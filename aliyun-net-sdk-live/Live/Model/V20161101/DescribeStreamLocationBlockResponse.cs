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
	public class DescribeStreamLocationBlockResponse : AcsResponse
	{

		private int? totalPage;

		private int? pageNum;

		private int? pageSize;

		private string requestId;

		private int? count;

		private List<DescribeStreamLocationBlock_StreamBlock> streamBlockList;

		[JsonProperty(PropertyName = "TotalPage")]
		public int? TotalPage
		{
			get
			{
				return totalPage;
			}
			set	
			{
				totalPage = value;
			}
		}

		[JsonProperty(PropertyName = "PageNum")]
		public int? PageNum
		{
			get
			{
				return pageNum;
			}
			set	
			{
				pageNum = value;
			}
		}

		[JsonProperty(PropertyName = "PageSize")]
		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

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

		[JsonProperty(PropertyName = "Count")]
		public int? Count
		{
			get
			{
				return count;
			}
			set	
			{
				count = value;
			}
		}

		[JsonProperty(PropertyName = "StreamBlockList")]
		public List<DescribeStreamLocationBlock_StreamBlock> StreamBlockList
		{
			get
			{
				return streamBlockList;
			}
			set	
			{
				streamBlockList = value;
			}
		}

		public class DescribeStreamLocationBlock_StreamBlock
		{

			private int? status;

			private string blockType;

			private string appName;

			private string updateTime;

			private string streamName;

			private string releaseTime;

			private string locationList;

			private string domainName;

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

			[JsonProperty(PropertyName = "BlockType")]
			public string BlockType
			{
				get
				{
					return blockType;
				}
				set	
				{
					blockType = value;
				}
			}

			[JsonProperty(PropertyName = "AppName")]
			public string AppName
			{
				get
				{
					return appName;
				}
				set	
				{
					appName = value;
				}
			}

			[JsonProperty(PropertyName = "UpdateTime")]
			public string UpdateTime
			{
				get
				{
					return updateTime;
				}
				set	
				{
					updateTime = value;
				}
			}

			[JsonProperty(PropertyName = "StreamName")]
			public string StreamName
			{
				get
				{
					return streamName;
				}
				set	
				{
					streamName = value;
				}
			}

			[JsonProperty(PropertyName = "ReleaseTime")]
			public string ReleaseTime
			{
				get
				{
					return releaseTime;
				}
				set	
				{
					releaseTime = value;
				}
			}

			[JsonProperty(PropertyName = "LocationList")]
			public string LocationList
			{
				get
				{
					return locationList;
				}
				set	
				{
					locationList = value;
				}
			}

			[JsonProperty(PropertyName = "DomainName")]
			public string DomainName
			{
				get
				{
					return domainName;
				}
				set	
				{
					domainName = value;
				}
			}
		}
	}
}
