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
    public class ListIntentsResponseUnmarshaller
    {
        public static ListIntentsResponse Unmarshall(UnmarshallerContext context)
        {
			ListIntentsResponse listIntentsResponse = new ListIntentsResponse();

			listIntentsResponse.HttpResponse = context.HttpResponse;
			listIntentsResponse.RequestId = context.StringValue("ListIntents.RequestId");
			listIntentsResponse.Success = context.BooleanValue("ListIntents.Success");
			listIntentsResponse.Code = context.StringValue("ListIntents.Code");
			listIntentsResponse.Message = context.StringValue("ListIntents.Message");
			listIntentsResponse.HttpStatusCode = context.IntegerValue("ListIntents.HttpStatusCode");

			ListIntentsResponse.ListIntents_Intents intents = new ListIntentsResponse.ListIntents_Intents();
			intents.TotalCount = context.IntegerValue("ListIntents.Intents.TotalCount");
			intents.PageNumber = context.IntegerValue("ListIntents.Intents.PageNumber");
			intents.PageSize = context.IntegerValue("ListIntents.Intents.PageSize");

			List<ListIntentsResponse.ListIntents_Intents.ListIntents_Intent> intents_list = new List<ListIntentsResponse.ListIntents_Intents.ListIntents_Intent>();
			for (int i = 0; i < context.Length("ListIntents.Intents.List.Length"); i++) {
				ListIntentsResponse.ListIntents_Intents.ListIntents_Intent intent = new ListIntentsResponse.ListIntents_Intents.ListIntents_Intent();
				intent.IntentId = context.StringValue("ListIntents.Intents.List["+ i +"].IntentId");
				intent.ScriptId = context.StringValue("ListIntents.Intents.List["+ i +"].ScriptId");
				intent.IntentName = context.StringValue("ListIntents.Intents.List["+ i +"].IntentName");
				intent.IntentDescription = context.StringValue("ListIntents.Intents.List["+ i +"].IntentDescription");
				intent.Utterances = context.StringValue("ListIntents.Intents.List["+ i +"].Utterances");
				intent.Keywords = context.StringValue("ListIntents.Intents.List["+ i +"].Keywords");
				intent.CreateTime = context.LongValue("ListIntents.Intents.List["+ i +"].CreateTime");
				intent.UpdateTime = context.LongValue("ListIntents.Intents.List["+ i +"].UpdateTime");

				intents_list.Add(intent);
			}
			intents.List = intents_list;
			listIntentsResponse.Intents = intents;
        
			return listIntentsResponse;
        }
    }
}
