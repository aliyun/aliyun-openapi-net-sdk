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
    public class SaveSingleTaskForCreatingOrderActivateRequest : RpcAcsRequest<SaveSingleTaskForCreatingOrderActivateResponse>
    {
        public SaveSingleTaskForCreatingOrderActivateRequest()
            : base("Domain", "2018-01-29", "SaveSingleTaskForCreatingOrderActivate", "domain", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Domain.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Domain.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string country;

		private string dns2;

		private string dns1;

		private string couponNo;

		private string zhCity;

		private string resourceGroupId;

		private string telExt;

		private string province;

		private string domainName;

		private string zhAddress;

		private string telephone;

		private string zhProvince;

		private string registrantOrganization;

		private string promotionNo;

		private string registrantName;

		private bool? usePromotion;

		private int? subscriptionDuration;

		private bool? permitPremiumActivation;

		private string city;

		private long? registrantProfileId;

		private bool? aliyunDns;

		private string zhRegistrantName;

		private string postalCode;

		private string lang;

		private string email;

		private string zhRegistrantOrganization;

		private string address;

		private string telArea;

		private string registrantType;

		private bool? trademarkDomainActivation;

		private bool? useCoupon;

		private bool? enableDomainProxy;

		private string userClientIp;

		[JsonProperty(PropertyName = "Country")]
		public string Country
		{
			get
			{
				return country;
			}
			set	
			{
				country = value;
				DictionaryUtil.Add(QueryParameters, "Country", value);
			}
		}

		[JsonProperty(PropertyName = "Dns2")]
		public string Dns2
		{
			get
			{
				return dns2;
			}
			set	
			{
				dns2 = value;
				DictionaryUtil.Add(QueryParameters, "Dns2", value);
			}
		}

		[JsonProperty(PropertyName = "Dns1")]
		public string Dns1
		{
			get
			{
				return dns1;
			}
			set	
			{
				dns1 = value;
				DictionaryUtil.Add(QueryParameters, "Dns1", value);
			}
		}

		[JsonProperty(PropertyName = "CouponNo")]
		public string CouponNo
		{
			get
			{
				return couponNo;
			}
			set	
			{
				couponNo = value;
				DictionaryUtil.Add(QueryParameters, "CouponNo", value);
			}
		}

		[JsonProperty(PropertyName = "ZhCity")]
		public string ZhCity
		{
			get
			{
				return zhCity;
			}
			set	
			{
				zhCity = value;
				DictionaryUtil.Add(QueryParameters, "ZhCity", value);
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

		[JsonProperty(PropertyName = "TelExt")]
		public string TelExt
		{
			get
			{
				return telExt;
			}
			set	
			{
				telExt = value;
				DictionaryUtil.Add(QueryParameters, "TelExt", value);
			}
		}

		[JsonProperty(PropertyName = "Province")]
		public string Province
		{
			get
			{
				return province;
			}
			set	
			{
				province = value;
				DictionaryUtil.Add(QueryParameters, "Province", value);
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
				DictionaryUtil.Add(QueryParameters, "DomainName", value);
			}
		}

		[JsonProperty(PropertyName = "ZhAddress")]
		public string ZhAddress
		{
			get
			{
				return zhAddress;
			}
			set	
			{
				zhAddress = value;
				DictionaryUtil.Add(QueryParameters, "ZhAddress", value);
			}
		}

		[JsonProperty(PropertyName = "Telephone")]
		public string Telephone
		{
			get
			{
				return telephone;
			}
			set	
			{
				telephone = value;
				DictionaryUtil.Add(QueryParameters, "Telephone", value);
			}
		}

		[JsonProperty(PropertyName = "ZhProvince")]
		public string ZhProvince
		{
			get
			{
				return zhProvince;
			}
			set	
			{
				zhProvince = value;
				DictionaryUtil.Add(QueryParameters, "ZhProvince", value);
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
				DictionaryUtil.Add(QueryParameters, "RegistrantOrganization", value);
			}
		}

		[JsonProperty(PropertyName = "PromotionNo")]
		public string PromotionNo
		{
			get
			{
				return promotionNo;
			}
			set	
			{
				promotionNo = value;
				DictionaryUtil.Add(QueryParameters, "PromotionNo", value);
			}
		}

		[JsonProperty(PropertyName = "RegistrantName")]
		public string RegistrantName
		{
			get
			{
				return registrantName;
			}
			set	
			{
				registrantName = value;
				DictionaryUtil.Add(QueryParameters, "RegistrantName", value);
			}
		}

		[JsonProperty(PropertyName = "UsePromotion")]
		public bool? UsePromotion
		{
			get
			{
				return usePromotion;
			}
			set	
			{
				usePromotion = value;
				DictionaryUtil.Add(QueryParameters, "UsePromotion", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "SubscriptionDuration")]
		public int? SubscriptionDuration
		{
			get
			{
				return subscriptionDuration;
			}
			set	
			{
				subscriptionDuration = value;
				DictionaryUtil.Add(QueryParameters, "SubscriptionDuration", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "PermitPremiumActivation")]
		public bool? PermitPremiumActivation
		{
			get
			{
				return permitPremiumActivation;
			}
			set	
			{
				permitPremiumActivation = value;
				DictionaryUtil.Add(QueryParameters, "PermitPremiumActivation", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "City")]
		public string City
		{
			get
			{
				return city;
			}
			set	
			{
				city = value;
				DictionaryUtil.Add(QueryParameters, "City", value);
			}
		}

		[JsonProperty(PropertyName = "RegistrantProfileId")]
		public long? RegistrantProfileId
		{
			get
			{
				return registrantProfileId;
			}
			set	
			{
				registrantProfileId = value;
				DictionaryUtil.Add(QueryParameters, "RegistrantProfileId", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "AliyunDns")]
		public bool? AliyunDns
		{
			get
			{
				return aliyunDns;
			}
			set	
			{
				aliyunDns = value;
				DictionaryUtil.Add(QueryParameters, "AliyunDns", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "ZhRegistrantName")]
		public string ZhRegistrantName
		{
			get
			{
				return zhRegistrantName;
			}
			set	
			{
				zhRegistrantName = value;
				DictionaryUtil.Add(QueryParameters, "ZhRegistrantName", value);
			}
		}

		[JsonProperty(PropertyName = "PostalCode")]
		public string PostalCode
		{
			get
			{
				return postalCode;
			}
			set	
			{
				postalCode = value;
				DictionaryUtil.Add(QueryParameters, "PostalCode", value);
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
				DictionaryUtil.Add(QueryParameters, "Email", value);
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
				DictionaryUtil.Add(QueryParameters, "ZhRegistrantOrganization", value);
			}
		}

		[JsonProperty(PropertyName = "Address")]
		public string Address
		{
			get
			{
				return address;
			}
			set	
			{
				address = value;
				DictionaryUtil.Add(QueryParameters, "Address", value);
			}
		}

		[JsonProperty(PropertyName = "TelArea")]
		public string TelArea
		{
			get
			{
				return telArea;
			}
			set	
			{
				telArea = value;
				DictionaryUtil.Add(QueryParameters, "TelArea", value);
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
				DictionaryUtil.Add(QueryParameters, "RegistrantType", value);
			}
		}

		[JsonProperty(PropertyName = "TrademarkDomainActivation")]
		public bool? TrademarkDomainActivation
		{
			get
			{
				return trademarkDomainActivation;
			}
			set	
			{
				trademarkDomainActivation = value;
				DictionaryUtil.Add(QueryParameters, "TrademarkDomainActivation", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "UseCoupon")]
		public bool? UseCoupon
		{
			get
			{
				return useCoupon;
			}
			set	
			{
				useCoupon = value;
				DictionaryUtil.Add(QueryParameters, "UseCoupon", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "EnableDomainProxy")]
		public bool? EnableDomainProxy
		{
			get
			{
				return enableDomainProxy;
			}
			set	
			{
				enableDomainProxy = value;
				DictionaryUtil.Add(QueryParameters, "EnableDomainProxy", value.ToString());
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SaveSingleTaskForCreatingOrderActivateResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SaveSingleTaskForCreatingOrderActivateResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
