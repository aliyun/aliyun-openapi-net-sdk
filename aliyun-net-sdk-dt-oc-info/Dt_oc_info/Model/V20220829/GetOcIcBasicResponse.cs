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
	public class GetOcIcBasicResponse : AcsResponse
	{

		private string code;

		private bool? success;

		private string message;

		private int? totalNum;

		private int? pageIndex;

		private int? pageNum;

		private string requestId;

		private GetOcIcBasic_Data data;

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

		public GetOcIcBasic_Data Data
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

		public class GetOcIcBasic_Data
		{

			private string entName;

			private string legalName;

			private string esDate;

			private string entStatus;

			private string regCap;

			private string recCap;

			private string socialCreditCode;

			private string licenseNumber;

			private string orgNo;

			private string taxNum;

			private string entType;

			private string industryNameLv1;

			private string industryNameLv2;

			private string opFrom;

			private string opTo;

			private string staffNum;

			private string insuredNum;

			private string entNameEng;

			private string formerNames;

			private string regOrg;

			private string checkDate;

			private string opScope;

			private string entAddress;

			private string entBrief;

			private string regOrgProvince;

			private string regOrgCity;

			private string regOrgDistrict;

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

			public string EsDate
			{
				get
				{
					return esDate;
				}
				set	
				{
					esDate = value;
				}
			}

			public string EntStatus
			{
				get
				{
					return entStatus;
				}
				set	
				{
					entStatus = value;
				}
			}

			public string RegCap
			{
				get
				{
					return regCap;
				}
				set	
				{
					regCap = value;
				}
			}

			public string RecCap
			{
				get
				{
					return recCap;
				}
				set	
				{
					recCap = value;
				}
			}

			public string SocialCreditCode
			{
				get
				{
					return socialCreditCode;
				}
				set	
				{
					socialCreditCode = value;
				}
			}

			public string LicenseNumber
			{
				get
				{
					return licenseNumber;
				}
				set	
				{
					licenseNumber = value;
				}
			}

			public string OrgNo
			{
				get
				{
					return orgNo;
				}
				set	
				{
					orgNo = value;
				}
			}

			public string TaxNum
			{
				get
				{
					return taxNum;
				}
				set	
				{
					taxNum = value;
				}
			}

			public string EntType
			{
				get
				{
					return entType;
				}
				set	
				{
					entType = value;
				}
			}

			public string IndustryNameLv1
			{
				get
				{
					return industryNameLv1;
				}
				set	
				{
					industryNameLv1 = value;
				}
			}

			public string IndustryNameLv2
			{
				get
				{
					return industryNameLv2;
				}
				set	
				{
					industryNameLv2 = value;
				}
			}

			public string OpFrom
			{
				get
				{
					return opFrom;
				}
				set	
				{
					opFrom = value;
				}
			}

			public string OpTo
			{
				get
				{
					return opTo;
				}
				set	
				{
					opTo = value;
				}
			}

			public string StaffNum
			{
				get
				{
					return staffNum;
				}
				set	
				{
					staffNum = value;
				}
			}

			public string InsuredNum
			{
				get
				{
					return insuredNum;
				}
				set	
				{
					insuredNum = value;
				}
			}

			public string EntNameEng
			{
				get
				{
					return entNameEng;
				}
				set	
				{
					entNameEng = value;
				}
			}

			public string FormerNames
			{
				get
				{
					return formerNames;
				}
				set	
				{
					formerNames = value;
				}
			}

			public string RegOrg
			{
				get
				{
					return regOrg;
				}
				set	
				{
					regOrg = value;
				}
			}

			public string CheckDate
			{
				get
				{
					return checkDate;
				}
				set	
				{
					checkDate = value;
				}
			}

			public string OpScope
			{
				get
				{
					return opScope;
				}
				set	
				{
					opScope = value;
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

			public string EntBrief
			{
				get
				{
					return entBrief;
				}
				set	
				{
					entBrief = value;
				}
			}

			public string RegOrgProvince
			{
				get
				{
					return regOrgProvince;
				}
				set	
				{
					regOrgProvince = value;
				}
			}

			public string RegOrgCity
			{
				get
				{
					return regOrgCity;
				}
				set	
				{
					regOrgCity = value;
				}
			}

			public string RegOrgDistrict
			{
				get
				{
					return regOrgDistrict;
				}
				set	
				{
					regOrgDistrict = value;
				}
			}
		}
	}
}
