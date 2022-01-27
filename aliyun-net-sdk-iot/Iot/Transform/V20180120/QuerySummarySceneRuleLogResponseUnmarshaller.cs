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
    public class QuerySummarySceneRuleLogResponseUnmarshaller
    {
        public static QuerySummarySceneRuleLogResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QuerySummarySceneRuleLogResponse querySummarySceneRuleLogResponse = new QuerySummarySceneRuleLogResponse();

			querySummarySceneRuleLogResponse.HttpResponse = _ctx.HttpResponse;
			querySummarySceneRuleLogResponse.RequestId = _ctx.StringValue("QuerySummarySceneRuleLog.RequestId");
			querySummarySceneRuleLogResponse.Success = _ctx.BooleanValue("QuerySummarySceneRuleLog.Success");
			querySummarySceneRuleLogResponse.ErrorMessage = _ctx.StringValue("QuerySummarySceneRuleLog.ErrorMessage");
			querySummarySceneRuleLogResponse.Code = _ctx.StringValue("QuerySummarySceneRuleLog.Code");

			QuerySummarySceneRuleLogResponse.QuerySummarySceneRuleLog_Data data = new QuerySummarySceneRuleLogResponse.QuerySummarySceneRuleLog_Data();
			data.Total = _ctx.IntegerValue("QuerySummarySceneRuleLog.Data.Total");
			data.PageSize = _ctx.IntegerValue("QuerySummarySceneRuleLog.Data.PageSize");
			data.CurrentPage = _ctx.IntegerValue("QuerySummarySceneRuleLog.Data.CurrentPage");

			List<QuerySummarySceneRuleLogResponse.QuerySummarySceneRuleLog_Data.QuerySummarySceneRuleLog_LogInfo> data_logList = new List<QuerySummarySceneRuleLogResponse.QuerySummarySceneRuleLog_Data.QuerySummarySceneRuleLog_LogInfo>();
			for (int i = 0; i < _ctx.Length("QuerySummarySceneRuleLog.Data.LogList.Length"); i++) {
				QuerySummarySceneRuleLogResponse.QuerySummarySceneRuleLog_Data.QuerySummarySceneRuleLog_LogInfo logInfo = new QuerySummarySceneRuleLogResponse.QuerySummarySceneRuleLog_Data.QuerySummarySceneRuleLog_LogInfo();
				logInfo.LogTime = _ctx.IntegerValue("QuerySummarySceneRuleLog.Data.LogList["+ i +"].LogTime");
				logInfo.Result = _ctx.StringValue("QuerySummarySceneRuleLog.Data.LogList["+ i +"].Result");
				logInfo.TraceId = _ctx.StringValue("QuerySummarySceneRuleLog.Data.LogList["+ i +"].TraceId");

				data_logList.Add(logInfo);
			}
			data.LogList = data_logList;
			querySummarySceneRuleLogResponse.Data = data;
        
			return querySummarySceneRuleLogResponse;
        }
    }
}
