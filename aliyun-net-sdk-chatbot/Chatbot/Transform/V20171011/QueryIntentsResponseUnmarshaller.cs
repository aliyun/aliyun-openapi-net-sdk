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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Chatbot.Model.V20171011;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Chatbot.Transform.V20171011
{
    public class QueryIntentsResponseUnmarshaller
    {
        public static QueryIntentsResponse Unmarshall(UnmarshallerContext context)
        {
            QueryIntentsResponse queryIntentsResponse = new QueryIntentsResponse
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("QueryIntents.RequestId"),
                PageNumber = context.IntegerValue("QueryIntents.PageNumber"),
                PageSize = context.IntegerValue("QueryIntents.PageSize"),
                TotalCount = context.IntegerValue("QueryIntents.TotalCount")
            };

            List<QueryIntentsResponse.QueryIntents_Intent> queryIntentsResponse_intents = new List<QueryIntentsResponse.QueryIntents_Intent>();
			for (int i = 0; i < context.Length("QueryIntents.Intents.Length"); i++) {
                QueryIntentsResponse.QueryIntents_Intent intent = new QueryIntentsResponse.QueryIntents_Intent
                {
                    IntentId = context.LongValue("QueryIntents.Intents[" + i + "].IntentId"),
                    Name = context.StringValue("QueryIntents.Intents[" + i + "].Name"),
                    CreateTime = context.StringValue("QueryIntents.Intents[" + i + "].CreateTime"),
                    ModifyTime = context.StringValue("QueryIntents.Intents[" + i + "].ModifyTime"),
                    CreateUserId = context.StringValue("QueryIntents.Intents[" + i + "].CreateUserId"),
                    CreateUserName = context.StringValue("QueryIntents.Intents[" + i + "].CreateUserName"),
                    ModifyUserId = context.StringValue("QueryIntents.Intents[" + i + "].ModifyUserId"),
                    ModifyUserName = context.StringValue("QueryIntents.Intents[" + i + "].ModifyUserName")
                };

                List<QueryIntentsResponse.QueryIntents_Intent.QueryIntents_UserSayItem> intent_userSay = new List<QueryIntentsResponse.QueryIntents_Intent.QueryIntents_UserSayItem>();
				for (int j = 0; j < context.Length("QueryIntents.Intents["+ i +"].UserSay.Length"); j++) {
                    QueryIntentsResponse.QueryIntents_Intent.QueryIntents_UserSayItem userSayItem = new QueryIntentsResponse.QueryIntents_Intent.QueryIntents_UserSayItem
                    {
                        Strict = context.BooleanValue("QueryIntents.Intents[" + i + "].UserSay[" + j + "].Strict")
                    };

                    List<QueryIntentsResponse.QueryIntents_Intent.QueryIntents_UserSayItem.QueryIntents_DataItem> userSayItem_data = new List<QueryIntentsResponse.QueryIntents_Intent.QueryIntents_UserSayItem.QueryIntents_DataItem>();
					for (int k = 0; k < context.Length("QueryIntents.Intents["+ i +"].UserSay["+ j +"].Data.Length"); k++) {
                        QueryIntentsResponse.QueryIntents_Intent.QueryIntents_UserSayItem.QueryIntents_DataItem dataItem = new QueryIntentsResponse.QueryIntents_Intent.QueryIntents_UserSayItem.QueryIntents_DataItem
                        {
                            Text = context.StringValue("QueryIntents.Intents[" + i + "].UserSay[" + j + "].Data[" + k + "].Text"),
                            SlotId = context.StringValue("QueryIntents.Intents[" + i + "].UserSay[" + j + "].Data[" + k + "].SlotId")
                        };

                        userSayItem_data.Add(dataItem);
					}
					userSayItem.Data = userSayItem_data;

					intent_userSay.Add(userSayItem);
				}
				intent.UserSay = intent_userSay;

				List<QueryIntentsResponse.QueryIntents_Intent.QueryIntents_RuleCheckItem> intent_ruleCheck = new List<QueryIntentsResponse.QueryIntents_Intent.QueryIntents_RuleCheckItem>();
				for (int j = 0; j < context.Length("QueryIntents.Intents["+ i +"].RuleCheck.Length"); j++) {
                    QueryIntentsResponse.QueryIntents_Intent.QueryIntents_RuleCheckItem ruleCheckItem = new QueryIntentsResponse.QueryIntents_Intent.QueryIntents_RuleCheckItem
                    {
                        Text = context.StringValue("QueryIntents.Intents[" + i + "].RuleCheck[" + j + "].Text"),
                        Strict = context.BooleanValue("QueryIntents.Intents[" + i + "].RuleCheck[" + j + "].Strict")
                    };

                    List<string> ruleCheckItem_warning = new List<string>();
					for (int k = 0; k < context.Length("QueryIntents.Intents["+ i +"].RuleCheck["+ j +"].Warning.Length"); k++) {
						ruleCheckItem_warning.Add(context.StringValue("QueryIntents.Intents["+ i +"].RuleCheck["+ j +"].Warning["+ k +"]"));
					}
					ruleCheckItem.Warning = ruleCheckItem_warning;

					List<string> ruleCheckItem_error = new List<string>();
					for (int k = 0; k < context.Length("QueryIntents.Intents["+ i +"].RuleCheck["+ j +"].Error.Length"); k++) {
						ruleCheckItem_error.Add(context.StringValue("QueryIntents.Intents["+ i +"].RuleCheck["+ j +"].Error["+ k +"]"));
					}
					ruleCheckItem.Error = ruleCheckItem_error;

					intent_ruleCheck.Add(ruleCheckItem);
				}
				intent.RuleCheck = intent_ruleCheck;

				List<QueryIntentsResponse.QueryIntents_Intent.QueryIntents_SlotItem> intent_slot = new List<QueryIntentsResponse.QueryIntents_Intent.QueryIntents_SlotItem>();
				for (int j = 0; j < context.Length("QueryIntents.Intents["+ i +"].Slot.Length"); j++) {
                    QueryIntentsResponse.QueryIntents_Intent.QueryIntents_SlotItem slotItem = new QueryIntentsResponse.QueryIntents_Intent.QueryIntents_SlotItem
                    {
                        Name = context.StringValue("QueryIntents.Intents[" + i + "].Slot[" + j + "].Name"),
                        _Value = context.StringValue("QueryIntents.Intents[" + i + "].Slot[" + j + "].Value"),
                        IsNecessary = context.BooleanValue("QueryIntents.Intents[" + i + "].Slot[" + j + "].IsNecessary"),
                        IsArray = context.BooleanValue("QueryIntents.Intents[" + i + "].Slot[" + j + "].IsArray"),
                        LifeSpan = context.IntegerValue("QueryIntents.Intents[" + i + "].Slot[" + j + "].LifeSpan")
                    };

                    List<string> slotItem_question = new List<string>();
					for (int k = 0; k < context.Length("QueryIntents.Intents["+ i +"].Slot["+ j +"].Question.Length"); k++) {
						slotItem_question.Add(context.StringValue("QueryIntents.Intents["+ i +"].Slot["+ j +"].Question["+ k +"]"));
					}
					slotItem.Question = slotItem_question;

					List<QueryIntentsResponse.QueryIntents_Intent.QueryIntents_SlotItem.QueryIntents_TagsItem> slotItem_tags = new List<QueryIntentsResponse.QueryIntents_Intent.QueryIntents_SlotItem.QueryIntents_TagsItem>();
					for (int k = 0; k < context.Length("QueryIntents.Intents["+ i +"].Slot["+ j +"].Tags.Length"); k++) {
                        QueryIntentsResponse.QueryIntents_Intent.QueryIntents_SlotItem.QueryIntents_TagsItem tagsItem = new QueryIntentsResponse.QueryIntents_Intent.QueryIntents_SlotItem.QueryIntents_TagsItem
                        {
                            _Value = context.StringValue("QueryIntents.Intents[" + i + "].Slot[" + j + "].Tags[" + k + "].Value"),
                            UserSayId = context.StringValue("QueryIntents.Intents[" + i + "].Slot[" + j + "].Tags[" + k + "].UserSayId")
                        };

                        slotItem_tags.Add(tagsItem);
					}
					slotItem.Tags = slotItem_tags;

					intent_slot.Add(slotItem);
				}
				intent.Slot = intent_slot;

				queryIntentsResponse_intents.Add(intent);
			}
			queryIntentsResponse.Intents = queryIntentsResponse_intents;
        
			return queryIntentsResponse;
        }
    }
}