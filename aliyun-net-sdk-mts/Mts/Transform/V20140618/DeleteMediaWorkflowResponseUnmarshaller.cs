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
using Aliyun.Acs.Mts.Model.V20140618;

namespace Aliyun.Acs.Mts.Transform.V20140618
{
    public class DeleteMediaWorkflowResponseUnmarshaller
    {
        public static DeleteMediaWorkflowResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DeleteMediaWorkflowResponse deleteMediaWorkflowResponse = new DeleteMediaWorkflowResponse();

			deleteMediaWorkflowResponse.HttpResponse = _ctx.HttpResponse;
			deleteMediaWorkflowResponse.RequestId = _ctx.StringValue("DeleteMediaWorkflow.RequestId");

			DeleteMediaWorkflowResponse.DeleteMediaWorkflow_MediaWorkflow mediaWorkflow = new DeleteMediaWorkflowResponse.DeleteMediaWorkflow_MediaWorkflow();
			mediaWorkflow.CreationTime = _ctx.StringValue("DeleteMediaWorkflow.MediaWorkflow.CreationTime");
			mediaWorkflow.MediaWorkflowId = _ctx.StringValue("DeleteMediaWorkflow.MediaWorkflow.MediaWorkflowId");
			mediaWorkflow.State = _ctx.StringValue("DeleteMediaWorkflow.MediaWorkflow.State");
			mediaWorkflow.Name = _ctx.StringValue("DeleteMediaWorkflow.MediaWorkflow.Name");
			mediaWorkflow.Topology = _ctx.StringValue("DeleteMediaWorkflow.MediaWorkflow.Topology");
			deleteMediaWorkflowResponse.MediaWorkflow = mediaWorkflow;
        
			return deleteMediaWorkflowResponse;
        }
    }
}
