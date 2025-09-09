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
using Aliyun.Acs.WebsiteBuild.Model.V20250429;

namespace Aliyun.Acs.WebsiteBuild.Transform.V20250429
{
    public class GetUserTmpIdentityForPartnerResponseUnmarshaller
    {
        public static GetUserTmpIdentityForPartnerResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetUserTmpIdentityForPartnerResponse getUserTmpIdentityForPartnerResponse = new GetUserTmpIdentityForPartnerResponse();

			getUserTmpIdentityForPartnerResponse.HttpResponse = _ctx.HttpResponse;
			getUserTmpIdentityForPartnerResponse.RequestId = _ctx.StringValue("GetUserTmpIdentityForPartner.RequestId");
			getUserTmpIdentityForPartnerResponse.ErrorMsg = _ctx.StringValue("GetUserTmpIdentityForPartner.ErrorMsg");
			getUserTmpIdentityForPartnerResponse.Success = _ctx.BooleanValue("GetUserTmpIdentityForPartner.Success");
			getUserTmpIdentityForPartnerResponse.ErrorCode = _ctx.StringValue("GetUserTmpIdentityForPartner.ErrorCode");

			GetUserTmpIdentityForPartnerResponse.GetUserTmpIdentityForPartner_Data data = new GetUserTmpIdentityForPartnerResponse.GetUserTmpIdentityForPartner_Data();
			data.HasCustomRoleAuth = _ctx.BooleanValue("GetUserTmpIdentityForPartner.Data.HasCustomRoleAuth");

			GetUserTmpIdentityForPartnerResponse.GetUserTmpIdentityForPartner_Data.GetUserTmpIdentityForPartner_Credentials credentials = new GetUserTmpIdentityForPartnerResponse.GetUserTmpIdentityForPartner_Data.GetUserTmpIdentityForPartner_Credentials();
			credentials.EncryptedAccessKeyId = _ctx.StringValue("GetUserTmpIdentityForPartner.Data.Credentials.EncryptedAccessKeyId");
			credentials.EncryptedAccessKeySecret = _ctx.StringValue("GetUserTmpIdentityForPartner.Data.Credentials.EncryptedAccessKeySecret");
			credentials.EncryptedSecurityToken = _ctx.StringValue("GetUserTmpIdentityForPartner.Data.Credentials.EncryptedSecurityToken");
			credentials.Expiration = _ctx.StringValue("GetUserTmpIdentityForPartner.Data.Credentials.Expiration");
			data.Credentials = credentials;
			getUserTmpIdentityForPartnerResponse.Data = data;
        
			return getUserTmpIdentityForPartnerResponse;
        }
    }
}
