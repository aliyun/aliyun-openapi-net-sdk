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
	public class DescribeRiskCheckResultResponse : AcsResponse
	{

		private string requestId;

		private int? pageCount;

		private int? count;

		private int? pageSize;

		private int? totalCount;

		private int? currentPage;

		private List<DescribeRiskCheckResult_RiskCheckResultForDisplay> list;

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

		public int? PageCount
		{
			get
			{
				return pageCount;
			}
			set	
			{
				pageCount = value;
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

		public List<DescribeRiskCheckResult_RiskCheckResultForDisplay> List
		{
			get
			{
				return list;
			}
			set	
			{
				list = value;
			}
		}

		public class DescribeRiskCheckResult_RiskCheckResultForDisplay
		{

			private long? itemId;

			private long? taskId;

			private string title;

			private string riskLevel;

			private string status;

			private int? affectedCount;

			private long? checkTime;

			private int? remainingTime;

			private int? sort;

			private string type;

			private string startStatus;

			private string repairStatus;

			private string riskAssertType;

			private List<DescribeRiskCheckResult_RiskItemResource> riskItemResources;

			public long? ItemId
			{
				get
				{
					return itemId;
				}
				set	
				{
					itemId = value;
				}
			}

			public long? TaskId
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

			public string Title
			{
				get
				{
					return title;
				}
				set	
				{
					title = value;
				}
			}

			public string RiskLevel
			{
				get
				{
					return riskLevel;
				}
				set	
				{
					riskLevel = value;
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

			public int? AffectedCount
			{
				get
				{
					return affectedCount;
				}
				set	
				{
					affectedCount = value;
				}
			}

			public long? CheckTime
			{
				get
				{
					return checkTime;
				}
				set	
				{
					checkTime = value;
				}
			}

			public int? RemainingTime
			{
				get
				{
					return remainingTime;
				}
				set	
				{
					remainingTime = value;
				}
			}

			public int? Sort
			{
				get
				{
					return sort;
				}
				set	
				{
					sort = value;
				}
			}

			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}

			public string StartStatus
			{
				get
				{
					return startStatus;
				}
				set	
				{
					startStatus = value;
				}
			}

			public string RepairStatus
			{
				get
				{
					return repairStatus;
				}
				set	
				{
					repairStatus = value;
				}
			}

			public string RiskAssertType
			{
				get
				{
					return riskAssertType;
				}
				set	
				{
					riskAssertType = value;
				}
			}

			public List<DescribeRiskCheckResult_RiskItemResource> RiskItemResources
			{
				get
				{
					return riskItemResources;
				}
				set	
				{
					riskItemResources = value;
				}
			}

			public class DescribeRiskCheckResult_RiskItemResource
			{

				private string resourceName;

				private string contentResource;

				public string ResourceName
				{
					get
					{
						return resourceName;
					}
					set	
					{
						resourceName = value;
					}
				}

				public string ContentResource
				{
					get
					{
						return contentResource;
					}
					set	
					{
						contentResource = value;
					}
				}
			}
		}
	}
}
