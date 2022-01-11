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
	public class QueryAuctionsResponse : AcsResponse
	{

		private int? currentPageNum;

		private int? totalPageNum;

		private int? pageSize;

		private string requestId;

		private int? totalItemNum;

		private List<QueryAuctions_AuctionDetail> data;

		public int? CurrentPageNum
		{
			get
			{
				return currentPageNum;
			}
			set	
			{
				currentPageNum = value;
			}
		}

		public int? TotalPageNum
		{
			get
			{
				return totalPageNum;
			}
			set	
			{
				totalPageNum = value;
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

		public int? TotalItemNum
		{
			get
			{
				return totalItemNum;
			}
			set	
			{
				totalItemNum = value;
			}
		}

		public List<QueryAuctions_AuctionDetail> Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class QueryAuctions_AuctionDetail
		{

			private string status;

			private bool? reserveMet;

			private float? highBid;

			private long? deliveryTime;

			private float? transferInPrice;

			private float? nextValidBid;

			private string produceStatus;

			private string highBidder;

			private string bookedPartner;

			private string currency;

			private string domainName;

			private float? yourCurrentBid;

			private string failCode;

			private long? auctionEndTime;

			private long? bookEndTime;

			private long? payEndTime;

			private string payStatus;

			private float? yourMaxBid;

			private float? payPrice;

			private string auctionId;

			private string partnerType;

			private string domainType;

			private long? reserveMin;

			private long? reserveMax;

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

			public long? ReserveMin
			{
				get
				{
					return reserveMin;
				}
				set	
				{
					reserveMin = value;
				}
			}

			public long? ReserveMax
			{
				get
				{
					return reserveMax;
				}
				set	
				{
					reserveMax = value;
				}
			}
		}
	}
}
