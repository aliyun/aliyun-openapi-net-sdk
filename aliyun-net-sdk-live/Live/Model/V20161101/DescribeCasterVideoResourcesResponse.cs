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

namespace Aliyun.Acs.live.Model.V20161101
{
	public class DescribeCasterVideoResourcesResponse : AcsResponse
	{

		private string requestId;

		private int? total;

		private List<DescribeCasterVideoResources_VideoResource> videoResources;

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

			private string materialId;

			private string resourceId;

			private string resourceName;

			private string locationId;

			private string liveStreamUrl;

			private int? repeatNum;

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
		}
	}
}