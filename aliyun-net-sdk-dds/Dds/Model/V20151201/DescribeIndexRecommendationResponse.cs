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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Dds.Model.V20151201
{
	public class DescribeIndexRecommendationResponse : AcsResponse
	{

		private string requestId;

		private int? totalRecordCount;

		private int? pageNumber;

		private int? pageRecordCount;

		private List<DescribeIndexRecommendation_Analyzation> analyzations;

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

		public int? TotalRecordCount
		{
			get
			{
				return totalRecordCount;
			}
			set	
			{
				totalRecordCount = value;
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public int? PageRecordCount
		{
			get
			{
				return pageRecordCount;
			}
			set	
			{
				pageRecordCount = value;
			}
		}

		public List<DescribeIndexRecommendation_Analyzation> Analyzations
		{
			get
			{
				return analyzations;
			}
			set	
			{
				analyzations = value;
			}
		}

		public class DescribeIndexRecommendation_Analyzation
		{

			private string database;

			private string _namespace;

			private string operation;

			private string query;

			private string sort;

			private long? count;

			private long? totalExecutionTime;

			private long? averageExecutionTime;

			private long? averageReturnRowCount;

			private long? averageDocsExaminedCount;

			private long? averageKeysExaminedCount;

			private string inMemorySort;

			private string lastExecutionTime;

			private string executionPlan;

			private List<DescribeIndexRecommendation_Recommendation> indexRecommendations;

			private List<string> indexCombines;

			public string Database
			{
				get
				{
					return database;
				}
				set	
				{
					database = value;
				}
			}

			public string _Namespace
			{
				get
				{
					return _namespace;
				}
				set	
				{
					_namespace = value;
				}
			}

			public string Operation
			{
				get
				{
					return operation;
				}
				set	
				{
					operation = value;
				}
			}

			public string Query
			{
				get
				{
					return query;
				}
				set	
				{
					query = value;
				}
			}

			public string Sort
			{
				get
				{
					return sort;
				}
				set	
				{
					sort = value;
				}
			}

			public long? Count
			{
				get
				{
					return count;
				}
				set	
				{
					count = value;
				}
			}

			public long? TotalExecutionTime
			{
				get
				{
					return totalExecutionTime;
				}
				set	
				{
					totalExecutionTime = value;
				}
			}

			public long? AverageExecutionTime
			{
				get
				{
					return averageExecutionTime;
				}
				set	
				{
					averageExecutionTime = value;
				}
			}

			public long? AverageReturnRowCount
			{
				get
				{
					return averageReturnRowCount;
				}
				set	
				{
					averageReturnRowCount = value;
				}
			}

			public long? AverageDocsExaminedCount
			{
				get
				{
					return averageDocsExaminedCount;
				}
				set	
				{
					averageDocsExaminedCount = value;
				}
			}

			public long? AverageKeysExaminedCount
			{
				get
				{
					return averageKeysExaminedCount;
				}
				set	
				{
					averageKeysExaminedCount = value;
				}
			}

			public string InMemorySort
			{
				get
				{
					return inMemorySort;
				}
				set	
				{
					inMemorySort = value;
				}
			}

			public string LastExecutionTime
			{
				get
				{
					return lastExecutionTime;
				}
				set	
				{
					lastExecutionTime = value;
				}
			}

			public string ExecutionPlan
			{
				get
				{
					return executionPlan;
				}
				set	
				{
					executionPlan = value;
				}
			}

			public List<DescribeIndexRecommendation_Recommendation> IndexRecommendations
			{
				get
				{
					return indexRecommendations;
				}
				set	
				{
					indexRecommendations = value;
				}
			}

			public List<string> IndexCombines
			{
				get
				{
					return indexCombines;
				}
				set	
				{
					indexCombines = value;
				}
			}

			public class DescribeIndexRecommendation_Recommendation
			{

				private string recmdType;

				private string content;

				public string RecmdType
				{
					get
					{
						return recmdType;
					}
					set	
					{
						recmdType = value;
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
			}
		}
	}
}