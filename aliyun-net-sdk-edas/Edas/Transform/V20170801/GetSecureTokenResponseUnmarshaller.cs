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
using Aliyun.Acs.Edas.Model.V20170801;

namespace Aliyun.Acs.Edas.Transform.V20170801
{
    public class GetSecureTokenResponseUnmarshaller
    {
        public static GetSecureTokenResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetSecureTokenResponse getSecureTokenResponse = new GetSecureTokenResponse();

			getSecureTokenResponse.HttpResponse = _ctx.HttpResponse;
			getSecureTokenResponse.Code = _ctx.IntegerValue("GetSecureToken.Code");
			getSecureTokenResponse.Message = _ctx.StringValue("GetSecureToken.Message");
			getSecureTokenResponse.RequestId = _ctx.StringValue("GetSecureToken.RequestId");

			GetSecureTokenResponse.GetSecureToken_SecureToken secureToken = new GetSecureTokenResponse.GetSecureToken_SecureToken();
			secureToken.Id = _ctx.LongValue("GetSecureToken.SecureToken.Id");
			secureToken.UserId = _ctx.StringValue("GetSecureToken.SecureToken.UserId");
			secureToken.EdasId = _ctx.StringValue("GetSecureToken.SecureToken.EdasId");
			secureToken.RegionId = _ctx.StringValue("GetSecureToken.SecureToken.RegionId");
			secureToken.RegionName = _ctx.StringValue("GetSecureToken.SecureToken.RegionName");
			secureToken.Description = _ctx.StringValue("GetSecureToken.SecureToken.Description");
			secureToken.BelongRegion = _ctx.StringValue("GetSecureToken.SecureToken.BelongRegion");
			secureToken.AccessKey = _ctx.StringValue("GetSecureToken.SecureToken.AccessKey");
			secureToken.SecretKey = _ctx.StringValue("GetSecureToken.SecureToken.SecretKey");
			secureToken.TenantId = _ctx.StringValue("GetSecureToken.SecureToken.TenantId");
			secureToken.AddressServerHost = _ctx.StringValue("GetSecureToken.SecureToken.AddressServerHost");
			getSecureTokenResponse.SecureToken = secureToken;
        
			return getSecureTokenResponse;
        }
    }
}
