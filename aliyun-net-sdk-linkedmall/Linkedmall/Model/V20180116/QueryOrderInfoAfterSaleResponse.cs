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
	public class QueryOrderInfoAfterSaleResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private QueryOrderInfoAfterSale_Model model;

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

		public QueryOrderInfoAfterSale_Model Model
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

		public class QueryOrderInfoAfterSale_Model
		{

			private long? lmOrderId;

			private long? tbOrderId;

			private string createDate;

			private string cashAmount;

			private long? points;

			private long? pointsAmount;

			private string orderStatus;

			private string shopName;

			private string refundStatus;

			private long? refundAmount;

			private string refundRate;

			private string xiaomiCode;

			private string shopServiceTelephone;

			private string extJson;

			private long? refundPoints;

			private List<QueryOrderInfoAfterSale_Logistics> logisticsList;

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

			public string CashAmount
			{
				get
				{
					return cashAmount;
				}
				set	
				{
					cashAmount = value;
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

			public string OrderStatus
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

			public string RefundStatus
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

			public long? RefundAmount
			{
				get
				{
					return refundAmount;
				}
				set	
				{
					refundAmount = value;
				}
			}

			public string RefundRate
			{
				get
				{
					return refundRate;
				}
				set	
				{
					refundRate = value;
				}
			}

			public string XiaomiCode
			{
				get
				{
					return xiaomiCode;
				}
				set	
				{
					xiaomiCode = value;
				}
			}

			public string ShopServiceTelephone
			{
				get
				{
					return shopServiceTelephone;
				}
				set	
				{
					shopServiceTelephone = value;
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

			public long? RefundPoints
			{
				get
				{
					return refundPoints;
				}
				set	
				{
					refundPoints = value;
				}
			}

			public List<QueryOrderInfoAfterSale_Logistics> LogisticsList
			{
				get
				{
					return logisticsList;
				}
				set	
				{
					logisticsList = value;
				}
			}

			public class QueryOrderInfoAfterSale_Logistics
			{

				private string logisticsNo;

				private string logisticsStatus;

				private string logisticsCompanyName;

				private string logisticsCompanyCode;

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

				public string LogisticsStatus
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

				public string LogisticsCompanyName
				{
					get
					{
						return logisticsCompanyName;
					}
					set	
					{
						logisticsCompanyName = value;
					}
				}

				public string LogisticsCompanyCode
				{
					get
					{
						return logisticsCompanyCode;
					}
					set	
					{
						logisticsCompanyCode = value;
					}
				}
			}
		}
	}
}
