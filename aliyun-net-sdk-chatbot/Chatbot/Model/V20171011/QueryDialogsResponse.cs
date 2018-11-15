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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Chatbot.Model.V20171011
{
	public class QueryDialogsResponse : AcsResponse
	{

		private string requestId;

		private int? pageSize;

		private int? pageNumber;

		private int? totalCount;

		private List<QueryDialogs_Dialog> dialogs;

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

		public List<QueryDialogs_Dialog> Dialogs
		{
			get
			{
				return dialogs;
			}
			set	
			{
				dialogs = value;
			}
		}

		public class QueryDialogs_Dialog
		{

			private long? dialogId;

			private string dialogName;

			private string description;

			private string createTime;

			private string modifyTime;

			private string createUserId;

			private string createUserName;

			private string modifyUserId;

			private string modifyUserName;

			private bool? isSampleDialog;

			private int? status;

			private bool? isOnline;

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

			public string DialogName
			{
				get
				{
					return dialogName;
				}
				set	
				{
					dialogName = value;
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

			public string CreateTime
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

			public string ModifyTime
			{
				get
				{
					return modifyTime;
				}
				set	
				{
					modifyTime = value;
				}
			}

			public string CreateUserId
			{
				get
				{
					return createUserId;
				}
				set	
				{
					createUserId = value;
				}
			}

			public string CreateUserName
			{
				get
				{
					return createUserName;
				}
				set	
				{
					createUserName = value;
				}
			}

			public string ModifyUserId
			{
				get
				{
					return modifyUserId;
				}
				set	
				{
					modifyUserId = value;
				}
			}

			public string ModifyUserName
			{
				get
				{
					return modifyUserName;
				}
				set	
				{
					modifyUserName = value;
				}
			}

			public bool? IsSampleDialog
			{
				get
				{
					return isSampleDialog;
				}
				set	
				{
					isSampleDialog = value;
				}
			}

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

			public bool? IsOnline
			{
				get
				{
					return isOnline;
				}
				set	
				{
					isOnline = value;
				}
			}
		}
	}
}