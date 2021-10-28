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
using Aliyun.Acs.Cloudauth.Model.V20201112;

namespace Aliyun.Acs.Cloudauth.Transform.V20201112
{
    public class DescribeVerifyTokenResponseUnmarshaller
    {
        public static DescribeVerifyTokenResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVerifyTokenResponse describeVerifyTokenResponse = new DescribeVerifyTokenResponse();

			describeVerifyTokenResponse.HttpResponse = _ctx.HttpResponse;
			describeVerifyTokenResponse.RequestId = _ctx.StringValue("DescribeVerifyToken.RequestId");
			describeVerifyTokenResponse.Code = _ctx.StringValue("DescribeVerifyToken.Code");
			describeVerifyTokenResponse.Message = _ctx.StringValue("DescribeVerifyToken.Message");
			describeVerifyTokenResponse.Success = _ctx.BooleanValue("DescribeVerifyToken.Success");

			DescribeVerifyTokenResponse.DescribeVerifyToken_ResultObject resultObject = new DescribeVerifyTokenResponse.DescribeVerifyToken_ResultObject();
			resultObject.VerifyPageUrl = _ctx.StringValue("DescribeVerifyToken.ResultObject.VerifyPageUrl");
			resultObject.VerifyToken = _ctx.StringValue("DescribeVerifyToken.ResultObject.VerifyToken");
			describeVerifyTokenResponse.ResultObject = resultObject;
        
			return describeVerifyTokenResponse;
        }
    }
}
