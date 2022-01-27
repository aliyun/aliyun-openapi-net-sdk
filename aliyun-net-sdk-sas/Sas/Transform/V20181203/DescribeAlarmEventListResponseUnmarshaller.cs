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
			pageInfo.Count = _ctx.IntegerValue("DescribeAlarmEventList.PageInfo.Count");
			pageInfo.PageSize = _ctx.IntegerValue("DescribeAlarmEventList.PageInfo.PageSize");
			pageInfo.TotalCount = _ctx.IntegerValue("DescribeAlarmEventList.PageInfo.TotalCount");
			pageInfo.CurrentPage = _ctx.IntegerValue("DescribeAlarmEventList.PageInfo.CurrentPage");
			describeAlarmEventListResponse.PageInfo = pageInfo;

			List<DescribeAlarmEventListResponse.DescribeAlarmEventList_SuspEventsItem> describeAlarmEventListResponse_suspEvents = new List<DescribeAlarmEventListResponse.DescribeAlarmEventList_SuspEventsItem>();
			for (int i = 0; i < _ctx.Length("DescribeAlarmEventList.SuspEvents.Length"); i++) {
				DescribeAlarmEventListResponse.DescribeAlarmEventList_SuspEventsItem suspEventsItem = new DescribeAlarmEventListResponse.DescribeAlarmEventList_SuspEventsItem();
				suspEventsItem.AlarmUniqueInfo = _ctx.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].AlarmUniqueInfo");
				suspEventsItem.Solution = _ctx.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].Solution");
				suspEventsItem.Level = _ctx.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].Level");
				suspEventsItem.CanBeDealOnLine = _ctx.BooleanValue("DescribeAlarmEventList.SuspEvents["+ i +"].CanBeDealOnLine");
				suspEventsItem.Description = _ctx.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].Description");
				suspEventsItem.StartTime = _ctx.LongValue("DescribeAlarmEventList.SuspEvents["+ i +"].StartTime");
				suspEventsItem.EndTime = _ctx.LongValue("DescribeAlarmEventList.SuspEvents["+ i +"].EndTime");
				suspEventsItem.OperateTime = _ctx.LongValue("DescribeAlarmEventList.SuspEvents["+ i +"].OperateTime");
				suspEventsItem.AlarmEventType = _ctx.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].AlarmEventType");
				suspEventsItem.SuspiciousEventCount = _ctx.IntegerValue("DescribeAlarmEventList.SuspEvents["+ i +"].SuspiciousEventCount");
				suspEventsItem.Uuid = _ctx.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].Uuid");
				suspEventsItem.InstanceName = _ctx.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].InstanceName");
				suspEventsItem.InternetIp = _ctx.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].InternetIp");
				suspEventsItem.IntranetIp = _ctx.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].IntranetIp");
				suspEventsItem.AlarmEventName = _ctx.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].AlarmEventName");
				suspEventsItem.SaleVersion = _ctx.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].SaleVersion");
				suspEventsItem.DataSource = _ctx.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].DataSource");
				suspEventsItem.CanCancelFault = _ctx.BooleanValue("DescribeAlarmEventList.SuspEvents["+ i +"].CanCancelFault");
				suspEventsItem.Dealed = _ctx.BooleanValue("DescribeAlarmEventList.SuspEvents["+ i +"].Dealed");
				suspEventsItem.GmtModified = _ctx.LongValue("DescribeAlarmEventList.SuspEvents["+ i +"].GmtModified");
				suspEventsItem.HasTraceInfo = _ctx.BooleanValue("DescribeAlarmEventList.SuspEvents["+ i +"].HasTraceInfo");
				suspEventsItem.SecurityEventIds = _ctx.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].SecurityEventIds");
				suspEventsItem.OperateErrorCode = _ctx.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].OperateErrorCode");
				suspEventsItem.AlarmEventNameOriginal = _ctx.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].AlarmEventNameOriginal");
				suspEventsItem.InstanceId = _ctx.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].InstanceId");
				suspEventsItem.ContainHwMode = _ctx.BooleanValue("DescribeAlarmEventList.SuspEvents["+ i +"].ContainHwMode");
				suspEventsItem.Stages = _ctx.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].Stages");
				suspEventsItem.ContainerImageId = _ctx.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].ContainerImageId");
				suspEventsItem.ContainerImageName = _ctx.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].ContainerImageName");
				suspEventsItem.ContainerId = _ctx.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].ContainerId");
				suspEventsItem.K8sNamespace = _ctx.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].K8sNamespace");
				suspEventsItem.K8sClusterId = _ctx.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].K8sClusterId");
				suspEventsItem.K8sClusterName = _ctx.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].K8sClusterName");
				suspEventsItem.K8sNodeId = _ctx.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].K8sNodeId");
				suspEventsItem.K8sPodName = _ctx.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].K8sPodName");
				suspEventsItem.K8sNodeName = _ctx.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].K8sNodeName");
				suspEventsItem.AppName = _ctx.StringValue("DescribeAlarmEventList.SuspEvents["+ i +"].AppName");

				describeAlarmEventListResponse_suspEvents.Add(suspEventsItem);
			}
			describeAlarmEventListResponse.SuspEvents = describeAlarmEventListResponse_suspEvents;
        
			return describeAlarmEventListResponse;
        }
    }
}
