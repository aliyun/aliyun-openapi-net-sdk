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
	public class DescribeDataObjectColumnDetailV2Response : AcsResponse
	{

		private int? currentPage;

		private string requestId;

		private int? pageSize;

		private int? totalCount;

		private List<DescribeDataObjectColumnDetailV2_Rule> items;

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

		public List<DescribeDataObjectColumnDetailV2_Rule> Items
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

		public class DescribeDataObjectColumnDetailV2_Rule
		{

			private string columnName;

			private string dataType;

			private string columnComment;

			private bool? primaryKey;

			private string id;

			private long? riskLevelId;

			private string riskLevelName;

			private long? ruleId;

			private string ruleName;

			private List<DescribeDataObjectColumnDetailV2_ModelTagsItem> modelTags;

			private List<string> categories;

			public string ColumnName
			{
				get
				{
					return columnName;
				}
				set	
				{
					columnName = value;
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

			public string ColumnComment
			{
				get
				{
					return columnComment;
				}
				set	
				{
					columnComment = value;
				}
			}

			public bool? PrimaryKey
			{
				get
				{
					return primaryKey;
				}
				set	
				{
					primaryKey = value;
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

			public long? RuleId
			{
				get
				{
					return ruleId;
				}
				set	
				{
					ruleId = value;
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

			public List<DescribeDataObjectColumnDetailV2_ModelTagsItem> ModelTags
			{
				get
				{
					return modelTags;
				}
				set	
				{
					modelTags = value;
				}
			}

			public List<string> Categories
			{
				get
				{
					return categories;
				}
				set	
				{
					categories = value;
				}
			}

			public class DescribeDataObjectColumnDetailV2_ModelTagsItem
			{

				private long? id;

				private string name;

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
			}
		}
	}
}
