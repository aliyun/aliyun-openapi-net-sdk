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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.live.Model.V20161101
{
	public class DescribeLiveGrtnDurationResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeLiveGrtnDuration_StreamData> streamDetailData;

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "StreamDetailData")]
		public List<DescribeLiveGrtnDuration_StreamData> StreamDetailData
		{
			get
			{
				return streamDetailData;
			}
			set	
			{
				streamDetailData = value;
			}
		}

		public class DescribeLiveGrtnDuration_StreamData
		{

			private string appId;

			private long? duration;

			private string mediaProfile;

			private string mediaType;

			private string timeStamp;

			[JsonProperty(PropertyName = "AppId")]
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

			[JsonProperty(PropertyName = "Duration")]
			public long? Duration
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

			[JsonProperty(PropertyName = "MediaProfile")]
			public string MediaProfile
			{
				get
				{
					return mediaProfile;
				}
				set	
				{
					mediaProfile = value;
				}
			}

			[JsonProperty(PropertyName = "MediaType")]
			public string MediaType
			{
				get
				{
					return mediaType;
				}
				set	
				{
					mediaType = value;
				}
			}

			[JsonProperty(PropertyName = "TimeStamp")]
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
		}
	}
}
