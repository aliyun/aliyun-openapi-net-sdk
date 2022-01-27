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
    public class QueryBidRecordsResponseUnmarshaller
    {
        public static QueryBidRecordsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryBidRecordsResponse queryBidRecordsResponse = new QueryBidRecordsResponse();

			queryBidRecordsResponse.HttpResponse = _ctx.HttpResponse;
			queryBidRecordsResponse.RequestId = _ctx.StringValue("QueryBidRecords.RequestId");
			queryBidRecordsResponse.TotalItemNum = _ctx.IntegerValue("QueryBidRecords.TotalItemNum");
			queryBidRecordsResponse.CurrentPageNum = _ctx.IntegerValue("QueryBidRecords.CurrentPageNum");
			queryBidRecordsResponse.PageSize = _ctx.IntegerValue("QueryBidRecords.PageSize");
			queryBidRecordsResponse.TotalPageNum = _ctx.IntegerValue("QueryBidRecords.TotalPageNum");

			List<QueryBidRecordsResponse.QueryBidRecords_BidRecord> queryBidRecordsResponse_data = new List<QueryBidRecordsResponse.QueryBidRecords_BidRecord>();
			for (int i = 0; i < _ctx.Length("QueryBidRecords.Data.Length"); i++) {
				QueryBidRecordsResponse.QueryBidRecords_BidRecord bidRecord = new QueryBidRecordsResponse.QueryBidRecords_BidRecord();
				bidRecord.DomainName = _ctx.StringValue("QueryBidRecords.Data["+ i +"].DomainName");
				bidRecord.Currency = _ctx.StringValue("QueryBidRecords.Data["+ i +"].Currency");
				bidRecord.Bid = _ctx.FloatValue("QueryBidRecords.Data["+ i +"].Bid");
				bidRecord.BidTime = _ctx.LongValue("QueryBidRecords.Data["+ i +"].BidTime");
				bidRecord.Bidder = _ctx.StringValue("QueryBidRecords.Data["+ i +"].Bidder");

				queryBidRecordsResponse_data.Add(bidRecord);
			}
			queryBidRecordsResponse.Data = queryBidRecordsResponse_data;
        
			return queryBidRecordsResponse;
        }
    }
}
