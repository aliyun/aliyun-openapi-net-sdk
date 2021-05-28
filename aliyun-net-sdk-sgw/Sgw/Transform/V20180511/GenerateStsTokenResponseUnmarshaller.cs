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
using Aliyun.Acs.sgw.Model.V20180511;

namespace Aliyun.Acs.sgw.Transform.V20180511
{
    public class GenerateStsTokenResponseUnmarshaller
    {
        public static GenerateStsTokenResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GenerateStsTokenResponse generateStsTokenResponse = new GenerateStsTokenResponse();

			generateStsTokenResponse.HttpResponse = _ctx.HttpResponse;
			generateStsTokenResponse.RequestId = _ctx.StringValue("GenerateStsToken.RequestId");
			generateStsTokenResponse.Success = _ctx.BooleanValue("GenerateStsToken.Success");
			generateStsTokenResponse.Code = _ctx.StringValue("GenerateStsToken.Code");
			generateStsTokenResponse.Message = _ctx.StringValue("GenerateStsToken.Message");
			generateStsTokenResponse.AccessKeyId = _ctx.StringValue("GenerateStsToken.AccessKeyId");
			generateStsTokenResponse.AccessKeySecret = _ctx.StringValue("GenerateStsToken.AccessKeySecret");
			generateStsTokenResponse.Expiration = _ctx.StringValue("GenerateStsToken.Expiration");
			generateStsTokenResponse.SecurityToken = _ctx.StringValue("GenerateStsToken.SecurityToken");
			generateStsTokenResponse.SupportBundleTarget = _ctx.StringValue("GenerateStsToken.SupportBundleTarget");
			generateStsTokenResponse.Environment = _ctx.StringValue("GenerateStsToken.Environment");
        
			return generateStsTokenResponse;
        }
    }
}
