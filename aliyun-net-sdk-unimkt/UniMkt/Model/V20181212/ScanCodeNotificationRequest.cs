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
    public class ScanCodeNotificationRequest : RpcAcsRequest<ScanCodeNotificationResponse>
    {
        public ScanCodeNotificationRequest()
            : base("UniMkt", "2018-12-12", "ScanCodeNotification", "uniMkt", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.UniMkt.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.UniMkt.Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string realCostAmount;

		private int? salePrice;

		private string commodityId;

		private string holderId;

		private string deviceType;

		private string deviceCode;

		private int? applyPrice;

		private string taskId;

		private string outerCode;

		private string queryStr;

		private string phase;

		private string bizResult;

		private string taskType;

		private string brandUserId;

		private string sex;

		private string costDetail;

		private string proxyUserId;

		private string alipayOpenId;

		private string bizType;

		private string brandNick;

		private string v;

		private string chargeTag;

		private int? age;

		private string channelId;

		private string cid;

		public string RealCostAmount
		{
			get
			{
				return realCostAmount;
			}
			set	
			{
				realCostAmount = value;
				DictionaryUtil.Add(QueryParameters, "RealCostAmount", value);
			}
		}

		public int? SalePrice
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

		public int? ApplyPrice
		{
			get
			{
				return applyPrice;
			}
			set	
			{
				applyPrice = value;
				DictionaryUtil.Add(QueryParameters, "ApplyPrice", value.ToString());
			}
		}

		public string TaskId
		{
			get
			{
				return taskId;
			}
			set	
			{
				taskId = value;
				DictionaryUtil.Add(QueryParameters, "TaskId", value);
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

		public string Phase
		{
			get
			{
				return phase;
			}
			set	
			{
				phase = value;
				DictionaryUtil.Add(QueryParameters, "Phase", value);
			}
		}

		public string BizResult
		{
			get
			{
				return bizResult;
			}
			set	
			{
				bizResult = value;
				DictionaryUtil.Add(QueryParameters, "BizResult", value);
			}
		}

		public string TaskType
		{
			get
			{
				return taskType;
			}
			set	
			{
				taskType = value;
				DictionaryUtil.Add(QueryParameters, "TaskType", value);
			}
		}

		public string BrandUserId
		{
			get
			{
				return brandUserId;
			}
			set	
			{
				brandUserId = value;
				DictionaryUtil.Add(QueryParameters, "BrandUserId", value);
			}
		}

		public string Sex
		{
			get
			{
				return sex;
			}
			set	
			{
				sex = value;
				DictionaryUtil.Add(QueryParameters, "Sex", value);
			}
		}

		public string CostDetail
		{
			get
			{
				return costDetail;
			}
			set	
			{
				costDetail = value;
				DictionaryUtil.Add(QueryParameters, "CostDetail", value);
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
				DictionaryUtil.Add(QueryParameters, "ProxyUserId", value);
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
				DictionaryUtil.Add(QueryParameters, "AlipayOpenId", value);
			}
		}

		public string BizType
		{
			get
			{
				return bizType;
			}
			set	
			{
				bizType = value;
				DictionaryUtil.Add(QueryParameters, "BizType", value);
			}
		}

		public string BrandNick
		{
			get
			{
				return brandNick;
			}
			set	
			{
				brandNick = value;
				DictionaryUtil.Add(QueryParameters, "BrandNick", value);
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

		public string ChargeTag
		{
			get
			{
				return chargeTag;
			}
			set	
			{
				chargeTag = value;
				DictionaryUtil.Add(QueryParameters, "ChargeTag", value);
			}
		}

		public int? Age
		{
			get
			{
				return age;
			}
			set	
			{
				age = value;
				DictionaryUtil.Add(QueryParameters, "Age", value.ToString());
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

		public string Cid
		{
			get
			{
				return cid;
			}
			set	
			{
				cid = value;
				DictionaryUtil.Add(QueryParameters, "Cid", value);
			}
		}

        public override ScanCodeNotificationResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ScanCodeNotificationResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
