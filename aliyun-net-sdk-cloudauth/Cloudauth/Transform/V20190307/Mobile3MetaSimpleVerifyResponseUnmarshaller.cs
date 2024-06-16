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
    public class Mobile3MetaSimpleVerifyResponseUnmarshaller
    {
        public static Mobile3MetaSimpleVerifyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			Mobile3MetaSimpleVerifyResponse mobile3MetaSimpleVerifyResponse = new Mobile3MetaSimpleVerifyResponse();

			mobile3MetaSimpleVerifyResponse.HttpResponse = _ctx.HttpResponse;
			mobile3MetaSimpleVerifyResponse.RequestId = _ctx.StringValue("Mobile3MetaSimpleVerify.RequestId");
			mobile3MetaSimpleVerifyResponse.Code = _ctx.StringValue("Mobile3MetaSimpleVerify.Code");
			mobile3MetaSimpleVerifyResponse.Message = _ctx.StringValue("Mobile3MetaSimpleVerify.Message");

			Mobile3MetaSimpleVerifyResponse.Mobile3MetaSimpleVerify_ResultObject resultObject = new Mobile3MetaSimpleVerifyResponse.Mobile3MetaSimpleVerify_ResultObject();
			resultObject.BizCode = _ctx.StringValue("Mobile3MetaSimpleVerify.ResultObject.BizCode");
			resultObject.IspName = _ctx.StringValue("Mobile3MetaSimpleVerify.ResultObject.IspName");
			mobile3MetaSimpleVerifyResponse.ResultObject = resultObject;
        
			return mobile3MetaSimpleVerifyResponse;
        }
    }
}
