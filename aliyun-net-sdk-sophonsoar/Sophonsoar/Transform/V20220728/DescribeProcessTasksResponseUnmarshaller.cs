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
    public class DescribeProcessTasksResponseUnmarshaller
    {
        public static DescribeProcessTasksResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeProcessTasksResponse describeProcessTasksResponse = new DescribeProcessTasksResponse();

			describeProcessTasksResponse.HttpResponse = _ctx.HttpResponse;
			describeProcessTasksResponse.RequestId = _ctx.StringValue("DescribeProcessTasks.RequestId");

			DescribeProcessTasksResponse.DescribeProcessTasks_Page page = new DescribeProcessTasksResponse.DescribeProcessTasks_Page();
			page.TotalCount = _ctx.IntegerValue("DescribeProcessTasks.Page.TotalCount");
			page.PageNumber = _ctx.IntegerValue("DescribeProcessTasks.Page.PageNumber");
			page.PageSize = _ctx.IntegerValue("DescribeProcessTasks.Page.PageSize");
			describeProcessTasksResponse.Page = page;

			List<DescribeProcessTasksResponse.DescribeProcessTasks_Data> describeProcessTasksResponse_processTasks = new List<DescribeProcessTasksResponse.DescribeProcessTasks_Data>();
			for (int i = 0; i < _ctx.Length("DescribeProcessTasks.ProcessTasks.Length"); i++) {
				DescribeProcessTasksResponse.DescribeProcessTasks_Data data = new DescribeProcessTasksResponse.DescribeProcessTasks_Data();
				data.TaskId = _ctx.StringValue("DescribeProcessTasks.ProcessTasks["+ i +"].TaskId");
				data.Creator = _ctx.StringValue("DescribeProcessTasks.ProcessTasks["+ i +"].Creator");
				data.GmtCreateMillis = _ctx.LongValue("DescribeProcessTasks.ProcessTasks["+ i +"].GmtCreateMillis");
				data.GmtModifiedMillis = _ctx.LongValue("DescribeProcessTasks.ProcessTasks["+ i +"].GmtModifiedMillis");
				data.TaskName = _ctx.StringValue("DescribeProcessTasks.ProcessTasks["+ i +"].TaskName");
				data.YunCode = _ctx.StringValue("DescribeProcessTasks.ProcessTasks["+ i +"].YunCode");
				data.EntityName = _ctx.StringValue("DescribeProcessTasks.ProcessTasks["+ i +"].EntityName");
				data.EntityType = _ctx.StringValue("DescribeProcessTasks.ProcessTasks["+ i +"].EntityType");
				data.EntityValue = _ctx.StringValue("DescribeProcessTasks.ProcessTasks["+ i +"].EntityValue");
				data.EntityKey = _ctx.StringValue("DescribeProcessTasks.ProcessTasks["+ i +"].EntityKey");
				data.TaskStatus = _ctx.IntegerValue("DescribeProcessTasks.ProcessTasks["+ i +"].TaskStatus");
				data.Scope = _ctx.StringValue("DescribeProcessTasks.ProcessTasks["+ i +"].Scope");
				data.InputParams = _ctx.StringValue("DescribeProcessTasks.ProcessTasks["+ i +"].InputParams");
				data.SceneCode = _ctx.StringValue("DescribeProcessTasks.ProcessTasks["+ i +"].SceneCode");
				data.SceneName = _ctx.StringValue("DescribeProcessTasks.ProcessTasks["+ i +"].SceneName");
				data.ProcessTime = _ctx.LongValue("DescribeProcessTasks.ProcessTasks["+ i +"].ProcessTime");
				data.RemoveTime = _ctx.LongValue("DescribeProcessTasks.ProcessTasks["+ i +"].RemoveTime");
				data.ProcessStrategyUuid = _ctx.StringValue("DescribeProcessTasks.ProcessTasks["+ i +"].ProcessStrategyUuid");
				data.TenantId = _ctx.StringValue("DescribeProcessTasks.ProcessTasks["+ i +"].TenantId");
				data.Source = _ctx.StringValue("DescribeProcessTasks.ProcessTasks["+ i +"].Source");
				data.RemoveFlag = _ctx.IntegerValue("DescribeProcessTasks.ProcessTasks["+ i +"].RemoveFlag");
				data.RetryFlag = _ctx.IntegerValue("DescribeProcessTasks.ProcessTasks["+ i +"].RetryFlag");
				data.ErrCode = _ctx.StringValue("DescribeProcessTasks.ProcessTasks["+ i +"].ErrCode");
				data.ErrMsg = _ctx.StringValue("DescribeProcessTasks.ProcessTasks["+ i +"].ErrMsg");
				data.ErrTip = _ctx.StringValue("DescribeProcessTasks.ProcessTasks["+ i +"].ErrTip");
				data.EntityUuid = _ctx.StringValue("DescribeProcessTasks.ProcessTasks["+ i +"].EntityUuid");
				data.EventUuid = _ctx.StringValue("DescribeProcessTasks.ProcessTasks["+ i +"].EventUuid");
				data.ReqUuid = _ctx.StringValue("DescribeProcessTasks.ProcessTasks["+ i +"].ReqUuid");
				data.TriggerSource = _ctx.StringValue("DescribeProcessTasks.ProcessTasks["+ i +"].TriggerSource");

				describeProcessTasksResponse_processTasks.Add(data);
			}
			describeProcessTasksResponse.ProcessTasks = describeProcessTasksResponse_processTasks;
        
			return describeProcessTasksResponse;
        }
    }
}
