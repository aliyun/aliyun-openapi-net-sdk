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
	public class GetMetaTableThemeLevelResponse : AcsResponse
	{

		private string requestId;

		private string errorCode;

		private string errorMessage;

		private int? httpStatusCode;

		private bool? success;

		private GetMetaTableThemeLevel_Entity entity;

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

		public GetMetaTableThemeLevel_Entity Entity
		{
			get
			{
				return entity;
			}
			set	
			{
				entity = value;
			}
		}

		public class GetMetaTableThemeLevel_Entity
		{

			private List<GetMetaTableThemeLevel_ThemeItem> theme;

			private List<GetMetaTableThemeLevel_LevelItem> level;

			public List<GetMetaTableThemeLevel_ThemeItem> Theme
			{
				get
				{
					return theme;
				}
				set	
				{
					theme = value;
				}
			}

			public List<GetMetaTableThemeLevel_LevelItem> Level
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

			public class GetMetaTableThemeLevel_ThemeItem
			{

				private long? themeId;

				private string name;

				private int? level;

				private long? parentId;

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
			}

			public class GetMetaTableThemeLevel_LevelItem
			{

				private long? levelId;

				private string name;

				private int? type;

				private string description;

				public long? LevelId
				{
					get
					{
						return levelId;
					}
					set	
					{
						levelId = value;
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
			}
		}
	}
}
