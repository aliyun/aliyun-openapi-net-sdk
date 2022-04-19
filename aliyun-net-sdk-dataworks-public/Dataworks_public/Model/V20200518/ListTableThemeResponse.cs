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

namespace Aliyun.Acs.dataworks_public.Model.V20200518
{
	public class ListTableThemeResponse : AcsResponse
	{

		private int? httpStatusCode;

		private string errorMessage;

		private string requestId;

		private bool? success;

		private string errorCode;

		private ListTableTheme_Data data;

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

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
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

		public ListTableTheme_Data Data
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

		public class ListTableTheme_Data
		{

			private long? totalCount;

			private List<ListTableTheme_ThemeListItem> themeList;

			public long? TotalCount
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

			public List<ListTableTheme_ThemeListItem> ThemeList
			{
				get
				{
					return themeList;
				}
				set	
				{
					themeList = value;
				}
			}

			public class ListTableTheme_ThemeListItem
			{

				private long? createTimeStamp;

				private long? parentId;

				private long? themeId;

				private long? projectId;

				private string name;

				private int? level;

				private string creator;

				public long? CreateTimeStamp
				{
					get
					{
						return createTimeStamp;
					}
					set	
					{
						createTimeStamp = value;
					}
				}

				public long? ParentId
				{
					get
					{
						return parentId;
					}
					set	
					{
						parentId = value;
					}
				}

				public long? ThemeId
				{
					get
					{
						return themeId;
					}
					set	
					{
						themeId = value;
					}
				}

				public long? ProjectId
				{
					get
					{
						return projectId;
					}
					set	
					{
						projectId = value;
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

				public int? Level
				{
					get
					{
						return level;
					}
					set	
					{
						level = value;
					}
				}

				public string Creator
				{
					get
					{
						return creator;
					}
					set	
					{
						creator = value;
					}
				}
			}
		}
	}
}
