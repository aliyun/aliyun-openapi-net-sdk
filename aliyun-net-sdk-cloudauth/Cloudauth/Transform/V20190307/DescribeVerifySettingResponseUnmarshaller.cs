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
    public class DescribeVerifySettingResponseUnmarshaller
    {
        public static DescribeVerifySettingResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVerifySettingResponse describeVerifySettingResponse = new DescribeVerifySettingResponse();

			describeVerifySettingResponse.HttpResponse = _ctx.HttpResponse;
			describeVerifySettingResponse.RequestId = _ctx.StringValue("DescribeVerifySetting.RequestId");

			List<DescribeVerifySettingResponse.DescribeVerifySetting_VerifySetting> describeVerifySettingResponse_verifySettingList = new List<DescribeVerifySettingResponse.DescribeVerifySetting_VerifySetting>();
			for (int i = 0; i < _ctx.Length("DescribeVerifySetting.VerifySettingList.Length"); i++) {
				DescribeVerifySettingResponse.DescribeVerifySetting_VerifySetting verifySetting = new DescribeVerifySettingResponse.DescribeVerifySetting_VerifySetting();
				verifySetting.BizType = _ctx.StringValue("DescribeVerifySetting.VerifySettingList["+ i +"].BizType");
				verifySetting.BizName = _ctx.StringValue("DescribeVerifySetting.VerifySettingList["+ i +"].BizName");
				verifySetting.Solution = _ctx.StringValue("DescribeVerifySetting.VerifySettingList["+ i +"].Solution");

				List<string> verifySetting_stepList = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeVerifySetting.VerifySettingList["+ i +"].StepList.Length"); j++) {
					verifySetting_stepList.Add(_ctx.StringValue("DescribeVerifySetting.VerifySettingList["+ i +"].StepList["+ j +"]"));
				}
				verifySetting.StepList = verifySetting_stepList;

				describeVerifySettingResponse_verifySettingList.Add(verifySetting);
			}
			describeVerifySettingResponse.VerifySettingList = describeVerifySettingResponse_verifySettingList;
        
			return describeVerifySettingResponse;
        }
    }
}
