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
			details.TaskName = _ctx.StringValue("DescribeSoarTaskAndActions.Details.TaskName");
			details.StartTime = _ctx.LongValue("DescribeSoarTaskAndActions.Details.StartTime");
			details.EndTime = _ctx.LongValue("DescribeSoarTaskAndActions.Details.EndTime");
			details.Status = _ctx.StringValue("DescribeSoarTaskAndActions.Details.Status");
			details.RequestUuid = _ctx.StringValue("DescribeSoarTaskAndActions.Details.RequestUuid");
			details.TaskUuid = _ctx.StringValue("DescribeSoarTaskAndActions.Details.TaskUuid");
			details.TriggerUser = _ctx.StringValue("DescribeSoarTaskAndActions.Details.TriggerUser");
			details.ErrorMsg = _ctx.StringValue("DescribeSoarTaskAndActions.Details.ErrorMsg");
			details.RawEventReq = _ctx.StringValue("DescribeSoarTaskAndActions.Details.RawEventReq");
			details.TaskFlowMd5 = _ctx.StringValue("DescribeSoarTaskAndActions.Details.TaskFlowMd5");
			details.ActionLogNum = _ctx.IntegerValue("DescribeSoarTaskAndActions.Details.ActionLogNum");

			List<DescribeSoarTaskAndActionsResponse.DescribeSoarTaskAndActions_Details.DescribeSoarTaskAndActions_Action> details_actions = new List<DescribeSoarTaskAndActionsResponse.DescribeSoarTaskAndActions_Details.DescribeSoarTaskAndActions_Action>();
			for (int i = 0; i < _ctx.Length("DescribeSoarTaskAndActions.Details.Actions.Length"); i++) {
				DescribeSoarTaskAndActionsResponse.DescribeSoarTaskAndActions_Details.DescribeSoarTaskAndActions_Action action = new DescribeSoarTaskAndActionsResponse.DescribeSoarTaskAndActions_Details.DescribeSoarTaskAndActions_Action();
				action.Component = _ctx.StringValue("DescribeSoarTaskAndActions.Details.Actions["+ i +"].Component");
				action.Action = _ctx.StringValue("DescribeSoarTaskAndActions.Details.Actions["+ i +"].Action");
				action.StartTime = _ctx.LongValue("DescribeSoarTaskAndActions.Details.Actions["+ i +"].StartTime");
				action.EndTime = _ctx.LongValue("DescribeSoarTaskAndActions.Details.Actions["+ i +"].EndTime");
				action.Status = _ctx.StringValue("DescribeSoarTaskAndActions.Details.Actions["+ i +"].Status");
				action.ActionUuid = _ctx.StringValue("DescribeSoarTaskAndActions.Details.Actions["+ i +"].ActionUuid");
				action.AssetName = _ctx.StringValue("DescribeSoarTaskAndActions.Details.Actions["+ i +"].AssetName");
				action.NodeName = _ctx.StringValue("DescribeSoarTaskAndActions.Details.Actions["+ i +"].NodeName");
				action.NodeId = _ctx.StringValue("DescribeSoarTaskAndActions.Details.Actions["+ i +"].NodeId");
				action.NodeType = _ctx.StringValue("DescribeSoarTaskAndActions.Details.Actions["+ i +"].NodeType");

				details_actions.Add(action);
			}
			details.Actions = details_actions;
			describeSoarTaskAndActionsResponse.Details = details;

			DescribeSoarTaskAndActionsResponse.DescribeSoarTaskAndActions_Page page = new DescribeSoarTaskAndActionsResponse.DescribeSoarTaskAndActions_Page();
			page.TotalCount = _ctx.StringValue("DescribeSoarTaskAndActions.Page.TotalCount");
			page.PageNumber = _ctx.StringValue("DescribeSoarTaskAndActions.Page.PageNumber");
			page.PageSize = _ctx.StringValue("DescribeSoarTaskAndActions.Page.PageSize");
			describeSoarTaskAndActionsResponse.Page = page;
        
			return describeSoarTaskAndActionsResponse;
        }
    }
}
