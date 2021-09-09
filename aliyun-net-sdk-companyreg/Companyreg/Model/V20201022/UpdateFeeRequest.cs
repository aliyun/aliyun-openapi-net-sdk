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
    public class UpdateFeeRequest : RpcAcsRequest<UpdateFeeResponse>
    {
        public UpdateFeeRequest()
            : base("companyreg", "2020-10-22", "UpdateFee", "companyreg", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.companyreg.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.companyreg.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string kind;

		private string use;

		private string baseTotalAmount;

		private string payer;

		private string secondKey;

		private string payMethod;

		private string firstKey;

		private string bizId;

		private string feeType;

		private long? id;

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

		public string BaseTotalAmount
		{
			get
			{
				return baseTotalAmount;
			}
			set	
			{
				baseTotalAmount = value;
				DictionaryUtil.Add(QueryParameters, "BaseTotalAmount", value);
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

		public string FeeType
		{
			get
			{
				return feeType;
			}
			set	
			{
				feeType = value;
				DictionaryUtil.Add(QueryParameters, "FeeType", value);
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateFeeResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateFeeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
