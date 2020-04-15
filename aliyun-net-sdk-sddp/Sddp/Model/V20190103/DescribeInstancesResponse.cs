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
	public class DescribeInstancesResponse : AcsResponse
	{

		private string requestId;

		private int? pageSize;

		private int? currentPage;

		private int? totalCount;

		private List<DescribeInstances_Instance> items;

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

		public List<DescribeInstances_Instance> Items
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

		public class DescribeInstances_Instance
		{

			private long? id;

			private string name;

			private string owner;

			private long? creationTime;

			private string productId;

			private string productCode;

			private bool? protection;

			private bool? labelsec;

			private string odpsRiskLevelName;

			private bool? sensitive;

			private long? riskLevelId;

			private string riskLevelName;

			private string ruleName;

			private string departName;

			private int? totalCount;

			private int? sensitiveCount;

			private string acl;

			private int? s2Count;

			private int? s3Count;

			private long? lastFinishTime;

			private string regionName;

			private string regionId;

			private string engineType;

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

			public bool? Protection
			{
				get
				{
					return protection;
				}
				set	
				{
					protection = value;
				}
			}

			public bool? Labelsec
			{
				get
				{
					return labelsec;
				}
				set	
				{
					labelsec = value;
				}
			}

			public string OdpsRiskLevelName
			{
				get
				{
					return odpsRiskLevelName;
				}
				set	
				{
					odpsRiskLevelName = value;
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

			public string RuleName
			{
				get
				{
					return ruleName;
				}
				set	
				{
					ruleName = value;
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

			public string Acl
			{
				get
				{
					return acl;
				}
				set	
				{
					acl = value;
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

			public long? LastFinishTime
			{
				get
				{
					return lastFinishTime;
				}
				set	
				{
					lastFinishTime = value;
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

			public string EngineType
			{
				get
				{
					return engineType;
				}
				set	
				{
					engineType = value;
				}
			}
		}
	}
}
