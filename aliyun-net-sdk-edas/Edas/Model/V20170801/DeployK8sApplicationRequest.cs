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
    public class DeployK8sApplicationRequest : RoaAcsRequest<DeployK8sApplicationResponse>
    {
        public DeployK8sApplicationRequest()
            : base("Edas", "2017-08-01", "DeployK8sApplication", "Edas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Edas.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Edas.Endpoint.endpointRegionalType, null);
            }
			UriPattern = "/pop/v5/k8s/acs/k8s_apps";
			Method = MethodType.POST;
        }

		private string nasId;

		private string webContainer;

		private bool? enableAhas;

		private string slsConfigs;

		private string readiness;

		private string packageVersionId;

		private int? batchWaitTime;

		private string liveness;

		private string envs;

		private int? cpuLimit;

		private string packageVersion;

		private string storageType;

		private string envFroms;

		private string configMountDescs;

		private string edasContainerVersion;

		private string packageUrl;

		private int? memoryLimit;

		private string imageTag;

		private string deployAcrossZones;

		private string deployAcrossNodes;

		private int? memoryRequest;

		private string image;

		private string preStop;

		private string mountDescs;

		private int? replicas;

		private int? cpuRequest;

		private string webContainerConfig;

		private string localVolume;

		private string command;

		private string updateStrategy;

		private string args;

		private string jDK;

		private bool? useBodyEncoding;

		private string changeOrderDesc;

		private string uriEncoding;

		private string appId;

		private int? batchTimeout;

		private string pvcMountDescs;

		private string emptyDirs;

		private int? mcpuRequest;

		private int? mcpuLimit;

		private string volumesStr;

		private string runtimeClassName;

		private string trafficControlStrategy;

		private string postStart;

		private string javaStartUpConfig;

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

		public bool? EnableAhas
		{
			get
			{
				return enableAhas;
			}
			set	
			{
				enableAhas = value;
				DictionaryUtil.Add(QueryParameters, "EnableAhas", value.ToString());
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

		public string PackageVersionId
		{
			get
			{
				return packageVersionId;
			}
			set	
			{
				packageVersionId = value;
				DictionaryUtil.Add(QueryParameters, "PackageVersionId", value);
			}
		}

		public int? BatchWaitTime
		{
			get
			{
				return batchWaitTime;
			}
			set	
			{
				batchWaitTime = value;
				DictionaryUtil.Add(QueryParameters, "BatchWaitTime", value.ToString());
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

		public int? CpuLimit
		{
			get
			{
				return cpuLimit;
			}
			set	
			{
				cpuLimit = value;
				DictionaryUtil.Add(QueryParameters, "CpuLimit", value.ToString());
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

		public string StorageType
		{
			get
			{
				return storageType;
			}
			set	
			{
				storageType = value;
				DictionaryUtil.Add(QueryParameters, "StorageType", value);
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
				DictionaryUtil.Add(QueryParameters, "EnvFroms", value);
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
				DictionaryUtil.Add(QueryParameters, "ConfigMountDescs", value);
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

		public int? MemoryLimit
		{
			get
			{
				return memoryLimit;
			}
			set	
			{
				memoryLimit = value;
				DictionaryUtil.Add(QueryParameters, "MemoryLimit", value.ToString());
			}
		}

		public string ImageTag
		{
			get
			{
				return imageTag;
			}
			set	
			{
				imageTag = value;
				DictionaryUtil.Add(QueryParameters, "ImageTag", value);
			}
		}

		public string DeployAcrossZones
		{
			get
			{
				return deployAcrossZones;
			}
			set	
			{
				deployAcrossZones = value;
				DictionaryUtil.Add(QueryParameters, "DeployAcrossZones", value);
			}
		}

		public string DeployAcrossNodes
		{
			get
			{
				return deployAcrossNodes;
			}
			set	
			{
				deployAcrossNodes = value;
				DictionaryUtil.Add(QueryParameters, "DeployAcrossNodes", value);
			}
		}

		public int? MemoryRequest
		{
			get
			{
				return memoryRequest;
			}
			set	
			{
				memoryRequest = value;
				DictionaryUtil.Add(QueryParameters, "MemoryRequest", value.ToString());
			}
		}

		public string Image
		{
			get
			{
				return image;
			}
			set	
			{
				image = value;
				DictionaryUtil.Add(QueryParameters, "Image", value);
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

		public string MountDescs
		{
			get
			{
				return mountDescs;
			}
			set	
			{
				mountDescs = value;
				DictionaryUtil.Add(QueryParameters, "MountDescs", value);
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

		public int? CpuRequest
		{
			get
			{
				return cpuRequest;
			}
			set	
			{
				cpuRequest = value;
				DictionaryUtil.Add(QueryParameters, "CpuRequest", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "WebContainerConfig", value);
			}
		}

		public string LocalVolume
		{
			get
			{
				return localVolume;
			}
			set	
			{
				localVolume = value;
				DictionaryUtil.Add(QueryParameters, "LocalVolume", value);
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

		public string UpdateStrategy
		{
			get
			{
				return updateStrategy;
			}
			set	
			{
				updateStrategy = value;
				DictionaryUtil.Add(QueryParameters, "UpdateStrategy", value);
			}
		}

		public string Args
		{
			get
			{
				return args;
			}
			set	
			{
				args = value;
				DictionaryUtil.Add(QueryParameters, "Args", value);
			}
		}

		public string JDK
		{
			get
			{
				return jDK;
			}
			set	
			{
				jDK = value;
				DictionaryUtil.Add(QueryParameters, "JDK", value);
			}
		}

		public bool? UseBodyEncoding
		{
			get
			{
				return useBodyEncoding;
			}
			set	
			{
				useBodyEncoding = value;
				DictionaryUtil.Add(QueryParameters, "UseBodyEncoding", value.ToString());
			}
		}

		public string ChangeOrderDesc
		{
			get
			{
				return changeOrderDesc;
			}
			set	
			{
				changeOrderDesc = value;
				DictionaryUtil.Add(QueryParameters, "ChangeOrderDesc", value);
			}
		}

		public string UriEncoding
		{
			get
			{
				return uriEncoding;
			}
			set	
			{
				uriEncoding = value;
				DictionaryUtil.Add(QueryParameters, "UriEncoding", value);
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

		public int? BatchTimeout
		{
			get
			{
				return batchTimeout;
			}
			set	
			{
				batchTimeout = value;
				DictionaryUtil.Add(QueryParameters, "BatchTimeout", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "PvcMountDescs", value);
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
				DictionaryUtil.Add(QueryParameters, "EmptyDirs", value);
			}
		}

		public int? McpuRequest
		{
			get
			{
				return mcpuRequest;
			}
			set	
			{
				mcpuRequest = value;
				DictionaryUtil.Add(QueryParameters, "McpuRequest", value.ToString());
			}
		}

		public int? McpuLimit
		{
			get
			{
				return mcpuLimit;
			}
			set	
			{
				mcpuLimit = value;
				DictionaryUtil.Add(QueryParameters, "McpuLimit", value.ToString());
			}
		}

		public string VolumesStr
		{
			get
			{
				return volumesStr;
			}
			set	
			{
				volumesStr = value;
				DictionaryUtil.Add(QueryParameters, "VolumesStr", value);
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
				DictionaryUtil.Add(QueryParameters, "RuntimeClassName", value);
			}
		}

		public string TrafficControlStrategy
		{
			get
			{
				return trafficControlStrategy;
			}
			set	
			{
				trafficControlStrategy = value;
				DictionaryUtil.Add(QueryParameters, "TrafficControlStrategy", value);
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

		public string JavaStartUpConfig
		{
			get
			{
				return javaStartUpConfig;
			}
			set	
			{
				javaStartUpConfig = value;
				DictionaryUtil.Add(QueryParameters, "JavaStartUpConfig", value);
			}
		}

        public override DeployK8sApplicationResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DeployK8sApplicationResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
