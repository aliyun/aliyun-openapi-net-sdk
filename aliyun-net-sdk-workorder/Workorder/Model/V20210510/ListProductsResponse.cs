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

namespace Aliyun.Acs.Workorder.Model.V20210510
{
	public class ListProductsResponse : AcsResponse
	{

		private int? code;

		private string requestId;

		private string message;

		private bool? success;

		private List<ListProducts_DataItem> data;

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

		public List<ListProducts_DataItem> Data
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

		public class ListProducts_DataItem
		{

			private string topCategoryName;

			private long? topCategoryId;

			private int? orderNumber;

			private List<ListProducts_RootsItem> roots;

			public string TopCategoryName
			{
				get
				{
					return topCategoryName;
				}
				set	
				{
					topCategoryName = value;
				}
			}

			public long? TopCategoryId
			{
				get
				{
					return topCategoryId;
				}
				set	
				{
					topCategoryId = value;
				}
			}

			public int? OrderNumber
			{
				get
				{
					return orderNumber;
				}
				set	
				{
					orderNumber = value;
				}
			}

			public List<ListProducts_RootsItem> Roots
			{
				get
				{
					return roots;
				}
				set	
				{
					roots = value;
				}
			}

			public class ListProducts_RootsItem
			{

				private long? categoryId;

				private string categoryName;

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
