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
using Aliyun.Acs.cas.Transform;
using Aliyun.Acs.cas.Transform.V20180813;

namespace Aliyun.Acs.cas.Model.V20180813
{
    public class CreateOrderMaterialRequest : RpcAcsRequest<CreateOrderMaterialResponse>
    {
        public CreateOrderMaterialRequest()
            : base("cas", "2018-08-13", "CreateOrderMaterial", "cas_esign_fdd", "openAPI")
        {
        }

		private string leaderName;

		private string city;

		private string countryCode;

		private string leaderEmail;

		private string companyAddress;

		private string companyCode;

		private string personEmail;

		private string province;

		private int? domainAuthType;

		private string leaderPhone;

		private string sourceIp;

		private string csrContent;

		private string lang;

		private string personName;

		private string personIdCardNumber;

		private long? orderId;

		private string leaderTitle;

		private string personTitle;

		private string postCode;

		private int? createCsr;

		private string personPhone;

		private string companyName;

		private string companyPhone;

		private int? companyType;

		private string domain;

		private string personDepartment;

		public string LeaderName
		{
			get
			{
				return leaderName;
			}
			set	
			{
				leaderName = value;
				DictionaryUtil.Add(QueryParameters, "LeaderName", value);
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

		public string CountryCode
		{
			get
			{
				return countryCode;
			}
			set	
			{
				countryCode = value;
				DictionaryUtil.Add(QueryParameters, "CountryCode", value);
			}
		}

		public string LeaderEmail
		{
			get
			{
				return leaderEmail;
			}
			set	
			{
				leaderEmail = value;
				DictionaryUtil.Add(QueryParameters, "LeaderEmail", value);
			}
		}

		public string CompanyAddress
		{
			get
			{
				return companyAddress;
			}
			set	
			{
				companyAddress = value;
				DictionaryUtil.Add(QueryParameters, "CompanyAddress", value);
			}
		}

		public string CompanyCode
		{
			get
			{
				return companyCode;
			}
			set	
			{
				companyCode = value;
				DictionaryUtil.Add(QueryParameters, "CompanyCode", value);
			}
		}

		public string PersonEmail
		{
			get
			{
				return personEmail;
			}
			set	
			{
				personEmail = value;
				DictionaryUtil.Add(QueryParameters, "PersonEmail", value);
			}
		}

		public string Province
		{
			get
			{
				return province;
			}
			set	
			{
				province = value;
				DictionaryUtil.Add(QueryParameters, "Province", value);
			}
		}

		public int? DomainAuthType
		{
			get
			{
				return domainAuthType;
			}
			set	
			{
				domainAuthType = value;
				DictionaryUtil.Add(QueryParameters, "DomainAuthType", value.ToString());
			}
		}

		public string LeaderPhone
		{
			get
			{
				return leaderPhone;
			}
			set	
			{
				leaderPhone = value;
				DictionaryUtil.Add(QueryParameters, "LeaderPhone", value);
			}
		}

		public string SourceIp
		{
			get
			{
				return sourceIp;
			}
			set	
			{
				sourceIp = value;
				DictionaryUtil.Add(QueryParameters, "SourceIp", value);
			}
		}

		public string CsrContent
		{
			get
			{
				return csrContent;
			}
			set	
			{
				csrContent = value;
				DictionaryUtil.Add(QueryParameters, "CsrContent", value);
			}
		}

		public string Lang
		{
			get
			{
				return lang;
			}
			set	
			{
				lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

		public string PersonName
		{
			get
			{
				return personName;
			}
			set	
			{
				personName = value;
				DictionaryUtil.Add(QueryParameters, "PersonName", value);
			}
		}

		public string PersonIdCardNumber
		{
			get
			{
				return personIdCardNumber;
			}
			set	
			{
				personIdCardNumber = value;
				DictionaryUtil.Add(QueryParameters, "PersonIdCardNumber", value);
			}
		}

		public long? OrderId
		{
			get
			{
				return orderId;
			}
			set	
			{
				orderId = value;
				DictionaryUtil.Add(QueryParameters, "OrderId", value.ToString());
			}
		}

		public string LeaderTitle
		{
			get
			{
				return leaderTitle;
			}
			set	
			{
				leaderTitle = value;
				DictionaryUtil.Add(QueryParameters, "LeaderTitle", value);
			}
		}

		public string PersonTitle
		{
			get
			{
				return personTitle;
			}
			set	
			{
				personTitle = value;
				DictionaryUtil.Add(QueryParameters, "PersonTitle", value);
			}
		}

		public string PostCode
		{
			get
			{
				return postCode;
			}
			set	
			{
				postCode = value;
				DictionaryUtil.Add(QueryParameters, "PostCode", value);
			}
		}

		public int? CreateCsr
		{
			get
			{
				return createCsr;
			}
			set	
			{
				createCsr = value;
				DictionaryUtil.Add(QueryParameters, "CreateCsr", value.ToString());
			}
		}

		public string PersonPhone
		{
			get
			{
				return personPhone;
			}
			set	
			{
				personPhone = value;
				DictionaryUtil.Add(QueryParameters, "PersonPhone", value);
			}
		}

		public string CompanyName
		{
			get
			{
				return companyName;
			}
			set	
			{
				companyName = value;
				DictionaryUtil.Add(QueryParameters, "CompanyName", value);
			}
		}

		public string CompanyPhone
		{
			get
			{
				return companyPhone;
			}
			set	
			{
				companyPhone = value;
				DictionaryUtil.Add(QueryParameters, "CompanyPhone", value);
			}
		}

		public int? CompanyType
		{
			get
			{
				return companyType;
			}
			set	
			{
				companyType = value;
				DictionaryUtil.Add(QueryParameters, "CompanyType", value.ToString());
			}
		}

		public string Domain
		{
			get
			{
				return domain;
			}
			set	
			{
				domain = value;
				DictionaryUtil.Add(QueryParameters, "Domain", value);
			}
		}

		public string PersonDepartment
		{
			get
			{
				return personDepartment;
			}
			set	
			{
				personDepartment = value;
				DictionaryUtil.Add(QueryParameters, "PersonDepartment", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateOrderMaterialResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateOrderMaterialResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
