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
    public class ListDialogueFlowsResponseUnmarshaller
    {
        public static ListDialogueFlowsResponse Unmarshall(UnmarshallerContext context)
        {
			ListDialogueFlowsResponse listDialogueFlowsResponse = new ListDialogueFlowsResponse();

			listDialogueFlowsResponse.HttpResponse = context.HttpResponse;
			listDialogueFlowsResponse.RequestId = context.StringValue("ListDialogueFlows.RequestId");
			listDialogueFlowsResponse.Success = context.BooleanValue("ListDialogueFlows.Success");
			listDialogueFlowsResponse.Code = context.StringValue("ListDialogueFlows.Code");
			listDialogueFlowsResponse.Message = context.StringValue("ListDialogueFlows.Message");
			listDialogueFlowsResponse.HttpStatusCode = context.IntegerValue("ListDialogueFlows.HttpStatusCode");

			List<ListDialogueFlowsResponse.ListDialogueFlows_DialogueFlow> listDialogueFlowsResponse_dialogueFlows = new List<ListDialogueFlowsResponse.ListDialogueFlows_DialogueFlow>();
			for (int i = 0; i < context.Length("ListDialogueFlows.DialogueFlows.Length"); i++) {
				ListDialogueFlowsResponse.ListDialogueFlows_DialogueFlow dialogueFlow = new ListDialogueFlowsResponse.ListDialogueFlows_DialogueFlow();
				dialogueFlow.DialogueFlowId = context.StringValue("ListDialogueFlows.DialogueFlows["+ i +"].DialogueFlowId");
				dialogueFlow.DialogueFlowName = context.StringValue("ListDialogueFlows.DialogueFlows["+ i +"].DialogueFlowName");
				dialogueFlow.ScriptId = context.StringValue("ListDialogueFlows.DialogueFlows["+ i +"].ScriptId");
				dialogueFlow.ScriptVersion = context.StringValue("ListDialogueFlows.DialogueFlows["+ i +"].ScriptVersion");
				dialogueFlow.DialogueFlowType = context.StringValue("ListDialogueFlows.DialogueFlows["+ i +"].DialogueFlowType");
				dialogueFlow.DialogueFlowDefinition = context.StringValue("ListDialogueFlows.DialogueFlows["+ i +"].DialogueFlowDefinition");

				listDialogueFlowsResponse_dialogueFlows.Add(dialogueFlow);
			}
			listDialogueFlowsResponse.DialogueFlows = listDialogueFlowsResponse_dialogueFlows;
        
			return listDialogueFlowsResponse;
        }
    }
}
