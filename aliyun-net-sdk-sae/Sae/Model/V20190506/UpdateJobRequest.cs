/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.sae.Transform;
using Aliyun.Acs.sae.Transform.V20190506;

namespace Aliyun.Acs.sae.Model.V20190506
{
    public class UpdateJobRequest : RoaAcsRequest<UpdateJobResponse>
    {
        public UpdateJobRequest()
            : base("sae", "2019-05-06", "UpdateJob", "serverless", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.sae.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.sae.Endpoint.endpointRegionalType, null);
            }
			UriPattern = "/pop/v1/sam/job/updateJob";
			Method = MethodType.POST;
        }

		private string nasId;

		private string jarStartArgs;

		private string concurrencyPolicy;

		private string triggerConfig;

		private string ossAkSecret;

		private string mountHost;

		private string envs;

		private string programmingLanguage;

		private string customHostAlias;

		private string jarStartOptions;

		private bool? slice;

		private string configMapMountDesc;

		private string ossMountDescs;

		private string imagePullSecrets;

		private string preStop;

		private string python;

		private long? backoffLimit;

		private string postStart;

		private string webContainer;

		private string slsConfigs;

		private string commandArgs;

		private string acrAssumeRoleArn;

		private string timezone;

		private string ossAkId;

		private string packageVersion;

		private string tomcatConfig;

		private long? timeout;

		private string warStartOptions;

		private string edasContainerVersion;

		private string packageUrl;

		private int? terminationGracePeriodSeconds;

		private string phpConfig;

		private string sliceEnvs;

		private bool? enableImageAccl;

		private string replicas;

		private string command;

		private string mountDesc;

		private string jdk;

		private string acrInstanceId;

		private string appId;

		private string imageUrl;

		private string php;

		private string refAppId;

		private string pythonModules;

		private string phpConfigLocation;

		public string NasId
		{
			get
			{
				return nasId;
			}
			set	
			{
				nasId = value;
				DictionaryUtil.Add(QueryParameters, "NasId", value);
			}
		}

		public string JarStartArgs
		{
			get
			{
				return jarStartArgs;
			}
			set	
			{
				jarStartArgs = value;
				DictionaryUtil.Add(QueryParameters, "JarStartArgs", value);
			}
		}

		public string ConcurrencyPolicy
		{
			get
			{
				return concurrencyPolicy;
			}
			set	
			{
				concurrencyPolicy = value;
				DictionaryUtil.Add(QueryParameters, "ConcurrencyPolicy", value);
			}
		}

		public string TriggerConfig
		{
			get
			{
				return triggerConfig;
			}
			set	
			{
				triggerConfig = value;
				DictionaryUtil.Add(QueryParameters, "TriggerConfig", value);
			}
		}

		public string OssAkSecret
		{
			get
			{
				return ossAkSecret;
			}
			set	
			{
				ossAkSecret = value;
				DictionaryUtil.Add(BodyParameters, "OssAkSecret", value);
			}
		}

		public string MountHost
		{
			get
			{
				return mountHost;
			}
			set	
			{
				mountHost = value;
				DictionaryUtil.Add(QueryParameters, "MountHost", value);
			}
		}

		public string Envs
		{
			get
			{
				return envs;
			}
			set	
			{
				envs = value;
				DictionaryUtil.Add(QueryParameters, "Envs", value);
			}
		}

		public string ProgrammingLanguage
		{
			get
			{
				return programmingLanguage;
			}
			set	
			{
				programmingLanguage = value;
				DictionaryUtil.Add(QueryParameters, "ProgrammingLanguage", value);
			}
		}

		public string CustomHostAlias
		{
			get
			{
				return customHostAlias;
			}
			set	
			{
				customHostAlias = value;
				DictionaryUtil.Add(QueryParameters, "CustomHostAlias", value);
			}
		}

		public string JarStartOptions
		{
			get
			{
				return jarStartOptions;
			}
			set	
			{
				jarStartOptions = value;
				DictionaryUtil.Add(QueryParameters, "JarStartOptions", value);
			}
		}

		public bool? Slice
		{
			get
			{
				return slice;
			}
			set	
			{
				slice = value;
				DictionaryUtil.Add(QueryParameters, "Slice", value.ToString());
			}
		}

		public string ConfigMapMountDesc
		{
			get
			{
				return configMapMountDesc;
			}
			set	
			{
				configMapMountDesc = value;
				DictionaryUtil.Add(BodyParameters, "ConfigMapMountDesc", value);
			}
		}

		public string OssMountDescs
		{
			get
			{
				return ossMountDescs;
			}
			set	
			{
				ossMountDescs = value;
				DictionaryUtil.Add(BodyParameters, "OssMountDescs", value);
			}
		}

		public string ImagePullSecrets
		{
			get
			{
				return imagePullSecrets;
			}
			set	
			{
				imagePullSecrets = value;
				DictionaryUtil.Add(QueryParameters, "ImagePullSecrets", value);
			}
		}

		public string PreStop
		{
			get
			{
				return preStop;
			}
			set	
			{
				preStop = value;
				DictionaryUtil.Add(QueryParameters, "PreStop", value);
			}
		}

		public string Python
		{
			get
			{
				return python;
			}
			set	
			{
				python = value;
				DictionaryUtil.Add(QueryParameters, "Python", value);
			}
		}

		public long? BackoffLimit
		{
			get
			{
				return backoffLimit;
			}
			set	
			{
				backoffLimit = value;
				DictionaryUtil.Add(QueryParameters, "BackoffLimit", value.ToString());
			}
		}

		public string PostStart
		{
			get
			{
				return postStart;
			}
			set	
			{
				postStart = value;
				DictionaryUtil.Add(QueryParameters, "PostStart", value);
			}
		}

		public string WebContainer
		{
			get
			{
				return webContainer;
			}
			set	
			{
				webContainer = value;
				DictionaryUtil.Add(QueryParameters, "WebContainer", value);
			}
		}

		public string SlsConfigs
		{
			get
			{
				return slsConfigs;
			}
			set	
			{
				slsConfigs = value;
				DictionaryUtil.Add(QueryParameters, "SlsConfigs", value);
			}
		}

		public string CommandArgs
		{
			get
			{
				return commandArgs;
			}
			set	
			{
				commandArgs = value;
				DictionaryUtil.Add(QueryParameters, "CommandArgs", value);
			}
		}

		public string AcrAssumeRoleArn
		{
			get
			{
				return acrAssumeRoleArn;
			}
			set	
			{
				acrAssumeRoleArn = value;
				DictionaryUtil.Add(QueryParameters, "AcrAssumeRoleArn", value);
			}
		}

		public string Timezone
		{
			get
			{
				return timezone;
			}
			set	
			{
				timezone = value;
				DictionaryUtil.Add(QueryParameters, "Timezone", value);
			}
		}

		public string OssAkId
		{
			get
			{
				return ossAkId;
			}
			set	
			{
				ossAkId = value;
				DictionaryUtil.Add(BodyParameters, "OssAkId", value);
			}
		}

		public string PackageVersion
		{
			get
			{
				return packageVersion;
			}
			set	
			{
				packageVersion = value;
				DictionaryUtil.Add(QueryParameters, "PackageVersion", value);
			}
		}

		public string TomcatConfig
		{
			get
			{
				return tomcatConfig;
			}
			set	
			{
				tomcatConfig = value;
				DictionaryUtil.Add(QueryParameters, "TomcatConfig", value);
			}
		}

		public long? Timeout
		{
			get
			{
				return timeout;
			}
			set	
			{
				timeout = value;
				DictionaryUtil.Add(QueryParameters, "Timeout", value.ToString());
			}
		}

		public string WarStartOptions
		{
			get
			{
				return warStartOptions;
			}
			set	
			{
				warStartOptions = value;
				DictionaryUtil.Add(QueryParameters, "WarStartOptions", value);
			}
		}

		public string EdasContainerVersion
		{
			get
			{
				return edasContainerVersion;
			}
			set	
			{
				edasContainerVersion = value;
				DictionaryUtil.Add(QueryParameters, "EdasContainerVersion", value);
			}
		}

		public string PackageUrl
		{
			get
			{
				return packageUrl;
			}
			set	
			{
				packageUrl = value;
				DictionaryUtil.Add(QueryParameters, "PackageUrl", value);
			}
		}

		public int? TerminationGracePeriodSeconds
		{
			get
			{
				return terminationGracePeriodSeconds;
			}
			set	
			{
				terminationGracePeriodSeconds = value;
				DictionaryUtil.Add(QueryParameters, "TerminationGracePeriodSeconds", value.ToString());
			}
		}

		public string PhpConfig
		{
			get
			{
				return phpConfig;
			}
			set	
			{
				phpConfig = value;
				DictionaryUtil.Add(BodyParameters, "PhpConfig", value);
			}
		}

		public string SliceEnvs
		{
			get
			{
				return sliceEnvs;
			}
			set	
			{
				sliceEnvs = value;
				DictionaryUtil.Add(QueryParameters, "SliceEnvs", value);
			}
		}

		public bool? EnableImageAccl
		{
			get
			{
				return enableImageAccl;
			}
			set	
			{
				enableImageAccl = value;
				DictionaryUtil.Add(BodyParameters, "EnableImageAccl", value.ToString());
			}
		}

		public string Replicas
		{
			get
			{
				return replicas;
			}
			set	
			{
				replicas = value;
				DictionaryUtil.Add(QueryParameters, "Replicas", value);
			}
		}

		public string Command
		{
			get
			{
				return command;
			}
			set	
			{
				command = value;
				DictionaryUtil.Add(QueryParameters, "Command", value);
			}
		}

		public string MountDesc
		{
			get
			{
				return mountDesc;
			}
			set	
			{
				mountDesc = value;
				DictionaryUtil.Add(QueryParameters, "MountDesc", value);
			}
		}

		public string Jdk
		{
			get
			{
				return jdk;
			}
			set	
			{
				jdk = value;
				DictionaryUtil.Add(QueryParameters, "Jdk", value);
			}
		}

		public string AcrInstanceId
		{
			get
			{
				return acrInstanceId;
			}
			set	
			{
				acrInstanceId = value;
				DictionaryUtil.Add(BodyParameters, "AcrInstanceId", value);
			}
		}

		public string AppId
		{
			get
			{
				return appId;
			}
			set	
			{
				appId = value;
				DictionaryUtil.Add(QueryParameters, "AppId", value);
			}
		}

		public string ImageUrl
		{
			get
			{
				return imageUrl;
			}
			set	
			{
				imageUrl = value;
				DictionaryUtil.Add(QueryParameters, "ImageUrl", value);
			}
		}

		public string Php
		{
			get
			{
				return php;
			}
			set	
			{
				php = value;
				DictionaryUtil.Add(BodyParameters, "Php", value);
			}
		}

		public string RefAppId
		{
			get
			{
				return refAppId;
			}
			set	
			{
				refAppId = value;
				DictionaryUtil.Add(QueryParameters, "RefAppId", value);
			}
		}

		public string PythonModules
		{
			get
			{
				return pythonModules;
			}
			set	
			{
				pythonModules = value;
				DictionaryUtil.Add(QueryParameters, "PythonModules", value);
			}
		}

		public string PhpConfigLocation
		{
			get
			{
				return phpConfigLocation;
			}
			set	
			{
				phpConfigLocation = value;
				DictionaryUtil.Add(QueryParameters, "PhpConfigLocation", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateJobResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateJobResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
