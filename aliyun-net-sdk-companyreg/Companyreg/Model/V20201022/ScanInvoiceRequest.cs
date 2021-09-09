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
using Aliyun.Acs.companyreg.Transform;
using Aliyun.Acs.companyreg.Transform.V20201022;

namespace Aliyun.Acs.companyreg.Model.V20201022
{
    public class ScanInvoiceRequest : RpcAcsRequest<ScanInvoiceResponse>
    {
        public ScanInvoiceRequest()
            : base("companyreg", "2020-10-22", "ScanInvoice", "companyreg", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.companyreg.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.companyreg.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string date;

		private string no;

		private string amount;

		private string code;

		private string vCode;

		private string bizId;

		private string invoiceCode;

		public string Date
		{
			get
			{
				return date;
			}
			set	
			{
				date = value;
				DictionaryUtil.Add(QueryParameters, "Date", value);
			}
		}

		public string No
		{
			get
			{
				return no;
			}
			set	
			{
				no = value;
				DictionaryUtil.Add(QueryParameters, "No", value);
			}
		}

		public string Amount
		{
			get
			{
				return amount;
			}
			set	
			{
				amount = value;
				DictionaryUtil.Add(QueryParameters, "Amount", value);
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
				DictionaryUtil.Add(QueryParameters, "Code", value);
			}
		}

		public string VCode
		{
			get
			{
				return vCode;
			}
			set	
			{
				vCode = value;
				DictionaryUtil.Add(QueryParameters, "VCode", value);
			}
		}

		public string BizId
		{
			get
			{
				return bizId;
			}
			set	
			{
				bizId = value;
				DictionaryUtil.Add(QueryParameters, "BizId", value);
			}
		}

		public string InvoiceCode
		{
			get
			{
				return invoiceCode;
			}
			set	
			{
				invoiceCode = value;
				DictionaryUtil.Add(QueryParameters, "InvoiceCode", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ScanInvoiceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ScanInvoiceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
