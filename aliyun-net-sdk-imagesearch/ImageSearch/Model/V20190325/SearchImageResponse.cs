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

namespace Aliyun.Acs.ImageSearch.Model.V20190325
{
	public class SearchImageResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private int? code;

		private string msg;

		private List<SearchImage_Auction> auctions;

		private SearchImage_Head head;

		private SearchImage_PicInfo picInfo;

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

		public int? Code
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

		public string Msg
		{
			get
			{
				return msg;
			}
			set	
			{
				msg = value;
			}
		}

		public List<SearchImage_Auction> Auctions
		{
			get
			{
				return auctions;
			}
			set	
			{
				auctions = value;
			}
		}

		public SearchImage_Head Head
		{
			get
			{
				return head;
			}
			set	
			{
				head = value;
			}
		}

		public SearchImage_PicInfo PicInfo
		{
			get
			{
				return picInfo;
			}
			set	
			{
				picInfo = value;
			}
		}

		public class SearchImage_Auction
		{

			private int? categoryId;

			private string productId;

			private string picName;

			private string customContent;

			private string sortExprValues;

			private int? intAttr;

			private string strAttr;

			public int? CategoryId
			{
				get
				{
					return categoryId;
				}
				set	
				{
					categoryId = value;
				}
			}

			public string ProductId
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

			public string PicName
			{
				get
				{
					return picName;
				}
				set	
				{
					picName = value;
				}
			}

			public string CustomContent
			{
				get
				{
					return customContent;
				}
				set	
				{
					customContent = value;
				}
			}

			public string SortExprValues
			{
				get
				{
					return sortExprValues;
				}
				set	
				{
					sortExprValues = value;
				}
			}

			public int? IntAttr
			{
				get
				{
					return intAttr;
				}
				set	
				{
					intAttr = value;
				}
			}

			public string StrAttr
			{
				get
				{
					return strAttr;
				}
				set	
				{
					strAttr = value;
				}
			}
		}

		public class SearchImage_Head
		{

			private int? docsReturn;

			private int? docsFound;

			private int? searchTime;

			public int? DocsReturn
			{
				get
				{
					return docsReturn;
				}
				set	
				{
					docsReturn = value;
				}
			}

			public int? DocsFound
			{
				get
				{
					return docsFound;
				}
				set	
				{
					docsFound = value;
				}
			}

			public int? SearchTime
			{
				get
				{
					return searchTime;
				}
				set	
				{
					searchTime = value;
				}
			}
		}

		public class SearchImage_PicInfo
		{

			private int? categoryId;

			private string region;

			private List<SearchImage_Category> allCategories;

			public int? CategoryId
			{
				get
				{
					return categoryId;
				}
				set	
				{
					categoryId = value;
				}
			}

			public string Region
			{
				get
				{
					return region;
				}
				set	
				{
					region = value;
				}
			}

			public List<SearchImage_Category> AllCategories
			{
				get
				{
					return allCategories;
				}
				set	
				{
					allCategories = value;
				}
			}

			public class SearchImage_Category
			{

				private int? id;

				private string name;

				public int? Id
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
