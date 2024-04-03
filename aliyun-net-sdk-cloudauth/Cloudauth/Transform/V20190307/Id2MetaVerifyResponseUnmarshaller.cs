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
    public class Id2MetaVerifyResponseUnmarshaller
    {
        public static Id2MetaVerifyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			Id2MetaVerifyResponse id2MetaVerifyResponse = new Id2MetaVerifyResponse();

			id2MetaVerifyResponse.HttpResponse = _ctx.HttpResponse;
			id2MetaVerifyResponse.RequestId = _ctx.StringValue("Id2MetaVerify.RequestId");
			id2MetaVerifyResponse.Code = _ctx.StringValue("Id2MetaVerify.Code");
			id2MetaVerifyResponse.Message = _ctx.StringValue("Id2MetaVerify.Message");

			Id2MetaVerifyResponse.Id2MetaVerify_ResultObject resultObject = new Id2MetaVerifyResponse.Id2MetaVerify_ResultObject();
			resultObject.BizCode = _ctx.StringValue("Id2MetaVerify.ResultObject.BizCode");
			id2MetaVerifyResponse.ResultObject = resultObject;
        
			return id2MetaVerifyResponse;
        }
    }
}
