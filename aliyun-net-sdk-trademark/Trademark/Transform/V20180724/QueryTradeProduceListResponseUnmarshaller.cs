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
using Aliyun.Acs.Trademark.Model.V20180724;

namespace Aliyun.Acs.Trademark.Transform.V20180724
{
    public class QueryTradeProduceListResponseUnmarshaller
    {
        public static QueryTradeProduceListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryTradeProduceListResponse queryTradeProduceListResponse = new QueryTradeProduceListResponse();

			queryTradeProduceListResponse.HttpResponse = context.HttpResponse;
			queryTradeProduceListResponse.RequestId = context.StringValue("QueryTradeProduceList.RequestId");
			queryTradeProduceListResponse.TotalItemNum = context.IntegerValue("QueryTradeProduceList.TotalItemNum");
			queryTradeProduceListResponse.CurrentPageNum = context.IntegerValue("QueryTradeProduceList.CurrentPageNum");
			queryTradeProduceListResponse.PageSize = context.IntegerValue("QueryTradeProduceList.PageSize");
			queryTradeProduceListResponse.TotalPageNum = context.IntegerValue("QueryTradeProduceList.TotalPageNum");

			List<QueryTradeProduceListResponse.QueryTradeProduceList_TradeProduces> queryTradeProduceListResponse_data = new List<QueryTradeProduceListResponse.QueryTradeProduceList_TradeProduces>();
			for (int i = 0; i < context.Length("QueryTradeProduceList.Data.Length"); i++) {
				QueryTradeProduceListResponse.QueryTradeProduceList_TradeProduces tradeProduces = new QueryTradeProduceListResponse.QueryTradeProduceList_TradeProduces();
				tradeProduces.BizId = context.StringValue("QueryTradeProduceList.Data["+ i +"].BizId");
				tradeProduces.PreOrderId = context.StringValue("QueryTradeProduceList.Data["+ i +"].PreOrderId");
				tradeProduces.PreAmount = context.IntegerValue("QueryTradeProduceList.Data["+ i +"].PreAmount");
				tradeProduces.FinalAmount = context.IntegerValue("QueryTradeProduceList.Data["+ i +"].FinalAmount");
				tradeProduces.RegisterNumber = context.StringValue("QueryTradeProduceList.Data["+ i +"].RegisterNumber");
				tradeProduces.Classification = context.StringValue("QueryTradeProduceList.Data["+ i +"].Classification");
				tradeProduces.Icon = context.StringValue("QueryTradeProduceList.Data["+ i +"].Icon");
				tradeProduces.OperateNote = context.StringValue("QueryTradeProduceList.Data["+ i +"].OperateNote");
				tradeProduces.BuyerStatus = context.IntegerValue("QueryTradeProduceList.Data["+ i +"].BuyerStatus");
				tradeProduces.UserId = context.StringValue("QueryTradeProduceList.Data["+ i +"].UserId");
				tradeProduces.CreateTime = context.LongValue("QueryTradeProduceList.Data["+ i +"].CreateTime");
				tradeProduces.UpdateTime = context.LongValue("QueryTradeProduceList.Data["+ i +"].UpdateTime");
				tradeProduces.AllowCancel = context.BooleanValue("QueryTradeProduceList.Data["+ i +"].AllowCancel");
				tradeProduces.FailReason = context.IntegerValue("QueryTradeProduceList.Data["+ i +"].FailReason");
				tradeProduces.Source = context.IntegerValue("QueryTradeProduceList.Data["+ i +"].Source");

				queryTradeProduceListResponse_data.Add(tradeProduces);
			}
			queryTradeProduceListResponse.Data = queryTradeProduceListResponse_data;
        
			return queryTradeProduceListResponse;
        }
    }
}
