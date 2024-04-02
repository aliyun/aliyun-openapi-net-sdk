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
using Aliyun.Acs.Green.Model.V20170823;

namespace Aliyun.Acs.Green.Transform.V20170823
{
    public class DescribeBizTypeSettingResponseUnmarshaller
    {
        public static DescribeBizTypeSettingResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeBizTypeSettingResponse describeBizTypeSettingResponse = new DescribeBizTypeSettingResponse();

			describeBizTypeSettingResponse.HttpResponse = _ctx.HttpResponse;
			describeBizTypeSettingResponse.RequestId = _ctx.StringValue("DescribeBizTypeSetting.RequestId");

			DescribeBizTypeSettingResponse.DescribeBizTypeSetting_Terrorism terrorism = new DescribeBizTypeSettingResponse.DescribeBizTypeSetting_Terrorism();

			List<string> terrorism_categories = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeBizTypeSetting.Terrorism.Categories.Length"); i++) {
				terrorism_categories.Add(_ctx.StringValue("DescribeBizTypeSetting.Terrorism.Categories["+ i +"]"));
			}
			terrorism.Categories = terrorism_categories;
			describeBizTypeSettingResponse.Terrorism = terrorism;

			DescribeBizTypeSettingResponse.DescribeBizTypeSetting_Porn porn = new DescribeBizTypeSettingResponse.DescribeBizTypeSetting_Porn();

			List<string> porn_categories1 = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeBizTypeSetting.Porn.Categories.Length"); i++) {
				porn_categories1.Add(_ctx.StringValue("DescribeBizTypeSetting.Porn.Categories["+ i +"]"));
			}
			porn.Categories1 = porn_categories1;
			describeBizTypeSettingResponse.Porn = porn;

			DescribeBizTypeSettingResponse.DescribeBizTypeSetting_Antispam antispam = new DescribeBizTypeSettingResponse.DescribeBizTypeSetting_Antispam();

			List<string> antispam_categories2 = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeBizTypeSetting.Antispam.Categories.Length"); i++) {
				antispam_categories2.Add(_ctx.StringValue("DescribeBizTypeSetting.Antispam.Categories["+ i +"]"));
			}
			antispam.Categories2 = antispam_categories2;
			describeBizTypeSettingResponse.Antispam = antispam;

			DescribeBizTypeSettingResponse.DescribeBizTypeSetting_Ad ad = new DescribeBizTypeSettingResponse.DescribeBizTypeSetting_Ad();

			List<string> ad_categories3 = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeBizTypeSetting.Ad.Categories.Length"); i++) {
				ad_categories3.Add(_ctx.StringValue("DescribeBizTypeSetting.Ad.Categories["+ i +"]"));
			}
			ad.Categories3 = ad_categories3;
			describeBizTypeSettingResponse.Ad = ad;

			DescribeBizTypeSettingResponse.DescribeBizTypeSetting_Live live = new DescribeBizTypeSettingResponse.DescribeBizTypeSetting_Live();

			List<string> live_categories4 = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeBizTypeSetting.Live.Categories.Length"); i++) {
				live_categories4.Add(_ctx.StringValue("DescribeBizTypeSetting.Live.Categories["+ i +"]"));
			}
			live.Categories4 = live_categories4;
			describeBizTypeSettingResponse.Live = live;
        
			return describeBizTypeSettingResponse;
        }
    }
}
