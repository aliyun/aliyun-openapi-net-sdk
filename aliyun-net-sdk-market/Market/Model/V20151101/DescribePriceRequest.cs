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
using Aliyun.Acs.Market.Transform;
using Aliyun.Acs.Market.Transform.V20151101;

namespace Aliyun.Acs.Market.Model.V20151101
{
    public class DescribePriceRequest : RpcAcsRequest<DescribePriceResponse>
    {
        public DescribePriceRequest()
            : base("Market", "2015-11-01", "DescribePrice", "yunmarket", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Market.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Market.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string commodity;

		private string orderType;

		[JsonProperty(PropertyName = "Commodity")]
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

		[JsonProperty(PropertyName = "OrderType")]
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

        public override DescribePriceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribePriceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
