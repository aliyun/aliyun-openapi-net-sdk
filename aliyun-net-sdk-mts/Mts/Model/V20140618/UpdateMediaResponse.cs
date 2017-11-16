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

namespace Aliyun.Acs.Mts.Model.V20140618
{
	public class UpdateMediaResponse : AcsResponse
	{

		private string requestId;

		private UpdateMedia_Media media;

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

		public UpdateMedia_Media Media
		{
			get
			{
				return media;
			}
			set	
			{
				media = value;
			}
		}

		public class UpdateMedia_Media
		{

			private string mediaId;

			private string title;

			private string description;

			private string coverURL;

			private long? cateId;

			private string duration;

			private string format;

			private string size;

			private string bitrate;

			private string width;

			private string height;

			private string fps;

			private string publishState;

			private string creationTime;

			private List<string> tags;

			private List<string> runIdList;

			private UpdateMedia_File file;

			public string MediaId
			{
				get
				{
					return mediaId;
				}
				set	
				{
					mediaId = value;
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

			public string CoverURL
			{
				get
				{
					return coverURL;
				}
				set	
				{
					coverURL = value;
				}
			}

			public long? CateId
			{
				get
				{
					return cateId;
				}
				set	
				{
					cateId = value;
				}
			}

			public string Duration
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

			public string Format
			{
				get
				{
					return format;
				}
				set	
				{
					format = value;
				}
			}

			public string Size
			{
				get
				{
					return size;
				}
				set	
				{
					size = value;
				}
			}

			public string Bitrate
			{
				get
				{
					return bitrate;
				}
				set	
				{
					bitrate = value;
				}
			}

			public string Width
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

			public string Height
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

			public string Fps
			{
				get
				{
					return fps;
				}
				set	
				{
					fps = value;
				}
			}

			public string PublishState
			{
				get
				{
					return publishState;
				}
				set	
				{
					publishState = value;
				}
			}

			public string CreationTime
			{
				get
				{
					return creationTime;
				}
				set	
				{
					creationTime = value;
				}
			}

			public List<string> Tags
			{
				get
				{
					return tags;
				}
				set	
				{
					tags = value;
				}
			}

			public List<string> RunIdList
			{
				get
				{
					return runIdList;
				}
				set	
				{
					runIdList = value;
				}
			}

			public UpdateMedia_File File
			{
				get
				{
					return file;
				}
				set	
				{
					file = value;
				}
			}

			public class UpdateMedia_File
			{

				private string uRL;

				private string state;

				public string URL
				{
					get
					{
						return uRL;
					}
					set	
					{
						uRL = value;
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
			}
		}
	}
}