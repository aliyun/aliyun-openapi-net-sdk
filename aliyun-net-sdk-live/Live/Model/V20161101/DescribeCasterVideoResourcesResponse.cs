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
	public class DescribeCasterVideoResourcesResponse : AcsResponse
	{

		private string requestId;

		private int? total;

		private List<DescribeCasterVideoResources_VideoResource> videoResources;

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

		[JsonProperty(PropertyName = "VideoResources")]
		public List<DescribeCasterVideoResources_VideoResource> VideoResources
		{
			get
			{
				return videoResources;
			}
			set	
			{
				videoResources = value;
			}
		}

		public class DescribeCasterVideoResources_VideoResource
		{

			private int? beginOffset;

			private int? endOffset;

			private string flvUrl;

			private string imageId;

			private string imageUrl;

			private string liveStreamUrl;

			private string locationId;

			private string materialId;

			private int? ptsCallbackInterval;

			private int? repeatNum;

			private string resourceId;

			private string resourceName;

			private string vodUrl;

			[JsonProperty(PropertyName = "BeginOffset")]
			public int? BeginOffset
			{
				get
				{
					return beginOffset;
				}
				set	
				{
					beginOffset = value;
				}
			}

			[JsonProperty(PropertyName = "EndOffset")]
			public int? EndOffset
			{
				get
				{
					return endOffset;
				}
				set	
				{
					endOffset = value;
				}
			}

			[JsonProperty(PropertyName = "FlvUrl")]
			public string FlvUrl
			{
				get
				{
					return flvUrl;
				}
				set	
				{
					flvUrl = value;
				}
			}

			[JsonProperty(PropertyName = "ImageId")]
			public string ImageId
			{
				get
				{
					return imageId;
				}
				set	
				{
					imageId = value;
				}
			}

			[JsonProperty(PropertyName = "ImageUrl")]
			public string ImageUrl
			{
				get
				{
					return imageUrl;
				}
				set	
				{
					imageUrl = value;
				}
			}

			[JsonProperty(PropertyName = "LiveStreamUrl")]
			public string LiveStreamUrl
			{
				get
				{
					return liveStreamUrl;
				}
				set	
				{
					liveStreamUrl = value;
				}
			}

			[JsonProperty(PropertyName = "LocationId")]
			public string LocationId
			{
				get
				{
					return locationId;
				}
				set	
				{
					locationId = value;
				}
			}

			[JsonProperty(PropertyName = "MaterialId")]
			public string MaterialId
			{
				get
				{
					return materialId;
				}
				set	
				{
					materialId = value;
				}
			}

			[JsonProperty(PropertyName = "PtsCallbackInterval")]
			public int? PtsCallbackInterval
			{
				get
				{
					return ptsCallbackInterval;
				}
				set	
				{
					ptsCallbackInterval = value;
				}
			}

			[JsonProperty(PropertyName = "RepeatNum")]
			public int? RepeatNum
			{
				get
				{
					return repeatNum;
				}
				set	
				{
					repeatNum = value;
				}
			}

			[JsonProperty(PropertyName = "ResourceId")]
			public string ResourceId
			{
				get
				{
					return resourceId;
				}
				set	
				{
					resourceId = value;
				}
			}

			[JsonProperty(PropertyName = "ResourceName")]
			public string ResourceName
			{
				get
				{
					return resourceName;
				}
				set	
				{
					resourceName = value;
				}
			}

			[JsonProperty(PropertyName = "VodUrl")]
			public string VodUrl
			{
				get
				{
					return vodUrl;
				}
				set	
				{
					vodUrl = value;
				}
			}
		}
	}
}
