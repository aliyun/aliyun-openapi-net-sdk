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
	public class GetTaxInfoResponse : AcsResponse
	{

		private string taxPreparerName;

		private string taxiationAgentSecret;

		private string myTaxInfo;

		private string taxArea;

		private string acctgSystem;

		private string requestId;

		private string externalUniqueId;

		private string taxTypes;

		private string incomeDeclarationPsw;

		private string isNeedSmsCode;

		private string taxNo;

		private string taxpayerType;

		private string name;

		private string taxPreparerPsw;

		private string taxAreaCode;

		private long? tenantId;

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

		public string MyTaxInfo
		{
			get
			{
				return myTaxInfo;
			}
			set	
			{
				myTaxInfo = value;
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

		public string IsNeedSmsCode
		{
			get
			{
				return isNeedSmsCode;
			}
			set	
			{
				isNeedSmsCode = value;
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

		public string TaxAreaCode
		{
			get
			{
				return taxAreaCode;
			}
			set	
			{
				taxAreaCode = value;
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
