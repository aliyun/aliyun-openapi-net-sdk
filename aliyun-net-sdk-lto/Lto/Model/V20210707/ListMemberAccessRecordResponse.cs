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

namespace Aliyun.Acs.lto.Model.V20210707
{
	public class ListMemberAccessRecordResponse : AcsResponse
	{

		private string code;

		private int? httpStatusCode;

		private string message;

		private string requestId;

		private bool? success;

		private ListMemberAccessRecord_Data data;

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

		public ListMemberAccessRecord_Data Data
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

		public class ListMemberAccessRecord_Data
		{

			private int? num;

			private int? total;

			private int? size;

			private List<ListMemberAccessRecord_MemberInfo> pageData;

			public int? Num
			{
				get
				{
					return num;
				}
				set	
				{
					num = value;
				}
			}

			public int? Total
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

			public int? Size
			{
				get
				{
					return size;
				}
				set	
				{
					size = value;
				}
			}

			public List<ListMemberAccessRecord_MemberInfo> PageData
			{
				get
				{
					return pageData;
				}
				set	
				{
					pageData = value;
				}
			}

			public class ListMemberAccessRecord_MemberInfo
			{

				private string status;

				private long? authorizedCount;

				private string remark;

				private string adminName;

				private string memberId;

				private string name;

				private string contactor;

				private string telephony;

				private string uid;

				private string accessStatus;

				private long? accessDate;

				private long? memberResponseDate;

				private int? authorizedDeviceCount;

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

				public long? AuthorizedCount
				{
					get
					{
						return authorizedCount;
					}
					set	
					{
						authorizedCount = value;
					}
				}

				public string Remark
				{
					get
					{
						return remark;
					}
					set	
					{
						remark = value;
					}
				}

				public string AdminName
				{
					get
					{
						return adminName;
					}
					set	
					{
						adminName = value;
					}
				}

				public string MemberId
				{
					get
					{
						return memberId;
					}
					set	
					{
						memberId = value;
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

				public string Contactor
				{
					get
					{
						return contactor;
					}
					set	
					{
						contactor = value;
					}
				}

				public string Telephony
				{
					get
					{
						return telephony;
					}
					set	
					{
						telephony = value;
					}
				}

				public string Uid
				{
					get
					{
						return uid;
					}
					set	
					{
						uid = value;
					}
				}

				public string AccessStatus
				{
					get
					{
						return accessStatus;
					}
					set	
					{
						accessStatus = value;
					}
				}

				public long? AccessDate
				{
					get
					{
						return accessDate;
					}
					set	
					{
						accessDate = value;
					}
				}

				public long? MemberResponseDate
				{
					get
					{
						return memberResponseDate;
					}
					set	
					{
						memberResponseDate = value;
					}
				}

				public int? AuthorizedDeviceCount
				{
					get
					{
						return authorizedDeviceCount;
					}
					set	
					{
						authorizedDeviceCount = value;
					}
				}
			}
		}
	}
}
