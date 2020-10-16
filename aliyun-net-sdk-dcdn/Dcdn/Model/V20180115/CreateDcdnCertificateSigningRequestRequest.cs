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
using Aliyun.Acs.dcdn;
using Aliyun.Acs.dcdn.Transform;
using Aliyun.Acs.dcdn.Transform.V20180115;

namespace Aliyun.Acs.dcdn.Model.V20180115
{
    public class CreateDcdnCertificateSigningRequestRequest : RpcAcsRequest<CreateDcdnCertificateSigningRequestResponse>
    {
        public CreateDcdnCertificateSigningRequestRequest()
            : base("dcdn", "2018-01-15", "CreateDcdnCertificateSigningRequest")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string country;

		private string city;

		private string commonName;

		private string state;

		private string email;

		private string sANs;

		private long? ownerId;

		private string organization;

		private string organizationUnit;

		public string Country
		{
			get
			{
				return country;
			}
			set	
			{
				country = value;
				DictionaryUtil.Add(QueryParameters, "Country", value);
			}
		}

		public string City
		{
			get
			{
				return city;
			}
			set	
			{
				city = value;
				DictionaryUtil.Add(QueryParameters, "City", value);
			}
		}

		public string CommonName
		{
			get
			{
				return commonName;
			}
			set	
			{
				commonName = value;
				DictionaryUtil.Add(QueryParameters, "CommonName", value);
			}
		}

		public string State
		{
			get
			{
				return state;
			}
			set	
			{
				state = value;
				DictionaryUtil.Add(QueryParameters, "State", value);
			}
		}

		public string Email
		{
			get
			{
				return email;
			}
			set	
			{
				email = value;
				DictionaryUtil.Add(QueryParameters, "Email", value);
			}
		}

		public string SANs
		{
			get
			{
				return sANs;
			}
			set	
			{
				sANs = value;
				DictionaryUtil.Add(QueryParameters, "SANs", value);
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

		public string Organization
		{
			get
			{
				return organization;
			}
			set	
			{
				organization = value;
				DictionaryUtil.Add(QueryParameters, "Organization", value);
			}
		}

		public string OrganizationUnit
		{
			get
			{
				return organizationUnit;
			}
			set	
			{
				organizationUnit = value;
				DictionaryUtil.Add(QueryParameters, "OrganizationUnit", value);
			}
		}

        public override CreateDcdnCertificateSigningRequestResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateDcdnCertificateSigningRequestResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
