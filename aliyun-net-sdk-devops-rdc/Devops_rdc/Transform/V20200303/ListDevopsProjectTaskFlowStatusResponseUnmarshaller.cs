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
        public static ListDevopsProjectTaskFlowStatusResponse Unmarshall(UnmarshallerContext context)
        {
			ListDevopsProjectTaskFlowStatusResponse listDevopsProjectTaskFlowStatusResponse = new ListDevopsProjectTaskFlowStatusResponse();

			listDevopsProjectTaskFlowStatusResponse.HttpResponse = context.HttpResponse;
			listDevopsProjectTaskFlowStatusResponse.Successful = context.BooleanValue("ListDevopsProjectTaskFlowStatus.Successful");
			listDevopsProjectTaskFlowStatusResponse.ErrorCode = context.StringValue("ListDevopsProjectTaskFlowStatus.ErrorCode");
			listDevopsProjectTaskFlowStatusResponse.ErrorMsg = context.StringValue("ListDevopsProjectTaskFlowStatus.ErrorMsg");
			listDevopsProjectTaskFlowStatusResponse.RequestId = context.StringValue("ListDevopsProjectTaskFlowStatus.RequestId");

			List<ListDevopsProjectTaskFlowStatusResponse.ListDevopsProjectTaskFlowStatus_TaskflowStatus> listDevopsProjectTaskFlowStatusResponse_object = new List<ListDevopsProjectTaskFlowStatusResponse.ListDevopsProjectTaskFlowStatus_TaskflowStatus>();
			for (int i = 0; i < context.Length("ListDevopsProjectTaskFlowStatus.Object.Length"); i++) {
				ListDevopsProjectTaskFlowStatusResponse.ListDevopsProjectTaskFlowStatus_TaskflowStatus taskflowStatus = new ListDevopsProjectTaskFlowStatusResponse.ListDevopsProjectTaskFlowStatus_TaskflowStatus();
				taskflowStatus.IsDeleted = context.BooleanValue("ListDevopsProjectTaskFlowStatus.Object["+ i +"].IsDeleted");
				taskflowStatus.RejectStatusIds = context.StringValue("ListDevopsProjectTaskFlowStatus.Object["+ i +"].RejectStatusIds");
				taskflowStatus.Pos = context.IntegerValue("ListDevopsProjectTaskFlowStatus.Object["+ i +"].Pos");
				taskflowStatus.Kind = context.StringValue("ListDevopsProjectTaskFlowStatus.Object["+ i +"].Kind");
				taskflowStatus.Created = context.StringValue("ListDevopsProjectTaskFlowStatus.Object["+ i +"].Created");
				taskflowStatus.TaskflowId = context.StringValue("ListDevopsProjectTaskFlowStatus.Object["+ i +"].TaskflowId");
				taskflowStatus.Name = context.StringValue("ListDevopsProjectTaskFlowStatus.Object["+ i +"].Name");
				taskflowStatus.CreatorId = context.StringValue("ListDevopsProjectTaskFlowStatus.Object["+ i +"].CreatorId");
				taskflowStatus.Id = context.StringValue("ListDevopsProjectTaskFlowStatus.Object["+ i +"].Id");
				taskflowStatus.Updated = context.StringValue("ListDevopsProjectTaskFlowStatus.Object["+ i +"].Updated");

				listDevopsProjectTaskFlowStatusResponse_object.Add(taskflowStatus);
			}
			listDevopsProjectTaskFlowStatusResponse._Object = listDevopsProjectTaskFlowStatusResponse_object;
        
			return listDevopsProjectTaskFlowStatusResponse;
        }
    }
}
