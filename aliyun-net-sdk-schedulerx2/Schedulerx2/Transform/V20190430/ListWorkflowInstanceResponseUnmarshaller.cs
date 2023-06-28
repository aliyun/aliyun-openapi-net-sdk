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
using Aliyun.Acs.schedulerx2.Model.V20190430;

namespace Aliyun.Acs.schedulerx2.Transform.V20190430
{
    public class ListWorkflowInstanceResponseUnmarshaller
    {
        public static ListWorkflowInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListWorkflowInstanceResponse listWorkflowInstanceResponse = new ListWorkflowInstanceResponse();

			listWorkflowInstanceResponse.HttpResponse = _ctx.HttpResponse;
			listWorkflowInstanceResponse.RequestId = _ctx.StringValue("ListWorkflowInstance.RequestId");
			listWorkflowInstanceResponse.Code = _ctx.IntegerValue("ListWorkflowInstance.Code");
			listWorkflowInstanceResponse.Success = _ctx.BooleanValue("ListWorkflowInstance.Success");
			listWorkflowInstanceResponse.Message = _ctx.StringValue("ListWorkflowInstance.Message");

			ListWorkflowInstanceResponse.ListWorkflowInstance_Data data = new ListWorkflowInstanceResponse.ListWorkflowInstance_Data();

			List<ListWorkflowInstanceResponse.ListWorkflowInstance_Data.ListWorkflowInstance_WfInstanceInfosItem> data_wfInstanceInfos = new List<ListWorkflowInstanceResponse.ListWorkflowInstance_Data.ListWorkflowInstance_WfInstanceInfosItem>();
			for (int i = 0; i < _ctx.Length("ListWorkflowInstance.Data.WfInstanceInfos.Length"); i++) {
				ListWorkflowInstanceResponse.ListWorkflowInstance_Data.ListWorkflowInstance_WfInstanceInfosItem wfInstanceInfosItem = new ListWorkflowInstanceResponse.ListWorkflowInstance_Data.ListWorkflowInstance_WfInstanceInfosItem();
				wfInstanceInfosItem.WfInstanceId = _ctx.LongValue("ListWorkflowInstance.Data.WfInstanceInfos["+ i +"].WfInstanceId");
				wfInstanceInfosItem.WorkflowId = _ctx.LongValue("ListWorkflowInstance.Data.WfInstanceInfos["+ i +"].WorkflowId");
				wfInstanceInfosItem.Status = _ctx.IntegerValue("ListWorkflowInstance.Data.WfInstanceInfos["+ i +"].Status");
				wfInstanceInfosItem.StartTime = _ctx.StringValue("ListWorkflowInstance.Data.WfInstanceInfos["+ i +"].StartTime");
				wfInstanceInfosItem.EndTime = _ctx.StringValue("ListWorkflowInstance.Data.WfInstanceInfos["+ i +"].EndTime");
				wfInstanceInfosItem.ScheduleTime = _ctx.StringValue("ListWorkflowInstance.Data.WfInstanceInfos["+ i +"].ScheduleTime");
				wfInstanceInfosItem.DataTime = _ctx.StringValue("ListWorkflowInstance.Data.WfInstanceInfos["+ i +"].DataTime");

				data_wfInstanceInfos.Add(wfInstanceInfosItem);
			}
			data.WfInstanceInfos = data_wfInstanceInfos;
			listWorkflowInstanceResponse.Data = data;
        
			return listWorkflowInstanceResponse;
        }
    }
}
