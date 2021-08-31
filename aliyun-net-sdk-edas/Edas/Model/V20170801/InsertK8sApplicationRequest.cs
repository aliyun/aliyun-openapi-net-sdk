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
    public class InsertK8sApplicationRequest : RoaAcsRequest<InsertK8sApplicationResponse>
    {
        public InsertK8sApplicationRequest()
            : base("Edas", "2017-08-01", "InsertK8sApplication", "Edas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Edas.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Edas.Endpoint.endpointRegionalType, null);
            }
			UriPattern = "/pop/v5/k8s/acs/create_k8s_app";
			Method = MethodType.POST;
        }

		private string nasId;

		private string intranetSlbId;

		private string envs;

		private int? requestsMem;

		private string storageType;

		private string configMountDescs;

		private string appName;

		private int? requestsmCpu;

		private string deployAcrossZones;

		private int? intranetSlbPort;

		private string deployAcrossNodes;

		private string preStop;

		private string buildPackId;

		private string localVolume;

		private bool? useBodyEncoding;

		private string emptyDirs;

		private string packageType;

		private string runtimeClassName;

		private string postStart;

		private string repoId;

		private int? internetTargetPort;

		private string webContainer;

		private bool? enableAsm;

		private bool? enableAhas;

		private string slsConfigs;

		private string commandArgs;

		private string readiness;

		private string liveness;

		private string csClusterId;

		private int? internetSlbPort;

		private string packageVersion;

		private int? timeout;

		private string envFroms;

		private int? limitMem;

		private int? limitmCpu;

		private string edasContainerVersion;

		private string internetSlbId;

		private string logicalRegionId;

		private string packageUrl;

		private string internetSlbProtocol;

		private string mountDescs;

		private int? replicas;

		private int? limitCpu;

		private string webContainerConfig;

		private bool? isMultilingualApp;

		private string clusterId;

		private int? intranetTargetPort;

		private string command;

		private string jDK;

		private string uriEncoding;

		private string intranetSlbProtocol;

		private string imageUrl;

		private string pvcMountDescs;

		private string _namespace;

		private string applicationDescription;

		private int? requestsCpu;

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

		public string IntranetSlbId
		{
			get
			{
				return intranetSlbId;
			}
			set	
			{
				intranetSlbId = value;
				DictionaryUtil.Add(QueryParameters, "IntranetSlbId", value);
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

		public int? RequestsMem
		{
			get
			{
				return requestsMem;
			}
			set	
			{
				requestsMem = value;
				DictionaryUtil.Add(QueryParameters, "RequestsMem", value.ToString());
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

		public int? RequestsmCpu
		{
			get
			{
				return requestsmCpu;
			}
			set	
			{
				requestsmCpu = value;
				DictionaryUtil.Add(QueryParameters, "RequestsmCpu", value.ToString());
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

		public int? IntranetSlbPort
		{
			get
			{
				return intranetSlbPort;
			}
			set	
			{
				intranetSlbPort = value;
				DictionaryUtil.Add(QueryParameters, "IntranetSlbPort", value.ToString());
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

		public string BuildPackId
		{
			get
			{
				return buildPackId;
			}
			set	
			{
				buildPackId = value;
				DictionaryUtil.Add(QueryParameters, "BuildPackId", value);
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

		public string RepoId
		{
			get
			{
				return repoId;
			}
			set	
			{
				repoId = value;
				DictionaryUtil.Add(QueryParameters, "RepoId", value);
			}
		}

		public int? InternetTargetPort
		{
			get
			{
				return internetTargetPort;
			}
			set	
			{
				internetTargetPort = value;
				DictionaryUtil.Add(QueryParameters, "InternetTargetPort", value.ToString());
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

		public bool? EnableAsm
		{
			get
			{
				return enableAsm;
			}
			set	
			{
				enableAsm = value;
				DictionaryUtil.Add(QueryParameters, "EnableAsm", value.ToString());
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

		public string CsClusterId
		{
			get
			{
				return csClusterId;
			}
			set	
			{
				csClusterId = value;
				DictionaryUtil.Add(QueryParameters, "CsClusterId", value);
			}
		}

		public int? InternetSlbPort
		{
			get
			{
				return internetSlbPort;
			}
			set	
			{
				internetSlbPort = value;
				DictionaryUtil.Add(QueryParameters, "InternetSlbPort", value.ToString());
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

		public int? Timeout
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

		public int? LimitMem
		{
			get
			{
				return limitMem;
			}
			set	
			{
				limitMem = value;
				DictionaryUtil.Add(QueryParameters, "LimitMem", value.ToString());
			}
		}

		public int? LimitmCpu
		{
			get
			{
				return limitmCpu;
			}
			set	
			{
				limitmCpu = value;
				DictionaryUtil.Add(QueryParameters, "LimitmCpu", value.ToString());
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

		public string InternetSlbId
		{
			get
			{
				return internetSlbId;
			}
			set	
			{
				internetSlbId = value;
				DictionaryUtil.Add(QueryParameters, "InternetSlbId", value);
			}
		}

		public string LogicalRegionId
		{
			get
			{
				return logicalRegionId;
			}
			set	
			{
				logicalRegionId = value;
				DictionaryUtil.Add(QueryParameters, "LogicalRegionId", value);
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

		public string InternetSlbProtocol
		{
			get
			{
				return internetSlbProtocol;
			}
			set	
			{
				internetSlbProtocol = value;
				DictionaryUtil.Add(QueryParameters, "InternetSlbProtocol", value);
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

		public int? LimitCpu
		{
			get
			{
				return limitCpu;
			}
			set	
			{
				limitCpu = value;
				DictionaryUtil.Add(QueryParameters, "LimitCpu", value.ToString());
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

		public bool? IsMultilingualApp
		{
			get
			{
				return isMultilingualApp;
			}
			set	
			{
				isMultilingualApp = value;
				DictionaryUtil.Add(QueryParameters, "IsMultilingualApp", value.ToString());
			}
		}

		public string ClusterId
		{
			get
			{
				return clusterId;
			}
			set	
			{
				clusterId = value;
				DictionaryUtil.Add(QueryParameters, "ClusterId", value);
			}
		}

		public int? IntranetTargetPort
		{
			get
			{
				return intranetTargetPort;
			}
			set	
			{
				intranetTargetPort = value;
				DictionaryUtil.Add(QueryParameters, "IntranetTargetPort", value.ToString());
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

		public string IntranetSlbProtocol
		{
			get
			{
				return intranetSlbProtocol;
			}
			set	
			{
				intranetSlbProtocol = value;
				DictionaryUtil.Add(QueryParameters, "IntranetSlbProtocol", value);
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

		public string _Namespace
		{
			get
			{
				return _namespace;
			}
			set	
			{
				_namespace = value;
				DictionaryUtil.Add(QueryParameters, "Namespace", value);
			}
		}

		public string ApplicationDescription
		{
			get
			{
				return applicationDescription;
			}
			set	
			{
				applicationDescription = value;
				DictionaryUtil.Add(QueryParameters, "ApplicationDescription", value);
			}
		}

		public int? RequestsCpu
		{
			get
			{
				return requestsCpu;
			}
			set	
			{
				requestsCpu = value;
				DictionaryUtil.Add(QueryParameters, "RequestsCpu", value.ToString());
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

        public override InsertK8sApplicationResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return InsertK8sApplicationResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
