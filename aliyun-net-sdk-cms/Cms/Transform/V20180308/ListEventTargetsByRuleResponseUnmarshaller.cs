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
using Aliyun.Acs.Cms.Model.V20180308;

namespace Aliyun.Acs.Cms.Transform.V20180308
{
    public class ListEventTargetsByRuleResponseUnmarshaller
    {
        public static ListEventTargetsByRuleResponse Unmarshall(UnmarshallerContext context)
        {
			ListEventTargetsByRuleResponse listEventTargetsByRuleResponse = new ListEventTargetsByRuleResponse();

			listEventTargetsByRuleResponse.HttpResponse = context.HttpResponse;
			listEventTargetsByRuleResponse.Code = context.StringValue("ListEventTargetsByRule.Code");
			listEventTargetsByRuleResponse.Message = context.StringValue("ListEventTargetsByRule.Message");
			listEventTargetsByRuleResponse.RequestId = context.StringValue("ListEventTargetsByRule.RequestId");
			listEventTargetsByRuleResponse.ParameterCount = context.IntegerValue("ListEventTargetsByRule.ParameterCount");

			List<ListEventTargetsByRuleResponse.ListEventTargetsByRule_ContactParameter> listEventTargetsByRuleResponse_contactParameters = new List<ListEventTargetsByRuleResponse.ListEventTargetsByRule_ContactParameter>();
			for (int i = 0; i < context.Length("ListEventTargetsByRule.ContactParameters.Length"); i++) {
				ListEventTargetsByRuleResponse.ListEventTargetsByRule_ContactParameter contactParameter = new ListEventTargetsByRuleResponse.ListEventTargetsByRule_ContactParameter();
				contactParameter.ContactGroupName = context.StringValue("ListEventTargetsByRule.ContactParameters["+ i +"].ContactGroupName");
				contactParameter.Level = context.StringValue("ListEventTargetsByRule.ContactParameters["+ i +"].Level");
				contactParameter.Id = context.StringValue("ListEventTargetsByRule.ContactParameters["+ i +"].Id");

				listEventTargetsByRuleResponse_contactParameters.Add(contactParameter);
			}
			listEventTargetsByRuleResponse.ContactParameters = listEventTargetsByRuleResponse_contactParameters;

			List<ListEventTargetsByRuleResponse.ListEventTargetsByRule_FCParameter> listEventTargetsByRuleResponse_fcParameters = new List<ListEventTargetsByRuleResponse.ListEventTargetsByRule_FCParameter>();
			for (int i = 0; i < context.Length("ListEventTargetsByRule.FcParameters.Length"); i++) {
				ListEventTargetsByRuleResponse.ListEventTargetsByRule_FCParameter fCParameter = new ListEventTargetsByRuleResponse.ListEventTargetsByRule_FCParameter();
				fCParameter.Region = context.StringValue("ListEventTargetsByRule.FcParameters["+ i +"].Region");
				fCParameter.ServiceName = context.StringValue("ListEventTargetsByRule.FcParameters["+ i +"].ServiceName");
				fCParameter.FunctionName = context.StringValue("ListEventTargetsByRule.FcParameters["+ i +"].FunctionName");
				fCParameter.Id = context.StringValue("ListEventTargetsByRule.FcParameters["+ i +"].Id");

				listEventTargetsByRuleResponse_fcParameters.Add(fCParameter);
			}
			listEventTargetsByRuleResponse.FcParameters = listEventTargetsByRuleResponse_fcParameters;

			List<ListEventTargetsByRuleResponse.ListEventTargetsByRule_MnsParameter> listEventTargetsByRuleResponse_mnsParameters = new List<ListEventTargetsByRuleResponse.ListEventTargetsByRule_MnsParameter>();
			for (int i = 0; i < context.Length("ListEventTargetsByRule.MnsParameters.Length"); i++) {
				ListEventTargetsByRuleResponse.ListEventTargetsByRule_MnsParameter mnsParameter = new ListEventTargetsByRuleResponse.ListEventTargetsByRule_MnsParameter();
				mnsParameter.Region = context.StringValue("ListEventTargetsByRule.MnsParameters["+ i +"].Region");
				mnsParameter.Queue = context.StringValue("ListEventTargetsByRule.MnsParameters["+ i +"].Queue");
				mnsParameter.Id = context.StringValue("ListEventTargetsByRule.MnsParameters["+ i +"].Id");

				listEventTargetsByRuleResponse_mnsParameters.Add(mnsParameter);
			}
			listEventTargetsByRuleResponse.MnsParameters = listEventTargetsByRuleResponse_mnsParameters;

			List<ListEventTargetsByRuleResponse.ListEventTargetsByRule_WebhookParameter> listEventTargetsByRuleResponse_webhookParameters = new List<ListEventTargetsByRuleResponse.ListEventTargetsByRule_WebhookParameter>();
			for (int i = 0; i < context.Length("ListEventTargetsByRule.WebhookParameters.Length"); i++) {
				ListEventTargetsByRuleResponse.ListEventTargetsByRule_WebhookParameter webhookParameter = new ListEventTargetsByRuleResponse.ListEventTargetsByRule_WebhookParameter();
				webhookParameter.Id = context.StringValue("ListEventTargetsByRule.WebhookParameters["+ i +"].Id");
				webhookParameter.Protocol = context.StringValue("ListEventTargetsByRule.WebhookParameters["+ i +"].Protocol");
				webhookParameter.Method = context.StringValue("ListEventTargetsByRule.WebhookParameters["+ i +"].Method");
				webhookParameter.Url = context.StringValue("ListEventTargetsByRule.WebhookParameters["+ i +"].Url");

				listEventTargetsByRuleResponse_webhookParameters.Add(webhookParameter);
			}
			listEventTargetsByRuleResponse.WebhookParameters = listEventTargetsByRuleResponse_webhookParameters;

			List<ListEventTargetsByRuleResponse.ListEventTargetsByRule_SlsParameter> listEventTargetsByRuleResponse_slsParameters = new List<ListEventTargetsByRuleResponse.ListEventTargetsByRule_SlsParameter>();
			for (int i = 0; i < context.Length("ListEventTargetsByRule.SlsParameters.Length"); i++) {
				ListEventTargetsByRuleResponse.ListEventTargetsByRule_SlsParameter slsParameter = new ListEventTargetsByRuleResponse.ListEventTargetsByRule_SlsParameter();
				slsParameter.Id = context.StringValue("ListEventTargetsByRule.SlsParameters["+ i +"].Id");
				slsParameter.Region = context.StringValue("ListEventTargetsByRule.SlsParameters["+ i +"].Region");
				slsParameter.Project = context.StringValue("ListEventTargetsByRule.SlsParameters["+ i +"].Project");
				slsParameter.LogStore = context.StringValue("ListEventTargetsByRule.SlsParameters["+ i +"].LogStore");

				listEventTargetsByRuleResponse_slsParameters.Add(slsParameter);
			}
			listEventTargetsByRuleResponse.SlsParameters = listEventTargetsByRuleResponse_slsParameters;
        
			return listEventTargetsByRuleResponse;
        }
    }
}
