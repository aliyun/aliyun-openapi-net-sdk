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
using Aliyun.Acs.Httpdns.Model.V20160201;

namespace Aliyun.Acs.Httpdns.Transform.V20160201
{
    public class GetResolveCountSummaryResponseUnmarshaller
    {
        public static GetResolveCountSummaryResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetResolveCountSummaryResponse getResolveCountSummaryResponse = new GetResolveCountSummaryResponse();

			getResolveCountSummaryResponse.HttpResponse = _ctx.HttpResponse;
			getResolveCountSummaryResponse.RequestId = _ctx.StringValue("GetResolveCountSummary.RequestId");

			GetResolveCountSummaryResponse.GetResolveCountSummary_ResolveSummary resolveSummary = new GetResolveCountSummaryResponse.GetResolveCountSummary_ResolveSummary();
			resolveSummary.Http = _ctx.LongValue("GetResolveCountSummary.ResolveSummary.Http");
			resolveSummary.Https = _ctx.LongValue("GetResolveCountSummary.ResolveSummary.Https");
			resolveSummary.Http6 = _ctx.LongValue("GetResolveCountSummary.ResolveSummary.Http6");
			resolveSummary.Https6 = _ctx.LongValue("GetResolveCountSummary.ResolveSummary.Https6");
			getResolveCountSummaryResponse.ResolveSummary = resolveSummary;
        
			return getResolveCountSummaryResponse;
        }
    }
}
