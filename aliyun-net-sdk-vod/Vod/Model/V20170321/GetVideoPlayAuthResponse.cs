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
	public class GetVideoPlayAuthResponse : AcsResponse
	{

		private string requestId;

		private string playAuth;

		private GetVideoPlayAuth_VideoMeta videoMeta;

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

		public string PlayAuth
		{
			get
			{
				return playAuth;
			}
			set	
			{
				playAuth = value;
			}
		}

		public GetVideoPlayAuth_VideoMeta VideoMeta
		{
			get
			{
				return videoMeta;
			}
			set	
			{
				videoMeta = value;
			}
		}

		public class GetVideoPlayAuth_VideoMeta
		{

			private string coverURL;

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