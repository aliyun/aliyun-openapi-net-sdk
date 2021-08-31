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

namespace Aliyun.Acs.Edas.Model.V20170801
{
	public class GetK8sApplicationResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private GetK8sApplication_Applcation applcation;

		public int? Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public GetK8sApplication_Applcation Applcation
		{
			get
			{
				return applcation;
			}
			set	
			{
				applcation = value;
			}
		}

		public class GetK8sApplication_Applcation
		{

			private string appId;

			private List<GetK8sApplication_DeployGroup> deployGroups;

			private GetK8sApplication_ImageInfo imageInfo;

			private GetK8sApplication_App app;

			private GetK8sApplication_Conf conf;

			private GetK8sApplication_LatestVersion latestVersion;

			public string AppId
			{
				get
				{
					return appId;
				}
				set	
				{
					appId = value;
				}
			}

			public List<GetK8sApplication_DeployGroup> DeployGroups
			{
				get
				{
					return deployGroups;
				}
				set	
				{
					deployGroups = value;
				}
			}

			public GetK8sApplication_ImageInfo ImageInfo
			{
				get
				{
					return imageInfo;
				}
				set	
				{
					imageInfo = value;
				}
			}

			public GetK8sApplication_App App
			{
				get
				{
					return app;
				}
				set	
				{
					app = value;
				}
			}

			public GetK8sApplication_Conf Conf
			{
				get
				{
					return conf;
				}
				set	
				{
					conf = value;
				}
			}

			public GetK8sApplication_LatestVersion LatestVersion
			{
				get
				{
					return latestVersion;
				}
				set	
				{
					latestVersion = value;
				}
			}

			public class GetK8sApplication_DeployGroup
			{

				private List<GetK8sApplication_ComponentsItem> components;

				public List<GetK8sApplication_ComponentsItem> Components
				{
					get
					{
						return components;
					}
					set	
					{
						components = value;
					}
				}

				public class GetK8sApplication_ComponentsItem
				{

					private string componentId;

					private string componentKey;

					private string type;

					public string ComponentId
					{
						get
						{
							return componentId;
						}
						set	
						{
							componentId = value;
						}
					}

					public string ComponentKey
					{
						get
						{
							return componentKey;
						}
						set	
						{
							componentKey = value;
						}
					}

					public string Type
					{
						get
						{
							return type;
						}
						set	
						{
							type = value;
						}
					}
				}
			}

			public class GetK8sApplication_ImageInfo
			{

				private string imageUrl;

				private string repoName;

				private string regionId;

				private string repoId;

				private string repoNamespace;

				private string repoOriginType;

				private string tag;

				public string ImageUrl
				{
					get
					{
						return imageUrl;
					}
					set	
					{
						imageUrl = value;
					}
				}

				public string RepoName
				{
					get
					{
						return repoName;
					}
					set	
					{
						repoName = value;
					}
				}

				public string RegionId
				{
					get
					{
						return regionId;
					}
					set	
					{
						regionId = value;
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
					}
				}

				public string RepoNamespace
				{
					get
					{
						return repoNamespace;
					}
					set	
					{
						repoNamespace = value;
					}
				}

				public string RepoOriginType
				{
					get
					{
						return repoOriginType;
					}
					set	
					{
						repoOriginType = value;
					}
				}

				public string Tag
				{
					get
					{
						return tag;
					}
					set	
					{
						tag = value;
					}
				}
			}

			public class GetK8sApplication_App
			{

				private string applicationType;

				private string cmd;

				private string deployType;

				private string edasContainerVersion;

				private int? buildpackId;

				private string tomcatVersion;

				private int? instancesBeforeScaling;

				private string appId;

				private string applicationName;

				private string clusterId;

				private int? instances;

				private string csClusterId;

				private int? limitCpuM;

				private int? requestCpuM;

				private int? limitMem;

				private int? requestMem;

				private string k8sNamespace;

				private string regionId;

				private List<GetK8sApplication_Env> envList;

				private List<string> cmdArgs;

				public string ApplicationType
				{
					get
					{
						return applicationType;
					}
					set	
					{
						applicationType = value;
					}
				}

				public string Cmd
				{
					get
					{
						return cmd;
					}
					set	
					{
						cmd = value;
					}
				}

				public string DeployType
				{
					get
					{
						return deployType;
					}
					set	
					{
						deployType = value;
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
					}
				}

				public int? BuildpackId
				{
					get
					{
						return buildpackId;
					}
					set	
					{
						buildpackId = value;
					}
				}

				public string TomcatVersion
				{
					get
					{
						return tomcatVersion;
					}
					set	
					{
						tomcatVersion = value;
					}
				}

				public int? InstancesBeforeScaling
				{
					get
					{
						return instancesBeforeScaling;
					}
					set	
					{
						instancesBeforeScaling = value;
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
					}
				}

				public string ApplicationName
				{
					get
					{
						return applicationName;
					}
					set	
					{
						applicationName = value;
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
					}
				}

				public int? Instances
				{
					get
					{
						return instances;
					}
					set	
					{
						instances = value;
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
					}
				}

				public int? LimitCpuM
				{
					get
					{
						return limitCpuM;
					}
					set	
					{
						limitCpuM = value;
					}
				}

				public int? RequestCpuM
				{
					get
					{
						return requestCpuM;
					}
					set	
					{
						requestCpuM = value;
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
					}
				}

				public int? RequestMem
				{
					get
					{
						return requestMem;
					}
					set	
					{
						requestMem = value;
					}
				}

				public string K8sNamespace
				{
					get
					{
						return k8sNamespace;
					}
					set	
					{
						k8sNamespace = value;
					}
				}

				public string RegionId
				{
					get
					{
						return regionId;
					}
					set	
					{
						regionId = value;
					}
				}

				public List<GetK8sApplication_Env> EnvList
				{
					get
					{
						return envList;
					}
					set	
					{
						envList = value;
					}
				}

				public List<string> CmdArgs
				{
					get
					{
						return cmdArgs;
					}
					set	
					{
						cmdArgs = value;
					}
				}

				public class GetK8sApplication_Env
				{

					private string name;

					private string _value;

					public string Name
					{
						get
						{
							return name;
						}
						set	
						{
							name = value;
						}
					}

					public string _Value
					{
						get
						{
							return _value;
						}
						set	
						{
							_value = value;
						}
					}
				}
			}

			public class GetK8sApplication_Conf
			{

				private string jarStartArgs;

				private string jarStartOptions;

				private string k8sCmd;

				private string k8sCmdArgs;

				private string k8sLocalvolumeInfo;

				private string k8sNasInfo;

				private string k8sVolumeInfo;

				private string liveness;

				private string postStart;

				private string preStop;

				private string readiness;

				private string runtimeClassName;

				private string deployAcrossZones;

				private bool? ahasEnabled;

				private string deployAcrossNodes;

				public string JarStartArgs
				{
					get
					{
						return jarStartArgs;
					}
					set	
					{
						jarStartArgs = value;
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
					}
				}

				public string K8sCmd
				{
					get
					{
						return k8sCmd;
					}
					set	
					{
						k8sCmd = value;
					}
				}

				public string K8sCmdArgs
				{
					get
					{
						return k8sCmdArgs;
					}
					set	
					{
						k8sCmdArgs = value;
					}
				}

				public string K8sLocalvolumeInfo
				{
					get
					{
						return k8sLocalvolumeInfo;
					}
					set	
					{
						k8sLocalvolumeInfo = value;
					}
				}

				public string K8sNasInfo
				{
					get
					{
						return k8sNasInfo;
					}
					set	
					{
						k8sNasInfo = value;
					}
				}

				public string K8sVolumeInfo
				{
					get
					{
						return k8sVolumeInfo;
					}
					set	
					{
						k8sVolumeInfo = value;
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
					}
				}

				public bool? AhasEnabled
				{
					get
					{
						return ahasEnabled;
					}
					set	
					{
						ahasEnabled = value;
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
					}
				}
			}

			public class GetK8sApplication_LatestVersion
			{

				private string packageVersion;

				private string url;

				private string warUrl;

				public string PackageVersion
				{
					get
					{
						return packageVersion;
					}
					set	
					{
						packageVersion = value;
					}
				}

				public string Url
				{
					get
					{
						return url;
					}
					set	
					{
						url = value;
					}
				}

				public string WarUrl
				{
					get
					{
						return warUrl;
					}
					set	
					{
						warUrl = value;
					}
				}
			}
		}
	}
}
