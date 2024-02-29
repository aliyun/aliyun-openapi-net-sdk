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
	public class DescribeDataObjectsResponse : AcsResponse
	{

		private int? currentPage;

		private string requestId;

		private int? pageSize;

		private int? totalCount;

		private List<DescribeDataObjects_Rule> items;

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

		public List<DescribeDataObjects_Rule> Items
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

		public class DescribeDataObjects_Rule
		{

			private string name;

			private string id;

			private long? templateId;

			private long? productId;

			private string instanceDescription;

			private string productCode;

			private string instanceId;

			private long? lastScanTime;

			private int? sensitiveCount;

			private string objectType;

			private string path;

			private string regionName;

			private string objectFileCategory;

			private List<DescribeDataObjects_ModelTagsItem> modelTags;

			private List<DescribeDataObjects_RuleListItem> ruleList;

			private List<string> categories;

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

			public string InstanceId
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

			public string ObjectType
			{
				get
				{
					return objectType;
				}
				set	
				{
					objectType = value;
				}
			}

			public string Path
			{
				get
				{
					return path;
				}
				set	
				{
					path = value;
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

			public string ObjectFileCategory
			{
				get
				{
					return objectFileCategory;
				}
				set	
				{
					objectFileCategory = value;
				}
			}

			public List<DescribeDataObjects_ModelTagsItem> ModelTags
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

			public List<DescribeDataObjects_RuleListItem> RuleList
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

			public class DescribeDataObjects_ModelTagsItem
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

			public class DescribeDataObjects_RuleListItem
			{

				private long? ruleId;

				private string ruleName;

				private long? riskLevelId;

				private string riskLevelName;

				private int? ruleCount;

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

				public int? RuleCount
				{
					get
					{
						return ruleCount;
					}
					set	
					{
						ruleCount = value;
					}
				}
			}
		}
	}
}
