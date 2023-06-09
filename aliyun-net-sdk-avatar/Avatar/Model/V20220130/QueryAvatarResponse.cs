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
	public class QueryAvatarResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private bool? success;

		private QueryAvatar_Data data;

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
		public QueryAvatar_Data Data
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

		public class QueryAvatar_Data
		{

			private string name;

			private string description;

			private string portrait;

			private string image;

			private string modelType;

			private string avatarType;

			private QueryAvatar_SupportedResolutions supportedResolutions;

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

			[JsonProperty(PropertyName = "SupportedResolutions")]
			public QueryAvatar_SupportedResolutions SupportedResolutions
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

			public class QueryAvatar_SupportedResolutions
			{

				private List<QueryAvatar_OfflineItem> offline;

				private List<QueryAvatar_OnlineItem> online;

				[JsonProperty(PropertyName = "Offline")]
				public List<QueryAvatar_OfflineItem> Offline
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
				public List<QueryAvatar_OnlineItem> Online
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

				public class QueryAvatar_OfflineItem
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

				public class QueryAvatar_OnlineItem
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
