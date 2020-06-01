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
    public class ImportInboundOrderRequest : RpcAcsRequest<ImportInboundOrderResponse>
    {
        public ImportInboundOrderRequest()
            : base("digitalstore", "2020-01-07", "ImportInboundOrder", "digitalstore", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string code;

		private string fromWarehouseCode;

		private string description;

		private List<DetailList> detailLists = new List<DetailList>(){ };

		private string sourceOrderCode;

		private string toWarehouseCode;

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

		public string FromWarehouseCode
		{
			get
			{
				return fromWarehouseCode;
			}
			set	
			{
				fromWarehouseCode = value;
				DictionaryUtil.Add(BodyParameters, "FromWarehouseCode", value);
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

		public List<DetailList> DetailLists
		{
			get
			{
				return detailLists;
			}

			set
			{
				detailLists = value;
				for (int i = 0; i < detailLists.Count; i++)
				{
					DictionaryUtil.Add(BodyParameters,"DetailList." + (i + 1) + ".Quantity", detailLists[i].Quantity);
					DictionaryUtil.Add(BodyParameters,"DetailList." + (i + 1) + ".Barcode", detailLists[i].Barcode);
				}
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

		public string ToWarehouseCode
		{
			get
			{
				return toWarehouseCode;
			}
			set	
			{
				toWarehouseCode = value;
				DictionaryUtil.Add(BodyParameters, "ToWarehouseCode", value);
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

		public class DetailList
		{

			private int? quantity;

			private string barcode;

			public int? Quantity
			{
				get
				{
					return quantity;
				}
				set	
				{
					quantity = value;
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

        public override ImportInboundOrderResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ImportInboundOrderResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
