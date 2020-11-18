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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.rtc.Transform;
using Aliyun.Acs.rtc.Transform.V20180111;

namespace Aliyun.Acs.rtc.Model.V20180111
{
    public class StartRecordTaskRequest : RpcAcsRequest<StartRecordTaskResponse>
    {
        public StartRecordTaskRequest()
            : base("rtc", "2018-01-11", "StartRecordTask", "rtc", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.rtc.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.rtc.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private List<UserPanes> userPaness = new List<UserPanes>(){ };

		private string taskId;

		private long? ownerId;

		private string templateId;

		private List<string> subSpecUserss = new List<string>(){ };

		private string appId;

		private string channelId;

		public List<UserPanes> UserPaness
		{
			get
			{
				return userPaness;
			}

			set
			{
				userPaness = value;
				for (int i = 0; i < userPaness.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"UserPanes." + (i + 1) + ".PaneId", userPaness[i].PaneId);
					DictionaryUtil.Add(QueryParameters,"UserPanes." + (i + 1) + ".UserId", userPaness[i].UserId);
					DictionaryUtil.Add(QueryParameters,"UserPanes." + (i + 1) + ".SourceType", userPaness[i].SourceType);
					for (int j = 0; j < userPaness[i].Imagess.Count; j++)
					{
						DictionaryUtil.Add(QueryParameters,"UserPanes." + (i + 1) + ".Images." +(j + 1), userPaness[i].Imagess[j]);
					}
					for (int j = 0; j < userPaness[i].Textss.Count; j++)
					{
						DictionaryUtil.Add(QueryParameters,"UserPanes." + (i + 1) + ".Texts." +(j + 1), userPaness[i].Textss[j]);
					}
				}
			}
		}

		public string TaskId
		{
			get
			{
				return taskId;
			}
			set	
			{
				taskId = value;
				DictionaryUtil.Add(QueryParameters, "TaskId", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string TemplateId
		{
			get
			{
				return templateId;
			}
			set	
			{
				templateId = value;
				DictionaryUtil.Add(QueryParameters, "TemplateId", value);
			}
		}

		public List<string> SubSpecUserss
		{
			get
			{
				return subSpecUserss;
			}

			set
			{
				subSpecUserss = value;
				for (int i = 0; i < subSpecUserss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"SubSpecUsers." + (i + 1) , subSpecUserss[i]);
				}
			}
		}

		public string AppId
		{
			get
			{
				return appId;
			}
			set	
			{
				appId = value;
				DictionaryUtil.Add(QueryParameters, "AppId", value);
			}
		}

		public string ChannelId
		{
			get
			{
				return channelId;
			}
			set	
			{
				channelId = value;
				DictionaryUtil.Add(QueryParameters, "ChannelId", value);
			}
		}

		public class UserPanes
		{

			private int? paneId;

			private string userId;

			private string sourceType;

			private List<Images> imagess = new List<Images>(){ };

			private List<Texts> textss = new List<Texts>(){ };

			public int? PaneId
			{
				get
				{
					return paneId;
				}
				set	
				{
					paneId = value;
				}
			}

			public string UserId
			{
				get
				{
					return userId;
				}
				set	
				{
					userId = value;
				}
			}

			public string SourceType
			{
				get
				{
					return sourceType;
				}
				set	
				{
					sourceType = value;
				}
			}

			public List<Images> Imagess
			{
				get
				{
					return imagess;
				}
				set	
				{
					imagess = value;
				}
			}

			public List<Texts> Textss
			{
				get
				{
					return textss;
				}
				set	
				{
					textss = value;
				}
			}

			public class Images
			{

				private string url;

				private int? display;

				private float? x;

				private float? y;

				private float? width;

				private float? height;

				private int? zOrder;

				public string Url
				{
					get
					{
						return url;
					}
					set	
					{
						url = value;
					}
				}

				public int? Display
				{
					get
					{
						return display;
					}
					set	
					{
						display = value;
					}
				}

				public float? X
				{
					get
					{
						return x;
					}
					set	
					{
						x = value;
					}
				}

				public float? Y
				{
					get
					{
						return y;
					}
					set	
					{
						y = value;
					}
				}

				public float? Width
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

				public float? Height
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

				public int? ZOrder
				{
					get
					{
						return zOrder;
					}
					set	
					{
						zOrder = value;
					}
				}
			}

			public class Texts
			{

				private string text;

				private float? x;

				private float? y;

				private int? fontType;

				private int? fontSize;

				private int? fontColor;

				private int? zOrder;

				public string Text
				{
					get
					{
						return text;
					}
					set	
					{
						text = value;
					}
				}

				public float? X
				{
					get
					{
						return x;
					}
					set	
					{
						x = value;
					}
				}

				public float? Y
				{
					get
					{
						return y;
					}
					set	
					{
						y = value;
					}
				}

				public int? FontType
				{
					get
					{
						return fontType;
					}
					set	
					{
						fontType = value;
					}
				}

				public int? FontSize
				{
					get
					{
						return fontSize;
					}
					set	
					{
						fontSize = value;
					}
				}

				public int? FontColor
				{
					get
					{
						return fontColor;
					}
					set	
					{
						fontColor = value;
					}
				}

				public int? ZOrder
				{
					get
					{
						return zOrder;
					}
					set	
					{
						zOrder = value;
					}
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override StartRecordTaskResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return StartRecordTaskResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
