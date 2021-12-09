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

		private string requestId;

		private string message;

		private string traceId;

		private string errorCode;

		private string code;

		private bool? success;

		private DescribeApplicationConfig_Data data;

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

			private string vpcId;

			private string readiness;

			private string securityGroupId;

			private int? batchWaitTime;

			private string jdk;

			private string imageUrl;

			private string slsConfigs;

			private string liveness;

			private string packageUrl;

			private string packageType;

			private string preStop;

			private string packageVersion;

			private string jarStartArgs;

			private string appName;

			private string appId;

			private string jarStartOptions;

			private int? replicas;

			private string updateStrategy;

			private int? minReadyInstances;

			private int? memory;

			private string php;

			private string phpConfig;

			private string phpConfigLocation;

			private string phpExtensions;

			private string phpPECLExtensions;

			private string postStart;

			private int? terminationGracePeriodSeconds;

			private string commandArgs;

			private string namespaceId;

			private string mountHost;

			private string tomcatConfig;

			private string regionId;

			private string vSwitchId;

			private int? cpu;

			private string envs;

			private string enableAhas;

			private string customHostAlias;

			private string webContainer;

			private string command;

			private string warStartOptions;

			private string phpArmsConfigLocation;

			private string nasId;

			private string ossAkId;

			private string ossAkSecret;

			private string edasContainerVersion;

			private string timezone;

			private string appDescription;

			private bool? enableGreyTagRoute;

			private string mseApplicationId;

			private string acrInstanceId;

			private string acrAssumeRoleArn;

			private bool? associateEip;

			private List<DescribeApplicationConfig_ConfigMapMountDescItem> configMapMountDesc;

			private List<DescribeApplicationConfig_Tag> tags;

			private List<DescribeApplicationConfig_MountDescItem> mountDesc;

			private List<DescribeApplicationConfig_OssMountDesc> ossMountDescs;

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

			public string UpdateStrategy
			{
				get
				{
					return updateStrategy;
				}
				set	
				{
					updateStrategy = value;
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

			public string Php
			{
				get
				{
					return php;
				}
				set	
				{
					php = value;
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

			public string PhpExtensions
			{
				get
				{
					return phpExtensions;
				}
				set	
				{
					phpExtensions = value;
				}
			}

			public string PhpPECLExtensions
			{
				get
				{
					return phpPECLExtensions;
				}
				set	
				{
					phpPECLExtensions = value;
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

			public string OssAkId
			{
				get
				{
					return ossAkId;
				}
				set	
				{
					ossAkId = value;
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

			public bool? EnableGreyTagRoute
			{
				get
				{
					return enableGreyTagRoute;
				}
				set	
				{
					enableGreyTagRoute = value;
				}
			}

			public string MseApplicationId
			{
				get
				{
					return mseApplicationId;
				}
				set	
				{
					mseApplicationId = value;
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
				}
			}

			public bool? AssociateEip
			{
				get
				{
					return associateEip;
				}
				set	
				{
					associateEip = value;
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

			public List<DescribeApplicationConfig_OssMountDesc> OssMountDescs
			{
				get
				{
					return ossMountDescs;
				}
				set	
				{
					ossMountDescs = value;
				}
			}

			public class DescribeApplicationConfig_ConfigMapMountDescItem
			{

				private string key;

				private string configMapName;

				private string mountPath;

				private long? configMapId;

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

			public class DescribeApplicationConfig_MountDescItem
			{

				private string mountPath;

				private string nasPath;

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
			}

			public class DescribeApplicationConfig_OssMountDesc
			{

				private string bucketName;

				private string bucketPath;

				private string mountPath;

				private bool? _readOnly;

				public string BucketName
				{
					get
					{
						return bucketName;
					}
					set	
					{
						bucketName = value;
					}
				}

				public string BucketPath
				{
					get
					{
						return bucketPath;
					}
					set	
					{
						bucketPath = value;
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

				public bool? _ReadOnly
				{
					get
					{
						return _readOnly;
					}
					set	
					{
						_readOnly = value;
					}
				}
			}
		}
	}
}
