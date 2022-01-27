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
    public class ListConversationDetailsResponseUnmarshaller
    {
        public static ListConversationDetailsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListConversationDetailsResponse listConversationDetailsResponse = new ListConversationDetailsResponse();

			listConversationDetailsResponse.HttpResponse = _ctx.HttpResponse;
			listConversationDetailsResponse.RequestId = _ctx.StringValue("ListConversationDetails.RequestId");

			List<ListConversationDetailsResponse.ListConversationDetails_ConversationDetail> listConversationDetailsResponse_conversationDetails = new List<ListConversationDetailsResponse.ListConversationDetails_ConversationDetail>();
			for (int i = 0; i < _ctx.Length("ListConversationDetails.ConversationDetails.Length"); i++) {
				ListConversationDetailsResponse.ListConversationDetails_ConversationDetail conversationDetail = new ListConversationDetailsResponse.ListConversationDetails_ConversationDetail();
				conversationDetail.ConversationId = _ctx.StringValue("ListConversationDetails.ConversationDetails["+ i +"].ConversationId");
				conversationDetail.Speaker = _ctx.StringValue("ListConversationDetails.ConversationDetails["+ i +"].Speaker");
				conversationDetail.Utterance = _ctx.StringValue("ListConversationDetails.ConversationDetails["+ i +"].Utterance");
				conversationDetail.Action = _ctx.StringValue("ListConversationDetails.ConversationDetails["+ i +"].Action");
				conversationDetail.ActionParams = _ctx.StringValue("ListConversationDetails.ConversationDetails["+ i +"].ActionParams");
				conversationDetail.CreateTime = _ctx.LongValue("ListConversationDetails.ConversationDetails["+ i +"].CreateTime");
				conversationDetail.SequenceId = _ctx.StringValue("ListConversationDetails.ConversationDetails["+ i +"].SequenceId");

				listConversationDetailsResponse_conversationDetails.Add(conversationDetail);
			}
			listConversationDetailsResponse.ConversationDetails = listConversationDetailsResponse_conversationDetails;
        
			return listConversationDetailsResponse;
        }
    }
}
