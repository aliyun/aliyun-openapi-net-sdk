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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.Market.Model.V20151101
{
	public class DescribeOrderResponse : AcsResponse
	{

		private string productName;

		private string supplierCompanyName;

		private float? originalPrice;

		private long? aliUid;

		private float? couponPrice;

		private long? accountQuantity;

		private string periodType;

		private string requestId;

		private string payStatus;

		private float? paymentPrice;

		private string orderStatus;

		private string productSkuCode;

		private long? paidOn;

		private string components;

		private long? createdOn;

		private string orderType;

		private float? totalPrice;

		private int? quantity;

		private long? orderId;

		private string productCode;

		private List<string> supplierTelephones;

		private List<string> instanceIds;

		[JsonProperty(PropertyName = "ProductName")]
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

		[JsonProperty(PropertyName = "SupplierCompanyName")]
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

		[JsonProperty(PropertyName = "OriginalPrice")]
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

		[JsonProperty(PropertyName = "AliUid")]
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

		[JsonProperty(PropertyName = "CouponPrice")]
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

		[JsonProperty(PropertyName = "AccountQuantity")]
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

		[JsonProperty(PropertyName = "PeriodType")]
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

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "PayStatus")]
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

		[JsonProperty(PropertyName = "PaymentPrice")]
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

		[JsonProperty(PropertyName = "OrderStatus")]
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

		[JsonProperty(PropertyName = "ProductSkuCode")]
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

		[JsonProperty(PropertyName = "PaidOn")]
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

		[JsonProperty(PropertyName = "Components")]
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

		[JsonProperty(PropertyName = "CreatedOn")]
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

		[JsonProperty(PropertyName = "OrderType")]
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

		[JsonProperty(PropertyName = "TotalPrice")]
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

		[JsonProperty(PropertyName = "Quantity")]
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

		[JsonProperty(PropertyName = "OrderId")]
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

		[JsonProperty(PropertyName = "ProductCode")]
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

		[JsonProperty(PropertyName = "SupplierTelephones")]
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

		[JsonProperty(PropertyName = "InstanceIds")]
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
