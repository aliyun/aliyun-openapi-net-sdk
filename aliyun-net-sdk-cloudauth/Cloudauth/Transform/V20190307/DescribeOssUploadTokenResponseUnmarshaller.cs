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
    public class DescribeOssUploadTokenResponseUnmarshaller
    {
        public static DescribeOssUploadTokenResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeOssUploadTokenResponse describeOssUploadTokenResponse = new DescribeOssUploadTokenResponse();

			describeOssUploadTokenResponse.HttpResponse = context.HttpResponse;
			describeOssUploadTokenResponse.RequestId = context.StringValue("DescribeOssUploadToken.RequestId");

			DescribeOssUploadTokenResponse.DescribeOssUploadToken_OssUploadToken ossUploadToken = new DescribeOssUploadTokenResponse.DescribeOssUploadToken_OssUploadToken();
			ossUploadToken.Bucket = context.StringValue("DescribeOssUploadToken.OssUploadToken.Bucket");
			ossUploadToken.EndPoint = context.StringValue("DescribeOssUploadToken.OssUploadToken.EndPoint");
			ossUploadToken.Path = context.StringValue("DescribeOssUploadToken.OssUploadToken.Path");
			ossUploadToken.Expired = context.LongValue("DescribeOssUploadToken.OssUploadToken.Expired");
			ossUploadToken.Secret = context.StringValue("DescribeOssUploadToken.OssUploadToken.Secret");
			ossUploadToken.Key = context.StringValue("DescribeOssUploadToken.OssUploadToken.Key");
			ossUploadToken.Token = context.StringValue("DescribeOssUploadToken.OssUploadToken.Token");
			describeOssUploadTokenResponse.OssUploadToken = ossUploadToken;
        
			return describeOssUploadTokenResponse;
        }
    }
}
