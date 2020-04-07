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

namespace Aliyun.Acs.Market.Model.V20151101
{
	public class DescribeOrderResponse : AcsResponse
	{

		private long? orderId;

		private long? aliUid;

		private string supplierCompanyName;

		private string productCode;

		private string productSkuCode;

		private string productName;

		private string periodType;

		private int? quantity;

		private long? accountQuantity;

		private string orderType;

		private string orderStatus;

		private string payStatus;

		private long? paidOn;

		private long? createdOn;

		private float? originalPrice;

		private float? totalPrice;

		private float? paymentPrice;

		private float? couponPrice;

		private string components;

		private string requestId;

		private List<string> supplierTelephones;

		private List<string> instanceIds;

		public long? OrderId
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

		public long? AliUid
		{
			get
			{
				return aliUid;
			}
			set	
			{
				aliUid = value;
			}
		}

		public string SupplierCompanyName
		{
			get
			{
				return supplierCompanyName;
			}
			set	
			{
				supplierCompanyName = value;
			}
		}

		public string ProductCode
		{
			get
			{
				return productCode;
			}
			set	
			{
				productCode = value;
			}
		}

		public string ProductSkuCode
		{
			get
			{
				return productSkuCode;
			}
			set	
			{
				productSkuCode = value;
			}
		}

		public string ProductName
		{
			get
			{
				return productName;
			}
			set	
			{
				productName = value;
			}
		}

		public string PeriodType
		{
			get
			{
				return periodType;
			}
			set	
			{
				periodType = value;
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

		public long? AccountQuantity
		{
			get
			{
				return accountQuantity;
			}
			set	
			{
				accountQuantity = value;
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

		public string PayStatus
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

		public long? PaidOn
		{
			get
			{
				return paidOn;
			}
			set	
			{
				paidOn = value;
			}
		}

		public long? CreatedOn
		{
			get
			{
				return createdOn;
			}
			set	
			{
				createdOn = value;
			}
		}

		public float? OriginalPrice
		{
			get
			{
				return originalPrice;
			}
			set	
			{
				originalPrice = value;
			}
		}

		public float? TotalPrice
		{
			get
			{
				return totalPrice;
			}
			set	
			{
				totalPrice = value;
			}
		}

		public float? PaymentPrice
		{
			get
			{
				return paymentPrice;
			}
			set	
			{
				paymentPrice = value;
			}
		}

		public float? CouponPrice
		{
			get
			{
				return couponPrice;
			}
			set	
			{
				couponPrice = value;
			}
		}

		public string Components
		{
			get
			{
				return components;
			}
			set	
			{
				components = value;
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

		public List<string> SupplierTelephones
		{
			get
			{
				return supplierTelephones;
			}
			set	
			{
				supplierTelephones = value;
			}
		}

		public List<string> InstanceIds
		{
			get
			{
				return instanceIds;
			}
			set	
			{
				instanceIds = value;
			}
		}
	}
}
