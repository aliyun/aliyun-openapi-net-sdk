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
using Aliyun.Acs.appstream_center;
using Aliyun.Acs.appstream_center.Transform;
using Aliyun.Acs.appstream_center.Transform.V20210901;

namespace Aliyun.Acs.appstream_center.Model.V20210901
{
    public class GetResourcePriceRequest : RpcAcsRequest<GetResourcePriceResponse>
    {
        public GetResourcePriceRequest()
            : base("appstream-center", "2021-09-01", "GetResourcePrice")
        {
			Method = MethodType.POST;
        }

		private string bizRegionId;

		private long? period;

		private long? amount;

		private string nodeInstanceType;

		private string productType;

		private string periodUnit;

		private string chargeType;

		[JsonProperty(PropertyName = "BizRegionId")]
		public string BizRegionId
		{
			get
			{
				return bizRegionId;
			}
			set	
			{
				bizRegionId = value;
				DictionaryUtil.Add(QueryParameters, "BizRegionId", value);
			}
		}

		[JsonProperty(PropertyName = "Period")]
		public long? Period
		{
			get
			{
				return period;
			}
			set	
			{
				period = value;
				DictionaryUtil.Add(QueryParameters, "Period", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "Amount")]
		public long? Amount
		{
			get
			{
				return amount;
			}
			set	
			{
				amount = value;
				DictionaryUtil.Add(QueryParameters, "Amount", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "NodeInstanceType")]
		public string NodeInstanceType
		{
			get
			{
				return nodeInstanceType;
			}
			set	
			{
				nodeInstanceType = value;
				DictionaryUtil.Add(QueryParameters, "NodeInstanceType", value);
			}
		}

		[JsonProperty(PropertyName = "ProductType")]
		public string ProductType
		{
			get
			{
				return productType;
			}
			set	
			{
				productType = value;
				DictionaryUtil.Add(QueryParameters, "ProductType", value);
			}
		}

		[JsonProperty(PropertyName = "PeriodUnit")]
		public string PeriodUnit
		{
			get
			{
				return periodUnit;
			}
			set	
			{
				periodUnit = value;
				DictionaryUtil.Add(QueryParameters, "PeriodUnit", value);
			}
		}

		[JsonProperty(PropertyName = "ChargeType")]
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetResourcePriceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetResourcePriceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
