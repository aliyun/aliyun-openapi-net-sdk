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
	public class ListLogstashResponse : AcsResponse
	{

		private string requestId;

		private List<ListLogstash_Instance> result;

		private ListLogstash_Headers headers;

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

		public List<ListLogstash_Instance> Result
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

		public ListLogstash_Headers Headers
		{
			get
			{
				return headers;
			}
			set	
			{
				headers = value;
			}
		}

		public class ListLogstash_Instance
		{

			private string paymentType;

			private int? nodeAmount;

			private string description;

			private string createdAt;

			private string status;

			private string updatedAt;

			private string instanceId;

			private string version;

			private string resourceGroupId;

			private List<ListLogstash_TagsItem> tags;

			private ListLogstash_NodeSpec nodeSpec;

			private ListLogstash_NetworkConfig networkConfig;

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

			public List<ListLogstash_TagsItem> Tags
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

			public ListLogstash_NodeSpec NodeSpec
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

			public ListLogstash_NetworkConfig NetworkConfig
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

			public class ListLogstash_TagsItem
			{

				private string tagValue;

				private string tagKey;

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
			}

			public class ListLogstash_NodeSpec
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

			public class ListLogstash_NetworkConfig
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

		public class ListLogstash_Headers
		{

			private int? xTotalCount;

			public int? XTotalCount
			{
				get
				{
					return xTotalCount;
				}
				set	
				{
					xTotalCount = value;
				}
			}
		}
	}
}
