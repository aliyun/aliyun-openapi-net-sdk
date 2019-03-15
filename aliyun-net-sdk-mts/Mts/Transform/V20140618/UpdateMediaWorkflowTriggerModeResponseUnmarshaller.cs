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
    public class UpdateMediaWorkflowTriggerModeResponseUnmarshaller
    {
        public static UpdateMediaWorkflowTriggerModeResponse Unmarshall(UnmarshallerContext context)
        {
			UpdateMediaWorkflowTriggerModeResponse updateMediaWorkflowTriggerModeResponse = new UpdateMediaWorkflowTriggerModeResponse();

			updateMediaWorkflowTriggerModeResponse.HttpResponse = context.HttpResponse;
			updateMediaWorkflowTriggerModeResponse.RequestId = context.StringValue("UpdateMediaWorkflowTriggerMode.RequestId");

			UpdateMediaWorkflowTriggerModeResponse.UpdateMediaWorkflowTriggerMode_MediaWorkflow mediaWorkflow = new UpdateMediaWorkflowTriggerModeResponse.UpdateMediaWorkflowTriggerMode_MediaWorkflow();
			mediaWorkflow.MediaWorkflowId = context.StringValue("UpdateMediaWorkflowTriggerMode.MediaWorkflow.MediaWorkflowId");
			mediaWorkflow.Name = context.StringValue("UpdateMediaWorkflowTriggerMode.MediaWorkflow.Name");
			mediaWorkflow.Topology = context.StringValue("UpdateMediaWorkflowTriggerMode.MediaWorkflow.Topology");
			mediaWorkflow.TriggerMode = context.StringValue("UpdateMediaWorkflowTriggerMode.MediaWorkflow.TriggerMode");
			mediaWorkflow.State = context.StringValue("UpdateMediaWorkflowTriggerMode.MediaWorkflow.State");
			mediaWorkflow.CreationTime = context.StringValue("UpdateMediaWorkflowTriggerMode.MediaWorkflow.CreationTime");
			updateMediaWorkflowTriggerModeResponse.MediaWorkflow = mediaWorkflow;
        
			return updateMediaWorkflowTriggerModeResponse;
        }
    }
}
