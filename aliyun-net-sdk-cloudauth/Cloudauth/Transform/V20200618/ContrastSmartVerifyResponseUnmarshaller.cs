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
using Aliyun.Acs.Cloudauth.Model.V20200618;

namespace Aliyun.Acs.Cloudauth.Transform.V20200618
{
    public class ContrastSmartVerifyResponseUnmarshaller
    {
        public static ContrastSmartVerifyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ContrastSmartVerifyResponse contrastSmartVerifyResponse = new ContrastSmartVerifyResponse();

			contrastSmartVerifyResponse.HttpResponse = _ctx.HttpResponse;
			contrastSmartVerifyResponse.RequestId = _ctx.StringValue("ContrastSmartVerify.RequestId");
			contrastSmartVerifyResponse.Message = _ctx.StringValue("ContrastSmartVerify.Message");
			contrastSmartVerifyResponse.Code = _ctx.StringValue("ContrastSmartVerify.Code");

			ContrastSmartVerifyResponse.ContrastSmartVerify_ResultObject resultObject = new ContrastSmartVerifyResponse.ContrastSmartVerify_ResultObject();
			resultObject.CertifyId = _ctx.StringValue("ContrastSmartVerify.ResultObject.CertifyId");
			resultObject.Passed = _ctx.StringValue("ContrastSmartVerify.ResultObject.Passed");
			resultObject.SubCode = _ctx.StringValue("ContrastSmartVerify.ResultObject.SubCode");
			resultObject.VerifyInfo = _ctx.StringValue("ContrastSmartVerify.ResultObject.VerifyInfo");
			resultObject.RiskInfo = _ctx.StringValue("ContrastSmartVerify.ResultObject.RiskInfo");
			contrastSmartVerifyResponse.ResultObject = resultObject;
        
			return contrastSmartVerifyResponse;
        }
    }
}
