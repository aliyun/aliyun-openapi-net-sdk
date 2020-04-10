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
    public class ListTakeStockOrdersRequest : RpcAcsRequest<ListTakeStockOrdersResponse>
    {
        public ListTakeStockOrdersRequest()
            : base("digitalstore", "2020-01-07", "ListTakeStockOrders", "digitalstore", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string code;

		private string orderByField;

		private int? pageNumber;

		private string confirmDateTimeEnd;

		private string takeStockOrderId;

		private string sourceOrderCode;

		private int? pageSize;

		private string createEndTime;

		private List<string> syncStatuss = new List<string>(){ };

		private string createBeginTime;

		private long? merchantId;

		private string confirmDateTimeBegin;

		private string orderByMethod;

		private List<string> warehouseIdss = new List<string>(){ };

		private List<string> statuss = new List<string>(){ };

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

		public string ConfirmDateTimeEnd
		{
			get
			{
				return confirmDateTimeEnd;
			}
			set	
			{
				confirmDateTimeEnd = value;
				DictionaryUtil.Add(BodyParameters, "ConfirmDateTimeEnd", value);
			}
		}

		public string TakeStockOrderId
		{
			get
			{
				return takeStockOrderId;
			}
			set	
			{
				takeStockOrderId = value;
				DictionaryUtil.Add(BodyParameters, "TakeStockOrderId", value);
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

		public string CreateEndTime
		{
			get
			{
				return createEndTime;
			}
			set	
			{
				createEndTime = value;
				DictionaryUtil.Add(BodyParameters, "CreateEndTime", value);
			}
		}

		public List<string> SyncStatuss
		{
			get
			{
				return syncStatuss;
			}

			set
			{
				syncStatuss = value;
				for (int i = 0; i < syncStatuss.Count; i++)
				{
					DictionaryUtil.Add(BodyParameters,"SyncStatus." + (i + 1) , syncStatuss[i]);
				}
			}
		}

		public string CreateBeginTime
		{
			get
			{
				return createBeginTime;
			}
			set	
			{
				createBeginTime = value;
				DictionaryUtil.Add(BodyParameters, "CreateBeginTime", value);
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

		public string ConfirmDateTimeBegin
		{
			get
			{
				return confirmDateTimeBegin;
			}
			set	
			{
				confirmDateTimeBegin = value;
				DictionaryUtil.Add(BodyParameters, "ConfirmDateTimeBegin", value);
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

		public List<string> WarehouseIdss
		{
			get
			{
				return warehouseIdss;
			}

			set
			{
				warehouseIdss = value;
				for (int i = 0; i < warehouseIdss.Count; i++)
				{
					DictionaryUtil.Add(BodyParameters,"WarehouseIds." + (i + 1) , warehouseIdss[i]);
				}
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

        public override ListTakeStockOrdersResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListTakeStockOrdersResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
