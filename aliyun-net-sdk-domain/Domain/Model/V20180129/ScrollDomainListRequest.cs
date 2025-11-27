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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Domain.Transform;
using Aliyun.Acs.Domain.Transform.V20180129;

namespace Aliyun.Acs.Domain.Model.V20180129
{
    public class ScrollDomainListRequest : RpcAcsRequest<ScrollDomainListResponse>
    {
        public ScrollDomainListRequest()
            : base("Domain", "2018-01-29", "ScrollDomainList", "domain", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Domain.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Domain.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string productDomainType;

		private string excluded;

		private int? startLength;

		private string resourceGroupId;

		private bool? excludedSuffix;

		private int? pageSize;

		private string lang;

		private bool? excludedPrefix;

		private string keyWord;

		private long? endExpirationDate;

		private string suffixs;

		private long? startExpirationDate;

		private int? domainStatus;

		private long? domainGroupId;

		private bool? keyWordSuffix;

		private string scrollId;

		private bool? keyWordPrefix;

		private int? tradeType;

		private long? endRegistrationDate;

		private int? form;

		private string userClientIp;

		private long? startRegistrationDate;

		private int? endLength;

		[JsonProperty(PropertyName = "ProductDomainType")]
		public string ProductDomainType
		{
			get
			{
				return productDomainType;
			}
			set	
			{
				productDomainType = value;
				DictionaryUtil.Add(QueryParameters, "ProductDomainType", value);
			}
		}

		[JsonProperty(PropertyName = "Excluded")]
		public string Excluded
		{
			get
			{
				return excluded;
			}
			set	
			{
				excluded = value;
				DictionaryUtil.Add(QueryParameters, "Excluded", value);
			}
		}

		[JsonProperty(PropertyName = "StartLength")]
		public int? StartLength
		{
			get
			{
				return startLength;
			}
			set	
			{
				startLength = value;
				DictionaryUtil.Add(QueryParameters, "StartLength", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "ResourceGroupId", value);
			}
		}

		[JsonProperty(PropertyName = "ExcludedSuffix")]
		public bool? ExcludedSuffix
		{
			get
			{
				return excludedSuffix;
			}
			set	
			{
				excludedSuffix = value;
				DictionaryUtil.Add(QueryParameters, "ExcludedSuffix", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "Lang")]
		public string Lang
		{
			get
			{
				return lang;
			}
			set	
			{
				lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

		[JsonProperty(PropertyName = "ExcludedPrefix")]
		public bool? ExcludedPrefix
		{
			get
			{
				return excludedPrefix;
			}
			set	
			{
				excludedPrefix = value;
				DictionaryUtil.Add(QueryParameters, "ExcludedPrefix", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "KeyWord")]
		public string KeyWord
		{
			get
			{
				return keyWord;
			}
			set	
			{
				keyWord = value;
				DictionaryUtil.Add(QueryParameters, "KeyWord", value);
			}
		}

		[JsonProperty(PropertyName = "EndExpirationDate")]
		public long? EndExpirationDate
		{
			get
			{
				return endExpirationDate;
			}
			set	
			{
				endExpirationDate = value;
				DictionaryUtil.Add(QueryParameters, "EndExpirationDate", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "Suffixs")]
		public string Suffixs
		{
			get
			{
				return suffixs;
			}
			set	
			{
				suffixs = value;
				DictionaryUtil.Add(QueryParameters, "Suffixs", value);
			}
		}

		[JsonProperty(PropertyName = "StartExpirationDate")]
		public long? StartExpirationDate
		{
			get
			{
				return startExpirationDate;
			}
			set	
			{
				startExpirationDate = value;
				DictionaryUtil.Add(QueryParameters, "StartExpirationDate", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "DomainStatus")]
		public int? DomainStatus
		{
			get
			{
				return domainStatus;
			}
			set	
			{
				domainStatus = value;
				DictionaryUtil.Add(QueryParameters, "DomainStatus", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "DomainGroupId")]
		public long? DomainGroupId
		{
			get
			{
				return domainGroupId;
			}
			set	
			{
				domainGroupId = value;
				DictionaryUtil.Add(QueryParameters, "DomainGroupId", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "KeyWordSuffix")]
		public bool? KeyWordSuffix
		{
			get
			{
				return keyWordSuffix;
			}
			set	
			{
				keyWordSuffix = value;
				DictionaryUtil.Add(QueryParameters, "KeyWordSuffix", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "ScrollId", value);
			}
		}

		[JsonProperty(PropertyName = "KeyWordPrefix")]
		public bool? KeyWordPrefix
		{
			get
			{
				return keyWordPrefix;
			}
			set	
			{
				keyWordPrefix = value;
				DictionaryUtil.Add(QueryParameters, "KeyWordPrefix", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "TradeType")]
		public int? TradeType
		{
			get
			{
				return tradeType;
			}
			set	
			{
				tradeType = value;
				DictionaryUtil.Add(QueryParameters, "TradeType", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "EndRegistrationDate")]
		public long? EndRegistrationDate
		{
			get
			{
				return endRegistrationDate;
			}
			set	
			{
				endRegistrationDate = value;
				DictionaryUtil.Add(QueryParameters, "EndRegistrationDate", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "Form")]
		public int? Form
		{
			get
			{
				return form;
			}
			set	
			{
				form = value;
				DictionaryUtil.Add(QueryParameters, "Form", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "UserClientIp")]
		public string UserClientIp
		{
			get
			{
				return userClientIp;
			}
			set	
			{
				userClientIp = value;
				DictionaryUtil.Add(QueryParameters, "UserClientIp", value);
			}
		}

		[JsonProperty(PropertyName = "StartRegistrationDate")]
		public long? StartRegistrationDate
		{
			get
			{
				return startRegistrationDate;
			}
			set	
			{
				startRegistrationDate = value;
				DictionaryUtil.Add(QueryParameters, "StartRegistrationDate", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "EndLength")]
		public int? EndLength
		{
			get
			{
				return endLength;
			}
			set	
			{
				endLength = value;
				DictionaryUtil.Add(QueryParameters, "EndLength", value.ToString());
			}
		}

        public override ScrollDomainListResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ScrollDomainListResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
