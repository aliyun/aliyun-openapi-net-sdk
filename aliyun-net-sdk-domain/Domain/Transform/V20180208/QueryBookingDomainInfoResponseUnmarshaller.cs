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
    public class QueryBookingDomainInfoResponseUnmarshaller
    {
        public static QueryBookingDomainInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryBookingDomainInfoResponse queryBookingDomainInfoResponse = new QueryBookingDomainInfoResponse();

			queryBookingDomainInfoResponse.HttpResponse = _ctx.HttpResponse;
			queryBookingDomainInfoResponse.RequestId = _ctx.StringValue("QueryBookingDomainInfo.RequestId");
			queryBookingDomainInfoResponse.AuctionId = _ctx.IntegerValue("QueryBookingDomainInfo.AuctionId");
			queryBookingDomainInfoResponse.PartnerType = _ctx.StringValue("QueryBookingDomainInfo.PartnerType");
			queryBookingDomainInfoResponse.MaxBid = _ctx.FloatValue("QueryBookingDomainInfo.MaxBid");
			queryBookingDomainInfoResponse.TransferInPrice = _ctx.FloatValue("QueryBookingDomainInfo.TransferInPrice");
			queryBookingDomainInfoResponse.Currency = _ctx.StringValue("QueryBookingDomainInfo.Currency");
			queryBookingDomainInfoResponse.BookEndTime = _ctx.LongValue("QueryBookingDomainInfo.BookEndTime");
        
			return queryBookingDomainInfoResponse;
        }
    }
}
