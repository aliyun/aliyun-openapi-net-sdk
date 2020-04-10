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
    public class CreateBarcodeRequest : RpcAcsRequest<CreateBarcodeResponse>
    {
        public CreateBarcodeRequest()
            : base("digitalstore", "2020-01-07", "CreateBarcode", "digitalstore", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string code;

		private string description;

		private float? currentPrice;

		private float? retailPrice;

		private string sizeId;

		private string colorId;

		private string styleId;

		private int? disable;

		private string name;

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

		public string SizeId
		{
			get
			{
				return sizeId;
			}
			set	
			{
				sizeId = value;
				DictionaryUtil.Add(BodyParameters, "SizeId", value);
			}
		}

		public string ColorId
		{
			get
			{
				return colorId;
			}
			set	
			{
				colorId = value;
				DictionaryUtil.Add(BodyParameters, "ColorId", value);
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

        public override CreateBarcodeResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateBarcodeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
