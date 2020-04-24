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
    public class CreateApplicationOrderRequest : RpcAcsRequest<CreateApplicationOrderResponse>
    {
        public CreateApplicationOrderRequest()
            : base("digitalstore", "2020-01-07", "CreateApplicationOrder", "digitalstore", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string expressCompanyId;

		private string description;

		private string scanType;

		private string reservationDeliveryDateTimeRange;

		private string warehouseId;

		private string sourceOrderId;

		private List<string> caseIdss = new List<string>(){ };

		private string reservationDeliveryTime;

		private string waybillCode;

		public string ExpressCompanyId
		{
			get
			{
				return expressCompanyId;
			}
			set	
			{
				expressCompanyId = value;
				DictionaryUtil.Add(BodyParameters, "ExpressCompanyId", value);
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

		public string ScanType
		{
			get
			{
				return scanType;
			}
			set	
			{
				scanType = value;
				DictionaryUtil.Add(BodyParameters, "ScanType", value);
			}
		}

		public string ReservationDeliveryDateTimeRange
		{
			get
			{
				return reservationDeliveryDateTimeRange;
			}
			set	
			{
				reservationDeliveryDateTimeRange = value;
				DictionaryUtil.Add(BodyParameters, "ReservationDeliveryDateTimeRange", value);
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

		public string SourceOrderId
		{
			get
			{
				return sourceOrderId;
			}
			set	
			{
				sourceOrderId = value;
				DictionaryUtil.Add(BodyParameters, "SourceOrderId", value);
			}
		}

		public List<string> CaseIdss
		{
			get
			{
				return caseIdss;
			}

			set
			{
				caseIdss = value;
				for (int i = 0; i < caseIdss.Count; i++)
				{
					DictionaryUtil.Add(BodyParameters,"CaseIds." + (i + 1) , caseIdss[i]);
				}
			}
		}

		public string ReservationDeliveryTime
		{
			get
			{
				return reservationDeliveryTime;
			}
			set	
			{
				reservationDeliveryTime = value;
				DictionaryUtil.Add(BodyParameters, "ReservationDeliveryTime", value);
			}
		}

		public string WaybillCode
		{
			get
			{
				return waybillCode;
			}
			set	
			{
				waybillCode = value;
				DictionaryUtil.Add(BodyParameters, "WaybillCode", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateApplicationOrderResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateApplicationOrderResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
