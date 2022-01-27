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
using Aliyun.Acs.BssOpenApi;
using Aliyun.Acs.BssOpenApi.Transform;
using Aliyun.Acs.BssOpenApi.Transform.V20171214;

namespace Aliyun.Acs.BssOpenApi.Model.V20171214
{
    public class ApplyInvoiceRequest : RpcAcsRequest<ApplyInvoiceResponse>
    {
        public ApplyInvoiceRequest()
            : base("BssOpenApi", "2017-12-14", "ApplyInvoice")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.BssOpenApi.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.BssOpenApi.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private int? invoicingType;

		private int? processWay;

		private long? ownerId;

		private long? invoiceAmount;

		private long? addressId;

		private string applyUserNick;

		private bool? invoiceByAmount;

		private long? customerId;

		private List<long?> selectedIdss = new List<long?>(){ };

		private string userRemark;

		public int? InvoicingType
		{
			get
			{
				return invoicingType;
			}
			set	
			{
				invoicingType = value;
				DictionaryUtil.Add(QueryParameters, "InvoicingType", value.ToString());
			}
		}

		public int? ProcessWay
		{
			get
			{
				return processWay;
			}
			set	
			{
				processWay = value;
				DictionaryUtil.Add(QueryParameters, "ProcessWay", value.ToString());
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public long? InvoiceAmount
		{
			get
			{
				return invoiceAmount;
			}
			set	
			{
				invoiceAmount = value;
				DictionaryUtil.Add(QueryParameters, "InvoiceAmount", value.ToString());
			}
		}

		public long? AddressId
		{
			get
			{
				return addressId;
			}
			set	
			{
				addressId = value;
				DictionaryUtil.Add(QueryParameters, "AddressId", value.ToString());
			}
		}

		public string ApplyUserNick
		{
			get
			{
				return applyUserNick;
			}
			set	
			{
				applyUserNick = value;
				DictionaryUtil.Add(QueryParameters, "ApplyUserNick", value);
			}
		}

		public bool? InvoiceByAmount
		{
			get
			{
				return invoiceByAmount;
			}
			set	
			{
				invoiceByAmount = value;
				DictionaryUtil.Add(QueryParameters, "InvoiceByAmount", value.ToString());
			}
		}

		public long? CustomerId
		{
			get
			{
				return customerId;
			}
			set	
			{
				customerId = value;
				DictionaryUtil.Add(QueryParameters, "CustomerId", value.ToString());
			}
		}

		public List<long?> SelectedIdss
		{
			get
			{
				return selectedIdss;
			}

			set
			{
				selectedIdss = value;
				for (int i = 0; i < selectedIdss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"SelectedIds." + (i + 1) , selectedIdss[i]);
				}
			}
		}

		public string UserRemark
		{
			get
			{
				return userRemark;
			}
			set	
			{
				userRemark = value;
				DictionaryUtil.Add(QueryParameters, "UserRemark", value);
			}
		}

        public override ApplyInvoiceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ApplyInvoiceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
