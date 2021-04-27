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
	public class DescribeGroupedInstancesResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeGroupedInstances_Instance> instances;

		private DescribeGroupedInstances_PageInfo pageInfo;

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

		public List<DescribeGroupedInstances_Instance> Instances
		{
			get
			{
				return instances;
			}
			set	
			{
				instances = value;
			}
		}

		public DescribeGroupedInstances_PageInfo PageInfo
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

		public class DescribeGroupedInstances_Instance
		{

			private string unProtectedInstanceCount;

			private string fieldAliasName;

			private int? groupFlag;

			private long? fieldId;

			private string riskInstanceCount;

			private string instanceCount;

			private long? asapVulInstanceCount;

			private List<string> groupPath;

			public string UnProtectedInstanceCount
			{
				get
				{
					return unProtectedInstanceCount;
				}
				set	
				{
					unProtectedInstanceCount = value;
				}
			}

			public string FieldAliasName
			{
				get
				{
					return fieldAliasName;
				}
				set	
				{
					fieldAliasName = value;
				}
			}

			public int? GroupFlag
			{
				get
				{
					return groupFlag;
				}
				set	
				{
					groupFlag = value;
				}
			}

			public long? FieldId
			{
				get
				{
					return fieldId;
				}
				set	
				{
					fieldId = value;
				}
			}

			public string RiskInstanceCount
			{
				get
				{
					return riskInstanceCount;
				}
				set	
				{
					riskInstanceCount = value;
				}
			}

			public string InstanceCount
			{
				get
				{
					return instanceCount;
				}
				set	
				{
					instanceCount = value;
				}
			}

			public long? AsapVulInstanceCount
			{
				get
				{
					return asapVulInstanceCount;
				}
				set	
				{
					asapVulInstanceCount = value;
				}
			}

			public List<string> GroupPath
			{
				get
				{
					return groupPath;
				}
				set	
				{
					groupPath = value;
				}
			}
		}

		public class DescribeGroupedInstances_PageInfo
		{

			private int? count;

			private int? pageSize;

			private int? totalCount;

			private int? currentPage;

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
		}
	}
}
