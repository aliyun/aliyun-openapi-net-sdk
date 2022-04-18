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
	public class DescribeDataAssetsResponse : AcsResponse
	{

		private int? currentPage;

		private string requestId;

		private int? pageSize;

		private int? totalCount;

		private List<DescribeDataAssets_Asset> items;

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

		public List<DescribeDataAssets_Asset> Items
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

		public class DescribeDataAssets_Asset
		{

			private string acl;

			private long? creationTime;

			private string dataType;

			private string owner;

			private string sensitiveRatio;

			private bool? protection;

			private string departName;

			private bool? labelsec;

			private int? totalCount;

			private long? riskLevelId;

			private string ruleName;

			private bool? sensitive;

			private string objectKey;

			private string riskLevelName;

			private string odpsRiskLevelName;

			private string productId;

			private string name;

			private int? sensitiveCount;

			private string id;

			private string productCode;

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

			public string DataType
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

			public string ObjectKey
			{
				get
				{
					return objectKey;
				}
				set	
				{
					objectKey = value;
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

			public string Id
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
		}
	}
}
