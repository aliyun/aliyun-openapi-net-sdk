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
    public class CopyPlaybookResponseUnmarshaller
    {
        public static CopyPlaybookResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CopyPlaybookResponse copyPlaybookResponse = new CopyPlaybookResponse();

			copyPlaybookResponse.HttpResponse = _ctx.HttpResponse;
			copyPlaybookResponse.RequestId = _ctx.StringValue("CopyPlaybook.RequestId");

			CopyPlaybookResponse.CopyPlaybook_Data data = new CopyPlaybookResponse.CopyPlaybook_Data();
			data.DisplayName = _ctx.StringValue("CopyPlaybook.Data.DisplayName");
			data.PlaybookUuid = _ctx.StringValue("CopyPlaybook.Data.PlaybookUuid");
			data.OwnType = _ctx.StringValue("CopyPlaybook.Data.OwnType");
			data.Active = _ctx.IntegerValue("CopyPlaybook.Data.Active");
			data.LastRuntime = _ctx.LongValue("CopyPlaybook.Data.LastRuntime");
			data.Permission = _ctx.IntegerValue("CopyPlaybook.Data.Permission");
			data.GmtCreate = _ctx.LongValue("CopyPlaybook.Data.GmtCreate");
			data.GmtModified = _ctx.LongValue("CopyPlaybook.Data.GmtModified");
			data.HistoryMd5 = _ctx.IntegerValue("CopyPlaybook.Data.HistoryMd5");
			data.SuccNum = _ctx.IntegerValue("CopyPlaybook.Data.SuccNum");
			data.FailNum = _ctx.IntegerValue("CopyPlaybook.Data.FailNum");
			data.FailRate = _ctx.DoubleValue("CopyPlaybook.Data.FailRate");
			data.InputParams = _ctx.StringValue("CopyPlaybook.Data.InputParams");
			data.OutputParams = _ctx.StringValue("CopyPlaybook.Data.OutputParams");
			data.Description = _ctx.StringValue("CopyPlaybook.Data.Description");
			data.LogicReleaseTaskflowMd5 = _ctx.StringValue("CopyPlaybook.Data.LogicReleaseTaskflowMd5");
			data.PlaybookStatus = _ctx.IntegerValue("CopyPlaybook.Data.PlaybookStatus");
			data.TenantId = _ctx.StringValue("CopyPlaybook.Data.TenantId");
			copyPlaybookResponse.Data = data;

			CopyPlaybookResponse.CopyPlaybook_Page page = new CopyPlaybookResponse.CopyPlaybook_Page();
			page.TotalCount = _ctx.IntegerValue("CopyPlaybook.Page.TotalCount");
			page.PageNumber = _ctx.IntegerValue("CopyPlaybook.Page.PageNumber");
			page.PageSize = _ctx.IntegerValue("CopyPlaybook.Page.PageSize");
			copyPlaybookResponse.Page = page;
        
			return copyPlaybookResponse;
        }
    }
}
