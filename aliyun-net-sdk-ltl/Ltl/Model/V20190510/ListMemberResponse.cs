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

namespace Aliyun.Acs.ltl.Model.V20190510
{
	public class ListMemberResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private bool? success;

		private ListMember_Data data;

		[JsonProperty(PropertyName = "Code")]
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

		[JsonProperty(PropertyName = "Message")]
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

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "Success")]
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

		[JsonProperty(PropertyName = "Data")]
		public ListMember_Data Data
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

		public class ListMember_Data
		{

			private int? num;

			private int? total;

			private int? size;

			private List<ListMember_MemberInfo> pageData;

			[JsonProperty(PropertyName = "Num")]
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

			[JsonProperty(PropertyName = "Total")]
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

			[JsonProperty(PropertyName = "Size")]
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

			[JsonProperty(PropertyName = "PageData")]
			public List<ListMember_MemberInfo> PageData
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

			public class ListMember_MemberInfo
			{

				private string status;

				private string memberName;

				private string remark;

				private string memberUid;

				private string memberPhone;

				private string memberId;

				private string memberContact;

				[JsonProperty(PropertyName = "Status")]
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

				[JsonProperty(PropertyName = "MemberName")]
				public string MemberName
				{
					get
					{
						return memberName;
					}
					set	
					{
						memberName = value;
					}
				}

				[JsonProperty(PropertyName = "Remark")]
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

				[JsonProperty(PropertyName = "MemberUid")]
				public string MemberUid
				{
					get
					{
						return memberUid;
					}
					set	
					{
						memberUid = value;
					}
				}

				[JsonProperty(PropertyName = "MemberPhone")]
				public string MemberPhone
				{
					get
					{
						return memberPhone;
					}
					set	
					{
						memberPhone = value;
					}
				}

				[JsonProperty(PropertyName = "MemberId")]
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

				[JsonProperty(PropertyName = "MemberContact")]
				public string MemberContact
				{
					get
					{
						return memberContact;
					}
					set	
					{
						memberContact = value;
					}
				}
			}
		}
	}
}
