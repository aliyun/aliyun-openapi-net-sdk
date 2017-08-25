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

namespace Aliyun.Acs.Cdn.Model.V20141111
{
	public class DescribeLiveStreamsOnlineListResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeLiveStreamsOnlineList_LiveStreamOnlineInfo> onlineInfo;

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

		public List<DescribeLiveStreamsOnlineList_LiveStreamOnlineInfo> OnlineInfo
		{
			get
			{
				return onlineInfo;
			}
			set	
			{
				onlineInfo = value;
			}
		}

		public class DescribeLiveStreamsOnlineList_LiveStreamOnlineInfo
		{

			private string domainName;

			private string appName;

			private string streamName;

			private string publishTime;

			private string publishUrl;

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

			public string PublishTime
			{
				get
				{
					return publishTime;
				}
				set	
				{
					publishTime = value;
				}
			}

			public string PublishUrl
			{
				get
				{
					return publishUrl;
				}
				set	
				{
					publishUrl = value;
				}
			}
		}
	}
}