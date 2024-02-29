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
	public class DescribeColumnsV2Response : AcsResponse
	{

		private int? currentPage;

		private string requestId;

		private int? pageSize;

		private int? totalCount;

		private List<DescribeColumnsV2_Column> items;

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

		public List<DescribeColumnsV2_Column> Items
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

		public class DescribeColumnsV2_Column
		{

			private long? creationTime;

			private string tableName;

			private string dataType;

			private int? odpsRiskLevelValue;

			private string departName;

			private long? instanceId;

			private long? riskLevelId;

			private string ruleName;

			private long? ruleId;

			private bool? sensitive;

			private string sensLevelName;

			private string instanceName;

			private string riskLevelName;

			private string odpsRiskLevelName;

			private string name;

			private long? tableId;

			private string id;

			private string productCode;

			private long? revisionStatus;

			private long? revisionId;

			private List<DescribeColumnsV2_ModelTagsItem> modelTags;

			private List<string> sampleList;

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

			public string TableName
			{
				get
				{
					return tableName;
				}
				set	
				{
					tableName = value;
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

			public int? OdpsRiskLevelValue
			{
				get
				{
					return odpsRiskLevelValue;
				}
				set	
				{
					odpsRiskLevelValue = value;
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

			public long? TableId
			{
				get
				{
					return tableId;
				}
				set	
				{
					tableId = value;
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

			public long? RevisionStatus
			{
				get
				{
					return revisionStatus;
				}
				set	
				{
					revisionStatus = value;
				}
			}

			public long? RevisionId
			{
				get
				{
					return revisionId;
				}
				set	
				{
					revisionId = value;
				}
			}

			public List<DescribeColumnsV2_ModelTagsItem> ModelTags
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

			public List<string> SampleList
			{
				get
				{
					return sampleList;
				}
				set	
				{
					sampleList = value;
				}
			}

			public class DescribeColumnsV2_ModelTagsItem
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
