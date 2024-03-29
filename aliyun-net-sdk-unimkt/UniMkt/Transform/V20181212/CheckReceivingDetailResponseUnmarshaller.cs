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
using Aliyun.Acs.UniMkt.Model.V20181212;

namespace Aliyun.Acs.UniMkt.Transform.V20181212
{
    public class CheckReceivingDetailResponseUnmarshaller
    {
        public static CheckReceivingDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CheckReceivingDetailResponse checkReceivingDetailResponse = new CheckReceivingDetailResponse();

			checkReceivingDetailResponse.HttpResponse = _ctx.HttpResponse;
			checkReceivingDetailResponse.Status = _ctx.BooleanValue("CheckReceivingDetail.Status");
			checkReceivingDetailResponse.Msg = _ctx.StringValue("CheckReceivingDetail.Msg");
			checkReceivingDetailResponse.RequestId = _ctx.StringValue("CheckReceivingDetail.RequestId");
			checkReceivingDetailResponse.ErrorCode = _ctx.StringValue("CheckReceivingDetail.ErrorCode");
			checkReceivingDetailResponse.TradeOrderId = _ctx.StringValue("CheckReceivingDetail.TradeOrderId");
			checkReceivingDetailResponse.HasPromotion = _ctx.BooleanValue("CheckReceivingDetail.HasPromotion");
			checkReceivingDetailResponse.UnionAmount = _ctx.StringValue("CheckReceivingDetail.UnionAmount");
        
			return checkReceivingDetailResponse;
        }
    }
}
