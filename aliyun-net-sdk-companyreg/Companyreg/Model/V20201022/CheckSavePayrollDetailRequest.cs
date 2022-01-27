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
    public class CheckSavePayrollDetailRequest : RpcAcsRequest<CheckSavePayrollDetailResponse>
    {
        public CheckSavePayrollDetailRequest()
            : base("companyreg", "2020-10-22", "CheckSavePayrollDetail", "companyreg", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.companyreg.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.companyreg.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string income;

		private string corporateHousingAccumulationFund;

		private string personHousingAccumulationFund;

		private string persMedicalInsurance;

		private string corpUnemploymentInsurance;

		private long? id;

		private string personSocialInsurance;

		private string period;

		private string corporateSocialInsurance;

		private string corpInjuryInsurance;

		private string persPension;

		private string corpMedicalInsurance;

		private string idNo;

		private string employeeTime;

		private bool? updateEmployeeFlag;

		private string phone;

		private string persUnemploymentInsurance;

		private string bizId;

		private string name;

		private string corpPension;

		private string corpMaternityInsurance;

		public string Income
		{
			get
			{
				return income;
			}
			set	
			{
				income = value;
				DictionaryUtil.Add(QueryParameters, "Income", value);
			}
		}

		public string CorporateHousingAccumulationFund
		{
			get
			{
				return corporateHousingAccumulationFund;
			}
			set	
			{
				corporateHousingAccumulationFund = value;
				DictionaryUtil.Add(QueryParameters, "CorporateHousingAccumulationFund", value);
			}
		}

		public string PersonHousingAccumulationFund
		{
			get
			{
				return personHousingAccumulationFund;
			}
			set	
			{
				personHousingAccumulationFund = value;
				DictionaryUtil.Add(QueryParameters, "PersonHousingAccumulationFund", value);
			}
		}

		public string PersMedicalInsurance
		{
			get
			{
				return persMedicalInsurance;
			}
			set	
			{
				persMedicalInsurance = value;
				DictionaryUtil.Add(QueryParameters, "PersMedicalInsurance", value);
			}
		}

		public string CorpUnemploymentInsurance
		{
			get
			{
				return corpUnemploymentInsurance;
			}
			set	
			{
				corpUnemploymentInsurance = value;
				DictionaryUtil.Add(QueryParameters, "CorpUnemploymentInsurance", value);
			}
		}

		public long? Id
		{
			get
			{
				return id;
			}
			set	
			{
				id = value;
				DictionaryUtil.Add(QueryParameters, "Id", value.ToString());
			}
		}

		public string PersonSocialInsurance
		{
			get
			{
				return personSocialInsurance;
			}
			set	
			{
				personSocialInsurance = value;
				DictionaryUtil.Add(QueryParameters, "PersonSocialInsurance", value);
			}
		}

		public string Period
		{
			get
			{
				return period;
			}
			set	
			{
				period = value;
				DictionaryUtil.Add(QueryParameters, "Period", value);
			}
		}

		public string CorporateSocialInsurance
		{
			get
			{
				return corporateSocialInsurance;
			}
			set	
			{
				corporateSocialInsurance = value;
				DictionaryUtil.Add(QueryParameters, "CorporateSocialInsurance", value);
			}
		}

		public string CorpInjuryInsurance
		{
			get
			{
				return corpInjuryInsurance;
			}
			set	
			{
				corpInjuryInsurance = value;
				DictionaryUtil.Add(QueryParameters, "CorpInjuryInsurance", value);
			}
		}

		public string PersPension
		{
			get
			{
				return persPension;
			}
			set	
			{
				persPension = value;
				DictionaryUtil.Add(QueryParameters, "PersPension", value);
			}
		}

		public string CorpMedicalInsurance
		{
			get
			{
				return corpMedicalInsurance;
			}
			set	
			{
				corpMedicalInsurance = value;
				DictionaryUtil.Add(QueryParameters, "CorpMedicalInsurance", value);
			}
		}

		public string IdNo
		{
			get
			{
				return idNo;
			}
			set	
			{
				idNo = value;
				DictionaryUtil.Add(QueryParameters, "IdNo", value);
			}
		}

		public string EmployeeTime
		{
			get
			{
				return employeeTime;
			}
			set	
			{
				employeeTime = value;
				DictionaryUtil.Add(QueryParameters, "EmployeeTime", value);
			}
		}

		public bool? UpdateEmployeeFlag
		{
			get
			{
				return updateEmployeeFlag;
			}
			set	
			{
				updateEmployeeFlag = value;
				DictionaryUtil.Add(QueryParameters, "UpdateEmployeeFlag", value.ToString());
			}
		}

		public string Phone
		{
			get
			{
				return phone;
			}
			set	
			{
				phone = value;
				DictionaryUtil.Add(QueryParameters, "Phone", value);
			}
		}

		public string PersUnemploymentInsurance
		{
			get
			{
				return persUnemploymentInsurance;
			}
			set	
			{
				persUnemploymentInsurance = value;
				DictionaryUtil.Add(QueryParameters, "PersUnemploymentInsurance", value);
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

		public string CorpPension
		{
			get
			{
				return corpPension;
			}
			set	
			{
				corpPension = value;
				DictionaryUtil.Add(QueryParameters, "CorpPension", value);
			}
		}

		public string CorpMaternityInsurance
		{
			get
			{
				return corpMaternityInsurance;
			}
			set	
			{
				corpMaternityInsurance = value;
				DictionaryUtil.Add(QueryParameters, "CorpMaternityInsurance", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CheckSavePayrollDetailResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CheckSavePayrollDetailResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
