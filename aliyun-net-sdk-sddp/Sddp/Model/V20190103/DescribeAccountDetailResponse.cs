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
	public class DescribeAccountDetailResponse : AcsResponse
	{

		private string requestId;

		private DescribeAccountDetail_Account account;

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

		public DescribeAccountDetail_Account Account
		{
			get
			{
				return account;
			}
			set	
			{
				account = value;
			}
		}

		public class DescribeAccountDetail_Account
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

			private long? aliUid;

			private List<DescribeAccountDetail_Privilege> privilegeList;

			private DescribeAccountDetail_EventCount eventCount;

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

			public List<DescribeAccountDetail_Privilege> PrivilegeList
			{
				get
				{
					return privilegeList;
				}
				set	
				{
					privilegeList = value;
				}
			}

			public DescribeAccountDetail_EventCount EventCount
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

			public class DescribeAccountDetail_Privilege
			{

				private string productName;

				private string useAccountId;

				private int? useAccountType;

				private string useAccountTypeName;

				private long? useAccountCreateTime;

				private string useAccountName;

				public string ProductName
				{
					get
					{
						return productName;
					}
					set	
					{
						productName = value;
					}
				}

				public string UseAccountId
				{
					get
					{
						return useAccountId;
					}
					set	
					{
						useAccountId = value;
					}
				}

				public int? UseAccountType
				{
					get
					{
						return useAccountType;
					}
					set	
					{
						useAccountType = value;
					}
				}

				public string UseAccountTypeName
				{
					get
					{
						return useAccountTypeName;
					}
					set	
					{
						useAccountTypeName = value;
					}
				}

				public long? UseAccountCreateTime
				{
					get
					{
						return useAccountCreateTime;
					}
					set	
					{
						useAccountCreateTime = value;
					}
				}

				public string UseAccountName
				{
					get
					{
						return useAccountName;
					}
					set	
					{
						useAccountName = value;
					}
				}
			}

			public class DescribeAccountDetail_EventCount
			{

				private DescribeAccountDetail_Total total;

				public DescribeAccountDetail_Total Total
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

				public class DescribeAccountDetail_Total
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
