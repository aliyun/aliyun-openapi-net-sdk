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

namespace Aliyun.Acs.Sddp.Model.V20190103
{
	public class DescribeAccountsResponse : AcsResponse
	{

		private string requestId;

		private int? pageSize;

		private int? currentPage;

		private int? totalCount;

		private List<DescribeAccounts_Account> items;

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

		public int? CurrentPage
		{
			get
			{
				return currentPage;
			}
			set	
			{
				currentPage = value;
			}
		}

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

		public List<DescribeAccounts_Account> Items
		{
			get
			{
				return items;
			}
			set	
			{
				items = value;
			}
		}

		public class DescribeAccounts_Account
		{

			private long? id;

			private long? userId;

			private long? firstLevelDepartId;

			private string loginName;

			private string fullName;

			private string cellphoneNum;

			private string telephoneNum;

			private string email;

			private string activeStatus;

			private string deleteStatus;

			private string dataInstance;

			private long? createTime;

			private long? loginDataTime;

			private string loginPolicyName;

			private string firstLevelDepartName;

			private string roleNames;

			private string instanceName;

			private long? aliUid;

			private long? accountTypeId;

			private DescribeAccounts_EventCount eventCount;

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

			public long? UserId
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

			public long? FirstLevelDepartId
			{
				get
				{
					return firstLevelDepartId;
				}
				set	
				{
					firstLevelDepartId = value;
				}
			}

			public string LoginName
			{
				get
				{
					return loginName;
				}
				set	
				{
					loginName = value;
				}
			}

			public string FullName
			{
				get
				{
					return fullName;
				}
				set	
				{
					fullName = value;
				}
			}

			public string CellphoneNum
			{
				get
				{
					return cellphoneNum;
				}
				set	
				{
					cellphoneNum = value;
				}
			}

			public string TelephoneNum
			{
				get
				{
					return telephoneNum;
				}
				set	
				{
					telephoneNum = value;
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

			public string ActiveStatus
			{
				get
				{
					return activeStatus;
				}
				set	
				{
					activeStatus = value;
				}
			}

			public string DeleteStatus
			{
				get
				{
					return deleteStatus;
				}
				set	
				{
					deleteStatus = value;
				}
			}

			public string DataInstance
			{
				get
				{
					return dataInstance;
				}
				set	
				{
					dataInstance = value;
				}
			}

			public long? CreateTime
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

			public long? LoginDataTime
			{
				get
				{
					return loginDataTime;
				}
				set	
				{
					loginDataTime = value;
				}
			}

			public string LoginPolicyName
			{
				get
				{
					return loginPolicyName;
				}
				set	
				{
					loginPolicyName = value;
				}
			}

			public string FirstLevelDepartName
			{
				get
				{
					return firstLevelDepartName;
				}
				set	
				{
					firstLevelDepartName = value;
				}
			}

			public string RoleNames
			{
				get
				{
					return roleNames;
				}
				set	
				{
					roleNames = value;
				}
			}

			public string InstanceName
			{
				get
				{
					return instanceName;
				}
				set	
				{
					instanceName = value;
				}
			}

			public long? AliUid
			{
				get
				{
					return aliUid;
				}
				set	
				{
					aliUid = value;
				}
			}

			public long? AccountTypeId
			{
				get
				{
					return accountTypeId;
				}
				set	
				{
					accountTypeId = value;
				}
			}

			public DescribeAccounts_EventCount EventCount
			{
				get
				{
					return eventCount;
				}
				set	
				{
					eventCount = value;
				}
			}

			public class DescribeAccounts_EventCount
			{

				private DescribeAccounts_Total total;

				public DescribeAccounts_Total Total
				{
					get
					{
						return total;
					}
					set	
					{
						total = value;
					}
				}

				public class DescribeAccounts_Total
				{

					private long? totalCount;

					private long? undealCount;

					private long? confirmCount;

					private long? excludeCount;

					public long? TotalCount
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

					public long? UndealCount
					{
						get
						{
							return undealCount;
						}
						set	
						{
							undealCount = value;
						}
					}

					public long? ConfirmCount
					{
						get
						{
							return confirmCount;
						}
						set	
						{
							confirmCount = value;
						}
					}

					public long? ExcludeCount
					{
						get
						{
							return excludeCount;
						}
						set	
						{
							excludeCount = value;
						}
					}
				}
			}
		}
	}
}
