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

namespace Aliyun.Acs.eflo.Model.V20220530
{
	public class ListVccGrantRulesResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private ListVccGrantRules_Content content;

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

		public ListVccGrantRules_Content Content
		{
			get
			{
				return content;
			}
			set	
			{
				content = value;
			}
		}

		public class ListVccGrantRules_Content
		{

			private long? total;

			private List<ListVccGrantRules_DataItem> data;

			public long? Total
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

			public List<ListVccGrantRules_DataItem> Data
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

			public class ListVccGrantRules_DataItem
			{

				private string regionId;

				private string tenantId;

				private string instanceId;

				private string instanceName;

				private string product;

				private string erId;

				private string grantTenantId;

				private bool? used;

				private string createTime;

				private string grantRuleId;

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

				public string TenantId
				{
					get
					{
						return tenantId;
					}
					set	
					{
						tenantId = value;
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

				public string Product
				{
					get
					{
						return product;
					}
					set	
					{
						product = value;
					}
				}

				public string ErId
				{
					get
					{
						return erId;
					}
					set	
					{
						erId = value;
					}
				}

				public string GrantTenantId
				{
					get
					{
						return grantTenantId;
					}
					set	
					{
						grantTenantId = value;
					}
				}

				public bool? Used
				{
					get
					{
						return used;
					}
					set	
					{
						used = value;
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

				public string GrantRuleId
				{
					get
					{
						return grantRuleId;
					}
					set	
					{
						grantRuleId = value;
					}
				}
			}
		}
	}
}
