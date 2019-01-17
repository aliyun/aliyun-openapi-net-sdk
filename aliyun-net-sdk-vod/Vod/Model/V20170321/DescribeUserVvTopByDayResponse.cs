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
	public class DescribeUserVvTopByDayResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeUserVvTopByDay_UserPlayStatisticsInfo> userPlayStatisticsInfos;

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

		public List<DescribeUserVvTopByDay_UserPlayStatisticsInfo> UserPlayStatisticsInfos
		{
			get
			{
				return userPlayStatisticsInfos;
			}
			set	
			{
				userPlayStatisticsInfos = value;
			}
		}

		public class DescribeUserVvTopByDay_UserPlayStatisticsInfo
		{

			private string count;

			private string videoid;

			private string videoName;

			public string Count
			{
				get
				{
					return count;
				}
				set	
				{
					count = value;
				}
			}

			public string Videoid
			{
				get
				{
					return videoid;
				}
				set	
				{
					videoid = value;
				}
			}

			public string VideoName
			{
				get
				{
					return videoName;
				}
				set	
				{
					videoName = value;
				}
			}
		}
	}
}