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
	public class ListPrivacyNumberCallDetailsResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private int? httpStatusCode;

		private ListPrivacyNumberCallDetails_PrivacyNumberCallDetails privacyNumberCallDetails;

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

		public ListPrivacyNumberCallDetails_PrivacyNumberCallDetails PrivacyNumberCallDetails
		{
			get
			{
				return privacyNumberCallDetails;
			}
			set	
			{
				privacyNumberCallDetails = value;
			}
		}

		public class ListPrivacyNumberCallDetails_PrivacyNumberCallDetails
		{

			private int? totalCount;

			private int? pageNumber;

			private int? pageSize;

			private List<ListPrivacyNumberCallDetails_PrivacyNumberCallDetail> list;

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

			public List<ListPrivacyNumberCallDetails_PrivacyNumberCallDetail> List
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

			public class ListPrivacyNumberCallDetails_PrivacyNumberCallDetail
			{

				private string agentId;

				private string agentName;

				private string contactId;

				private string callingNumber;

				private string calledNumber;

				private string privacyNumber;

				private string contactType;

				private string result;

				private string description;

				private long? callTime;

				private string status;

				public string AgentId
				{
					get
					{
						return agentId;
					}
					set	
					{
						agentId = value;
					}
				}

				public string AgentName
				{
					get
					{
						return agentName;
					}
					set	
					{
						agentName = value;
					}
				}

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

				public string CallingNumber
				{
					get
					{
						return callingNumber;
					}
					set	
					{
						callingNumber = value;
					}
				}

				public string CalledNumber
				{
					get
					{
						return calledNumber;
					}
					set	
					{
						calledNumber = value;
					}
				}

				public string PrivacyNumber
				{
					get
					{
						return privacyNumber;
					}
					set	
					{
						privacyNumber = value;
					}
				}

				public string ContactType
				{
					get
					{
						return contactType;
					}
					set	
					{
						contactType = value;
					}
				}

				public string Result
				{
					get
					{
						return result;
					}
					set	
					{
						result = value;
					}
				}

				public string Description
				{
					get
					{
						return description;
					}
					set	
					{
						description = value;
					}
				}

				public long? CallTime
				{
					get
					{
						return callTime;
					}
					set	
					{
						callTime = value;
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
			}
		}
	}
}
