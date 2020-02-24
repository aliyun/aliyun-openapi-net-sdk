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

namespace Aliyun.Acs.OutboundBot.Model.V20191226
{
	public class ListUnreachableContactsResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private int? httpStatusCode;

		private ListUnreachableContacts_UnreachableContacts unreachableContacts;

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

		public int? HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
			}
		}

		public ListUnreachableContacts_UnreachableContacts UnreachableContacts
		{
			get
			{
				return unreachableContacts;
			}
			set	
			{
				unreachableContacts = value;
			}
		}

		public class ListUnreachableContacts_UnreachableContacts
		{

			private int? totalCount;

			private int? pageNumber;

			private int? pageSize;

			private List<ListUnreachableContacts_UnreachableContact> list;

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

			public int? PageNumber
			{
				get
				{
					return pageNumber;
				}
				set	
				{
					pageNumber = value;
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

			public List<ListUnreachableContacts_UnreachableContact> List
			{
				get
				{
					return list;
				}
				set	
				{
					list = value;
				}
			}

			public class ListUnreachableContacts_UnreachableContact
			{

				private int? totalAttempts;

				private List<ListUnreachableContacts_Contact> contacts;

				public int? TotalAttempts
				{
					get
					{
						return totalAttempts;
					}
					set	
					{
						totalAttempts = value;
					}
				}

				public List<ListUnreachableContacts_Contact> Contacts
				{
					get
					{
						return contacts;
					}
					set	
					{
						contacts = value;
					}
				}

				public class ListUnreachableContacts_Contact
				{

					private string contactId;

					private string contactName;

					private string role;

					private string phoneNumber;

					private string state;

					private string referenceId;

					public string ContactId
					{
						get
						{
							return contactId;
						}
						set	
						{
							contactId = value;
						}
					}

					public string ContactName
					{
						get
						{
							return contactName;
						}
						set	
						{
							contactName = value;
						}
					}

					public string Role
					{
						get
						{
							return role;
						}
						set	
						{
							role = value;
						}
					}

					public string PhoneNumber
					{
						get
						{
							return phoneNumber;
						}
						set	
						{
							phoneNumber = value;
						}
					}

					public string State
					{
						get
						{
							return state;
						}
						set	
						{
							state = value;
						}
					}

					public string ReferenceId
					{
						get
						{
							return referenceId;
						}
						set	
						{
							referenceId = value;
						}
					}
				}
			}
		}
	}
}
