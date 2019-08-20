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

namespace Aliyun.Acs.AppMallsService.Model.V20180224
{
	public class TaobaoFilmGetShowCommentsResponse : AcsResponse
	{

		private string errorCode;

		private string msg;

		private string subCode;

		private string subMsg;

		private long? count;

		private string logsId;

		private string requestId;

		private List<TaobaoFilmGetShowComments_CommentListItem> commentList;

		public string ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
			}
		}

		public string Msg
		{
			get
			{
				return msg;
			}
			set	
			{
				msg = value;
			}
		}

		public string SubCode
		{
			get
			{
				return subCode;
			}
			set	
			{
				subCode = value;
			}
		}

		public string SubMsg
		{
			get
			{
				return subMsg;
			}
			set	
			{
				subMsg = value;
			}
		}

		public long? Count
		{
			get
			{
				return count;
			}
			set	
			{
				count = value;
			}
		}

		public string LogsId
		{
			get
			{
				return logsId;
			}
			set	
			{
				logsId = value;
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

		public List<TaobaoFilmGetShowComments_CommentListItem> CommentList
		{
			get
			{
				return commentList;
			}
			set	
			{
				commentList = value;
			}
		}

		public class TaobaoFilmGetShowComments_CommentListItem
		{

			private string commentTime;

			private string content;

			private long? favorCount;

			private long? id;

			private string nickName;

			private long? remark;

			private long? showId;

			private string subject;

			public string CommentTime
			{
				get
				{
					return commentTime;
				}
				set	
				{
					commentTime = value;
				}
			}

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

			public long? FavorCount
			{
				get
				{
					return favorCount;
				}
				set	
				{
					favorCount = value;
				}
			}

			public long? Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

			public string NickName
			{
				get
				{
					return nickName;
				}
				set	
				{
					nickName = value;
				}
			}

			public long? Remark
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

			public long? ShowId
			{
				get
				{
					return showId;
				}
				set	
				{
					showId = value;
				}
			}

			public string Subject
			{
				get
				{
					return subject;
				}
				set	
				{
					subject = value;
				}
			}
		}
	}
}
