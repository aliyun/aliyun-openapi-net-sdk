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
using Aliyun.Acs.IntlMarket;
using Aliyun.Acs.IntlMarket.Transform;
using Aliyun.Acs.IntlMarket.Transform.V20250812;

namespace Aliyun.Acs.IntlMarket.Model.V20250812
{
    public class CreateOrderRequest : RpcAcsRequest<CreateOrderResponse>
    {
        public CreateOrderRequest()
            : base("IntlMarket", "2025-08-12", "CreateOrder")
        {
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string orderSouce;

		private string commodity;

		private string clientToken;

		private string ownerId;

		private string paymentType;

		private string orderType;

		public string OrderSouce
		{
			get
			{
				return orderSouce;
			}
			set	
			{
				orderSouce = value;
				DictionaryUtil.Add(QueryParameters, "OrderSouce", value);
			}
		}

		public string Commodity
		{
			get
			{
				return commodity;
			}
			set	
			{
				commodity = value;
				DictionaryUtil.Add(QueryParameters, "Commodity", value);
			}
		}

		public string ClientToken
		{
			get
			{
				return clientToken;
			}
			set	
			{
				clientToken = value;
				DictionaryUtil.Add(QueryParameters, "ClientToken", value);
			}
		}

		public string OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value);
			}
		}

		public string PaymentType
		{
			get
			{
				return paymentType;
			}
			set	
			{
				paymentType = value;
				DictionaryUtil.Add(QueryParameters, "PaymentType", value);
			}
		}

		public string OrderType
		{
			get
			{
				return orderType;
			}
			set	
			{
				orderType = value;
				DictionaryUtil.Add(QueryParameters, "OrderType", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateOrderResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateOrderResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
