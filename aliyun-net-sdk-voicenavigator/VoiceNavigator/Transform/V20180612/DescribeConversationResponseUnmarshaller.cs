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
using Aliyun.Acs.VoiceNavigator.Model.V20180612;

namespace Aliyun.Acs.VoiceNavigator.Transform.V20180612
{
    public class DescribeConversationResponseUnmarshaller
    {
        public static DescribeConversationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeConversationResponse describeConversationResponse = new DescribeConversationResponse();

			describeConversationResponse.HttpResponse = _ctx.HttpResponse;
			describeConversationResponse.EffectiveAnswerCount = _ctx.IntegerValue("DescribeConversation.EffectiveAnswerCount");
			describeConversationResponse.ConversationId = _ctx.StringValue("DescribeConversation.ConversationId");
			describeConversationResponse.TransferredToAgent = _ctx.BooleanValue("DescribeConversation.TransferredToAgent");
			describeConversationResponse.EndTime = _ctx.LongValue("DescribeConversation.EndTime");
			describeConversationResponse.RequestId = _ctx.StringValue("DescribeConversation.RequestId");
			describeConversationResponse.BeginTime = _ctx.LongValue("DescribeConversation.BeginTime");
			describeConversationResponse.SkillGroupId = _ctx.StringValue("DescribeConversation.SkillGroupId");
			describeConversationResponse.CallingNumber = _ctx.StringValue("DescribeConversation.CallingNumber");
			describeConversationResponse.UserUtteranceCount = _ctx.IntegerValue("DescribeConversation.UserUtteranceCount");
        
			return describeConversationResponse;
        }
    }
}
