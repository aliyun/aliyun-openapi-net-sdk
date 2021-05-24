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

namespace Aliyun.Acs.CCC.Model.V20200701
{
	public class ListPhoneNumbersOfSkillGroupResponse : AcsResponse
	{

		private string code;

		private int? httpStatusCode;

		private string message;

		private string requestId;

		private ListPhoneNumbersOfSkillGroup_Data data;

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

		public ListPhoneNumbersOfSkillGroup_Data Data
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

		public class ListPhoneNumbersOfSkillGroup_Data
		{

			private int? pageNumber;

			private int? pageSize;

			private int? totalCount;

			private List<ListPhoneNumbersOfSkillGroup_PhoneNumber> list;

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

			public List<ListPhoneNumbersOfSkillGroup_PhoneNumber> List
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

			public class ListPhoneNumbersOfSkillGroup_PhoneNumber
			{

				private bool? active;

				private string city;

				private string contactFlowId;

				private string instanceId;

				private string number;

				private string province;

				private string usage;

				public bool? Active
				{
					get
					{
						return active;
					}
					set	
					{
						active = value;
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
			}
		}
	}
}
