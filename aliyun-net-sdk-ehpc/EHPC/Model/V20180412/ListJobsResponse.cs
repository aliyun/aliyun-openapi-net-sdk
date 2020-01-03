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

namespace Aliyun.Acs.EHPC.Model.V20180412
{
	public class ListJobsResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<ListJobs_JobInfo> jobs;

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

		public List<ListJobs_JobInfo> Jobs
		{
			get
			{
				return jobs;
			}
			set	
			{
				jobs = value;
			}
		}

		public class ListJobs_JobInfo
		{

			private string id;

			private string name;

			private string owner;

			private string nodeList;

			private string priority;

			private string state;

			private string submitTime;

			private string startTime;

			private string lastModifyTime;

			private string stdout;

			private string stderr;

			private string shellPath;

			private string comment;

			private string arrayRequest;

			private ListJobs_Resources resources;

			public string Id
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

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public string Owner
			{
				get
				{
					return owner;
				}
				set	
				{
					owner = value;
				}
			}

			public string NodeList
			{
				get
				{
					return nodeList;
				}
				set	
				{
					nodeList = value;
				}
			}

			public string Priority
			{
				get
				{
					return priority;
				}
				set	
				{
					priority = value;
				}
			}

			public string State
			{
				get
				{
					return state;
				}
				set	
				{
					state = value;
				}
			}

			public string SubmitTime
			{
				get
				{
					return submitTime;
				}
				set	
				{
					submitTime = value;
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

			public string LastModifyTime
			{
				get
				{
					return lastModifyTime;
				}
				set	
				{
					lastModifyTime = value;
				}
			}

			public string Stdout
			{
				get
				{
					return stdout;
				}
				set	
				{
					stdout = value;
				}
			}

			public string Stderr
			{
				get
				{
					return stderr;
				}
				set	
				{
					stderr = value;
				}
			}

			public string ShellPath
			{
				get
				{
					return shellPath;
				}
				set	
				{
					shellPath = value;
				}
			}

			public string Comment
			{
				get
				{
					return comment;
				}
				set	
				{
					comment = value;
				}
			}

			public string ArrayRequest
			{
				get
				{
					return arrayRequest;
				}
				set	
				{
					arrayRequest = value;
				}
			}

			public ListJobs_Resources Resources
			{
				get
				{
					return resources;
				}
				set	
				{
					resources = value;
				}
			}

			public class ListJobs_Resources
			{

				private int? nodes;

				private int? cores;

				public int? Nodes
				{
					get
					{
						return nodes;
					}
					set	
					{
						nodes = value;
					}
				}

				public int? Cores
				{
					get
					{
						return cores;
					}
					set	
					{
						cores = value;
					}
				}
			}
		}
	}
}
