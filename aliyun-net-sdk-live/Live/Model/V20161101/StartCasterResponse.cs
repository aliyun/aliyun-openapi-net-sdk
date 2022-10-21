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
	public class StartCasterResponse : AcsResponse
	{

		private string requestId;

		private List<StartCaster_SceneInfo> pvwSceneInfos;

		private List<StartCaster_SceneInfo1> pgmSceneInfos;

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

		[JsonProperty(PropertyName = "PvwSceneInfos")]
		public List<StartCaster_SceneInfo> PvwSceneInfos
		{
			get
			{
				return pvwSceneInfos;
			}
			set	
			{
				pvwSceneInfos = value;
			}
		}

		[JsonProperty(PropertyName = "PgmSceneInfos")]
		public List<StartCaster_SceneInfo1> PgmSceneInfos
		{
			get
			{
				return pgmSceneInfos;
			}
			set	
			{
				pgmSceneInfos = value;
			}
		}

		public class StartCaster_SceneInfo
		{

			private string rtsUrl;

			private string sceneId;

			private string streamUrl;

			[JsonProperty(PropertyName = "RtsUrl")]
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

			[JsonProperty(PropertyName = "SceneId")]
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

			[JsonProperty(PropertyName = "StreamUrl")]
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
		}

		public class StartCaster_SceneInfo1
		{

			private string rtsUrl;

			private string sceneId;

			private string streamUrl;

			private List<StartCaster_StreamInfo> streamInfos;

			[JsonProperty(PropertyName = "RtsUrl")]
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

			[JsonProperty(PropertyName = "SceneId")]
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

			[JsonProperty(PropertyName = "StreamUrl")]
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

			[JsonProperty(PropertyName = "StreamInfos")]
			public List<StartCaster_StreamInfo> StreamInfos
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

			public class StartCaster_StreamInfo
			{

				private string videoFormat;

				private string outputStreamUrl;

				private string transcodeConfig;

				[JsonProperty(PropertyName = "VideoFormat")]
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

				[JsonProperty(PropertyName = "OutputStreamUrl")]
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

				[JsonProperty(PropertyName = "TranscodeConfig")]
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
