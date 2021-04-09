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
    public class ElementSmartVerifyResponseUnmarshaller
    {
        public static ElementSmartVerifyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ElementSmartVerifyResponse elementSmartVerifyResponse = new ElementSmartVerifyResponse();

			elementSmartVerifyResponse.HttpResponse = _ctx.HttpResponse;
			elementSmartVerifyResponse.RequestId = _ctx.StringValue("ElementSmartVerify.RequestId");
			elementSmartVerifyResponse.Message = _ctx.StringValue("ElementSmartVerify.Message");
			elementSmartVerifyResponse.Code = _ctx.StringValue("ElementSmartVerify.Code");

			ElementSmartVerifyResponse.ElementSmartVerify_ResultObject resultObject = new ElementSmartVerifyResponse.ElementSmartVerify_ResultObject();
			resultObject.Passed = _ctx.StringValue("ElementSmartVerify.ResultObject.Passed");
			resultObject.SubCode = _ctx.StringValue("ElementSmartVerify.ResultObject.SubCode");
			resultObject.MaterialInfo = _ctx.StringValue("ElementSmartVerify.ResultObject.MaterialInfo");
			resultObject.CertifyId = _ctx.StringValue("ElementSmartVerify.ResultObject.CertifyId");
			elementSmartVerifyResponse.ResultObject = resultObject;
        
			return elementSmartVerifyResponse;
        }
    }
}
