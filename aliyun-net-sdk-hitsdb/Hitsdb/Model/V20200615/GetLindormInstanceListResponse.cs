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

namespace Aliyun.Acs.hitsdb.Model.V20200615
{
	public class GetLindormInstanceListResponse : AcsResponse
	{

		private string requestId;

		private int? pageNumber;

		private int? pageSize;

		private int? total;

		private List<GetLindormInstanceList_LindormInstanceSummary> instanceList;

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

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public int? Total
		{
			get
			{
				return total;
			}
			set	
			{
				total = value;
			}
		}

		public List<GetLindormInstanceList_LindormInstanceSummary> InstanceList
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

		public class GetLindormInstanceList_LindormInstanceSummary
		{

			private string vpcId;

			private string engineType;

			private string expireTime;

			private string createTime;

			private string payType;

			private long? aliUid;

			private string instanceStorage;

			private string instanceId;

			private string networkType;

			private string serviceType;

			private string regionId;

			private long? createMilliseconds;

			private string instanceAlias;

			private string zoneId;

			private string instanceStatus;

			private long? expiredMilliseconds;

			private bool? enableStream;

			private bool? enableCompute;

			private string resourceGroupId;

			private List<GetLindormInstanceList_Tag> tags;

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

			public string EngineType
			{
				get
				{
					return engineType;
				}
				set	
				{
					engineType = value;
				}
			}

			public string ExpireTime
			{
				get
				{
					return expireTime;
				}
				set	
				{
					expireTime = value;
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

			public string PayType
			{
				get
				{
					return payType;
				}
				set	
				{
					payType = value;
				}
			}

			public long? AliUid
			{
				get
				{
					return aliUid;
				}
				set	
				{
					aliUid = value;
				}
			}

			public string InstanceStorage
			{
				get
				{
					return instanceStorage;
				}
				set	
				{
					instanceStorage = value;
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

			public string ServiceType
			{
				get
				{
					return serviceType;
				}
				set	
				{
					serviceType = value;
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

			public long? CreateMilliseconds
			{
				get
				{
					return createMilliseconds;
				}
				set	
				{
					createMilliseconds = value;
				}
			}

			public string InstanceAlias
			{
				get
				{
					return instanceAlias;
				}
				set	
				{
					instanceAlias = value;
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

			public long? ExpiredMilliseconds
			{
				get
				{
					return expiredMilliseconds;
				}
				set	
				{
					expiredMilliseconds = value;
				}
			}

			public bool? EnableStream
			{
				get
				{
					return enableStream;
				}
				set	
				{
					enableStream = value;
				}
			}

			public bool? EnableCompute
			{
				get
				{
					return enableCompute;
				}
				set	
				{
					enableCompute = value;
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

			public List<GetLindormInstanceList_Tag> Tags
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

			public class GetLindormInstanceList_Tag
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
