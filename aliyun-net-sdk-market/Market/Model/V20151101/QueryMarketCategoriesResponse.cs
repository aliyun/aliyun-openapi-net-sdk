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

namespace Aliyun.Acs.Market.Model.V20151101
{
	public class QueryMarketCategoriesResponse : AcsResponse
	{

		private int? pageNumber;

		private int? pageSize;

		private int? totalCount;

		private string requestId;

		private List<QueryMarketCategories_Category> categories;

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

		public List<QueryMarketCategories_Category> Categories
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

		public class QueryMarketCategories_Category
		{

			private long? id;

			private string categoryCode;

			private string categoryName;

			private List<QueryMarketCategories_ChildCategory> childCategories;

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

			public string CategoryCode
			{
				get
				{
					return categoryCode;
				}
				set	
				{
					categoryCode = value;
				}
			}

			public string CategoryName
			{
				get
				{
					return categoryName;
				}
				set	
				{
					categoryName = value;
				}
			}

			public List<QueryMarketCategories_ChildCategory> ChildCategories
			{
				get
				{
					return childCategories;
				}
				set	
				{
					childCategories = value;
				}
			}

			public class QueryMarketCategories_ChildCategory
			{

				private long? id;

				private string categoryCode;

				private string categoryName;

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

				public string CategoryCode
				{
					get
					{
						return categoryCode;
					}
					set	
					{
						categoryCode = value;
					}
				}

				public string CategoryName
				{
					get
					{
						return categoryName;
					}
					set	
					{
						categoryName = value;
					}
				}
			}
		}
	}
}
