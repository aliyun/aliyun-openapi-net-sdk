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
    public class SaveBatchTaskForCreatingOrderRedeemRequest : RpcAcsRequest<SaveBatchTaskForCreatingOrderRedeemResponse>
    {
        public SaveBatchTaskForCreatingOrderRedeemRequest()
            : base("Domain", "2018-01-29", "SaveBatchTaskForCreatingOrderRedeem", "domain", "openAPI")
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

		private List<OrderRedeemParam> orderRedeemParams = new List<OrderRedeemParam>(){ };

		private string userClientIp;

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

		public List<OrderRedeemParam> OrderRedeemParams
		{
			get
			{
				return orderRedeemParams;
			}

			set
			{
				orderRedeemParams = value;
				for (int i = 0; i < orderRedeemParams.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"OrderRedeemParam." + (i + 1) + ".CurrentExpirationDate", orderRedeemParams[i].CurrentExpirationDate);
					DictionaryUtil.Add(QueryParameters,"OrderRedeemParam." + (i + 1) + ".DomainName", orderRedeemParams[i].DomainName);
				}
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

		public class OrderRedeemParam
		{

			private long? currentExpirationDate;

			private string domainName;

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

        public override SaveBatchTaskForCreatingOrderRedeemResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SaveBatchTaskForCreatingOrderRedeemResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
