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

namespace Aliyun.Acs.Sddp.Model.V20190103
{
	public class DescribeTablesResponse : AcsResponse
	{

		private string requestId;

		private int? pageSize;

		private int? currentPage;

		private int? totalCount;

		private List<DescribeTables_Table> items;

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

			private long? id;

			private string name;

			private string owner;

			private long? creationTime;

			private string productId;

			private string productCode;

			private bool? sensitive;

			private long? riskLevelId;

			private string riskLevelName;

			private string departName;

			private int? totalCount;

			private int? sensitiveCount;

			private string sensitiveRatio;

			private long? instanceId;

			private int? s2Count;

			private int? s3Count;

			private int? totalRows;

			private long? lastScanTime;

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
		}
	}
}
