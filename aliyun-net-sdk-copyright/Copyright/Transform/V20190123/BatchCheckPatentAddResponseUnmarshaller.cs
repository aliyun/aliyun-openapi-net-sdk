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
using Aliyun.Acs.Copyright.Model.V20190123;

namespace Aliyun.Acs.Copyright.Transform.V20190123
{
    public class BatchCheckPatentAddResponseUnmarshaller
    {
        public static BatchCheckPatentAddResponse Unmarshall(UnmarshallerContext _ctx)
        {
			BatchCheckPatentAddResponse batchCheckPatentAddResponse = new BatchCheckPatentAddResponse();

			batchCheckPatentAddResponse.HttpResponse = _ctx.HttpResponse;
			batchCheckPatentAddResponse.CacheKey = _ctx.StringValue("BatchCheckPatentAdd.CacheKey");
			batchCheckPatentAddResponse.CanAddCount = _ctx.IntegerValue("BatchCheckPatentAdd.CanAddCount");
			batchCheckPatentAddResponse.ExistCount = _ctx.IntegerValue("BatchCheckPatentAdd.ExistCount");
			batchCheckPatentAddResponse.RequestId = _ctx.StringValue("BatchCheckPatentAdd.RequestId");
			batchCheckPatentAddResponse.Success = _ctx.BooleanValue("BatchCheckPatentAdd.Success");
			batchCheckPatentAddResponse.TotalCount = _ctx.IntegerValue("BatchCheckPatentAdd.TotalCount");

			List<BatchCheckPatentAddResponse.BatchCheckPatentAdd_ErrorDetailItem> batchCheckPatentAddResponse_errorDetail = new List<BatchCheckPatentAddResponse.BatchCheckPatentAdd_ErrorDetailItem>();
			for (int i = 0; i < _ctx.Length("BatchCheckPatentAdd.ErrorDetail.Length"); i++) {
				BatchCheckPatentAddResponse.BatchCheckPatentAdd_ErrorDetailItem errorDetailItem = new BatchCheckPatentAddResponse.BatchCheckPatentAdd_ErrorDetailItem();
				errorDetailItem.ApplyNumber = _ctx.StringValue("BatchCheckPatentAdd.ErrorDetail["+ i +"].ApplyNumber");
				errorDetailItem.Message = _ctx.StringValue("BatchCheckPatentAdd.ErrorDetail["+ i +"].Message");
				errorDetailItem.Success = _ctx.BooleanValue("BatchCheckPatentAdd.ErrorDetail["+ i +"].Success");

				batchCheckPatentAddResponse_errorDetail.Add(errorDetailItem);
			}
			batchCheckPatentAddResponse.ErrorDetail = batchCheckPatentAddResponse_errorDetail;

			List<BatchCheckPatentAddResponse.BatchCheckPatentAdd_TradeListItem> batchCheckPatentAddResponse_tradeList = new List<BatchCheckPatentAddResponse.BatchCheckPatentAdd_TradeListItem>();
			for (int i = 0; i < _ctx.Length("BatchCheckPatentAdd.TradeList.Length"); i++) {
				BatchCheckPatentAddResponse.BatchCheckPatentAdd_TradeListItem tradeListItem = new BatchCheckPatentAddResponse.BatchCheckPatentAdd_TradeListItem();
				tradeListItem.Age = _ctx.StringValue("BatchCheckPatentAdd.TradeList["+ i +"].Age");
				tradeListItem.Discount = _ctx.StringValue("BatchCheckPatentAdd.TradeList["+ i +"].Discount");
				tradeListItem.ExistCount = _ctx.LongValue("BatchCheckPatentAdd.TradeList["+ i +"].ExistCount");
				tradeListItem.NeedCount = _ctx.IntegerValue("BatchCheckPatentAdd.TradeList["+ i +"].NeedCount");
				tradeListItem.NeedFee = _ctx.FloatValue("BatchCheckPatentAdd.TradeList["+ i +"].NeedFee");
				tradeListItem.TotalCount = _ctx.LongValue("BatchCheckPatentAdd.TradeList["+ i +"].TotalCount");
				tradeListItem.Type = _ctx.StringValue("BatchCheckPatentAdd.TradeList["+ i +"].Type");
				tradeListItem.OverduePenalty = _ctx.StringValue("BatchCheckPatentAdd.TradeList["+ i +"].OverduePenalty");

				batchCheckPatentAddResponse_tradeList.Add(tradeListItem);
			}
			batchCheckPatentAddResponse.TradeList = batchCheckPatentAddResponse_tradeList;
        
			return batchCheckPatentAddResponse;
        }
    }
}
