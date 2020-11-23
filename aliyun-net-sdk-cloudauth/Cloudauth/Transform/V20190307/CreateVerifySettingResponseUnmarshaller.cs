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
    public class CreateVerifySettingResponseUnmarshaller
    {
        public static CreateVerifySettingResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateVerifySettingResponse createVerifySettingResponse = new CreateVerifySettingResponse();

			createVerifySettingResponse.HttpResponse = _ctx.HttpResponse;
			createVerifySettingResponse.RequestId = _ctx.StringValue("CreateVerifySetting.RequestId");
			createVerifySettingResponse.BizType = _ctx.StringValue("CreateVerifySetting.BizType");
			createVerifySettingResponse.BizName = _ctx.StringValue("CreateVerifySetting.BizName");
			createVerifySettingResponse.Solution = _ctx.StringValue("CreateVerifySetting.Solution");

			List<string> createVerifySettingResponse_stepList = new List<string>();
			for (int i = 0; i < _ctx.Length("CreateVerifySetting.StepList.Length"); i++) {
				createVerifySettingResponse_stepList.Add(_ctx.StringValue("CreateVerifySetting.StepList["+ i +"]"));
			}
			createVerifySettingResponse.StepList = createVerifySettingResponse_stepList;
        
			return createVerifySettingResponse;
        }
    }
}
