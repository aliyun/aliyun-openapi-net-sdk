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
using Aliyun.Acs.linkedmall.Model.V20180116;

namespace Aliyun.Acs.linkedmall.Transform.V20180116
{
    public class RemoveMessagesResponseUnmarshaller
    {
        public static RemoveMessagesResponse Unmarshall(UnmarshallerContext context)
        {
			RemoveMessagesResponse removeMessagesResponse = new RemoveMessagesResponse();

			removeMessagesResponse.HttpResponse = context.HttpResponse;
			removeMessagesResponse.RequestId = context.StringValue("RemoveMessages.RequestId");
			removeMessagesResponse.LogsId = context.StringValue("RemoveMessages.LogsId");
			removeMessagesResponse.SubCode = context.StringValue("RemoveMessages.SubCode");
			removeMessagesResponse.SubMessage = context.StringValue("RemoveMessages.SubMessage");
			removeMessagesResponse.Code = context.StringValue("RemoveMessages.Code");
			removeMessagesResponse.Message = context.StringValue("RemoveMessages.Message");
			removeMessagesResponse.Success = context.BooleanValue("RemoveMessages.Success");

			RemoveMessagesResponse.RemoveMessages_ActionResult actionResult = new RemoveMessagesResponse.RemoveMessages_ActionResult();
			actionResult.ReturnCode = context.StringValue("RemoveMessages.ActionResult.ReturnCode");
			actionResult.ReturnValue = context.StringValue("RemoveMessages.ActionResult.ReturnValue");
			actionResult.ReturnMessage = context.StringValue("RemoveMessages.ActionResult.ReturnMessage");
			removeMessagesResponse.ActionResult = actionResult;
        
			return removeMessagesResponse;
        }
    }
}
