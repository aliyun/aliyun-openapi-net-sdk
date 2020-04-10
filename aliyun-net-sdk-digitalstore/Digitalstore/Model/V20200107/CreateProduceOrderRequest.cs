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
    public class CreateProduceOrderRequest : RpcAcsRequest<CreateProduceOrderResponse>
    {
        public CreateProduceOrderRequest()
            : base("digitalstore", "2020-01-07", "CreateProduceOrder", "digitalstore", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string code;

		private string description;

		private string gmtModified;

		private string deliveryDate;

		private string makeDateTime;

		private string sourceOrderCode;

		private string warehouseId;

		private string sourceOrderType;

		private string warehouseCode;

		private string orderId;

		private List<DetailList> detailLists = new List<DetailList>(){ };

		private string gmtCreate;

		private string businessUnitCode;

		private string businessUnitId;

		private string styleId;

		private string contractNumber;

		private string name;

		private string styleCode;

		private string status;

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

		public string GmtModified
		{
			get
			{
				return gmtModified;
			}
			set	
			{
				gmtModified = value;
				DictionaryUtil.Add(BodyParameters, "GmtModified", value);
			}
		}

		public string DeliveryDate
		{
			get
			{
				return deliveryDate;
			}
			set	
			{
				deliveryDate = value;
				DictionaryUtil.Add(BodyParameters, "DeliveryDate", value);
			}
		}

		public string MakeDateTime
		{
			get
			{
				return makeDateTime;
			}
			set	
			{
				makeDateTime = value;
				DictionaryUtil.Add(BodyParameters, "MakeDateTime", value);
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

		public string WarehouseId
		{
			get
			{
				return warehouseId;
			}
			set	
			{
				warehouseId = value;
				DictionaryUtil.Add(BodyParameters, "WarehouseId", value);
			}
		}

		public string SourceOrderType
		{
			get
			{
				return sourceOrderType;
			}
			set	
			{
				sourceOrderType = value;
				DictionaryUtil.Add(BodyParameters, "SourceOrderType", value);
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
					DictionaryUtil.Add(BodyParameters,"DetailList." + (i + 1) + ".CaseCode", detailLists[i].CaseCode);
					DictionaryUtil.Add(BodyParameters,"DetailList." + (i + 1) + ".Quantity", detailLists[i].Quantity);
					DictionaryUtil.Add(BodyParameters,"DetailList." + (i + 1) + ".PreQuantity", detailLists[i].PreQuantity);
					DictionaryUtil.Add(BodyParameters,"DetailList." + (i + 1) + ".BusinessPrice", detailLists[i].BusinessPrice);
					DictionaryUtil.Add(BodyParameters,"DetailList." + (i + 1) + ".MoreQuantity", detailLists[i].MoreQuantity);
					DictionaryUtil.Add(BodyParameters,"DetailList." + (i + 1) + ".ToleranceRate", detailLists[i].ToleranceRate);
					DictionaryUtil.Add(BodyParameters,"DetailList." + (i + 1) + ".BarcodeId", detailLists[i].BarcodeId);
				}
			}
		}

		public string GmtCreate
		{
			get
			{
				return gmtCreate;
			}
			set	
			{
				gmtCreate = value;
				DictionaryUtil.Add(BodyParameters, "GmtCreate", value);
			}
		}

		public string BusinessUnitCode
		{
			get
			{
				return businessUnitCode;
			}
			set	
			{
				businessUnitCode = value;
				DictionaryUtil.Add(BodyParameters, "BusinessUnitCode", value);
			}
		}

		public string BusinessUnitId
		{
			get
			{
				return businessUnitId;
			}
			set	
			{
				businessUnitId = value;
				DictionaryUtil.Add(BodyParameters, "BusinessUnitId", value);
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

		public string ContractNumber
		{
			get
			{
				return contractNumber;
			}
			set	
			{
				contractNumber = value;
				DictionaryUtil.Add(BodyParameters, "ContractNumber", value);
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

		public string Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
				DictionaryUtil.Add(BodyParameters, "Status", value);
			}
		}

		public class DetailList
		{

			private string caseCode;

			private int? quantity;

			private int? preQuantity;

			private int? businessPrice;

			private int? moreQuantity;

			private int? toleranceRate;

			private string barcodeId;

			public string CaseCode
			{
				get
				{
					return caseCode;
				}
				set	
				{
					caseCode = value;
				}
			}

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

			public int? PreQuantity
			{
				get
				{
					return preQuantity;
				}
				set	
				{
					preQuantity = value;
				}
			}

			public int? BusinessPrice
			{
				get
				{
					return businessPrice;
				}
				set	
				{
					businessPrice = value;
				}
			}

			public int? MoreQuantity
			{
				get
				{
					return moreQuantity;
				}
				set	
				{
					moreQuantity = value;
				}
			}

			public int? ToleranceRate
			{
				get
				{
					return toleranceRate;
				}
				set	
				{
					toleranceRate = value;
				}
			}

			public string BarcodeId
			{
				get
				{
					return barcodeId;
				}
				set	
				{
					barcodeId = value;
				}
			}
		}

        public override CreateProduceOrderResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateProduceOrderResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
