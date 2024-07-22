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

namespace Aliyun.Acs.elasticsearch.Model.V20170613
{
	public class CreateLogstashResponse : AcsResponse
	{

		private string requestId;

		private CreateLogstash_Result result;

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

		public CreateLogstash_Result Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class CreateLogstash_Result
		{

			private string status;

			private string description;

			private string resourceGroupId;

			private long? endTime;

			private string instanceId;

			private string config;

			private string createdAt;

			private long? nodeAmount;

			private string updatedAt;

			private string version;

			private bool? dataNode;

			private string paymentType;

			private string protocol;

			private long? zoneCount;

			private List<CreateLogstash_EndpointListItem> endpointList;

			private List<CreateLogstash_ZoneInfosItem> zoneInfos;

			private List<CreateLogstash_TagsItem> tags;

			private CreateLogstash_NetworkConfig networkConfig;

			private CreateLogstash_NodeSpec nodeSpec;

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

			public long? EndTime
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

			public string Config
			{
				get
				{
					return config;
				}
				set	
				{
					config = value;
				}
			}

			public string CreatedAt
			{
				get
				{
					return createdAt;
				}
				set	
				{
					createdAt = value;
				}
			}

			public long? NodeAmount
			{
				get
				{
					return nodeAmount;
				}
				set	
				{
					nodeAmount = value;
				}
			}

			public string UpdatedAt
			{
				get
				{
					return updatedAt;
				}
				set	
				{
					updatedAt = value;
				}
			}

			public string Version
			{
				get
				{
					return version;
				}
				set	
				{
					version = value;
				}
			}

			public bool? DataNode
			{
				get
				{
					return dataNode;
				}
				set	
				{
					dataNode = value;
				}
			}

			public string PaymentType
			{
				get
				{
					return paymentType;
				}
				set	
				{
					paymentType = value;
				}
			}

			public string Protocol
			{
				get
				{
					return protocol;
				}
				set	
				{
					protocol = value;
				}
			}

			public long? ZoneCount
			{
				get
				{
					return zoneCount;
				}
				set	
				{
					zoneCount = value;
				}
			}

			public List<CreateLogstash_EndpointListItem> EndpointList
			{
				get
				{
					return endpointList;
				}
				set	
				{
					endpointList = value;
				}
			}

			public List<CreateLogstash_ZoneInfosItem> ZoneInfos
			{
				get
				{
					return zoneInfos;
				}
				set	
				{
					zoneInfos = value;
				}
			}

			public List<CreateLogstash_TagsItem> Tags
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

			public CreateLogstash_NetworkConfig NetworkConfig
			{
				get
				{
					return networkConfig;
				}
				set	
				{
					networkConfig = value;
				}
			}

			public CreateLogstash_NodeSpec NodeSpec
			{
				get
				{
					return nodeSpec;
				}
				set	
				{
					nodeSpec = value;
				}
			}

			public class CreateLogstash_EndpointListItem
			{

				private string host;

				private long? port;

				private string zoneId;

				public string Host
				{
					get
					{
						return host;
					}
					set	
					{
						host = value;
					}
				}

				public long? Port
				{
					get
					{
						return port;
					}
					set	
					{
						port = value;
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
			}

			public class CreateLogstash_ZoneInfosItem
			{

				private string status;

				private string zoneId;

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
			}

			public class CreateLogstash_TagsItem
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

			public class CreateLogstash_NetworkConfig
			{

				private string type;

				private string vpcId;

				private string vsArea;

				private string vswitchId;

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

				public string VsArea
				{
					get
					{
						return vsArea;
					}
					set	
					{
						vsArea = value;
					}
				}

				public string VswitchId
				{
					get
					{
						return vswitchId;
					}
					set	
					{
						vswitchId = value;
					}
				}
			}

			public class CreateLogstash_NodeSpec
			{

				private long? disk;

				private string diskType;

				private string spec;

				public long? Disk
				{
					get
					{
						return disk;
					}
					set	
					{
						disk = value;
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

				public string Spec
				{
					get
					{
						return spec;
					}
					set	
					{
						spec = value;
					}
				}
			}
		}
	}
}
