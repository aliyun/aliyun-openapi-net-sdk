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
    public class DialogueResponseUnmarshaller
    {
        public static DialogueResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DialogueResponse dialogueResponse = new DialogueResponse();

			dialogueResponse.HttpResponse = _ctx.HttpResponse;
			dialogueResponse.Code = _ctx.StringValue("Dialogue.Code");
			dialogueResponse.HttpStatusCode = _ctx.IntegerValue("Dialogue.HttpStatusCode");
			dialogueResponse.Message = _ctx.StringValue("Dialogue.Message");
			dialogueResponse.RequestId = _ctx.StringValue("Dialogue.RequestId");
			dialogueResponse.Success = _ctx.BooleanValue("Dialogue.Success");

			DialogueResponse.Dialogue_Feedback feedback = new DialogueResponse.Dialogue_Feedback();
			feedback.Action = _ctx.StringValue("Dialogue.Feedback.Action");
			feedback.ActionParams = _ctx.StringValue("Dialogue.Feedback.ActionParams");
			feedback.Content = _ctx.StringValue("Dialogue.Feedback.Content");
			feedback.Interruptible = _ctx.BooleanValue("Dialogue.Feedback.Interruptible");
			dialogueResponse.Feedback = feedback;
        
			return dialogueResponse;
        }
    }
}
