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
using Aliyun.Acs.UniMkt.Transform;
using Aliyun.Acs.UniMkt.Transform.V20181207;

namespace Aliyun.Acs.UniMkt.Model.V20181207
{
    public class AccountOperateRequest : RpcAcsRequest<AccountOperateResponse>
    {
        public AccountOperateRequest()
            : base("UniMkt", "2018-12-07", "AccountOperate", "uniMkt", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.UniMkt.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.UniMkt.Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string accountManagerNumber;

		private string fromUserId;

		private string toAccountNo;

		private string cataloguePrice;

		private string bpId;

		private string operateName;

		private string balance;

		private string actualAmount;

		private string proxyUserNick;

		private string fromAccountNo;

		private string priceVersion;

		private string createTime;

		private string amount;

		private string accountManagerName;

		private string toUserId;

		private int? marketCount;

		private string proxyUserId;

		private string discountRate;

		private string accuActualAmount;

		private string flowId;

		private string preDebit;

		private string accuAmount;

		public string AccountManagerNumber
		{
			get
			{
				return accountManagerNumber;
			}
			set	
			{
				accountManagerNumber = value;
				DictionaryUtil.Add(BodyParameters, "AccountManagerNumber", value);
			}
		}

		public string FromUserId
		{
			get
			{
				return fromUserId;
			}
			set	
			{
				fromUserId = value;
				DictionaryUtil.Add(BodyParameters, "FromUserId", value);
			}
		}

		public string ToAccountNo
		{
			get
			{
				return toAccountNo;
			}
			set	
			{
				toAccountNo = value;
				DictionaryUtil.Add(BodyParameters, "ToAccountNo", value);
			}
		}

		public string CataloguePrice
		{
			get
			{
				return cataloguePrice;
			}
			set	
			{
				cataloguePrice = value;
				DictionaryUtil.Add(BodyParameters, "CataloguePrice", value);
			}
		}

		public string BpId
		{
			get
			{
				return bpId;
			}
			set	
			{
				bpId = value;
				DictionaryUtil.Add(BodyParameters, "BpId", value);
			}
		}

		public string OperateName
		{
			get
			{
				return operateName;
			}
			set	
			{
				operateName = value;
				DictionaryUtil.Add(BodyParameters, "OperateName", value);
			}
		}

		public string Balance
		{
			get
			{
				return balance;
			}
			set	
			{
				balance = value;
				DictionaryUtil.Add(BodyParameters, "Balance", value);
			}
		}

		public string ActualAmount
		{
			get
			{
				return actualAmount;
			}
			set	
			{
				actualAmount = value;
				DictionaryUtil.Add(BodyParameters, "ActualAmount", value);
			}
		}

		public string ProxyUserNick
		{
			get
			{
				return proxyUserNick;
			}
			set	
			{
				proxyUserNick = value;
				DictionaryUtil.Add(BodyParameters, "ProxyUserNick", value);
			}
		}

		public string FromAccountNo
		{
			get
			{
				return fromAccountNo;
			}
			set	
			{
				fromAccountNo = value;
				DictionaryUtil.Add(BodyParameters, "FromAccountNo", value);
			}
		}

		public string PriceVersion
		{
			get
			{
				return priceVersion;
			}
			set	
			{
				priceVersion = value;
				DictionaryUtil.Add(BodyParameters, "PriceVersion", value);
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
				DictionaryUtil.Add(BodyParameters, "CreateTime", value);
			}
		}

		public string Amount
		{
			get
			{
				return amount;
			}
			set	
			{
				amount = value;
				DictionaryUtil.Add(BodyParameters, "Amount", value);
			}
		}

		public string AccountManagerName
		{
			get
			{
				return accountManagerName;
			}
			set	
			{
				accountManagerName = value;
				DictionaryUtil.Add(BodyParameters, "AccountManagerName", value);
			}
		}

		public string ToUserId
		{
			get
			{
				return toUserId;
			}
			set	
			{
				toUserId = value;
				DictionaryUtil.Add(BodyParameters, "ToUserId", value);
			}
		}

		public int? MarketCount
		{
			get
			{
				return marketCount;
			}
			set	
			{
				marketCount = value;
				DictionaryUtil.Add(BodyParameters, "MarketCount", value.ToString());
			}
		}

		public string ProxyUserId
		{
			get
			{
				return proxyUserId;
			}
			set	
			{
				proxyUserId = value;
				DictionaryUtil.Add(BodyParameters, "ProxyUserId", value);
			}
		}

		public string DiscountRate
		{
			get
			{
				return discountRate;
			}
			set	
			{
				discountRate = value;
				DictionaryUtil.Add(BodyParameters, "DiscountRate", value);
			}
		}

		public string AccuActualAmount
		{
			get
			{
				return accuActualAmount;
			}
			set	
			{
				accuActualAmount = value;
				DictionaryUtil.Add(BodyParameters, "AccuActualAmount", value);
			}
		}

		public string FlowId
		{
			get
			{
				return flowId;
			}
			set	
			{
				flowId = value;
				DictionaryUtil.Add(BodyParameters, "FlowId", value);
			}
		}

		public string PreDebit
		{
			get
			{
				return preDebit;
			}
			set	
			{
				preDebit = value;
				DictionaryUtil.Add(BodyParameters, "PreDebit", value);
			}
		}

		public string AccuAmount
		{
			get
			{
				return accuAmount;
			}
			set	
			{
				accuAmount = value;
				DictionaryUtil.Add(BodyParameters, "AccuAmount", value);
			}
		}

        public override AccountOperateResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AccountOperateResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
