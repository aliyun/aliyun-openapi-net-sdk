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
    public class DescribeConversationContextResponseUnmarshaller
    {
        public static DescribeConversationContextResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeConversationContextResponse describeConversationContextResponse = new DescribeConversationContextResponse();

			describeConversationContextResponse.HttpResponse = context.HttpResponse;
			describeConversationContextResponse.RequestId = context.StringValue("DescribeConversationContext.RequestId");
			describeConversationContextResponse.ConversationContext = context.StringValue("DescribeConversationContext.ConversationContext");
        
			return describeConversationContextResponse;
        }
    }
}
