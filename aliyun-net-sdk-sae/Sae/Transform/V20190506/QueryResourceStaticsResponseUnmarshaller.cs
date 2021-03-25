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
using Aliyun.Acs.sae.Model.V20190506;

namespace Aliyun.Acs.sae.Transform.V20190506
{
    public class QueryResourceStaticsResponseUnmarshaller
    {
        public static QueryResourceStaticsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryResourceStaticsResponse queryResourceStaticsResponse = new QueryResourceStaticsResponse();

			queryResourceStaticsResponse.HttpResponse = _ctx.HttpResponse;
			queryResourceStaticsResponse.Code = _ctx.StringValue("QueryResourceStatics.Code");
			queryResourceStaticsResponse.ErrorCode = _ctx.StringValue("QueryResourceStatics.ErrorCode");
			queryResourceStaticsResponse.Message = _ctx.StringValue("QueryResourceStatics.Message");
			queryResourceStaticsResponse.Success = _ctx.BooleanValue("QueryResourceStatics.Success");
			queryResourceStaticsResponse.TraceId = _ctx.StringValue("QueryResourceStatics.TraceId");
			queryResourceStaticsResponse.RequestId = _ctx.StringValue("QueryResourceStatics.RequestId");

			QueryResourceStaticsResponse.QueryResourceStatics_Data data = new QueryResourceStaticsResponse.QueryResourceStatics_Data();

			QueryResourceStaticsResponse.QueryResourceStatics_Data.QueryResourceStatics_RealTimeRes realTimeRes = new QueryResourceStaticsResponse.QueryResourceStatics_Data.QueryResourceStatics_RealTimeRes();
			realTimeRes.Cpu = _ctx.FloatValue("QueryResourceStatics.Data.RealTimeRes.Cpu");
			realTimeRes.Memory = _ctx.FloatValue("QueryResourceStatics.Data.RealTimeRes.Memory");
			data.RealTimeRes = realTimeRes;

			QueryResourceStaticsResponse.QueryResourceStatics_Data.QueryResourceStatics_Summary summary = new QueryResourceStaticsResponse.QueryResourceStatics_Data.QueryResourceStatics_Summary();
			summary.Cpu = _ctx.FloatValue("QueryResourceStatics.Data.Summary.Cpu");
			summary.Memory = _ctx.FloatValue("QueryResourceStatics.Data.Summary.Memory");
			data.Summary = summary;
			queryResourceStaticsResponse.Data = data;
        
			return queryResourceStaticsResponse;
        }
    }
}
