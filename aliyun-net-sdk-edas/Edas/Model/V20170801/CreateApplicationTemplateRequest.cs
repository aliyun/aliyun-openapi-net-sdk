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
using Aliyun.Acs.Edas.Transform;
using Aliyun.Acs.Edas.Transform.V20170801;

namespace Aliyun.Acs.Edas.Model.V20170801
{
    public class CreateApplicationTemplateRequest : RoaAcsRequest<CreateApplicationTemplateResponse>
    {
        public CreateApplicationTemplateRequest()
            : base("Edas", "2017-08-01", "CreateApplicationTemplate", "Edas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Edas.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Edas.Endpoint.endpointRegionalType, null);
            }
			UriPattern = "/pop/v5/cnedas/app_template";
			Method = MethodType.POST;
        }

		private string nasId;

		private bool? enableAhas;

		private string slsConfigs;

		private string commandArgs;

		private string readiness;

		private string liveness;

		private string description;

		private string envs;

		private string envFroms;

		private string requestCpu;

		private string requestMem;

		private string showName;

		private string limitMem;

		private string configMountDescs;

		private bool? deployAcrossZones;

		private bool? deployAcrossNodes;

		private string preStop;

		private long? replicas;

		private string limitCpu;

		private string webContainerConfig;

		private string packageConfig;

		private bool? isMultilingualApp;

		private string nasMountDescs;

		private string localVolumes;

		private string command;

		private string nasStorageType;

		private string imageConfig;

		private string sourceConfig;

		private string emptyDirs;

		private string pvcMountDescs;

		private string name;

		private string attributes;

		private string runtimeClassName;

		private string javaStartUpConfig;

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
				DictionaryUtil.Add(BodyParameters, "NasId", value);
			}
		}

		public bool? EnableAhas
		{
			get
			{
				return enableAhas;
			}
			set	
			{
				enableAhas = value;
				DictionaryUtil.Add(BodyParameters, "EnableAhas", value.ToString());
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
				DictionaryUtil.Add(BodyParameters, "SlsConfigs", value);
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
				DictionaryUtil.Add(BodyParameters, "CommandArgs", value);
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
				DictionaryUtil.Add(BodyParameters, "Readiness", value);
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
				DictionaryUtil.Add(BodyParameters, "Liveness", value);
			}
		}

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(BodyParameters, "Description", value);
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
				DictionaryUtil.Add(BodyParameters, "Envs", value);
			}
		}

		public string EnvFroms
		{
			get
			{
				return envFroms;
			}
			set	
			{
				envFroms = value;
				DictionaryUtil.Add(BodyParameters, "EnvFroms", value);
			}
		}

		public string RequestCpu
		{
			get
			{
				return requestCpu;
			}
			set	
			{
				requestCpu = value;
				DictionaryUtil.Add(BodyParameters, "RequestCpu", value);
			}
		}

		public string RequestMem
		{
			get
			{
				return requestMem;
			}
			set	
			{
				requestMem = value;
				DictionaryUtil.Add(BodyParameters, "RequestMem", value);
			}
		}

		public string ShowName
		{
			get
			{
				return showName;
			}
			set	
			{
				showName = value;
				DictionaryUtil.Add(BodyParameters, "ShowName", value);
			}
		}

		public string LimitMem
		{
			get
			{
				return limitMem;
			}
			set	
			{
				limitMem = value;
				DictionaryUtil.Add(BodyParameters, "LimitMem", value);
			}
		}

		public string ConfigMountDescs
		{
			get
			{
				return configMountDescs;
			}
			set	
			{
				configMountDescs = value;
				DictionaryUtil.Add(BodyParameters, "ConfigMountDescs", value);
			}
		}

		public bool? DeployAcrossZones
		{
			get
			{
				return deployAcrossZones;
			}
			set	
			{
				deployAcrossZones = value;
				DictionaryUtil.Add(BodyParameters, "DeployAcrossZones", value.ToString());
			}
		}

		public bool? DeployAcrossNodes
		{
			get
			{
				return deployAcrossNodes;
			}
			set	
			{
				deployAcrossNodes = value;
				DictionaryUtil.Add(BodyParameters, "DeployAcrossNodes", value.ToString());
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
				DictionaryUtil.Add(BodyParameters, "PreStop", value);
			}
		}

		public long? Replicas
		{
			get
			{
				return replicas;
			}
			set	
			{
				replicas = value;
				DictionaryUtil.Add(BodyParameters, "Replicas", value.ToString());
			}
		}

		public string LimitCpu
		{
			get
			{
				return limitCpu;
			}
			set	
			{
				limitCpu = value;
				DictionaryUtil.Add(BodyParameters, "LimitCpu", value);
			}
		}

		public string WebContainerConfig
		{
			get
			{
				return webContainerConfig;
			}
			set	
			{
				webContainerConfig = value;
				DictionaryUtil.Add(BodyParameters, "WebContainerConfig", value);
			}
		}

		public string PackageConfig
		{
			get
			{
				return packageConfig;
			}
			set	
			{
				packageConfig = value;
				DictionaryUtil.Add(BodyParameters, "PackageConfig", value);
			}
		}

		public bool? IsMultilingualApp
		{
			get
			{
				return isMultilingualApp;
			}
			set	
			{
				isMultilingualApp = value;
				DictionaryUtil.Add(BodyParameters, "IsMultilingualApp", value.ToString());
			}
		}

		public string NasMountDescs
		{
			get
			{
				return nasMountDescs;
			}
			set	
			{
				nasMountDescs = value;
				DictionaryUtil.Add(BodyParameters, "NasMountDescs", value);
			}
		}

		public string LocalVolumes
		{
			get
			{
				return localVolumes;
			}
			set	
			{
				localVolumes = value;
				DictionaryUtil.Add(BodyParameters, "LocalVolumes", value);
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
				DictionaryUtil.Add(BodyParameters, "Command", value);
			}
		}

		public string NasStorageType
		{
			get
			{
				return nasStorageType;
			}
			set	
			{
				nasStorageType = value;
				DictionaryUtil.Add(BodyParameters, "NasStorageType", value);
			}
		}

		public string ImageConfig
		{
			get
			{
				return imageConfig;
			}
			set	
			{
				imageConfig = value;
				DictionaryUtil.Add(BodyParameters, "ImageConfig", value);
			}
		}

		public string SourceConfig
		{
			get
			{
				return sourceConfig;
			}
			set	
			{
				sourceConfig = value;
				DictionaryUtil.Add(BodyParameters, "SourceConfig", value);
			}
		}

		public string EmptyDirs
		{
			get
			{
				return emptyDirs;
			}
			set	
			{
				emptyDirs = value;
				DictionaryUtil.Add(BodyParameters, "EmptyDirs", value);
			}
		}

		public string PvcMountDescs
		{
			get
			{
				return pvcMountDescs;
			}
			set	
			{
				pvcMountDescs = value;
				DictionaryUtil.Add(BodyParameters, "PvcMountDescs", value);
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(BodyParameters, "Name", value);
			}
		}

		public string Attributes
		{
			get
			{
				return attributes;
			}
			set	
			{
				attributes = value;
				DictionaryUtil.Add(BodyParameters, "Attributes", value);
			}
		}

		public string RuntimeClassName
		{
			get
			{
				return runtimeClassName;
			}
			set	
			{
				runtimeClassName = value;
				DictionaryUtil.Add(BodyParameters, "RuntimeClassName", value);
			}
		}

		public string JavaStartUpConfig
		{
			get
			{
				return javaStartUpConfig;
			}
			set	
			{
				javaStartUpConfig = value;
				DictionaryUtil.Add(BodyParameters, "JavaStartUpConfig", value);
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
				DictionaryUtil.Add(BodyParameters, "PostStart", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateApplicationTemplateResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateApplicationTemplateResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
