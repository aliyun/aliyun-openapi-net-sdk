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
	public class DescribeRulesResponse : AcsResponse
	{

		private string requestId;

		private int? pageSize;

		private int? currentPage;

		private int? totalCount;

		private List<DescribeRules_Rule> items;

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

		public List<DescribeRules_Rule> Items
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

		public class DescribeRules_Rule
		{

			private long? id;

			private long? gmtCreate;

			private long? gmtModified;

			private int? customType;

			private string name;

			private string description;

			private long? userId;

			private string loginName;

			private string displayName;

			private int? category;

			private string categoryName;

			private int? status;

			private string riskLevelName;

			private long? riskLevelId;

			private string content;

			private string departName;

			private string statExpress;

			private long? productId;

			private int? hitTotalCount;

			private string productCode;

			private int? warnLevel;

			private string majorKey;

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

			public long? GmtCreate
			{
				get
				{
					return gmtCreate;
				}
				set	
				{
					gmtCreate = value;
				}
			}

			public long? GmtModified
			{
				get
				{
					return gmtModified;
				}
				set	
				{
					gmtModified = value;
				}
			}

			public int? CustomType
			{
				get
				{
					return customType;
				}
				set	
				{
					customType = value;
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

			public long? UserId
			{
				get
				{
					return userId;
				}
				set	
				{
					userId = value;
				}
			}

			public string LoginName
			{
				get
				{
					return loginName;
				}
				set	
				{
					loginName = value;
				}
			}

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

			public int? Category
			{
				get
				{
					return category;
				}
				set	
				{
					category = value;
				}
			}

			public string CategoryName
			{
				get
				{
					return categoryName;
				}
				set	
				{
					categoryName = value;
				}
			}

			public int? Status
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

			public string Content
			{
				get
				{
					return content;
				}
				set	
				{
					content = value;
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

			public string StatExpress
			{
				get
				{
					return statExpress;
				}
				set	
				{
					statExpress = value;
				}
			}

			public long? ProductId
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

			public int? HitTotalCount
			{
				get
				{
					return hitTotalCount;
				}
				set	
				{
					hitTotalCount = value;
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

			public int? WarnLevel
			{
				get
				{
					return warnLevel;
				}
				set	
				{
					warnLevel = value;
				}
			}

			public string MajorKey
			{
				get
				{
					return majorKey;
				}
				set	
				{
					majorKey = value;
				}
			}
		}
	}
}
