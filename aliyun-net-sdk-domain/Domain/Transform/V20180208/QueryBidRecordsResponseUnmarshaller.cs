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
        public static QueryBidRecordsResponse Unmarshall(UnmarshallerContext context)
        {
			QueryBidRecordsResponse queryBidRecordsResponse = new QueryBidRecordsResponse();

			queryBidRecordsResponse.HttpResponse = context.HttpResponse;
			queryBidRecordsResponse.RequestId = context.StringValue("QueryBidRecords.RequestId");
			queryBidRecordsResponse.TotalItemNum = context.IntegerValue("QueryBidRecords.TotalItemNum");
			queryBidRecordsResponse.CurrentPageNum = context.IntegerValue("QueryBidRecords.CurrentPageNum");
			queryBidRecordsResponse.PageSize = context.IntegerValue("QueryBidRecords.PageSize");
			queryBidRecordsResponse.TotalPageNum = context.IntegerValue("QueryBidRecords.TotalPageNum");

			List<QueryBidRecordsResponse.QueryBidRecords_BidRecord> queryBidRecordsResponse_data = new List<QueryBidRecordsResponse.QueryBidRecords_BidRecord>();
			for (int i = 0; i < context.Length("QueryBidRecords.Data.Length"); i++) {
				QueryBidRecordsResponse.QueryBidRecords_BidRecord bidRecord = new QueryBidRecordsResponse.QueryBidRecords_BidRecord();
				bidRecord.DomainName = context.StringValue("QueryBidRecords.Data["+ i +"].DomainName");
				bidRecord.Currency = context.StringValue("QueryBidRecords.Data["+ i +"].Currency");
				bidRecord.Bid = context.FloatValue("QueryBidRecords.Data["+ i +"].Bid");
				bidRecord.BidTime = context.LongValue("QueryBidRecords.Data["+ i +"].BidTime");
				bidRecord.Bidder = context.StringValue("QueryBidRecords.Data["+ i +"].Bidder");

				queryBidRecordsResponse_data.Add(bidRecord);
			}
			queryBidRecordsResponse.Data = queryBidRecordsResponse_data;
        
			return queryBidRecordsResponse;
        }
    }
}
