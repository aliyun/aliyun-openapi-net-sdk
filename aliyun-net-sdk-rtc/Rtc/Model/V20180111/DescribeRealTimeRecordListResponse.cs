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

namespace Aliyun.Acs.rtc.Model.V20180111
{
	public class DescribeRealTimeRecordListResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeRealTimeRecordList_CommunicationRecordInfo> communicationRecordInfos;

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

		public List<DescribeRealTimeRecordList_CommunicationRecordInfo> CommunicationRecordInfos
		{
			get
			{
				return communicationRecordInfos;
			}
			set	
			{
				communicationRecordInfos = value;
			}
		}

		public class DescribeRealTimeRecordList_CommunicationRecordInfo
		{

			private string channelId;

			private string startTime;

			private string endTime;

			private long? onlineUserCnt;

			private bool? status;

			private string recordId;

			private List<string> callAreas;

			public string ChannelId
			{
				get
				{
					return channelId;
				}
				set	
				{
					channelId = value;
				}
			}

			public string StartTime
			{
				get
				{
					return startTime;
				}
				set	
				{
					startTime = value;
				}
			}

			public string EndTime
			{
				get
				{
					return endTime;
				}
				set	
				{
					endTime = value;
				}
			}

			public long? OnlineUserCnt
			{
				get
				{
					return onlineUserCnt;
				}
				set	
				{
					onlineUserCnt = value;
				}
			}

			public bool? Status
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

			public string RecordId
			{
				get
				{
					return recordId;
				}
				set	
				{
					recordId = value;
				}
			}

			public List<string> CallAreas
			{
				get
				{
					return callAreas;
				}
				set	
				{
					callAreas = value;
				}
			}
		}
	}
}