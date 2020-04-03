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
	public class QueryOrderAndPaymentListResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private long? totalCount;

		private int? pageSize;

		private int? pageNumber;

		private List<QueryOrderAndPaymentList_LmOrderListItem> lmOrderList;

		private QueryOrderAndPaymentList_PostFee postFee;

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

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public List<QueryOrderAndPaymentList_LmOrderListItem> LmOrderList
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

		public QueryOrderAndPaymentList_PostFee PostFee
		{
			get
			{
				return postFee;
			}
			set	
			{
				postFee = value;
			}
		}

		public class QueryOrderAndPaymentList_LmOrderListItem
		{

			private string createDate;

			private long? lmOrderId;

			private long? orderAmount;

			private int? orderStatus;

			private string extJson;

			private string shopName;

			private int? logisticsStatus;

			private int? enableStatus;

			private long? tbOrderId;

			private string lmPaymentId;

			private List<QueryOrderAndPaymentList_FundStructureModelsItem> fundStructureModels;

			private List<QueryOrderAndPaymentList_SubOrderListItem> subOrderList;

			private QueryOrderAndPaymentList_PostFee1 postFee1;

			public string CreateDate
			{
				get
				{
					return createDate;
				}
				set	
				{
					createDate = value;
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

			public long? OrderAmount
			{
				get
				{
					return orderAmount;
				}
				set	
				{
					orderAmount = value;
				}
			}

			public int? OrderStatus
			{
				get
				{
					return orderStatus;
				}
				set	
				{
					orderStatus = value;
				}
			}

			public string ExtJson
			{
				get
				{
					return extJson;
				}
				set	
				{
					extJson = value;
				}
			}

			public string ShopName
			{
				get
				{
					return shopName;
				}
				set	
				{
					shopName = value;
				}
			}

			public int? LogisticsStatus
			{
				get
				{
					return logisticsStatus;
				}
				set	
				{
					logisticsStatus = value;
				}
			}

			public int? EnableStatus
			{
				get
				{
					return enableStatus;
				}
				set	
				{
					enableStatus = value;
				}
			}

			public long? TbOrderId
			{
				get
				{
					return tbOrderId;
				}
				set	
				{
					tbOrderId = value;
				}
			}

			public string LmPaymentId
			{
				get
				{
					return lmPaymentId;
				}
				set	
				{
					lmPaymentId = value;
				}
			}

			public List<QueryOrderAndPaymentList_FundStructureModelsItem> FundStructureModels
			{
				get
				{
					return fundStructureModels;
				}
				set	
				{
					fundStructureModels = value;
				}
			}

			public List<QueryOrderAndPaymentList_SubOrderListItem> SubOrderList
			{
				get
				{
					return subOrderList;
				}
				set	
				{
					subOrderList = value;
				}
			}

			public QueryOrderAndPaymentList_PostFee1 PostFee1
			{
				get
				{
					return postFee1;
				}
				set	
				{
					postFee1 = value;
				}
			}

			public class QueryOrderAndPaymentList_FundStructureModelsItem
			{

				private long? fundAmount;

				private long? fundAmountMoney;

				private string fundType;

				public long? FundAmount
				{
					get
					{
						return fundAmount;
					}
					set	
					{
						fundAmount = value;
					}
				}

				public long? FundAmountMoney
				{
					get
					{
						return fundAmountMoney;
					}
					set	
					{
						fundAmountMoney = value;
					}
				}

				public string FundType
				{
					get
					{
						return fundType;
					}
					set	
					{
						fundType = value;
					}
				}
			}

			public class QueryOrderAndPaymentList_SubOrderListItem
			{

				private long? itemId;

				private string itemPic;

				private string itemTitle;

				private long? number;

				private long? skuId;

				private string skuName;

				private long? lmOrderId;

				private int? orderStatus;

				private int? enableStatus;

				private long? tbOrderId;

				private string lmItemId;

				private List<QueryOrderAndPaymentList_ItemPriceListItem> itemPriceList;

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

				public string ItemPic
				{
					get
					{
						return itemPic;
					}
					set	
					{
						itemPic = value;
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

				public long? Number
				{
					get
					{
						return number;
					}
					set	
					{
						number = value;
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

				public int? OrderStatus
				{
					get
					{
						return orderStatus;
					}
					set	
					{
						orderStatus = value;
					}
				}

				public int? EnableStatus
				{
					get
					{
						return enableStatus;
					}
					set	
					{
						enableStatus = value;
					}
				}

				public long? TbOrderId
				{
					get
					{
						return tbOrderId;
					}
					set	
					{
						tbOrderId = value;
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

				public List<QueryOrderAndPaymentList_ItemPriceListItem> ItemPriceList
				{
					get
					{
						return itemPriceList;
					}
					set	
					{
						itemPriceList = value;
					}
				}

				public class QueryOrderAndPaymentList_ItemPriceListItem
				{

					private long? fundAmount;

					private long? fundAmountMoney;

					private string fundType;

					public long? FundAmount
					{
						get
						{
							return fundAmount;
						}
						set	
						{
							fundAmount = value;
						}
					}

					public long? FundAmountMoney
					{
						get
						{
							return fundAmountMoney;
						}
						set	
						{
							fundAmountMoney = value;
						}
					}

					public string FundType
					{
						get
						{
							return fundType;
						}
						set	
						{
							fundType = value;
						}
					}
				}
			}

			public class QueryOrderAndPaymentList_PostFee1
			{

				private long? fundAmount;

				private long? fundAmountMoney;

				private string fundType;

				public long? FundAmount
				{
					get
					{
						return fundAmount;
					}
					set	
					{
						fundAmount = value;
					}
				}

				public long? FundAmountMoney
				{
					get
					{
						return fundAmountMoney;
					}
					set	
					{
						fundAmountMoney = value;
					}
				}

				public string FundType
				{
					get
					{
						return fundType;
					}
					set	
					{
						fundType = value;
					}
				}
			}
		}

		public class QueryOrderAndPaymentList_PostFee
		{

			private long? fundAmount;

			private long? fundAmountMoney;

			private string fundType;

			public long? FundAmount
			{
				get
				{
					return fundAmount;
				}
				set	
				{
					fundAmount = value;
				}
			}

			public long? FundAmountMoney
			{
				get
				{
					return fundAmountMoney;
				}
				set	
				{
					fundAmountMoney = value;
				}
			}

			public string FundType
			{
				get
				{
					return fundType;
				}
				set	
				{
					fundType = value;
				}
			}
		}
	}
}
