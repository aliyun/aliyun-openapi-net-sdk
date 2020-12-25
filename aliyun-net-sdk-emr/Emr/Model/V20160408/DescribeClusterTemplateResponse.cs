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

namespace Aliyun.Acs.Emr.Model.V20160408
{
	public class DescribeClusterTemplateResponse : AcsResponse
	{

		private string requestId;

		private DescribeClusterTemplate_TemplateInfo templateInfo;

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

		public DescribeClusterTemplate_TemplateInfo TemplateInfo
		{
			get
			{
				return templateInfo;
			}
			set	
			{
				templateInfo = value;
			}
		}

		public class DescribeClusterTemplate_TemplateInfo
		{

			private string id;

			private string templateName;

			private string emrVer;

			private bool? logEnable;

			private string logPath;

			private string userId;

			private string userDefinedEmrEcsRole;

			private int? masterNodeTotal;

			private string vpcId;

			private string vSwitchId;

			private string netType;

			private bool? ioOptimized;

			private string instanceGeneration;

			private bool? highAvailabilityEnable;

			private bool? easEnable;

			private long? gmtCreate;

			private long? gmtModified;

			private string zoneId;

			private string clusterType;

			private string securityGroupId;

			private string securityGroupName;

			private string configurations;

			private bool? allowNotebook;

			private string createSource;

			private bool? useLocalMetaDb;

			private bool? sshEnable;

			private bool? isOpenPublicIp;

			private string depositType;

			private string machineType;

			private bool? useCustomHiveMetaDb;

			private bool? initCustomHiveMetaDb;

			private string keyPairName;

			private string masterPwd;

			private string metaStoreType;

			private string metaStoreConf;

			private List<DescribeClusterTemplate_BootstrapAction> bootstrapActionList;

			private List<DescribeClusterTemplate_HostGroup> hostGroupList;

			private List<DescribeClusterTemplate_Config> configList;

			private List<DescribeClusterTemplate_Tag> tags;

			private List<string> softwareInfoList;

			public string Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

			public string TemplateName
			{
				get
				{
					return templateName;
				}
				set	
				{
					templateName = value;
				}
			}

			public string EmrVer
			{
				get
				{
					return emrVer;
				}
				set	
				{
					emrVer = value;
				}
			}

			public bool? LogEnable
			{
				get
				{
					return logEnable;
				}
				set	
				{
					logEnable = value;
				}
			}

			public string LogPath
			{
				get
				{
					return logPath;
				}
				set	
				{
					logPath = value;
				}
			}

			public string UserId
			{
				get
				{
					return userId;
				}
				set	
				{
					userId = value;
				}
			}

			public string UserDefinedEmrEcsRole
			{
				get
				{
					return userDefinedEmrEcsRole;
				}
				set	
				{
					userDefinedEmrEcsRole = value;
				}
			}

			public int? MasterNodeTotal
			{
				get
				{
					return masterNodeTotal;
				}
				set	
				{
					masterNodeTotal = value;
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

			public string NetType
			{
				get
				{
					return netType;
				}
				set	
				{
					netType = value;
				}
			}

			public bool? IoOptimized
			{
				get
				{
					return ioOptimized;
				}
				set	
				{
					ioOptimized = value;
				}
			}

			public string InstanceGeneration
			{
				get
				{
					return instanceGeneration;
				}
				set	
				{
					instanceGeneration = value;
				}
			}

			public bool? HighAvailabilityEnable
			{
				get
				{
					return highAvailabilityEnable;
				}
				set	
				{
					highAvailabilityEnable = value;
				}
			}

			public bool? EasEnable
			{
				get
				{
					return easEnable;
				}
				set	
				{
					easEnable = value;
				}
			}

			public long? GmtCreate
			{
				get
				{
					return gmtCreate;
				}
				set	
				{
					gmtCreate = value;
				}
			}

			public long? GmtModified
			{
				get
				{
					return gmtModified;
				}
				set	
				{
					gmtModified = value;
				}
			}

			public string ZoneId
			{
				get
				{
					return zoneId;
				}
				set	
				{
					zoneId = value;
				}
			}

			public string ClusterType
			{
				get
				{
					return clusterType;
				}
				set	
				{
					clusterType = value;
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

			public string SecurityGroupName
			{
				get
				{
					return securityGroupName;
				}
				set	
				{
					securityGroupName = value;
				}
			}

			public string Configurations
			{
				get
				{
					return configurations;
				}
				set	
				{
					configurations = value;
				}
			}

			public bool? AllowNotebook
			{
				get
				{
					return allowNotebook;
				}
				set	
				{
					allowNotebook = value;
				}
			}

			public string CreateSource
			{
				get
				{
					return createSource;
				}
				set	
				{
					createSource = value;
				}
			}

			public bool? UseLocalMetaDb
			{
				get
				{
					return useLocalMetaDb;
				}
				set	
				{
					useLocalMetaDb = value;
				}
			}

			public bool? SshEnable
			{
				get
				{
					return sshEnable;
				}
				set	
				{
					sshEnable = value;
				}
			}

			public bool? IsOpenPublicIp
			{
				get
				{
					return isOpenPublicIp;
				}
				set	
				{
					isOpenPublicIp = value;
				}
			}

			public string DepositType
			{
				get
				{
					return depositType;
				}
				set	
				{
					depositType = value;
				}
			}

			public string MachineType
			{
				get
				{
					return machineType;
				}
				set	
				{
					machineType = value;
				}
			}

			public bool? UseCustomHiveMetaDb
			{
				get
				{
					return useCustomHiveMetaDb;
				}
				set	
				{
					useCustomHiveMetaDb = value;
				}
			}

			public bool? InitCustomHiveMetaDb
			{
				get
				{
					return initCustomHiveMetaDb;
				}
				set	
				{
					initCustomHiveMetaDb = value;
				}
			}

			public string KeyPairName
			{
				get
				{
					return keyPairName;
				}
				set	
				{
					keyPairName = value;
				}
			}

			public string MasterPwd
			{
				get
				{
					return masterPwd;
				}
				set	
				{
					masterPwd = value;
				}
			}

			public string MetaStoreType
			{
				get
				{
					return metaStoreType;
				}
				set	
				{
					metaStoreType = value;
				}
			}

			public string MetaStoreConf
			{
				get
				{
					return metaStoreConf;
				}
				set	
				{
					metaStoreConf = value;
				}
			}

			public List<DescribeClusterTemplate_BootstrapAction> BootstrapActionList
			{
				get
				{
					return bootstrapActionList;
				}
				set	
				{
					bootstrapActionList = value;
				}
			}

			public List<DescribeClusterTemplate_HostGroup> HostGroupList
			{
				get
				{
					return hostGroupList;
				}
				set	
				{
					hostGroupList = value;
				}
			}

			public List<DescribeClusterTemplate_Config> ConfigList
			{
				get
				{
					return configList;
				}
				set	
				{
					configList = value;
				}
			}

			public List<DescribeClusterTemplate_Tag> Tags
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

			public List<string> SoftwareInfoList
			{
				get
				{
					return softwareInfoList;
				}
				set	
				{
					softwareInfoList = value;
				}
			}

			public class DescribeClusterTemplate_BootstrapAction
			{

				private string name;

				private string path;

				private string arg;

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

				public string Path
				{
					get
					{
						return path;
					}
					set	
					{
						path = value;
					}
				}

				public string Arg
				{
					get
					{
						return arg;
					}
					set	
					{
						arg = value;
					}
				}
			}

			public class DescribeClusterTemplate_HostGroup
			{

				private string hostGroupId;

				private string hostGroupName;

				private string hostGroupType;

				private string chargeType;

				private string period;

				private int? nodeCount;

				private string instanceType;

				private string diskType;

				private int? diskCapacity;

				private int? diskCount;

				private string sysDiskType;

				private int? sysDiskCapacity;

				private string multiInstanceTypes;

				public string HostGroupId
				{
					get
					{
						return hostGroupId;
					}
					set	
					{
						hostGroupId = value;
					}
				}

				public string HostGroupName
				{
					get
					{
						return hostGroupName;
					}
					set	
					{
						hostGroupName = value;
					}
				}

				public string HostGroupType
				{
					get
					{
						return hostGroupType;
					}
					set	
					{
						hostGroupType = value;
					}
				}

				public string ChargeType
				{
					get
					{
						return chargeType;
					}
					set	
					{
						chargeType = value;
					}
				}

				public string Period
				{
					get
					{
						return period;
					}
					set	
					{
						period = value;
					}
				}

				public int? NodeCount
				{
					get
					{
						return nodeCount;
					}
					set	
					{
						nodeCount = value;
					}
				}

				public string InstanceType
				{
					get
					{
						return instanceType;
					}
					set	
					{
						instanceType = value;
					}
				}

				public string DiskType
				{
					get
					{
						return diskType;
					}
					set	
					{
						diskType = value;
					}
				}

				public int? DiskCapacity
				{
					get
					{
						return diskCapacity;
					}
					set	
					{
						diskCapacity = value;
					}
				}

				public int? DiskCount
				{
					get
					{
						return diskCount;
					}
					set	
					{
						diskCount = value;
					}
				}

				public string SysDiskType
				{
					get
					{
						return sysDiskType;
					}
					set	
					{
						sysDiskType = value;
					}
				}

				public int? SysDiskCapacity
				{
					get
					{
						return sysDiskCapacity;
					}
					set	
					{
						sysDiskCapacity = value;
					}
				}

				public string MultiInstanceTypes
				{
					get
					{
						return multiInstanceTypes;
					}
					set	
					{
						multiInstanceTypes = value;
					}
				}
			}

			public class DescribeClusterTemplate_Config
			{

				private string serviceName;

				private string fileName;

				private string configKey;

				private string configValue;

				private string encrypt;

				private string replace;

				public string ServiceName
				{
					get
					{
						return serviceName;
					}
					set	
					{
						serviceName = value;
					}
				}

				public string FileName
				{
					get
					{
						return fileName;
					}
					set	
					{
						fileName = value;
					}
				}

				public string ConfigKey
				{
					get
					{
						return configKey;
					}
					set	
					{
						configKey = value;
					}
				}

				public string ConfigValue
				{
					get
					{
						return configValue;
					}
					set	
					{
						configValue = value;
					}
				}

				public string Encrypt
				{
					get
					{
						return encrypt;
					}
					set	
					{
						encrypt = value;
					}
				}

				public string Replace
				{
					get
					{
						return replace;
					}
					set	
					{
						replace = value;
					}
				}
			}

			public class DescribeClusterTemplate_Tag
			{

				private string tagKey;

				private string tagValue;

				public string TagKey
				{
					get
					{
						return tagKey;
					}
					set	
					{
						tagKey = value;
					}
				}

				public string TagValue
				{
					get
					{
						return tagValue;
					}
					set	
					{
						tagValue = value;
					}
				}
			}
		}
	}
}
