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

			private int? maxResults;

			private string nextToken;

			private List<ListInstances_InstanceVO> instances;

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

				private string instanceId;

				private string instanceName;

				private string instanceType;

				private string status;

				private string orderType;

				private long? orderCreateTime;

				private long? expireTime;

				private bool? autoRenewInstance;

				private bool? supportEIP;

				private string privateEndpoint;

				private string publicEndpoint;

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
			}
		}
	}
}
