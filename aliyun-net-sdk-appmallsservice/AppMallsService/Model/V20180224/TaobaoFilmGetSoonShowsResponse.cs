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
	public class TaobaoFilmGetSoonShowsResponse : AcsResponse
	{

		private string errorCode;

		private string msg;

		private string subCode;

		private string subMsg;

		private string logsId;

		private string requestId;

		private List<TaobaoFilmGetSoonShows_ShowsItem> shows;

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

		public List<TaobaoFilmGetSoonShows_ShowsItem> Shows
		{
			get
			{
				return shows;
			}
			set	
			{
				shows = value;
			}
		}

		public class TaobaoFilmGetSoonShows_ShowsItem
		{

			private string backgroundPicture;

			private string country;

			private string description;

			private string director;

			private long? duration;

			private string highlight;

			private long? id;

			private string language;

			private string leadingRole;

			private string openDay;

			private string openTime;

			private string poster;

			private string remark;

			private string showMark;

			private string showName;

			private string showNameEn;

			private string type;

			private List<string> showVersionList;

			private List<string> trailerList;

			public string BackgroundPicture
			{
				get
				{
					return backgroundPicture;
				}
				set	
				{
					backgroundPicture = value;
				}
			}

			public string Country
			{
				get
				{
					return country;
				}
				set	
				{
					country = value;
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

			public string Director
			{
				get
				{
					return director;
				}
				set	
				{
					director = value;
				}
			}

			public long? Duration
			{
				get
				{
					return duration;
				}
				set	
				{
					duration = value;
				}
			}

			public string Highlight
			{
				get
				{
					return highlight;
				}
				set	
				{
					highlight = value;
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

			public string Language
			{
				get
				{
					return language;
				}
				set	
				{
					language = value;
				}
			}

			public string LeadingRole
			{
				get
				{
					return leadingRole;
				}
				set	
				{
					leadingRole = value;
				}
			}

			public string OpenDay
			{
				get
				{
					return openDay;
				}
				set	
				{
					openDay = value;
				}
			}

			public string OpenTime
			{
				get
				{
					return openTime;
				}
				set	
				{
					openTime = value;
				}
			}

			public string Poster
			{
				get
				{
					return poster;
				}
				set	
				{
					poster = value;
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

			public string ShowMark
			{
				get
				{
					return showMark;
				}
				set	
				{
					showMark = value;
				}
			}

			public string ShowName
			{
				get
				{
					return showName;
				}
				set	
				{
					showName = value;
				}
			}

			public string ShowNameEn
			{
				get
				{
					return showNameEn;
				}
				set	
				{
					showNameEn = value;
				}
			}

			public string Type
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

			public List<string> ShowVersionList
			{
				get
				{
					return showVersionList;
				}
				set	
				{
					showVersionList = value;
				}
			}

			public List<string> TrailerList
			{
				get
				{
					return trailerList;
				}
				set	
				{
					trailerList = value;
				}
			}
		}
	}
}
