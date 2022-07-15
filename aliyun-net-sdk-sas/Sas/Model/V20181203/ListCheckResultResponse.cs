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

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class ListCheckResultResponse : AcsResponse
	{

		private string requestId;

		private List<ListCheckResult_ChecksItem> checks;

		private ListCheckResult_PageInfo pageInfo;

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

		public List<ListCheckResult_ChecksItem> Checks
		{
			get
			{
				return checks;
			}
			set	
			{
				checks = value;
			}
		}

		public ListCheckResult_PageInfo PageInfo
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

		public class ListCheckResult_ChecksItem
		{

			private long? checkId;

			private string checkShowName;

			private string vendor;

			private string vendorShowName;

			private string instanceType;

			private string instanceSubType;

			private string riskLevel;

			private string status;

			private string taskId;

			private long? lastCheckTime;

			private List<ListCheckResult_CheckPolicie> checkPolicies;

			public long? CheckId
			{
				get
				{
					return checkId;
				}
				set	
				{
					checkId = value;
				}
			}

			public string CheckShowName
			{
				get
				{
					return checkShowName;
				}
				set	
				{
					checkShowName = value;
				}
			}

			public string Vendor
			{
				get
				{
					return vendor;
				}
				set	
				{
					vendor = value;
				}
			}

			public string VendorShowName
			{
				get
				{
					return vendorShowName;
				}
				set	
				{
					vendorShowName = value;
				}
			}

			public string InstanceType
			{
				get
				{
					return instanceType;
				}
				set	
				{
					instanceType = value;
				}
			}

			public string InstanceSubType
			{
				get
				{
					return instanceSubType;
				}
				set	
				{
					instanceSubType = value;
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

			public string TaskId
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

			public long? LastCheckTime
			{
				get
				{
					return lastCheckTime;
				}
				set	
				{
					lastCheckTime = value;
				}
			}

			public List<ListCheckResult_CheckPolicie> CheckPolicies
			{
				get
				{
					return checkPolicies;
				}
				set	
				{
					checkPolicies = value;
				}
			}

			public class ListCheckResult_CheckPolicie
			{

				private long? standardId;

				private string standardShowName;

				private long? requirementId;

				private string requirementShowName;

				private long? sectionId;

				private string sectionShowName;

				public long? StandardId
				{
					get
					{
						return standardId;
					}
					set	
					{
						standardId = value;
					}
				}

				public string StandardShowName
				{
					get
					{
						return standardShowName;
					}
					set	
					{
						standardShowName = value;
					}
				}

				public long? RequirementId
				{
					get
					{
						return requirementId;
					}
					set	
					{
						requirementId = value;
					}
				}

				public string RequirementShowName
				{
					get
					{
						return requirementShowName;
					}
					set	
					{
						requirementShowName = value;
					}
				}

				public long? SectionId
				{
					get
					{
						return sectionId;
					}
					set	
					{
						sectionId = value;
					}
				}

				public string SectionShowName
				{
					get
					{
						return sectionShowName;
					}
					set	
					{
						sectionShowName = value;
					}
				}
			}
		}

		public class ListCheckResult_PageInfo
		{

			private int? currentPage;

			private int? pageSize;

			private string nextToken;

			private int? maxResults;

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

			public string NextToken
			{
				get
				{
					return nextToken;
				}
				set	
				{
					nextToken = value;
				}
			}

			public int? MaxResults
			{
				get
				{
					return maxResults;
				}
				set	
				{
					maxResults = value;
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
