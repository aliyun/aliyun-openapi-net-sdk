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
        public static ListIntentsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListIntentsResponse listIntentsResponse = new ListIntentsResponse();

			listIntentsResponse.HttpResponse = _ctx.HttpResponse;
			listIntentsResponse.Code = _ctx.StringValue("ListIntents.Code");
			listIntentsResponse.HttpStatusCode = _ctx.IntegerValue("ListIntents.HttpStatusCode");
			listIntentsResponse.Message = _ctx.StringValue("ListIntents.Message");
			listIntentsResponse.RequestId = _ctx.StringValue("ListIntents.RequestId");
			listIntentsResponse.Success = _ctx.BooleanValue("ListIntents.Success");

			ListIntentsResponse.ListIntents_Intents intents = new ListIntentsResponse.ListIntents_Intents();
			intents.PageNumber = _ctx.IntegerValue("ListIntents.Intents.PageNumber");
			intents.PageSize = _ctx.IntegerValue("ListIntents.Intents.PageSize");
			intents.TotalCount = _ctx.IntegerValue("ListIntents.Intents.TotalCount");

			List<ListIntentsResponse.ListIntents_Intents.ListIntents_Intent> intents_list = new List<ListIntentsResponse.ListIntents_Intents.ListIntents_Intent>();
			for (int i = 0; i < _ctx.Length("ListIntents.Intents.List.Length"); i++) {
				ListIntentsResponse.ListIntents_Intents.ListIntents_Intent intent = new ListIntentsResponse.ListIntents_Intents.ListIntents_Intent();
				intent.CreateTime = _ctx.LongValue("ListIntents.Intents.List["+ i +"].CreateTime");
				intent.IntentDescription = _ctx.StringValue("ListIntents.Intents.List["+ i +"].IntentDescription");
				intent.IntentId = _ctx.StringValue("ListIntents.Intents.List["+ i +"].IntentId");
				intent.IntentName = _ctx.StringValue("ListIntents.Intents.List["+ i +"].IntentName");
				intent.Keywords = _ctx.StringValue("ListIntents.Intents.List["+ i +"].Keywords");
				intent.ScriptId = _ctx.StringValue("ListIntents.Intents.List["+ i +"].ScriptId");
				intent.UpdateTime = _ctx.LongValue("ListIntents.Intents.List["+ i +"].UpdateTime");
				intent.Utterances = _ctx.StringValue("ListIntents.Intents.List["+ i +"].Utterances");

				intents_list.Add(intent);
			}
			intents.List = intents_list;
			listIntentsResponse.Intents = intents;
        
			return listIntentsResponse;
        }
    }
}
