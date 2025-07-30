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

namespace Aliyun.Acs.R_kvstore.Model.V20150101
{
	public class DescribeTairKVCacheInferInstanceAttributeResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeTairKVCacheInferInstanceAttribute_DBInstanceAttribute> instances;

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

		public List<DescribeTairKVCacheInferInstanceAttribute_DBInstanceAttribute> Instances
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

		public class DescribeTairKVCacheInferInstanceAttribute_DBInstanceAttribute
		{

			private string instanceId;

			private string vpcId;

			private string vSwitchId;

			private string privateIp;

			private string chargeType;

			private string createTime;

			private string endTime;

			private string architectureType;

			private string networkType;

			private string instanceName;

			private string instanceClass;

			private string instanceType;

			private string zoneId;

			private string zoneType;

			private string regionId;

			private long? storage;

			private string resourceGroupId;

			private string instanceStatus;

			private string isOrderCompleted;

			private string connectionString;

			private int? isDelete;

			private string model;

			private int? modelServiceNum;

			private int? computeUnitNum;

			private List<DescribeTairKVCacheInferInstanceAttribute_Tag> tags;

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

			public string PrivateIp
			{
				get
				{
					return privateIp;
				}
				set	
				{
					privateIp = value;
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

			public string CreateTime
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

			public string EndTime
			{
				get
				{
					return endTime;
				}
				set	
				{
					endTime = value;
				}
			}

			public string ArchitectureType
			{
				get
				{
					return architectureType;
				}
				set	
				{
					architectureType = value;
				}
			}

			public string NetworkType
			{
				get
				{
					return networkType;
				}
				set	
				{
					networkType = value;
				}
			}

			public string InstanceName
			{
				get
				{
					return instanceName;
				}
				set	
				{
					instanceName = value;
				}
			}

			public string InstanceClass
			{
				get
				{
					return instanceClass;
				}
				set	
				{
					instanceClass = value;
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

			public string ZoneType
			{
				get
				{
					return zoneType;
				}
				set	
				{
					zoneType = value;
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

			public long? Storage
			{
				get
				{
					return storage;
				}
				set	
				{
					storage = value;
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

			public string InstanceStatus
			{
				get
				{
					return instanceStatus;
				}
				set	
				{
					instanceStatus = value;
				}
			}

			public string IsOrderCompleted
			{
				get
				{
					return isOrderCompleted;
				}
				set	
				{
					isOrderCompleted = value;
				}
			}

			public string ConnectionString
			{
				get
				{
					return connectionString;
				}
				set	
				{
					connectionString = value;
				}
			}

			public int? IsDelete
			{
				get
				{
					return isDelete;
				}
				set	
				{
					isDelete = value;
				}
			}

			public string Model
			{
				get
				{
					return model;
				}
				set	
				{
					model = value;
				}
			}

			public int? ModelServiceNum
			{
				get
				{
					return modelServiceNum;
				}
				set	
				{
					modelServiceNum = value;
				}
			}

			public int? ComputeUnitNum
			{
				get
				{
					return computeUnitNum;
				}
				set	
				{
					computeUnitNum = value;
				}
			}

			public List<DescribeTairKVCacheInferInstanceAttribute_Tag> Tags
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

			public class DescribeTairKVCacheInferInstanceAttribute_Tag
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
		}
	}
}
