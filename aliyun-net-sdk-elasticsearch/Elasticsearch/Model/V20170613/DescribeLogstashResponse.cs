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
	public class DescribeLogstashResponse : AcsResponse
	{

		private string requestId;

		private DescribeLogstash_Result result;

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

		public DescribeLogstash_Result Result
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

		public class DescribeLogstash_Result
		{

			private string config;

			private string paymentType;

			private string resourceGroupId;

			private int? nodeAmount;

			private string description;

			private string createdAt;

			private string status;

			private string vpcInstanceId;

			private string updatedAt;

			private string version;

			private string instanceId;

			private List<DescribeLogstash_Endpoint> endpointList;

			private List<DescribeLogstash_TagsItem> tags;

			private List<DescribeLogstash_ZoneInfosItem> zoneInfos;

			private List<Dictionary<string, string>> extendConfigs;

			private DescribeLogstash_NodeSpec nodeSpec;

			private DescribeLogstash_NetworkConfig networkConfig;

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

			public int? NodeAmount
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

			public string VpcInstanceId
			{
				get
				{
					return vpcInstanceId;
				}
				set	
				{
					vpcInstanceId = value;
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

			public List<DescribeLogstash_Endpoint> EndpointList
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

			public List<DescribeLogstash_TagsItem> Tags
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

			public List<DescribeLogstash_ZoneInfosItem> ZoneInfos
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

			public List<Dictionary<string, string>> ExtendConfigs
			{
				get
				{
					return extendConfigs;
				}
				set	
				{
					extendConfigs = value;
				}
			}

			public DescribeLogstash_NodeSpec NodeSpec
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

			public DescribeLogstash_NetworkConfig NetworkConfig
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

			public class DescribeLogstash_Endpoint
			{

				private string zoneId;

				private string port;

				private string host;

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

				public string Port
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
			}

			public class DescribeLogstash_TagsItem
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

			public class DescribeLogstash_ZoneInfosItem
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

			public class DescribeLogstash_NodeSpec
			{

				private string spec;

				private int? disk;

				private bool? diskEncryption;

				private string diskType;

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

				public int? Disk
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

				public bool? DiskEncryption
				{
					get
					{
						return diskEncryption;
					}
					set	
					{
						diskEncryption = value;
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
			}

			public class DescribeLogstash_NetworkConfig
			{

				private string vpcId;

				private string vsArea;

				private string type;

				private string vswitchId;

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
		}
	}
}
