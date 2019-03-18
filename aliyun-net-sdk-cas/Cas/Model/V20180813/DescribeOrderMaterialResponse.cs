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

namespace Aliyun.Acs.cas.Model.V20180813
{
	public class DescribeOrderMaterialResponse : AcsResponse
	{

		private string requestId;

		private string companyName;

		private string companyPhone;

		private string companyCode;

		private string personName;

		private string personPhone;

		private string personEmail;

		private string companyEmail;

		private string companyAddress;

		private string personIdCardNumber;

		private int? companyType;

		private string city;

		private string province;

		private int? createCsr;

		private string postCode;

		private string csrContent;

		private string personTitle;

		private string leaderName;

		private string leaderTitle;

		private string leaderEmail;

		private string leaderPhone;

		private string countryCode;

		private string personDepartment;

		private int? domainAuthType;

		private string domain;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
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
			}
		}

		public string CompanyEmail
		{
			get
			{
				return companyEmail;
			}
			set	
			{
				companyEmail = value;
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
			}
		}

		public string LeaderName
		{
			get
			{
				return leaderName;
			}
			set	
			{
				leaderName = value;
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
			}
		}
	}
}
