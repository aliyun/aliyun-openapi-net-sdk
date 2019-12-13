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
        public static DescribeBizTypeSettingResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeBizTypeSettingResponse describeBizTypeSettingResponse = new DescribeBizTypeSettingResponse();

			describeBizTypeSettingResponse.HttpResponse = context.HttpResponse;
			describeBizTypeSettingResponse.RequestId = context.StringValue("DescribeBizTypeSetting.RequestId");

			DescribeBizTypeSettingResponse.DescribeBizTypeSetting_Terrorism terrorism = new DescribeBizTypeSettingResponse.DescribeBizTypeSetting_Terrorism();

			List<string> terrorism_categories = new List<string>();
			for (int i = 0; i < context.Length("DescribeBizTypeSetting.Terrorism.Categories.Length"); i++) {
				terrorism_categories.Add(context.StringValue("DescribeBizTypeSetting.Terrorism.Categories["+ i +"]"));
			}
			terrorism.Categories = terrorism_categories;
			describeBizTypeSettingResponse.Terrorism = terrorism;

			DescribeBizTypeSettingResponse.DescribeBizTypeSetting_Porn porn = new DescribeBizTypeSettingResponse.DescribeBizTypeSetting_Porn();

			List<string> porn_categories1 = new List<string>();
			for (int i = 0; i < context.Length("DescribeBizTypeSetting.Porn.Categories.Length"); i++) {
				porn_categories1.Add(context.StringValue("DescribeBizTypeSetting.Porn.Categories["+ i +"]"));
			}
			porn.Categories1 = porn_categories1;
			describeBizTypeSettingResponse.Porn = porn;

			DescribeBizTypeSettingResponse.DescribeBizTypeSetting_Antispam antispam = new DescribeBizTypeSettingResponse.DescribeBizTypeSetting_Antispam();

			List<string> antispam_categories2 = new List<string>();
			for (int i = 0; i < context.Length("DescribeBizTypeSetting.Antispam.Categories.Length"); i++) {
				antispam_categories2.Add(context.StringValue("DescribeBizTypeSetting.Antispam.Categories["+ i +"]"));
			}
			antispam.Categories2 = antispam_categories2;
			describeBizTypeSettingResponse.Antispam = antispam;
        
			return describeBizTypeSettingResponse;
        }
    }
}
