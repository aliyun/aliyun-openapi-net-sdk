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
	public class DescribeLiveStreamRecordIndexFilesResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeLiveStreamRecordIndexFiles_RecordIndexInfo> recordIndexInfoList;

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

		public List<DescribeLiveStreamRecordIndexFiles_RecordIndexInfo> RecordIndexInfoList
		{
			get
			{
				return recordIndexInfoList;
			}
			set	
			{
				recordIndexInfoList = value;
			}
		}

		public class DescribeLiveStreamRecordIndexFiles_RecordIndexInfo
		{

			private string recordId;

			private string recordUrl;

			private string domainName;

			private string appName;

			private string streamName;

			private string ossObject;

			private string startTime;

			private string endTime;

			private float? duration;

			private int? height;

			private int? width;

			private string createTime;

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

			public string RecordUrl
			{
				get
				{
					return recordUrl;
				}
				set	
				{
					recordUrl = value;
				}
			}

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

			public string OssObject
			{
				get
				{
					return ossObject;
				}
				set	
				{
					ossObject = value;
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

			public int? Height
			{
				get
				{
					return height;
				}
				set	
				{
					height = value;
				}
			}

			public int? Width
			{
				get
				{
					return width;
				}
				set	
				{
					width = value;
				}
			}

			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}
		}
	}
}