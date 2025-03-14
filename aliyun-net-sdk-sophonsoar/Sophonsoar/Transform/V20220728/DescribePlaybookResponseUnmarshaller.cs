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
    public class DescribePlaybookResponseUnmarshaller
    {
        public static DescribePlaybookResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePlaybookResponse describePlaybookResponse = new DescribePlaybookResponse();

			describePlaybookResponse.HttpResponse = _ctx.HttpResponse;
			describePlaybookResponse.RequestId = _ctx.StringValue("DescribePlaybook.RequestId");

			DescribePlaybookResponse.DescribePlaybook_Playbook playbook = new DescribePlaybookResponse.DescribePlaybook_Playbook();
			playbook.GmtCreate = _ctx.StringValue("DescribePlaybook.Playbook.GmtCreate");
			playbook.GmtModified = _ctx.StringValue("DescribePlaybook.Playbook.GmtModified");
			playbook.PlaybookUuid = _ctx.StringValue("DescribePlaybook.Playbook.PlaybookUuid");
			playbook.Taskflow = _ctx.StringValue("DescribePlaybook.Playbook.Taskflow");
			playbook.TaskflowType = _ctx.StringValue("DescribePlaybook.Playbook.TaskflowType");
			playbook.Taskconfig = _ctx.StringValue("DescribePlaybook.Playbook.Taskconfig");
			playbook.TenantId = _ctx.StringValue("DescribePlaybook.Playbook.TenantId");
			playbook.Inputtype = _ctx.StringValue("DescribePlaybook.Playbook.Inputtype");
			playbook.OwnType = _ctx.StringValue("DescribePlaybook.Playbook.OwnType");
			playbook.SuccessExeNum = _ctx.IntegerValue("DescribePlaybook.Playbook.SuccessExeNum");
			playbook.FailExeNum = _ctx.IntegerValue("DescribePlaybook.Playbook.FailExeNum");
			playbook.LastExeTime = _ctx.LongValue("DescribePlaybook.Playbook.LastExeTime");
			playbook.TriggerInfo = _ctx.StringValue("DescribePlaybook.Playbook.TriggerInfo");
			playbook.OperateType = _ctx.StringValue("DescribePlaybook.Playbook.OperateType");
			playbook.DisplayName = _ctx.StringValue("DescribePlaybook.Playbook.DisplayName");
			playbook.RiskLevel = _ctx.IntegerValue("DescribePlaybook.Playbook.RiskLevel");
			playbook.Type = _ctx.StringValue("DescribePlaybook.Playbook.Type");
			playbook.InputParams = _ctx.StringValue("DescribePlaybook.Playbook.InputParams");
			playbook.Description = _ctx.StringValue("DescribePlaybook.Playbook.Description");
			playbook.Oss = _ctx.StringValue("DescribePlaybook.Playbook.Oss");
			playbook.Active = _ctx.BooleanValue("DescribePlaybook.Playbook.Active");
			playbook.Compiledresult = _ctx.StringValue("DescribePlaybook.Playbook.Compiledresult");
			playbook.OnlineOss = _ctx.StringValue("DescribePlaybook.Playbook.OnlineOss");
			playbook.OnlineActive = _ctx.BooleanValue("DescribePlaybook.Playbook.OnlineActive");
			playbook.OnlineCompiledresult = _ctx.StringValue("DescribePlaybook.Playbook.OnlineCompiledresult");
			playbook.ExecuteMode = _ctx.StringValue("DescribePlaybook.Playbook.ExecuteMode");
			playbook.Cron = _ctx.StringValue("DescribePlaybook.Playbook.Cron");
			playbook.OnlineExecuteMode = _ctx.StringValue("DescribePlaybook.Playbook.OnlineExecuteMode");
			playbook.OnlineCron = _ctx.StringValue("DescribePlaybook.Playbook.OnlineCron");
			playbook.SchedulerId = _ctx.LongValue("DescribePlaybook.Playbook.SchedulerId");
			playbook.OnlineSchedulerId = _ctx.LongValue("DescribePlaybook.Playbook.OnlineSchedulerId");
			playbook.ParentId = _ctx.IntegerValue("DescribePlaybook.Playbook.ParentId");
			playbook.OutputParams = _ctx.StringValue("DescribePlaybook.Playbook.OutputParams");
			playbook.TaskflowMd5 = _ctx.StringValue("DescribePlaybook.Playbook.TaskflowMd5");
			playbook.OnlineReleaseUuid = _ctx.StringValue("DescribePlaybook.Playbook.OnlineReleaseUuid");
			playbook.OnlineReleaseTime = _ctx.StringValue("DescribePlaybook.Playbook.OnlineReleaseTime");
			playbook.ReleaseUuid = _ctx.StringValue("DescribePlaybook.Playbook.ReleaseUuid");
			playbook.ReleaseTime = _ctx.StringValue("DescribePlaybook.Playbook.ReleaseTime");
			playbook.OnlineReleaseTaskflowMd5 = _ctx.StringValue("DescribePlaybook.Playbook.OnlineReleaseTaskflowMd5");
			playbook.ReleaseTaskflowMd5 = _ctx.StringValue("DescribePlaybook.Playbook.ReleaseTaskflowMd5");
			playbook.Flag = _ctx.IntegerValue("DescribePlaybook.Playbook.Flag");
			playbook.RightLevel = _ctx.StringValue("DescribePlaybook.Playbook.RightLevel");
			playbook.TaskFlowDesc = _ctx.StringValue("DescribePlaybook.Playbook.TaskFlowDesc");
			playbook.DebugFlag = _ctx.StringValue("DescribePlaybook.Playbook.DebugFlag");
			playbook.PlaybookStatus = _ctx.IntegerValue("DescribePlaybook.Playbook.PlaybookStatus");
			describePlaybookResponse.Playbook = playbook;
        
			return describePlaybookResponse;
        }
    }
}
