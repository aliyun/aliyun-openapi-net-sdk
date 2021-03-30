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
using Aliyun.Acs.Airec.Model.V20201126;

namespace Aliyun.Acs.Airec.Transform.V20201126
{
    public class QueryDataMessageStatisticsResponseUnmarshaller
    {
        public static QueryDataMessageStatisticsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryDataMessageStatisticsResponse queryDataMessageStatisticsResponse = new QueryDataMessageStatisticsResponse();

			queryDataMessageStatisticsResponse.HttpResponse = _ctx.HttpResponse;
			queryDataMessageStatisticsResponse.Code = _ctx.StringValue("QueryDataMessageStatistics.code");
			queryDataMessageStatisticsResponse.Message = _ctx.StringValue("QueryDataMessageStatistics.message");
			queryDataMessageStatisticsResponse.RequestId = _ctx.StringValue("QueryDataMessageStatistics.requestId");
			queryDataMessageStatisticsResponse.Result = _ctx.StringValue("QueryDataMessageStatistics.result");
        
			return queryDataMessageStatisticsResponse;
        }
    }
}
