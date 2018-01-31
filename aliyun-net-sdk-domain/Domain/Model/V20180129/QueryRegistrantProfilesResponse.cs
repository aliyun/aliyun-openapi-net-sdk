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

namespace Aliyun.Acs.Domain.Model.V20180129
{
	public class QueryRegistrantProfilesResponse : AcsResponse
	{

		private string requestId;

		private int? totalItemNum;

		private int? currentPageNum;

		private int? totalPageNum;

		private int? pageSize;

		private bool? prePage;

		private bool? nextPage;

		private List<QueryRegistrantProfiles_RegistrantProfile> registrantProfiles;

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

		public List<QueryRegistrantProfiles_RegistrantProfile> RegistrantProfiles
		{
			get
			{
				return registrantProfiles;
			}
			set	
			{
				registrantProfiles = value;
			}
		}

		public class QueryRegistrantProfiles_RegistrantProfile
		{

			private long? registrantProfileId;

			private string createTime;

			private string updateTime;

			private bool? defaultRegistrantProfile;

			private string registrantName;

			private string registrantOrganization;

			private string country;

			private string province;

			private string city;

			private string address;

			private string email;

			private string postalCode;

			private string telArea;

			private string telephone;

			private string telExt;

			private int? emailVerificationStatus;

			private string zhRegistrantName;

			private string zhRegistrantOrganization;

			private string zhProvince;

			private string zhCity;

			private string zhAddress;

			private string registrantType;

			private string realNameStatus;

			public long? RegistrantProfileId
			{
				get
				{
					return registrantProfileId;
				}
				set	
				{
					registrantProfileId = value;
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

			public bool? DefaultRegistrantProfile
			{
				get
				{
					return defaultRegistrantProfile;
				}
				set	
				{
					defaultRegistrantProfile = value;
				}
			}

			public string RegistrantName
			{
				get
				{
					return registrantName;
				}
				set	
				{
					registrantName = value;
				}
			}

			public string RegistrantOrganization
			{
				get
				{
					return registrantOrganization;
				}
				set	
				{
					registrantOrganization = value;
				}
			}

			public string Country
			{
				get
				{
					return country;
				}
				set	
				{
					country = value;
				}
			}

			public string Province
			{
				get
				{
					return province;
				}
				set	
				{
					province = value;
				}
			}

			public string City
			{
				get
				{
					return city;
				}
				set	
				{
					city = value;
				}
			}

			public string Address
			{
				get
				{
					return address;
				}
				set	
				{
					address = value;
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

			public string Telephone
			{
				get
				{
					return telephone;
				}
				set	
				{
					telephone = value;
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

			public int? EmailVerificationStatus
			{
				get
				{
					return emailVerificationStatus;
				}
				set	
				{
					emailVerificationStatus = value;
				}
			}

			public string ZhRegistrantName
			{
				get
				{
					return zhRegistrantName;
				}
				set	
				{
					zhRegistrantName = value;
				}
			}

			public string ZhRegistrantOrganization
			{
				get
				{
					return zhRegistrantOrganization;
				}
				set	
				{
					zhRegistrantOrganization = value;
				}
			}

			public string ZhProvince
			{
				get
				{
					return zhProvince;
				}
				set	
				{
					zhProvince = value;
				}
			}

			public string ZhCity
			{
				get
				{
					return zhCity;
				}
				set	
				{
					zhCity = value;
				}
			}

			public string ZhAddress
			{
				get
				{
					return zhAddress;
				}
				set	
				{
					zhAddress = value;
				}
			}

			public string RegistrantType
			{
				get
				{
					return registrantType;
				}
				set	
				{
					registrantType = value;
				}
			}

			public string RealNameStatus
			{
				get
				{
					return realNameStatus;
				}
				set	
				{
					realNameStatus = value;
				}
			}
		}
	}
}