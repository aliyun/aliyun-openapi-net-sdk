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
using Aliyun.Acs.teambition_aliyun.Model.V20200226;

namespace Aliyun.Acs.teambition_aliyun.Transform.V20200226
{
    public class ListProjectTaskFlowStatusResponseUnmarshaller
    {
        public static ListProjectTaskFlowStatusResponse Unmarshall(UnmarshallerContext context)
        {
			ListProjectTaskFlowStatusResponse listProjectTaskFlowStatusResponse = new ListProjectTaskFlowStatusResponse();

			listProjectTaskFlowStatusResponse.HttpResponse = context.HttpResponse;
			listProjectTaskFlowStatusResponse.Successful = context.BooleanValue("ListProjectTaskFlowStatus.Successful");
			listProjectTaskFlowStatusResponse.ErrorCode = context.StringValue("ListProjectTaskFlowStatus.ErrorCode");
			listProjectTaskFlowStatusResponse.ErrorMsg = context.StringValue("ListProjectTaskFlowStatus.ErrorMsg");
			listProjectTaskFlowStatusResponse.RequestId = context.StringValue("ListProjectTaskFlowStatus.RequestId");

			List<ListProjectTaskFlowStatusResponse.ListProjectTaskFlowStatus_TaskflowStatus> listProjectTaskFlowStatusResponse_object = new List<ListProjectTaskFlowStatusResponse.ListProjectTaskFlowStatus_TaskflowStatus>();
			for (int i = 0; i < context.Length("ListProjectTaskFlowStatus.Object.Length"); i++) {
				ListProjectTaskFlowStatusResponse.ListProjectTaskFlowStatus_TaskflowStatus taskflowStatus = new ListProjectTaskFlowStatusResponse.ListProjectTaskFlowStatus_TaskflowStatus();
				taskflowStatus.IsDeleted = context.BooleanValue("ListProjectTaskFlowStatus.Object["+ i +"].IsDeleted");
				taskflowStatus.RejectStatusIds = context.StringValue("ListProjectTaskFlowStatus.Object["+ i +"].RejectStatusIds");
				taskflowStatus.Pos = context.IntegerValue("ListProjectTaskFlowStatus.Object["+ i +"].Pos");
				taskflowStatus.Kind = context.StringValue("ListProjectTaskFlowStatus.Object["+ i +"].Kind");
				taskflowStatus.Created = context.StringValue("ListProjectTaskFlowStatus.Object["+ i +"].Created");
				taskflowStatus.TaskflowId = context.StringValue("ListProjectTaskFlowStatus.Object["+ i +"].TaskflowId");
				taskflowStatus.Name = context.StringValue("ListProjectTaskFlowStatus.Object["+ i +"].Name");
				taskflowStatus.CreatorId = context.StringValue("ListProjectTaskFlowStatus.Object["+ i +"].CreatorId");
				taskflowStatus.Id = context.StringValue("ListProjectTaskFlowStatus.Object["+ i +"].Id");
				taskflowStatus.Updated = context.StringValue("ListProjectTaskFlowStatus.Object["+ i +"].Updated");

				listProjectTaskFlowStatusResponse_object.Add(taskflowStatus);
			}
			listProjectTaskFlowStatusResponse._Object = listProjectTaskFlowStatusResponse_object;
        
			return listProjectTaskFlowStatusResponse;
        }
    }
}
