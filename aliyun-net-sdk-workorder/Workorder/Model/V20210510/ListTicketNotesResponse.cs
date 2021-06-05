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

namespace Aliyun.Acs.Workorder.Model.V20210510
{
	public class ListTicketNotesResponse : AcsResponse
	{

		private int? code;

		private string requestId;

		private string message;

		private bool? success;

		private List<ListTicketNotes_DataItem> data;

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

		public List<ListTicketNotes_DataItem> Data
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

		public class ListTicketNotes_DataItem
		{

			private int? status;

			private long? createTime;

			private int? type;

			private long? dialogId;

			private string tip;

			private ListTicketNotes_DataInfo dataInfo;

			private ListTicketNotes_UserInfo userInfo;

			public int? Status
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

			public long? DialogId
			{
				get
				{
					return dialogId;
				}
				set	
				{
					dialogId = value;
				}
			}

			public string Tip
			{
				get
				{
					return tip;
				}
				set	
				{
					tip = value;
				}
			}

			public ListTicketNotes_DataInfo DataInfo
			{
				get
				{
					return dataInfo;
				}
				set	
				{
					dataInfo = value;
				}
			}

			public ListTicketNotes_UserInfo UserInfo
			{
				get
				{
					return userInfo;
				}
				set	
				{
					userInfo = value;
				}
			}

			public class ListTicketNotes_DataInfo
			{

				private string content;

				private string schema;

				public string Content
				{
					get
					{
						return content;
					}
					set	
					{
						content = value;
					}
				}

				public string Schema
				{
					get
					{
						return schema;
					}
					set	
					{
						schema = value;
					}
				}
			}

			public class ListTicketNotes_UserInfo
			{

				private string userName;

				private int? role;

				public string UserName
				{
					get
					{
						return userName;
					}
					set	
					{
						userName = value;
					}
				}

				public int? Role
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
			}
		}
	}
}
