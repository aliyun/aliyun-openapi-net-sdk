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

namespace Aliyun.Acs.NAS.Model.V20170626
{
	public class DescribeLifecyclePoliciesResponse : AcsResponse
	{

		private int? totalCount;

		private string requestId;

		private int? pageSize;

		private int? pageNumber;

		private List<DescribeLifecyclePolicies_LifecyclePolicy> lifecyclePolicies;

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

		public List<DescribeLifecyclePolicies_LifecyclePolicy> LifecyclePolicies
		{
			get
			{
				return lifecyclePolicies;
			}
			set	
			{
				lifecyclePolicies = value;
			}
		}

		public class DescribeLifecyclePolicies_LifecyclePolicy
		{

			private string fileSystemId;

			private string lifecycleRuleName;

			private string createTime;

			private string path;

			private string storageType;

			private string lifecyclePolicyName;

			private List<string> paths;

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

			public string LifecycleRuleName
			{
				get
				{
					return lifecycleRuleName;
				}
				set	
				{
					lifecycleRuleName = value;
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

			public string Path
			{
				get
				{
					return path;
				}
				set	
				{
					path = value;
				}
			}

			public string StorageType
			{
				get
				{
					return storageType;
				}
				set	
				{
					storageType = value;
				}
			}

			public string LifecyclePolicyName
			{
				get
				{
					return lifecyclePolicyName;
				}
				set	
				{
					lifecyclePolicyName = value;
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
