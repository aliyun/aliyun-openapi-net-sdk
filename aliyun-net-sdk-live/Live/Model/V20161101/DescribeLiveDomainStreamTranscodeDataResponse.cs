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
	public class DescribeLiveDomainStreamTranscodeDataResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeLiveDomainStreamTranscodeData_TranscodeData> transcodeDataList;

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

		public List<DescribeLiveDomainStreamTranscodeData_TranscodeData> TranscodeDataList
		{
			get
			{
				return transcodeDataList;
			}
			set	
			{
				transcodeDataList = value;
			}
		}

		public class DescribeLiveDomainStreamTranscodeData_TranscodeData
		{

			private string timeStamp;

			private string domain;

			private string region;

			private string tanscodeType;

			private string resolution;

			private string fps;

			private int? duration;

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

			public string Domain
			{
				get
				{
					return domain;
				}
				set	
				{
					domain = value;
				}
			}

			public string Region
			{
				get
				{
					return region;
				}
				set	
				{
					region = value;
				}
			}

			public string TanscodeType
			{
				get
				{
					return tanscodeType;
				}
				set	
				{
					tanscodeType = value;
				}
			}

			public string Resolution
			{
				get
				{
					return resolution;
				}
				set	
				{
					resolution = value;
				}
			}

			public string Fps
			{
				get
				{
					return fps;
				}
				set	
				{
					fps = value;
				}
			}

			public int? Duration
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
		}
	}
}
