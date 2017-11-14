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

namespace Aliyun.Acs.live.Model.V20161101
{
	public class DescribeLiveStreamHistoryUserNumResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeLiveStreamHistoryUserNum_LiveStreamUserNumInfo> liveStreamUserNumInfos;

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

		public List<DescribeLiveStreamHistoryUserNum_LiveStreamUserNumInfo> LiveStreamUserNumInfos
		{
			get
			{
				return liveStreamUserNumInfos;
			}
			set	
			{
				liveStreamUserNumInfos = value;
			}
		}

		public class DescribeLiveStreamHistoryUserNum_LiveStreamUserNumInfo
		{

			private string streamTime;

			private string userNum;

			public string StreamTime
			{
				get
				{
					return streamTime;
				}
				set	
				{
					streamTime = value;
				}
			}

			public string UserNum
			{
				get
				{
					return userNum;
				}
				set	
				{
					userNum = value;
				}
			}
		}
	}
}