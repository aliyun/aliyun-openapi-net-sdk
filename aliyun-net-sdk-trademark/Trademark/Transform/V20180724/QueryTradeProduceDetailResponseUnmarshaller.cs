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
    public class QueryTradeProduceDetailResponseUnmarshaller
    {
        public static QueryTradeProduceDetailResponse Unmarshall(UnmarshallerContext context)
        {
			QueryTradeProduceDetailResponse queryTradeProduceDetailResponse = new QueryTradeProduceDetailResponse();

			queryTradeProduceDetailResponse.HttpResponse = context.HttpResponse;
			queryTradeProduceDetailResponse.RequestId = context.StringValue("QueryTradeProduceDetail.RequestId");

			QueryTradeProduceDetailResponse.QueryTradeProduceDetail_Data data = new QueryTradeProduceDetailResponse.QueryTradeProduceDetail_Data();
			data.BizId = context.StringValue("QueryTradeProduceDetail.Data.BizId");
			data.PreOrderId = context.StringValue("QueryTradeProduceDetail.Data.PreOrderId");
			data.PreAmount = context.FloatValue("QueryTradeProduceDetail.Data.PreAmount");
			data.FinalAmount = context.FloatValue("QueryTradeProduceDetail.Data.FinalAmount");
			data.RegisterNumber = context.StringValue("QueryTradeProduceDetail.Data.RegisterNumber");
			data.Classification = context.StringValue("QueryTradeProduceDetail.Data.Classification");
			data.Icon = context.StringValue("QueryTradeProduceDetail.Data.Icon");
			data.OperateNote = context.StringValue("QueryTradeProduceDetail.Data.OperateNote");
			data.BuyerStatus = context.IntegerValue("QueryTradeProduceDetail.Data.BuyerStatus");
			data.UserId = context.StringValue("QueryTradeProduceDetail.Data.UserId");
			data.CreateTime = context.LongValue("QueryTradeProduceDetail.Data.CreateTime");
			data.UpdateTime = context.LongValue("QueryTradeProduceDetail.Data.UpdateTime");
			data.Extend = context.StringValue("QueryTradeProduceDetail.Data.Extend");
			data.ThirdCode = context.StringValue("QueryTradeProduceDetail.Data.ThirdCode");
			data.Share = context.StringValue("QueryTradeProduceDetail.Data.Share");
			data.ExclusiveDateLimit = context.StringValue("QueryTradeProduceDetail.Data.ExclusiveDateLimit");
			data.AllowCancel = context.BooleanValue("QueryTradeProduceDetail.Data.AllowCancel");
			data.TmName = context.StringValue("QueryTradeProduceDetail.Data.TmName");
			data.PaidAmount = context.FloatValue("QueryTradeProduceDetail.Data.PaidAmount");
			data.ConfiscateAmount = context.FloatValue("QueryTradeProduceDetail.Data.ConfiscateAmount");
			data.RefundAmount = context.FloatValue("QueryTradeProduceDetail.Data.RefundAmount");
			data.Source = context.IntegerValue("QueryTradeProduceDetail.Data.Source");
			queryTradeProduceDetailResponse.Data = data;
        
			return queryTradeProduceDetailResponse;
        }
    }
}
