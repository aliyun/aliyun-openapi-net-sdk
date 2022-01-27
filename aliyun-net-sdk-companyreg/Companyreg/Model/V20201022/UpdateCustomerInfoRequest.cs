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
    public class UpdateCustomerInfoRequest : RpcAcsRequest<UpdateCustomerInfoResponse>
    {
        public UpdateCustomerInfoRequest()
            : base("companyreg", "2020-10-22", "UpdateCustomerInfo", "companyreg", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.companyreg.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.companyreg.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string contactTelInfo;

		private string taxPreparerName;

		private string taxAgentSecret;

		private string legalRepresentative;

		private string taxPreparerPassword;

		private string establishmentDate;

		private string contactName;

		private string bizScope;

		private string incomeDeclarationPassword;

		private string companyType;

		private string corpAddress;

		private string bizId;

		private string name;

		private bool? isRefreshInfo;

		private string registeredCapital;

		private string operatingPeriod;

		public string ContactTelInfo
		{
			get
			{
				return contactTelInfo;
			}
			set	
			{
				contactTelInfo = value;
				DictionaryUtil.Add(QueryParameters, "ContactTelInfo", value);
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
				DictionaryUtil.Add(QueryParameters, "TaxPreparerName", value);
			}
		}

		public string TaxAgentSecret
		{
			get
			{
				return taxAgentSecret;
			}
			set	
			{
				taxAgentSecret = value;
				DictionaryUtil.Add(QueryParameters, "TaxAgentSecret", value);
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
				DictionaryUtil.Add(QueryParameters, "LegalRepresentative", value);
			}
		}

		public string TaxPreparerPassword
		{
			get
			{
				return taxPreparerPassword;
			}
			set	
			{
				taxPreparerPassword = value;
				DictionaryUtil.Add(QueryParameters, "TaxPreparerPassword", value);
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
				DictionaryUtil.Add(QueryParameters, "EstablishmentDate", value);
			}
		}

		public string ContactName
		{
			get
			{
				return contactName;
			}
			set	
			{
				contactName = value;
				DictionaryUtil.Add(QueryParameters, "ContactName", value);
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
				DictionaryUtil.Add(QueryParameters, "BizScope", value);
			}
		}

		public string IncomeDeclarationPassword
		{
			get
			{
				return incomeDeclarationPassword;
			}
			set	
			{
				incomeDeclarationPassword = value;
				DictionaryUtil.Add(QueryParameters, "IncomeDeclarationPassword", value);
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
				DictionaryUtil.Add(QueryParameters, "CompanyType", value);
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
				DictionaryUtil.Add(QueryParameters, "CorpAddress", value);
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

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
			}
		}

		public bool? IsRefreshInfo
		{
			get
			{
				return isRefreshInfo;
			}
			set	
			{
				isRefreshInfo = value;
				DictionaryUtil.Add(QueryParameters, "IsRefreshInfo", value.ToString());
			}
		}

		public string RegisteredCapital
		{
			get
			{
				return registeredCapital;
			}
			set	
			{
				registeredCapital = value;
				DictionaryUtil.Add(QueryParameters, "RegisteredCapital", value);
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
				DictionaryUtil.Add(QueryParameters, "OperatingPeriod", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateCustomerInfoResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateCustomerInfoResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
