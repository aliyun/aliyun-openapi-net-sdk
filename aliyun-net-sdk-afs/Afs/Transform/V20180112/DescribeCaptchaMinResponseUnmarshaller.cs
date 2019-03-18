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
    public class DescribeCaptchaMinResponseUnmarshaller
    {
        public static DescribeCaptchaMinResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCaptchaMinResponse describeCaptchaMinResponse = new DescribeCaptchaMinResponse();

			describeCaptchaMinResponse.HttpResponse = context.HttpResponse;
			describeCaptchaMinResponse.RequestId = context.StringValue("DescribeCaptchaMin.RequestId");
			describeCaptchaMinResponse.BizCode = context.StringValue("DescribeCaptchaMin.BizCode");
			describeCaptchaMinResponse.HasData = context.BooleanValue("DescribeCaptchaMin.HasData");

			List<DescribeCaptchaMinResponse.DescribeCaptchaMin_CaptchaMin> describeCaptchaMinResponse_captchaMins = new List<DescribeCaptchaMinResponse.DescribeCaptchaMin_CaptchaMin>();
			for (int i = 0; i < context.Length("DescribeCaptchaMin.CaptchaMins.Length"); i++) {
				DescribeCaptchaMinResponse.DescribeCaptchaMin_CaptchaMin captchaMin = new DescribeCaptchaMinResponse.DescribeCaptchaMin_CaptchaMin();
				captchaMin.Time = context.StringValue("DescribeCaptchaMin.CaptchaMins["+ i +"].Time");
				captchaMin.Pass = context.StringValue("DescribeCaptchaMin.CaptchaMins["+ i +"].Pass");
				captchaMin.Interception = context.StringValue("DescribeCaptchaMin.CaptchaMins["+ i +"].Interception");

				describeCaptchaMinResponse_captchaMins.Add(captchaMin);
			}
			describeCaptchaMinResponse.CaptchaMins = describeCaptchaMinResponse_captchaMins;
        
			return describeCaptchaMinResponse;
        }
    }
}
