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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.afs.Model.V20180112;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.afs.Transform.V20180112
{
    public class DescribeCaptchaIpCityResponseUnmarshaller
    {
        public static DescribeCaptchaIpCityResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCaptchaIpCityResponse describeCaptchaIpCityResponse = new DescribeCaptchaIpCityResponse();

			describeCaptchaIpCityResponse.HttpResponse = context.HttpResponse;
			describeCaptchaIpCityResponse.RequestId = context.StringValue("DescribeCaptchaIpCity.RequestId");
			describeCaptchaIpCityResponse.BizCode = context.StringValue("DescribeCaptchaIpCity.BizCode");
			describeCaptchaIpCityResponse.HasData = context.BooleanValue("DescribeCaptchaIpCity.HasData");

			List<DescribeCaptchaIpCityResponse.DescribeCaptchaIpCity_CaptchaCitie> describeCaptchaIpCityResponse_captchaCities = new List<DescribeCaptchaIpCityResponse.DescribeCaptchaIpCity_CaptchaCitie>();
			for (int i = 0; i < context.Length("DescribeCaptchaIpCity.CaptchaCities.Length"); i++) {
				DescribeCaptchaIpCityResponse.DescribeCaptchaIpCity_CaptchaCitie captchaCitie = new DescribeCaptchaIpCityResponse.DescribeCaptchaIpCity_CaptchaCitie();
				captchaCitie.Location = context.StringValue("DescribeCaptchaIpCity.CaptchaCities["+ i +"].Location");
				captchaCitie.Lat = context.StringValue("DescribeCaptchaIpCity.CaptchaCities["+ i +"].Lat");
				captchaCitie.Lng = context.StringValue("DescribeCaptchaIpCity.CaptchaCities["+ i +"].Lng");
				captchaCitie.Pv = context.IntegerValue("DescribeCaptchaIpCity.CaptchaCities["+ i +"].Pv");

				describeCaptchaIpCityResponse_captchaCities.Add(captchaCitie);
			}
			describeCaptchaIpCityResponse.CaptchaCities = describeCaptchaIpCityResponse_captchaCities;

			List<DescribeCaptchaIpCityResponse.DescribeCaptchaIpCity_CaptchaIp> describeCaptchaIpCityResponse_captchaIps = new List<DescribeCaptchaIpCityResponse.DescribeCaptchaIpCity_CaptchaIp>();
			for (int i = 0; i < context.Length("DescribeCaptchaIpCity.CaptchaIps.Length"); i++) {
				DescribeCaptchaIpCityResponse.DescribeCaptchaIpCity_CaptchaIp captchaIp = new DescribeCaptchaIpCityResponse.DescribeCaptchaIpCity_CaptchaIp();
				captchaIp.Ip = context.StringValue("DescribeCaptchaIpCity.CaptchaIps["+ i +"].Ip");
				captchaIp._Value = context.IntegerValue("DescribeCaptchaIpCity.CaptchaIps["+ i +"].Value");

				describeCaptchaIpCityResponse_captchaIps.Add(captchaIp);
			}
			describeCaptchaIpCityResponse.CaptchaIps = describeCaptchaIpCityResponse_captchaIps;
        
			return describeCaptchaIpCityResponse;
        }
    }
}