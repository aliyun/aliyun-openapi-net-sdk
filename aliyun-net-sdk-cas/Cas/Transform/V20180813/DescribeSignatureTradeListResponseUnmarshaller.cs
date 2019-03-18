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
using Aliyun.Acs.cas.Model.V20180813;

namespace Aliyun.Acs.cas.Transform.V20180813
{
    public class DescribeSignatureTradeListResponseUnmarshaller
    {
        public static DescribeSignatureTradeListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSignatureTradeListResponse describeSignatureTradeListResponse = new DescribeSignatureTradeListResponse();

			describeSignatureTradeListResponse.HttpResponse = context.HttpResponse;
			describeSignatureTradeListResponse.RequestId = context.StringValue("DescribeSignatureTradeList.RequestId");
			describeSignatureTradeListResponse.CurrentPage = context.IntegerValue("DescribeSignatureTradeList.CurrentPage");
			describeSignatureTradeListResponse.ShowSize = context.IntegerValue("DescribeSignatureTradeList.ShowSize");
			describeSignatureTradeListResponse.TotalCount = context.IntegerValue("DescribeSignatureTradeList.TotalCount");

			List<DescribeSignatureTradeListResponse.DescribeSignatureTradeList_Trade> describeSignatureTradeListResponse_tradeList = new List<DescribeSignatureTradeListResponse.DescribeSignatureTradeList_Trade>();
			for (int i = 0; i < context.Length("DescribeSignatureTradeList.TradeList.Length"); i++) {
				DescribeSignatureTradeListResponse.DescribeSignatureTradeList_Trade trade = new DescribeSignatureTradeListResponse.DescribeSignatureTradeList_Trade();
				trade.Id = context.LongValue("DescribeSignatureTradeList.TradeList["+ i +"].Id");
				trade.DocTitle = context.StringValue("DescribeSignatureTradeList.TradeList["+ i +"].DocTitle");
				trade.TransactionId = context.StringValue("DescribeSignatureTradeList.TradeList["+ i +"].TransactionId");
				trade.PeopleName = context.StringValue("DescribeSignatureTradeList.TradeList["+ i +"].PeopleName");
				trade.CreateTime = context.LongValue("DescribeSignatureTradeList.TradeList["+ i +"].CreateTime");
				trade.SignStatus = context.IntegerValue("DescribeSignatureTradeList.TradeList["+ i +"].SignStatus");
				trade.SignMode = context.IntegerValue("DescribeSignatureTradeList.TradeList["+ i +"].SignMode");
				trade.DocId = context.StringValue("DescribeSignatureTradeList.TradeList["+ i +"].DocId");
				trade.PeopleId = context.StringValue("DescribeSignatureTradeList.TradeList["+ i +"].PeopleId");

				describeSignatureTradeListResponse_tradeList.Add(trade);
			}
			describeSignatureTradeListResponse.TradeList = describeSignatureTradeListResponse_tradeList;
        
			return describeSignatureTradeListResponse;
        }
    }
}
