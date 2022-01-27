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
        public static AddWebhookResponse Unmarshall(UnmarshallerContext _ctx)
        {
			AddWebhookResponse addWebhookResponse = new AddWebhookResponse();

			addWebhookResponse.HttpResponse = _ctx.HttpResponse;
			addWebhookResponse.RequestId = _ctx.StringValue("AddWebhook.RequestId");
			addWebhookResponse.ErrorCode = _ctx.StringValue("AddWebhook.ErrorCode");
			addWebhookResponse.Success = _ctx.BooleanValue("AddWebhook.Success");
			addWebhookResponse.ErrorMessage = _ctx.StringValue("AddWebhook.ErrorMessage");

			AddWebhookResponse.AddWebhook_Result result = new AddWebhookResponse.AddWebhook_Result();
			result.Id = _ctx.LongValue("AddWebhook.Result.Id");
			result.Url = _ctx.StringValue("AddWebhook.Result.Url");
			result.CreatedAt = _ctx.StringValue("AddWebhook.Result.CreatedAt");
			result.ProjectId = _ctx.LongValue("AddWebhook.Result.ProjectId");
			result.PushEvents = _ctx.BooleanValue("AddWebhook.Result.PushEvents");
			result.IssuesEvents = _ctx.BooleanValue("AddWebhook.Result.IssuesEvents");
			result.MergeRequestsEvents = _ctx.BooleanValue("AddWebhook.Result.MergeRequestsEvents");
			result.TagPushEvents = _ctx.BooleanValue("AddWebhook.Result.TagPushEvents");
			result.BuildEvents = _ctx.BooleanValue("AddWebhook.Result.BuildEvents");
			result.NoteEvents = _ctx.BooleanValue("AddWebhook.Result.NoteEvents");
			result.EnableSslVerification = _ctx.BooleanValue("AddWebhook.Result.EnableSslVerification");
			result.LastTestResult = _ctx.StringValue("AddWebhook.Result.LastTestResult");
			result.Description = _ctx.StringValue("AddWebhook.Result.Description");
			result.SecretToken = _ctx.StringValue("AddWebhook.Result.SecretToken");
			addWebhookResponse.Result = result;
        
			return addWebhookResponse;
        }
    }
}
