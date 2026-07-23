using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Utils;
using Newtonsoft.Json;

namespace Aliyun.Acs.Core.Auth.Provider
{
    /// <summary>
    /// Obtain the credential information from a configuration file. The path of the configuration file varies based on the operating system:
    /// <list type="bullet">
    /// <item><description>Linux: ~/.aliyun/config.json</description></item>
    /// <item><description>Windows: C:\Users\USER_NAME\.aliyun\config.json</description></item>
    /// </list>
    /// </summary>
    public class CLIProfileCredentialsProvider : AlibabaCloudCredentialsProvider
    {
        private readonly string CLI_CREDENTIALS_CONFIG_PATH = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), ".aliyun", "config.json");
        private volatile AlibabaCloudCredentialsProvider credentialsProvider;
        private volatile string currentProfileName;
        private readonly object credentialsProviderLock = new object();

        public CLIProfileCredentialsProvider(string profileName = null)
        {
            currentProfileName = profileName ?? Environment.GetEnvironmentVariable("ALIBABA_CLOUD_PROFILE");
        }

        public AlibabaCloudCredentials GetCredentials()
        {
            if (AuthUtils.EnvironmentDisableCLIProfile)
            {
                throw new ClientException("CLI credentials file is disabled.");
            }
            var config = ParseProfile(CLI_CREDENTIALS_CONFIG_PATH);
            if (config == null)
            {
                throw new ClientException("Unable to get profile form empty CLI credentials file.");
            }
            var refreshedProfileName = Environment.GetEnvironmentVariable("ALIBABA_CLOUD_PROFILE");

            if (ShouldReloadCredentialsProvider(refreshedProfileName))
            {
                lock (credentialsProviderLock)
                {
                    if (ShouldReloadCredentialsProvider(refreshedProfileName))
                    {
                        if (!string.IsNullOrEmpty(refreshedProfileName))
                        {
                            this.currentProfileName = refreshedProfileName;
                        }
                        this.credentialsProvider = ReloadCredentialsProvider(config, this.currentProfileName);
                    }
                }
            }
            return this.credentialsProvider.GetCredentials();
        }
        
        internal AlibabaCloudCredentials GetCredentials(string path)
        {
            if (AuthUtils.EnvironmentDisableCLIProfile)
            {
                throw new ClientException("CLI credentials file is disabled.");
            }
            var config = ParseProfile(path);
            if (config == null)
            {
                throw new ClientException("Unable to get profile form empty CLI credentials file.");
            }
            var refreshedProfileName = Environment.GetEnvironmentVariable("ALIBABA_CLOUD_PROFILE");

            if (ShouldReloadCredentialsProvider(refreshedProfileName))
            {
                lock (credentialsProviderLock)
                {
                    if (ShouldReloadCredentialsProvider(refreshedProfileName))
                    {
                        if (!string.IsNullOrEmpty(refreshedProfileName))
                        {
                            this.currentProfileName = refreshedProfileName;
                        }
                        this.credentialsProvider = ReloadCredentialsProvider(config, this.currentProfileName);
                    }
                }
            }
            return this.credentialsProvider.GetCredentials();
        }

        internal string GetProfileName()
        {
            return this.currentProfileName;
        }

        internal AlibabaCloudCredentialsProvider ReloadCredentialsProvider(Config config, string profileName)
        {
            var currentProfileName = !string.IsNullOrEmpty(profileName) ? profileName : config.GetCurrent();
            var profiles = config.GetProfiles();
            if (profiles != null && profiles.Count > 0)
            {
                foreach (var profile in profiles)
                {
                    if (!string.IsNullOrEmpty(profile.GetName()) && profile.GetName().Equals(currentProfileName))
                    {
                        switch (profile.GetMode())
                        {
                            case "AK":
                                return new StaticCredentialsProvider(new BasicCredentials(profile.GetAccessKeyId(), profile.GetAccessKeySecret()));
                            case "RamRoleArn":
                                AlibabaCloudCredentialsProvider innerProvider =
                                    new StaticCredentialsProvider(new BasicCredentials(profile.GetAccessKeyId(),
                                        profile.GetAccessKeySecret()));
                                return new STSAssumeRoleSessionCredentialsProvider.Builder()
                                    .CredentialsProvider(innerProvider)
                                    .RoleArn(profile.GetRoleArn())
                                    .DurationSeconds(profile.GetDurationSeconds())
                                    .RoleSessionName(profile.GetRoleSessionName())
                                    .StsRegionId(profile.GetStsRegionId())
                                    .EnableVpc(profile.GetEnableVpc())
                                    .Policy(profile.GetPolicy())
                                    .ExternalId(profile.GetExternalId())
                                    .Build();
                            case "EcsRamRole":
                                return new InstanceProfileCredentialsProvider.Builder().RoleName(profile.GetRamRoleName()).Build();
                            case "OIDC":
                                return new OIDCCredentialsProvider.Builder()
                                    .DurationSeconds(profile.GetDurationSeconds())
                                    .RoleArn(profile.GetRoleArn())
                                    .RoleSessionName(profile.GetRoleSessionName())
                                    .OIDCProviderArn(profile.GetOidcProviderArn())
                                    .OIDCTokenFilePath(profile.GetOidcTokenFile())
                                    .StsRegionId(profile.GetStsRegionId())
                                    .Policy(profile.GetPolicy())
                                    .EnableVpc(profile.GetEnableVpc())
                                    .Build();
                            case "ChainableRamRoleArn":
                                if (profile.GetSourceProfile() == profile.GetName())
                                {
                                    throw new ClientException("Source profile name can not be the same as profile name.");
                                }
                                var previousProvider = ReloadCredentialsProvider(config, profile.GetSourceProfile());
                                return new STSAssumeRoleSessionCredentialsProvider.Builder()
                                    .CredentialsProvider(previousProvider)
                                    .RoleArn(profile.GetRoleArn())
                                    .DurationSeconds(profile.GetDurationSeconds())
                                    .RoleSessionName(profile.GetRoleSessionName())
                                    .StsRegionId(profile.GetStsRegionId())
                                    .EnableVpc(profile.GetEnableVpc())
                                    .Policy(profile.GetPolicy())
                                    .ExternalId(profile.GetExternalId())
                                    .Build();
                            default:
                                throw new ClientException(string.Format("Unsupported profile mode '{0}' form CLI credentials file.", profile.GetMode()));
                        }
                    }
                }
            }
            throw new ClientException(string.Format("Unable to get profile with '{0}' form CLI credentials file.", currentProfileName));
        }

        internal Config ParseProfile(string configFilePath)
        {
            FileInfo configFile = new FileInfo(configFilePath);
            if (!configFile.Exists || !configFile.Attributes.HasFlag(FileAttributes.Normal) || !IsFileReadable(configFile))
            {
                throw new ClientException(string.Format("Unable to open credentials file: {0}.", configFile.FullName));
            }

            try
            {
                using (StreamReader sr = new StreamReader(configFile.FullName))
                {
                    StringBuilder sb = new StringBuilder();
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        sb.Append(line);
                    }

                    var jsonContent = sb.ToString();
                    return JsonConvert.DeserializeObject<Config>(jsonContent);
                }
            }
            catch (Exception)
            {
                throw new ClientException(string.Format("Failed to parse credential from CLI credentials file: {0}.", configFile.FullName));
            }
        }

        private static bool IsFileReadable(FileInfo fileInfo)
        {
            try
            {
                using (FileStream stream = fileInfo.OpenRead())
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        internal bool ShouldReloadCredentialsProvider(string profileName)
        {
            return credentialsProvider == null || (!string.IsNullOrEmpty(currentProfileName) && !string.IsNullOrEmpty(profileName) && !currentProfileName.Equals(profileName));
        }

        internal class Config
        {
            [JsonProperty("current")]
            private readonly string current;
            [JsonProperty("profiles")]
            private readonly List<Profile> profiles;

            public string GetCurrent()
            {
                return current;
            }

            public List<Profile> GetProfiles()
            {
                return profiles;
            }
        }

        internal class Profile
        {
            [JsonProperty("name")]
            private readonly string name;
            [JsonProperty("mode")]
            private readonly string mode;
            [JsonProperty("access_key_id")]
            private readonly string accessKeyId;
            [JsonProperty("access_key_secret")]
            private readonly string accessKeySecret;
            [JsonProperty("ram_role_arn")]
            private readonly string roleArn;
            [JsonProperty("ram_session_name")]
            private readonly string roleSessionName;
            [JsonProperty("expired_seconds")]
            private readonly int? durationSeconds;
            [JsonProperty("sts_region")]
            private readonly string stsRegionId;
            [JsonProperty("ram_role_name")]
            private readonly string ramRoleName;
            [JsonProperty("oidc_token_file")]
            private readonly string oidcTokenFile;
            [JsonProperty("oidc_provider_arn")]
            private readonly string oidcProviderArn;
            [JsonProperty("source_profile")]
            private readonly string sourceProfile;
            [JsonProperty("policy")]
            private readonly string policy;
            [JsonProperty("region_id")]
            private readonly string regionId;
            [JsonProperty("enable_vpc")]
            private readonly bool? enableVpc;
            [JsonProperty("external_id")]
            private readonly string externalId;

            public string GetName()
            {
                return name;
            }
            public string GetMode()
            {
                return mode;
            }

            public string GetAccessKeyId()
            {
                return accessKeyId;
            }

            public string GetAccessKeySecret()
            {
                return accessKeySecret;
            }

            public string GetRoleArn()
            {
                return roleArn;
            }

            public string GetRoleSessionName()
            {
                return roleSessionName;
            }

            public int? GetDurationSeconds()
            {
                return durationSeconds;
            }

            public string GetStsRegionId()
            {
                return stsRegionId;
            }

            public string GetRamRoleName()
            {
                return ramRoleName;
            }

            public string GetOidcTokenFile()
            {
                return oidcTokenFile;
            }

            public string GetOidcProviderArn()
            {
                return oidcProviderArn;
            }

            public string GetSourceProfile()
            {
                return sourceProfile;
            }

            public string GetPolicy()
            {
                return policy;
            }

            public string GetRegionId()
            {
                return regionId;
            }

            public bool? GetEnableVpc()
            {
                return enableVpc;
            }

            public string GetExternalId()
            {
                return externalId;
            }
        }
    }
}
