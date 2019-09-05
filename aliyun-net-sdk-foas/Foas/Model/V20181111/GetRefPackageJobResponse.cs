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

namespace Aliyun.Acs.foas.Model.V20181111
{
	public class GetRefPackageJobResponse : AcsResponse
	{

		private string requestId;

		private int? pageIndex;

		private int? pageSize;

		private long? totalCount;

		private int? totalPage;

		private List<GetRefPackageJob_Job> jobs;

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

		public int? PageIndex
		{
			get
			{
				return pageIndex;
			}
			set	
			{
				pageIndex = value;
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

		public long? TotalCount
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

		public int? TotalPage
		{
			get
			{
				return totalPage;
			}
			set	
			{
				totalPage = value;
			}
		}

		public List<GetRefPackageJob_Job> Jobs
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

		public class GetRefPackageJob_Job
		{

			private string jobName;

			private string projectName;

			private string jobType;

			private string apiType;

			private string code;

			private string planJson;

			private string properties;

			private string packages;

			private bool? isCommitted;

			private string creator;

			private long? createTime;

			private string modifier;

			private long? modifyTime;

			private string description;

			private string engineVersion;

			private string clusterId;

			private string queueName;

			private long? folderId;

			private string jobId;

			public string JobName
			{
				get
				{
					return jobName;
				}
				set	
				{
					jobName = value;
				}
			}

			public string ProjectName
			{
				get
				{
					return projectName;
				}
				set	
				{
					projectName = value;
				}
			}

			public string JobType
			{
				get
				{
					return jobType;
				}
				set	
				{
					jobType = value;
				}
			}

			public string ApiType
			{
				get
				{
					return apiType;
				}
				set	
				{
					apiType = value;
				}
			}

			public string Code
			{
				get
				{
					return code;
				}
				set	
				{
					code = value;
				}
			}

			public string PlanJson
			{
				get
				{
					return planJson;
				}
				set	
				{
					planJson = value;
				}
			}

			public string Properties
			{
				get
				{
					return properties;
				}
				set	
				{
					properties = value;
				}
			}

			public string Packages
			{
				get
				{
					return packages;
				}
				set	
				{
					packages = value;
				}
			}

			public bool? IsCommitted
			{
				get
				{
					return isCommitted;
				}
				set	
				{
					isCommitted = value;
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

			public long? CreateTime
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

			public string Modifier
			{
				get
				{
					return modifier;
				}
				set	
				{
					modifier = value;
				}
			}

			public long? ModifyTime
			{
				get
				{
					return modifyTime;
				}
				set	
				{
					modifyTime = value;
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

			public string EngineVersion
			{
				get
				{
					return engineVersion;
				}
				set	
				{
					engineVersion = value;
				}
			}

			public string ClusterId
			{
				get
				{
					return clusterId;
				}
				set	
				{
					clusterId = value;
				}
			}

			public string QueueName
			{
				get
				{
					return queueName;
				}
				set	
				{
					queueName = value;
				}
			}

			public long? FolderId
			{
				get
				{
					return folderId;
				}
				set	
				{
					folderId = value;
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
		}
	}
}
