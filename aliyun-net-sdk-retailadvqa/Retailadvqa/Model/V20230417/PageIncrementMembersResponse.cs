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

namespace Aliyun.Acs.retailadvqa.Model.V20230417
{
	public class PageIncrementMembersResponse : AcsResponse
	{

		private int? totalCount;

		private string requestId;

		private string success;

		private string errorCode;

		private string errorMessage;

		private List<PageIncrementMembers_DataItem> data;

		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
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

		public string Success
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

		public string ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
			}
		}

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
			}
		}

		public List<PageIncrementMembers_DataItem> Data
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

		public class PageIncrementMembers_DataItem
		{

			private string openMerchantId;

			private string outerMemberId;

			private string name;

			private string mobile;

			private string mixMobile;

			private string birthday;

			private string province;

			private string city;

			private string sex;

			private string email;

			private int? status;

			private string entryChannel;

			private int? levelNum;

			private string levelPoints;

			private string consumePoints;

			private string siteUsers;

			public string OpenMerchantId
			{
				get
				{
					return openMerchantId;
				}
				set	
				{
					openMerchantId = value;
				}
			}

			public string OuterMemberId
			{
				get
				{
					return outerMemberId;
				}
				set	
				{
					outerMemberId = value;
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

			public string Mobile
			{
				get
				{
					return mobile;
				}
				set	
				{
					mobile = value;
				}
			}

			public string MixMobile
			{
				get
				{
					return mixMobile;
				}
				set	
				{
					mixMobile = value;
				}
			}

			public string Birthday
			{
				get
				{
					return birthday;
				}
				set	
				{
					birthday = value;
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

			public string Sex
			{
				get
				{
					return sex;
				}
				set	
				{
					sex = value;
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

			public int? Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public string EntryChannel
			{
				get
				{
					return entryChannel;
				}
				set	
				{
					entryChannel = value;
				}
			}

			public int? LevelNum
			{
				get
				{
					return levelNum;
				}
				set	
				{
					levelNum = value;
				}
			}

			public string LevelPoints
			{
				get
				{
					return levelPoints;
				}
				set	
				{
					levelPoints = value;
				}
			}

			public string ConsumePoints
			{
				get
				{
					return consumePoints;
				}
				set	
				{
					consumePoints = value;
				}
			}

			public string SiteUsers
			{
				get
				{
					return siteUsers;
				}
				set	
				{
					siteUsers = value;
				}
			}
		}
	}
}
