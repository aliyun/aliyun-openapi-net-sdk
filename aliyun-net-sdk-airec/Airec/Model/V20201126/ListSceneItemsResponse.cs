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

namespace Aliyun.Acs.Airec.Model.V20201126
{
	public class ListSceneItemsResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private ListSceneItems_Result result;

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

		public ListSceneItems_Result Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class ListSceneItems_Result
		{

			private List<ListSceneItems_DetailItem> detail;

			private ListSceneItems_Total total;

			public List<ListSceneItems_DetailItem> Detail
			{
				get
				{
					return detail;
				}
				set	
				{
					detail = value;
				}
			}

			public ListSceneItems_Total Total
			{
				get
				{
					return total;
				}
				set	
				{
					total = value;
				}
			}

			public class ListSceneItems_DetailItem
			{

				private string author;

				private string brandId;

				private string categoryPath;

				private string channel;

				private string duration;

				private string expireTime;

				private string itemId;

				private string itemType;

				private string pubTime;

				private string shopId;

				private string status;

				private string title;

				public string Author
				{
					get
					{
						return author;
					}
					set	
					{
						author = value;
					}
				}

				public string BrandId
				{
					get
					{
						return brandId;
					}
					set	
					{
						brandId = value;
					}
				}

				public string CategoryPath
				{
					get
					{
						return categoryPath;
					}
					set	
					{
						categoryPath = value;
					}
				}

				public string Channel
				{
					get
					{
						return channel;
					}
					set	
					{
						channel = value;
					}
				}

				public string Duration
				{
					get
					{
						return duration;
					}
					set	
					{
						duration = value;
					}
				}

				public string ExpireTime
				{
					get
					{
						return expireTime;
					}
					set	
					{
						expireTime = value;
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

				public string ItemType
				{
					get
					{
						return itemType;
					}
					set	
					{
						itemType = value;
					}
				}

				public string PubTime
				{
					get
					{
						return pubTime;
					}
					set	
					{
						pubTime = value;
					}
				}

				public string ShopId
				{
					get
					{
						return shopId;
					}
					set	
					{
						shopId = value;
					}
				}

				public string Status
				{
					get
					{
						return status;
					}
					set	
					{
						status = value;
					}
				}

				public string Title
				{
					get
					{
						return title;
					}
					set	
					{
						title = value;
					}
				}
			}

			public class ListSceneItems_Total
			{

				private long? instanceRecommendItem;

				private long? sceneRecommendItem;

				private long? sceneWeightItem;

				private long? totalCount;

				private long? weightItem;

				public long? InstanceRecommendItem
				{
					get
					{
						return instanceRecommendItem;
					}
					set	
					{
						instanceRecommendItem = value;
					}
				}

				public long? SceneRecommendItem
				{
					get
					{
						return sceneRecommendItem;
					}
					set	
					{
						sceneRecommendItem = value;
					}
				}

				public long? SceneWeightItem
				{
					get
					{
						return sceneWeightItem;
					}
					set	
					{
						sceneWeightItem = value;
					}
				}

				public long? TotalCount
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

				public long? WeightItem
				{
					get
					{
						return weightItem;
					}
					set	
					{
						weightItem = value;
					}
				}
			}
		}
	}
}
