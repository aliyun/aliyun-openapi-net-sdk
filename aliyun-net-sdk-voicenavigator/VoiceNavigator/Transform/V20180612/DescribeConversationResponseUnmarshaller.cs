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
        public static DescribeConversationResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeConversationResponse describeConversationResponse = new DescribeConversationResponse();

			describeConversationResponse.HttpResponse = context.HttpResponse;
			describeConversationResponse.RequestId = context.StringValue("DescribeConversation.RequestId");
			describeConversationResponse.CallingNumber = context.StringValue("DescribeConversation.CallingNumber");
			describeConversationResponse.BeginTime = context.LongValue("DescribeConversation.BeginTime");
			describeConversationResponse.EndTime = context.LongValue("DescribeConversation.EndTime");
			describeConversationResponse.TransferredToAgent = context.BooleanValue("DescribeConversation.TransferredToAgent");
			describeConversationResponse.SkillGroupId = context.StringValue("DescribeConversation.SkillGroupId");
			describeConversationResponse.UserUtteranceCount = context.IntegerValue("DescribeConversation.UserUtteranceCount");
			describeConversationResponse.EffectiveAnswerCount = context.IntegerValue("DescribeConversation.EffectiveAnswerCount");
			describeConversationResponse.ConversationId = context.StringValue("DescribeConversation.ConversationId");
        
			return describeConversationResponse;
        }
    }
}
