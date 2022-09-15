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
	public class DescribeLiveStreamSnapshotInfoResponse : AcsResponse
	{

		private string nextStartTime;

		private string requestId;

		private List<DescribeLiveStreamSnapshotInfo_LiveStreamSnapshotInfo> liveStreamSnapshotInfoList;

		[JsonProperty(PropertyName = "NextStartTime")]
		public string NextStartTime
		{
			get
			{
				return nextStartTime;
			}
			set	
			{
				nextStartTime = value;
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

		[JsonProperty(PropertyName = "LiveStreamSnapshotInfoList")]
		public List<DescribeLiveStreamSnapshotInfo_LiveStreamSnapshotInfo> LiveStreamSnapshotInfoList
		{
			get
			{
				return liveStreamSnapshotInfoList;
			}
			set	
			{
				liveStreamSnapshotInfoList = value;
			}
		}

		public class DescribeLiveStreamSnapshotInfo_LiveStreamSnapshotInfo
		{

			private string ossObject;

			private string ossBucket;

			private string createTime;

			private string ossEndpoint;

			private bool? isOverlay;

			private long? createTimestamp;

			[JsonProperty(PropertyName = "OssObject")]
			public string OssObject
			{
				get
				{
					return ossObject;
				}
				set	
				{
					ossObject = value;
				}
			}

			[JsonProperty(PropertyName = "OssBucket")]
			public string OssBucket
			{
				get
				{
					return ossBucket;
				}
				set	
				{
					ossBucket = value;
				}
			}

			[JsonProperty(PropertyName = "CreateTime")]
			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			[JsonProperty(PropertyName = "OssEndpoint")]
			public string OssEndpoint
			{
				get
				{
					return ossEndpoint;
				}
				set	
				{
					ossEndpoint = value;
				}
			}

			[JsonProperty(PropertyName = "IsOverlay")]
			public bool? IsOverlay
			{
				get
				{
					return isOverlay;
				}
				set	
				{
					isOverlay = value;
				}
			}

			[JsonProperty(PropertyName = "CreateTimestamp")]
			public long? CreateTimestamp
			{
				get
				{
					return createTimestamp;
				}
				set	
				{
					createTimestamp = value;
				}
			}
		}
	}
}
