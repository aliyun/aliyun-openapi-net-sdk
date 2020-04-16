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
	public class ListPhoneTagsResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private int? httpStatusCode;

		private ListPhoneTags_PhoneNumbers phoneNumbers;

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

		public ListPhoneTags_PhoneNumbers PhoneNumbers
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

		public class ListPhoneTags_PhoneNumbers
		{

			private int? totalCount;

			private int? pageNumber;

			private int? pageSize;

			private List<ListPhoneTags_PhoneNumber> list;

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

			public List<ListPhoneTags_PhoneNumber> List
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

			public class ListPhoneTags_PhoneNumber
			{

				private string phoneNumberId;

				private string instanceId;

				private string number;

				private string phoneNumberDescription;

				private string usage;

				private string province;

				private string city;

				private int? type;

				private int? concurrency;

				private string serviceTag;

				private string provider;

				private long? createTime;

				private string contactFlowId;

				private List<string> skillGroupIdList;

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

				public int? Type
				{
					get
					{
						return type;
					}
					set	
					{
						type = value;
					}
				}

				public int? Concurrency
				{
					get
					{
						return concurrency;
					}
					set	
					{
						concurrency = value;
					}
				}

				public string ServiceTag
				{
					get
					{
						return serviceTag;
					}
					set	
					{
						serviceTag = value;
					}
				}

				public string Provider
				{
					get
					{
						return provider;
					}
					set	
					{
						provider = value;
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

				public string ContactFlowId
				{
					get
					{
						return contactFlowId;
					}
					set	
					{
						contactFlowId = value;
					}
				}

				public List<string> SkillGroupIdList
				{
					get
					{
						return skillGroupIdList;
					}
					set	
					{
						skillGroupIdList = value;
					}
				}
			}
		}
	}
}
