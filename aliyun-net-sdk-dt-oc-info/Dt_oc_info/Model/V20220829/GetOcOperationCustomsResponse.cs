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
	public class GetOcOperationCustomsResponse : AcsResponse
	{

		private string code;

		private bool? success;

		private string message;

		private int? totalNum;

		private int? pageIndex;

		private int? pageNum;

		private string requestId;

		private List<GetOcOperationCustoms_DataItem> data;

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

		public List<GetOcOperationCustoms_DataItem> Data
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

		public class GetOcOperationCustoms_DataItem
		{

			private string entName;

			private string regDate;

			private string customsNum;

			private string customsReg;

			private string businessCate;

			private string adminRegionName;

			private string ecoRegionName;

			private string specialArea;

			private string industryType;

			private string validDate;

			private string electType;

			private string cancelFlag;

			private string annualReport;

			private string creditLevelsNew;

			private string identCode;

			private string identDate;

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

			public string RegDate
			{
				get
				{
					return regDate;
				}
				set	
				{
					regDate = value;
				}
			}

			public string CustomsNum
			{
				get
				{
					return customsNum;
				}
				set	
				{
					customsNum = value;
				}
			}

			public string CustomsReg
			{
				get
				{
					return customsReg;
				}
				set	
				{
					customsReg = value;
				}
			}

			public string BusinessCate
			{
				get
				{
					return businessCate;
				}
				set	
				{
					businessCate = value;
				}
			}

			public string AdminRegionName
			{
				get
				{
					return adminRegionName;
				}
				set	
				{
					adminRegionName = value;
				}
			}

			public string EcoRegionName
			{
				get
				{
					return ecoRegionName;
				}
				set	
				{
					ecoRegionName = value;
				}
			}

			public string SpecialArea
			{
				get
				{
					return specialArea;
				}
				set	
				{
					specialArea = value;
				}
			}

			public string IndustryType
			{
				get
				{
					return industryType;
				}
				set	
				{
					industryType = value;
				}
			}

			public string ValidDate
			{
				get
				{
					return validDate;
				}
				set	
				{
					validDate = value;
				}
			}

			public string ElectType
			{
				get
				{
					return electType;
				}
				set	
				{
					electType = value;
				}
			}

			public string CancelFlag
			{
				get
				{
					return cancelFlag;
				}
				set	
				{
					cancelFlag = value;
				}
			}

			public string AnnualReport
			{
				get
				{
					return annualReport;
				}
				set	
				{
					annualReport = value;
				}
			}

			public string CreditLevelsNew
			{
				get
				{
					return creditLevelsNew;
				}
				set	
				{
					creditLevelsNew = value;
				}
			}

			public string IdentCode
			{
				get
				{
					return identCode;
				}
				set	
				{
					identCode = value;
				}
			}

			public string IdentDate
			{
				get
				{
					return identDate;
				}
				set	
				{
					identDate = value;
				}
			}
		}
	}
}
