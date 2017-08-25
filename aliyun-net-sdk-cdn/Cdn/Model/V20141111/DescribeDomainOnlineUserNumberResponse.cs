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
	public class DescribeDomainOnlineUserNumberResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeDomainOnlineUserNumber_LiveStreamOnlineUserNumInfo> liveStreamOnlineUserNumInfos;

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

		public List<DescribeDomainOnlineUserNumber_LiveStreamOnlineUserNumInfo> LiveStreamOnlineUserNumInfos
		{
			get
			{
				return liveStreamOnlineUserNumInfos;
			}
			set	
			{
				liveStreamOnlineUserNumInfos = value;
			}
		}

		public class DescribeDomainOnlineUserNumber_LiveStreamOnlineUserNumInfo
		{

			private string time;

			private long? userNumber;

			public string Time
			{
				get
				{
					return time;
				}
				set	
				{
					time = value;
				}
			}

			public long? UserNumber
			{
				get
				{
					return userNumber;
				}
				set	
				{
					userNumber = value;
				}
			}
		}
	}
}