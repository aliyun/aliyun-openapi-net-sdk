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
    public class ListProduceOrdersRequest : RpcAcsRequest<ListProduceOrdersResponse>
    {
        public ListProduceOrdersRequest()
            : base("digitalstore", "2020-01-07", "ListProduceOrders", "digitalstore", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string beginDate;

		private string code;

		private string orderByField;

		private int? pageNumber;

		private string sourceOrderCode;

		private string warehouseId;

		private int? pageSize;

		private string warehouseCode;

		private string orderId;

		private string businessUnitCode;

		private string businessUnitId;

		private string endDate;

		private long? merchantId;

		private string name;

		private string orderByMethod;

		private List<string> statuss = new List<string>(){ };

		public string BeginDate
		{
			get
			{
				return beginDate;
			}
			set	
			{
				beginDate = value;
				DictionaryUtil.Add(BodyParameters, "BeginDate", value);
			}
		}

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

		public string EndDate
		{
			get
			{
				return endDate;
			}
			set	
			{
				endDate = value;
				DictionaryUtil.Add(BodyParameters, "EndDate", value);
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

		public List<string> Statuss
		{
			get
			{
				return statuss;
			}

			set
			{
				statuss = value;
				for (int i = 0; i < statuss.Count; i++)
				{
					DictionaryUtil.Add(BodyParameters,"Status." + (i + 1) , statuss[i]);
				}
			}
		}

        public override ListProduceOrdersResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListProduceOrdersResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
