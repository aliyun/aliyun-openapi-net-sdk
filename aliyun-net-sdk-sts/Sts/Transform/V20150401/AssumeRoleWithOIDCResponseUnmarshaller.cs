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
using Aliyun.Acs.Sts.Model.V20150401;

namespace Aliyun.Acs.Sts.Transform.V20150401
{
    public class AssumeRoleWithOIDCResponseUnmarshaller
    {
        public static AssumeRoleWithOIDCResponse Unmarshall(UnmarshallerContext _ctx)
        {
			AssumeRoleWithOIDCResponse assumeRoleWithOIDCResponse = new AssumeRoleWithOIDCResponse();

			assumeRoleWithOIDCResponse.HttpResponse = _ctx.HttpResponse;
			assumeRoleWithOIDCResponse.RequestId = _ctx.StringValue("AssumeRoleWithOIDC.RequestId");

			AssumeRoleWithOIDCResponse.AssumeRoleWithOIDC_OIDCTokenInfo oIDCTokenInfo = new AssumeRoleWithOIDCResponse.AssumeRoleWithOIDC_OIDCTokenInfo();
			oIDCTokenInfo.Subject = _ctx.StringValue("AssumeRoleWithOIDC.OIDCTokenInfo.Subject");
			oIDCTokenInfo.Issuer = _ctx.StringValue("AssumeRoleWithOIDC.OIDCTokenInfo.Issuer");
			oIDCTokenInfo.ClientIds = _ctx.StringValue("AssumeRoleWithOIDC.OIDCTokenInfo.ClientIds");
			assumeRoleWithOIDCResponse.OIDCTokenInfo = oIDCTokenInfo;

			AssumeRoleWithOIDCResponse.AssumeRoleWithOIDC_AssumedRoleUser assumedRoleUser = new AssumeRoleWithOIDCResponse.AssumeRoleWithOIDC_AssumedRoleUser();
			assumedRoleUser.AssumedRoleId = _ctx.StringValue("AssumeRoleWithOIDC.AssumedRoleUser.AssumedRoleId");
			assumedRoleUser.Arn = _ctx.StringValue("AssumeRoleWithOIDC.AssumedRoleUser.Arn");
			assumeRoleWithOIDCResponse.AssumedRoleUser = assumedRoleUser;

			AssumeRoleWithOIDCResponse.AssumeRoleWithOIDC_Credentials credentials = new AssumeRoleWithOIDCResponse.AssumeRoleWithOIDC_Credentials();
			credentials.SecurityToken = _ctx.StringValue("AssumeRoleWithOIDC.Credentials.SecurityToken");
			credentials.Expiration = _ctx.StringValue("AssumeRoleWithOIDC.Credentials.Expiration");
			credentials.AccessKeySecret = _ctx.StringValue("AssumeRoleWithOIDC.Credentials.AccessKeySecret");
			credentials.AccessKeyId = _ctx.StringValue("AssumeRoleWithOIDC.Credentials.AccessKeyId");
			assumeRoleWithOIDCResponse.Credentials = credentials;
        
			return assumeRoleWithOIDCResponse;
        }
    }
}
