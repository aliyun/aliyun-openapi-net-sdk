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

namespace Aliyun.Acs.Market.Model.V20151101
{
	public class DescribeDistributionProductsResponse : AcsResponse
	{

		private string requestId;

		private int? pageNumber;

		private int? pageSize;

		private int? totalCount;

		private List<DescribeDistributionProducts_Result> results;

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

		public List<DescribeDistributionProducts_Result> Results
		{
			get
			{
				return results;
			}
			set	
			{
				results = value;
			}
		}

		public class DescribeDistributionProducts_Result
		{

			private string firstCategoryName;

			private string secondCategoryName;

			private string type;

			private string imageUrl;

			private string code;

			private string name;

			private string shortDescription;

			private string price;

			private string score;

			private string tradeCount;

			private string userCommentCount;

			private string submissionRadio;

			private string supplierName;

			private string supplierUId;

			public string FirstCategoryName
			{
				get
				{
					return firstCategoryName;
				}
				set	
				{
					firstCategoryName = value;
				}
			}

			public string SecondCategoryName
			{
				get
				{
					return secondCategoryName;
				}
				set	
				{
					secondCategoryName = value;
				}
			}

			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}

			public string ImageUrl
			{
				get
				{
					return imageUrl;
				}
				set	
				{
					imageUrl = value;
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

			public string ShortDescription
			{
				get
				{
					return shortDescription;
				}
				set	
				{
					shortDescription = value;
				}
			}

			public string Price
			{
				get
				{
					return price;
				}
				set	
				{
					price = value;
				}
			}

			public string Score
			{
				get
				{
					return score;
				}
				set	
				{
					score = value;
				}
			}

			public string TradeCount
			{
				get
				{
					return tradeCount;
				}
				set	
				{
					tradeCount = value;
				}
			}

			public string UserCommentCount
			{
				get
				{
					return userCommentCount;
				}
				set	
				{
					userCommentCount = value;
				}
			}

			public string SubmissionRadio
			{
				get
				{
					return submissionRadio;
				}
				set	
				{
					submissionRadio = value;
				}
			}

			public string SupplierName
			{
				get
				{
					return supplierName;
				}
				set	
				{
					supplierName = value;
				}
			}

			public string SupplierUId
			{
				get
				{
					return supplierUId;
				}
				set	
				{
					supplierUId = value;
				}
			}
		}
	}
}
