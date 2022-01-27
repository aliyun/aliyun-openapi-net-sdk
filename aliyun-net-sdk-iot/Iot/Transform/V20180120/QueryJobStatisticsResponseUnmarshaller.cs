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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class QueryJobStatisticsResponseUnmarshaller
    {
        public static QueryJobStatisticsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryJobStatisticsResponse queryJobStatisticsResponse = new QueryJobStatisticsResponse();

			queryJobStatisticsResponse.HttpResponse = _ctx.HttpResponse;
			queryJobStatisticsResponse.RequestId = _ctx.StringValue("QueryJobStatistics.RequestId");
			queryJobStatisticsResponse.Success = _ctx.BooleanValue("QueryJobStatistics.Success");
			queryJobStatisticsResponse.Code = _ctx.StringValue("QueryJobStatistics.Code");
			queryJobStatisticsResponse.ErrorMessage = _ctx.StringValue("QueryJobStatistics.ErrorMessage");

			QueryJobStatisticsResponse.QueryJobStatistics_Data data = new QueryJobStatisticsResponse.QueryJobStatistics_Data();
			data.Total = _ctx.IntegerValue("QueryJobStatistics.Data.Total");
			data.Queued = _ctx.IntegerValue("QueryJobStatistics.Data.Queued");
			data.Sent = _ctx.IntegerValue("QueryJobStatistics.Data.Sent");
			data.InProgress = _ctx.IntegerValue("QueryJobStatistics.Data.InProgress");
			data.Succeeded = _ctx.IntegerValue("QueryJobStatistics.Data.Succeeded");
			data.Failed = _ctx.IntegerValue("QueryJobStatistics.Data.Failed");
			data.Rejected = _ctx.IntegerValue("QueryJobStatistics.Data.Rejected");
			data.TimeOut = _ctx.IntegerValue("QueryJobStatistics.Data.TimeOut");
			data.Cancelled = _ctx.IntegerValue("QueryJobStatistics.Data.Cancelled");
			queryJobStatisticsResponse.Data = data;
        
			return queryJobStatisticsResponse;
        }
    }
}
