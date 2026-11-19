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
using Aliyun.Acs.quickbi_public.Model.V20220101;

namespace Aliyun.Acs.quickbi_public.Transform.V20220101
{
    public class GetPersonalICodeResponseUnmarshaller
    {
        public static GetPersonalICodeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetPersonalICodeResponse getPersonalICodeResponse = new GetPersonalICodeResponse();

			getPersonalICodeResponse.HttpResponse = _ctx.HttpResponse;
			getPersonalICodeResponse.RequestId = _ctx.StringValue("GetPersonalICode.RequestId");
			getPersonalICodeResponse.Success = _ctx.BooleanValue("GetPersonalICode.Success");

			GetPersonalICodeResponse.GetPersonalICode_Result result = new GetPersonalICodeResponse.GetPersonalICode_Result();
			result.IcodeKey = _ctx.StringValue("GetPersonalICode.Result.IcodeKey");
			result.Type = _ctx.IntegerValue("GetPersonalICode.Result.Type");
			result.Icode = _ctx.StringValue("GetPersonalICode.Result.Icode");
			getPersonalICodeResponse.Result = result;
        
			return getPersonalICodeResponse;
        }
    }
}
