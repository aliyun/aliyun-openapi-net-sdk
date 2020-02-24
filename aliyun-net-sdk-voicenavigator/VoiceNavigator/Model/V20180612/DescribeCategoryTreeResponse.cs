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

namespace Aliyun.Acs.VoiceNavigator.Model.V20180612
{
	public class DescribeCategoryTreeResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeCategoryTree_Level> levels;

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

		public List<DescribeCategoryTree_Level> Levels
		{
			get
			{
				return levels;
			}
			set	
			{
				levels = value;
			}
		}

		public class DescribeCategoryTree_Level
		{

			private List<DescribeCategoryTree_Category> categories;

			public List<DescribeCategoryTree_Category> Categories
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

			public class DescribeCategoryTree_Category
			{

				private string instanceId;

				private string name;

				private string categoryId;

				private long? level;

				private string previousSiblingId;

				private string nextSiblingId;

				private string parentId;

				public string InstanceId
				{
					get
					{
						return instanceId;
					}
					set	
					{
						instanceId = value;
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

				public string PreviousSiblingId
				{
					get
					{
						return previousSiblingId;
					}
					set	
					{
						previousSiblingId = value;
					}
				}

				public string NextSiblingId
				{
					get
					{
						return nextSiblingId;
					}
					set	
					{
						nextSiblingId = value;
					}
				}

				public string ParentId
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
}
