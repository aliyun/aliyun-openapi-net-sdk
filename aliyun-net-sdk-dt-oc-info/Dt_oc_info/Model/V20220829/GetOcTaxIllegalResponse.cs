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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.dt_oc_info.Model.V20220829
{
	public class GetOcTaxIllegalResponse : AcsResponse
	{

		private string code;

		private bool? success;

		private string message;

		private int? totalNum;

		private int? pageIndex;

		private int? pageNum;

		private string requestId;

		private List<GetOcTaxIllegal_DataItem> data;

		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

		public int? TotalNum
		{
			get
			{
				return totalNum;
			}
			set	
			{
				totalNum = value;
			}
		}

		public int? PageIndex
		{
			get
			{
				return pageIndex;
			}
			set	
			{
				pageIndex = value;
			}
		}

		public int? PageNum
		{
			get
			{
				return pageNum;
			}
			set	
			{
				pageNum = value;
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

		public List<GetOcTaxIllegal_DataItem> Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class GetOcTaxIllegal_DataItem
		{

			private string entName;

			private string taxpayerNum;

			private string orgCode;

			private string entAddress;

			private string caseType;

			private string illegalTruth;

			private string publishDate;

			private string lawBasis;

			private string department;

			private string legalName;

			private string legalSex;

			private string legalCardType;

			private string legalCardNum;

			private string financialName;

			private string financialSex;

			private string financialCardType;

			private string financialCardNum;

			private string agencyEnt;

			private string agencyName;

			private string agencySex;

			private string agencyCardType;

			private string agencyCardNum;

			public string EntName
			{
				get
				{
					return entName;
				}
				set	
				{
					entName = value;
				}
			}

			public string TaxpayerNum
			{
				get
				{
					return taxpayerNum;
				}
				set	
				{
					taxpayerNum = value;
				}
			}

			public string OrgCode
			{
				get
				{
					return orgCode;
				}
				set	
				{
					orgCode = value;
				}
			}

			public string EntAddress
			{
				get
				{
					return entAddress;
				}
				set	
				{
					entAddress = value;
				}
			}

			public string CaseType
			{
				get
				{
					return caseType;
				}
				set	
				{
					caseType = value;
				}
			}

			public string IllegalTruth
			{
				get
				{
					return illegalTruth;
				}
				set	
				{
					illegalTruth = value;
				}
			}

			public string PublishDate
			{
				get
				{
					return publishDate;
				}
				set	
				{
					publishDate = value;
				}
			}

			public string LawBasis
			{
				get
				{
					return lawBasis;
				}
				set	
				{
					lawBasis = value;
				}
			}

			public string Department
			{
				get
				{
					return department;
				}
				set	
				{
					department = value;
				}
			}

			public string LegalName
			{
				get
				{
					return legalName;
				}
				set	
				{
					legalName = value;
				}
			}

			public string LegalSex
			{
				get
				{
					return legalSex;
				}
				set	
				{
					legalSex = value;
				}
			}

			public string LegalCardType
			{
				get
				{
					return legalCardType;
				}
				set	
				{
					legalCardType = value;
				}
			}

			public string LegalCardNum
			{
				get
				{
					return legalCardNum;
				}
				set	
				{
					legalCardNum = value;
				}
			}

			public string FinancialName
			{
				get
				{
					return financialName;
				}
				set	
				{
					financialName = value;
				}
			}

			public string FinancialSex
			{
				get
				{
					return financialSex;
				}
				set	
				{
					financialSex = value;
				}
			}

			public string FinancialCardType
			{
				get
				{
					return financialCardType;
				}
				set	
				{
					financialCardType = value;
				}
			}

			public string FinancialCardNum
			{
				get
				{
					return financialCardNum;
				}
				set	
				{
					financialCardNum = value;
				}
			}

			public string AgencyEnt
			{
				get
				{
					return agencyEnt;
				}
				set	
				{
					agencyEnt = value;
				}
			}

			public string AgencyName
			{
				get
				{
					return agencyName;
				}
				set	
				{
					agencyName = value;
				}
			}

			public string AgencySex
			{
				get
				{
					return agencySex;
				}
				set	
				{
					agencySex = value;
				}
			}

			public string AgencyCardType
			{
				get
				{
					return agencyCardType;
				}
				set	
				{
					agencyCardType = value;
				}
			}

			public string AgencyCardNum
			{
				get
				{
					return agencyCardNum;
				}
				set	
				{
					agencyCardNum = value;
				}
			}
		}
	}
}
