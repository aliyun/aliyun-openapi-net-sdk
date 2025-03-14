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
using Aliyun.Acs.sophonsoar.Model.V20220728;

namespace Aliyun.Acs.sophonsoar.Transform.V20220728
{
    public class DescribeSoarTaskAndActionsResponseUnmarshaller
    {
        public static DescribeSoarTaskAndActionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSoarTaskAndActionsResponse describeSoarTaskAndActionsResponse = new DescribeSoarTaskAndActionsResponse();

			describeSoarTaskAndActionsResponse.HttpResponse = _ctx.HttpResponse;
			describeSoarTaskAndActionsResponse.RequestId = _ctx.StringValue("DescribeSoarTaskAndActions.RequestId");

			DescribeSoarTaskAndActionsResponse.DescribeSoarTaskAndActions_Details details = new DescribeSoarTaskAndActionsResponse.DescribeSoarTaskAndActions_Details();
			details.TriggerType = _ctx.StringValue("DescribeSoarTaskAndActions.Details.TriggerType");
			details.TriggerDataId = _ctx.StringValue("DescribeSoarTaskAndActions.Details.TriggerDataId");
			details.Sao = _ctx.StringValue("DescribeSoarTaskAndActions.Details.Sao");
			details.TaskName = _ctx.StringValue("DescribeSoarTaskAndActions.Details.TaskName");
			details.StartTime = _ctx.LongValue("DescribeSoarTaskAndActions.Details.StartTime");
			details.EndTime = _ctx.LongValue("DescribeSoarTaskAndActions.Details.EndTime");
			details.Status = _ctx.StringValue("DescribeSoarTaskAndActions.Details.Status");
			details.Success = _ctx.IntegerValue("DescribeSoarTaskAndActions.Details.Success");
			details.All = _ctx.IntegerValue("DescribeSoarTaskAndActions.Details.All");
			details.RequestUuid = _ctx.StringValue("DescribeSoarTaskAndActions.Details.RequestUuid");
			details.TaskUuid = _ctx.StringValue("DescribeSoarTaskAndActions.Details.TaskUuid");
			details.TriggerUser = _ctx.StringValue("DescribeSoarTaskAndActions.Details.TriggerUser");
			details.ErrorMsg = _ctx.StringValue("DescribeSoarTaskAndActions.Details.ErrorMsg");
			details.DataSourceName = _ctx.StringValue("DescribeSoarTaskAndActions.Details.DataSourceName");
			details.RawEventReq = _ctx.StringValue("DescribeSoarTaskAndActions.Details.RawEventReq");
			details.ResultLevel = _ctx.StringValue("DescribeSoarTaskAndActions.Details.ResultLevel");
			details.ResultMessage = _ctx.StringValue("DescribeSoarTaskAndActions.Details.ResultMessage");
			details.ResultDetailInfo = _ctx.StringValue("DescribeSoarTaskAndActions.Details.ResultDetailInfo");
			details.TaskTenantId = _ctx.StringValue("DescribeSoarTaskAndActions.Details.TaskTenantId");
			details.TaskType = _ctx.StringValue("DescribeSoarTaskAndActions.Details.TaskType");
			details.ActionLogNum = _ctx.IntegerValue("DescribeSoarTaskAndActions.Details.ActionLogNum");
			details.TaskFlowMd5 = _ctx.StringValue("DescribeSoarTaskAndActions.Details.TaskFlowMd5");

			List<DescribeSoarTaskAndActionsResponse.DescribeSoarTaskAndActions_Details.DescribeSoarTaskAndActions_Action> details_actions = new List<DescribeSoarTaskAndActionsResponse.DescribeSoarTaskAndActions_Details.DescribeSoarTaskAndActions_Action>();
			for (int i = 0; i < _ctx.Length("DescribeSoarTaskAndActions.Details.Actions.Length"); i++) {
				DescribeSoarTaskAndActionsResponse.DescribeSoarTaskAndActions_Details.DescribeSoarTaskAndActions_Action action = new DescribeSoarTaskAndActionsResponse.DescribeSoarTaskAndActions_Details.DescribeSoarTaskAndActions_Action();
				action.TriggerType = _ctx.StringValue("DescribeSoarTaskAndActions.Details.Actions["+ i +"].TriggerType");
				action.TriggerDataId = _ctx.StringValue("DescribeSoarTaskAndActions.Details.Actions["+ i +"].TriggerDataId");
				action.Component = _ctx.StringValue("DescribeSoarTaskAndActions.Details.Actions["+ i +"].Component");
				action.Action = _ctx.StringValue("DescribeSoarTaskAndActions.Details.Actions["+ i +"].Action");
				action.StartTime = _ctx.LongValue("DescribeSoarTaskAndActions.Details.Actions["+ i +"].StartTime");
				action.EndTime = _ctx.LongValue("DescribeSoarTaskAndActions.Details.Actions["+ i +"].EndTime");
				action.Status = _ctx.StringValue("DescribeSoarTaskAndActions.Details.Actions["+ i +"].Status");
				action.RequestUuid = _ctx.StringValue("DescribeSoarTaskAndActions.Details.Actions["+ i +"].RequestUuid");
				action.TaskUuid = _ctx.StringValue("DescribeSoarTaskAndActions.Details.Actions["+ i +"].TaskUuid");
				action.SrcHostName = _ctx.StringValue("DescribeSoarTaskAndActions.Details.Actions["+ i +"].SrcHostName");
				action.TriggerUser = _ctx.StringValue("DescribeSoarTaskAndActions.Details.Actions["+ i +"].TriggerUser");
				action.TaskName = _ctx.StringValue("DescribeSoarTaskAndActions.Details.Actions["+ i +"].TaskName");
				action.TaskStatus = _ctx.StringValue("DescribeSoarTaskAndActions.Details.Actions["+ i +"].TaskStatus");
				action.ActionUuid = _ctx.StringValue("DescribeSoarTaskAndActions.Details.Actions["+ i +"].ActionUuid");
				action.DataSourceName = _ctx.StringValue("DescribeSoarTaskAndActions.Details.Actions["+ i +"].DataSourceName");
				action.AssetName = _ctx.StringValue("DescribeSoarTaskAndActions.Details.Actions["+ i +"].AssetName");
				action.NodeName = _ctx.StringValue("DescribeSoarTaskAndActions.Details.Actions["+ i +"].NodeName");
				action.EventId = _ctx.StringValue("DescribeSoarTaskAndActions.Details.Actions["+ i +"].EventId");
				action.NodeId = _ctx.StringValue("DescribeSoarTaskAndActions.Details.Actions["+ i +"].NodeId");
				action.NodeType = _ctx.StringValue("DescribeSoarTaskAndActions.Details.Actions["+ i +"].NodeType");
				action.TaskTenantId = _ctx.StringValue("DescribeSoarTaskAndActions.Details.Actions["+ i +"].TaskTenantId");
				action.TaskType = _ctx.StringValue("DescribeSoarTaskAndActions.Details.Actions["+ i +"].TaskType");
				action.TenantId = _ctx.StringValue("DescribeSoarTaskAndActions.Details.Actions["+ i +"].TenantId");

				details_actions.Add(action);
			}
			details.Actions = details_actions;
			describeSoarTaskAndActionsResponse.Details = details;
        
			return describeSoarTaskAndActionsResponse;
        }
    }
}
