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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class QueryMessageInfoResponseUnmarshaller
    {
        public static QueryMessageInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryMessageInfoResponse queryMessageInfoResponse = new QueryMessageInfoResponse();

			queryMessageInfoResponse.HttpResponse = _ctx.HttpResponse;
			queryMessageInfoResponse.RequestId = _ctx.StringValue("QueryMessageInfo.RequestId");
			queryMessageInfoResponse.Success = _ctx.BooleanValue("QueryMessageInfo.Success");
			queryMessageInfoResponse.ErrorMessage = _ctx.StringValue("QueryMessageInfo.ErrorMessage");
			queryMessageInfoResponse.Code = _ctx.StringValue("QueryMessageInfo.Code");

			QueryMessageInfoResponse.QueryMessageInfo_Message message = new QueryMessageInfoResponse.QueryMessageInfo_Message();
			message.UniMsgId = _ctx.StringValue("QueryMessageInfo.Message.UniMsgId");
			message.TopicFullName = _ctx.StringValue("QueryMessageInfo.Message.TopicFullName");
			message.MessageContent = _ctx.StringValue("QueryMessageInfo.Message.MessageContent");
			message.GenerateTime = _ctx.LongValue("QueryMessageInfo.Message.GenerateTime");

			List<QueryMessageInfoResponse.QueryMessageInfo_Message.QueryMessageInfo_UserProperty> message_userProperties = new List<QueryMessageInfoResponse.QueryMessageInfo_Message.QueryMessageInfo_UserProperty>();
			for (int i = 0; i < _ctx.Length("QueryMessageInfo.Message.UserProperties.Length"); i++) {
				QueryMessageInfoResponse.QueryMessageInfo_Message.QueryMessageInfo_UserProperty userProperty = new QueryMessageInfoResponse.QueryMessageInfo_Message.QueryMessageInfo_UserProperty();
				userProperty.Key = _ctx.StringValue("QueryMessageInfo.Message.UserProperties["+ i +"].Key");
				userProperty._Value = _ctx.StringValue("QueryMessageInfo.Message.UserProperties["+ i +"].Value");

				message_userProperties.Add(userProperty);
			}
			message.UserProperties = message_userProperties;
			queryMessageInfoResponse.Message = message;
        
			return queryMessageInfoResponse;
        }
    }
}
