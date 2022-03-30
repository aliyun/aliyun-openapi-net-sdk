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

		private int? total;

		private string requestId;

		private List<DescribeCasterVideoResources_VideoResource> videoResources;

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

			private int? endOffset;

			private string flvUrl;

			private int? beginOffset;

			private int? ptsCallbackInterval;

			private string materialId;

			private string locationId;

			private string liveStreamUrl;

			private string vodUrl;

			private string resourceId;

			private int? repeatNum;

			private string resourceName;

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
		}
	}
}
