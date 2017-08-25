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
	public class DescribeLiveStreamFrameInfoResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeLiveStreamFrameInfo_FrameDataModel> frameDataInfos;

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

		public List<DescribeLiveStreamFrameInfo_FrameDataModel> FrameDataInfos
		{
			get
			{
				return frameDataInfos;
			}
			set	
			{
				frameDataInfos = value;
			}
		}

		public class DescribeLiveStreamFrameInfo_FrameDataModel
		{

			private string time;

			private string stream;

			private string clientAddr;

			private string server;

			private float? audioRate;

			private float? audioByte;

			private float? frameRate;

			private float? frameByte;

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

			public string Stream
			{
				get
				{
					return stream;
				}
				set	
				{
					stream = value;
				}
			}

			public string ClientAddr
			{
				get
				{
					return clientAddr;
				}
				set	
				{
					clientAddr = value;
				}
			}

			public string Server
			{
				get
				{
					return server;
				}
				set	
				{
					server = value;
				}
			}

			public float? AudioRate
			{
				get
				{
					return audioRate;
				}
				set	
				{
					audioRate = value;
				}
			}

			public float? AudioByte
			{
				get
				{
					return audioByte;
				}
				set	
				{
					audioByte = value;
				}
			}

			public float? FrameRate
			{
				get
				{
					return frameRate;
				}
				set	
				{
					frameRate = value;
				}
			}

			public float? FrameByte
			{
				get
				{
					return frameByte;
				}
				set	
				{
					frameByte = value;
				}
			}
		}
	}
}