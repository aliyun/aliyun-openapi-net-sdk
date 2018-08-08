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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Ots.Model.V20160620
{
	public class GetInstanceResponse : AcsResponse
	{

		private string requestId;

		private GetInstance_InstanceInfo instanceInfo;

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

		public GetInstance_InstanceInfo InstanceInfo
		{
			get
			{
				return instanceInfo;
			}
			set	
			{
				instanceInfo = value;
			}
		}

		public class GetInstance_InstanceInfo
		{

			private string instanceName;

			private string userId;

			private string network;

			private int? status;

			private int? writeCapacity;

			private int? readCapacity;

			private string description;

			private string createTime;

			private string clusterType;

			private List<GetInstance_TagInfo> tagInfos;

			private GetInstance_Quota quota;

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

			public string Network
			{
				get
				{
					return network;
				}
				set	
				{
					network = value;
				}
			}

			public int? Status
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

			public int? WriteCapacity
			{
				get
				{
					return writeCapacity;
				}
				set	
				{
					writeCapacity = value;
				}
			}

			public int? ReadCapacity
			{
				get
				{
					return readCapacity;
				}
				set	
				{
					readCapacity = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
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

			public List<GetInstance_TagInfo> TagInfos
			{
				get
				{
					return tagInfos;
				}
				set	
				{
					tagInfos = value;
				}
			}

			public GetInstance_Quota Quota
			{
				get
				{
					return quota;
				}
				set	
				{
					quota = value;
				}
			}

			public class GetInstance_TagInfo
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

			public class GetInstance_Quota
			{

				private int? entityQuota;

				public int? EntityQuota
				{
					get
					{
						return entityQuota;
					}
					set	
					{
						entityQuota = value;
					}
				}
			}
		}
	}
}