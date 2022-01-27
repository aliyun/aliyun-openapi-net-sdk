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
    public class DeleteRepositoryWebhookResponseUnmarshaller
    {
        public static DeleteRepositoryWebhookResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DeleteRepositoryWebhookResponse deleteRepositoryWebhookResponse = new DeleteRepositoryWebhookResponse();

			deleteRepositoryWebhookResponse.HttpResponse = _ctx.HttpResponse;
			deleteRepositoryWebhookResponse.RequestId = _ctx.StringValue("DeleteRepositoryWebhook.RequestId");
			deleteRepositoryWebhookResponse.ErrorCode = _ctx.StringValue("DeleteRepositoryWebhook.ErrorCode");
			deleteRepositoryWebhookResponse.Success = _ctx.BooleanValue("DeleteRepositoryWebhook.Success");
			deleteRepositoryWebhookResponse.ErrorMessage = _ctx.StringValue("DeleteRepositoryWebhook.ErrorMessage");

			DeleteRepositoryWebhookResponse.DeleteRepositoryWebhook_Result result = new DeleteRepositoryWebhookResponse.DeleteRepositoryWebhook_Result();
			result.Id = _ctx.LongValue("DeleteRepositoryWebhook.Result.Id");
			result.Url = _ctx.StringValue("DeleteRepositoryWebhook.Result.Url");
			result.CreatedAt = _ctx.StringValue("DeleteRepositoryWebhook.Result.CreatedAt");
			result.ProjectId = _ctx.LongValue("DeleteRepositoryWebhook.Result.ProjectId");
			result.PushEvents = _ctx.BooleanValue("DeleteRepositoryWebhook.Result.PushEvents");
			result.MergeRequestsEvents = _ctx.BooleanValue("DeleteRepositoryWebhook.Result.MergeRequestsEvents");
			result.TagPushEvents = _ctx.BooleanValue("DeleteRepositoryWebhook.Result.TagPushEvents");
			result.NoteEvents = _ctx.BooleanValue("DeleteRepositoryWebhook.Result.NoteEvents");
			result.EnableSslVerification = _ctx.BooleanValue("DeleteRepositoryWebhook.Result.EnableSslVerification");
			result.LastTestResult = _ctx.StringValue("DeleteRepositoryWebhook.Result.LastTestResult");
			result.Description = _ctx.StringValue("DeleteRepositoryWebhook.Result.Description");
			result.SecretToken = _ctx.StringValue("DeleteRepositoryWebhook.Result.SecretToken");
			deleteRepositoryWebhookResponse.Result = result;
        
			return deleteRepositoryWebhookResponse;
        }
    }
}
