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
using Aliyun.Acs.OutboundBot.Model.V20191226;

namespace Aliyun.Acs.OutboundBot.Transform.V20191226
{
    public class CreateDialogueFlowResponseUnmarshaller
    {
        public static CreateDialogueFlowResponse Unmarshall(UnmarshallerContext context)
        {
			CreateDialogueFlowResponse createDialogueFlowResponse = new CreateDialogueFlowResponse();

			createDialogueFlowResponse.HttpResponse = context.HttpResponse;
			createDialogueFlowResponse.RequestId = context.StringValue("CreateDialogueFlow.RequestId");
			createDialogueFlowResponse.Success = context.BooleanValue("CreateDialogueFlow.Success");
			createDialogueFlowResponse.Code = context.StringValue("CreateDialogueFlow.Code");
			createDialogueFlowResponse.Message = context.StringValue("CreateDialogueFlow.Message");
			createDialogueFlowResponse.HttpStatusCode = context.IntegerValue("CreateDialogueFlow.HttpStatusCode");
			createDialogueFlowResponse.DialogueFlowId = context.StringValue("CreateDialogueFlow.DialogueFlowId");
        
			return createDialogueFlowResponse;
        }
    }
}
