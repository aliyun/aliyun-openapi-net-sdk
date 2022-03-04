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
using Aliyun.Acs.quickbi_public.Model.V20220101;

namespace Aliyun.Acs.quickbi_public.Transform.V20220101
{
    public class QueryEmbeddedInfoResponseUnmarshaller
    {
        public static QueryEmbeddedInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryEmbeddedInfoResponse queryEmbeddedInfoResponse = new QueryEmbeddedInfoResponse();

			queryEmbeddedInfoResponse.HttpResponse = _ctx.HttpResponse;
			queryEmbeddedInfoResponse.Success = _ctx.BooleanValue("QueryEmbeddedInfo.Success");
			queryEmbeddedInfoResponse.RequestId = _ctx.StringValue("QueryEmbeddedInfo.RequestId");

			QueryEmbeddedInfoResponse.QueryEmbeddedInfo_Result result = new QueryEmbeddedInfoResponse.QueryEmbeddedInfo_Result();
			result.EmbeddedCount = _ctx.IntegerValue("QueryEmbeddedInfo.Result.EmbeddedCount");
			result.MaxCount = _ctx.IntegerValue("QueryEmbeddedInfo.Result.MaxCount");

			QueryEmbeddedInfoResponse.QueryEmbeddedInfo_Result.QueryEmbeddedInfo_Detail detail = new QueryEmbeddedInfoResponse.QueryEmbeddedInfo_Result.QueryEmbeddedInfo_Detail();
			detail.DashboardOfflineQuery = _ctx.IntegerValue("QueryEmbeddedInfo.Result.Detail.DashboardOfflineQuery");
			detail.Report = _ctx.IntegerValue("QueryEmbeddedInfo.Result.Detail.Report");
			detail.Page = _ctx.IntegerValue("QueryEmbeddedInfo.Result.Detail.Page");
			result.Detail = detail;
			queryEmbeddedInfoResponse.Result = result;
        
			return queryEmbeddedInfoResponse;
        }
    }
}
