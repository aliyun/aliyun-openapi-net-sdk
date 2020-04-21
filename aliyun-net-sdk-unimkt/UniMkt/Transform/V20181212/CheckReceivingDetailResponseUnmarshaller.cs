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
        public static CheckReceivingDetailResponse Unmarshall(UnmarshallerContext context)
        {
			CheckReceivingDetailResponse checkReceivingDetailResponse = new CheckReceivingDetailResponse();

			checkReceivingDetailResponse.HttpResponse = context.HttpResponse;
			checkReceivingDetailResponse.RequestId = context.StringValue("CheckReceivingDetail.RequestId");
			checkReceivingDetailResponse.Status = context.BooleanValue("CheckReceivingDetail.Status");
			checkReceivingDetailResponse.Msg = context.StringValue("CheckReceivingDetail.Msg");
			checkReceivingDetailResponse.ErrorCode = context.StringValue("CheckReceivingDetail.ErrorCode");
			checkReceivingDetailResponse.HasPromotion = context.BooleanValue("CheckReceivingDetail.HasPromotion");
			checkReceivingDetailResponse.TradeOrderId = context.StringValue("CheckReceivingDetail.TradeOrderId");
        
			return checkReceivingDetailResponse;
        }
    }
}
