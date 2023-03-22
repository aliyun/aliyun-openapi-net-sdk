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
    public class GetAppInstanceGroupResponseUnmarshaller
    {
        public static GetAppInstanceGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetAppInstanceGroupResponse getAppInstanceGroupResponse = new GetAppInstanceGroupResponse();

			getAppInstanceGroupResponse.HttpResponse = _ctx.HttpResponse;
			getAppInstanceGroupResponse.RequestId = _ctx.StringValue("GetAppInstanceGroup.RequestId");
			getAppInstanceGroupResponse.TotalCount = _ctx.IntegerValue("GetAppInstanceGroup.TotalCount");
			getAppInstanceGroupResponse.PageSize = _ctx.IntegerValue("GetAppInstanceGroup.PageSize");
			getAppInstanceGroupResponse.PageNumber = _ctx.IntegerValue("GetAppInstanceGroup.PageNumber");

			GetAppInstanceGroupResponse.GetAppInstanceGroup_AppInstanceGroupModels appInstanceGroupModels = new GetAppInstanceGroupResponse.GetAppInstanceGroup_AppInstanceGroupModels();
			appInstanceGroupModels.AppCenterImageId = _ctx.StringValue("GetAppInstanceGroup.AppInstanceGroupModels.AppCenterImageId");
			appInstanceGroupModels.AliyunImageId = _ctx.StringValue("GetAppInstanceGroup.AppInstanceGroupModels.AliyunImageId");
			appInstanceGroupModels.RegionId = _ctx.StringValue("GetAppInstanceGroup.AppInstanceGroupModels.RegionId");
			appInstanceGroupModels.ProductType = _ctx.StringValue("GetAppInstanceGroup.AppInstanceGroupModels.ProductType");
			appInstanceGroupModels.AppInstanceType = _ctx.StringValue("GetAppInstanceGroup.AppInstanceGroupModels.AppInstanceType");
			appInstanceGroupModels.AppInstanceGroupId = _ctx.StringValue("GetAppInstanceGroup.AppInstanceGroupModels.AppInstanceGroupId");
			appInstanceGroupModels.Cpu = _ctx.StringValue("GetAppInstanceGroup.AppInstanceGroupModels.Cpu");
			appInstanceGroupModels.Gpu = _ctx.StringValue("GetAppInstanceGroup.AppInstanceGroupModels.Gpu");
			appInstanceGroupModels.Memory = _ctx.LongValue("GetAppInstanceGroup.AppInstanceGroupModels.Memory");
			appInstanceGroupModels.Amount = _ctx.IntegerValue("GetAppInstanceGroup.AppInstanceGroupModels.Amount");
			appInstanceGroupModels.MinAmount = _ctx.IntegerValue("GetAppInstanceGroup.AppInstanceGroupModels.MinAmount");
			appInstanceGroupModels.MaxAmount = _ctx.IntegerValue("GetAppInstanceGroup.AppInstanceGroupModels.MaxAmount");
			appInstanceGroupModels.ChargeType = _ctx.StringValue("GetAppInstanceGroup.AppInstanceGroupModels.ChargeType");
			appInstanceGroupModels.GmtCreate = _ctx.StringValue("GetAppInstanceGroup.AppInstanceGroupModels.GmtCreate");
			appInstanceGroupModels.Status = _ctx.StringValue("GetAppInstanceGroup.AppInstanceGroupModels.Status");
			appInstanceGroupModels.SpecId = _ctx.StringValue("GetAppInstanceGroup.AppInstanceGroupModels.SpecId");
			appInstanceGroupModels.SessionTimeout = _ctx.StringValue("GetAppInstanceGroup.AppInstanceGroupModels.SessionTimeout");
			appInstanceGroupModels.AppInstanceGroupName = _ctx.StringValue("GetAppInstanceGroup.AppInstanceGroupModels.AppInstanceGroupName");
			appInstanceGroupModels.ExpiredTime = _ctx.StringValue("GetAppInstanceGroup.AppInstanceGroupModels.ExpiredTime");
			appInstanceGroupModels.OsType = _ctx.StringValue("GetAppInstanceGroup.AppInstanceGroupModels.OsType");
			appInstanceGroupModels.AppCenterImageName = _ctx.StringValue("GetAppInstanceGroup.AppInstanceGroupModels.AppCenterImageName");
			appInstanceGroupModels.ResourceStatus = _ctx.StringValue("GetAppInstanceGroup.AppInstanceGroupModels.ResourceStatus");

			GetAppInstanceGroupResponse.GetAppInstanceGroup_AppInstanceGroupModels.GetAppInstanceGroup_OtaInfo otaInfo = new GetAppInstanceGroupResponse.GetAppInstanceGroup_AppInstanceGroupModels.GetAppInstanceGroup_OtaInfo();
			otaInfo.OtaVersion = _ctx.StringValue("GetAppInstanceGroup.AppInstanceGroupModels.OtaInfo.OtaVersion");
			otaInfo.NewOtaVersion = _ctx.StringValue("GetAppInstanceGroup.AppInstanceGroupModels.OtaInfo.NewOtaVersion");
			otaInfo.TaskId = _ctx.StringValue("GetAppInstanceGroup.AppInstanceGroupModels.OtaInfo.TaskId");
			appInstanceGroupModels.OtaInfo = otaInfo;

			List<GetAppInstanceGroupResponse.GetAppInstanceGroup_AppInstanceGroupModels.GetAppInstanceGroup_AppsItem> appInstanceGroupModels_apps = new List<GetAppInstanceGroupResponse.GetAppInstanceGroup_AppInstanceGroupModels.GetAppInstanceGroup_AppsItem>();
			for (int i = 0; i < _ctx.Length("GetAppInstanceGroup.AppInstanceGroupModels.Apps.Length"); i++) {
				GetAppInstanceGroupResponse.GetAppInstanceGroup_AppInstanceGroupModels.GetAppInstanceGroup_AppsItem appsItem = new GetAppInstanceGroupResponse.GetAppInstanceGroup_AppInstanceGroupModels.GetAppInstanceGroup_AppsItem();
				appsItem.AppId = _ctx.StringValue("GetAppInstanceGroup.AppInstanceGroupModels.Apps["+ i +"].AppId");
				appsItem.AppName = _ctx.StringValue("GetAppInstanceGroup.AppInstanceGroupModels.Apps["+ i +"].AppName");

				appInstanceGroupModels_apps.Add(appsItem);
			}
			appInstanceGroupModels.Apps = appInstanceGroupModels_apps;

			List<GetAppInstanceGroupResponse.GetAppInstanceGroup_AppInstanceGroupModels.GetAppInstanceGroup_Node> appInstanceGroupModels_nodePool = new List<GetAppInstanceGroupResponse.GetAppInstanceGroup_AppInstanceGroupModels.GetAppInstanceGroup_Node>();
			for (int i = 0; i < _ctx.Length("GetAppInstanceGroup.AppInstanceGroupModels.NodePool.Length"); i++) {
				GetAppInstanceGroupResponse.GetAppInstanceGroup_AppInstanceGroupModels.GetAppInstanceGroup_Node node = new GetAppInstanceGroupResponse.GetAppInstanceGroup_AppInstanceGroupModels.GetAppInstanceGroup_Node();
				node.NodePoolId = _ctx.StringValue("GetAppInstanceGroup.AppInstanceGroupModels.NodePool["+ i +"].NodePoolId");
				node.NodeInstanceType = _ctx.StringValue("GetAppInstanceGroup.AppInstanceGroupModels.NodePool["+ i +"].NodeInstanceType");
				node.NodeAmount = _ctx.IntegerValue("GetAppInstanceGroup.AppInstanceGroupModels.NodePool["+ i +"].NodeAmount");
				node.NodeUsed = _ctx.IntegerValue("GetAppInstanceGroup.AppInstanceGroupModels.NodePool["+ i +"].NodeUsed");
				node.NodeCapacity = _ctx.IntegerValue("GetAppInstanceGroup.AppInstanceGroupModels.NodePool["+ i +"].NodeCapacity");
				node.ScalingNodeAmount = _ctx.IntegerValue("GetAppInstanceGroup.AppInstanceGroupModels.NodePool["+ i +"].ScalingNodeAmount");
				node.ScalingNodeUsed = _ctx.IntegerValue("GetAppInstanceGroup.AppInstanceGroupModels.NodePool["+ i +"].ScalingNodeUsed");
				node.StrategyType = _ctx.StringValue("GetAppInstanceGroup.AppInstanceGroupModels.NodePool["+ i +"].StrategyType");
				node.Amount = _ctx.IntegerValue("GetAppInstanceGroup.AppInstanceGroupModels.NodePool["+ i +"].Amount");
				node.MaxScalingAmount = _ctx.IntegerValue("GetAppInstanceGroup.AppInstanceGroupModels.NodePool["+ i +"].MaxScalingAmount");
				node.ScalingStep = _ctx.IntegerValue("GetAppInstanceGroup.AppInstanceGroupModels.NodePool["+ i +"].ScalingStep");
				node.ScalingUsageThreshold = _ctx.StringValue("GetAppInstanceGroup.AppInstanceGroupModels.NodePool["+ i +"].ScalingUsageThreshold");
				node.ScalingDownAfterIdleMinutes = _ctx.IntegerValue("GetAppInstanceGroup.AppInstanceGroupModels.NodePool["+ i +"].ScalingDownAfterIdleMinutes");
				node.StrategyDisableDate = _ctx.StringValue("GetAppInstanceGroup.AppInstanceGroupModels.NodePool["+ i +"].StrategyDisableDate");
				node.StrategyEnableDate = _ctx.StringValue("GetAppInstanceGroup.AppInstanceGroupModels.NodePool["+ i +"].StrategyEnableDate");
				node.WarmUp = _ctx.BooleanValue("GetAppInstanceGroup.AppInstanceGroupModels.NodePool["+ i +"].WarmUp");
				node.NodeTypeName = _ctx.StringValue("GetAppInstanceGroup.AppInstanceGroupModels.NodePool["+ i +"].NodeTypeName");

				List<GetAppInstanceGroupResponse.GetAppInstanceGroup_AppInstanceGroupModels.GetAppInstanceGroup_Node.GetAppInstanceGroup_RecurrenceSchedule> node_recurrenceSchedules = new List<GetAppInstanceGroupResponse.GetAppInstanceGroup_AppInstanceGroupModels.GetAppInstanceGroup_Node.GetAppInstanceGroup_RecurrenceSchedule>();
				for (int j = 0; j < _ctx.Length("GetAppInstanceGroup.AppInstanceGroupModels.NodePool["+ i +"].RecurrenceSchedules.Length"); j++) {
					GetAppInstanceGroupResponse.GetAppInstanceGroup_AppInstanceGroupModels.GetAppInstanceGroup_Node.GetAppInstanceGroup_RecurrenceSchedule recurrenceSchedule = new GetAppInstanceGroupResponse.GetAppInstanceGroup_AppInstanceGroupModels.GetAppInstanceGroup_Node.GetAppInstanceGroup_RecurrenceSchedule();
					recurrenceSchedule.RecurrenceType = _ctx.StringValue("GetAppInstanceGroup.AppInstanceGroupModels.NodePool["+ i +"].RecurrenceSchedules["+ j +"].RecurrenceType");

					List<string> recurrenceSchedule_recurrenceValues = new List<string>();
					for (int k = 0; k < _ctx.Length("GetAppInstanceGroup.AppInstanceGroupModels.NodePool["+ i +"].RecurrenceSchedules["+ j +"].RecurrenceValues.Length"); k++) {
						recurrenceSchedule_recurrenceValues.Add(_ctx.StringValue("GetAppInstanceGroup.AppInstanceGroupModels.NodePool["+ i +"].RecurrenceSchedules["+ j +"].RecurrenceValues["+ k +"]"));
					}
					recurrenceSchedule.RecurrenceValues = recurrenceSchedule_recurrenceValues;

					List<GetAppInstanceGroupResponse.GetAppInstanceGroup_AppInstanceGroupModels.GetAppInstanceGroup_Node.GetAppInstanceGroup_RecurrenceSchedule.GetAppInstanceGroup_TimerPeriod> recurrenceSchedule_timerPeriods = new List<GetAppInstanceGroupResponse.GetAppInstanceGroup_AppInstanceGroupModels.GetAppInstanceGroup_Node.GetAppInstanceGroup_RecurrenceSchedule.GetAppInstanceGroup_TimerPeriod>();
					for (int k = 0; k < _ctx.Length("GetAppInstanceGroup.AppInstanceGroupModels.NodePool["+ i +"].RecurrenceSchedules["+ j +"].TimerPeriods.Length"); k++) {
						GetAppInstanceGroupResponse.GetAppInstanceGroup_AppInstanceGroupModels.GetAppInstanceGroup_Node.GetAppInstanceGroup_RecurrenceSchedule.GetAppInstanceGroup_TimerPeriod timerPeriod = new GetAppInstanceGroupResponse.GetAppInstanceGroup_AppInstanceGroupModels.GetAppInstanceGroup_Node.GetAppInstanceGroup_RecurrenceSchedule.GetAppInstanceGroup_TimerPeriod();
						timerPeriod.Amount = _ctx.IntegerValue("GetAppInstanceGroup.AppInstanceGroupModels.NodePool["+ i +"].RecurrenceSchedules["+ j +"].TimerPeriods["+ k +"].Amount");
						timerPeriod.EndTime = _ctx.StringValue("GetAppInstanceGroup.AppInstanceGroupModels.NodePool["+ i +"].RecurrenceSchedules["+ j +"].TimerPeriods["+ k +"].EndTime");
						timerPeriod.StartTime = _ctx.StringValue("GetAppInstanceGroup.AppInstanceGroupModels.NodePool["+ i +"].RecurrenceSchedules["+ j +"].TimerPeriods["+ k +"].StartTime");

						recurrenceSchedule_timerPeriods.Add(timerPeriod);
					}
					recurrenceSchedule.TimerPeriods = recurrenceSchedule_timerPeriods;

					node_recurrenceSchedules.Add(recurrenceSchedule);
				}
				node.RecurrenceSchedules = node_recurrenceSchedules;

				appInstanceGroupModels_nodePool.Add(node);
			}
			appInstanceGroupModels.NodePool = appInstanceGroupModels_nodePool;
			getAppInstanceGroupResponse.AppInstanceGroupModels = appInstanceGroupModels;
        
			return getAppInstanceGroupResponse;
        }
    }
}
