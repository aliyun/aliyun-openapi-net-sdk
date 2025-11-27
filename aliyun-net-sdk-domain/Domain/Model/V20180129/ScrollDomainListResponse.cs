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

namespace Aliyun.Acs.Domain.Model.V20180129
{
	public class ScrollDomainListResponse : AcsResponse
	{

		private string requestId;

		private int? pageSize;

		private string scrollId;

		private int? totalItemNum;

		private List<ScrollDomainList_Domain> data;

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "PageSize")]
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

		[JsonProperty(PropertyName = "ScrollId")]
		public string ScrollId
		{
			get
			{
				return scrollId;
			}
			set	
			{
				scrollId = value;
			}
		}

		[JsonProperty(PropertyName = "TotalItemNum")]
		public int? TotalItemNum
		{
			get
			{
				return totalItemNum;
			}
			set	
			{
				totalItemNum = value;
			}
		}

		[JsonProperty(PropertyName = "Data")]
		public List<ScrollDomainList_Domain> Data
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

		public class ScrollDomainList_Domain
		{

			private string domainAuditStatus;

			private string domainGroupId;

			private string remark;

			private string domainGroupName;

			private string zhRegistrantOrganization;

			private string registrantOrganization;

			private string registrationDate;

			private string instanceId;

			private string domainName;

			private string expirationDateStatus;

			private string expirationDate;

			private string email;

			private string registrantType;

			private long? expirationDateLong;

			private int? expirationCurrDateDiff;

			private bool? premium;

			private long? registrationDateLong;

			private string productId;

			private string domainStatus;

			private string domainType;

			private string resourceGroupId;

			private List<ScrollDomainList_TagItem> tag;

			private List<string> dnsList;

			[JsonProperty(PropertyName = "DomainAuditStatus")]
			public string DomainAuditStatus
			{
				get
				{
					return domainAuditStatus;
				}
				set	
				{
					domainAuditStatus = value;
				}
			}

			[JsonProperty(PropertyName = "DomainGroupId")]
			public string DomainGroupId
			{
				get
				{
					return domainGroupId;
				}
				set	
				{
					domainGroupId = value;
				}
			}

			[JsonProperty(PropertyName = "Remark")]
			public string Remark
			{
				get
				{
					return remark;
				}
				set	
				{
					remark = value;
				}
			}

			[JsonProperty(PropertyName = "DomainGroupName")]
			public string DomainGroupName
			{
				get
				{
					return domainGroupName;
				}
				set	
				{
					domainGroupName = value;
				}
			}

			[JsonProperty(PropertyName = "ZhRegistrantOrganization")]
			public string ZhRegistrantOrganization
			{
				get
				{
					return zhRegistrantOrganization;
				}
				set	
				{
					zhRegistrantOrganization = value;
				}
			}

			[JsonProperty(PropertyName = "RegistrantOrganization")]
			public string RegistrantOrganization
			{
				get
				{
					return registrantOrganization;
				}
				set	
				{
					registrantOrganization = value;
				}
			}

			[JsonProperty(PropertyName = "RegistrationDate")]
			public string RegistrationDate
			{
				get
				{
					return registrationDate;
				}
				set	
				{
					registrationDate = value;
				}
			}

			[JsonProperty(PropertyName = "InstanceId")]
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

			[JsonProperty(PropertyName = "DomainName")]
			public string DomainName
			{
				get
				{
					return domainName;
				}
				set	
				{
					domainName = value;
				}
			}

			[JsonProperty(PropertyName = "ExpirationDateStatus")]
			public string ExpirationDateStatus
			{
				get
				{
					return expirationDateStatus;
				}
				set	
				{
					expirationDateStatus = value;
				}
			}

			[JsonProperty(PropertyName = "ExpirationDate")]
			public string ExpirationDate
			{
				get
				{
					return expirationDate;
				}
				set	
				{
					expirationDate = value;
				}
			}

			[JsonProperty(PropertyName = "Email")]
			public string Email
			{
				get
				{
					return email;
				}
				set	
				{
					email = value;
				}
			}

			[JsonProperty(PropertyName = "RegistrantType")]
			public string RegistrantType
			{
				get
				{
					return registrantType;
				}
				set	
				{
					registrantType = value;
				}
			}

			[JsonProperty(PropertyName = "ExpirationDateLong")]
			public long? ExpirationDateLong
			{
				get
				{
					return expirationDateLong;
				}
				set	
				{
					expirationDateLong = value;
				}
			}

			[JsonProperty(PropertyName = "ExpirationCurrDateDiff")]
			public int? ExpirationCurrDateDiff
			{
				get
				{
					return expirationCurrDateDiff;
				}
				set	
				{
					expirationCurrDateDiff = value;
				}
			}

			[JsonProperty(PropertyName = "Premium")]
			public bool? Premium
			{
				get
				{
					return premium;
				}
				set	
				{
					premium = value;
				}
			}

			[JsonProperty(PropertyName = "RegistrationDateLong")]
			public long? RegistrationDateLong
			{
				get
				{
					return registrationDateLong;
				}
				set	
				{
					registrationDateLong = value;
				}
			}

			[JsonProperty(PropertyName = "ProductId")]
			public string ProductId
			{
				get
				{
					return productId;
				}
				set	
				{
					productId = value;
				}
			}

			[JsonProperty(PropertyName = "DomainStatus")]
			public string DomainStatus
			{
				get
				{
					return domainStatus;
				}
				set	
				{
					domainStatus = value;
				}
			}

			[JsonProperty(PropertyName = "DomainType")]
			public string DomainType
			{
				get
				{
					return domainType;
				}
				set	
				{
					domainType = value;
				}
			}

			[JsonProperty(PropertyName = "ResourceGroupId")]
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

			[JsonProperty(PropertyName = "Tag")]
			public List<ScrollDomainList_TagItem> Tag
			{
				get
				{
					return tag;
				}
				set	
				{
					tag = value;
				}
			}

			[JsonProperty(PropertyName = "DnsList")]
			public List<string> DnsList
			{
				get
				{
					return dnsList;
				}
				set	
				{
					dnsList = value;
				}
			}

			public class ScrollDomainList_TagItem
			{

				private string key;

				private string _value;

				[JsonProperty(PropertyName = "Key")]
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

				[JsonProperty(PropertyName = "_Value")]
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
