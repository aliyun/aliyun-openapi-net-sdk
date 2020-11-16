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

namespace Aliyun.Acs.goodstech.Model.V20191230
{
	public class ClassifyCommodityResponse : AcsResponse
	{

		private string requestId;

		private ClassifyCommodity_Data data;

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

		public ClassifyCommodity_Data Data
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

		public class ClassifyCommodity_Data
		{

			private List<ClassifyCommodity_Category> categories;

			public List<ClassifyCommodity_Category> Categories
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

			public class ClassifyCommodity_Category
			{

				private float? score;

				private string categoryName;

				private string categoryId;

				public float? Score
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

				public string CategoryId
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
			}
		}
	}
}
