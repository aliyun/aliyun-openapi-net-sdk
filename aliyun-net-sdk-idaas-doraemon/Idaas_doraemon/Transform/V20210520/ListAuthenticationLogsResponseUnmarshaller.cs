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
    public class ListAuthenticationLogsResponseUnmarshaller
    {
        public static ListAuthenticationLogsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAuthenticationLogsResponse listAuthenticationLogsResponse = new ListAuthenticationLogsResponse();

			listAuthenticationLogsResponse.HttpResponse = _ctx.HttpResponse;
			listAuthenticationLogsResponse.RequestId = _ctx.StringValue("ListAuthenticationLogs.RequestId");
			listAuthenticationLogsResponse.TotalCount = _ctx.LongValue("ListAuthenticationLogs.TotalCount");
			listAuthenticationLogsResponse.PageNumber = _ctx.LongValue("ListAuthenticationLogs.PageNumber");
			listAuthenticationLogsResponse.PageSize = _ctx.LongValue("ListAuthenticationLogs.PageSize");

			List<ListAuthenticationLogsResponse.ListAuthenticationLogs_AuthenticationLogContentItem> listAuthenticationLogsResponse_authenticationLogContent = new List<ListAuthenticationLogsResponse.ListAuthenticationLogs_AuthenticationLogContentItem>();
			for (int i = 0; i < _ctx.Length("ListAuthenticationLogs.AuthenticationLogContent.Length"); i++) {
				ListAuthenticationLogsResponse.ListAuthenticationLogs_AuthenticationLogContentItem authenticationLogContentItem = new ListAuthenticationLogsResponse.ListAuthenticationLogs_AuthenticationLogContentItem();
				authenticationLogContentItem.TenantId = _ctx.StringValue("ListAuthenticationLogs.AuthenticationLogContent["+ i +"].TenantId");
				authenticationLogContentItem.AliUid = _ctx.StringValue("ListAuthenticationLogs.AuthenticationLogContent["+ i +"].AliUid");
				authenticationLogContentItem.ApplicationUuid = _ctx.StringValue("ListAuthenticationLogs.AuthenticationLogContent["+ i +"].ApplicationUuid");
				authenticationLogContentItem.ApplicationExternalId = _ctx.StringValue("ListAuthenticationLogs.AuthenticationLogContent["+ i +"].ApplicationExternalId");
				authenticationLogContentItem.UserId = _ctx.StringValue("ListAuthenticationLogs.AuthenticationLogContent["+ i +"].UserId");
				authenticationLogContentItem.AuthenticatorUuid = _ctx.StringValue("ListAuthenticationLogs.AuthenticationLogContent["+ i +"].AuthenticatorUuid");
				authenticationLogContentItem.AuthenticatorName = _ctx.StringValue("ListAuthenticationLogs.AuthenticationLogContent["+ i +"].AuthenticatorName");
				authenticationLogContentItem.CredentialId = _ctx.StringValue("ListAuthenticationLogs.AuthenticationLogContent["+ i +"].CredentialId");
				authenticationLogContentItem.AuthenticatorType = _ctx.StringValue("ListAuthenticationLogs.AuthenticationLogContent["+ i +"].AuthenticatorType");
				authenticationLogContentItem.AuthenticationAction = _ctx.StringValue("ListAuthenticationLogs.AuthenticationLogContent["+ i +"].AuthenticationAction");
				authenticationLogContentItem.ChallengeBase64 = _ctx.StringValue("ListAuthenticationLogs.AuthenticationLogContent["+ i +"].ChallengeBase64");
				authenticationLogContentItem.AuthenticationTime = _ctx.LongValue("ListAuthenticationLogs.AuthenticationLogContent["+ i +"].AuthenticationTime");
				authenticationLogContentItem.UserAgent = _ctx.StringValue("ListAuthenticationLogs.AuthenticationLogContent["+ i +"].UserAgent");
				authenticationLogContentItem.UserSourceIp = _ctx.StringValue("ListAuthenticationLogs.AuthenticationLogContent["+ i +"].UserSourceIp");
				authenticationLogContentItem.RawAuthenticationContext = _ctx.StringValue("ListAuthenticationLogs.AuthenticationLogContent["+ i +"].RawAuthenticationContext");
				authenticationLogContentItem.VerifyResult = _ctx.BooleanValue("ListAuthenticationLogs.AuthenticationLogContent["+ i +"].VerifyResult");
				authenticationLogContentItem.ErrorCode = _ctx.StringValue("ListAuthenticationLogs.AuthenticationLogContent["+ i +"].ErrorCode");
				authenticationLogContentItem.ErrorMessage = _ctx.StringValue("ListAuthenticationLogs.AuthenticationLogContent["+ i +"].ErrorMessage");
				authenticationLogContentItem.LogTag = _ctx.StringValue("ListAuthenticationLogs.AuthenticationLogContent["+ i +"].LogTag");
				authenticationLogContentItem.LogParams = _ctx.StringValue("ListAuthenticationLogs.AuthenticationLogContent["+ i +"].LogParams");

				listAuthenticationLogsResponse_authenticationLogContent.Add(authenticationLogContentItem);
			}
			listAuthenticationLogsResponse.AuthenticationLogContent = listAuthenticationLogsResponse_authenticationLogContent;
        
			return listAuthenticationLogsResponse;
        }
    }
}
