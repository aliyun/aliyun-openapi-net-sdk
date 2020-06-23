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
using Aliyun.Acs.Domain.Transform;
using Aliyun.Acs.Domain.Transform.V20180129;

namespace Aliyun.Acs.Domain.Model.V20180129
{
    public class SaveBatchTaskForCreatingOrderRenewRequest : RpcAcsRequest<SaveBatchTaskForCreatingOrderRenewResponse>
    {
        public SaveBatchTaskForCreatingOrderRenewRequest()
            : base("Domain", "2018-01-29", "SaveBatchTaskForCreatingOrderRenew", "domain", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string couponNo;

		private bool? useCoupon;

		private string promotionNo;

		private string userClientIp;

		private List<OrderRenewParam> orderRenewParams = new List<OrderRenewParam>(){ };

		private string lang;

		private bool? usePromotion;

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

		public List<OrderRenewParam> OrderRenewParams
		{
			get
			{
				return orderRenewParams;
			}

			set
			{
				orderRenewParams = value;
				for (int i = 0; i < orderRenewParams.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"OrderRenewParam." + (i + 1) + ".SubscriptionDuration", orderRenewParams[i].SubscriptionDuration);
					DictionaryUtil.Add(QueryParameters,"OrderRenewParam." + (i + 1) + ".CurrentExpirationDate", orderRenewParams[i].CurrentExpirationDate);
					DictionaryUtil.Add(QueryParameters,"OrderRenewParam." + (i + 1) + ".DomainName", orderRenewParams[i].DomainName);
				}
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

		public class OrderRenewParam
		{

			private int? subscriptionDuration;

			private long? currentExpirationDate;

			private string domainName;

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

			public long? CurrentExpirationDate
			{
				get
				{
					return currentExpirationDate;
				}
				set	
				{
					currentExpirationDate = value;
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
		}

        public override SaveBatchTaskForCreatingOrderRenewResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SaveBatchTaskForCreatingOrderRenewResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
