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
        public static ListDialogueFlowsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDialogueFlowsResponse listDialogueFlowsResponse = new ListDialogueFlowsResponse();

			listDialogueFlowsResponse.HttpResponse = _ctx.HttpResponse;
			listDialogueFlowsResponse.Code = _ctx.StringValue("ListDialogueFlows.Code");
			listDialogueFlowsResponse.HttpStatusCode = _ctx.IntegerValue("ListDialogueFlows.HttpStatusCode");
			listDialogueFlowsResponse.Message = _ctx.StringValue("ListDialogueFlows.Message");
			listDialogueFlowsResponse.RequestId = _ctx.StringValue("ListDialogueFlows.RequestId");
			listDialogueFlowsResponse.Success = _ctx.BooleanValue("ListDialogueFlows.Success");

			List<ListDialogueFlowsResponse.ListDialogueFlows_DialogueFlow> listDialogueFlowsResponse_dialogueFlows = new List<ListDialogueFlowsResponse.ListDialogueFlows_DialogueFlow>();
			for (int i = 0; i < _ctx.Length("ListDialogueFlows.DialogueFlows.Length"); i++) {
				ListDialogueFlowsResponse.ListDialogueFlows_DialogueFlow dialogueFlow = new ListDialogueFlowsResponse.ListDialogueFlows_DialogueFlow();
				dialogueFlow.DialogueFlowDefinition = _ctx.StringValue("ListDialogueFlows.DialogueFlows["+ i +"].DialogueFlowDefinition");
				dialogueFlow.DialogueFlowId = _ctx.StringValue("ListDialogueFlows.DialogueFlows["+ i +"].DialogueFlowId");
				dialogueFlow.DialogueFlowName = _ctx.StringValue("ListDialogueFlows.DialogueFlows["+ i +"].DialogueFlowName");
				dialogueFlow.DialogueFlowType = _ctx.StringValue("ListDialogueFlows.DialogueFlows["+ i +"].DialogueFlowType");
				dialogueFlow.ScriptId = _ctx.StringValue("ListDialogueFlows.DialogueFlows["+ i +"].ScriptId");
				dialogueFlow.ScriptVersion = _ctx.StringValue("ListDialogueFlows.DialogueFlows["+ i +"].ScriptVersion");

				listDialogueFlowsResponse_dialogueFlows.Add(dialogueFlow);
			}
			listDialogueFlowsResponse.DialogueFlows = listDialogueFlowsResponse_dialogueFlows;
        
			return listDialogueFlowsResponse;
        }
    }
}
