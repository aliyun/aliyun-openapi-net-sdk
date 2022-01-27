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

namespace Aliyun.Acs.Edas.Model.V20170801
{
	public class ListSubAccountResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private List<ListSubAccount_SubAccount> subAccountList;

		public int? Code
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

		public List<ListSubAccount_SubAccount> SubAccountList
		{
			get
			{
				return subAccountList;
			}
			set	
			{
				subAccountList = value;
			}
		}

		public class ListSubAccount_SubAccount
		{

			private string adminUserId;

			private string subUserId;

			private string email;

			private string phone;

			private string adminUserKp;

			private string subUserKp;

			private string adminEdasId;

			private string subEdasId;

			public string AdminUserId
			{
				get
				{
					return adminUserId;
				}
				set	
				{
					adminUserId = value;
				}
			}

			public string SubUserId
			{
				get
				{
					return subUserId;
				}
				set	
				{
					subUserId = value;
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

			public string AdminUserKp
			{
				get
				{
					return adminUserKp;
				}
				set	
				{
					adminUserKp = value;
				}
			}

			public string SubUserKp
			{
				get
				{
					return subUserKp;
				}
				set	
				{
					subUserKp = value;
				}
			}

			public string AdminEdasId
			{
				get
				{
					return adminEdasId;
				}
				set	
				{
					adminEdasId = value;
				}
			}

			public string SubEdasId
			{
				get
				{
					return subEdasId;
				}
				set	
				{
					subEdasId = value;
				}
			}
		}
	}
}
