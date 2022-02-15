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

namespace Aliyun.Acs.Copyright.Model.V20190123
{
	public class GetCopyrightPersonListResponse : AcsResponse
	{

		private int? pageNum;

		private string requestId;

		private int? pageSize;

		private bool? success;

		private int? totalItemNum;

		private List<GetCopyrightPersonList_DataItem> data;

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

		public List<GetCopyrightPersonList_DataItem> Data
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

		public class GetCopyrightPersonList_DataItem
		{

			private string legalPersonType;

			private int? roleType;

			private string city;

			private int? useType;

			private string phone;

			private string county;

			private string userPk;

			private string cardType;

			private string email;

			private string expiredDate;

			private string cardNum;

			private string address;

			private int? ownerType;

			private string name;

			private string personId;

			private int? auditStatus;

			private string province;

			public string LegalPersonType
			{
				get
				{
					return legalPersonType;
				}
				set	
				{
					legalPersonType = value;
				}
			}

			public int? RoleType
			{
				get
				{
					return roleType;
				}
				set	
				{
					roleType = value;
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

			public int? UseType
			{
				get
				{
					return useType;
				}
				set	
				{
					useType = value;
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

			public string County
			{
				get
				{
					return county;
				}
				set	
				{
					county = value;
				}
			}

			public string UserPk
			{
				get
				{
					return userPk;
				}
				set	
				{
					userPk = value;
				}
			}

			public string CardType
			{
				get
				{
					return cardType;
				}
				set	
				{
					cardType = value;
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

			public string ExpiredDate
			{
				get
				{
					return expiredDate;
				}
				set	
				{
					expiredDate = value;
				}
			}

			public string CardNum
			{
				get
				{
					return cardNum;
				}
				set	
				{
					cardNum = value;
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

			public int? OwnerType
			{
				get
				{
					return ownerType;
				}
				set	
				{
					ownerType = value;
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

			public string PersonId
			{
				get
				{
					return personId;
				}
				set	
				{
					personId = value;
				}
			}

			public int? AuditStatus
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
		}
	}
}
