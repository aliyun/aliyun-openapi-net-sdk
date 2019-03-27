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

namespace Aliyun.Acs.CCC.Model.V20170705
{
	public class CreateInstanceResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private int? httpStatusCode;

		private CreateInstance_Instance instance;

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

		public CreateInstance_Instance Instance
		{
			get
			{
				return instance;
			}
			set	
			{
				instance = value;
			}
		}

		public class CreateInstance_Instance
		{

			private string instanceId;

			private string instanceName;

			private string instanceDescription;

			private string domainName;

			private string consoleUrl;

			private string storageBucket;

			private int? storageMaxDays;

			private int? storageMaxSize;

			private int? maxOnlineAgents;

			private string tenantId;

			private string status;

			private string directoryId;

			private long? createdTime;

			private string owner;

			private List<CreateInstance_User> admin;

			private List<CreateInstance_PhoneNumber> phoneNumbers;

			private List<string> successPhoneNumbers;

			private List<string> failPhoneNumbers;

			private List<string> successLoginNames;

			private List<string> failLoginNames;

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
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

			public string InstanceDescription
			{
				get
				{
					return instanceDescription;
				}
				set	
				{
					instanceDescription = value;
				}
			}

			public string DomainName
			{
				get
				{
					return domainName;
				}
				set	
				{
					domainName = value;
				}
			}

			public string ConsoleUrl
			{
				get
				{
					return consoleUrl;
				}
				set	
				{
					consoleUrl = value;
				}
			}

			public string StorageBucket
			{
				get
				{
					return storageBucket;
				}
				set	
				{
					storageBucket = value;
				}
			}

			public int? StorageMaxDays
			{
				get
				{
					return storageMaxDays;
				}
				set	
				{
					storageMaxDays = value;
				}
			}

			public int? StorageMaxSize
			{
				get
				{
					return storageMaxSize;
				}
				set	
				{
					storageMaxSize = value;
				}
			}

			public int? MaxOnlineAgents
			{
				get
				{
					return maxOnlineAgents;
				}
				set	
				{
					maxOnlineAgents = value;
				}
			}

			public string TenantId
			{
				get
				{
					return tenantId;
				}
				set	
				{
					tenantId = value;
				}
			}

			public string Status
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

			public string DirectoryId
			{
				get
				{
					return directoryId;
				}
				set	
				{
					directoryId = value;
				}
			}

			public long? CreatedTime
			{
				get
				{
					return createdTime;
				}
				set	
				{
					createdTime = value;
				}
			}

			public string Owner
			{
				get
				{
					return owner;
				}
				set	
				{
					owner = value;
				}
			}

			public List<CreateInstance_User> Admin
			{
				get
				{
					return admin;
				}
				set	
				{
					admin = value;
				}
			}

			public List<CreateInstance_PhoneNumber> PhoneNumbers
			{
				get
				{
					return phoneNumbers;
				}
				set	
				{
					phoneNumbers = value;
				}
			}

			public List<string> SuccessPhoneNumbers
			{
				get
				{
					return successPhoneNumbers;
				}
				set	
				{
					successPhoneNumbers = value;
				}
			}

			public List<string> FailPhoneNumbers
			{
				get
				{
					return failPhoneNumbers;
				}
				set	
				{
					failPhoneNumbers = value;
				}
			}

			public List<string> SuccessLoginNames
			{
				get
				{
					return successLoginNames;
				}
				set	
				{
					successLoginNames = value;
				}
			}

			public List<string> FailLoginNames
			{
				get
				{
					return failLoginNames;
				}
				set	
				{
					failLoginNames = value;
				}
			}

			public class CreateInstance_User
			{

				private string userId;

				private string ramId;

				private string instanceId;

				private CreateInstance_Detail detail;

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

				public string RamId
				{
					get
					{
						return ramId;
					}
					set	
					{
						ramId = value;
					}
				}

				public string InstanceId
				{
					get
					{
						return instanceId;
					}
					set	
					{
						instanceId = value;
					}
				}

				public CreateInstance_Detail Detail
				{
					get
					{
						return detail;
					}
					set	
					{
						detail = value;
					}
				}

				public class CreateInstance_Detail
				{

					private string loginName;

					private string displayName;

					private string phone;

					private string email;

					private string department;

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

					public string DisplayName
					{
						get
						{
							return displayName;
						}
						set	
						{
							displayName = value;
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

					public string Department
					{
						get
						{
							return department;
						}
						set	
						{
							department = value;
						}
					}
				}
			}

			public class CreateInstance_PhoneNumber
			{

				private string phoneNumberId;

				private string instanceId;

				private string number;

				private string phoneNumberDescription;

				private bool? testOnly;

				private int? remainingTime;

				private bool? allowOutbound;

				private string usage;

				private int? trunks;

				public string PhoneNumberId
				{
					get
					{
						return phoneNumberId;
					}
					set	
					{
						phoneNumberId = value;
					}
				}

				public string InstanceId
				{
					get
					{
						return instanceId;
					}
					set	
					{
						instanceId = value;
					}
				}

				public string Number
				{
					get
					{
						return number;
					}
					set	
					{
						number = value;
					}
				}

				public string PhoneNumberDescription
				{
					get
					{
						return phoneNumberDescription;
					}
					set	
					{
						phoneNumberDescription = value;
					}
				}

				public bool? TestOnly
				{
					get
					{
						return testOnly;
					}
					set	
					{
						testOnly = value;
					}
				}

				public int? RemainingTime
				{
					get
					{
						return remainingTime;
					}
					set	
					{
						remainingTime = value;
					}
				}

				public bool? AllowOutbound
				{
					get
					{
						return allowOutbound;
					}
					set	
					{
						allowOutbound = value;
					}
				}

				public string Usage
				{
					get
					{
						return usage;
					}
					set	
					{
						usage = value;
					}
				}

				public int? Trunks
				{
					get
					{
						return trunks;
					}
					set	
					{
						trunks = value;
					}
				}
			}
		}
	}
}
