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
using Aliyun.Acs.Trademark.Transform;
using Aliyun.Acs.Trademark.Transform.V20180724;

namespace Aliyun.Acs.Trademark.Model.V20180724
{
    public class InsertTradeIntentionUserRequest : RpcAcsRequest<InsertTradeIntentionUserResponse>
    {
        public InsertTradeIntentionUserRequest()
            : base("Trademark", "2018-07-24", "InsertTradeIntentionUser", "trademark", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string mobile;

		private string description;

		private string partnerCode;

		private string classification;

		private int? type;

		private string vcode;

		private string registerNumber;

		private string userName;

		public string Mobile
		{
			get
			{
				return mobile;
			}
			set	
			{
				mobile = value;
				DictionaryUtil.Add(QueryParameters, "Mobile", value);
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
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		public string PartnerCode
		{
			get
			{
				return partnerCode;
			}
			set	
			{
				partnerCode = value;
				DictionaryUtil.Add(QueryParameters, "PartnerCode", value);
			}
		}

		public string Classification
		{
			get
			{
				return classification;
			}
			set	
			{
				classification = value;
				DictionaryUtil.Add(QueryParameters, "Classification", value);
			}
		}

		public int? Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
				DictionaryUtil.Add(QueryParameters, "Type", value.ToString());
			}
		}

		public string Vcode
		{
			get
			{
				return vcode;
			}
			set	
			{
				vcode = value;
				DictionaryUtil.Add(QueryParameters, "Vcode", value);
			}
		}

		public string RegisterNumber
		{
			get
			{
				return registerNumber;
			}
			set	
			{
				registerNumber = value;
				DictionaryUtil.Add(QueryParameters, "RegisterNumber", value);
			}
		}

		public string UserName
		{
			get
			{
				return userName;
			}
			set	
			{
				userName = value;
				DictionaryUtil.Add(QueryParameters, "UserName", value);
			}
		}

        public override InsertTradeIntentionUserResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return InsertTradeIntentionUserResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
