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

namespace Aliyun.Acs.quotas.Model.V20200510
{
	public class ListProductQuotaDimensionsResponse : AcsResponse
	{

		private int? totalCount;

		private string nextToken;

		private string requestId;

		private int? maxResults;

		private List<ListProductQuotaDimensions_QuotaDimensionsItem> quotaDimensions;

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

		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
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

		public int? MaxResults
		{
			get
			{
				return maxResults;
			}
			set	
			{
				maxResults = value;
			}
		}

		public List<ListProductQuotaDimensions_QuotaDimensionsItem> QuotaDimensions
		{
			get
			{
				return quotaDimensions;
			}
			set	
			{
				quotaDimensions = value;
			}
		}

		public class ListProductQuotaDimensions_QuotaDimensionsItem
		{

			private bool? requisite;

			private string dimensionKey;

			private string name;

			private List<ListProductQuotaDimensions_DimensionValueDetailItem> dimensionValueDetail;

			private List<string> dependentDimensions;

			private List<string> dimensionValues;

			public bool? Requisite
			{
				get
				{
					return requisite;
				}
				set	
				{
					requisite = value;
				}
			}

			public string DimensionKey
			{
				get
				{
					return dimensionKey;
				}
				set	
				{
					dimensionKey = value;
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

			public List<ListProductQuotaDimensions_DimensionValueDetailItem> DimensionValueDetail
			{
				get
				{
					return dimensionValueDetail;
				}
				set	
				{
					dimensionValueDetail = value;
				}
			}

			public List<string> DependentDimensions
			{
				get
				{
					return dependentDimensions;
				}
				set	
				{
					dependentDimensions = value;
				}
			}

			public List<string> DimensionValues
			{
				get
				{
					return dimensionValues;
				}
				set	
				{
					dimensionValues = value;
				}
			}

			public class ListProductQuotaDimensions_DimensionValueDetailItem
			{

				private string name;

				private string _value;

				private List<ListProductQuotaDimensions_DependentDimension> dependentDimensions1;

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

				public List<ListProductQuotaDimensions_DependentDimension> DependentDimensions1
				{
					get
					{
						return dependentDimensions1;
					}
					set	
					{
						dependentDimensions1 = value;
					}
				}

				public class ListProductQuotaDimensions_DependentDimension
				{

					private string key;

					private string _value;

					public string Key
					{
						get
						{
							return key;
						}
						set	
						{
							key = value;
						}
					}

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
				}
			}
		}
	}
}
