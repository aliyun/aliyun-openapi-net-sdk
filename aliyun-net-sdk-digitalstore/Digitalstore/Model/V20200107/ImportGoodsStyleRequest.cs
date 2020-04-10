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
    public class ImportGoodsStyleRequest : RpcAcsRequest<ImportGoodsStyleResponse>
    {
        public ImportGoodsStyleRequest()
            : base("digitalstore", "2020-01-07", "ImportGoodsStyle", "digitalstore", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string description;

		private string colorCode;

		private string sizeName;

		private float? currentPrice;

		private float? retailPrice;

		private string styleName;

		private string sizeGroupCode;

		private string barcode;

		private int? useSkuColor;

		private string barcodeName;

		private string sizeCode;

		private string colorName;

		private int? disable;

		private int? useSkuSize;

		private string sizeGroupName;

		private string styleCode;

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(BodyParameters, "Description", value);
			}
		}

		public string ColorCode
		{
			get
			{
				return colorCode;
			}
			set	
			{
				colorCode = value;
				DictionaryUtil.Add(BodyParameters, "ColorCode", value);
			}
		}

		public string SizeName
		{
			get
			{
				return sizeName;
			}
			set	
			{
				sizeName = value;
				DictionaryUtil.Add(BodyParameters, "SizeName", value);
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

		public string StyleName
		{
			get
			{
				return styleName;
			}
			set	
			{
				styleName = value;
				DictionaryUtil.Add(BodyParameters, "StyleName", value);
			}
		}

		public string SizeGroupCode
		{
			get
			{
				return sizeGroupCode;
			}
			set	
			{
				sizeGroupCode = value;
				DictionaryUtil.Add(BodyParameters, "SizeGroupCode", value);
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
				DictionaryUtil.Add(BodyParameters, "Barcode", value);
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

		public string BarcodeName
		{
			get
			{
				return barcodeName;
			}
			set	
			{
				barcodeName = value;
				DictionaryUtil.Add(BodyParameters, "BarcodeName", value);
			}
		}

		public string SizeCode
		{
			get
			{
				return sizeCode;
			}
			set	
			{
				sizeCode = value;
				DictionaryUtil.Add(BodyParameters, "SizeCode", value);
			}
		}

		public string ColorName
		{
			get
			{
				return colorName;
			}
			set	
			{
				colorName = value;
				DictionaryUtil.Add(BodyParameters, "ColorName", value);
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

		public string SizeGroupName
		{
			get
			{
				return sizeGroupName;
			}
			set	
			{
				sizeGroupName = value;
				DictionaryUtil.Add(BodyParameters, "SizeGroupName", value);
			}
		}

		public string StyleCode
		{
			get
			{
				return styleCode;
			}
			set	
			{
				styleCode = value;
				DictionaryUtil.Add(BodyParameters, "StyleCode", value);
			}
		}

        public override ImportGoodsStyleResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ImportGoodsStyleResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
