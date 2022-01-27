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
    public class CreateAgAccountRequest : RpcAcsRequest<CreateAgAccountResponse>
    {
        public CreateAgAccountRequest()
            : base("BssOpenApi", "2017-12-14", "CreateAgAccount")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.BssOpenApi.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.BssOpenApi.Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string firstName;

		private string cityName;

		private string postcode;

		private string enterpriseName;

		private string nationCode;

		private string lastName;

		private string loginEmail;

		private string provinceName;

		private string accountAttr;

		public string FirstName
		{
			get
			{
				return firstName;
			}
			set	
			{
				firstName = value;
				DictionaryUtil.Add(QueryParameters, "FirstName", value);
			}
		}

		public string CityName
		{
			get
			{
				return cityName;
			}
			set	
			{
				cityName = value;
				DictionaryUtil.Add(QueryParameters, "CityName", value);
			}
		}

		public string Postcode
		{
			get
			{
				return postcode;
			}
			set	
			{
				postcode = value;
				DictionaryUtil.Add(QueryParameters, "Postcode", value);
			}
		}

		public string EnterpriseName
		{
			get
			{
				return enterpriseName;
			}
			set	
			{
				enterpriseName = value;
				DictionaryUtil.Add(QueryParameters, "EnterpriseName", value);
			}
		}

		public string NationCode
		{
			get
			{
				return nationCode;
			}
			set	
			{
				nationCode = value;
				DictionaryUtil.Add(QueryParameters, "NationCode", value);
			}
		}

		public string LastName
		{
			get
			{
				return lastName;
			}
			set	
			{
				lastName = value;
				DictionaryUtil.Add(QueryParameters, "LastName", value);
			}
		}

		public string LoginEmail
		{
			get
			{
				return loginEmail;
			}
			set	
			{
				loginEmail = value;
				DictionaryUtil.Add(QueryParameters, "LoginEmail", value);
			}
		}

		public string ProvinceName
		{
			get
			{
				return provinceName;
			}
			set	
			{
				provinceName = value;
				DictionaryUtil.Add(QueryParameters, "ProvinceName", value);
			}
		}

		public string AccountAttr
		{
			get
			{
				return accountAttr;
			}
			set	
			{
				accountAttr = value;
				DictionaryUtil.Add(QueryParameters, "AccountAttr", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateAgAccountResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateAgAccountResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
