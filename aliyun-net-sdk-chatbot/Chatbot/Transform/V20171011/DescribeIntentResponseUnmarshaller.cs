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
    public class DescribeIntentResponseUnmarshaller
    {
        public static DescribeIntentResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeIntentResponse describeIntentResponse = new DescribeIntentResponse();

			describeIntentResponse.HttpResponse = context.HttpResponse;
			describeIntentResponse.RequestId = context.StringValue("DescribeIntent.RequestId");
			describeIntentResponse.IntentId = context.LongValue("DescribeIntent.IntentId");
			describeIntentResponse.Name = context.StringValue("DescribeIntent.Name");
			describeIntentResponse.Type = context.StringValue("DescribeIntent.Type");
			describeIntentResponse.DialogId = context.LongValue("DescribeIntent.DialogId");
			describeIntentResponse.CreateTime = context.StringValue("DescribeIntent.CreateTime");
			describeIntentResponse.ModifyTime = context.StringValue("DescribeIntent.ModifyTime");
			describeIntentResponse.CreateUserId = context.StringValue("DescribeIntent.CreateUserId");
			describeIntentResponse.CreateUserName = context.StringValue("DescribeIntent.CreateUserName");
			describeIntentResponse.ModifyUserId = context.StringValue("DescribeIntent.ModifyUserId");
			describeIntentResponse.ModifyUserName = context.StringValue("DescribeIntent.ModifyUserName");

			List<DescribeIntentResponse.DescribeIntent_RuleCheckItem> describeIntentResponse_ruleCheck = new List<DescribeIntentResponse.DescribeIntent_RuleCheckItem>();
			for (int i = 0; i < context.Length("DescribeIntent.RuleCheck.Length"); i++) {
				DescribeIntentResponse.DescribeIntent_RuleCheckItem ruleCheckItem = new DescribeIntentResponse.DescribeIntent_RuleCheckItem();
				ruleCheckItem.Text = context.StringValue("DescribeIntent.RuleCheck["+ i +"].Text");
				ruleCheckItem.Strict = context.BooleanValue("DescribeIntent.RuleCheck["+ i +"].Strict");

				List<string> ruleCheckItem_warning = new List<string>();
				for (int j = 0; j < context.Length("DescribeIntent.RuleCheck["+ i +"].Warning.Length"); j++) {
					ruleCheckItem_warning.Add(context.StringValue("DescribeIntent.RuleCheck["+ i +"].Warning["+ j +"]"));
				}
				ruleCheckItem.Warning = ruleCheckItem_warning;

				List<string> ruleCheckItem_error = new List<string>();
				for (int j = 0; j < context.Length("DescribeIntent.RuleCheck["+ i +"].Error.Length"); j++) {
					ruleCheckItem_error.Add(context.StringValue("DescribeIntent.RuleCheck["+ i +"].Error["+ j +"]"));
				}
				ruleCheckItem.Error = ruleCheckItem_error;

				describeIntentResponse_ruleCheck.Add(ruleCheckItem);
			}
			describeIntentResponse.RuleCheck = describeIntentResponse_ruleCheck;

			List<DescribeIntentResponse.DescribeIntent_SlotItem> describeIntentResponse_slot = new List<DescribeIntentResponse.DescribeIntent_SlotItem>();
			for (int i = 0; i < context.Length("DescribeIntent.Slot.Length"); i++) {
				DescribeIntentResponse.DescribeIntent_SlotItem slotItem = new DescribeIntentResponse.DescribeIntent_SlotItem();
				slotItem.Name = context.StringValue("DescribeIntent.Slot["+ i +"].Name");
				slotItem._Value = context.StringValue("DescribeIntent.Slot["+ i +"].Value");
				slotItem.IsNecessary = context.BooleanValue("DescribeIntent.Slot["+ i +"].IsNecessary");
				slotItem.IsArray = context.BooleanValue("DescribeIntent.Slot["+ i +"].IsArray");
				slotItem.LifeSpan = context.IntegerValue("DescribeIntent.Slot["+ i +"].LifeSpan");

				List<string> slotItem_question = new List<string>();
				for (int j = 0; j < context.Length("DescribeIntent.Slot["+ i +"].Question.Length"); j++) {
					slotItem_question.Add(context.StringValue("DescribeIntent.Slot["+ i +"].Question["+ j +"]"));
				}
				slotItem.Question = slotItem_question;

				List<DescribeIntentResponse.DescribeIntent_SlotItem.DescribeIntent_TagsItem> slotItem_tags = new List<DescribeIntentResponse.DescribeIntent_SlotItem.DescribeIntent_TagsItem>();
				for (int j = 0; j < context.Length("DescribeIntent.Slot["+ i +"].Tags.Length"); j++) {
					DescribeIntentResponse.DescribeIntent_SlotItem.DescribeIntent_TagsItem tagsItem = new DescribeIntentResponse.DescribeIntent_SlotItem.DescribeIntent_TagsItem();
					tagsItem._Value = context.StringValue("DescribeIntent.Slot["+ i +"].Tags["+ j +"].Value");
					tagsItem.UserSayId = context.StringValue("DescribeIntent.Slot["+ i +"].Tags["+ j +"].UserSayId");

					slotItem_tags.Add(tagsItem);
				}
				slotItem.Tags = slotItem_tags;

				describeIntentResponse_slot.Add(slotItem);
			}
			describeIntentResponse.Slot = describeIntentResponse_slot;

			List<DescribeIntentResponse.DescribeIntent_UserSayItem> describeIntentResponse_userSay = new List<DescribeIntentResponse.DescribeIntent_UserSayItem>();
			for (int i = 0; i < context.Length("DescribeIntent.UserSay.Length"); i++) {
				DescribeIntentResponse.DescribeIntent_UserSayItem userSayItem = new DescribeIntentResponse.DescribeIntent_UserSayItem();
				userSayItem.Strict = context.BooleanValue("DescribeIntent.UserSay["+ i +"].Strict");

				List<DescribeIntentResponse.DescribeIntent_UserSayItem.DescribeIntent_DataItem> userSayItem_data = new List<DescribeIntentResponse.DescribeIntent_UserSayItem.DescribeIntent_DataItem>();
				for (int j = 0; j < context.Length("DescribeIntent.UserSay["+ i +"].Data.Length"); j++) {
					DescribeIntentResponse.DescribeIntent_UserSayItem.DescribeIntent_DataItem dataItem = new DescribeIntentResponse.DescribeIntent_UserSayItem.DescribeIntent_DataItem();
					dataItem.Text = context.StringValue("DescribeIntent.UserSay["+ i +"].Data["+ j +"].Text");
					dataItem.SlotId = context.StringValue("DescribeIntent.UserSay["+ i +"].Data["+ j +"].SlotId");

					userSayItem_data.Add(dataItem);
				}
				userSayItem.Data = userSayItem_data;

				describeIntentResponse_userSay.Add(userSayItem);
			}
			describeIntentResponse.UserSay = describeIntentResponse_userSay;
        
			return describeIntentResponse;
        }
    }
}