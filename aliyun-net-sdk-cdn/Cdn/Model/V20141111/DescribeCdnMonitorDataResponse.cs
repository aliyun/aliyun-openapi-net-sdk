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
	public class DescribeCdnMonitorDataResponse : AcsResponse
	{

		private string requestId;

		private string domainName;

		private long? monitorInterval;

		private string startTime;

		private string endTime;

		private List<DescribeCdnMonitorData_CDNMonitorData> monitorDatas;

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

		public long? MonitorInterval
		{
			get
			{
				return monitorInterval;
			}
			set	
			{
				monitorInterval = value;
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

		public List<DescribeCdnMonitorData_CDNMonitorData> MonitorDatas
		{
			get
			{
				return monitorDatas;
			}
			set	
			{
				monitorDatas = value;
			}
		}

		public class DescribeCdnMonitorData_CDNMonitorData
		{

			private string timeStamp;

			private string queryPerSecond;

			private string bytesPerSecond;

			private string bytesHitRate;

			private string requestHitRate;

			private string averageObjectSize;

			public string TimeStamp
			{
				get
				{
					return timeStamp;
				}
				set	
				{
					timeStamp = value;
				}
			}

			public string QueryPerSecond
			{
				get
				{
					return queryPerSecond;
				}
				set	
				{
					queryPerSecond = value;
				}
			}

			public string BytesPerSecond
			{
				get
				{
					return bytesPerSecond;
				}
				set	
				{
					bytesPerSecond = value;
				}
			}

			public string BytesHitRate
			{
				get
				{
					return bytesHitRate;
				}
				set	
				{
					bytesHitRate = value;
				}
			}

			public string RequestHitRate
			{
				get
				{
					return requestHitRate;
				}
				set	
				{
					requestHitRate = value;
				}
			}

			public string AverageObjectSize
			{
				get
				{
					return averageObjectSize;
				}
				set	
				{
					averageObjectSize = value;
				}
			}
		}
	}
}