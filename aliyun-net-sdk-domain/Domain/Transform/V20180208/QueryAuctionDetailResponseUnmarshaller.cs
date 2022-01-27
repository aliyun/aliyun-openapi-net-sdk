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
        public static QueryAuctionDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryAuctionDetailResponse queryAuctionDetailResponse = new QueryAuctionDetailResponse();

			queryAuctionDetailResponse.HttpResponse = _ctx.HttpResponse;
			queryAuctionDetailResponse.RequestId = _ctx.StringValue("QueryAuctionDetail.RequestId");
			queryAuctionDetailResponse.DomainName = _ctx.StringValue("QueryAuctionDetail.DomainName");
			queryAuctionDetailResponse.AuctionId = _ctx.StringValue("QueryAuctionDetail.AuctionId");
			queryAuctionDetailResponse.DomainType = _ctx.StringValue("QueryAuctionDetail.DomainType");
			queryAuctionDetailResponse.BookedPartner = _ctx.StringValue("QueryAuctionDetail.BookedPartner");
			queryAuctionDetailResponse.PartnerType = _ctx.StringValue("QueryAuctionDetail.PartnerType");
			queryAuctionDetailResponse.Currency = _ctx.StringValue("QueryAuctionDetail.Currency");
			queryAuctionDetailResponse.YourCurrentBid = _ctx.FloatValue("QueryAuctionDetail.YourCurrentBid");
			queryAuctionDetailResponse.YourMaxBid = _ctx.FloatValue("QueryAuctionDetail.YourMaxBid");
			queryAuctionDetailResponse.HighBid = _ctx.FloatValue("QueryAuctionDetail.HighBid");
			queryAuctionDetailResponse.NextValidBid = _ctx.FloatValue("QueryAuctionDetail.NextValidBid");
			queryAuctionDetailResponse.ReserveMet = _ctx.BooleanValue("QueryAuctionDetail.ReserveMet");
			queryAuctionDetailResponse.TransferInPrice = _ctx.FloatValue("QueryAuctionDetail.TransferInPrice");
			queryAuctionDetailResponse.PayPrice = _ctx.FloatValue("QueryAuctionDetail.PayPrice");
			queryAuctionDetailResponse.HighBidder = _ctx.StringValue("QueryAuctionDetail.HighBidder");
			queryAuctionDetailResponse.Status = _ctx.StringValue("QueryAuctionDetail.Status");
			queryAuctionDetailResponse.PayStatus = _ctx.StringValue("QueryAuctionDetail.PayStatus");
			queryAuctionDetailResponse.ProduceStatus = _ctx.StringValue("QueryAuctionDetail.ProduceStatus");
			queryAuctionDetailResponse.AuctionEndTime = _ctx.LongValue("QueryAuctionDetail.AuctionEndTime");
			queryAuctionDetailResponse.BookEndTime = _ctx.LongValue("QueryAuctionDetail.BookEndTime");
			queryAuctionDetailResponse.PayEndTime = _ctx.LongValue("QueryAuctionDetail.PayEndTime");
			queryAuctionDetailResponse.DeliveryTime = _ctx.LongValue("QueryAuctionDetail.DeliveryTime");
			queryAuctionDetailResponse.FailCode = _ctx.StringValue("QueryAuctionDetail.FailCode");
        
			return queryAuctionDetailResponse;
        }
    }
}
