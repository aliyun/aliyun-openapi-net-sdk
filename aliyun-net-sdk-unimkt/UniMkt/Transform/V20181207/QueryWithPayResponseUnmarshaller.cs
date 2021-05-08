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
using Aliyun.Acs.UniMkt.Model.V20181207;

namespace Aliyun.Acs.UniMkt.Transform.V20181207
{
    public class QueryWithPayResponseUnmarshaller
    {
        public static QueryWithPayResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryWithPayResponse queryWithPayResponse = new QueryWithPayResponse();

			queryWithPayResponse.HttpResponse = _ctx.HttpResponse;
			queryWithPayResponse.Status = _ctx.BooleanValue("QueryWithPay.Status");
			queryWithPayResponse.Msg = _ctx.StringValue("QueryWithPay.Msg");
			queryWithPayResponse.ErrorCode = _ctx.StringValue("QueryWithPay.ErrorCode");
			queryWithPayResponse.RequestId = _ctx.StringValue("QueryWithPay.RequestId");

			QueryWithPayResponse.QueryWithPay_Data data = new QueryWithPayResponse.QueryWithPay_Data();
			data.Url = _ctx.StringValue("QueryWithPay.Data.Url");
			data.Status = _ctx.BooleanValue("QueryWithPay.Data.Status");
			data.UnionAmount = _ctx.StringValue("QueryWithPay.Data.UnionAmount");
			queryWithPayResponse.Data = data;
        
			return queryWithPayResponse;
        }
    }
}
