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
	public class GetOcOperationRecruitmentResponse : AcsResponse
	{

		private string code;

		private bool? success;

		private string message;

		private int? totalNum;

		private int? pageIndex;

		private int? pageNum;

		private string requestId;

		private List<GetOcOperationRecruitment_DataItem> data;

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

		public List<GetOcOperationRecruitment_DataItem> Data
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

		public class GetOcOperationRecruitment_DataItem
		{

			private string entName;

			private string recruitingName;

			private string description;

			private string salary;

			private string recruitingAddress;

			private string education;

			private string experience;

			private string benefitList;

			private string publishDate;

			private string startDate;

			private string endDate;

			private string pageUrl;

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

			public string RecruitingName
			{
				get
				{
					return recruitingName;
				}
				set	
				{
					recruitingName = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}

			public string Salary
			{
				get
				{
					return salary;
				}
				set	
				{
					salary = value;
				}
			}

			public string RecruitingAddress
			{
				get
				{
					return recruitingAddress;
				}
				set	
				{
					recruitingAddress = value;
				}
			}

			public string Education
			{
				get
				{
					return education;
				}
				set	
				{
					education = value;
				}
			}

			public string Experience
			{
				get
				{
					return experience;
				}
				set	
				{
					experience = value;
				}
			}

			public string BenefitList
			{
				get
				{
					return benefitList;
				}
				set	
				{
					benefitList = value;
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

			public string StartDate
			{
				get
				{
					return startDate;
				}
				set	
				{
					startDate = value;
				}
			}

			public string EndDate
			{
				get
				{
					return endDate;
				}
				set	
				{
					endDate = value;
				}
			}

			public string PageUrl
			{
				get
				{
					return pageUrl;
				}
				set	
				{
					pageUrl = value;
				}
			}
		}
	}
}
