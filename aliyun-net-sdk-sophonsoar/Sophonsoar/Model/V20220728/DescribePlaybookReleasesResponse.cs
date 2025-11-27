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

namespace Aliyun.Acs.sophonsoar.Model.V20220728
{
	public class DescribePlaybookReleasesResponse : AcsResponse
	{

		private string requestId;

		private List<DescribePlaybookReleases_Data> records;

		private DescribePlaybookReleases_Page page;

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

		public List<DescribePlaybookReleases_Data> Records
		{
			get
			{
				return records;
			}
			set	
			{
				records = value;
			}
		}

		public DescribePlaybookReleases_Page Page
		{
			get
			{
				return page;
			}
			set	
			{
				page = value;
			}
		}

		public class DescribePlaybookReleases_Data
		{

			private int? id;

			private long? gmtCreate;

			private long? gmtModified;

			private long? playbookId;

			private string releaseUuid;

			private string creator;

			private string description;

			private string taskflowMd5;

			private int? flowFlag;

			private int? flowTag;

			public int? Id
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

			public long? GmtCreate
			{
				get
				{
					return gmtCreate;
				}
				set	
				{
					gmtCreate = value;
				}
			}

			public long? GmtModified
			{
				get
				{
					return gmtModified;
				}
				set	
				{
					gmtModified = value;
				}
			}

			public long? PlaybookId
			{
				get
				{
					return playbookId;
				}
				set	
				{
					playbookId = value;
				}
			}

			public string ReleaseUuid
			{
				get
				{
					return releaseUuid;
				}
				set	
				{
					releaseUuid = value;
				}
			}

			public string Creator
			{
				get
				{
					return creator;
				}
				set	
				{
					creator = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}

			public string TaskflowMd5
			{
				get
				{
					return taskflowMd5;
				}
				set	
				{
					taskflowMd5 = value;
				}
			}

			public int? FlowFlag
			{
				get
				{
					return flowFlag;
				}
				set	
				{
					flowFlag = value;
				}
			}

			public int? FlowTag
			{
				get
				{
					return flowTag;
				}
				set	
				{
					flowTag = value;
				}
			}
		}

		public class DescribePlaybookReleases_Page
		{

			private int? totalCount;

			private int? pageNumber;

			private int? pageSize;

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

			public int? PageNumber
			{
				get
				{
					return pageNumber;
				}
				set	
				{
					pageNumber = value;
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
		}
	}
}
