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
using Aliyun.Acs.idaas_doraemon.Model.V20210520;

namespace Aliyun.Acs.idaas_doraemon.Transform.V20210520
{
    public class ListAuthenticatorOpsLogsResponseUnmarshaller
    {
        public static ListAuthenticatorOpsLogsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAuthenticatorOpsLogsResponse listAuthenticatorOpsLogsResponse = new ListAuthenticatorOpsLogsResponse();

			listAuthenticatorOpsLogsResponse.HttpResponse = _ctx.HttpResponse;
			listAuthenticatorOpsLogsResponse.RequestId = _ctx.StringValue("ListAuthenticatorOpsLogs.RequestId");
			listAuthenticatorOpsLogsResponse.TotalCount = _ctx.LongValue("ListAuthenticatorOpsLogs.TotalCount");
			listAuthenticatorOpsLogsResponse.PageNumber = _ctx.LongValue("ListAuthenticatorOpsLogs.PageNumber");
			listAuthenticatorOpsLogsResponse.PageSize = _ctx.LongValue("ListAuthenticatorOpsLogs.PageSize");

			List<ListAuthenticatorOpsLogsResponse.ListAuthenticatorOpsLogs_AuthenticationLogContentItem> listAuthenticatorOpsLogsResponse_authenticationLogContent = new List<ListAuthenticatorOpsLogsResponse.ListAuthenticatorOpsLogs_AuthenticationLogContentItem>();
			for (int i = 0; i < _ctx.Length("ListAuthenticatorOpsLogs.AuthenticationLogContent.Length"); i++) {
				ListAuthenticatorOpsLogsResponse.ListAuthenticatorOpsLogs_AuthenticationLogContentItem authenticationLogContentItem = new ListAuthenticatorOpsLogsResponse.ListAuthenticatorOpsLogs_AuthenticationLogContentItem();
				authenticationLogContentItem.TenantId = _ctx.StringValue("ListAuthenticatorOpsLogs.AuthenticationLogContent["+ i +"].TenantId");
				authenticationLogContentItem.AliUid = _ctx.StringValue("ListAuthenticatorOpsLogs.AuthenticationLogContent["+ i +"].AliUid");
				authenticationLogContentItem.ApplicationUuid = _ctx.StringValue("ListAuthenticatorOpsLogs.AuthenticationLogContent["+ i +"].ApplicationUuid");
				authenticationLogContentItem.ApplicationExternalId = _ctx.StringValue("ListAuthenticatorOpsLogs.AuthenticationLogContent["+ i +"].ApplicationExternalId");
				authenticationLogContentItem.UserId = _ctx.StringValue("ListAuthenticatorOpsLogs.AuthenticationLogContent["+ i +"].UserId");
				authenticationLogContentItem.AuthenticatorUuid = _ctx.StringValue("ListAuthenticatorOpsLogs.AuthenticationLogContent["+ i +"].AuthenticatorUuid");
				authenticationLogContentItem.AuthenticatorName = _ctx.StringValue("ListAuthenticatorOpsLogs.AuthenticationLogContent["+ i +"].AuthenticatorName");
				authenticationLogContentItem.CredentialId = _ctx.StringValue("ListAuthenticatorOpsLogs.AuthenticationLogContent["+ i +"].CredentialId");
				authenticationLogContentItem.AuthenticatorType = _ctx.StringValue("ListAuthenticatorOpsLogs.AuthenticationLogContent["+ i +"].AuthenticatorType");
				authenticationLogContentItem.OperationAction = _ctx.StringValue("ListAuthenticatorOpsLogs.AuthenticationLogContent["+ i +"].OperationAction");
				authenticationLogContentItem.ChallengeBase64 = _ctx.StringValue("ListAuthenticatorOpsLogs.AuthenticationLogContent["+ i +"].ChallengeBase64");
				authenticationLogContentItem.OperationTime = _ctx.LongValue("ListAuthenticatorOpsLogs.AuthenticationLogContent["+ i +"].OperationTime");
				authenticationLogContentItem.UserAgent = _ctx.StringValue("ListAuthenticatorOpsLogs.AuthenticationLogContent["+ i +"].UserAgent");
				authenticationLogContentItem.UserSourceIp = _ctx.StringValue("ListAuthenticatorOpsLogs.AuthenticationLogContent["+ i +"].UserSourceIp");
				authenticationLogContentItem.RawContext = _ctx.StringValue("ListAuthenticatorOpsLogs.AuthenticationLogContent["+ i +"].RawContext");
				authenticationLogContentItem.OperationResult = _ctx.BooleanValue("ListAuthenticatorOpsLogs.AuthenticationLogContent["+ i +"].OperationResult");
				authenticationLogContentItem.ErrorCode = _ctx.StringValue("ListAuthenticatorOpsLogs.AuthenticationLogContent["+ i +"].ErrorCode");
				authenticationLogContentItem.ErrorMessage = _ctx.StringValue("ListAuthenticatorOpsLogs.AuthenticationLogContent["+ i +"].ErrorMessage");
				authenticationLogContentItem.LogParams = _ctx.StringValue("ListAuthenticatorOpsLogs.AuthenticationLogContent["+ i +"].LogParams");

				listAuthenticatorOpsLogsResponse_authenticationLogContent.Add(authenticationLogContentItem);
			}
			listAuthenticatorOpsLogsResponse.AuthenticationLogContent = listAuthenticatorOpsLogsResponse_authenticationLogContent;
        
			return listAuthenticatorOpsLogsResponse;
        }
    }
}
