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
	public class DescribeLiveStreamCountResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeLiveStreamCount_StreamCountInfo> streamCountInfos;

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

		public List<DescribeLiveStreamCount_StreamCountInfo> StreamCountInfos
		{
			get
			{
				return streamCountInfos;
			}
			set	
			{
				streamCountInfos = value;
			}
		}

		public class DescribeLiveStreamCount_StreamCountInfo
		{

			private string type;

			private long? count;

			private long? limit;

			private List<DescribeLiveStreamCount_StreamCountDetail> streamCountDetails;

			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}

			public long? Count
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

			public long? Limit
			{
				get
				{
					return limit;
				}
				set	
				{
					limit = value;
				}
			}

			public List<DescribeLiveStreamCount_StreamCountDetail> StreamCountDetails
			{
				get
				{
					return streamCountDetails;
				}
				set	
				{
					streamCountDetails = value;
				}
			}

			public class DescribeLiveStreamCount_StreamCountDetail
			{

				private long? videoDataRate;

				private string format;

				private long? count;

				public long? VideoDataRate
				{
					get
					{
						return videoDataRate;
					}
					set	
					{
						videoDataRate = value;
					}
				}

				public string Format
				{
					get
					{
						return format;
					}
					set	
					{
						format = value;
					}
				}

				public long? Count
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
			}
		}
	}
}
