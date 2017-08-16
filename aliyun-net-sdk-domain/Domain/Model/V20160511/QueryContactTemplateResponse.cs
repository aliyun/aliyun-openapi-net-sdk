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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Domain.Model.V20160511
{
	public class QueryContactTemplateResponse : AcsResponse
	{

		private string requestId;

		private int? totalItemNum;

		private int? currentPageNum;

		private int? totalPageNum;

		private int? pageSize;

		private bool? prePage;

		private bool? nextPage;

		private List<QueryContactTemplate_ContactTemplate> contactTemplates;

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

		public int? TotalItemNum
		{
			get
			{
				return totalItemNum;
			}
			set	
			{
				totalItemNum = value;
			}
		}

		public int? CurrentPageNum
		{
			get
			{
				return currentPageNum;
			}
			set	
			{
				currentPageNum = value;
			}
		}

		public int? TotalPageNum
		{
			get
			{
				return totalPageNum;
			}
			set	
			{
				totalPageNum = value;
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public bool? PrePage
		{
			get
			{
				return prePage;
			}
			set	
			{
				prePage = value;
			}
		}

		public bool? NextPage
		{
			get
			{
				return nextPage;
			}
			set	
			{
				nextPage = value;
			}
		}

		public List<QueryContactTemplate_ContactTemplate> ContactTemplates
		{
			get
			{
				return contactTemplates;
			}
			set	
			{
				contactTemplates = value;
			}
		}

		public class QueryContactTemplate_ContactTemplate
		{

			private long? contactTemplateId;

			private string createTime;

			private string updateTime;

			private string userId;

			private string regType;

			private bool? defaultTemplate;

			private string auditStatus;

			private string cName;

			private string eName;

			private string cCompany;

			private string eCompany;

			private string cCountry;

			private string cProvince;

			private string eProvince;

			private string cCity;

			private string eCity;

			private string cVenu;

			private string eVenu;

			private string email;

			private string telArea;

			private string postalCode;

			private string telMain;

			private string telExt;

			public long? ContactTemplateId
			{
				get
				{
					return contactTemplateId;
				}
				set	
				{
					contactTemplateId = value;
				}
			}

			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public string UpdateTime
			{
				get
				{
					return updateTime;
				}
				set	
				{
					updateTime = value;
				}
			}

			public string UserId
			{
				get
				{
					return userId;
				}
				set	
				{
					userId = value;
				}
			}

			public string RegType
			{
				get
				{
					return regType;
				}
				set	
				{
					regType = value;
				}
			}

			public bool? DefaultTemplate
			{
				get
				{
					return defaultTemplate;
				}
				set	
				{
					defaultTemplate = value;
				}
			}

			public string AuditStatus
			{
				get
				{
					return auditStatus;
				}
				set	
				{
					auditStatus = value;
				}
			}

			public string CName
			{
				get
				{
					return cName;
				}
				set	
				{
					cName = value;
				}
			}

			public string EName
			{
				get
				{
					return eName;
				}
				set	
				{
					eName = value;
				}
			}

			public string CCompany
			{
				get
				{
					return cCompany;
				}
				set	
				{
					cCompany = value;
				}
			}

			public string ECompany
			{
				get
				{
					return eCompany;
				}
				set	
				{
					eCompany = value;
				}
			}

			public string CCountry
			{
				get
				{
					return cCountry;
				}
				set	
				{
					cCountry = value;
				}
			}

			public string CProvince
			{
				get
				{
					return cProvince;
				}
				set	
				{
					cProvince = value;
				}
			}

			public string EProvince
			{
				get
				{
					return eProvince;
				}
				set	
				{
					eProvince = value;
				}
			}

			public string CCity
			{
				get
				{
					return cCity;
				}
				set	
				{
					cCity = value;
				}
			}

			public string ECity
			{
				get
				{
					return eCity;
				}
				set	
				{
					eCity = value;
				}
			}

			public string CVenu
			{
				get
				{
					return cVenu;
				}
				set	
				{
					cVenu = value;
				}
			}

			public string EVenu
			{
				get
				{
					return eVenu;
				}
				set	
				{
					eVenu = value;
				}
			}

			public string Email
			{
				get
				{
					return email;
				}
				set	
				{
					email = value;
				}
			}

			public string TelArea
			{
				get
				{
					return telArea;
				}
				set	
				{
					telArea = value;
				}
			}

			public string PostalCode
			{
				get
				{
					return postalCode;
				}
				set	
				{
					postalCode = value;
				}
			}

			public string TelMain
			{
				get
				{
					return telMain;
				}
				set	
				{
					telMain = value;
				}
			}

			public string TelExt
			{
				get
				{
					return telExt;
				}
				set	
				{
					telExt = value;
				}
			}
		}
	}
}