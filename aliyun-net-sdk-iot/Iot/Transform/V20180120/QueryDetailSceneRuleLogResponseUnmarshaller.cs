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
    public class QueryDetailSceneRuleLogResponseUnmarshaller
    {
        public static QueryDetailSceneRuleLogResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryDetailSceneRuleLogResponse queryDetailSceneRuleLogResponse = new QueryDetailSceneRuleLogResponse();

			queryDetailSceneRuleLogResponse.HttpResponse = _ctx.HttpResponse;
			queryDetailSceneRuleLogResponse.RequestId = _ctx.StringValue("QueryDetailSceneRuleLog.RequestId");
			queryDetailSceneRuleLogResponse.Success = _ctx.BooleanValue("QueryDetailSceneRuleLog.Success");
			queryDetailSceneRuleLogResponse.ErrorMessage = _ctx.StringValue("QueryDetailSceneRuleLog.ErrorMessage");
			queryDetailSceneRuleLogResponse.Code = _ctx.StringValue("QueryDetailSceneRuleLog.Code");

			QueryDetailSceneRuleLogResponse.QueryDetailSceneRuleLog_Data data = new QueryDetailSceneRuleLogResponse.QueryDetailSceneRuleLog_Data();
			data.Total = _ctx.IntegerValue("QueryDetailSceneRuleLog.Data.Total");
			data.PageSize = _ctx.IntegerValue("QueryDetailSceneRuleLog.Data.PageSize");
			data.CurrentPage = _ctx.IntegerValue("QueryDetailSceneRuleLog.Data.CurrentPage");

			List<QueryDetailSceneRuleLogResponse.QueryDetailSceneRuleLog_Data.QueryDetailSceneRuleLog_LogInfo> data_logList = new List<QueryDetailSceneRuleLogResponse.QueryDetailSceneRuleLog_Data.QueryDetailSceneRuleLog_LogInfo>();
			for (int i = 0; i < _ctx.Length("QueryDetailSceneRuleLog.Data.LogList.Length"); i++) {
				QueryDetailSceneRuleLogResponse.QueryDetailSceneRuleLog_Data.QueryDetailSceneRuleLog_LogInfo logInfo = new QueryDetailSceneRuleLogResponse.QueryDetailSceneRuleLog_Data.QueryDetailSceneRuleLog_LogInfo();
				logInfo.Code = _ctx.StringValue("QueryDetailSceneRuleLog.Data.LogList["+ i +"].Code");
				logInfo.Message = _ctx.StringValue("QueryDetailSceneRuleLog.Data.LogList["+ i +"].Message");
				logInfo.PkDn = _ctx.StringValue("QueryDetailSceneRuleLog.Data.LogList["+ i +"].PkDn");

				data_logList.Add(logInfo);
			}
			data.LogList = data_logList;
			queryDetailSceneRuleLogResponse.Data = data;
        
			return queryDetailSceneRuleLogResponse;
        }
    }
}
