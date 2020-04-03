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
	public class QueryGuideItemGroupResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private string subCode;

		private string subMessage;

		private bool? success;

		private List<QueryGuideItemGroup_ItemInfo> guideItemGroup;

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

		public List<QueryGuideItemGroup_ItemInfo> GuideItemGroup
		{
			get
			{
				return guideItemGroup;
			}
			set	
			{
				guideItemGroup = value;
			}
		}

		public class QueryGuideItemGroup_ItemInfo
		{

			private long? itemId;

			private string itemTitle;

			private string mainPicUrl;

			private string itemUrl;

			private long? priceCent;

			private long? points;

			private string reservePrice;

			private long? pointsAmount;

			private long? pointPrice;

			private string lmItemId;

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

			public string ItemTitle
			{
				get
				{
					return itemTitle;
				}
				set	
				{
					itemTitle = value;
				}
			}

			public string MainPicUrl
			{
				get
				{
					return mainPicUrl;
				}
				set	
				{
					mainPicUrl = value;
				}
			}

			public string ItemUrl
			{
				get
				{
					return itemUrl;
				}
				set	
				{
					itemUrl = value;
				}
			}

			public long? PriceCent
			{
				get
				{
					return priceCent;
				}
				set	
				{
					priceCent = value;
				}
			}

			public long? Points
			{
				get
				{
					return points;
				}
				set	
				{
					points = value;
				}
			}

			public string ReservePrice
			{
				get
				{
					return reservePrice;
				}
				set	
				{
					reservePrice = value;
				}
			}

			public long? PointsAmount
			{
				get
				{
					return pointsAmount;
				}
				set	
				{
					pointsAmount = value;
				}
			}

			public long? PointPrice
			{
				get
				{
					return pointPrice;
				}
				set	
				{
					pointPrice = value;
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
