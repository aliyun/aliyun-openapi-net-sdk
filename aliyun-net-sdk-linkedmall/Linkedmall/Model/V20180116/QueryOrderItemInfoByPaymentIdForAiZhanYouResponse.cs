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
	public class QueryOrderItemInfoByPaymentIdForAiZhanYouResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private List<QueryOrderItemInfoByPaymentIdForAiZhanYou_LmOrderListItem> lmOrderList;

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

		public List<QueryOrderItemInfoByPaymentIdForAiZhanYou_LmOrderListItem> LmOrderList
		{
			get
			{
				return lmOrderList;
			}
			set	
			{
				lmOrderList = value;
			}
		}

		public class QueryOrderItemInfoByPaymentIdForAiZhanYou_LmOrderListItem
		{

			private string itemName;

			private long? lmOrderId;

			private long? skuId;

			private string skuName;

			private long? itemId;

			private string lmItemId;

			public string ItemName
			{
				get
				{
					return itemName;
				}
				set	
				{
					itemName = value;
				}
			}

			public long? LmOrderId
			{
				get
				{
					return lmOrderId;
				}
				set	
				{
					lmOrderId = value;
				}
			}

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

			public string SkuName
			{
				get
				{
					return skuName;
				}
				set	
				{
					skuName = value;
				}
			}

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
		}
	}
}
