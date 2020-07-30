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
    public class InitSmartVerifyResponseUnmarshaller
    {
        public static InitSmartVerifyResponse Unmarshall(UnmarshallerContext context)
        {
			InitSmartVerifyResponse initSmartVerifyResponse = new InitSmartVerifyResponse();

			initSmartVerifyResponse.HttpResponse = context.HttpResponse;
			initSmartVerifyResponse.RequestId = context.StringValue("InitSmartVerify.RequestId");
			initSmartVerifyResponse.Message = context.StringValue("InitSmartVerify.Message");
			initSmartVerifyResponse.Code = context.StringValue("InitSmartVerify.Code");

			InitSmartVerifyResponse.InitSmartVerify_ResultObject resultObject = new InitSmartVerifyResponse.InitSmartVerify_ResultObject();
			resultObject.CertifyId = context.StringValue("InitSmartVerify.ResultObject.CertifyId");
			initSmartVerifyResponse.ResultObject = resultObject;
        
			return initSmartVerifyResponse;
        }
    }
}
