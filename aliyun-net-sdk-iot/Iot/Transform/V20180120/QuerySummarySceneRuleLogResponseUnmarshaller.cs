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
        public static QuerySummarySceneRuleLogResponse Unmarshall(UnmarshallerContext context)
        {
			QuerySummarySceneRuleLogResponse querySummarySceneRuleLogResponse = new QuerySummarySceneRuleLogResponse();

			querySummarySceneRuleLogResponse.HttpResponse = context.HttpResponse;
			querySummarySceneRuleLogResponse.RequestId = context.StringValue("QuerySummarySceneRuleLog.RequestId");
			querySummarySceneRuleLogResponse.Success = context.BooleanValue("QuerySummarySceneRuleLog.Success");
			querySummarySceneRuleLogResponse.ErrorMessage = context.StringValue("QuerySummarySceneRuleLog.ErrorMessage");
			querySummarySceneRuleLogResponse.Code = context.StringValue("QuerySummarySceneRuleLog.Code");

			QuerySummarySceneRuleLogResponse.QuerySummarySceneRuleLog_Data data = new QuerySummarySceneRuleLogResponse.QuerySummarySceneRuleLog_Data();
			data.Total = context.IntegerValue("QuerySummarySceneRuleLog.Data.Total");
			data.PageSize = context.IntegerValue("QuerySummarySceneRuleLog.Data.PageSize");
			data.CurrentPage = context.IntegerValue("QuerySummarySceneRuleLog.Data.CurrentPage");

			List<QuerySummarySceneRuleLogResponse.QuerySummarySceneRuleLog_Data.QuerySummarySceneRuleLog_LogInfo> data_logList = new List<QuerySummarySceneRuleLogResponse.QuerySummarySceneRuleLog_Data.QuerySummarySceneRuleLog_LogInfo>();
			for (int i = 0; i < context.Length("QuerySummarySceneRuleLog.Data.LogList.Length"); i++) {
				QuerySummarySceneRuleLogResponse.QuerySummarySceneRuleLog_Data.QuerySummarySceneRuleLog_LogInfo logInfo = new QuerySummarySceneRuleLogResponse.QuerySummarySceneRuleLog_Data.QuerySummarySceneRuleLog_LogInfo();
				logInfo.LogTime = context.IntegerValue("QuerySummarySceneRuleLog.Data.LogList["+ i +"].LogTime");
				logInfo.Result = context.StringValue("QuerySummarySceneRuleLog.Data.LogList["+ i +"].Result");
				logInfo.TraceId = context.StringValue("QuerySummarySceneRuleLog.Data.LogList["+ i +"].TraceId");

				data_logList.Add(logInfo);
			}
			data.LogList = data_logList;
			querySummarySceneRuleLogResponse.Data = data;
        
			return querySummarySceneRuleLogResponse;
        }
    }
}
