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

namespace Aliyun.Acs.live.Model.V20161101
{
	public class StartPlaylistResponse : AcsResponse
	{

		private string requestId;

		private string programId;

		private StartPlaylist_StreamInfo streamInfo;

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

		public string ProgramId
		{
			get
			{
				return programId;
			}
			set	
			{
				programId = value;
			}
		}

		public StartPlaylist_StreamInfo StreamInfo
		{
			get
			{
				return streamInfo;
			}
			set	
			{
				streamInfo = value;
			}
		}

		public class StartPlaylist_StreamInfo
		{

			private string domainName;

			private string appName;

			private string streamName;

			private List<StartPlaylist_Stream> streams;

			public string DomainName
			{
				get
				{
					return domainName;
				}
				set	
				{
					domainName = value;
				}
			}

			public string AppName
			{
				get
				{
					return appName;
				}
				set	
				{
					appName = value;
				}
			}

			public string StreamName
			{
				get
				{
					return streamName;
				}
				set	
				{
					streamName = value;
				}
			}

			public List<StartPlaylist_Stream> Streams
			{
				get
				{
					return streams;
				}
				set	
				{
					streams = value;
				}
			}

			public class StartPlaylist_Stream
			{

				private string pullFlvUrl;

				private string pullRtmpUrl;

				private string pullM3U8Url;

				private string quality;

				public string PullFlvUrl
				{
					get
					{
						return pullFlvUrl;
					}
					set	
					{
						pullFlvUrl = value;
					}
				}

				public string PullRtmpUrl
				{
					get
					{
						return pullRtmpUrl;
					}
					set	
					{
						pullRtmpUrl = value;
					}
				}

				public string PullM3U8Url
				{
					get
					{
						return pullM3U8Url;
					}
					set	
					{
						pullM3U8Url = value;
					}
				}

				public string Quality
				{
					get
					{
						return quality;
					}
					set	
					{
						quality = value;
					}
				}
			}
		}
	}
}
