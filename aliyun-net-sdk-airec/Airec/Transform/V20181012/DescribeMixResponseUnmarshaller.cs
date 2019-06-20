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
using Aliyun.Acs.Airec.Model.V20181012;

namespace Aliyun.Acs.Airec.Transform.V20181012
{
    public class DescribeMixResponseUnmarshaller
    {
        public static DescribeMixResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeMixResponse describeMixResponse = new DescribeMixResponse();

			describeMixResponse.HttpResponse = context.HttpResponse;
			describeMixResponse.RequestId = context.StringValue("DescribeMix.RequestId");
			describeMixResponse.Code = context.StringValue("DescribeMix.Code");
			describeMixResponse.Message = context.StringValue("DescribeMix.Message");

			DescribeMixResponse.DescribeMix_Result result = new DescribeMixResponse.DescribeMix_Result();
			result.Name = context.StringValue("DescribeMix.Result.Name");
			result.GmtCreate = context.StringValue("DescribeMix.Result.GmtCreate");
			result.GmtModified = context.StringValue("DescribeMix.Result.GmtModified");

			DescribeMixResponse.DescribeMix_Result.DescribeMix_Parameter parameter = new DescribeMixResponse.DescribeMix_Result.DescribeMix_Parameter();

			List<DescribeMixResponse.DescribeMix_Result.DescribeMix_Parameter.DescribeMix_SettingsItem> parameter_settings = new List<DescribeMixResponse.DescribeMix_Result.DescribeMix_Parameter.DescribeMix_SettingsItem>();
			for (int i = 0; i < context.Length("DescribeMix.Result.Parameter.Settings.Length"); i++) {
				DescribeMixResponse.DescribeMix_Result.DescribeMix_Parameter.DescribeMix_SettingsItem settingsItem = new DescribeMixResponse.DescribeMix_Result.DescribeMix_Parameter.DescribeMix_SettingsItem();
				settingsItem.Name = context.StringValue("DescribeMix.Result.Parameter.Settings["+ i +"].Name");
				settingsItem._Value = context.IntegerValue("DescribeMix.Result.Parameter.Settings["+ i +"].Value");

				parameter_settings.Add(settingsItem);
			}
			parameter.Settings = parameter_settings;
			result.Parameter = parameter;
			describeMixResponse.Result = result;
        
			return describeMixResponse;
        }
    }
}
