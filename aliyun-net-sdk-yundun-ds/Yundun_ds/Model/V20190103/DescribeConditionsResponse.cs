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

namespace Aliyun.Acs.Yundun_ds.Model.V20190103
{
	public class DescribeConditionsResponse : AcsResponse
	{

		private string requestId;

		private DescribeConditions_Condition condition;

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

		public DescribeConditions_Condition Condition
		{
			get
			{
				return condition;
			}
			set	
			{
				condition = value;
			}
		}

		public class DescribeConditions_Condition
		{

			private List<DescribeConditions_RiskLevel> riskLevelList;

			private List<DescribeConditions_Rule> ruleList;

			private List<DescribeConditions_Range> rangeList;

			private List<DescribeConditions_EventType> eventTypeList;

			private List<DescribeConditions_Status> statusList;

			private List<DescribeConditions_DataType> dataTypeList;

			private List<DescribeConditions_Operation> operationList;

			private List<DescribeConditions_Product> productList;

			private List<DescribeConditions_TransferProduct> transferProductList;

			private List<DescribeConditions_RuleCategory> ruleCategoryList;

			public List<DescribeConditions_RiskLevel> RiskLevelList
			{
				get
				{
					return riskLevelList;
				}
				set	
				{
					riskLevelList = value;
				}
			}

			public List<DescribeConditions_Rule> RuleList
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

			public List<DescribeConditions_Range> RangeList
			{
				get
				{
					return rangeList;
				}
				set	
				{
					rangeList = value;
				}
			}

			public List<DescribeConditions_EventType> EventTypeList
			{
				get
				{
					return eventTypeList;
				}
				set	
				{
					eventTypeList = value;
				}
			}

			public List<DescribeConditions_Status> StatusList
			{
				get
				{
					return statusList;
				}
				set	
				{
					statusList = value;
				}
			}

			public List<DescribeConditions_DataType> DataTypeList
			{
				get
				{
					return dataTypeList;
				}
				set	
				{
					dataTypeList = value;
				}
			}

			public List<DescribeConditions_Operation> OperationList
			{
				get
				{
					return operationList;
				}
				set	
				{
					operationList = value;
				}
			}

			public List<DescribeConditions_Product> ProductList
			{
				get
				{
					return productList;
				}
				set	
				{
					productList = value;
				}
			}

			public List<DescribeConditions_TransferProduct> TransferProductList
			{
				get
				{
					return transferProductList;
				}
				set	
				{
					transferProductList = value;
				}
			}

			public List<DescribeConditions_RuleCategory> RuleCategoryList
			{
				get
				{
					return ruleCategoryList;
				}
				set	
				{
					ruleCategoryList = value;
				}
			}

			public class DescribeConditions_RiskLevel
			{

				private long? id;

				private string name;

				private bool? defaulted;

				private bool? sensitive;

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

				public bool? Defaulted
				{
					get
					{
						return defaulted;
					}
					set	
					{
						defaulted = value;
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
			}

			public class DescribeConditions_Rule
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

			public class DescribeConditions_Range
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

			public class DescribeConditions_EventType
			{

				private long? id;

				private string name;

				private string code;

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

				public string Code
				{
					get
					{
						return code;
					}
					set	
					{
						code = value;
					}
				}
			}

			public class DescribeConditions_Status
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

			public class DescribeConditions_DataType
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

			public class DescribeConditions_Operation
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

			public class DescribeConditions_Product
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

			public class DescribeConditions_TransferProduct
			{

				private string code;

				private int? status;

				public string Code
				{
					get
					{
						return code;
					}
					set	
					{
						code = value;
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
			}

			public class DescribeConditions_RuleCategory
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
