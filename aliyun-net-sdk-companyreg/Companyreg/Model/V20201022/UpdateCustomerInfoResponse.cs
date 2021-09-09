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
	public class UpdateCustomerInfoResponse : AcsResponse
	{

		private string acctgSystem;

		private string bizScope;

		private string companyType;

		private string corpAddress;

		private string establishmentDate;

		private string externalUniqueId;

		private string incomeDeclarationPsw;

		private string legalRepresentative;

		private string name;

		private string orgName;

		private string registeredCaptial;

		private string requestId;

		private string taxArea;

		private string taxNo;

		private string taxPreparerName;

		private string taxPreparerPsw;

		private string taxTypes;

		private string taxiationAgentSecret;

		private string taxpayerType;

		private long? tenantId;

		public string AcctgSystem
		{
			get
			{
				return acctgSystem;
			}
			set	
			{
				acctgSystem = value;
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

		public string ExternalUniqueId
		{
			get
			{
				return externalUniqueId;
			}
			set	
			{
				externalUniqueId = value;
			}
		}

		public string IncomeDeclarationPsw
		{
			get
			{
				return incomeDeclarationPsw;
			}
			set	
			{
				incomeDeclarationPsw = value;
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

		public string OrgName
		{
			get
			{
				return orgName;
			}
			set	
			{
				orgName = value;
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

		public string TaxArea
		{
			get
			{
				return taxArea;
			}
			set	
			{
				taxArea = value;
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

		public string TaxPreparerName
		{
			get
			{
				return taxPreparerName;
			}
			set	
			{
				taxPreparerName = value;
			}
		}

		public string TaxPreparerPsw
		{
			get
			{
				return taxPreparerPsw;
			}
			set	
			{
				taxPreparerPsw = value;
			}
		}

		public string TaxTypes
		{
			get
			{
				return taxTypes;
			}
			set	
			{
				taxTypes = value;
			}
		}

		public string TaxiationAgentSecret
		{
			get
			{
				return taxiationAgentSecret;
			}
			set	
			{
				taxiationAgentSecret = value;
			}
		}

		public string TaxpayerType
		{
			get
			{
				return taxpayerType;
			}
			set	
			{
				taxpayerType = value;
			}
		}

		public long? TenantId
		{
			get
			{
				return tenantId;
			}
			set	
			{
				tenantId = value;
			}
		}
	}
}
