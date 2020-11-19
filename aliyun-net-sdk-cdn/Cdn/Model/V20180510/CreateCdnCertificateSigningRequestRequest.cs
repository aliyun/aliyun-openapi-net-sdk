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
using Aliyun.Acs.Cdn;
using Aliyun.Acs.Cdn.Transform;
using Aliyun.Acs.Cdn.Transform.V20180510;

namespace Aliyun.Acs.Cdn.Model.V20180510
{
    public class CreateCdnCertificateSigningRequestRequest : RpcAcsRequest<CreateCdnCertificateSigningRequestResponse>
    {
        public CreateCdnCertificateSigningRequestRequest()
            : base("Cdn", "2018-05-10", "CreateCdnCertificateSigningRequest")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Cdn.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Cdn.Endpoint.endpointRegionalType, null);
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

        public override CreateCdnCertificateSigningRequestResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateCdnCertificateSigningRequestResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
