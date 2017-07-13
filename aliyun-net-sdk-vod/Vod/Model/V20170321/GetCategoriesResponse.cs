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

namespace Aliyun.Acs.vod.Model.V20170321
{
	public class GetCategoriesResponse : AcsResponse
	{

		private string requestId;

		private long? subTotal;

		private List<GetCategories_Category> subCategories;

		private GetCategories_Category category;

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

		public GetCategories_Category Category
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

		public class GetCategories_Category
		{

			private long? cateId;

			private string cateName;

			private long? level;

			private long? parentId;

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
		}

	}
}
