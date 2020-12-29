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
using Aliyun.Acs.EHPC.Model.V20180412;

namespace Aliyun.Acs.EHPC.Transform.V20180412
{
    public class GetHealthMonitorLogsResponseUnmarshaller
    {
        public static GetHealthMonitorLogsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetHealthMonitorLogsResponse getHealthMonitorLogsResponse = new GetHealthMonitorLogsResponse();

			getHealthMonitorLogsResponse.HttpResponse = _ctx.HttpResponse;
			getHealthMonitorLogsResponse.RequestId = _ctx.StringValue("GetHealthMonitorLogs.RequestId");

			List<GetHealthMonitorLogsResponse.GetHealthMonitorLogs_Logs> getHealthMonitorLogsResponse_logInfo = new List<GetHealthMonitorLogsResponse.GetHealthMonitorLogs_Logs>();
			for (int i = 0; i < _ctx.Length("GetHealthMonitorLogs.LogInfo.Length"); i++) {
				GetHealthMonitorLogsResponse.GetHealthMonitorLogs_Logs logs = new GetHealthMonitorLogsResponse.GetHealthMonitorLogs_Logs();
				logs.HealthId = _ctx.StringValue("GetHealthMonitorLogs.LogInfo["+ i +"].HealthId");
				logs.HostName = _ctx.StringValue("GetHealthMonitorLogs.LogInfo["+ i +"].HostName");
				logs.InstanceId = _ctx.StringValue("GetHealthMonitorLogs.LogInfo["+ i +"].InstanceId");
				logs.ItemDescription = _ctx.StringValue("GetHealthMonitorLogs.LogInfo["+ i +"].ItemDescription");
				logs.ItemName = _ctx.StringValue("GetHealthMonitorLogs.LogInfo["+ i +"].ItemName");
				logs.Level = _ctx.StringValue("GetHealthMonitorLogs.LogInfo["+ i +"].Level");
				logs.SceneDescription = _ctx.StringValue("GetHealthMonitorLogs.LogInfo["+ i +"].SceneDescription");
				logs.SceneName = _ctx.StringValue("GetHealthMonitorLogs.LogInfo["+ i +"].SceneName");
				logs.Time = _ctx.IntegerValue("GetHealthMonitorLogs.LogInfo["+ i +"].Time");

				List<GetHealthMonitorLogsResponse.GetHealthMonitorLogs_Logs.GetHealthMonitorLogs_CheckListItem> logs_checkList = new List<GetHealthMonitorLogsResponse.GetHealthMonitorLogs_Logs.GetHealthMonitorLogs_CheckListItem>();
				for (int j = 0; j < _ctx.Length("GetHealthMonitorLogs.LogInfo["+ i +"].CheckList.Length"); j++) {
					GetHealthMonitorLogsResponse.GetHealthMonitorLogs_Logs.GetHealthMonitorLogs_CheckListItem checkListItem = new GetHealthMonitorLogsResponse.GetHealthMonitorLogs_Logs.GetHealthMonitorLogs_CheckListItem();
					checkListItem.CheckDescription = _ctx.StringValue("GetHealthMonitorLogs.LogInfo["+ i +"].CheckList["+ j +"].CheckDescription");
					checkListItem.CheckInfo = _ctx.StringValue("GetHealthMonitorLogs.LogInfo["+ i +"].CheckList["+ j +"].CheckInfo");
					checkListItem.CheckName = _ctx.StringValue("GetHealthMonitorLogs.LogInfo["+ i +"].CheckList["+ j +"].CheckName");
					checkListItem.CheckSolution = _ctx.StringValue("GetHealthMonitorLogs.LogInfo["+ i +"].CheckList["+ j +"].CheckSolution");

					logs_checkList.Add(checkListItem);
				}
				logs.CheckList = logs_checkList;

				getHealthMonitorLogsResponse_logInfo.Add(logs);
			}
			getHealthMonitorLogsResponse.LogInfo = getHealthMonitorLogsResponse_logInfo;
        
			return getHealthMonitorLogsResponse;
        }
    }
}
