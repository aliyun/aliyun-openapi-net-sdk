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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Domain;
using Aliyun.Acs.Domain.Transform;
using Aliyun.Acs.Domain.Transform.V20180129;

namespace Aliyun.Acs.Domain.Model.V20180129
{
    public class SaveBatchTaskForCreatingOrderActivateRequest : RpcAcsRequest<SaveBatchTaskForCreatingOrderActivateResponse>
    {
        public SaveBatchTaskForCreatingOrderActivateRequest()
            : base("Domain", "2018-01-29", "SaveBatchTaskForCreatingOrderActivate")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Domain.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Domain.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private List<string> orderActivateParams = new List<string>(){ };

		private string couponNo;

		private bool? useCoupon;

		private string promotionNo;

		private string userClientIp;

		private string lang;

		private bool? usePromotion;

		public List<string> OrderActivateParams
		{
			get
			{
				return orderActivateParams;
			}

			set
			{
				orderActivateParams = value;
				if(orderActivateParams != null)
				{
					for (int depth1 = 0; depth1 < orderActivateParams.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"OrderActivateParam." + (depth1 + 1), orderActivateParams[depth1]);
						DictionaryUtil.Add(QueryParameters,"OrderActivateParam." + (depth1 + 1), orderActivateParams[depth1]);
						DictionaryUtil.Add(QueryParameters,"OrderActivateParam." + (depth1 + 1), orderActivateParams[depth1]);
						DictionaryUtil.Add(QueryParameters,"OrderActivateParam." + (depth1 + 1), orderActivateParams[depth1]);
						DictionaryUtil.Add(QueryParameters,"OrderActivateParam." + (depth1 + 1), orderActivateParams[depth1]);
						DictionaryUtil.Add(QueryParameters,"OrderActivateParam." + (depth1 + 1), orderActivateParams[depth1]);
						DictionaryUtil.Add(QueryParameters,"OrderActivateParam." + (depth1 + 1), orderActivateParams[depth1]);
						DictionaryUtil.Add(QueryParameters,"OrderActivateParam." + (depth1 + 1), orderActivateParams[depth1]);
						DictionaryUtil.Add(QueryParameters,"OrderActivateParam." + (depth1 + 1), orderActivateParams[depth1]);
						DictionaryUtil.Add(QueryParameters,"OrderActivateParam." + (depth1 + 1), orderActivateParams[depth1]);
						DictionaryUtil.Add(QueryParameters,"OrderActivateParam." + (depth1 + 1), orderActivateParams[depth1]);
						DictionaryUtil.Add(QueryParameters,"OrderActivateParam." + (depth1 + 1), orderActivateParams[depth1]);
						DictionaryUtil.Add(QueryParameters,"OrderActivateParam." + (depth1 + 1), orderActivateParams[depth1]);
						DictionaryUtil.Add(QueryParameters,"OrderActivateParam." + (depth1 + 1), orderActivateParams[depth1]);
						DictionaryUtil.Add(QueryParameters,"OrderActivateParam." + (depth1 + 1), orderActivateParams[depth1]);
						DictionaryUtil.Add(QueryParameters,"OrderActivateParam." + (depth1 + 1), orderActivateParams[depth1]);
						DictionaryUtil.Add(QueryParameters,"OrderActivateParam." + (depth1 + 1), orderActivateParams[depth1]);
						DictionaryUtil.Add(QueryParameters,"OrderActivateParam." + (depth1 + 1), orderActivateParams[depth1]);
						DictionaryUtil.Add(QueryParameters,"OrderActivateParam." + (depth1 + 1), orderActivateParams[depth1]);
						DictionaryUtil.Add(QueryParameters,"OrderActivateParam." + (depth1 + 1), orderActivateParams[depth1]);
						DictionaryUtil.Add(QueryParameters,"OrderActivateParam." + (depth1 + 1), orderActivateParams[depth1]);
						DictionaryUtil.Add(QueryParameters,"OrderActivateParam." + (depth1 + 1), orderActivateParams[depth1]);
						DictionaryUtil.Add(QueryParameters,"OrderActivateParam." + (depth1 + 1), orderActivateParams[depth1]);
						DictionaryUtil.Add(QueryParameters,"OrderActivateParam." + (depth1 + 1), orderActivateParams[depth1]);
						DictionaryUtil.Add(QueryParameters,"OrderActivateParam." + (depth1 + 1), orderActivateParams[depth1]);
						DictionaryUtil.Add(QueryParameters,"OrderActivateParam." + (depth1 + 1), orderActivateParams[depth1]);
					}
				}
			}
		}

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

		public class OrderActivateParam
		{

			private string country;

			private int? subscriptionDuration;

			private bool? permitPremiumActivation;

			private string city;

			private string dns2;

			private string dns1;

			private long? registrantProfileId;

			private bool? aliyunDns;

			private string zhCity;

			private string telExt;

			private string zhRegistrantName;

			private string province;

			private string postalCode;

			private string email;

			private string zhRegistrantOrganization;

			private string address;

			private string telArea;

			private string domainName;

			private string registrantType;

			private string zhAddress;

			private string telephone;

			private bool? trademarkDomainActivation;

			private string zhProvince;

			private string registrantOrganization;

			private bool? enableDomainProxy;

			private string registrantName;

			public string Country
			{
				get
				{
					return country;
				}
				set	
				{
					country = value;
				}
			}

			public int? SubscriptionDuration
			{
				get
				{
					return subscriptionDuration;
				}
				set	
				{
					subscriptionDuration = value;
				}
			}

			public bool? PermitPremiumActivation
			{
				get
				{
					return permitPremiumActivation;
				}
				set	
				{
					permitPremiumActivation = value;
				}
			}

			public string City
			{
				get
				{
					return city;
				}
				set	
				{
					city = value;
				}
			}

			public string Dns2
			{
				get
				{
					return dns2;
				}
				set	
				{
					dns2 = value;
				}
			}

			public string Dns1
			{
				get
				{
					return dns1;
				}
				set	
				{
					dns1 = value;
				}
			}

			public long? RegistrantProfileId
			{
				get
				{
					return registrantProfileId;
				}
				set	
				{
					registrantProfileId = value;
				}
			}

			public bool? AliyunDns
			{
				get
				{
					return aliyunDns;
				}
				set	
				{
					aliyunDns = value;
				}
			}

			public string ZhCity
			{
				get
				{
					return zhCity;
				}
				set	
				{
					zhCity = value;
				}
			}

			public string TelExt
			{
				get
				{
					return telExt;
				}
				set	
				{
					telExt = value;
				}
			}

			public string ZhRegistrantName
			{
				get
				{
					return zhRegistrantName;
				}
				set	
				{
					zhRegistrantName = value;
				}
			}

			public string Province
			{
				get
				{
					return province;
				}
				set	
				{
					province = value;
				}
			}

			public string PostalCode
			{
				get
				{
					return postalCode;
				}
				set	
				{
					postalCode = value;
				}
			}

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

			public string Address
			{
				get
				{
					return address;
				}
				set	
				{
					address = value;
				}
			}

			public string TelArea
			{
				get
				{
					return telArea;
				}
				set	
				{
					telArea = value;
				}
			}

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

			public string ZhAddress
			{
				get
				{
					return zhAddress;
				}
				set	
				{
					zhAddress = value;
				}
			}

			public string Telephone
			{
				get
				{
					return telephone;
				}
				set	
				{
					telephone = value;
				}
			}

			public bool? TrademarkDomainActivation
			{
				get
				{
					return trademarkDomainActivation;
				}
				set	
				{
					trademarkDomainActivation = value;
				}
			}

			public string ZhProvince
			{
				get
				{
					return zhProvince;
				}
				set	
				{
					zhProvince = value;
				}
			}

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

			public bool? EnableDomainProxy
			{
				get
				{
					return enableDomainProxy;
				}
				set	
				{
					enableDomainProxy = value;
				}
			}

			public string RegistrantName
			{
				get
				{
					return registrantName;
				}
				set	
				{
					registrantName = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SaveBatchTaskForCreatingOrderActivateResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SaveBatchTaskForCreatingOrderActivateResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
