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
    public class ImportTakeStockOrderRequest : RpcAcsRequest<ImportTakeStockOrderResponse>
    {
        public ImportTakeStockOrderRequest()
            : base("digitalstore", "2020-01-07", "ImportTakeStockOrder", "digitalstore", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private List<ImportSnapBizs> importSnapBizss = new List<ImportSnapBizs>(){ };

		private string description;

		private string sourceOrderCode;

		private string warehouseCode;

		public List<ImportSnapBizs> ImportSnapBizss
		{
			get
			{
				return importSnapBizss;
			}

			set
			{
				importSnapBizss = value;
				for (int i = 0; i < importSnapBizss.Count; i++)
				{
					DictionaryUtil.Add(BodyParameters,"ImportSnapBizs." + (i + 1) + ".SnapQuantity", importSnapBizss[i].SnapQuantity);
					DictionaryUtil.Add(BodyParameters,"ImportSnapBizs." + (i + 1) + ".Barcode", importSnapBizss[i].Barcode);
				}
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

		public string SourceOrderCode
		{
			get
			{
				return sourceOrderCode;
			}
			set	
			{
				sourceOrderCode = value;
				DictionaryUtil.Add(BodyParameters, "SourceOrderCode", value);
			}
		}

		public string WarehouseCode
		{
			get
			{
				return warehouseCode;
			}
			set	
			{
				warehouseCode = value;
				DictionaryUtil.Add(BodyParameters, "WarehouseCode", value);
			}
		}

		public class ImportSnapBizs
		{

			private int? snapQuantity;

			private string barcode;

			public int? SnapQuantity
			{
				get
				{
					return snapQuantity;
				}
				set	
				{
					snapQuantity = value;
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

        public override ImportTakeStockOrderResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ImportTakeStockOrderResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
