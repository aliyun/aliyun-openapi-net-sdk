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

namespace Aliyun.Acs.Netana.Model.V20181018
{
	public class DescribeNetworkQuotasResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private List<DescribeNetworkQuotas_NetworkQuota> networkQuotas;

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

		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public List<DescribeNetworkQuotas_NetworkQuota> NetworkQuotas
		{
			get
			{
				return networkQuotas;
			}
			set	
			{
				networkQuotas = value;
			}
		}

		public class DescribeNetworkQuotas_NetworkQuota
		{

			private string product;

			private string resourceType;

			private List<DescribeNetworkQuotas_Privilege> privileges;

			private List<DescribeNetworkQuotas_NetworkQuotaInfo> networkQuotaInfos;

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

			public string ResourceType
			{
				get
				{
					return resourceType;
				}
				set	
				{
					resourceType = value;
				}
			}

			public List<DescribeNetworkQuotas_Privilege> Privileges
			{
				get
				{
					return privileges;
				}
				set	
				{
					privileges = value;
				}
			}

			public List<DescribeNetworkQuotas_NetworkQuotaInfo> NetworkQuotaInfos
			{
				get
				{
					return networkQuotaInfos;
				}
				set	
				{
					networkQuotaInfos = value;
				}
			}

			public class DescribeNetworkQuotas_Privilege
			{

				private string privilege;

				private string description;

				private bool? enabled;

				private string descriptionCn;

				public string Privilege
				{
					get
					{
						return privilege;
					}
					set	
					{
						privilege = value;
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

				public bool? Enabled
				{
					get
					{
						return enabled;
					}
					set	
					{
						enabled = value;
					}
				}

				public string DescriptionCn
				{
					get
					{
						return descriptionCn;
					}
					set	
					{
						descriptionCn = value;
					}
				}
			}

			public class DescribeNetworkQuotas_NetworkQuotaInfo
			{

				private string quotaName;

				private string quotaDescription;

				private string quotaQuantity;

				private string instanceQuantity;

				private string canExceptional;

				private string quotaDescriptionCn;

				private string sequence;

				public string QuotaName
				{
					get
					{
						return quotaName;
					}
					set	
					{
						quotaName = value;
					}
				}

				public string QuotaDescription
				{
					get
					{
						return quotaDescription;
					}
					set	
					{
						quotaDescription = value;
					}
				}

				public string QuotaQuantity
				{
					get
					{
						return quotaQuantity;
					}
					set	
					{
						quotaQuantity = value;
					}
				}

				public string InstanceQuantity
				{
					get
					{
						return instanceQuantity;
					}
					set	
					{
						instanceQuantity = value;
					}
				}

				public string CanExceptional
				{
					get
					{
						return canExceptional;
					}
					set	
					{
						canExceptional = value;
					}
				}

				public string QuotaDescriptionCn
				{
					get
					{
						return quotaDescriptionCn;
					}
					set	
					{
						quotaDescriptionCn = value;
					}
				}

				public string Sequence
				{
					get
					{
						return sequence;
					}
					set	
					{
						sequence = value;
					}
				}
			}
		}
	}
}
