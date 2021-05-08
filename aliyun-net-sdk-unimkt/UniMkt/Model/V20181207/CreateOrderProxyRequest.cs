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
    public class CreateOrderProxyRequest : RpcAcsRequest<CreateOrderProxyResponse>
    {
        public CreateOrderProxyRequest()
            : base("UniMkt", "2018-12-07", "CreateOrderProxy", "uniMkt", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.UniMkt.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.UniMkt.Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private float? salePrice;

		private string commodityId;

		private string holderId;

		private string promotionId;

		private string deviceType;

		private string alipayUid;

		private string deviceCode;

		private string v;

		private string channelId;

		private string outerCode;

		private string queryStr;

		public float? SalePrice
		{
			get
			{
				return salePrice;
			}
			set	
			{
				salePrice = value;
				DictionaryUtil.Add(QueryParameters, "SalePrice", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "CommodityId", value);
			}
		}

		public string HolderId
		{
			get
			{
				return holderId;
			}
			set	
			{
				holderId = value;
				DictionaryUtil.Add(QueryParameters, "HolderId", value);
			}
		}

		public string PromotionId
		{
			get
			{
				return promotionId;
			}
			set	
			{
				promotionId = value;
				DictionaryUtil.Add(QueryParameters, "PromotionId", value);
			}
		}

		public string DeviceType
		{
			get
			{
				return deviceType;
			}
			set	
			{
				deviceType = value;
				DictionaryUtil.Add(QueryParameters, "DeviceType", value);
			}
		}

		public string AlipayUid
		{
			get
			{
				return alipayUid;
			}
			set	
			{
				alipayUid = value;
				DictionaryUtil.Add(QueryParameters, "AlipayUid", value);
			}
		}

		public string DeviceCode
		{
			get
			{
				return deviceCode;
			}
			set	
			{
				deviceCode = value;
				DictionaryUtil.Add(QueryParameters, "DeviceCode", value);
			}
		}

		public string V
		{
			get
			{
				return v;
			}
			set	
			{
				v = value;
				DictionaryUtil.Add(QueryParameters, "V", value);
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
				DictionaryUtil.Add(QueryParameters, "ChannelId", value);
			}
		}

		public string OuterCode
		{
			get
			{
				return outerCode;
			}
			set	
			{
				outerCode = value;
				DictionaryUtil.Add(QueryParameters, "OuterCode", value);
			}
		}

		public string QueryStr
		{
			get
			{
				return queryStr;
			}
			set	
			{
				queryStr = value;
				DictionaryUtil.Add(QueryParameters, "QueryStr", value);
			}
		}

        public override CreateOrderProxyResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateOrderProxyResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
