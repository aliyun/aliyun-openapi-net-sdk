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
			QueryIntentsResponse queryIntentsResponse = new QueryIntentsResponse();

			queryIntentsResponse.HttpResponse = context.HttpResponse;
			queryIntentsResponse.RequestId = context.StringValue("QueryIntents.RequestId");
			queryIntentsResponse.PageNumber = context.IntegerValue("QueryIntents.PageNumber");
			queryIntentsResponse.PageSize = context.IntegerValue("QueryIntents.PageSize");
			queryIntentsResponse.TotalCount = context.IntegerValue("QueryIntents.TotalCount");

			List<QueryIntentsResponse.QueryIntents_Intent> queryIntentsResponse_intents = new List<QueryIntentsResponse.QueryIntents_Intent>();
			for (int i = 0; i < context.Length("QueryIntents.Intents.Length"); i++) {
				QueryIntentsResponse.QueryIntents_Intent intent = new QueryIntentsResponse.QueryIntents_Intent();
				intent.IntentId = context.LongValue("QueryIntents.Intents["+ i +"].IntentId");
				intent.Name = context.StringValue("QueryIntents.Intents["+ i +"].Name");
				intent.CreateTime = context.StringValue("QueryIntents.Intents["+ i +"].CreateTime");
				intent.ModifyTime = context.StringValue("QueryIntents.Intents["+ i +"].ModifyTime");
				intent.CreateUserId = context.StringValue("QueryIntents.Intents["+ i +"].CreateUserId");
				intent.CreateUserName = context.StringValue("QueryIntents.Intents["+ i +"].CreateUserName");
				intent.ModifyUserId = context.StringValue("QueryIntents.Intents["+ i +"].ModifyUserId");
				intent.ModifyUserName = context.StringValue("QueryIntents.Intents["+ i +"].ModifyUserName");

				List<QueryIntentsResponse.QueryIntents_Intent.QueryIntents_UserSayItem> intent_userSay = new List<QueryIntentsResponse.QueryIntents_Intent.QueryIntents_UserSayItem>();
				for (int j = 0; j < context.Length("QueryIntents.Intents["+ i +"].UserSay.Length"); j++) {
					QueryIntentsResponse.QueryIntents_Intent.QueryIntents_UserSayItem userSayItem = new QueryIntentsResponse.QueryIntents_Intent.QueryIntents_UserSayItem();
					userSayItem.Strict = context.BooleanValue("QueryIntents.Intents["+ i +"].UserSay["+ j +"].Strict");

					List<QueryIntentsResponse.QueryIntents_Intent.QueryIntents_UserSayItem.QueryIntents_DataItem> userSayItem_data = new List<QueryIntentsResponse.QueryIntents_Intent.QueryIntents_UserSayItem.QueryIntents_DataItem>();
					for (int k = 0; k < context.Length("QueryIntents.Intents["+ i +"].UserSay["+ j +"].Data.Length"); k++) {
						QueryIntentsResponse.QueryIntents_Intent.QueryIntents_UserSayItem.QueryIntents_DataItem dataItem = new QueryIntentsResponse.QueryIntents_Intent.QueryIntents_UserSayItem.QueryIntents_DataItem();
						dataItem.Text = context.StringValue("QueryIntents.Intents["+ i +"].UserSay["+ j +"].Data["+ k +"].Text");
						dataItem.SlotId = context.StringValue("QueryIntents.Intents["+ i +"].UserSay["+ j +"].Data["+ k +"].SlotId");

						userSayItem_data.Add(dataItem);
					}
					userSayItem.Data = userSayItem_data;

					intent_userSay.Add(userSayItem);
				}
				intent.UserSay = intent_userSay;

				List<QueryIntentsResponse.QueryIntents_Intent.QueryIntents_RuleCheckItem> intent_ruleCheck = new List<QueryIntentsResponse.QueryIntents_Intent.QueryIntents_RuleCheckItem>();
				for (int j = 0; j < context.Length("QueryIntents.Intents["+ i +"].RuleCheck.Length"); j++) {
					QueryIntentsResponse.QueryIntents_Intent.QueryIntents_RuleCheckItem ruleCheckItem = new QueryIntentsResponse.QueryIntents_Intent.QueryIntents_RuleCheckItem();
					ruleCheckItem.Text = context.StringValue("QueryIntents.Intents["+ i +"].RuleCheck["+ j +"].Text");
					ruleCheckItem.Strict = context.BooleanValue("QueryIntents.Intents["+ i +"].RuleCheck["+ j +"].Strict");

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
					QueryIntentsResponse.QueryIntents_Intent.QueryIntents_SlotItem slotItem = new QueryIntentsResponse.QueryIntents_Intent.QueryIntents_SlotItem();
					slotItem.Name = context.StringValue("QueryIntents.Intents["+ i +"].Slot["+ j +"].Name");
					slotItem._Value = context.StringValue("QueryIntents.Intents["+ i +"].Slot["+ j +"].Value");
					slotItem.IsNecessary = context.BooleanValue("QueryIntents.Intents["+ i +"].Slot["+ j +"].IsNecessary");
					slotItem.IsArray = context.BooleanValue("QueryIntents.Intents["+ i +"].Slot["+ j +"].IsArray");
					slotItem.LifeSpan = context.IntegerValue("QueryIntents.Intents["+ i +"].Slot["+ j +"].LifeSpan");

					List<string> slotItem_question = new List<string>();
					for (int k = 0; k < context.Length("QueryIntents.Intents["+ i +"].Slot["+ j +"].Question.Length"); k++) {
						slotItem_question.Add(context.StringValue("QueryIntents.Intents["+ i +"].Slot["+ j +"].Question["+ k +"]"));
					}
					slotItem.Question = slotItem_question;

					List<QueryIntentsResponse.QueryIntents_Intent.QueryIntents_SlotItem.QueryIntents_TagsItem> slotItem_tags = new List<QueryIntentsResponse.QueryIntents_Intent.QueryIntents_SlotItem.QueryIntents_TagsItem>();
					for (int k = 0; k < context.Length("QueryIntents.Intents["+ i +"].Slot["+ j +"].Tags.Length"); k++) {
						QueryIntentsResponse.QueryIntents_Intent.QueryIntents_SlotItem.QueryIntents_TagsItem tagsItem = new QueryIntentsResponse.QueryIntents_Intent.QueryIntents_SlotItem.QueryIntents_TagsItem();
						tagsItem._Value = context.StringValue("QueryIntents.Intents["+ i +"].Slot["+ j +"].Tags["+ k +"].Value");
						tagsItem.UserSayId = context.StringValue("QueryIntents.Intents["+ i +"].Slot["+ j +"].Tags["+ k +"].UserSayId");

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