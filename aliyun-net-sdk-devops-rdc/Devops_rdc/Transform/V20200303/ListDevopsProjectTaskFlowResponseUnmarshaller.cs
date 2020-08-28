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
    public class ListDevopsProjectTaskFlowResponseUnmarshaller
    {
        public static ListDevopsProjectTaskFlowResponse Unmarshall(UnmarshallerContext context)
        {
			ListDevopsProjectTaskFlowResponse listDevopsProjectTaskFlowResponse = new ListDevopsProjectTaskFlowResponse();

			listDevopsProjectTaskFlowResponse.HttpResponse = context.HttpResponse;
			listDevopsProjectTaskFlowResponse.Successful = context.BooleanValue("ListDevopsProjectTaskFlow.Successful");
			listDevopsProjectTaskFlowResponse.ErrorCode = context.StringValue("ListDevopsProjectTaskFlow.ErrorCode");
			listDevopsProjectTaskFlowResponse.ErrorMsg = context.StringValue("ListDevopsProjectTaskFlow.ErrorMsg");
			listDevopsProjectTaskFlowResponse.RequestId = context.StringValue("ListDevopsProjectTaskFlow.RequestId");

			List<ListDevopsProjectTaskFlowResponse.ListDevopsProjectTaskFlow_Taskflow> listDevopsProjectTaskFlowResponse_object = new List<ListDevopsProjectTaskFlowResponse.ListDevopsProjectTaskFlow_Taskflow>();
			for (int i = 0; i < context.Length("ListDevopsProjectTaskFlow.Object.Length"); i++) {
				ListDevopsProjectTaskFlowResponse.ListDevopsProjectTaskFlow_Taskflow taskflow = new ListDevopsProjectTaskFlowResponse.ListDevopsProjectTaskFlow_Taskflow();
				taskflow.Id = context.StringValue("ListDevopsProjectTaskFlow.Object["+ i +"].Id");
				taskflow.Type = context.StringValue("ListDevopsProjectTaskFlow.Object["+ i +"].Type");
				taskflow.Name = context.StringValue("ListDevopsProjectTaskFlow.Object["+ i +"].Name");

				listDevopsProjectTaskFlowResponse_object.Add(taskflow);
			}
			listDevopsProjectTaskFlowResponse._Object = listDevopsProjectTaskFlowResponse_object;
        
			return listDevopsProjectTaskFlowResponse;
        }
    }
}
