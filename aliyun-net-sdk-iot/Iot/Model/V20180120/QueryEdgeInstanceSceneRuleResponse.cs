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

namespace Aliyun.Acs.Iot.Model.V20180120
{
	public class QueryEdgeInstanceSceneRuleResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string errorMessage;

		private QueryEdgeInstanceSceneRule_Data data;

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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
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

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
			}
		}

		public QueryEdgeInstanceSceneRule_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class QueryEdgeInstanceSceneRule_Data
		{

			private int? total;

			private int? pageSize;

			private int? currentPage;

			private List<QueryEdgeInstanceSceneRule_Rule> ruleList;

			public int? Total
			{
				get
				{
					return total;
				}
				set	
				{
					total = value;
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

			public List<QueryEdgeInstanceSceneRule_Rule> RuleList
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

			public class QueryEdgeInstanceSceneRule_Rule
			{

				private string ruleId;

				private string ruleName;

				private long? gmtCreate;

				private int? status;

				private int? isExisted;

				public string RuleId
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

				public int? IsExisted
				{
					get
					{
						return isExisted;
					}
					set	
					{
						isExisted = value;
					}
				}
			}
		}
	}
}
