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
using Aliyun.Acs.BssOpenApi.Transform;
using Aliyun.Acs.BssOpenApi.Transform.V20171214;

namespace Aliyun.Acs.BssOpenApi.Model.V20171214
{
    public class CreateSavingsPlansInstanceRequest : RpcAcsRequest<CreateSavingsPlansInstanceResponse>
    {
        public CreateSavingsPlansInstanceRequest()
            : base("BssOpenApi", "2017-12-14", "CreateSavingsPlansInstance", "bssopenapi", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.BssOpenApi.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.BssOpenApi.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string specification;

		private string poolValue;

		private string commodityCode;

		private string type;

		private string effectiveDate;

		private string duration;

		private string specType;

		private string extendMap;

		private string payMode;

		private string region;

		private string pricingCycle;

		[JsonProperty(PropertyName = "Specification")]
		public string Specification
		{
			get
			{
				return specification;
			}
			set	
			{
				specification = value;
				DictionaryUtil.Add(QueryParameters, "Specification", value);
			}
		}

		[JsonProperty(PropertyName = "PoolValue")]
		public string PoolValue
		{
			get
			{
				return poolValue;
			}
			set	
			{
				poolValue = value;
				DictionaryUtil.Add(QueryParameters, "PoolValue", value);
			}
		}

		[JsonProperty(PropertyName = "CommodityCode")]
		public string CommodityCode
		{
			get
			{
				return commodityCode;
			}
			set	
			{
				commodityCode = value;
				DictionaryUtil.Add(QueryParameters, "CommodityCode", value);
			}
		}

		[JsonProperty(PropertyName = "Type")]
		public string Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
				DictionaryUtil.Add(QueryParameters, "Type", value);
			}
		}

		[JsonProperty(PropertyName = "EffectiveDate")]
		public string EffectiveDate
		{
			get
			{
				return effectiveDate;
			}
			set	
			{
				effectiveDate = value;
				DictionaryUtil.Add(QueryParameters, "EffectiveDate", value);
			}
		}

		[JsonProperty(PropertyName = "Duration")]
		public string Duration
		{
			get
			{
				return duration;
			}
			set	
			{
				duration = value;
				DictionaryUtil.Add(QueryParameters, "Duration", value);
			}
		}

		[JsonProperty(PropertyName = "SpecType")]
		public string SpecType
		{
			get
			{
				return specType;
			}
			set	
			{
				specType = value;
				DictionaryUtil.Add(QueryParameters, "SpecType", value);
			}
		}

		[JsonProperty(PropertyName = "ExtendMap")]
		public string ExtendMap
		{
			get
			{
				return extendMap;
			}
			set	
			{
				extendMap = value;
				DictionaryUtil.Add(QueryParameters, "ExtendMap", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "PayMode")]
		public string PayMode
		{
			get
			{
				return payMode;
			}
			set	
			{
				payMode = value;
				DictionaryUtil.Add(QueryParameters, "PayMode", value);
			}
		}

		[JsonProperty(PropertyName = "Region")]
		public string Region
		{
			get
			{
				return region;
			}
			set	
			{
				region = value;
				DictionaryUtil.Add(QueryParameters, "Region", value);
			}
		}

		[JsonProperty(PropertyName = "PricingCycle")]
		public string PricingCycle
		{
			get
			{
				return pricingCycle;
			}
			set	
			{
				pricingCycle = value;
				DictionaryUtil.Add(QueryParameters, "PricingCycle", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateSavingsPlansInstanceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateSavingsPlansInstanceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
