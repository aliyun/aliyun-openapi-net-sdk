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
	public class DescribeRecordDetailResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeRecordDetail_RecordDetailInfo> recordDetailInfos;

		private DescribeRecordDetail_Duration duration;

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

		public List<DescribeRecordDetail_RecordDetailInfo> RecordDetailInfos
		{
			get
			{
				return recordDetailInfos;
			}
			set	
			{
				recordDetailInfos = value;
			}
		}

		public DescribeRecordDetail_Duration Duration
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

		public class DescribeRecordDetail_RecordDetailInfo
		{

			private string uid;

			private string startTime;

			private string endTime;

			private string deviceType;

			private string sDKVersion;

			public string Uid
			{
				get
				{
					return uid;
				}
				set	
				{
					uid = value;
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

			public string DeviceType
			{
				get
				{
					return deviceType;
				}
				set	
				{
					deviceType = value;
				}
			}

			public string SDKVersion
			{
				get
				{
					return sDKVersion;
				}
				set	
				{
					sDKVersion = value;
				}
			}
		}

		public class DescribeRecordDetail_Duration
		{

			private float? audio;

			private float? sd;

			private float? hd;

			private float? fhd;

			private float? all;

			public float? Audio
			{
				get
				{
					return audio;
				}
				set	
				{
					audio = value;
				}
			}

			public float? Sd
			{
				get
				{
					return sd;
				}
				set	
				{
					sd = value;
				}
			}

			public float? Hd
			{
				get
				{
					return hd;
				}
				set	
				{
					hd = value;
				}
			}

			public float? Fhd
			{
				get
				{
					return fhd;
				}
				set	
				{
					fhd = value;
				}
			}

			public float? All
			{
				get
				{
					return all;
				}
				set	
				{
					all = value;
				}
			}
		}
	}
}