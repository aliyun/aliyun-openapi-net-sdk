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
    public class GetUserAccessTokenForPartnerResponseUnmarshaller
    {
        public static GetUserAccessTokenForPartnerResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetUserAccessTokenForPartnerResponse getUserAccessTokenForPartnerResponse = new GetUserAccessTokenForPartnerResponse();

			getUserAccessTokenForPartnerResponse.HttpResponse = _ctx.HttpResponse;
			getUserAccessTokenForPartnerResponse.RequestId = _ctx.StringValue("GetUserAccessTokenForPartner.RequestId");
			getUserAccessTokenForPartnerResponse.Success = _ctx.StringValue("GetUserAccessTokenForPartner.Success");
			getUserAccessTokenForPartnerResponse.ErrorCode = _ctx.StringValue("GetUserAccessTokenForPartner.ErrorCode");

			GetUserAccessTokenForPartnerResponse.GetUserAccessTokenForPartner_Module module = new GetUserAccessTokenForPartnerResponse.GetUserAccessTokenForPartner_Module();
			module.TokenValue = _ctx.StringValue("GetUserAccessTokenForPartner.Module.TokenValue");
			getUserAccessTokenForPartnerResponse.Module = module;
        
			return getUserAccessTokenForPartnerResponse;
        }
    }
}
