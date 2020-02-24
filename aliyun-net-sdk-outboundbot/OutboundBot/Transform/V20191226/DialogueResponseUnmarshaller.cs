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
        public static DialogueResponse Unmarshall(UnmarshallerContext context)
        {
			DialogueResponse dialogueResponse = new DialogueResponse();

			dialogueResponse.HttpResponse = context.HttpResponse;
			dialogueResponse.RequestId = context.StringValue("Dialogue.RequestId");
			dialogueResponse.Success = context.BooleanValue("Dialogue.Success");
			dialogueResponse.Code = context.StringValue("Dialogue.Code");
			dialogueResponse.Message = context.StringValue("Dialogue.Message");
			dialogueResponse.HttpStatusCode = context.IntegerValue("Dialogue.HttpStatusCode");

			DialogueResponse.Dialogue_Feedback feedback = new DialogueResponse.Dialogue_Feedback();
			feedback.Content = context.StringValue("Dialogue.Feedback.Content");
			feedback.Action = context.StringValue("Dialogue.Feedback.Action");
			feedback.ActionParams = context.StringValue("Dialogue.Feedback.ActionParams");
			feedback.Interruptible = context.BooleanValue("Dialogue.Feedback.Interruptible");
			dialogueResponse.Feedback = feedback;
        
			return dialogueResponse;
        }
    }
}
