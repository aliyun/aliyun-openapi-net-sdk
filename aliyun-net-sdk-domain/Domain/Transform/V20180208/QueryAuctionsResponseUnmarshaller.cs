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
        public static QueryAuctionsResponse Unmarshall(UnmarshallerContext context)
        {
			QueryAuctionsResponse queryAuctionsResponse = new QueryAuctionsResponse();

			queryAuctionsResponse.HttpResponse = context.HttpResponse;
			queryAuctionsResponse.RequestId = context.StringValue("QueryAuctions.RequestId");
			queryAuctionsResponse.TotalItemNum = context.IntegerValue("QueryAuctions.TotalItemNum");
			queryAuctionsResponse.CurrentPageNum = context.IntegerValue("QueryAuctions.CurrentPageNum");
			queryAuctionsResponse.PageSize = context.IntegerValue("QueryAuctions.PageSize");
			queryAuctionsResponse.TotalPageNum = context.IntegerValue("QueryAuctions.TotalPageNum");

			List<QueryAuctionsResponse.QueryAuctions_AuctionDetail> queryAuctionsResponse_data = new List<QueryAuctionsResponse.QueryAuctions_AuctionDetail>();
			for (int i = 0; i < context.Length("QueryAuctions.Data.Length"); i++) {
				QueryAuctionsResponse.QueryAuctions_AuctionDetail auctionDetail = new QueryAuctionsResponse.QueryAuctions_AuctionDetail();
				auctionDetail.DomainName = context.StringValue("QueryAuctions.Data["+ i +"].DomainName");
				auctionDetail.AuctionId = context.StringValue("QueryAuctions.Data["+ i +"].AuctionId");
				auctionDetail.DomainType = context.StringValue("QueryAuctions.Data["+ i +"].DomainType");
				auctionDetail.BookedPartner = context.StringValue("QueryAuctions.Data["+ i +"].BookedPartner");
				auctionDetail.PartnerType = context.StringValue("QueryAuctions.Data["+ i +"].PartnerType");
				auctionDetail.Currency = context.StringValue("QueryAuctions.Data["+ i +"].Currency");
				auctionDetail.YourCurrentBid = context.FloatValue("QueryAuctions.Data["+ i +"].YourCurrentBid");
				auctionDetail.YourMaxBid = context.FloatValue("QueryAuctions.Data["+ i +"].YourMaxBid");
				auctionDetail.HighBid = context.FloatValue("QueryAuctions.Data["+ i +"].HighBid");
				auctionDetail.NextValidBid = context.FloatValue("QueryAuctions.Data["+ i +"].NextValidBid");
				auctionDetail.ReserveMet = context.BooleanValue("QueryAuctions.Data["+ i +"].ReserveMet");
				auctionDetail.TransferInPrice = context.FloatValue("QueryAuctions.Data["+ i +"].TransferInPrice");
				auctionDetail.PayPrice = context.FloatValue("QueryAuctions.Data["+ i +"].PayPrice");
				auctionDetail.HighBidder = context.StringValue("QueryAuctions.Data["+ i +"].HighBidder");
				auctionDetail.Status = context.StringValue("QueryAuctions.Data["+ i +"].Status");
				auctionDetail.PayStatus = context.StringValue("QueryAuctions.Data["+ i +"].PayStatus");
				auctionDetail.ProduceStatus = context.StringValue("QueryAuctions.Data["+ i +"].ProduceStatus");
				auctionDetail.AuctionEndTime = context.LongValue("QueryAuctions.Data["+ i +"].AuctionEndTime");
				auctionDetail.BookEndTime = context.LongValue("QueryAuctions.Data["+ i +"].BookEndTime");
				auctionDetail.PayEndTime = context.LongValue("QueryAuctions.Data["+ i +"].PayEndTime");
				auctionDetail.DeliveryTime = context.LongValue("QueryAuctions.Data["+ i +"].DeliveryTime");
				auctionDetail.FailCode = context.StringValue("QueryAuctions.Data["+ i +"].FailCode");

				queryAuctionsResponse_data.Add(auctionDetail);
			}
			queryAuctionsResponse.Data = queryAuctionsResponse_data;
        
			return queryAuctionsResponse;
        }
    }
}
