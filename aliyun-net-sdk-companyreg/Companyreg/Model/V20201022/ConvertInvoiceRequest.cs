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
    public class ConvertInvoiceRequest : RpcAcsRequest<ConvertInvoiceResponse>
    {
        public ConvertInvoiceRequest()
            : base("companyreg", "2020-10-22", "ConvertInvoice", "companyreg", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.companyreg.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.companyreg.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private bool? isFee;

		private string shellMethod;

		private string kind;

		private string use;

		private string thirdKey;

		private string payer;

		private string secondKey;

		private string payMethod;

		private string buyMethod;

		private string fixedAssetType;

		private string firstKey;

		private string bizId;

		private long? id;

		private string buyTarget;

		public bool? IsFee
		{
			get
			{
				return isFee;
			}
			set	
			{
				isFee = value;
				DictionaryUtil.Add(QueryParameters, "IsFee", value.ToString());
			}
		}

		public string ShellMethod
		{
			get
			{
				return shellMethod;
			}
			set	
			{
				shellMethod = value;
				DictionaryUtil.Add(QueryParameters, "ShellMethod", value);
			}
		}

		public string Kind
		{
			get
			{
				return kind;
			}
			set	
			{
				kind = value;
				DictionaryUtil.Add(QueryParameters, "Kind", value);
			}
		}

		public string Use
		{
			get
			{
				return use;
			}
			set	
			{
				use = value;
				DictionaryUtil.Add(QueryParameters, "Use", value);
			}
		}

		public string ThirdKey
		{
			get
			{
				return thirdKey;
			}
			set	
			{
				thirdKey = value;
				DictionaryUtil.Add(QueryParameters, "ThirdKey", value);
			}
		}

		public string Payer
		{
			get
			{
				return payer;
			}
			set	
			{
				payer = value;
				DictionaryUtil.Add(QueryParameters, "Payer", value);
			}
		}

		public string SecondKey
		{
			get
			{
				return secondKey;
			}
			set	
			{
				secondKey = value;
				DictionaryUtil.Add(QueryParameters, "SecondKey", value);
			}
		}

		public string PayMethod
		{
			get
			{
				return payMethod;
			}
			set	
			{
				payMethod = value;
				DictionaryUtil.Add(QueryParameters, "PayMethod", value);
			}
		}

		public string BuyMethod
		{
			get
			{
				return buyMethod;
			}
			set	
			{
				buyMethod = value;
				DictionaryUtil.Add(QueryParameters, "BuyMethod", value);
			}
		}

		public string FixedAssetType
		{
			get
			{
				return fixedAssetType;
			}
			set	
			{
				fixedAssetType = value;
				DictionaryUtil.Add(QueryParameters, "FixedAssetType", value);
			}
		}

		public string FirstKey
		{
			get
			{
				return firstKey;
			}
			set	
			{
				firstKey = value;
				DictionaryUtil.Add(QueryParameters, "FirstKey", value);
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

		public long? Id
		{
			get
			{
				return id;
			}
			set	
			{
				id = value;
				DictionaryUtil.Add(QueryParameters, "Id", value.ToString());
			}
		}

		public string BuyTarget
		{
			get
			{
				return buyTarget;
			}
			set	
			{
				buyTarget = value;
				DictionaryUtil.Add(QueryParameters, "BuyTarget", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ConvertInvoiceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ConvertInvoiceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
