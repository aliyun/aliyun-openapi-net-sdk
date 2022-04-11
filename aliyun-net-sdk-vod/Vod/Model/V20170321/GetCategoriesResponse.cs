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

namespace Aliyun.Acs.vod.Model.V20170321
{
	public class GetCategoriesResponse : AcsResponse
	{

		private long? subTotal;

		private string requestId;

		private List<GetCategories_Category> subCategories;

		private GetCategories_Category1 category1;

		public long? SubTotal
		{
			get
			{
				return subTotal;
			}
			set	
			{
				subTotal = value;
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

		public List<GetCategories_Category> SubCategories
		{
			get
			{
				return subCategories;
			}
			set	
			{
				subCategories = value;
			}
		}

		public GetCategories_Category1 Category1
		{
			get
			{
				return category1;
			}
			set	
			{
				category1 = value;
			}
		}

		public class GetCategories_Category
		{

			private string type;

			private string cateName;

			private long? parentId;

			private long? cateId;

			private long? subTotal;

			private long? level;

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

			public string CateName
			{
				get
				{
					return cateName;
				}
				set	
				{
					cateName = value;
				}
			}

			public long? ParentId
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

			public long? CateId
			{
				get
				{
					return cateId;
				}
				set	
				{
					cateId = value;
				}
			}

			public long? SubTotal
			{
				get
				{
					return subTotal;
				}
				set	
				{
					subTotal = value;
				}
			}

			public long? Level
			{
				get
				{
					return level;
				}
				set	
				{
					level = value;
				}
			}
		}

		public class GetCategories_Category1
		{

			private string type;

			private long? parentId;

			private string cateName;

			private long? cateId;

			private long? level;

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

			public long? ParentId
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

			public string CateName
			{
				get
				{
					return cateName;
				}
				set	
				{
					cateName = value;
				}
			}

			public long? CateId
			{
				get
				{
					return cateId;
				}
				set	
				{
					cateId = value;
				}
			}

			public long? Level
			{
				get
				{
					return level;
				}
				set	
				{
					level = value;
				}
			}
		}
	}
}
