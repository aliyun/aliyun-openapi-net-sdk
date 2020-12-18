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
    public class ListRepositoryWebhookResponseUnmarshaller
    {
        public static ListRepositoryWebhookResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListRepositoryWebhookResponse listRepositoryWebhookResponse = new ListRepositoryWebhookResponse();

			listRepositoryWebhookResponse.HttpResponse = _ctx.HttpResponse;
			listRepositoryWebhookResponse.RequestId = _ctx.StringValue("ListRepositoryWebhook.RequestId");
			listRepositoryWebhookResponse.ErrorCode = _ctx.StringValue("ListRepositoryWebhook.ErrorCode");
			listRepositoryWebhookResponse.Success = _ctx.BooleanValue("ListRepositoryWebhook.Success");
			listRepositoryWebhookResponse.ErrorMessage = _ctx.StringValue("ListRepositoryWebhook.ErrorMessage");
			listRepositoryWebhookResponse.Total = _ctx.LongValue("ListRepositoryWebhook.Total");

			List<ListRepositoryWebhookResponse.ListRepositoryWebhook_ResultItem> listRepositoryWebhookResponse_result = new List<ListRepositoryWebhookResponse.ListRepositoryWebhook_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListRepositoryWebhook.Result.Length"); i++) {
				ListRepositoryWebhookResponse.ListRepositoryWebhook_ResultItem resultItem = new ListRepositoryWebhookResponse.ListRepositoryWebhook_ResultItem();
				resultItem.Id = _ctx.LongValue("ListRepositoryWebhook.Result["+ i +"].Id");
				resultItem.Url = _ctx.StringValue("ListRepositoryWebhook.Result["+ i +"].Url");
				resultItem.CreatedAt = _ctx.StringValue("ListRepositoryWebhook.Result["+ i +"].CreatedAt");
				resultItem.ProjectId = _ctx.LongValue("ListRepositoryWebhook.Result["+ i +"].ProjectId");
				resultItem.PushEvents = _ctx.BooleanValue("ListRepositoryWebhook.Result["+ i +"].PushEvents");
				resultItem.MergeRequestsEvents = _ctx.BooleanValue("ListRepositoryWebhook.Result["+ i +"].MergeRequestsEvents");
				resultItem.TagPushEvents = _ctx.BooleanValue("ListRepositoryWebhook.Result["+ i +"].TagPushEvents");
				resultItem.NoteEvents = _ctx.BooleanValue("ListRepositoryWebhook.Result["+ i +"].NoteEvents");
				resultItem.EnableSslVerification = _ctx.BooleanValue("ListRepositoryWebhook.Result["+ i +"].EnableSslVerification");
				resultItem.LastTestResult = _ctx.StringValue("ListRepositoryWebhook.Result["+ i +"].LastTestResult");
				resultItem.Description = _ctx.StringValue("ListRepositoryWebhook.Result["+ i +"].Description");
				resultItem.SecretToken = _ctx.StringValue("ListRepositoryWebhook.Result["+ i +"].SecretToken");

				listRepositoryWebhookResponse_result.Add(resultItem);
			}
			listRepositoryWebhookResponse.Result = listRepositoryWebhookResponse_result;
        
			return listRepositoryWebhookResponse;
        }
    }
}
