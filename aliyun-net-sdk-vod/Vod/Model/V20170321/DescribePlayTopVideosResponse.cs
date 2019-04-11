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

namespace Aliyun.Acs.vod.Model.V20170321
{
	public class DescribePlayTopVideosResponse : AcsResponse
	{

		private string requestId;

		private long? pageNo;

		private long? pageSize;

		private long? totalNum;

		private List<DescribePlayTopVideos_TopPlayVideoStatis> topPlayVideos;

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

		public long? PageNo
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

		public long? PageSize
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

		public long? TotalNum
		{
			get
			{
				return totalNum;
			}
			set	
			{
				totalNum = value;
			}
		}

		public List<DescribePlayTopVideos_TopPlayVideoStatis> TopPlayVideos
		{
			get
			{
				return topPlayVideos;
			}
			set	
			{
				topPlayVideos = value;
			}
		}

		public class DescribePlayTopVideos_TopPlayVideoStatis
		{

			private string playDuration;

			private string vV;

			private string uV;

			private string videoId;

			private string title;

			public string PlayDuration
			{
				get
				{
					return playDuration;
				}
				set	
				{
					playDuration = value;
				}
			}

			public string VV
			{
				get
				{
					return vV;
				}
				set	
				{
					vV = value;
				}
			}

			public string UV
			{
				get
				{
					return uV;
				}
				set	
				{
					uV = value;
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
		}
	}
}
