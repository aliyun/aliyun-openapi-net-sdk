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
    public class QueryWithPayRequest : RpcAcsRequest<QueryWithPayResponse>
    {
        public QueryWithPayRequest()
            : base("UniMkt", "2018-12-07", "QueryWithPay", "uniMkt", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.UniMkt.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.UniMkt.Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string extra;

		private float? salePrice;

		private string commodityId;

		private string alipayOpenId;

		private string deviceSn;

		private string channelId;

		public string Extra
		{
			get
			{
				return extra;
			}
			set	
			{
				extra = value;
				DictionaryUtil.Add(BodyParameters, "Extra", value);
			}
		}

		public float? SalePrice
		{
			get
			{
				return salePrice;
			}
			set	
			{
				salePrice = value;
				DictionaryUtil.Add(BodyParameters, "SalePrice", value.ToString());
			}
		}

		public string CommodityId
		{
			get
			{
				return commodityId;
			}
			set	
			{
				commodityId = value;
				DictionaryUtil.Add(BodyParameters, "CommodityId", value);
			}
		}

		public string AlipayOpenId
		{
			get
			{
				return alipayOpenId;
			}
			set	
			{
				alipayOpenId = value;
				DictionaryUtil.Add(BodyParameters, "AlipayOpenId", value);
			}
		}

		public string DeviceSn
		{
			get
			{
				return deviceSn;
			}
			set	
			{
				deviceSn = value;
				DictionaryUtil.Add(BodyParameters, "DeviceSn", value);
			}
		}

		public string ChannelId
		{
			get
			{
				return channelId;
			}
			set	
			{
				channelId = value;
				DictionaryUtil.Add(BodyParameters, "ChannelId", value);
			}
		}

        public override QueryWithPayResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return QueryWithPayResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
