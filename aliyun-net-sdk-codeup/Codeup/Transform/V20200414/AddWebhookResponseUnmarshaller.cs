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
using Aliyun.Acs.codeup.Model.V20200414;

namespace Aliyun.Acs.codeup.Transform.V20200414
{
    public class AddWebhookResponseUnmarshaller
    {
        public static AddWebhookResponse Unmarshall(UnmarshallerContext context)
        {
			AddWebhookResponse addWebhookResponse = new AddWebhookResponse();

			addWebhookResponse.HttpResponse = context.HttpResponse;
			addWebhookResponse.RequestId = context.StringValue("AddWebhook.RequestId");
			addWebhookResponse.ErrorCode = context.StringValue("AddWebhook.ErrorCode");
			addWebhookResponse.Success = context.BooleanValue("AddWebhook.Success");
			addWebhookResponse.ErrorMessage = context.StringValue("AddWebhook.ErrorMessage");

			AddWebhookResponse.AddWebhook_Result result = new AddWebhookResponse.AddWebhook_Result();
			result.Id = context.LongValue("AddWebhook.Result.Id");
			result.Url = context.StringValue("AddWebhook.Result.Url");
			result.CreatedAt = context.StringValue("AddWebhook.Result.CreatedAt");
			result.ProjectId = context.LongValue("AddWebhook.Result.ProjectId");
			result.PushEvents = context.BooleanValue("AddWebhook.Result.PushEvents");
			result.IssuesEvents = context.BooleanValue("AddWebhook.Result.IssuesEvents");
			result.MergeRequestsEvents = context.BooleanValue("AddWebhook.Result.MergeRequestsEvents");
			result.TagPushEvents = context.BooleanValue("AddWebhook.Result.TagPushEvents");
			result.BuildEvents = context.BooleanValue("AddWebhook.Result.BuildEvents");
			result.NoteEvents = context.BooleanValue("AddWebhook.Result.NoteEvents");
			result.EnableSslVerification = context.BooleanValue("AddWebhook.Result.EnableSslVerification");
			result.LastTestResult = context.StringValue("AddWebhook.Result.LastTestResult");
			result.Description = context.StringValue("AddWebhook.Result.Description");
			addWebhookResponse.Result = result;
        
			return addWebhookResponse;
        }
    }
}
