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
	public class DescribeRuleCategoryResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeRuleCategory_Rule> ruleList;

		private List<DescribeRuleCategory_Product> productList;

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

		public List<DescribeRuleCategory_Rule> RuleList
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

		public List<DescribeRuleCategory_Product> ProductList
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

		public class DescribeRuleCategory_Rule
		{

			private string groupId;

			private string name;

			private List<DescribeRuleCategory_ChildRule> childList;

			public string GroupId
			{
				get
				{
					return groupId;
				}
				set	
				{
					groupId = value;
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

			public List<DescribeRuleCategory_ChildRule> ChildList
			{
				get
				{
					return childList;
				}
				set	
				{
					childList = value;
				}
			}

			public class DescribeRuleCategory_ChildRule
			{

				private long? id;

				private string groupId;

				private string name;

				private string parentId;

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

				public string GroupId
				{
					get
					{
						return groupId;
					}
					set	
					{
						groupId = value;
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

				public string ParentId
				{
					get
					{
						return parentId;
					}
					set	
					{
						parentId = value;
					}
				}
			}
		}

		public class DescribeRuleCategory_Product
		{

			private string _value;

			private string label;

			public string _Value
			{
				get
				{
					return _value;
				}
				set	
				{
					_value = value;
				}
			}

			public string Label
			{
				get
				{
					return label;
				}
				set	
				{
					label = value;
				}
			}
		}
	}
}
