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
	public class DescribeLivePrivateLineAreasResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeLivePrivateLineAreas_LiveArea> liveAreasList;

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

		[JsonProperty(PropertyName = "LiveAreasList")]
		public List<DescribeLivePrivateLineAreas_LiveArea> LiveAreasList
		{
			get
			{
				return liveAreasList;
			}
			set	
			{
				liveAreasList = value;
			}
		}

		public class DescribeLivePrivateLineAreas_LiveArea
		{

			private string regionType;

			private List<DescribeLivePrivateLineAreas_Region> regions;

			[JsonProperty(PropertyName = "RegionType")]
			public string RegionType
			{
				get
				{
					return regionType;
				}
				set	
				{
					regionType = value;
				}
			}

			[JsonProperty(PropertyName = "Regions")]
			public List<DescribeLivePrivateLineAreas_Region> Regions
			{
				get
				{
					return regions;
				}
				set	
				{
					regions = value;
				}
			}

			public class DescribeLivePrivateLineAreas_Region
			{

				private string localName;

				private string regionId;

				[JsonProperty(PropertyName = "LocalName")]
				public string LocalName
				{
					get
					{
						return localName;
					}
					set	
					{
						localName = value;
					}
				}

				[JsonProperty(PropertyName = "RegionId")]
				public string RegionId
				{
					get
					{
						return regionId;
					}
					set	
					{
						regionId = value;
					}
				}
			}
		}
	}
}
