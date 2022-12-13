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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.alikafka.Model.V20190916
{
	public class GetInstanceListResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private bool? success;

		private List<GetInstanceList_InstanceVO> instanceList;

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

		public List<GetInstanceList_InstanceVO> InstanceList
		{
			get
			{
				return instanceList;
			}
			set	
			{
				instanceList = value;
			}
		}

		public class GetInstanceList_InstanceVO
		{

			private string vpcId;

			private string specType;

			private int? deployType;

			private long? createTime;

			private int? diskSize;

			private int? diskType;

			private string securityGroup;

			private string sslEndPoint;

			private string instanceId;

			private string allConfig;

			private int? serviceStatus;

			private int? eipMax;

			private string regionId;

			private int? msgRetain;

			private string vSwitchId;

			private long? expiredTime;

			private int? topicNumLimit;

			private string zoneId;

			private int? ioMax;

			private int? paidType;

			private string name;

			private string endPoint;

			private string domainEndpoint;

			private string sslDomainEndpoint;

			private string saslDomainEndpoint;

			private string resourceGroupId;

			private int? usedTopicCount;

			private int? usedGroupCount;

			private int? usedPartitionCount;

			private string kmsKeyId;

			private string standardZoneId;

			private List<GetInstanceList_TagVO> tags;

			private GetInstanceList_UpgradeServiceDetailInfo upgradeServiceDetailInfo;

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

			public string SpecType
			{
				get
				{
					return specType;
				}
				set	
				{
					specType = value;
				}
			}

			public int? DeployType
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

			public long? CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public int? DiskSize
			{
				get
				{
					return diskSize;
				}
				set	
				{
					diskSize = value;
				}
			}

			public int? DiskType
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

			public string SecurityGroup
			{
				get
				{
					return securityGroup;
				}
				set	
				{
					securityGroup = value;
				}
			}

			public string SslEndPoint
			{
				get
				{
					return sslEndPoint;
				}
				set	
				{
					sslEndPoint = value;
				}
			}

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			public string AllConfig
			{
				get
				{
					return allConfig;
				}
				set	
				{
					allConfig = value;
				}
			}

			public int? ServiceStatus
			{
				get
				{
					return serviceStatus;
				}
				set	
				{
					serviceStatus = value;
				}
			}

			public int? EipMax
			{
				get
				{
					return eipMax;
				}
				set	
				{
					eipMax = value;
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

			public int? MsgRetain
			{
				get
				{
					return msgRetain;
				}
				set	
				{
					msgRetain = value;
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

			public long? ExpiredTime
			{
				get
				{
					return expiredTime;
				}
				set	
				{
					expiredTime = value;
				}
			}

			public int? TopicNumLimit
			{
				get
				{
					return topicNumLimit;
				}
				set	
				{
					topicNumLimit = value;
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

			public int? IoMax
			{
				get
				{
					return ioMax;
				}
				set	
				{
					ioMax = value;
				}
			}

			public int? PaidType
			{
				get
				{
					return paidType;
				}
				set	
				{
					paidType = value;
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
				}
			}

			public string EndPoint
			{
				get
				{
					return endPoint;
				}
				set	
				{
					endPoint = value;
				}
			}

			public string DomainEndpoint
			{
				get
				{
					return domainEndpoint;
				}
				set	
				{
					domainEndpoint = value;
				}
			}

			public string SslDomainEndpoint
			{
				get
				{
					return sslDomainEndpoint;
				}
				set	
				{
					sslDomainEndpoint = value;
				}
			}

			public string SaslDomainEndpoint
			{
				get
				{
					return saslDomainEndpoint;
				}
				set	
				{
					saslDomainEndpoint = value;
				}
			}

			public string ResourceGroupId
			{
				get
				{
					return resourceGroupId;
				}
				set	
				{
					resourceGroupId = value;
				}
			}

			public int? UsedTopicCount
			{
				get
				{
					return usedTopicCount;
				}
				set	
				{
					usedTopicCount = value;
				}
			}

			public int? UsedGroupCount
			{
				get
				{
					return usedGroupCount;
				}
				set	
				{
					usedGroupCount = value;
				}
			}

			public int? UsedPartitionCount
			{
				get
				{
					return usedPartitionCount;
				}
				set	
				{
					usedPartitionCount = value;
				}
			}

			public string KmsKeyId
			{
				get
				{
					return kmsKeyId;
				}
				set	
				{
					kmsKeyId = value;
				}
			}

			public string StandardZoneId
			{
				get
				{
					return standardZoneId;
				}
				set	
				{
					standardZoneId = value;
				}
			}

			public List<GetInstanceList_TagVO> Tags
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

			public GetInstanceList_UpgradeServiceDetailInfo UpgradeServiceDetailInfo
			{
				get
				{
					return upgradeServiceDetailInfo;
				}
				set	
				{
					upgradeServiceDetailInfo = value;
				}
			}

			public class GetInstanceList_TagVO
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

			public class GetInstanceList_UpgradeServiceDetailInfo
			{

				private string current2OpenSourceVersion;

				public string Current2OpenSourceVersion
				{
					get
					{
						return current2OpenSourceVersion;
					}
					set	
					{
						current2OpenSourceVersion = value;
					}
				}
			}
		}
	}
}
