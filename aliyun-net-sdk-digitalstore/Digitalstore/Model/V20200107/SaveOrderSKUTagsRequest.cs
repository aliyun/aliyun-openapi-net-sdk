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
using Aliyun.Acs.digitalstore.Transform;
using Aliyun.Acs.digitalstore.Transform.V20200107;

namespace Aliyun.Acs.digitalstore.Model.V20200107
{
    public class SaveOrderSKUTagsRequest : RpcAcsRequest<SaveOrderSKUTagsResponse>
    {
        public SaveOrderSKUTagsRequest()
            : base("digitalstore", "2020-01-07", "SaveOrderSKUTags", "digitalstore", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string orderId;

		private List<SkuTags> skuTagss = new List<SkuTags>(){ };

		private string orderType;

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

		public List<SkuTags> SkuTagss
		{
			get
			{
				return skuTagss;
			}

			set
			{
				skuTagss = value;
				for (int i = 0; i < skuTagss.Count; i++)
				{
					DictionaryUtil.Add(BodyParameters,"SkuTags." + (i + 1) + ".TagValue", skuTagss[i].TagValue);
					DictionaryUtil.Add(BodyParameters,"SkuTags." + (i + 1) + ".CaseId", skuTagss[i].CaseId);
					DictionaryUtil.Add(BodyParameters,"SkuTags." + (i + 1) + ".DeviceId", skuTagss[i].DeviceId);
					DictionaryUtil.Add(BodyParameters,"SkuTags." + (i + 1) + ".Barcode", skuTagss[i].Barcode);
				}
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
				DictionaryUtil.Add(BodyParameters, "OrderType", value);
			}
		}

		public class SkuTags
		{

			private string tagValue;

			private string caseId;

			private string deviceId;

			private string barcode;

			public string TagValue
			{
				get
				{
					return tagValue;
				}
				set	
				{
					tagValue = value;
				}
			}

			public string CaseId
			{
				get
				{
					return caseId;
				}
				set	
				{
					caseId = value;
				}
			}

			public string DeviceId
			{
				get
				{
					return deviceId;
				}
				set	
				{
					deviceId = value;
				}
			}

			public string Barcode
			{
				get
				{
					return barcode;
				}
				set	
				{
					barcode = value;
				}
			}
		}

        public override SaveOrderSKUTagsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SaveOrderSKUTagsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
