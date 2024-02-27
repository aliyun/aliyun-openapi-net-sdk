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

namespace Aliyun.Acs.avatar.Model.V20220130
{
	public class QueryAvatarListResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private bool? success;

		private QueryAvatarList_Data data;

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

		[JsonProperty(PropertyName = "Code")]
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
		public QueryAvatarList_Data Data
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

		public class QueryAvatarList_Data
		{

			private int? totalCount;

			private int? pageNo;

			private int? pageSize;

			private int? totalPage;

			private List<QueryAvatarList_ListItem> list;

			[JsonProperty(PropertyName = "TotalCount")]
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

			[JsonProperty(PropertyName = "PageNo")]
			public int? PageNo
			{
				get
				{
					return pageNo;
				}
				set	
				{
					pageNo = value;
				}
			}

			[JsonProperty(PropertyName = "PageSize")]
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

			[JsonProperty(PropertyName = "TotalPage")]
			public int? TotalPage
			{
				get
				{
					return totalPage;
				}
				set	
				{
					totalPage = value;
				}
			}

			[JsonProperty(PropertyName = "List")]
			public List<QueryAvatarList_ListItem> List
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

			public class QueryAvatarList_ListItem
			{

				private string code;

				private string name;

				private string image;

				private string portrait;

				private string description;

				private string avatarType;

				private string modelType;

				private string makeStatus;

				private string makeFailReason;

				private string makeStage;

				private string preview;

				private QueryAvatarList_SupportedResolutions supportedResolutions;

				[JsonProperty(PropertyName = "Code")]
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

				[JsonProperty(PropertyName = "Name")]
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

				[JsonProperty(PropertyName = "Image")]
				public string Image
				{
					get
					{
						return image;
					}
					set	
					{
						image = value;
					}
				}

				[JsonProperty(PropertyName = "Portrait")]
				public string Portrait
				{
					get
					{
						return portrait;
					}
					set	
					{
						portrait = value;
					}
				}

				[JsonProperty(PropertyName = "Description")]
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

				[JsonProperty(PropertyName = "AvatarType")]
				public string AvatarType
				{
					get
					{
						return avatarType;
					}
					set	
					{
						avatarType = value;
					}
				}

				[JsonProperty(PropertyName = "ModelType")]
				public string ModelType
				{
					get
					{
						return modelType;
					}
					set	
					{
						modelType = value;
					}
				}

				[JsonProperty(PropertyName = "MakeStatus")]
				public string MakeStatus
				{
					get
					{
						return makeStatus;
					}
					set	
					{
						makeStatus = value;
					}
				}

				[JsonProperty(PropertyName = "MakeFailReason")]
				public string MakeFailReason
				{
					get
					{
						return makeFailReason;
					}
					set	
					{
						makeFailReason = value;
					}
				}

				[JsonProperty(PropertyName = "MakeStage")]
				public string MakeStage
				{
					get
					{
						return makeStage;
					}
					set	
					{
						makeStage = value;
					}
				}

				[JsonProperty(PropertyName = "Preview")]
				public string Preview
				{
					get
					{
						return preview;
					}
					set	
					{
						preview = value;
					}
				}

				[JsonProperty(PropertyName = "SupportedResolutions")]
				public QueryAvatarList_SupportedResolutions SupportedResolutions
				{
					get
					{
						return supportedResolutions;
					}
					set	
					{
						supportedResolutions = value;
					}
				}

				public class QueryAvatarList_SupportedResolutions
				{

					private List<QueryAvatarList_OfflineItem> offline;

					private List<QueryAvatarList_OnlineItem> online;

					[JsonProperty(PropertyName = "Offline")]
					public List<QueryAvatarList_OfflineItem> Offline
					{
						get
						{
							return offline;
						}
						set	
						{
							offline = value;
						}
					}

					[JsonProperty(PropertyName = "Online")]
					public List<QueryAvatarList_OnlineItem> Online
					{
						get
						{
							return online;
						}
						set	
						{
							online = value;
						}
					}

					public class QueryAvatarList_OfflineItem
					{

						private int? width;

						private int? height;

						private string desc;

						[JsonProperty(PropertyName = "Width")]
						public int? Width
						{
							get
							{
								return width;
							}
							set	
							{
								width = value;
							}
						}

						[JsonProperty(PropertyName = "Height")]
						public int? Height
						{
							get
							{
								return height;
							}
							set	
							{
								height = value;
							}
						}

						[JsonProperty(PropertyName = "Desc")]
						public string Desc
						{
							get
							{
								return desc;
							}
							set	
							{
								desc = value;
							}
						}
					}

					public class QueryAvatarList_OnlineItem
					{

						private int? width;

						private int? height;

						private string desc;

						[JsonProperty(PropertyName = "Width")]
						public int? Width
						{
							get
							{
								return width;
							}
							set	
							{
								width = value;
							}
						}

						[JsonProperty(PropertyName = "Height")]
						public int? Height
						{
							get
							{
								return height;
							}
							set	
							{
								height = value;
							}
						}

						[JsonProperty(PropertyName = "Desc")]
						public string Desc
						{
							get
							{
								return desc;
							}
							set	
							{
								desc = value;
							}
						}
					}
				}
			}
		}
	}
}
