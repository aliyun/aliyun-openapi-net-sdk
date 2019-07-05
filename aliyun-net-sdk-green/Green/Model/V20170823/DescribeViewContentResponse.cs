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

using Aliyun.Acs.Core;

namespace Aliyun.Acs.Green.Model.V20170823
{
	public class DescribeViewContentResponse : AcsResponse
	{

		private string requestId;

		private int? pageSize;

		private int? currentPage;

		private int? totalCount;

		private List<DescribeViewContent_ViewContent> viewContentList;

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

		public List<DescribeViewContent_ViewContent> ViewContentList
		{
			get
			{
				return viewContentList;
			}
			set	
			{
				viewContentList = value;
			}
		}

		public class DescribeViewContent_ViewContent
		{

			private string taskId;

			private string dataId;

			private string bizType;

			private string content;

			private string url;

			private string newUrl;

			private string thumbnail;

			private string requestTime;

			private string scanFinishedTime;

			private string suggestion;

			private long? id;

			private string scanResult;

			private List<DescribeViewContent_Result> results;

			private List<DescribeViewContent_FrameResult> frameResults;

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

			public string BizType
			{
				get
				{
					return bizType;
				}
				set	
				{
					bizType = value;
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

			public string ScanResult
			{
				get
				{
					return scanResult;
				}
				set	
				{
					scanResult = value;
				}
			}

			public List<DescribeViewContent_Result> Results
			{
				get
				{
					return results;
				}
				set	
				{
					results = value;
				}
			}

			public List<DescribeViewContent_FrameResult> FrameResults
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

			public class DescribeViewContent_Result
			{

				private string suggestion;

				private string label;

				private string scene;

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

				public string Scene
				{
					get
					{
						return scene;
					}
					set	
					{
						scene = value;
					}
				}
			}

			public class DescribeViewContent_FrameResult
			{

				private string url;

				private int? offset;

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
			}
		}
	}
}
