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
	public class DescribeAuditContentItemResponse : AcsResponse
	{

		private int? currentPage;

		private string requestId;

		private int? pageSize;

		private int? totalCount;

		private List<DescribeAuditContentItem_AuditContentItem> auditContentItemList;

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

		public List<DescribeAuditContentItem_AuditContentItem> AuditContentItemList
		{
			get
			{
				return auditContentItemList;
			}
			set	
			{
				auditContentItemList = value;
			}
		}

		public class DescribeAuditContentItem_AuditContentItem
		{

			private string endTime;

			private string startTime;

			private string suggestion;

			private int? sn;

			private string parentTaskId;

			private string auditResult;

			private int? audit;

			private string content;

			private long? id;

			private List<string> auditIllegalReasons;

			public string EndTime
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

			public string StartTime
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

			public int? Sn
			{
				get
				{
					return sn;
				}
				set	
				{
					sn = value;
				}
			}

			public string ParentTaskId
			{
				get
				{
					return parentTaskId;
				}
				set	
				{
					parentTaskId = value;
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
		}
	}
}
