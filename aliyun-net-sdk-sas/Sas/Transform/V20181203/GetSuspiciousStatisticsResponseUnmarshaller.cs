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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class GetSuspiciousStatisticsResponseUnmarshaller
    {
        public static GetSuspiciousStatisticsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetSuspiciousStatisticsResponse getSuspiciousStatisticsResponse = new GetSuspiciousStatisticsResponse();

			getSuspiciousStatisticsResponse.HttpResponse = _ctx.HttpResponse;
			getSuspiciousStatisticsResponse.SuspiciousCount = _ctx.IntegerValue("GetSuspiciousStatistics.SuspiciousCount");
			getSuspiciousStatisticsResponse.RemindCount = _ctx.IntegerValue("GetSuspiciousStatistics.RemindCount");
			getSuspiciousStatisticsResponse.RequestId = _ctx.StringValue("GetSuspiciousStatistics.RequestId");
			getSuspiciousStatisticsResponse.TemindCount = _ctx.IntegerValue("GetSuspiciousStatistics.TemindCount");
			getSuspiciousStatisticsResponse.SeriousCount = _ctx.IntegerValue("GetSuspiciousStatistics.SeriousCount");
			getSuspiciousStatisticsResponse.TotalCount = _ctx.IntegerValue("GetSuspiciousStatistics.TotalCount");
        
			return getSuspiciousStatisticsResponse;
        }
    }
}
