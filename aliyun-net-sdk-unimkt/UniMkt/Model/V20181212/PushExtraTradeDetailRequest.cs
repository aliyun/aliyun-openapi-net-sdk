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
using Aliyun.Acs.UniMkt.Transform.V20181212;

namespace Aliyun.Acs.UniMkt.Model.V20181212
{
    public class PushExtraTradeDetailRequest : RpcAcsRequest<PushExtraTradeDetailResponse>
    {
        public PushExtraTradeDetailRequest()
            : base("UniMkt", "2018-12-12", "PushExtraTradeDetail", "uniMkt", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.UniMkt.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.UniMkt.Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string orderId;

		private float? salePrice;

		private int? tradeStatus;

		private string commodityId;

		private string deviceSn;

		private string channelId;

		private string commodityName;

		private long? tradeTime;

		private float? tradePrice;

		public string OrderId
		{
			get
			{
				return orderId;
			}
			set	
			{
				orderId = value;
				DictionaryUtil.Add(BodyParameters, "OrderId", value);
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

		public int? TradeStatus
		{
			get
			{
				return tradeStatus;
			}
			set	
			{
				tradeStatus = value;
				DictionaryUtil.Add(BodyParameters, "TradeStatus", value.ToString());
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

		public string CommodityName
		{
			get
			{
				return commodityName;
			}
			set	
			{
				commodityName = value;
				DictionaryUtil.Add(BodyParameters, "CommodityName", value);
			}
		}

		public long? TradeTime
		{
			get
			{
				return tradeTime;
			}
			set	
			{
				tradeTime = value;
				DictionaryUtil.Add(BodyParameters, "TradeTime", value.ToString());
			}
		}

		public float? TradePrice
		{
			get
			{
				return tradePrice;
			}
			set	
			{
				tradePrice = value;
				DictionaryUtil.Add(BodyParameters, "TradePrice", value.ToString());
			}
		}

        public override PushExtraTradeDetailResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return PushExtraTradeDetailResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
