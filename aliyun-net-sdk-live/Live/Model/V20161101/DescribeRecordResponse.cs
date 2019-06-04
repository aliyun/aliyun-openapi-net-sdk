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
	public class DescribeRecordResponse : AcsResponse
	{

		private string requestId;

		private string recordId;

		private string appId;

		private int? boardId;

		private long? recordStartTime;

		private long? startTime;

		private long? endTime;

		private int? state;

		private string ossPath;

		private string ossBucket;

		private string ossEndpoint;

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

		public string AppId
		{
			get
			{
				return appId;
			}
			set	
			{
				appId = value;
			}
		}

		public int? BoardId
		{
			get
			{
				return boardId;
			}
			set	
			{
				boardId = value;
			}
		}

		public long? RecordStartTime
		{
			get
			{
				return recordStartTime;
			}
			set	
			{
				recordStartTime = value;
			}
		}

		public long? StartTime
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

		public long? EndTime
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

		public int? State
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

		public string OssPath
		{
			get
			{
				return ossPath;
			}
			set	
			{
				ossPath = value;
			}
		}

		public string OssBucket
		{
			get
			{
				return ossBucket;
			}
			set	
			{
				ossBucket = value;
			}
		}

		public string OssEndpoint
		{
			get
			{
				return ossEndpoint;
			}
			set	
			{
				ossEndpoint = value;
			}
		}
	}
}
