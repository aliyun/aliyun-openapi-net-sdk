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
    public class QueryAuctionsResponseUnmarshaller
    {
        public static QueryAuctionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryAuctionsResponse queryAuctionsResponse = new QueryAuctionsResponse();

			queryAuctionsResponse.HttpResponse = _ctx.HttpResponse;
			queryAuctionsResponse.CurrentPageNum = _ctx.IntegerValue("QueryAuctions.CurrentPageNum");
			queryAuctionsResponse.TotalPageNum = _ctx.IntegerValue("QueryAuctions.TotalPageNum");
			queryAuctionsResponse.PageSize = _ctx.IntegerValue("QueryAuctions.PageSize");
			queryAuctionsResponse.RequestId = _ctx.StringValue("QueryAuctions.RequestId");
			queryAuctionsResponse.TotalItemNum = _ctx.IntegerValue("QueryAuctions.TotalItemNum");

			List<QueryAuctionsResponse.QueryAuctions_AuctionDetail> queryAuctionsResponse_data = new List<QueryAuctionsResponse.QueryAuctions_AuctionDetail>();
			for (int i = 0; i < _ctx.Length("QueryAuctions.Data.Length"); i++) {
				QueryAuctionsResponse.QueryAuctions_AuctionDetail auctionDetail = new QueryAuctionsResponse.QueryAuctions_AuctionDetail();
				auctionDetail.Status = _ctx.StringValue("QueryAuctions.Data["+ i +"].Status");
				auctionDetail.ReserveMet = _ctx.BooleanValue("QueryAuctions.Data["+ i +"].ReserveMet");
				auctionDetail.HighBid = _ctx.FloatValue("QueryAuctions.Data["+ i +"].HighBid");
				auctionDetail.DeliveryTime = _ctx.LongValue("QueryAuctions.Data["+ i +"].DeliveryTime");
				auctionDetail.TransferInPrice = _ctx.FloatValue("QueryAuctions.Data["+ i +"].TransferInPrice");
				auctionDetail.NextValidBid = _ctx.FloatValue("QueryAuctions.Data["+ i +"].NextValidBid");
				auctionDetail.ProduceStatus = _ctx.StringValue("QueryAuctions.Data["+ i +"].ProduceStatus");
				auctionDetail.HighBidder = _ctx.StringValue("QueryAuctions.Data["+ i +"].HighBidder");
				auctionDetail.BookedPartner = _ctx.StringValue("QueryAuctions.Data["+ i +"].BookedPartner");
				auctionDetail.Currency = _ctx.StringValue("QueryAuctions.Data["+ i +"].Currency");
				auctionDetail.DomainName = _ctx.StringValue("QueryAuctions.Data["+ i +"].DomainName");
				auctionDetail.YourCurrentBid = _ctx.FloatValue("QueryAuctions.Data["+ i +"].YourCurrentBid");
				auctionDetail.FailCode = _ctx.StringValue("QueryAuctions.Data["+ i +"].FailCode");
				auctionDetail.AuctionEndTime = _ctx.LongValue("QueryAuctions.Data["+ i +"].AuctionEndTime");
				auctionDetail.BookEndTime = _ctx.LongValue("QueryAuctions.Data["+ i +"].BookEndTime");
				auctionDetail.PayEndTime = _ctx.LongValue("QueryAuctions.Data["+ i +"].PayEndTime");
				auctionDetail.PayStatus = _ctx.StringValue("QueryAuctions.Data["+ i +"].PayStatus");
				auctionDetail.YourMaxBid = _ctx.FloatValue("QueryAuctions.Data["+ i +"].YourMaxBid");
				auctionDetail.PayPrice = _ctx.FloatValue("QueryAuctions.Data["+ i +"].PayPrice");
				auctionDetail.AuctionId = _ctx.StringValue("QueryAuctions.Data["+ i +"].AuctionId");
				auctionDetail.PartnerType = _ctx.StringValue("QueryAuctions.Data["+ i +"].PartnerType");
				auctionDetail.DomainType = _ctx.StringValue("QueryAuctions.Data["+ i +"].DomainType");
				auctionDetail.ReserveMin = _ctx.LongValue("QueryAuctions.Data["+ i +"].ReserveMin");
				auctionDetail.ReserveMax = _ctx.LongValue("QueryAuctions.Data["+ i +"].ReserveMax");

				queryAuctionsResponse_data.Add(auctionDetail);
			}
			queryAuctionsResponse.Data = queryAuctionsResponse_data;
        
			return queryAuctionsResponse;
        }
    }
}
