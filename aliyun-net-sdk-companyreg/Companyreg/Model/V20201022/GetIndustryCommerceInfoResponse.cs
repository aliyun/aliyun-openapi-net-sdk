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

namespace Aliyun.Acs.companyreg.Model.V20201022
{
	public class GetIndustryCommerceInfoResponse : AcsResponse
	{

		private string requestId;

		private string companyType;

		private string establishmentDate;

		private string businessStatus;

		private string taxNo;

		private string registeredCaptial;

		private string name;

		private string legalRepresentative;

		private string operatingPeriod;

		private string bizScope;

		private string corpAddress;

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

		public string CompanyType
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

		public string EstablishmentDate
		{
			get
			{
				return establishmentDate;
			}
			set	
			{
				establishmentDate = value;
			}
		}

		public string BusinessStatus
		{
			get
			{
				return businessStatus;
			}
			set	
			{
				businessStatus = value;
			}
		}

		public string TaxNo
		{
			get
			{
				return taxNo;
			}
			set	
			{
				taxNo = value;
			}
		}

		public string RegisteredCaptial
		{
			get
			{
				return registeredCaptial;
			}
			set	
			{
				registeredCaptial = value;
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
			}
		}

		public string LegalRepresentative
		{
			get
			{
				return legalRepresentative;
			}
			set	
			{
				legalRepresentative = value;
			}
		}

		public string OperatingPeriod
		{
			get
			{
				return operatingPeriod;
			}
			set	
			{
				operatingPeriod = value;
			}
		}

		public string BizScope
		{
			get
			{
				return bizScope;
			}
			set	
			{
				bizScope = value;
			}
		}

		public string CorpAddress
		{
			get
			{
				return corpAddress;
			}
			set	
			{
				corpAddress = value;
			}
		}
	}
}
