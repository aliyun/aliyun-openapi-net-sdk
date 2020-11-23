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
using Aliyun.Acs.Cloudauth.Model.V20180916;

namespace Aliyun.Acs.Cloudauth.Transform.V20180916
{
    public class GetVerifyTokenResponseUnmarshaller
    {
        public static GetVerifyTokenResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetVerifyTokenResponse getVerifyTokenResponse = new GetVerifyTokenResponse();

			getVerifyTokenResponse.HttpResponse = _ctx.HttpResponse;
			getVerifyTokenResponse.RequestId = _ctx.StringValue("GetVerifyToken.RequestId");
			getVerifyTokenResponse.Success = _ctx.BooleanValue("GetVerifyToken.Success");
			getVerifyTokenResponse.Code = _ctx.StringValue("GetVerifyToken.Code");
			getVerifyTokenResponse.Message = _ctx.StringValue("GetVerifyToken.Message");

			GetVerifyTokenResponse.GetVerifyToken_Data data = new GetVerifyTokenResponse.GetVerifyToken_Data();
			data.CloudauthPageUrl = _ctx.StringValue("GetVerifyToken.Data.CloudauthPageUrl");

			GetVerifyTokenResponse.GetVerifyToken_Data.GetVerifyToken_VerifyToken verifyToken = new GetVerifyTokenResponse.GetVerifyToken_Data.GetVerifyToken_VerifyToken();
			verifyToken.Token = _ctx.StringValue("GetVerifyToken.Data.VerifyToken.Token");
			verifyToken.DurationSeconds = _ctx.IntegerValue("GetVerifyToken.Data.VerifyToken.DurationSeconds");
			data.VerifyToken = verifyToken;

			GetVerifyTokenResponse.GetVerifyToken_Data.GetVerifyToken_StsToken stsToken = new GetVerifyTokenResponse.GetVerifyToken_Data.GetVerifyToken_StsToken();
			stsToken.AccessKeyId = _ctx.StringValue("GetVerifyToken.Data.StsToken.AccessKeyId");
			stsToken.AccessKeySecret = _ctx.StringValue("GetVerifyToken.Data.StsToken.AccessKeySecret");
			stsToken.Expiration = _ctx.StringValue("GetVerifyToken.Data.StsToken.Expiration");
			stsToken.EndPoint = _ctx.StringValue("GetVerifyToken.Data.StsToken.EndPoint");
			stsToken.BucketName = _ctx.StringValue("GetVerifyToken.Data.StsToken.BucketName");
			stsToken.Path = _ctx.StringValue("GetVerifyToken.Data.StsToken.Path");
			stsToken.Token = _ctx.StringValue("GetVerifyToken.Data.StsToken.Token");
			data.StsToken = stsToken;
			getVerifyTokenResponse.Data = data;
        
			return getVerifyTokenResponse;
        }
    }
}
