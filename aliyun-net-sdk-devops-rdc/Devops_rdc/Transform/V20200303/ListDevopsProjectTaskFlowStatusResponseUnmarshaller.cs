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
using Aliyun.Acs.devops_rdc.Model.V20200303;

namespace Aliyun.Acs.devops_rdc.Transform.V20200303
{
    public class ListDevopsProjectTaskFlowStatusResponseUnmarshaller
    {
        public static ListDevopsProjectTaskFlowStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDevopsProjectTaskFlowStatusResponse listDevopsProjectTaskFlowStatusResponse = new ListDevopsProjectTaskFlowStatusResponse();

			listDevopsProjectTaskFlowStatusResponse.HttpResponse = _ctx.HttpResponse;
			listDevopsProjectTaskFlowStatusResponse.Successful = _ctx.BooleanValue("ListDevopsProjectTaskFlowStatus.Successful");
			listDevopsProjectTaskFlowStatusResponse.ErrorCode = _ctx.StringValue("ListDevopsProjectTaskFlowStatus.ErrorCode");
			listDevopsProjectTaskFlowStatusResponse.ErrorMsg = _ctx.StringValue("ListDevopsProjectTaskFlowStatus.ErrorMsg");
			listDevopsProjectTaskFlowStatusResponse.RequestId = _ctx.StringValue("ListDevopsProjectTaskFlowStatus.RequestId");

			List<ListDevopsProjectTaskFlowStatusResponse.ListDevopsProjectTaskFlowStatus_TaskflowStatus> listDevopsProjectTaskFlowStatusResponse_object = new List<ListDevopsProjectTaskFlowStatusResponse.ListDevopsProjectTaskFlowStatus_TaskflowStatus>();
			for (int i = 0; i < _ctx.Length("ListDevopsProjectTaskFlowStatus.Object.Length"); i++) {
				ListDevopsProjectTaskFlowStatusResponse.ListDevopsProjectTaskFlowStatus_TaskflowStatus taskflowStatus = new ListDevopsProjectTaskFlowStatusResponse.ListDevopsProjectTaskFlowStatus_TaskflowStatus();
				taskflowStatus.IsDeleted = _ctx.BooleanValue("ListDevopsProjectTaskFlowStatus.Object["+ i +"].IsDeleted");
				taskflowStatus.RejectStatusIds = _ctx.StringValue("ListDevopsProjectTaskFlowStatus.Object["+ i +"].RejectStatusIds");
				taskflowStatus.Pos = _ctx.IntegerValue("ListDevopsProjectTaskFlowStatus.Object["+ i +"].Pos");
				taskflowStatus.Kind = _ctx.StringValue("ListDevopsProjectTaskFlowStatus.Object["+ i +"].Kind");
				taskflowStatus.Created = _ctx.StringValue("ListDevopsProjectTaskFlowStatus.Object["+ i +"].Created");
				taskflowStatus.TaskflowId = _ctx.StringValue("ListDevopsProjectTaskFlowStatus.Object["+ i +"].TaskflowId");
				taskflowStatus.Name = _ctx.StringValue("ListDevopsProjectTaskFlowStatus.Object["+ i +"].Name");
				taskflowStatus.CreatorId = _ctx.StringValue("ListDevopsProjectTaskFlowStatus.Object["+ i +"].CreatorId");
				taskflowStatus.Id = _ctx.StringValue("ListDevopsProjectTaskFlowStatus.Object["+ i +"].Id");
				taskflowStatus.Updated = _ctx.StringValue("ListDevopsProjectTaskFlowStatus.Object["+ i +"].Updated");

				listDevopsProjectTaskFlowStatusResponse_object.Add(taskflowStatus);
			}
			listDevopsProjectTaskFlowStatusResponse._Object = listDevopsProjectTaskFlowStatusResponse_object;
        
			return listDevopsProjectTaskFlowStatusResponse;
        }
    }
}
