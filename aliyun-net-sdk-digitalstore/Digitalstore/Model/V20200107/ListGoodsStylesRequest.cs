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
    public class ListGoodsStylesRequest : RpcAcsRequest<ListGoodsStylesResponse>
    {
        public ListGoodsStylesRequest()
            : base("digitalstore", "2020-01-07", "ListGoodsStyles", "digitalstore", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string code;

		private string orderByField;

		private float? currentPrice;

		private int? pageNumber;

		private float? retailPrice;

		private int? pageSize;

		private int? useSkuColor;

		private string sizeGroupId;

		private long? merchantId;

		private int? disable;

		private string styleId;

		private int? useSkuSize;

		private string name;

		private string orderByMethod;

		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
				DictionaryUtil.Add(BodyParameters, "Code", value);
			}
		}

		public string OrderByField
		{
			get
			{
				return orderByField;
			}
			set	
			{
				orderByField = value;
				DictionaryUtil.Add(BodyParameters, "OrderByField", value);
			}
		}

		public float? CurrentPrice
		{
			get
			{
				return currentPrice;
			}
			set	
			{
				currentPrice = value;
				DictionaryUtil.Add(BodyParameters, "CurrentPrice", value.ToString());
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(BodyParameters, "PageNumber", value.ToString());
			}
		}

		public float? RetailPrice
		{
			get
			{
				return retailPrice;
			}
			set	
			{
				retailPrice = value;
				DictionaryUtil.Add(BodyParameters, "RetailPrice", value.ToString());
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(BodyParameters, "PageSize", value.ToString());
			}
		}

		public int? UseSkuColor
		{
			get
			{
				return useSkuColor;
			}
			set	
			{
				useSkuColor = value;
				DictionaryUtil.Add(BodyParameters, "UseSkuColor", value.ToString());
			}
		}

		public string SizeGroupId
		{
			get
			{
				return sizeGroupId;
			}
			set	
			{
				sizeGroupId = value;
				DictionaryUtil.Add(BodyParameters, "SizeGroupId", value);
			}
		}

		public long? MerchantId
		{
			get
			{
				return merchantId;
			}
			set	
			{
				merchantId = value;
				DictionaryUtil.Add(BodyParameters, "MerchantId", value.ToString());
			}
		}

		public int? Disable
		{
			get
			{
				return disable;
			}
			set	
			{
				disable = value;
				DictionaryUtil.Add(BodyParameters, "Disable", value.ToString());
			}
		}

		public string StyleId
		{
			get
			{
				return styleId;
			}
			set	
			{
				styleId = value;
				DictionaryUtil.Add(BodyParameters, "StyleId", value);
			}
		}

		public int? UseSkuSize
		{
			get
			{
				return useSkuSize;
			}
			set	
			{
				useSkuSize = value;
				DictionaryUtil.Add(BodyParameters, "UseSkuSize", value.ToString());
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(BodyParameters, "Name", value);
			}
		}

		public string OrderByMethod
		{
			get
			{
				return orderByMethod;
			}
			set	
			{
				orderByMethod = value;
				DictionaryUtil.Add(BodyParameters, "OrderByMethod", value);
			}
		}

        public override ListGoodsStylesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListGoodsStylesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
