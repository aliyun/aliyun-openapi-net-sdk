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
    public class DescribeAlarmEventListResponseUnmarshaller
    {
        public static DescribeAlarmEventListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAlarmEventListResponse describeAlarmEventListResponse = new DescribeAlarmEventListResponse();

			describeAlarmEventListResponse.HttpResponse = _ctx.HttpResponse;
			describeAlarmEventListResponse.RequestId = _ctx.StringValue("DescribeAlarmEventList.RequestId");

			DescribeAlarmEventListResponse.DescribeAlarmEventList_PageInfo pageInfo = new DescribeAlarmEventListResponse.DescribeAlarmEventList_PageInfo();
			pageInfo.CurrentPage = _ctx.IntegerValue("DescribeAlarmEventList.PageInfo.CurrentPage");
			pageInfo.PageSize = _ctx.IntegerValue("DescribeAlarmEventList.PageInfo.PageSize");
			pageInfo.TotalCount = _ctx.IntegerValue("DescribeAlarmEventList.PageInfo.TotalCount");
			pageInfo.Count = _ctx.IntegerValue("DescribeAlarmEventList.PageInfo.Count");
			describeAlarmEventListResponse.PageInfo = pageInfo;

			List<DescribeAlarmEventListResponse.DescribeAlarmEventList_SuspEventsItem> describeAlarmEventListResponse_suspEvents = new List<DescribeAlarmEventListResponse.DescribeAlarmEventList_SuspEventsItem>();
			for (int i = 0; i < _ctx.Length("DescribeAlarmEventList.SuspEvents.Length"); i++) {
				DescribeAlarmEventListResponse.DescribeAlarmEventList_SuspEventsItem suspEventsItem = new DescribeAlarmEventListResponse.DescribeAlarmEventList_SuspEventsItem();
				suspEventsItem.Dealed = _ctx.BooleanValue("DescribeAlarmEventList.SuspEvents["+ i +"].Dealed");
				suspEventsItem.Stages = _ctx.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].Stages");
				suspEventsItem.InternetIp = _ctx.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].InternetIp");
				suspEventsItem.SuspiciousEventCount = _ctx.IntegerValue("DescribeAlarmEventList.SuspEvents["+ i +"].SuspiciousEventCount");
				suspEventsItem.K8sClusterName = _ctx.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].K8sClusterName");
				suspEventsItem.ContainerImageId = _ctx.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].ContainerImageId");
				suspEventsItem.GmtModified = _ctx.LongValue("DescribeAlarmEventList.SuspEvents["+ i +"].GmtModified");
				suspEventsItem.AlarmEventNameOriginal = _ctx.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].AlarmEventNameOriginal");
				suspEventsItem.AlarmUniqueInfo = _ctx.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].AlarmUniqueInfo");
				suspEventsItem.CanCancelFault = _ctx.BooleanValue("DescribeAlarmEventList.SuspEvents["+ i +"].CanCancelFault");
				suspEventsItem.AppName = _ctx.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].AppName");
				suspEventsItem.SecurityEventIds = _ctx.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].SecurityEventIds");
				suspEventsItem.K8sClusterId = _ctx.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].K8sClusterId");
				suspEventsItem.ContainerImageName = _ctx.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].ContainerImageName");
				suspEventsItem.CanBeDealOnLine = _ctx.BooleanValue("DescribeAlarmEventList.SuspEvents["+ i +"].CanBeDealOnLine");
				suspEventsItem.Description = _ctx.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].Description");
				suspEventsItem.ContainHwMode = _ctx.BooleanValue("DescribeAlarmEventList.SuspEvents["+ i +"].ContainHwMode");
				suspEventsItem.K8sNodeId = _ctx.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].K8sNodeId");
				suspEventsItem.InstanceName = _ctx.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].InstanceName");
				suspEventsItem.SaleVersion = _ctx.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].SaleVersion");
				suspEventsItem.OperateErrorCode = _ctx.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].OperateErrorCode");
				suspEventsItem.Solution = _ctx.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].Solution");
				suspEventsItem.HasTraceInfo = _ctx.BooleanValue("DescribeAlarmEventList.SuspEvents["+ i +"].HasTraceInfo");
				suspEventsItem.DataSource = _ctx.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].DataSource");
				suspEventsItem.OperateTime = _ctx.LongValue("DescribeAlarmEventList.SuspEvents["+ i +"].OperateTime");
				suspEventsItem.InstanceId = _ctx.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].InstanceId");
				suspEventsItem.IntranetIp = _ctx.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].IntranetIp");
				suspEventsItem.EndTime = _ctx.LongValue("DescribeAlarmEventList.SuspEvents["+ i +"].EndTime");
				suspEventsItem.Uuid = _ctx.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].Uuid");
				suspEventsItem.StartTime = _ctx.LongValue("DescribeAlarmEventList.SuspEvents["+ i +"].StartTime");
				suspEventsItem.K8sPodName = _ctx.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].K8sPodName");
				suspEventsItem.ContainerId = _ctx.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].ContainerId");
				suspEventsItem.AlarmEventType = _ctx.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].AlarmEventType");
				suspEventsItem.K8sNamespace = _ctx.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].K8sNamespace");
				suspEventsItem.K8sNodeName = _ctx.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].K8sNodeName");
				suspEventsItem.AlarmEventName = _ctx.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].AlarmEventName");
				suspEventsItem.Level = _ctx.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].Level");

				List<DescribeAlarmEventListResponse.DescribeAlarmEventList_SuspEventsItem.DescribeAlarmEventList_TacticItem> suspEventsItem_tacticItems = new List<DescribeAlarmEventListResponse.DescribeAlarmEventList_SuspEventsItem.DescribeAlarmEventList_TacticItem>();
				for (int j = 0; j < _ctx.Length("DescribeAlarmEventList.SuspEvents["+ i +"].TacticItems.Length"); j++) {
					DescribeAlarmEventListResponse.DescribeAlarmEventList_SuspEventsItem.DescribeAlarmEventList_TacticItem tacticItem = new DescribeAlarmEventListResponse.DescribeAlarmEventList_SuspEventsItem.DescribeAlarmEventList_TacticItem();
					tacticItem.TacticId = _ctx.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].TacticItems["+ j +"].TacticId");
					tacticItem.TacticDisplayName = _ctx.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].TacticItems["+ j +"].TacticDisplayName");

					suspEventsItem_tacticItems.Add(tacticItem);
				}
				suspEventsItem.TacticItems = suspEventsItem_tacticItems;

				describeAlarmEventListResponse_suspEvents.Add(suspEventsItem);
			}
			describeAlarmEventListResponse.SuspEvents = describeAlarmEventListResponse_suspEvents;
        
			return describeAlarmEventListResponse;
        }
    }
}
