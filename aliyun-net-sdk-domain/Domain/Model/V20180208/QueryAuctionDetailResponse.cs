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

namespace Aliyun.Acs.Domain.Model.V20180208
{
	public class QueryAuctionDetailResponse : AcsResponse
	{

		private string requestId;

		private string domainName;

		private string auctionId;

		private string domainType;

		private string bookedPartner;

		private string partnerType;

		private string currency;

		private float? yourCurrentBid;

		private float? yourMaxBid;

		private float? highBid;

		private float? nextValidBid;

		private bool? reserveMet;

		private float? transferInPrice;

		private float? payPrice;

		private string highBidder;

		private string status;

		private string payStatus;

		private string produceStatus;

		private long? auctionEndTime;

		private long? bookEndTime;

		private long? payEndTime;

		private long? deliveryTime;

		private string failCode;

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

		public string DomainName
		{
			get
			{
				return domainName;
			}
			set	
			{
				domainName = value;
			}
		}

		public string AuctionId
		{
			get
			{
				return auctionId;
			}
			set	
			{
				auctionId = value;
			}
		}

		public string DomainType
		{
			get
			{
				return domainType;
			}
			set	
			{
				domainType = value;
			}
		}

		public string BookedPartner
		{
			get
			{
				return bookedPartner;
			}
			set	
			{
				bookedPartner = value;
			}
		}

		public string PartnerType
		{
			get
			{
				return partnerType;
			}
			set	
			{
				partnerType = value;
			}
		}

		public string Currency
		{
			get
			{
				return currency;
			}
			set	
			{
				currency = value;
			}
		}

		public float? YourCurrentBid
		{
			get
			{
				return yourCurrentBid;
			}
			set	
			{
				yourCurrentBid = value;
			}
		}

		public float? YourMaxBid
		{
			get
			{
				return yourMaxBid;
			}
			set	
			{
				yourMaxBid = value;
			}
		}

		public float? HighBid
		{
			get
			{
				return highBid;
			}
			set	
			{
				highBid = value;
			}
		}

		public float? NextValidBid
		{
			get
			{
				return nextValidBid;
			}
			set	
			{
				nextValidBid = value;
			}
		}

		public bool? ReserveMet
		{
			get
			{
				return reserveMet;
			}
			set	
			{
				reserveMet = value;
			}
		}

		public float? TransferInPrice
		{
			get
			{
				return transferInPrice;
			}
			set	
			{
				transferInPrice = value;
			}
		}

		public float? PayPrice
		{
			get
			{
				return payPrice;
			}
			set	
			{
				payPrice = value;
			}
		}

		public string HighBidder
		{
			get
			{
				return highBidder;
			}
			set	
			{
				highBidder = value;
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

		public string ProduceStatus
		{
			get
			{
				return produceStatus;
			}
			set	
			{
				produceStatus = value;
			}
		}

		public long? AuctionEndTime
		{
			get
			{
				return auctionEndTime;
			}
			set	
			{
				auctionEndTime = value;
			}
		}

		public long? BookEndTime
		{
			get
			{
				return bookEndTime;
			}
			set	
			{
				bookEndTime = value;
			}
		}

		public long? PayEndTime
		{
			get
			{
				return payEndTime;
			}
			set	
			{
				payEndTime = value;
			}
		}

		public long? DeliveryTime
		{
			get
			{
				return deliveryTime;
			}
			set	
			{
				deliveryTime = value;
			}
		}

		public string FailCode
		{
			get
			{
				return failCode;
			}
			set	
			{
				failCode = value;
			}
		}
	}
}
