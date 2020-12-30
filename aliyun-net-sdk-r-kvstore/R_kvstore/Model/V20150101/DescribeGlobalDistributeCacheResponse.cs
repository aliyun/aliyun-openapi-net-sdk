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

namespace Aliyun.Acs.R_kvstore.Model.V20150101
{
	public class DescribeGlobalDistributeCacheResponse : AcsResponse
	{

		private string requestId;

		private int? totalRecordCount;

		private int? pageNumber;

		private int? pageSize;

		private List<DescribeGlobalDistributeCache_GlobalDistributeCache> globalDistributeCaches;

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

		public int? TotalRecordCount
		{
			get
			{
				return totalRecordCount;
			}
			set	
			{
				totalRecordCount = value;
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

		public List<DescribeGlobalDistributeCache_GlobalDistributeCache> GlobalDistributeCaches
		{
			get
			{
				return globalDistributeCaches;
			}
			set	
			{
				globalDistributeCaches = value;
			}
		}

		public class DescribeGlobalDistributeCache_GlobalDistributeCache
		{

			private string globalInstanceId;

			private string globalInstanceName;

			private string status;

			private List<DescribeGlobalDistributeCache_SubInstance> subInstances;

			public string GlobalInstanceId
			{
				get
				{
					return globalInstanceId;
				}
				set	
				{
					globalInstanceId = value;
				}
			}

			public string GlobalInstanceName
			{
				get
				{
					return globalInstanceName;
				}
				set	
				{
					globalInstanceName = value;
				}
			}

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

			public List<DescribeGlobalDistributeCache_SubInstance> SubInstances
			{
				get
				{
					return subInstances;
				}
				set	
				{
					subInstances = value;
				}
			}

			public class DescribeGlobalDistributeCache_SubInstance
			{

				private string globalInstanceId;

				private string instanceID;

				private string regionId;

				private string instanceStatus;

				private string instanceClass;

				public string GlobalInstanceId
				{
					get
					{
						return globalInstanceId;
					}
					set	
					{
						globalInstanceId = value;
					}
				}

				public string InstanceID
				{
					get
					{
						return instanceID;
					}
					set	
					{
						instanceID = value;
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

				public string InstanceStatus
				{
					get
					{
						return instanceStatus;
					}
					set	
					{
						instanceStatus = value;
					}
				}

				public string InstanceClass
				{
					get
					{
						return instanceClass;
					}
					set	
					{
						instanceClass = value;
					}
				}
			}
		}
	}
}
