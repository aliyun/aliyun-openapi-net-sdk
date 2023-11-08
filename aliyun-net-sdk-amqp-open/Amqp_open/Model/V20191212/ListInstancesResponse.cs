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

namespace Aliyun.Acs.amqp_open.Model.V20191212
{
	public class ListInstancesResponse : AcsResponse
	{

		private string requestId;

		private ListInstances_Data data;

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

		public ListInstances_Data Data
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

		public class ListInstances_Data
		{

			private string nextToken;

			private int? maxResults;

			private List<ListInstances_InstanceVO> instances;

			public string NextToken
			{
				get
				{
					return nextToken;
				}
				set	
				{
					nextToken = value;
				}
			}

			public int? MaxResults
			{
				get
				{
					return maxResults;
				}
				set	
				{
					maxResults = value;
				}
			}

			public List<ListInstances_InstanceVO> Instances
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

			public class ListInstances_InstanceVO
			{

				private string status;

				private bool? supportEIP;

				private long? expireTime;

				private long? orderCreateTime;

				private string privateEndpoint;

				private int? storageSize;

				private int? maxEipTps;

				private string instanceId;

				private string instanceType;

				private string publicEndpoint;

				private string classicEndpoint;

				private int? maxVhost;

				private int? maxTps;

				private bool? autoRenewInstance;

				private string instanceName;

				private int? maxQueue;

				private string orderType;

				private List<ListInstances_TagsItem> tags;

				public string Status
				{
					get
					{
						return status;
					}
					set	
					{
						status = value;
					}
				}

				public bool? SupportEIP
				{
					get
					{
						return supportEIP;
					}
					set	
					{
						supportEIP = value;
					}
				}

				public long? ExpireTime
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

				public long? OrderCreateTime
				{
					get
					{
						return orderCreateTime;
					}
					set	
					{
						orderCreateTime = value;
					}
				}

				public string PrivateEndpoint
				{
					get
					{
						return privateEndpoint;
					}
					set	
					{
						privateEndpoint = value;
					}
				}

				public int? StorageSize
				{
					get
					{
						return storageSize;
					}
					set	
					{
						storageSize = value;
					}
				}

				public int? MaxEipTps
				{
					get
					{
						return maxEipTps;
					}
					set	
					{
						maxEipTps = value;
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

				public string PublicEndpoint
				{
					get
					{
						return publicEndpoint;
					}
					set	
					{
						publicEndpoint = value;
					}
				}

				public string ClassicEndpoint
				{
					get
					{
						return classicEndpoint;
					}
					set	
					{
						classicEndpoint = value;
					}
				}

				public int? MaxVhost
				{
					get
					{
						return maxVhost;
					}
					set	
					{
						maxVhost = value;
					}
				}

				public int? MaxTps
				{
					get
					{
						return maxTps;
					}
					set	
					{
						maxTps = value;
					}
				}

				public bool? AutoRenewInstance
				{
					get
					{
						return autoRenewInstance;
					}
					set	
					{
						autoRenewInstance = value;
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

				public int? MaxQueue
				{
					get
					{
						return maxQueue;
					}
					set	
					{
						maxQueue = value;
					}
				}

				public string OrderType
				{
					get
					{
						return orderType;
					}
					set	
					{
						orderType = value;
					}
				}

				public List<ListInstances_TagsItem> Tags
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

				public class ListInstances_TagsItem
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
}
