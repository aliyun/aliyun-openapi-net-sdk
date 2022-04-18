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

namespace Aliyun.Acs.Sddp.Model.V20190103
{
	public class DescribeTablesResponse : AcsResponse
	{

		private int? currentPage;

		private string requestId;

		private int? pageSize;

		private int? totalCount;

		private List<DescribeTables_Table> items;

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

		public List<DescribeTables_Table> Items
		{
			get
			{
				return items;
			}
			set	
			{
				items = value;
			}
		}

		public class DescribeTables_Table
		{

			private long? creationTime;

			private string owner;

			private string countDetails;

			private string sensitiveRatio;

			private string tenantName;

			private string departName;

			private long? riskLevelId;

			private string instanceName;

			private int? s3Count;

			private int? s1Count;

			private string productId;

			private string name;

			private int? s2Count;

			private long? instanceId;

			private int? totalCount;

			private string instanceDescription;

			private bool? sensitive;

			private string sensLevelName;

			private long? lastScanTime;

			private string regionName;

			private string riskLevelName;

			private int? totalRows;

			private int? sensitiveCount;

			private long? id;

			private string productCode;

			private string objectHex;

			private int? dataType;

			private List<DescribeTables_Rule> ruleList;

			public long? CreationTime
			{
				get
				{
					return creationTime;
				}
				set	
				{
					creationTime = value;
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

			public string CountDetails
			{
				get
				{
					return countDetails;
				}
				set	
				{
					countDetails = value;
				}
			}

			public string SensitiveRatio
			{
				get
				{
					return sensitiveRatio;
				}
				set	
				{
					sensitiveRatio = value;
				}
			}

			public string TenantName
			{
				get
				{
					return tenantName;
				}
				set	
				{
					tenantName = value;
				}
			}

			public string DepartName
			{
				get
				{
					return departName;
				}
				set	
				{
					departName = value;
				}
			}

			public long? RiskLevelId
			{
				get
				{
					return riskLevelId;
				}
				set	
				{
					riskLevelId = value;
				}
			}

			public string InstanceName
			{
				get
				{
					return instanceName;
				}
				set	
				{
					instanceName = value;
				}
			}

			public int? S3Count
			{
				get
				{
					return s3Count;
				}
				set	
				{
					s3Count = value;
				}
			}

			public int? S1Count
			{
				get
				{
					return s1Count;
				}
				set	
				{
					s1Count = value;
				}
			}

			public string ProductId
			{
				get
				{
					return productId;
				}
				set	
				{
					productId = value;
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

			public int? S2Count
			{
				get
				{
					return s2Count;
				}
				set	
				{
					s2Count = value;
				}
			}

			public long? InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
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

			public string InstanceDescription
			{
				get
				{
					return instanceDescription;
				}
				set	
				{
					instanceDescription = value;
				}
			}

			public bool? Sensitive
			{
				get
				{
					return sensitive;
				}
				set	
				{
					sensitive = value;
				}
			}

			public string SensLevelName
			{
				get
				{
					return sensLevelName;
				}
				set	
				{
					sensLevelName = value;
				}
			}

			public long? LastScanTime
			{
				get
				{
					return lastScanTime;
				}
				set	
				{
					lastScanTime = value;
				}
			}

			public string RegionName
			{
				get
				{
					return regionName;
				}
				set	
				{
					regionName = value;
				}
			}

			public string RiskLevelName
			{
				get
				{
					return riskLevelName;
				}
				set	
				{
					riskLevelName = value;
				}
			}

			public int? TotalRows
			{
				get
				{
					return totalRows;
				}
				set	
				{
					totalRows = value;
				}
			}

			public int? SensitiveCount
			{
				get
				{
					return sensitiveCount;
				}
				set	
				{
					sensitiveCount = value;
				}
			}

			public long? Id
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

			public string ProductCode
			{
				get
				{
					return productCode;
				}
				set	
				{
					productCode = value;
				}
			}

			public string ObjectHex
			{
				get
				{
					return objectHex;
				}
				set	
				{
					objectHex = value;
				}
			}

			public int? DataType
			{
				get
				{
					return dataType;
				}
				set	
				{
					dataType = value;
				}
			}

			public List<DescribeTables_Rule> RuleList
			{
				get
				{
					return ruleList;
				}
				set	
				{
					ruleList = value;
				}
			}

			public class DescribeTables_Rule
			{

				private string displayName;

				private string name;

				private long? riskLevelId;

				private long? count;

				public string DisplayName
				{
					get
					{
						return displayName;
					}
					set	
					{
						displayName = value;
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

				public long? RiskLevelId
				{
					get
					{
						return riskLevelId;
					}
					set	
					{
						riskLevelId = value;
					}
				}

				public long? Count
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
}
