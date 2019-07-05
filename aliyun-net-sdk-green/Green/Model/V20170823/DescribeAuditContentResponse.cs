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
	public class DescribeAuditContentResponse : AcsResponse
	{

		private string requestId;

		private int? pageSize;

		private int? currentPage;

		private int? totalCount;

		private List<DescribeAuditContent_AuditContent> auditContentList;

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

		public List<DescribeAuditContent_AuditContent> AuditContentList
		{
			get
			{
				return auditContentList;
			}
			set	
			{
				auditContentList = value;
			}
		}

		public class DescribeAuditContent_AuditContent
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

			private int? audit;

			private string auditResult;

			private string suggestion;

			private long? id;

			private List<DescribeAuditContent_Result> results;

			private List<DescribeAuditContent_FrameResult> frameResults;

			private List<string> auditIllegalReasons;

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

			public int? Audit
			{
				get
				{
					return audit;
				}
				set	
				{
					audit = value;
				}
			}

			public string AuditResult
			{
				get
				{
					return auditResult;
				}
				set	
				{
					auditResult = value;
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

			public List<DescribeAuditContent_Result> Results
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

			public List<DescribeAuditContent_FrameResult> FrameResults
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

			public List<string> AuditIllegalReasons
			{
				get
				{
					return auditIllegalReasons;
				}
				set	
				{
					auditIllegalReasons = value;
				}
			}

			public class DescribeAuditContent_Result
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

			public class DescribeAuditContent_FrameResult
			{

				private string url;

				private int? offset;

				private string label;

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
