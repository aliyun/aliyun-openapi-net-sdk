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
	public class DescribeCategoryTemplateRuleListResponse : AcsResponse
	{

		private int? currentPage;

		private string requestId;

		private int? pageSize;

		private int? totalCount;

		private List<DescribeCategoryTemplateRuleList_DataLimit> items;

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

		public List<DescribeCategoryTemplateRuleList_DataLimit> Items
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

		public class DescribeCategoryTemplateRuleList_DataLimit
		{

			private int? status;

			private string identificationScope;

			private long? riskLevelId;

			private long? parentCategoryId;

			private string description;

			private int? customType;

			private string identificationRuleIds;

			private string name;

			private int? orderNum;

			private long? templateId;

			private long? id;

			private int? categoryLevel;

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

			public string IdentificationScope
			{
				get
				{
					return identificationScope;
				}
				set	
				{
					identificationScope = value;
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

			public long? ParentCategoryId
			{
				get
				{
					return parentCategoryId;
				}
				set	
				{
					parentCategoryId = value;
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

			public string IdentificationRuleIds
			{
				get
				{
					return identificationRuleIds;
				}
				set	
				{
					identificationRuleIds = value;
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

			public int? OrderNum
			{
				get
				{
					return orderNum;
				}
				set	
				{
					orderNum = value;
				}
			}

			public long? TemplateId
			{
				get
				{
					return templateId;
				}
				set	
				{
					templateId = value;
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

			public int? CategoryLevel
			{
				get
				{
					return categoryLevel;
				}
				set	
				{
					categoryLevel = value;
				}
			}
		}
	}
}
