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
	public class GetPayrollInfoResponse : AcsResponse
	{

		private string corporateHousingAccumulationFund;

		private string corporateSocialInsurance;

		private string employeeTime;

		private long? id;

		private string idNo;

		private string income;

		private string name;

		private string period;

		private string personHousingAccumulationFund;

		private string personSocialInsurance;

		private string phone;

		private string corpPension;

		private string corpMedicalInsurance;

		private string corpUnemploymentInsurance;

		private string corpInjuryInsurance;

		private string corpMaternityInsurance;

		private string persPension;

		private string persUnemploymentInsurance;

		private string persMedicalInsurance;

		private string requestId;

		public string CorporateHousingAccumulationFund
		{
			get
			{
				return corporateHousingAccumulationFund;
			}
			set	
			{
				corporateHousingAccumulationFund = value;
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
			}
		}

		public string Income
		{
			get
			{
				return income;
			}
			set	
			{
				income = value;
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

		public string Period
		{
			get
			{
				return period;
			}
			set	
			{
				period = value;
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
	}
}
