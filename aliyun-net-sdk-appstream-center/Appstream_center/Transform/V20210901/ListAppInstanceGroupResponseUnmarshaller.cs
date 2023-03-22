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
using Aliyun.Acs.appstream_center.Model.V20210901;

namespace Aliyun.Acs.appstream_center.Transform.V20210901
{
    public class ListAppInstanceGroupResponseUnmarshaller
    {
        public static ListAppInstanceGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAppInstanceGroupResponse listAppInstanceGroupResponse = new ListAppInstanceGroupResponse();

			listAppInstanceGroupResponse.HttpResponse = _ctx.HttpResponse;
			listAppInstanceGroupResponse.RequestId = _ctx.StringValue("ListAppInstanceGroup.RequestId");
			listAppInstanceGroupResponse.TotalCount = _ctx.IntegerValue("ListAppInstanceGroup.TotalCount");
			listAppInstanceGroupResponse.PageSize = _ctx.IntegerValue("ListAppInstanceGroup.PageSize");
			listAppInstanceGroupResponse.PageNumber = _ctx.IntegerValue("ListAppInstanceGroup.PageNumber");

			List<ListAppInstanceGroupResponse.ListAppInstanceGroup_Data> listAppInstanceGroupResponse_appInstanceGroupModels = new List<ListAppInstanceGroupResponse.ListAppInstanceGroup_Data>();
			for (int i = 0; i < _ctx.Length("ListAppInstanceGroup.AppInstanceGroupModels.Length"); i++) {
				ListAppInstanceGroupResponse.ListAppInstanceGroup_Data data = new ListAppInstanceGroupResponse.ListAppInstanceGroup_Data();
				data.AppCenterImageId = _ctx.StringValue("ListAppInstanceGroup.AppInstanceGroupModels["+ i +"].AppCenterImageId");
				data.AliyunImageId = _ctx.StringValue("ListAppInstanceGroup.AppInstanceGroupModels["+ i +"].AliyunImageId");
				data.RegionId = _ctx.StringValue("ListAppInstanceGroup.AppInstanceGroupModels["+ i +"].RegionId");
				data.ProductType = _ctx.StringValue("ListAppInstanceGroup.AppInstanceGroupModels["+ i +"].ProductType");
				data.AppInstanceType = _ctx.StringValue("ListAppInstanceGroup.AppInstanceGroupModels["+ i +"].AppInstanceType");
				data.AppInstanceGroupId = _ctx.StringValue("ListAppInstanceGroup.AppInstanceGroupModels["+ i +"].AppInstanceGroupId");
				data.Cpu = _ctx.StringValue("ListAppInstanceGroup.AppInstanceGroupModels["+ i +"].Cpu");
				data.Gpu = _ctx.StringValue("ListAppInstanceGroup.AppInstanceGroupModels["+ i +"].Gpu");
				data.Memory = _ctx.LongValue("ListAppInstanceGroup.AppInstanceGroupModels["+ i +"].Memory");
				data.Amount = _ctx.IntegerValue("ListAppInstanceGroup.AppInstanceGroupModels["+ i +"].Amount");
				data.MinAmount = _ctx.IntegerValue("ListAppInstanceGroup.AppInstanceGroupModels["+ i +"].MinAmount");
				data.MaxAmount = _ctx.IntegerValue("ListAppInstanceGroup.AppInstanceGroupModels["+ i +"].MaxAmount");
				data.ChargeType = _ctx.StringValue("ListAppInstanceGroup.AppInstanceGroupModels["+ i +"].ChargeType");
				data.GmtCreate = _ctx.StringValue("ListAppInstanceGroup.AppInstanceGroupModels["+ i +"].GmtCreate");
				data.Status = _ctx.StringValue("ListAppInstanceGroup.AppInstanceGroupModels["+ i +"].Status");
				data.SpecId = _ctx.StringValue("ListAppInstanceGroup.AppInstanceGroupModels["+ i +"].SpecId");
				data.SessionTimeout = _ctx.StringValue("ListAppInstanceGroup.AppInstanceGroupModels["+ i +"].SessionTimeout");
				data.AppInstanceGroupName = _ctx.StringValue("ListAppInstanceGroup.AppInstanceGroupModels["+ i +"].AppInstanceGroupName");
				data.ExpiredTime = _ctx.StringValue("ListAppInstanceGroup.AppInstanceGroupModels["+ i +"].ExpiredTime");
				data.OsType = _ctx.StringValue("ListAppInstanceGroup.AppInstanceGroupModels["+ i +"].OsType");
				data.ResourceStatus = _ctx.StringValue("ListAppInstanceGroup.AppInstanceGroupModels["+ i +"].ResourceStatus");
				data.AppPolicyId = _ctx.StringValue("ListAppInstanceGroup.AppInstanceGroupModels["+ i +"].AppPolicyId");
				data.ChargeResourceMode = _ctx.StringValue("ListAppInstanceGroup.AppInstanceGroupModels["+ i +"].ChargeResourceMode");

				ListAppInstanceGroupResponse.ListAppInstanceGroup_Data.ListAppInstanceGroup_OtaInfo otaInfo = new ListAppInstanceGroupResponse.ListAppInstanceGroup_Data.ListAppInstanceGroup_OtaInfo();
				otaInfo.OtaVersion = _ctx.StringValue("ListAppInstanceGroup.AppInstanceGroupModels["+ i +"].OtaInfo.OtaVersion");
				otaInfo.NewOtaVersion = _ctx.StringValue("ListAppInstanceGroup.AppInstanceGroupModels["+ i +"].OtaInfo.NewOtaVersion");
				otaInfo.TaskId = _ctx.StringValue("ListAppInstanceGroup.AppInstanceGroupModels["+ i +"].OtaInfo.TaskId");
				data.OtaInfo = otaInfo;

				List<ListAppInstanceGroupResponse.ListAppInstanceGroup_Data.ListAppInstanceGroup_AppsItem> data_apps = new List<ListAppInstanceGroupResponse.ListAppInstanceGroup_Data.ListAppInstanceGroup_AppsItem>();
				for (int j = 0; j < _ctx.Length("ListAppInstanceGroup.AppInstanceGroupModels["+ i +"].Apps.Length"); j++) {
					ListAppInstanceGroupResponse.ListAppInstanceGroup_Data.ListAppInstanceGroup_AppsItem appsItem = new ListAppInstanceGroupResponse.ListAppInstanceGroup_Data.ListAppInstanceGroup_AppsItem();
					appsItem.AppId = _ctx.StringValue("ListAppInstanceGroup.AppInstanceGroupModels["+ i +"].Apps["+ j +"].AppId");
					appsItem.AppName = _ctx.StringValue("ListAppInstanceGroup.AppInstanceGroupModels["+ i +"].Apps["+ j +"].AppName");
					appsItem.AppVersion = _ctx.StringValue("ListAppInstanceGroup.AppInstanceGroupModels["+ i +"].Apps["+ j +"].AppVersion");
					appsItem.AppVersionName = _ctx.StringValue("ListAppInstanceGroup.AppInstanceGroupModels["+ i +"].Apps["+ j +"].AppVersionName");
					appsItem.AppIcon = _ctx.StringValue("ListAppInstanceGroup.AppInstanceGroupModels["+ i +"].Apps["+ j +"].AppIcon");

					data_apps.Add(appsItem);
				}
				data.Apps = data_apps;

				List<ListAppInstanceGroupResponse.ListAppInstanceGroup_Data.ListAppInstanceGroup_Node> data_nodePool = new List<ListAppInstanceGroupResponse.ListAppInstanceGroup_Data.ListAppInstanceGroup_Node>();
				for (int j = 0; j < _ctx.Length("ListAppInstanceGroup.AppInstanceGroupModels["+ i +"].NodePool.Length"); j++) {
					ListAppInstanceGroupResponse.ListAppInstanceGroup_Data.ListAppInstanceGroup_Node node = new ListAppInstanceGroupResponse.ListAppInstanceGroup_Data.ListAppInstanceGroup_Node();
					node.NodePoolId = _ctx.StringValue("ListAppInstanceGroup.AppInstanceGroupModels["+ i +"].NodePool["+ j +"].NodePoolId");
					node.NodeInstanceType = _ctx.StringValue("ListAppInstanceGroup.AppInstanceGroupModels["+ i +"].NodePool["+ j +"].NodeInstanceType");
					node.NodeAmount = _ctx.IntegerValue("ListAppInstanceGroup.AppInstanceGroupModels["+ i +"].NodePool["+ j +"].NodeAmount");
					node.NodeUsed = _ctx.IntegerValue("ListAppInstanceGroup.AppInstanceGroupModels["+ i +"].NodePool["+ j +"].NodeUsed");
					node.NodeCapacity = _ctx.IntegerValue("ListAppInstanceGroup.AppInstanceGroupModels["+ i +"].NodePool["+ j +"].NodeCapacity");
					node.ScalingNodeAmount = _ctx.IntegerValue("ListAppInstanceGroup.AppInstanceGroupModels["+ i +"].NodePool["+ j +"].ScalingNodeAmount");
					node.ScalingNodeUsed = _ctx.IntegerValue("ListAppInstanceGroup.AppInstanceGroupModels["+ i +"].NodePool["+ j +"].ScalingNodeUsed");
					node.StrategyType = _ctx.StringValue("ListAppInstanceGroup.AppInstanceGroupModels["+ i +"].NodePool["+ j +"].StrategyType");
					node.Amount = _ctx.IntegerValue("ListAppInstanceGroup.AppInstanceGroupModels["+ i +"].NodePool["+ j +"].Amount");
					node.MaxScalingAmount = _ctx.IntegerValue("ListAppInstanceGroup.AppInstanceGroupModels["+ i +"].NodePool["+ j +"].MaxScalingAmount");
					node.ScalingStep = _ctx.IntegerValue("ListAppInstanceGroup.AppInstanceGroupModels["+ i +"].NodePool["+ j +"].ScalingStep");
					node.ScalingUsageThreshold = _ctx.StringValue("ListAppInstanceGroup.AppInstanceGroupModels["+ i +"].NodePool["+ j +"].ScalingUsageThreshold");
					node.ScalingDownAfterIdleMinutes = _ctx.IntegerValue("ListAppInstanceGroup.AppInstanceGroupModels["+ i +"].NodePool["+ j +"].ScalingDownAfterIdleMinutes");
					node.StrategyDisableDate = _ctx.StringValue("ListAppInstanceGroup.AppInstanceGroupModels["+ i +"].NodePool["+ j +"].StrategyDisableDate");
					node.StrategyEnableDate = _ctx.StringValue("ListAppInstanceGroup.AppInstanceGroupModels["+ i +"].NodePool["+ j +"].StrategyEnableDate");
					node.WarmUp = _ctx.BooleanValue("ListAppInstanceGroup.AppInstanceGroupModels["+ i +"].NodePool["+ j +"].WarmUp");
					node.NodeTypeName = _ctx.StringValue("ListAppInstanceGroup.AppInstanceGroupModels["+ i +"].NodePool["+ j +"].NodeTypeName");

					List<ListAppInstanceGroupResponse.ListAppInstanceGroup_Data.ListAppInstanceGroup_Node.ListAppInstanceGroup_RecurrenceSchedule> node_recurrenceSchedules = new List<ListAppInstanceGroupResponse.ListAppInstanceGroup_Data.ListAppInstanceGroup_Node.ListAppInstanceGroup_RecurrenceSchedule>();
					for (int k = 0; k < _ctx.Length("ListAppInstanceGroup.AppInstanceGroupModels["+ i +"].NodePool["+ j +"].RecurrenceSchedules.Length"); k++) {
						ListAppInstanceGroupResponse.ListAppInstanceGroup_Data.ListAppInstanceGroup_Node.ListAppInstanceGroup_RecurrenceSchedule recurrenceSchedule = new ListAppInstanceGroupResponse.ListAppInstanceGroup_Data.ListAppInstanceGroup_Node.ListAppInstanceGroup_RecurrenceSchedule();
						recurrenceSchedule.RecurrenceType = _ctx.StringValue("ListAppInstanceGroup.AppInstanceGroupModels["+ i +"].NodePool["+ j +"].RecurrenceSchedules["+ k +"].RecurrenceType");

						List<string> recurrenceSchedule_recurrenceValues = new List<string>();
						for (int l = 0; l < _ctx.Length("ListAppInstanceGroup.AppInstanceGroupModels["+ i +"].NodePool["+ j +"].RecurrenceSchedules["+ k +"].RecurrenceValues.Length"); l++) {
							recurrenceSchedule_recurrenceValues.Add(_ctx.StringValue("ListAppInstanceGroup.AppInstanceGroupModels["+ i +"].NodePool["+ j +"].RecurrenceSchedules["+ k +"].RecurrenceValues["+ l +"]"));
						}
						recurrenceSchedule.RecurrenceValues = recurrenceSchedule_recurrenceValues;

						List<ListAppInstanceGroupResponse.ListAppInstanceGroup_Data.ListAppInstanceGroup_Node.ListAppInstanceGroup_RecurrenceSchedule.ListAppInstanceGroup_TimerPeriod> recurrenceSchedule_timerPeriods = new List<ListAppInstanceGroupResponse.ListAppInstanceGroup_Data.ListAppInstanceGroup_Node.ListAppInstanceGroup_RecurrenceSchedule.ListAppInstanceGroup_TimerPeriod>();
						for (int l = 0; l < _ctx.Length("ListAppInstanceGroup.AppInstanceGroupModels["+ i +"].NodePool["+ j +"].RecurrenceSchedules["+ k +"].TimerPeriods.Length"); l++) {
							ListAppInstanceGroupResponse.ListAppInstanceGroup_Data.ListAppInstanceGroup_Node.ListAppInstanceGroup_RecurrenceSchedule.ListAppInstanceGroup_TimerPeriod timerPeriod = new ListAppInstanceGroupResponse.ListAppInstanceGroup_Data.ListAppInstanceGroup_Node.ListAppInstanceGroup_RecurrenceSchedule.ListAppInstanceGroup_TimerPeriod();
							timerPeriod.Amount = _ctx.IntegerValue("ListAppInstanceGroup.AppInstanceGroupModels["+ i +"].NodePool["+ j +"].RecurrenceSchedules["+ k +"].TimerPeriods["+ l +"].Amount");
							timerPeriod.EndTime = _ctx.StringValue("ListAppInstanceGroup.AppInstanceGroupModels["+ i +"].NodePool["+ j +"].RecurrenceSchedules["+ k +"].TimerPeriods["+ l +"].EndTime");
							timerPeriod.StartTime = _ctx.StringValue("ListAppInstanceGroup.AppInstanceGroupModels["+ i +"].NodePool["+ j +"].RecurrenceSchedules["+ k +"].TimerPeriods["+ l +"].StartTime");

							recurrenceSchedule_timerPeriods.Add(timerPeriod);
						}
						recurrenceSchedule.TimerPeriods = recurrenceSchedule_timerPeriods;

						node_recurrenceSchedules.Add(recurrenceSchedule);
					}
					node.RecurrenceSchedules = node_recurrenceSchedules;

					data_nodePool.Add(node);
				}
				data.NodePool = data_nodePool;

				listAppInstanceGroupResponse_appInstanceGroupModels.Add(data);
			}
			listAppInstanceGroupResponse.AppInstanceGroupModels = listAppInstanceGroupResponse_appInstanceGroupModels;
        
			return listAppInstanceGroupResponse;
        }
    }
}
