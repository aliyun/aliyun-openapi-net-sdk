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
using Aliyun.Acs.polardb.Model.V20170801;

namespace Aliyun.Acs.polardb.Transform.V20170801
{
    public class DescribeHALogsResponseUnmarshaller
    {
        public static DescribeHALogsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeHALogsResponse describeHALogsResponse = new DescribeHALogsResponse();

			describeHALogsResponse.HttpResponse = _ctx.HttpResponse;
			describeHALogsResponse.TotalRecords = _ctx.IntegerValue("DescribeHALogs.TotalRecords");
			describeHALogsResponse.ItemsNumbers = _ctx.IntegerValue("DescribeHALogs.ItemsNumbers");
			describeHALogsResponse.PageNumber = _ctx.IntegerValue("DescribeHALogs.PageNumber");
			describeHALogsResponse.DBInstanceName = _ctx.StringValue("DescribeHALogs.DBInstanceName");
			describeHALogsResponse.DBInstanceType = _ctx.StringValue("DescribeHALogs.DBInstanceType");
			describeHALogsResponse.HaStatus = _ctx.IntegerValue("DescribeHALogs.HaStatus");
			describeHALogsResponse.RequestId = _ctx.StringValue("DescribeHALogs.RequestId");
			describeHALogsResponse.PageSize = _ctx.IntegerValue("DescribeHALogs.PageSize");

			List<DescribeHALogsResponse.DescribeHALogs_HaSwitchLogItem> describeHALogsResponse_haLogItems = new List<DescribeHALogsResponse.DescribeHALogs_HaSwitchLogItem>();
			for (int i = 0; i < _ctx.Length("DescribeHALogs.HaLogItems.Length"); i++) {
				DescribeHALogsResponse.DescribeHALogs_HaSwitchLogItem haSwitchLogItem = new DescribeHALogsResponse.DescribeHALogs_HaSwitchLogItem();
				haSwitchLogItem.SwitchId = _ctx.StringValue("DescribeHALogs.HaLogItems["+ i +"].SwitchId");
				haSwitchLogItem.FromDBType = _ctx.StringValue("DescribeHALogs.HaLogItems["+ i +"].FromDBType");
				haSwitchLogItem.SwitchCauseCode = _ctx.StringValue("DescribeHALogs.HaLogItems["+ i +"].SwitchCauseCode");
				haSwitchLogItem.SwitchCauseDetail = _ctx.StringValue("DescribeHALogs.HaLogItems["+ i +"].SwitchCauseDetail");
				haSwitchLogItem.SwitchStartTime = _ctx.StringValue("DescribeHALogs.HaLogItems["+ i +"].SwitchStartTime");
				haSwitchLogItem.SwitchFinishTime = _ctx.StringValue("DescribeHALogs.HaLogItems["+ i +"].SwitchFinishTime");
				haSwitchLogItem.TotalSessions = _ctx.LongValue("DescribeHALogs.HaLogItems["+ i +"].TotalSessions");
				haSwitchLogItem.AffectedSessions = _ctx.LongValue("DescribeHALogs.HaLogItems["+ i +"].AffectedSessions");
				haSwitchLogItem.SwitchType = _ctx.LongValue("DescribeHALogs.HaLogItems["+ i +"].SwitchType");

				describeHALogsResponse_haLogItems.Add(haSwitchLogItem);
			}
			describeHALogsResponse.HaLogItems = describeHALogsResponse_haLogItems;

			List<DescribeHALogsResponse.DescribeHALogs_SwitchListItem> describeHALogsResponse_switchListItems = new List<DescribeHALogsResponse.DescribeHALogs_SwitchListItem>();
			for (int i = 0; i < _ctx.Length("DescribeHALogs.SwitchListItems.Length"); i++) {
				DescribeHALogsResponse.DescribeHALogs_SwitchListItem switchListItem = new DescribeHALogsResponse.DescribeHALogs_SwitchListItem();
				switchListItem.SimulateListId = _ctx.StringValue("DescribeHALogs.SwitchListItems["+ i +"].SimulateListId");
				switchListItem.SimulateMode = _ctx.StringValue("DescribeHALogs.SwitchListItems["+ i +"].SimulateMode");
				switchListItem.SimulateStatus = _ctx.StringValue("DescribeHALogs.SwitchListItems["+ i +"].SimulateStatus");
				switchListItem.StartTime = _ctx.StringValue("DescribeHALogs.SwitchListItems["+ i +"].StartTime");
				switchListItem.EndTime = _ctx.StringValue("DescribeHALogs.SwitchListItems["+ i +"].EndTime");
				switchListItem.EventStartTime = _ctx.StringValue("DescribeHALogs.SwitchListItems["+ i +"].EventStartTime");
				switchListItem.EventFinishTime = _ctx.StringValue("DescribeHALogs.SwitchListItems["+ i +"].EventFinishTime");
				switchListItem.SimulateTaskId = _ctx.StringValue("DescribeHALogs.SwitchListItems["+ i +"].SimulateTaskId");
				switchListItem.PreferredSimulateStartTime = _ctx.StringValue("DescribeHALogs.SwitchListItems["+ i +"].PreferredSimulateStartTime");
				switchListItem.PlannedEscapeMode = _ctx.StringValue("DescribeHALogs.SwitchListItems["+ i +"].PlannedEscapeMode");
				switchListItem.PlannedEscapeTime = _ctx.StringValue("DescribeHALogs.SwitchListItems["+ i +"].PlannedEscapeTime");
				switchListItem.FaultInjectionType = _ctx.StringValue("DescribeHALogs.SwitchListItems["+ i +"].FaultInjectionType");

				List<string> switchListItem_dBNodeCrashList = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeHALogs.SwitchListItems["+ i +"].DBNodeCrashList.Length"); j++) {
					switchListItem_dBNodeCrashList.Add(_ctx.StringValue("DescribeHALogs.SwitchListItems["+ i +"].DBNodeCrashList["+ j +"]"));
				}
				switchListItem.DBNodeCrashList = switchListItem_dBNodeCrashList;

				List<DescribeHALogsResponse.DescribeHALogs_SwitchListItem.DescribeHALogs_SwitchLogItem> switchListItem_switchLogItems1 = new List<DescribeHALogsResponse.DescribeHALogs_SwitchListItem.DescribeHALogs_SwitchLogItem>();
				for (int j = 0; j < _ctx.Length("DescribeHALogs.SwitchListItems["+ i +"].SwitchLogItems.Length"); j++) {
					DescribeHALogsResponse.DescribeHALogs_SwitchListItem.DescribeHALogs_SwitchLogItem switchLogItem = new DescribeHALogsResponse.DescribeHALogs_SwitchListItem.DescribeHALogs_SwitchLogItem();
					switchLogItem.SimulateListId = _ctx.StringValue("DescribeHALogs.SwitchListItems["+ i +"].SwitchLogItems["+ j +"].SimulateListId");
					switchLogItem.SimulateLogId = _ctx.StringValue("DescribeHALogs.SwitchListItems["+ i +"].SwitchLogItems["+ j +"].SimulateLogId");
					switchLogItem.DBInstanceId = _ctx.StringValue("DescribeHALogs.SwitchListItems["+ i +"].SwitchLogItems["+ j +"].DBInstanceId");
					switchLogItem.SrcIpPort = _ctx.StringValue("DescribeHALogs.SwitchListItems["+ i +"].SwitchLogItems["+ j +"].SrcIpPort");
					switchLogItem.SrcDbType = _ctx.StringValue("DescribeHALogs.SwitchListItems["+ i +"].SwitchLogItems["+ j +"].SrcDbType");
					switchLogItem.DstIpPort = _ctx.StringValue("DescribeHALogs.SwitchListItems["+ i +"].SwitchLogItems["+ j +"].DstIpPort");
					switchLogItem.DstDbType = _ctx.StringValue("DescribeHALogs.SwitchListItems["+ i +"].SwitchLogItems["+ j +"].DstDbType");
					switchLogItem.SimulateStatus = _ctx.StringValue("DescribeHALogs.SwitchListItems["+ i +"].SwitchLogItems["+ j +"].SimulateStatus");
					switchLogItem.EventStartTime = _ctx.StringValue("DescribeHALogs.SwitchListItems["+ i +"].SwitchLogItems["+ j +"].EventStartTime");
					switchLogItem.EventFinishTime = _ctx.StringValue("DescribeHALogs.SwitchListItems["+ i +"].SwitchLogItems["+ j +"].EventFinishTime");

					List<DescribeHALogsResponse.DescribeHALogs_SwitchListItem.DescribeHALogs_SwitchLogItem.DescribeHALogs_SwitchDetailItem> switchLogItem_switchStepItems2 = new List<DescribeHALogsResponse.DescribeHALogs_SwitchListItem.DescribeHALogs_SwitchLogItem.DescribeHALogs_SwitchDetailItem>();
					for (int k = 0; k < _ctx.Length("DescribeHALogs.SwitchListItems["+ i +"].SwitchLogItems["+ j +"].SwitchStepItems.Length"); k++) {
						DescribeHALogsResponse.DescribeHALogs_SwitchListItem.DescribeHALogs_SwitchLogItem.DescribeHALogs_SwitchDetailItem switchDetailItem = new DescribeHALogsResponse.DescribeHALogs_SwitchListItem.DescribeHALogs_SwitchLogItem.DescribeHALogs_SwitchDetailItem();
						switchDetailItem.StepName = _ctx.StringValue("DescribeHALogs.SwitchListItems["+ i +"].SwitchLogItems["+ j +"].SwitchStepItems["+ k +"].StepName");
						switchDetailItem.StartTime = _ctx.StringValue("DescribeHALogs.SwitchListItems["+ i +"].SwitchLogItems["+ j +"].SwitchStepItems["+ k +"].StartTime");
						switchDetailItem.SimulatePhase = _ctx.StringValue("DescribeHALogs.SwitchListItems["+ i +"].SwitchLogItems["+ j +"].SwitchStepItems["+ k +"].SimulatePhase");
						switchDetailItem.EndTime = _ctx.StringValue("DescribeHALogs.SwitchListItems["+ i +"].SwitchLogItems["+ j +"].SwitchStepItems["+ k +"].EndTime");
						switchDetailItem.TimeCost = _ctx.StringValue("DescribeHALogs.SwitchListItems["+ i +"].SwitchLogItems["+ j +"].SwitchStepItems["+ k +"].TimeCost");
						switchDetailItem.IsSuccess = _ctx.StringValue("DescribeHALogs.SwitchListItems["+ i +"].SwitchLogItems["+ j +"].SwitchStepItems["+ k +"].IsSuccess");

						switchLogItem_switchStepItems2.Add(switchDetailItem);
					}
					switchLogItem.SwitchStepItems2 = switchLogItem_switchStepItems2;

					switchListItem_switchLogItems1.Add(switchLogItem);
				}
				switchListItem.SwitchLogItems1 = switchListItem_switchLogItems1;

				List<DescribeHALogsResponse.DescribeHALogs_SwitchListItem.DescribeHALogs_SwitchStepItem> switchListItem_switchStepItems = new List<DescribeHALogsResponse.DescribeHALogs_SwitchListItem.DescribeHALogs_SwitchStepItem>();
				for (int j = 0; j < _ctx.Length("DescribeHALogs.SwitchListItems["+ i +"].SwitchStepItems.Length"); j++) {
					DescribeHALogsResponse.DescribeHALogs_SwitchListItem.DescribeHALogs_SwitchStepItem switchStepItem = new DescribeHALogsResponse.DescribeHALogs_SwitchListItem.DescribeHALogs_SwitchStepItem();
					switchStepItem.SimulatePhase = _ctx.StringValue("DescribeHALogs.SwitchListItems["+ i +"].SwitchStepItems["+ j +"].SimulatePhase");
					switchStepItem.StepName = _ctx.StringValue("DescribeHALogs.SwitchListItems["+ i +"].SwitchStepItems["+ j +"].StepName");
					switchStepItem.StartTime = _ctx.StringValue("DescribeHALogs.SwitchListItems["+ i +"].SwitchStepItems["+ j +"].StartTime");
					switchStepItem.EndTime = _ctx.StringValue("DescribeHALogs.SwitchListItems["+ i +"].SwitchStepItems["+ j +"].EndTime");
					switchStepItem.TimeCost = _ctx.StringValue("DescribeHALogs.SwitchListItems["+ i +"].SwitchStepItems["+ j +"].TimeCost");
					switchStepItem.IsSuccess = _ctx.StringValue("DescribeHALogs.SwitchListItems["+ i +"].SwitchStepItems["+ j +"].IsSuccess");
					switchStepItem.DBNodeId = _ctx.StringValue("DescribeHALogs.SwitchListItems["+ i +"].SwitchStepItems["+ j +"].DBNodeId");

					switchListItem_switchStepItems.Add(switchStepItem);
				}
				switchListItem.SwitchStepItems = switchListItem_switchStepItems;

				describeHALogsResponse_switchListItems.Add(switchListItem);
			}
			describeHALogsResponse.SwitchListItems = describeHALogsResponse_switchListItems;

			List<DescribeHALogsResponse.DescribeHALogs_SwitchLogItem3> describeHALogsResponse_switchLogItems = new List<DescribeHALogsResponse.DescribeHALogs_SwitchLogItem3>();
			for (int i = 0; i < _ctx.Length("DescribeHALogs.SwitchLogItems.Length"); i++) {
				DescribeHALogsResponse.DescribeHALogs_SwitchLogItem3 switchLogItem3 = new DescribeHALogsResponse.DescribeHALogs_SwitchLogItem3();
				switchLogItem3.SimulateListId = _ctx.StringValue("DescribeHALogs.SwitchLogItems["+ i +"].SimulateListId");
				switchLogItem3.Simulatecode = _ctx.StringValue("DescribeHALogs.SwitchLogItems["+ i +"].Simulatecode");
				switchLogItem3.DBInstanceId = _ctx.StringValue("DescribeHALogs.SwitchLogItems["+ i +"].DBInstanceId");
				switchLogItem3.SrcIpPort = _ctx.StringValue("DescribeHALogs.SwitchLogItems["+ i +"].SrcIpPort");
				switchLogItem3.SrcDbType = _ctx.StringValue("DescribeHALogs.SwitchLogItems["+ i +"].SrcDbType");
				switchLogItem3.DstIpPort = _ctx.StringValue("DescribeHALogs.SwitchLogItems["+ i +"].DstIpPort");
				switchLogItem3.DstDbType = _ctx.StringValue("DescribeHALogs.SwitchLogItems["+ i +"].DstDbType");
				switchLogItem3.SimulateStatus = _ctx.StringValue("DescribeHALogs.SwitchLogItems["+ i +"].SimulateStatus");
				switchLogItem3.EventStartTime = _ctx.StringValue("DescribeHALogs.SwitchLogItems["+ i +"].EventStartTime");
				switchLogItem3.EventFinishTime = _ctx.StringValue("DescribeHALogs.SwitchLogItems["+ i +"].EventFinishTime");

				List<DescribeHALogsResponse.DescribeHALogs_SwitchLogItem3.DescribeHALogs_SwitchStepItem5> switchLogItem3_switchStepItems4 = new List<DescribeHALogsResponse.DescribeHALogs_SwitchLogItem3.DescribeHALogs_SwitchStepItem5>();
				for (int j = 0; j < _ctx.Length("DescribeHALogs.SwitchLogItems["+ i +"].SwitchStepItems.Length"); j++) {
					DescribeHALogsResponse.DescribeHALogs_SwitchLogItem3.DescribeHALogs_SwitchStepItem5 switchStepItem5 = new DescribeHALogsResponse.DescribeHALogs_SwitchLogItem3.DescribeHALogs_SwitchStepItem5();
					switchStepItem5.StepName = _ctx.StringValue("DescribeHALogs.SwitchLogItems["+ i +"].SwitchStepItems["+ j +"].StepName");
					switchStepItem5.StepMsg = _ctx.StringValue("DescribeHALogs.SwitchLogItems["+ i +"].SwitchStepItems["+ j +"].StepMsg");
					switchStepItem5.StartTime = _ctx.StringValue("DescribeHALogs.SwitchLogItems["+ i +"].SwitchStepItems["+ j +"].StartTime");
					switchStepItem5.EndTime = _ctx.StringValue("DescribeHALogs.SwitchLogItems["+ i +"].SwitchStepItems["+ j +"].EndTime");
					switchStepItem5.TimeCost = _ctx.StringValue("DescribeHALogs.SwitchLogItems["+ i +"].SwitchStepItems["+ j +"].TimeCost");
					switchStepItem5.IsSuccess = _ctx.StringValue("DescribeHALogs.SwitchLogItems["+ i +"].SwitchStepItems["+ j +"].IsSuccess");
					switchStepItem5.SimulatePhase = _ctx.StringValue("DescribeHALogs.SwitchLogItems["+ i +"].SwitchStepItems["+ j +"].SimulatePhase");
					switchStepItem5.DBNodeId = _ctx.StringValue("DescribeHALogs.SwitchLogItems["+ i +"].SwitchStepItems["+ j +"].DBNodeId");

					switchLogItem3_switchStepItems4.Add(switchStepItem5);
				}
				switchLogItem3.SwitchStepItems4 = switchLogItem3_switchStepItems4;

				describeHALogsResponse_switchLogItems.Add(switchLogItem3);
			}
			describeHALogsResponse.SwitchLogItems = describeHALogsResponse_switchLogItems;
        
			return describeHALogsResponse;
        }
    }
}
