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
using Aliyun.Acs.CCC.Model.V20170705;

namespace Aliyun.Acs.CCC.Transform.V20170705
{
    public class GetConversationListResponseUnmarshaller
    {
        public static GetConversationListResponse Unmarshall(UnmarshallerContext context)
        {
			GetConversationListResponse getConversationListResponse = new GetConversationListResponse();

			getConversationListResponse.HttpResponse = context.HttpResponse;
			getConversationListResponse.RequestId = context.StringValue("GetConversationList.RequestId");
			getConversationListResponse.Success = context.BooleanValue("GetConversationList.Success");
			getConversationListResponse.Code = context.StringValue("GetConversationList.Code");
			getConversationListResponse.Message = context.StringValue("GetConversationList.Message");
			getConversationListResponse.HttpStatusCode = context.IntegerValue("GetConversationList.HttpStatusCode");

			List<GetConversationListResponse.GetConversationList_ConversationDetail> getConversationListResponse_conversations = new List<GetConversationListResponse.GetConversationList_ConversationDetail>();
			for (int i = 0; i < context.Length("GetConversationList.Conversations.Length"); i++) {
				GetConversationListResponse.GetConversationList_ConversationDetail conversationDetail = new GetConversationListResponse.GetConversationList_ConversationDetail();
				conversationDetail.Timestamp = context.LongValue("GetConversationList.Conversations["+ i +"].Timestamp");
				conversationDetail.Speaker = context.StringValue("GetConversationList.Conversations["+ i +"].Speaker");
				conversationDetail.Script = context.StringValue("GetConversationList.Conversations["+ i +"].Script");

				List<GetConversationListResponse.GetConversationList_ConversationDetail.GetConversationList_SummaryItem> conversationDetail_summary = new List<GetConversationListResponse.GetConversationList_ConversationDetail.GetConversationList_SummaryItem>();
				for (int j = 0; j < context.Length("GetConversationList.Conversations["+ i +"].Summary.Length"); j++) {
					GetConversationListResponse.GetConversationList_ConversationDetail.GetConversationList_SummaryItem summaryItem = new GetConversationListResponse.GetConversationList_ConversationDetail.GetConversationList_SummaryItem();
					summaryItem.Category = context.StringValue("GetConversationList.Conversations["+ i +"].Summary["+ j +"].Category");
					summaryItem.SummaryName = context.StringValue("GetConversationList.Conversations["+ i +"].Summary["+ j +"].SummaryName");
					summaryItem.Content = context.StringValue("GetConversationList.Conversations["+ i +"].Summary["+ j +"].Content");

					conversationDetail_summary.Add(summaryItem);
				}
				conversationDetail.Summary = conversationDetail_summary;

				getConversationListResponse_conversations.Add(conversationDetail);
			}
			getConversationListResponse.Conversations = getConversationListResponse_conversations;
        
			return getConversationListResponse;
        }
    }
}
