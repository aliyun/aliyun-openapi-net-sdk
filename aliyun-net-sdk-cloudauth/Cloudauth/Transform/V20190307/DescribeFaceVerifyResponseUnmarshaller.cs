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
    public class DescribeFaceVerifyResponseUnmarshaller
    {
        public static DescribeFaceVerifyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeFaceVerifyResponse describeFaceVerifyResponse = new DescribeFaceVerifyResponse();

			describeFaceVerifyResponse.HttpResponse = _ctx.HttpResponse;
			describeFaceVerifyResponse.RequestId = _ctx.StringValue("DescribeFaceVerify.RequestId");
			describeFaceVerifyResponse.Message = _ctx.StringValue("DescribeFaceVerify.Message");
			describeFaceVerifyResponse.Code = _ctx.StringValue("DescribeFaceVerify.Code");

			DescribeFaceVerifyResponse.DescribeFaceVerify_ResultObject resultObject = new DescribeFaceVerifyResponse.DescribeFaceVerify_ResultObject();
			resultObject.Passed = _ctx.StringValue("DescribeFaceVerify.ResultObject.Passed");
			resultObject.IdentityInfo = _ctx.StringValue("DescribeFaceVerify.ResultObject.IdentityInfo");
			resultObject.MaterialInfo = _ctx.StringValue("DescribeFaceVerify.ResultObject.MaterialInfo");
			resultObject.DeviceToken = _ctx.StringValue("DescribeFaceVerify.ResultObject.DeviceToken");
			resultObject.SubCode = _ctx.StringValue("DescribeFaceVerify.ResultObject.SubCode");
			describeFaceVerifyResponse.ResultObject = resultObject;
        
			return describeFaceVerifyResponse;
        }
    }
}
