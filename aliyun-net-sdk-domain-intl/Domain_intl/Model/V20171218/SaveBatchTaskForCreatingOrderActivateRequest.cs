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
using Aliyun.Acs.Domain_intl.Transform;
using Aliyun.Acs.Domain_intl.Transform.V20171218;

namespace Aliyun.Acs.Domain_intl.Model.V20171218
{
    public class SaveBatchTaskForCreatingOrderActivateRequest : RpcAcsRequest<SaveBatchTaskForCreatingOrderActivateResponse>
    {
        public SaveBatchTaskForCreatingOrderActivateRequest()
            : base("Domain-intl", "2017-12-18", "SaveBatchTaskForCreatingOrderActivate", "domain", "openAPI")
        {
        }

		private List<OrderActivateParam> orderActivateParams = new List<OrderActivateParam>(){ };

		private string couponNo;

		private bool? useCoupon;

		private string promotionNo;

		private string userClientIp;

		private string lang;

		private bool? usePromotion;

		public List<OrderActivateParam> OrderActivateParams
		{
			get
			{
				return orderActivateParams;
			}

			set
			{
				orderActivateParams = value;
				for (int i = 0; i < orderActivateParams.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"OrderActivateParam." + (i + 1) + ".Country", orderActivateParams[i].Country);
					DictionaryUtil.Add(QueryParameters,"OrderActivateParam." + (i + 1) + ".SubscriptionDuration", orderActivateParams[i].SubscriptionDuration);
					DictionaryUtil.Add(QueryParameters,"OrderActivateParam." + (i + 1) + ".Address", orderActivateParams[i].Address);
					DictionaryUtil.Add(QueryParameters,"OrderActivateParam." + (i + 1) + ".PermitPremiumActivation", orderActivateParams[i].PermitPremiumActivation);
					DictionaryUtil.Add(QueryParameters,"OrderActivateParam." + (i + 1) + ".TelArea", orderActivateParams[i].TelArea);
					DictionaryUtil.Add(QueryParameters,"OrderActivateParam." + (i + 1) + ".City", orderActivateParams[i].City);
					DictionaryUtil.Add(QueryParameters,"OrderActivateParam." + (i + 1) + ".Dns2", orderActivateParams[i].Dns2);
					DictionaryUtil.Add(QueryParameters,"OrderActivateParam." + (i + 1) + ".Dns1", orderActivateParams[i].Dns1);
					DictionaryUtil.Add(QueryParameters,"OrderActivateParam." + (i + 1) + ".DomainName", orderActivateParams[i].DomainName);
					DictionaryUtil.Add(QueryParameters,"OrderActivateParam." + (i + 1) + ".RegistrantProfileId", orderActivateParams[i].RegistrantProfileId);
					DictionaryUtil.Add(QueryParameters,"OrderActivateParam." + (i + 1) + ".RegistrantType", orderActivateParams[i].RegistrantType);
					DictionaryUtil.Add(QueryParameters,"OrderActivateParam." + (i + 1) + ".Telephone", orderActivateParams[i].Telephone);
					DictionaryUtil.Add(QueryParameters,"OrderActivateParam." + (i + 1) + ".TrademarkDomainActivation", orderActivateParams[i].TrademarkDomainActivation);
					DictionaryUtil.Add(QueryParameters,"OrderActivateParam." + (i + 1) + ".AliyunDns", orderActivateParams[i].AliyunDns);
					DictionaryUtil.Add(QueryParameters,"OrderActivateParam." + (i + 1) + ".RegistrantOrganization", orderActivateParams[i].RegistrantOrganization);
					DictionaryUtil.Add(QueryParameters,"OrderActivateParam." + (i + 1) + ".TelExt", orderActivateParams[i].TelExt);
					DictionaryUtil.Add(QueryParameters,"OrderActivateParam." + (i + 1) + ".Province", orderActivateParams[i].Province);
					DictionaryUtil.Add(QueryParameters,"OrderActivateParam." + (i + 1) + ".PostalCode", orderActivateParams[i].PostalCode);
					DictionaryUtil.Add(QueryParameters,"OrderActivateParam." + (i + 1) + ".EnableDomainProxy", orderActivateParams[i].EnableDomainProxy);
					DictionaryUtil.Add(QueryParameters,"OrderActivateParam." + (i + 1) + ".Email", orderActivateParams[i].Email);
					DictionaryUtil.Add(QueryParameters,"OrderActivateParam." + (i + 1) + ".RegistrantName", orderActivateParams[i].RegistrantName);
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

			private string address;

			private bool? permitPremiumActivation;

			private string telArea;

			private string city;

			private string dns2;

			private string dns1;

			private string domainName;

			private long? registrantProfileId;

			private string registrantType;

			private string telephone;

			private bool? trademarkDomainActivation;

			private bool? aliyunDns;

			private string registrantOrganization;

			private string telExt;

			private string province;

			private string postalCode;

			private bool? enableDomainProxy;

			private string email;

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
