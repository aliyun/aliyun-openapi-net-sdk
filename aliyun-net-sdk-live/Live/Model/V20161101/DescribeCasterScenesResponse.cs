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
	public class DescribeCasterScenesResponse : AcsResponse
	{

		private string requestId;

		private int? total;

		private List<DescribeCasterScenes_Scene> sceneList;

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

		[JsonProperty(PropertyName = "Total")]
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

		[JsonProperty(PropertyName = "SceneList")]
		public List<DescribeCasterScenes_Scene> SceneList
		{
			get
			{
				return sceneList;
			}
			set	
			{
				sceneList = value;
			}
		}

		public class DescribeCasterScenes_Scene
		{

			private string layoutId;

			private string outputType;

			private string rtsUrl;

			private string sceneId;

			private string sceneName;

			private int? status;

			private string streamUrl;

			private List<DescribeCasterScenes_StreamInfo> streamInfos;

			private List<string> componentIds;

			[JsonProperty(PropertyName = "LayoutId")]
			public string LayoutId
			{
				get
				{
					return layoutId;
				}
				set	
				{
					layoutId = value;
				}
			}

			[JsonProperty(PropertyName = "OutputType")]
			public string OutputType
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

			[JsonProperty(PropertyName = "SceneName")]
			public string SceneName
			{
				get
				{
					return sceneName;
				}
				set	
				{
					sceneName = value;
				}
			}

			[JsonProperty(PropertyName = "Status")]
			public int? Status
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
			public List<DescribeCasterScenes_StreamInfo> StreamInfos
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

			[JsonProperty(PropertyName = "ComponentIds")]
			public List<string> ComponentIds
			{
				get
				{
					return componentIds;
				}
				set	
				{
					componentIds = value;
				}
			}

			public class DescribeCasterScenes_StreamInfo
			{

				private string outputStreamUrl;

				private string transcodeConfig;

				private string videoFormat;

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
			}
		}
	}
}
