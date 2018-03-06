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

namespace Aliyun.Acs.CloudPhoto.Model.V20170711
{
	public class ListEventsResponse : AcsResponse
	{

		private string code;

		private string message;

		private string nextCursor;

		private int? totalCount;

		private string requestId;

		private string action;

		private List<ListEvents__Event> events;

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

		public string NextCursor
		{
			get
			{
				return nextCursor;
			}
			set	
			{
				nextCursor = value;
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

		public string Action
		{
			get
			{
				return action;
			}
			set	
			{
				action = value;
			}
		}

		public List<ListEvents__Event> Events
		{
			get
			{
				return events;
			}
			set	
			{
				events = value;
			}
		}

		public class ListEvents__Event
		{

			private long? id;

			private string idStr;

			private string title;

			private string bannerPhotoId;

			private string identity;

			private string splashPhotoId;

			private string state;

			private string weixinTitle;

			private string watermarkPhotoId;

			private long? startAt;

			private long? endAt;

			private long? ctime;

			private long? mtime;

			private long? viewsCount;

			private string libraryId;

			private string idStr1;

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

			public string IdStr
			{
				get
				{
					return idStr;
				}
				set	
				{
					idStr = value;
				}
			}

			public string Title
			{
				get
				{
					return title;
				}
				set	
				{
					title = value;
				}
			}

			public string BannerPhotoId
			{
				get
				{
					return bannerPhotoId;
				}
				set	
				{
					bannerPhotoId = value;
				}
			}

			public string Identity
			{
				get
				{
					return identity;
				}
				set	
				{
					identity = value;
				}
			}

			public string SplashPhotoId
			{
				get
				{
					return splashPhotoId;
				}
				set	
				{
					splashPhotoId = value;
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

			public string WeixinTitle
			{
				get
				{
					return weixinTitle;
				}
				set	
				{
					weixinTitle = value;
				}
			}

			public string WatermarkPhotoId
			{
				get
				{
					return watermarkPhotoId;
				}
				set	
				{
					watermarkPhotoId = value;
				}
			}

			public long? StartAt
			{
				get
				{
					return startAt;
				}
				set	
				{
					startAt = value;
				}
			}

			public long? EndAt
			{
				get
				{
					return endAt;
				}
				set	
				{
					endAt = value;
				}
			}

			public long? Ctime
			{
				get
				{
					return ctime;
				}
				set	
				{
					ctime = value;
				}
			}

			public long? Mtime
			{
				get
				{
					return mtime;
				}
				set	
				{
					mtime = value;
				}
			}

			public long? ViewsCount
			{
				get
				{
					return viewsCount;
				}
				set	
				{
					viewsCount = value;
				}
			}

			public string LibraryId
			{
				get
				{
					return libraryId;
				}
				set	
				{
					libraryId = value;
				}
			}

			public string IdStr1
			{
				get
				{
					return idStr1;
				}
				set	
				{
					idStr1 = value;
				}
			}
		}
	}
}