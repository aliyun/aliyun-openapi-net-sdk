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

namespace Aliyun.Acs.sae.Model.V20190506
{
	public class DescribeApplicationConfigResponse : AcsResponse
	{

		private string code;

		private string message;

		private string traceId;

		private string requestId;

		private bool? success;

		private string errorCode;

		private DescribeApplicationConfig_Data data;

		public string Code
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

		public string TraceId
		{
			get
			{
				return traceId;
			}
			set	
			{
				traceId = value;
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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public string ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
			}
		}

		public DescribeApplicationConfig_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class DescribeApplicationConfig_Data
		{

			private string appId;

			private string appName;

			private string namespaceId;

			private string appDescription;

			private string vpcId;

			private string vSwitchId;

			private string packageType;

			private string packageVersion;

			private string packageUrl;

			private string imageUrl;

			private string jdk;

			private string webContainer;

			private int? cpu;

			private int? memory;

			private int? replicas;

			private string command;

			private string commandArgs;

			private string envs;

			private string customHostAlias;

			private string jarStartOptions;

			private string jarStartArgs;

			private string liveness;

			private string readiness;

			private int? minReadyInstances;

			private int? batchWaitTime;

			private string edasContainerVersion;

			private string regionId;

			private string slsConfigs;

			private string timezone;

			private string nasId;

			private string mountHost;

			private string preStop;

			private string postStart;

			private string warStartOptions;

			private string securityGroupId;

			private int? terminationGracePeriodSeconds;

			private string enableAhas;

			private string phpArmsConfigLocation;

			private string phpConfigLocation;

			private string phpConfig;

			private string tomcatConfig;

			private List<DescribeApplicationConfig_MountDescItem> mountDesc;

			private List<DescribeApplicationConfig_Tag> tags;

			private List<DescribeApplicationConfig_ConfigMapMountDescItem> configMapMountDesc;

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

			public string AppName
			{
				get
				{
					return appName;
				}
				set	
				{
					appName = value;
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

			public int? MinReadyInstances
			{
				get
				{
					return minReadyInstances;
				}
				set	
				{
					minReadyInstances = value;
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

			public string SlsConfigs
			{
				get
				{
					return slsConfigs;
				}
				set	
				{
					slsConfigs = value;
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
				}
			}

			public string NasId
			{
				get
				{
					return nasId;
				}
				set	
				{
					nasId = value;
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

			public string WarStartOptions
			{
				get
				{
					return warStartOptions;
				}
				set	
				{
					warStartOptions = value;
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
				}
			}

			public string EnableAhas
			{
				get
				{
					return enableAhas;
				}
				set	
				{
					enableAhas = value;
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
				}
			}

			public List<DescribeApplicationConfig_MountDescItem> MountDesc
			{
				get
				{
					return mountDesc;
				}
				set	
				{
					mountDesc = value;
				}
			}

			public List<DescribeApplicationConfig_Tag> Tags
			{
				get
				{
					return tags;
				}
				set	
				{
					tags = value;
				}
			}

			public List<DescribeApplicationConfig_ConfigMapMountDescItem> ConfigMapMountDesc
			{
				get
				{
					return configMapMountDesc;
				}
				set	
				{
					configMapMountDesc = value;
				}
			}

			public class DescribeApplicationConfig_MountDescItem
			{

				private string nasPath;

				private string mountPath;

				public string NasPath
				{
					get
					{
						return nasPath;
					}
					set	
					{
						nasPath = value;
					}
				}

				public string MountPath
				{
					get
					{
						return mountPath;
					}
					set	
					{
						mountPath = value;
					}
				}
			}

			public class DescribeApplicationConfig_Tag
			{

				private string key;

				private string _value;

				public string Key
				{
					get
					{
						return key;
					}
					set	
					{
						key = value;
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

			public class DescribeApplicationConfig_ConfigMapMountDescItem
			{

				private long? configMapId;

				private string configMapName;

				private string key;

				private string mountPath;

				public long? ConfigMapId
				{
					get
					{
						return configMapId;
					}
					set	
					{
						configMapId = value;
					}
				}

				public string ConfigMapName
				{
					get
					{
						return configMapName;
					}
					set	
					{
						configMapName = value;
					}
				}

				public string Key
				{
					get
					{
						return key;
					}
					set	
					{
						key = value;
					}
				}

				public string MountPath
				{
					get
					{
						return mountPath;
					}
					set	
					{
						mountPath = value;
					}
				}
			}
		}
	}
}
