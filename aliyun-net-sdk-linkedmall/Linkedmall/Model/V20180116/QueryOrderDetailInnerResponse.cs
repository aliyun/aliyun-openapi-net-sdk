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
	public class QueryOrderDetailInnerResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private QueryOrderDetailInner_Model model;

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

		public QueryOrderDetailInner_Model Model
		{
			get
			{
				return model;
			}
			set	
			{
				model = value;
			}
		}

		public class QueryOrderDetailInner_Model
		{

			private QueryOrderDetailInner_Order order;

			public QueryOrderDetailInner_Order Order
			{
				get
				{
					return order;
				}
				set	
				{
					order = value;
				}
			}

			public class QueryOrderDetailInner_Order
			{

				private long? lmOrderId;

				private string channelCode;

				private string channelOrderId;

				private string channelBizType;

				private string orderPayInfo;

				private long? sellerId;

				private string sellerNick;

				private string shopName;

				private string createDate;

				private int? payStatus;

				private int? payWaterStatus;

				private int? refundStatus;

				private int? logisticsStatus;

				private string logisticsStatusDesc;

				private string logisticsAddress;

				private string logisticsUserName;

				private string logisticsMobilePhone;

				private string logisticsNo;

				private long? orderAmount;

				private string logisticsCompName;

				private string resExtInfo;

				private long? endTime;

				private string shipping;

				private bool? eticket;

				private int? enableStatus;

				private string tbOrderId;

				private string extInfo;

				private List<QueryOrderDetailInner_SubItemOrder> subItemOrderList;

				private List<QueryOrderDetailInner_FundStructure> fundStructureModels;

				private QueryOrderDetailInner_PostFee postFee;

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

				public string ChannelCode
				{
					get
					{
						return channelCode;
					}
					set	
					{
						channelCode = value;
					}
				}

				public string ChannelOrderId
				{
					get
					{
						return channelOrderId;
					}
					set	
					{
						channelOrderId = value;
					}
				}

				public string ChannelBizType
				{
					get
					{
						return channelBizType;
					}
					set	
					{
						channelBizType = value;
					}
				}

				public string OrderPayInfo
				{
					get
					{
						return orderPayInfo;
					}
					set	
					{
						orderPayInfo = value;
					}
				}

				public long? SellerId
				{
					get
					{
						return sellerId;
					}
					set	
					{
						sellerId = value;
					}
				}

				public string SellerNick
				{
					get
					{
						return sellerNick;
					}
					set	
					{
						sellerNick = value;
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

				public int? PayStatus
				{
					get
					{
						return payStatus;
					}
					set	
					{
						payStatus = value;
					}
				}

				public int? PayWaterStatus
				{
					get
					{
						return payWaterStatus;
					}
					set	
					{
						payWaterStatus = value;
					}
				}

				public int? RefundStatus
				{
					get
					{
						return refundStatus;
					}
					set	
					{
						refundStatus = value;
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

				public string LogisticsStatusDesc
				{
					get
					{
						return logisticsStatusDesc;
					}
					set	
					{
						logisticsStatusDesc = value;
					}
				}

				public string LogisticsAddress
				{
					get
					{
						return logisticsAddress;
					}
					set	
					{
						logisticsAddress = value;
					}
				}

				public string LogisticsUserName
				{
					get
					{
						return logisticsUserName;
					}
					set	
					{
						logisticsUserName = value;
					}
				}

				public string LogisticsMobilePhone
				{
					get
					{
						return logisticsMobilePhone;
					}
					set	
					{
						logisticsMobilePhone = value;
					}
				}

				public string LogisticsNo
				{
					get
					{
						return logisticsNo;
					}
					set	
					{
						logisticsNo = value;
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

				public string LogisticsCompName
				{
					get
					{
						return logisticsCompName;
					}
					set	
					{
						logisticsCompName = value;
					}
				}

				public string ResExtInfo
				{
					get
					{
						return resExtInfo;
					}
					set	
					{
						resExtInfo = value;
					}
				}

				public long? EndTime
				{
					get
					{
						return endTime;
					}
					set	
					{
						endTime = value;
					}
				}

				public string Shipping
				{
					get
					{
						return shipping;
					}
					set	
					{
						shipping = value;
					}
				}

				public bool? Eticket
				{
					get
					{
						return eticket;
					}
					set	
					{
						eticket = value;
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

				public string TbOrderId
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

				public string ExtInfo
				{
					get
					{
						return extInfo;
					}
					set	
					{
						extInfo = value;
					}
				}

				public List<QueryOrderDetailInner_SubItemOrder> SubItemOrderList
				{
					get
					{
						return subItemOrderList;
					}
					set	
					{
						subItemOrderList = value;
					}
				}

				public List<QueryOrderDetailInner_FundStructure> FundStructureModels
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

				public QueryOrderDetailInner_PostFee PostFee
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

				public class QueryOrderDetailInner_SubItemOrder
				{

					private int? payStatus;

					private string itemTitle;

					private string lmItemId;

					private long? itemId;

					private string itemPic;

					private string itemPriceInfo;

					private int? number;

					private long? tbSubOrderId;

					private long? lmOrderId;

					private string skuName;

					private long? skuId;

					private string totalPaymentInfo;

					private string channelCode;

					private List<QueryOrderDetailInner_ItemPrice> itemPriceList;

					public int? PayStatus
					{
						get
						{
							return payStatus;
						}
						set	
						{
							payStatus = value;
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

					public string ItemPriceInfo
					{
						get
						{
							return itemPriceInfo;
						}
						set	
						{
							itemPriceInfo = value;
						}
					}

					public int? Number
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

					public long? TbSubOrderId
					{
						get
						{
							return tbSubOrderId;
						}
						set	
						{
							tbSubOrderId = value;
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

					public string TotalPaymentInfo
					{
						get
						{
							return totalPaymentInfo;
						}
						set	
						{
							totalPaymentInfo = value;
						}
					}

					public string ChannelCode
					{
						get
						{
							return channelCode;
						}
						set	
						{
							channelCode = value;
						}
					}

					public List<QueryOrderDetailInner_ItemPrice> ItemPriceList
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

					public class QueryOrderDetailInner_ItemPrice
					{

						private long? tbOrderId;

						private long? tbSubOrderId;

						private string fundType;

						private long? fundAmount;

						private long? fundAmountMoney;

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

						public long? TbSubOrderId
						{
							get
							{
								return tbSubOrderId;
							}
							set	
							{
								tbSubOrderId = value;
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
					}
				}

				public class QueryOrderDetailInner_FundStructure
				{

					private long? lmOrderId;

					private long? tbSubOrderId;

					private string fundType;

					private long? fundAmount;

					private long? fundAmountMoney;

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

					public long? TbSubOrderId
					{
						get
						{
							return tbSubOrderId;
						}
						set	
						{
							tbSubOrderId = value;
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
				}

				public class QueryOrderDetailInner_PostFee
				{

					private long? lmOrderId;

					private long? tbSubOrderId;

					private string fundType;

					private long? fundAmount;

					private long? fundAmountMoney;

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

					public long? TbSubOrderId
					{
						get
						{
							return tbSubOrderId;
						}
						set	
						{
							tbSubOrderId = value;
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
				}
			}
		}
	}
}
