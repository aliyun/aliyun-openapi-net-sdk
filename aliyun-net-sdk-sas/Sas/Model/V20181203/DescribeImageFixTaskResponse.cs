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

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class DescribeImageFixTaskResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeImageFixTask_BuildTask> buildTasks;

		private DescribeImageFixTask_PageInfo pageInfo;

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

		public List<DescribeImageFixTask_BuildTask> BuildTasks
		{
			get
			{
				return buildTasks;
			}
			set	
			{
				buildTasks = value;
			}
		}

		public DescribeImageFixTask_PageInfo PageInfo
		{
			get
			{
				return pageInfo;
			}
			set	
			{
				pageInfo = value;
			}
		}

		public class DescribeImageFixTask_BuildTask
		{

			private string buildTaskId;

			private string taskType;

			private string repoNamespace;

			private string repoName;

			private string regionId;

			private string oldTag;

			private string oldUuid;

			private string newTag;

			private string newUuid;

			private string fixTime;

			private string finishTime;

			private int? status;

			public string BuildTaskId
			{
				get
				{
					return buildTaskId;
				}
				set	
				{
					buildTaskId = value;
				}
			}

			public string TaskType
			{
				get
				{
					return taskType;
				}
				set	
				{
					taskType = value;
				}
			}

			public string RepoNamespace
			{
				get
				{
					return repoNamespace;
				}
				set	
				{
					repoNamespace = value;
				}
			}

			public string RepoName
			{
				get
				{
					return repoName;
				}
				set	
				{
					repoName = value;
				}
			}

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

			public string OldTag
			{
				get
				{
					return oldTag;
				}
				set	
				{
					oldTag = value;
				}
			}

			public string OldUuid
			{
				get
				{
					return oldUuid;
				}
				set	
				{
					oldUuid = value;
				}
			}

			public string NewTag
			{
				get
				{
					return newTag;
				}
				set	
				{
					newTag = value;
				}
			}

			public string NewUuid
			{
				get
				{
					return newUuid;
				}
				set	
				{
					newUuid = value;
				}
			}

			public string FixTime
			{
				get
				{
					return fixTime;
				}
				set	
				{
					fixTime = value;
				}
			}

			public string FinishTime
			{
				get
				{
					return finishTime;
				}
				set	
				{
					finishTime = value;
				}
			}

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
		}

		public class DescribeImageFixTask_PageInfo
		{

			private int? currentPage;

			private int? pageSize;

			private int? totalCount;

			private int? count;

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
		}
	}
}
