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

namespace Aliyun.Acs.vod.Model.V20170321
{
	public class GetVideoPlayInfoResponse : AcsResponse
	{

		private string requestId;

		private GetVideoPlayInfo_PlayInfo playInfo;

		private GetVideoPlayInfo_VideoInfo videoInfo;

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

		public GetVideoPlayInfo_PlayInfo PlayInfo
		{
			get
			{
				return playInfo;
			}
			set	
			{
				playInfo = value;
			}
		}

		public GetVideoPlayInfo_VideoInfo VideoInfo
		{
			get
			{
				return videoInfo;
			}
			set	
			{
				videoInfo = value;
			}
		}

		public class GetVideoPlayInfo_PlayInfo
		{

			private string accessKeyId;

			private string accessKeySecret;

			private string authInfo;

			private string securityToken;

			private string region;

			private string playDomain;

			public string AccessKeyId
			{
				get
				{
					return accessKeyId;
				}
				set	
				{
					accessKeyId = value;
				}
			}

			public string AccessKeySecret
			{
				get
				{
					return accessKeySecret;
				}
				set	
				{
					accessKeySecret = value;
				}
			}

			public string AuthInfo
			{
				get
				{
					return authInfo;
				}
				set	
				{
					authInfo = value;
				}
			}

			public string SecurityToken
			{
				get
				{
					return securityToken;
				}
				set	
				{
					securityToken = value;
				}
			}

			public string Region
			{
				get
				{
					return region;
				}
				set	
				{
					region = value;
				}
			}

			public string PlayDomain
			{
				get
				{
					return playDomain;
				}
				set	
				{
					playDomain = value;
				}
			}
		}

		public class GetVideoPlayInfo_VideoInfo
		{

			private string coverURL;

			private long? customerId;

			private float? duration;

			private string status;

			private string title;

			private string videoId;

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

			public long? CustomerId
			{
				get
				{
					return customerId;
				}
				set	
				{
					customerId = value;
				}
			}

			public float? Duration
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

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
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

			public string VideoId
			{
				get
				{
					return videoId;
				}
				set	
				{
					videoId = value;
				}
			}
		}
	}
}