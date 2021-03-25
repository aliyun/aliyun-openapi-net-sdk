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
    public class CreateApplicationRequest : RoaAcsRequest<CreateApplicationResponse>
    {
        public CreateApplicationRequest()
            : base("sae", "2019-05-06", "CreateApplication", "serverless", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.sae.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.sae.Endpoint.endpointRegionalType, null);
            }
			UriPattern = "/pop/v1/sam/app/createApplication";
			Method = MethodType.POST;
        }

		private string nasId;

		private string webContainer;

		private string jarStartArgs;

		private int? memory;

		private string slsConfigs;

		private string commandArgs;

		private string acrAssumeRoleArn;

		private string readiness;

		private string timezone;

		private string mountHost;

		private bool? autoConfig;

		private string liveness;

		private string securityGroupId;

		private string envs;

		private string phpArmsConfigLocation;

		private string packageVersion;

		private string tomcatConfig;

		private string customHostAlias;

		private bool? deploy;

		private string warStartOptions;

		private string jarStartOptions;

		private string edasContainerVersion;

		private string appName;

		private string namespaceId;

		private string packageUrl;

		private int? terminationGracePeriodSeconds;

		private string configMapMountDesc;

		private string phpConfig;

		private string preStop;

		private int? replicas;

		private int? cpu;

		private string command;

		private string mountDesc;

		private string vSwitchId;

		private string jdk;

		private string appDescription;

		private string vpcId;

		private string imageUrl;

		private string packageType;

		private string phpConfigLocation;

		private string postStart;

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

		public int? Memory
		{
			get
			{
				return memory;
			}
			set	
			{
				memory = value;
				DictionaryUtil.Add(QueryParameters, "Memory", value.ToString());
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

		public string Readiness
		{
			get
			{
				return readiness;
			}
			set	
			{
				readiness = value;
				DictionaryUtil.Add(QueryParameters, "Readiness", value);
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

		public bool? AutoConfig
		{
			get
			{
				return autoConfig;
			}
			set	
			{
				autoConfig = value;
				DictionaryUtil.Add(QueryParameters, "AutoConfig", value.ToString());
			}
		}

		public string Liveness
		{
			get
			{
				return liveness;
			}
			set	
			{
				liveness = value;
				DictionaryUtil.Add(QueryParameters, "Liveness", value);
			}
		}

		public string SecurityGroupId
		{
			get
			{
				return securityGroupId;
			}
			set	
			{
				securityGroupId = value;
				DictionaryUtil.Add(QueryParameters, "SecurityGroupId", value);
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

		public string PhpArmsConfigLocation
		{
			get
			{
				return phpArmsConfigLocation;
			}
			set	
			{
				phpArmsConfigLocation = value;
				DictionaryUtil.Add(QueryParameters, "PhpArmsConfigLocation", value);
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

		public bool? Deploy
		{
			get
			{
				return deploy;
			}
			set	
			{
				deploy = value;
				DictionaryUtil.Add(QueryParameters, "Deploy", value.ToString());
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

		public string AppName
		{
			get
			{
				return appName;
			}
			set	
			{
				appName = value;
				DictionaryUtil.Add(QueryParameters, "AppName", value);
			}
		}

		public string NamespaceId
		{
			get
			{
				return namespaceId;
			}
			set	
			{
				namespaceId = value;
				DictionaryUtil.Add(QueryParameters, "NamespaceId", value);
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

		public int? Replicas
		{
			get
			{
				return replicas;
			}
			set	
			{
				replicas = value;
				DictionaryUtil.Add(QueryParameters, "Replicas", value.ToString());
			}
		}

		public int? Cpu
		{
			get
			{
				return cpu;
			}
			set	
			{
				cpu = value;
				DictionaryUtil.Add(QueryParameters, "Cpu", value.ToString());
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

		public string VSwitchId
		{
			get
			{
				return vSwitchId;
			}
			set	
			{
				vSwitchId = value;
				DictionaryUtil.Add(QueryParameters, "VSwitchId", value);
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

		public string AppDescription
		{
			get
			{
				return appDescription;
			}
			set	
			{
				appDescription = value;
				DictionaryUtil.Add(QueryParameters, "AppDescription", value);
			}
		}

		public string VpcId
		{
			get
			{
				return vpcId;
			}
			set	
			{
				vpcId = value;
				DictionaryUtil.Add(QueryParameters, "VpcId", value);
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

		public string PackageType
		{
			get
			{
				return packageType;
			}
			set	
			{
				packageType = value;
				DictionaryUtil.Add(QueryParameters, "PackageType", value);
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateApplicationResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateApplicationResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
