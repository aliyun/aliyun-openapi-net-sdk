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
    public class UpdatePersonalICodeResponseUnmarshaller
    {
        public static UpdatePersonalICodeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdatePersonalICodeResponse updatePersonalICodeResponse = new UpdatePersonalICodeResponse();

			updatePersonalICodeResponse.HttpResponse = _ctx.HttpResponse;
			updatePersonalICodeResponse.RequestId = _ctx.StringValue("UpdatePersonalICode.RequestId");
			updatePersonalICodeResponse.Success = _ctx.BooleanValue("UpdatePersonalICode.Success");

			UpdatePersonalICodeResponse.UpdatePersonalICode_Result result = new UpdatePersonalICodeResponse.UpdatePersonalICode_Result();
			result.IcodeKey = _ctx.StringValue("UpdatePersonalICode.Result.IcodeKey");
			result.Type = _ctx.IntegerValue("UpdatePersonalICode.Result.Type");
			result.Icode = _ctx.StringValue("UpdatePersonalICode.Result.Icode");
			updatePersonalICodeResponse.Result = result;
        
			return updatePersonalICodeResponse;
        }
    }
}
