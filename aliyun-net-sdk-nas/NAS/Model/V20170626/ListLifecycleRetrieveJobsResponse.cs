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

namespace Aliyun.Acs.NAS.Model.V20170626
{
	public class ListLifecycleRetrieveJobsResponse : AcsResponse
	{

		private int? totalCount;

		private int? pageSize;

		private string requestId;

		private int? pageNumber;

		private List<ListLifecycleRetrieveJobs_LifecycleRetrieveJob> lifecycleRetrieveJobs;

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

		public List<ListLifecycleRetrieveJobs_LifecycleRetrieveJob> LifecycleRetrieveJobs
		{
			get
			{
				return lifecycleRetrieveJobs;
			}
			set	
			{
				lifecycleRetrieveJobs = value;
			}
		}

		public class ListLifecycleRetrieveJobs_LifecycleRetrieveJob
		{

			private string status;

			private string createTime;

			private long? retrievedFileCount;

			private string updateTime;

			private string fileSystemId;

			private string jobId;

			private long? discoveredFileCount;

			private List<string> paths;

			public string Status
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

			public long? RetrievedFileCount
			{
				get
				{
					return retrievedFileCount;
				}
				set	
				{
					retrievedFileCount = value;
				}
			}

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

			public string FileSystemId
			{
				get
				{
					return fileSystemId;
				}
				set	
				{
					fileSystemId = value;
				}
			}

			public string JobId
			{
				get
				{
					return jobId;
				}
				set	
				{
					jobId = value;
				}
			}

			public long? DiscoveredFileCount
			{
				get
				{
					return discoveredFileCount;
				}
				set	
				{
					discoveredFileCount = value;
				}
			}

			public List<string> Paths
			{
				get
				{
					return paths;
				}
				set	
				{
					paths = value;
				}
			}
		}
	}
}
