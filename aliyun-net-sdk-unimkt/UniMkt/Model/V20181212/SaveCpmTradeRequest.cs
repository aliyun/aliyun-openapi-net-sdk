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
    public class SaveCpmTradeRequest : RpcAcsRequest<SaveCpmTradeResponse>
    {
        public SaveCpmTradeRequest()
            : base("UniMkt", "2018-12-12", "SaveCpmTrade", "uniMkt", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.UniMkt.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.UniMkt.Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string taskType;

		private string realCostAmount;

		private string sex;

		private string costDetail;

		private string taskTag;

		private string bizType;

		private string deviceCode;

		private string v;

		private string applyPrice;

		private string chargeType;

		private string holdId;

		private string extendString;

		private string channelId;

		private int? age;

		private string taskId;

		private string advertType;

		private string outerCode;

		private long? tradeTime;

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

		public string TaskTag
		{
			get
			{
				return taskTag;
			}
			set	
			{
				taskTag = value;
				DictionaryUtil.Add(QueryParameters, "TaskTag", value);
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

		public string ApplyPrice
		{
			get
			{
				return applyPrice;
			}
			set	
			{
				applyPrice = value;
				DictionaryUtil.Add(QueryParameters, "ApplyPrice", value);
			}
		}

		public string ChargeType
		{
			get
			{
				return chargeType;
			}
			set	
			{
				chargeType = value;
				DictionaryUtil.Add(QueryParameters, "ChargeType", value);
			}
		}

		public string HoldId
		{
			get
			{
				return holdId;
			}
			set	
			{
				holdId = value;
				DictionaryUtil.Add(QueryParameters, "HoldId", value);
			}
		}

		public string ExtendString
		{
			get
			{
				return extendString;
			}
			set	
			{
				extendString = value;
				DictionaryUtil.Add(QueryParameters, "ExtendString", value);
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

		public string AdvertType
		{
			get
			{
				return advertType;
			}
			set	
			{
				advertType = value;
				DictionaryUtil.Add(QueryParameters, "AdvertType", value);
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

		public long? TradeTime
		{
			get
			{
				return tradeTime;
			}
			set	
			{
				tradeTime = value;
				DictionaryUtil.Add(QueryParameters, "TradeTime", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SaveCpmTradeResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SaveCpmTradeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
