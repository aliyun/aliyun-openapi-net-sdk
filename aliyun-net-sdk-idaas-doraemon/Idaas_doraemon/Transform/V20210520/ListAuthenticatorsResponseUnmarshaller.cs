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
    public class ListAuthenticatorsResponseUnmarshaller
    {
        public static ListAuthenticatorsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAuthenticatorsResponse listAuthenticatorsResponse = new ListAuthenticatorsResponse();

			listAuthenticatorsResponse.HttpResponse = _ctx.HttpResponse;
			listAuthenticatorsResponse.RequestId = _ctx.StringValue("ListAuthenticators.RequestId");
			listAuthenticatorsResponse.PageNumber = _ctx.LongValue("ListAuthenticators.PageNumber");
			listAuthenticatorsResponse.TotalCount = _ctx.LongValue("ListAuthenticators.TotalCount");
			listAuthenticatorsResponse.PageSize = _ctx.LongValue("ListAuthenticators.PageSize");

			List<ListAuthenticatorsResponse.ListAuthenticators_AuthenticatorListDTO> listAuthenticatorsResponse_authenticator = new List<ListAuthenticatorsResponse.ListAuthenticators_AuthenticatorListDTO>();
			for (int i = 0; i < _ctx.Length("ListAuthenticators.Authenticator.Length"); i++) {
				ListAuthenticatorsResponse.ListAuthenticators_AuthenticatorListDTO authenticatorListDTO = new ListAuthenticatorsResponse.ListAuthenticators_AuthenticatorListDTO();
				authenticatorListDTO.ApplicationExternalId = _ctx.StringValue("ListAuthenticators.Authenticator["+ i +"].ApplicationExternalId");
				authenticatorListDTO.AuthenticatorUuid = _ctx.StringValue("ListAuthenticators.Authenticator["+ i +"].AuthenticatorUuid");
				authenticatorListDTO.CredentialId = _ctx.StringValue("ListAuthenticators.Authenticator["+ i +"].CredentialId");
				authenticatorListDTO.Type = _ctx.StringValue("ListAuthenticators.Authenticator["+ i +"].Type");
				authenticatorListDTO.AuthenticatorName = _ctx.StringValue("ListAuthenticators.Authenticator["+ i +"].AuthenticatorName");
				authenticatorListDTO.RegisterTime = _ctx.LongValue("ListAuthenticators.Authenticator["+ i +"].RegisterTime");
				authenticatorListDTO.LastVerifyTime = _ctx.LongValue("ListAuthenticators.Authenticator["+ i +"].LastVerifyTime");

				listAuthenticatorsResponse_authenticator.Add(authenticatorListDTO);
			}
			listAuthenticatorsResponse.Authenticator = listAuthenticatorsResponse_authenticator;
        
			return listAuthenticatorsResponse;
        }
    }
}
