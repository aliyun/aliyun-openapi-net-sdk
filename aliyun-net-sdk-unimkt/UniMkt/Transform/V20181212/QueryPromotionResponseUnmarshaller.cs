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
    public class QueryPromotionResponseUnmarshaller
    {
        public static QueryPromotionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryPromotionResponse queryPromotionResponse = new QueryPromotionResponse();

			queryPromotionResponse.HttpResponse = _ctx.HttpResponse;
			queryPromotionResponse.Status = _ctx.BooleanValue("QueryPromotion.Status");
			queryPromotionResponse.Msg = _ctx.StringValue("QueryPromotion.Msg");
			queryPromotionResponse.ErrorCode = _ctx.StringValue("QueryPromotion.ErrorCode");
			queryPromotionResponse.RequestId = _ctx.StringValue("QueryPromotion.RequestId");
			queryPromotionResponse.Url = _ctx.StringValue("QueryPromotion.Url");
			queryPromotionResponse.UnionAmount = _ctx.StringValue("QueryPromotion.UnionAmount");
			queryPromotionResponse.NoPromotionUrl = _ctx.StringValue("QueryPromotion.NoPromotionUrl");
        
			return queryPromotionResponse;
        }
    }
}
