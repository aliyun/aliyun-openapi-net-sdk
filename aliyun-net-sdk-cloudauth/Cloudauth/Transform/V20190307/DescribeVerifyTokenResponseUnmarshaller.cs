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
using Aliyun.Acs.Cloudauth.Model.V20190307;

namespace Aliyun.Acs.Cloudauth.Transform.V20190307
{
    public class DescribeVerifyTokenResponseUnmarshaller
    {
        public static DescribeVerifyTokenResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVerifyTokenResponse describeVerifyTokenResponse = new DescribeVerifyTokenResponse();

			describeVerifyTokenResponse.HttpResponse = _ctx.HttpResponse;
			describeVerifyTokenResponse.RequestId = _ctx.StringValue("DescribeVerifyToken.RequestId");
			describeVerifyTokenResponse.VerifyPageUrl = _ctx.StringValue("DescribeVerifyToken.VerifyPageUrl");
			describeVerifyTokenResponse.VerifyToken = _ctx.StringValue("DescribeVerifyToken.VerifyToken");

			DescribeVerifyTokenResponse.DescribeVerifyToken_OssUploadToken ossUploadToken = new DescribeVerifyTokenResponse.DescribeVerifyToken_OssUploadToken();
			ossUploadToken.Bucket = _ctx.StringValue("DescribeVerifyToken.OssUploadToken.Bucket");
			ossUploadToken.EndPoint = _ctx.StringValue("DescribeVerifyToken.OssUploadToken.EndPoint");
			ossUploadToken.Path = _ctx.StringValue("DescribeVerifyToken.OssUploadToken.Path");
			ossUploadToken.Expired = _ctx.LongValue("DescribeVerifyToken.OssUploadToken.Expired");
			ossUploadToken.Secret = _ctx.StringValue("DescribeVerifyToken.OssUploadToken.Secret");
			ossUploadToken.Key = _ctx.StringValue("DescribeVerifyToken.OssUploadToken.Key");
			ossUploadToken.Token = _ctx.StringValue("DescribeVerifyToken.OssUploadToken.Token");
			describeVerifyTokenResponse.OssUploadToken = ossUploadToken;
        
			return describeVerifyTokenResponse;
        }
    }
}
