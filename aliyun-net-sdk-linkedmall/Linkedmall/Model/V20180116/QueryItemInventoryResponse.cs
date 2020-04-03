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

namespace Aliyun.Acs.linkedmall.Model.V20180116
{
	public class QueryItemInventoryResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private string subCode;

		private string subMessage;

		private bool? success;

		private List<QueryItemInventory_Item> itemList;

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

		public string SubCode
		{
			get
			{
				return subCode;
			}
			set	
			{
				subCode = value;
			}
		}

		public string SubMessage
		{
			get
			{
				return subMessage;
			}
			set	
			{
				subMessage = value;
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

		public List<QueryItemInventory_Item> ItemList
		{
			get
			{
				return itemList;
			}
			set	
			{
				itemList = value;
			}
		}

		public class QueryItemInventory_Item
		{

			private long? itemId;

			private string lmItemId;

			private List<QueryItemInventory_Sku> skuList;

			public long? ItemId
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

			public string LmItemId
			{
				get
				{
					return lmItemId;
				}
				set	
				{
					lmItemId = value;
				}
			}

			public List<QueryItemInventory_Sku> SkuList
			{
				get
				{
					return skuList;
				}
				set	
				{
					skuList = value;
				}
			}

			public class QueryItemInventory_Sku
			{

				private long? skuId;

				private QueryItemInventory_Inventory inventory;

				public long? SkuId
				{
					get
					{
						return skuId;
					}
					set	
					{
						skuId = value;
					}
				}

				public QueryItemInventory_Inventory Inventory
				{
					get
					{
						return inventory;
					}
					set	
					{
						inventory = value;
					}
				}

				public class QueryItemInventory_Inventory
				{

					private long? quantity;

					public long? Quantity
					{
						get
						{
							return quantity;
						}
						set	
						{
							quantity = value;
						}
					}
				}
			}
		}
	}
}
