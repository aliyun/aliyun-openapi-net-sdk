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

namespace Aliyun.Acs.ImageSearch.Model.V20180120
{
	public class SearchItemResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string message;

		private int? code;

		private List<SearchItem_Auction> auctions;

		private SearchItem_Head head;

		private SearchItem_PicInfo picInfo;

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

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
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

		public List<SearchItem_Auction> Auctions
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

		public SearchItem_Head Head
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

		public SearchItem_PicInfo PicInfo
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

		public class SearchItem_Auction
		{

			private string custContent;

			private string itemId;

			private string sortExprValues;

			private string catId;

			private string picName;

			public string CustContent
			{
				get
				{
					return custContent;
				}
				set	
				{
					custContent = value;
				}
			}

			public string ItemId
			{
				get
				{
					return itemId;
				}
				set	
				{
					itemId = value;
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

			public string CatId
			{
				get
				{
					return catId;
				}
				set	
				{
					catId = value;
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
		}

		public class SearchItem_Head
		{

			private int? searchTime;

			private int? docsFound;

			private int? docsReturn;

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
		}

		public class SearchItem_PicInfo
		{

			private string category;

			private string region;

			private List<SearchItem_Category> allCategory;

			public string Category
			{
				get
				{
					return category;
				}
				set	
				{
					category = value;
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

			public List<SearchItem_Category> AllCategory
			{
				get
				{
					return allCategory;
				}
				set	
				{
					allCategory = value;
				}
			}

			public class SearchItem_Category
			{

				private string name;

				private string id;

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
			}
		}
	}
}