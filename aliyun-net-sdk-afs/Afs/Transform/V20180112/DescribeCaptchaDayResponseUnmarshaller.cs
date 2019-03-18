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
using Aliyun.Acs.afs.Model.V20180112;

namespace Aliyun.Acs.afs.Transform.V20180112
{
    public class DescribeCaptchaDayResponseUnmarshaller
    {
        public static DescribeCaptchaDayResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCaptchaDayResponse describeCaptchaDayResponse = new DescribeCaptchaDayResponse();

			describeCaptchaDayResponse.HttpResponse = context.HttpResponse;
			describeCaptchaDayResponse.RequestId = context.StringValue("DescribeCaptchaDay.RequestId");
			describeCaptchaDayResponse.BizCode = context.StringValue("DescribeCaptchaDay.BizCode");
			describeCaptchaDayResponse.HasData = context.BooleanValue("DescribeCaptchaDay.HasData");

			DescribeCaptchaDayResponse.DescribeCaptchaDay_CaptchaDay captchaDay = new DescribeCaptchaDayResponse.DescribeCaptchaDay_CaptchaDay();
			captchaDay.Init = context.IntegerValue("DescribeCaptchaDay.CaptchaDay.Init");
			captchaDay.AskForVerify = context.IntegerValue("DescribeCaptchaDay.CaptchaDay.AskForVerify");
			captchaDay.DirecetStrategyInterception = context.IntegerValue("DescribeCaptchaDay.CaptchaDay.DirecetStrategyInterception");
			captchaDay.TwiceVerify = context.IntegerValue("DescribeCaptchaDay.CaptchaDay.TwiceVerify");
			captchaDay.Pass = context.IntegerValue("DescribeCaptchaDay.CaptchaDay.Pass");
			captchaDay.CheckTested = context.IntegerValue("DescribeCaptchaDay.CaptchaDay.CheckTested");
			captchaDay.UncheckTested = context.IntegerValue("DescribeCaptchaDay.CaptchaDay.UncheckTested");
			captchaDay.LegalSign = context.IntegerValue("DescribeCaptchaDay.CaptchaDay.LegalSign");
			captchaDay.MaliciousFlow = context.IntegerValue("DescribeCaptchaDay.CaptchaDay.MaliciousFlow");
			describeCaptchaDayResponse.CaptchaDay = captchaDay;
        
			return describeCaptchaDayResponse;
        }
    }
}
