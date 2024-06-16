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

namespace Aliyun.Acs.Green.Model.V20170823
{
	public class DescribeOssResultItemsResponse : AcsResponse
	{

		private int? currentPage;

		private int? pageSize;

		private string requestId;

		private int? totalCount;

		private string queryId;

		private List<DescribeOssResultItems_ScanResult> scanResultList;

		public int? CurrentPage
		{
			get
			{
				return currentPage;
			}
			set	
			{
				currentPage = value;
			}
		}

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

		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public string QueryId
		{
			get
			{
				return queryId;
			}
			set	
			{
				queryId = value;
			}
		}

		public List<DescribeOssResultItems_ScanResult> ScanResultList
		{
			get
			{
				return scanResultList;
			}
			set	
			{
				scanResultList = value;
			}
		}

		public class DescribeOssResultItems_ScanResult
		{

			private string suggestion;

			private string createTime;

			private string score;

			private string dataId;

			private string _object;

			private string newUrl;

			private string scanFinishedTime;

			private int? handleStatus;

			private string content;

			private string taskId;

			private string thumbnail;

			private long? id;

			private int? resourceStatus;

			private string requestTime;

			private string bucket;

			private List<DescribeOssResultItems_FrameResult> frameResults;

			private List<DescribeOssResultItems_VoiceSegmentAntispamResult> voiceSegmentAntispamResults;

			public string Suggestion
			{
				get
				{
					return suggestion;
				}
				set	
				{
					suggestion = value;
				}
			}

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

			public string Score
			{
				get
				{
					return score;
				}
				set	
				{
					score = value;
				}
			}

			public string DataId
			{
				get
				{
					return dataId;
				}
				set	
				{
					dataId = value;
				}
			}

			public string _Object
			{
				get
				{
					return _object;
				}
				set	
				{
					_object = value;
				}
			}

			public string NewUrl
			{
				get
				{
					return newUrl;
				}
				set	
				{
					newUrl = value;
				}
			}

			public string ScanFinishedTime
			{
				get
				{
					return scanFinishedTime;
				}
				set	
				{
					scanFinishedTime = value;
				}
			}

			public int? HandleStatus
			{
				get
				{
					return handleStatus;
				}
				set	
				{
					handleStatus = value;
				}
			}

			public string Content
			{
				get
				{
					return content;
				}
				set	
				{
					content = value;
				}
			}

			public string TaskId
			{
				get
				{
					return taskId;
				}
				set	
				{
					taskId = value;
				}
			}

			public string Thumbnail
			{
				get
				{
					return thumbnail;
				}
				set	
				{
					thumbnail = value;
				}
			}

			public long? Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

			public int? ResourceStatus
			{
				get
				{
					return resourceStatus;
				}
				set	
				{
					resourceStatus = value;
				}
			}

			public string RequestTime
			{
				get
				{
					return requestTime;
				}
				set	
				{
					requestTime = value;
				}
			}

			public string Bucket
			{
				get
				{
					return bucket;
				}
				set	
				{
					bucket = value;
				}
			}

			public List<DescribeOssResultItems_FrameResult> FrameResults
			{
				get
				{
					return frameResults;
				}
				set	
				{
					frameResults = value;
				}
			}

			public List<DescribeOssResultItems_VoiceSegmentAntispamResult> VoiceSegmentAntispamResults
			{
				get
				{
					return voiceSegmentAntispamResults;
				}
				set	
				{
					voiceSegmentAntispamResults = value;
				}
			}

			public class DescribeOssResultItems_FrameResult
			{

				private int? offset;

				private string url;

				private string thumbnail;

				public int? Offset
				{
					get
					{
						return offset;
					}
					set	
					{
						offset = value;
					}
				}

				public string Url
				{
					get
					{
						return url;
					}
					set	
					{
						url = value;
					}
				}

				public string Thumbnail
				{
					get
					{
						return thumbnail;
					}
					set	
					{
						thumbnail = value;
					}
				}
			}

			public class DescribeOssResultItems_VoiceSegmentAntispamResult
			{

				private int? endTime;

				private int? startTime;

				private string text;

				private string label;

				public int? EndTime
				{
					get
					{
						return endTime;
					}
					set	
					{
						endTime = value;
					}
				}

				public int? StartTime
				{
					get
					{
						return startTime;
					}
					set	
					{
						startTime = value;
					}
				}

				public string Text
				{
					get
					{
						return text;
					}
					set	
					{
						text = value;
					}
				}

				public string Label
				{
					get
					{
						return label;
					}
					set	
					{
						label = value;
					}
				}
			}
		}
	}
}
