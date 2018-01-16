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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Mts.Model.V20140618;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Mts.Transform.V20140618
{
    public class UpdateMediaWorkflowResponseUnmarshaller
    {
        public static UpdateMediaWorkflowResponse Unmarshall(UnmarshallerContext context)
        {
			UpdateMediaWorkflowResponse updateMediaWorkflowResponse = new UpdateMediaWorkflowResponse();

			updateMediaWorkflowResponse.HttpResponse = context.HttpResponse;
			updateMediaWorkflowResponse.RequestId = context.StringValue("UpdateMediaWorkflow.RequestId");

			UpdateMediaWorkflowResponse.UpdateMediaWorkflow_MediaWorkflow mediaWorkflow = new UpdateMediaWorkflowResponse.UpdateMediaWorkflow_MediaWorkflow();
			mediaWorkflow.MediaWorkflowId = context.StringValue("UpdateMediaWorkflow.MediaWorkflow.MediaWorkflowId");
			mediaWorkflow.Name = context.StringValue("UpdateMediaWorkflow.MediaWorkflow.Name");
			mediaWorkflow.Topology = context.StringValue("UpdateMediaWorkflow.MediaWorkflow.Topology");
			mediaWorkflow.TriggerMode = context.StringValue("UpdateMediaWorkflow.MediaWorkflow.TriggerMode");
			mediaWorkflow.State = context.StringValue("UpdateMediaWorkflow.MediaWorkflow.State");
			mediaWorkflow.CreationTime = context.StringValue("UpdateMediaWorkflow.MediaWorkflow.CreationTime");
			updateMediaWorkflowResponse.MediaWorkflow = mediaWorkflow;
        
			return updateMediaWorkflowResponse;
        }
    }
}