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
	public class DescribeCasterStreamUrlResponse : AcsResponse
	{

		private string requestId;

		private string casterId;

		private int? total;

		private List<DescribeCasterStreamUrl_CasterStream> casterStreams;

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

		public string CasterId
		{
			get
			{
				return casterId;
			}
			set	
			{
				casterId = value;
			}
		}

		public int? Total
		{
			get
			{
				return total;
			}
			set	
			{
				total = value;
			}
		}

		public List<DescribeCasterStreamUrl_CasterStream> CasterStreams
		{
			get
			{
				return casterStreams;
			}
			set	
			{
				casterStreams = value;
			}
		}

		public class DescribeCasterStreamUrl_CasterStream
		{

			private string rtsUrl;

			private string rtmpUrl;

			private string sceneId;

			private int? outputType;

			private string streamUrl;

			private List<DescribeCasterStreamUrl_StreamInfo> streamInfos;

			public string RtsUrl
			{
				get
				{
					return rtsUrl;
				}
				set	
				{
					rtsUrl = value;
				}
			}

			public string RtmpUrl
			{
				get
				{
					return rtmpUrl;
				}
				set	
				{
					rtmpUrl = value;
				}
			}

			public string SceneId
			{
				get
				{
					return sceneId;
				}
				set	
				{
					sceneId = value;
				}
			}

			public int? OutputType
			{
				get
				{
					return outputType;
				}
				set	
				{
					outputType = value;
				}
			}

			public string StreamUrl
			{
				get
				{
					return streamUrl;
				}
				set	
				{
					streamUrl = value;
				}
			}

			public List<DescribeCasterStreamUrl_StreamInfo> StreamInfos
			{
				get
				{
					return streamInfos;
				}
				set	
				{
					streamInfos = value;
				}
			}

			public class DescribeCasterStreamUrl_StreamInfo
			{

				private string videoFormat;

				private string outputStreamUrl;

				private string transcodeConfig;

				public string VideoFormat
				{
					get
					{
						return videoFormat;
					}
					set	
					{
						videoFormat = value;
					}
				}

				public string OutputStreamUrl
				{
					get
					{
						return outputStreamUrl;
					}
					set	
					{
						outputStreamUrl = value;
					}
				}

				public string TranscodeConfig
				{
					get
					{
						return transcodeConfig;
					}
					set	
					{
						transcodeConfig = value;
					}
				}
			}
		}
	}
}
