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

namespace Aliyun.Acs.Chatbot.Model.V20171011
{
	public class QueryCategoriesResponse : AcsResponse
	{

		private string requestId;

		private List<QueryCategories_Category> categories;

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

		public List<QueryCategories_Category> Categories
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

		public class QueryCategories_Category
		{

			private long? categoryId;

			private long? parentCategoryId;

			private string name;

			private List<string> childrens;

			public long? CategoryId
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

			public long? ParentCategoryId
			{
				get
				{
					return parentCategoryId;
				}
				set	
				{
					parentCategoryId = value;
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

			public List<string> Childrens
			{
				get
				{
					return childrens;
				}
				set	
				{
					childrens = value;
				}
			}
		}
	}
}