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
    public class UpdateVerifySettingResponseUnmarshaller
    {
        public static UpdateVerifySettingResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateVerifySettingResponse updateVerifySettingResponse = new UpdateVerifySettingResponse();

			updateVerifySettingResponse.HttpResponse = _ctx.HttpResponse;
			updateVerifySettingResponse.RequestId = _ctx.StringValue("UpdateVerifySetting.RequestId");
			updateVerifySettingResponse.BizType = _ctx.StringValue("UpdateVerifySetting.BizType");
			updateVerifySettingResponse.BizName = _ctx.StringValue("UpdateVerifySetting.BizName");
			updateVerifySettingResponse.Solution = _ctx.StringValue("UpdateVerifySetting.Solution");

			List<string> updateVerifySettingResponse_stepList = new List<string>();
			for (int i = 0; i < _ctx.Length("UpdateVerifySetting.StepList.Length"); i++) {
				updateVerifySettingResponse_stepList.Add(_ctx.StringValue("UpdateVerifySetting.StepList["+ i +"]"));
			}
			updateVerifySettingResponse.StepList = updateVerifySettingResponse_stepList;
        
			return updateVerifySettingResponse;
        }
    }
}
