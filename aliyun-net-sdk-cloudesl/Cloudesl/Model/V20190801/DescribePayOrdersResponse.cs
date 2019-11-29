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

namespace Aliyun.Acs.cloudesl.Model.V20190801
{
	public class DescribePayOrdersResponse : AcsResponse
	{

		private string errorMessage;

		private int? totalCount;

		private string errorCode;

		private string message;

		private int? pageSize;

		private string dynamicCode;

		private string code;

		private string dynamicMessage;

		private string requestId;

		private bool? success;

		private int? pageNumber;

		private List<DescribePayOrders_PayOrderInfo> payOrders;

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
			}
		}

		public int? TotalCount
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

		public string ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
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

		public string DynamicCode
		{
			get
			{
				return dynamicCode;
			}
			set	
			{
				dynamicCode = value;
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

		public string DynamicMessage
		{
			get
			{
				return dynamicMessage;
			}
			set	
			{
				dynamicMessage = value;
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

		public List<DescribePayOrders_PayOrderInfo> PayOrders
		{
			get
			{
				return payOrders;
			}
			set	
			{
				payOrders = value;
			}
		}

		public class DescribePayOrders_PayOrderInfo
		{

			private string gmtPay;

			private float? payAmount;

			private int? quantity;

			private string orderType;

			private bool? isAccepted;

			private string orderId;

			private float? originalAmount;

			private string detailName;

			private string orderStatus;

			private string commodityCode;

			private string commodityName;

			private string gmtCreate;

			public string GmtPay
			{
				get
				{
					return gmtPay;
				}
				set	
				{
					gmtPay = value;
				}
			}

			public float? PayAmount
			{
				get
				{
					return payAmount;
				}
				set	
				{
					payAmount = value;
				}
			}

			public int? Quantity
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

			public string OrderType
			{
				get
				{
					return orderType;
				}
				set	
				{
					orderType = value;
				}
			}

			public bool? IsAccepted
			{
				get
				{
					return isAccepted;
				}
				set	
				{
					isAccepted = value;
				}
			}

			public string OrderId
			{
				get
				{
					return orderId;
				}
				set	
				{
					orderId = value;
				}
			}

			public float? OriginalAmount
			{
				get
				{
					return originalAmount;
				}
				set	
				{
					originalAmount = value;
				}
			}

			public string DetailName
			{
				get
				{
					return detailName;
				}
				set	
				{
					detailName = value;
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

			public string CommodityCode
			{
				get
				{
					return commodityCode;
				}
				set	
				{
					commodityCode = value;
				}
			}

			public string CommodityName
			{
				get
				{
					return commodityName;
				}
				set	
				{
					commodityName = value;
				}
			}

			public string GmtCreate
			{
				get
				{
					return gmtCreate;
				}
				set	
				{
					gmtCreate = value;
				}
			}
		}
	}
}
