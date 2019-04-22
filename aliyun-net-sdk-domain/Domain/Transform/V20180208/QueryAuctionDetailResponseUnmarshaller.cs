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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Domain.Model.V20180208;

namespace Aliyun.Acs.Domain.Transform.V20180208
{
    public class QueryAuctionDetailResponseUnmarshaller
    {
        public static QueryAuctionDetailResponse Unmarshall(UnmarshallerContext context)
        {
			QueryAuctionDetailResponse queryAuctionDetailResponse = new QueryAuctionDetailResponse();

			queryAuctionDetailResponse.HttpResponse = context.HttpResponse;
			queryAuctionDetailResponse.RequestId = context.StringValue("QueryAuctionDetail.RequestId");
			queryAuctionDetailResponse.DomainName = context.StringValue("QueryAuctionDetail.DomainName");
			queryAuctionDetailResponse.AuctionId = context.StringValue("QueryAuctionDetail.AuctionId");
			queryAuctionDetailResponse.DomainType = context.StringValue("QueryAuctionDetail.DomainType");
			queryAuctionDetailResponse.BookedPartner = context.StringValue("QueryAuctionDetail.BookedPartner");
			queryAuctionDetailResponse.PartnerType = context.StringValue("QueryAuctionDetail.PartnerType");
			queryAuctionDetailResponse.Currency = context.StringValue("QueryAuctionDetail.Currency");
			queryAuctionDetailResponse.YourCurrentBid = context.FloatValue("QueryAuctionDetail.YourCurrentBid");
			queryAuctionDetailResponse.YourMaxBid = context.FloatValue("QueryAuctionDetail.YourMaxBid");
			queryAuctionDetailResponse.HighBid = context.FloatValue("QueryAuctionDetail.HighBid");
			queryAuctionDetailResponse.NextValidBid = context.FloatValue("QueryAuctionDetail.NextValidBid");
			queryAuctionDetailResponse.ReserveMet = context.BooleanValue("QueryAuctionDetail.ReserveMet");
			queryAuctionDetailResponse.TransferInPrice = context.FloatValue("QueryAuctionDetail.TransferInPrice");
			queryAuctionDetailResponse.PayPrice = context.FloatValue("QueryAuctionDetail.PayPrice");
			queryAuctionDetailResponse.HighBidder = context.StringValue("QueryAuctionDetail.HighBidder");
			queryAuctionDetailResponse.Status = context.StringValue("QueryAuctionDetail.Status");
			queryAuctionDetailResponse.PayStatus = context.StringValue("QueryAuctionDetail.PayStatus");
			queryAuctionDetailResponse.ProduceStatus = context.StringValue("QueryAuctionDetail.ProduceStatus");
			queryAuctionDetailResponse.AuctionEndTime = context.LongValue("QueryAuctionDetail.AuctionEndTime");
			queryAuctionDetailResponse.BookEndTime = context.LongValue("QueryAuctionDetail.BookEndTime");
			queryAuctionDetailResponse.PayEndTime = context.LongValue("QueryAuctionDetail.PayEndTime");
			queryAuctionDetailResponse.DeliveryTime = context.LongValue("QueryAuctionDetail.DeliveryTime");
			queryAuctionDetailResponse.FailCode = context.StringValue("QueryAuctionDetail.FailCode");
        
			return queryAuctionDetailResponse;
        }
    }
}
