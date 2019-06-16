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
    public class CreateMixResponseUnmarshaller
    {
        public static CreateMixResponse Unmarshall(UnmarshallerContext context)
        {
			CreateMixResponse createMixResponse = new CreateMixResponse();

			createMixResponse.HttpResponse = context.HttpResponse;
			createMixResponse.RequestId = context.StringValue("CreateMix.RequestId");
			createMixResponse.Code = context.StringValue("CreateMix.Code");
			createMixResponse.Message = context.StringValue("CreateMix.Message");

			CreateMixResponse.CreateMix_Result result = new CreateMixResponse.CreateMix_Result();
			result.Name = context.StringValue("CreateMix.Result.Name");
			result.GmtCreate = context.StringValue("CreateMix.Result.GmtCreate");
			result.GmtModified = context.StringValue("CreateMix.Result.GmtModified");

			CreateMixResponse.CreateMix_Result.CreateMix_Parameter parameter = new CreateMixResponse.CreateMix_Result.CreateMix_Parameter();

			List<CreateMixResponse.CreateMix_Result.CreateMix_Parameter.CreateMix_SettingsItem> parameter_settings = new List<CreateMixResponse.CreateMix_Result.CreateMix_Parameter.CreateMix_SettingsItem>();
			for (int i = 0; i < context.Length("CreateMix.Result.Parameter.Settings.Length"); i++) {
				CreateMixResponse.CreateMix_Result.CreateMix_Parameter.CreateMix_SettingsItem settingsItem = new CreateMixResponse.CreateMix_Result.CreateMix_Parameter.CreateMix_SettingsItem();
				settingsItem.Name = context.StringValue("CreateMix.Result.Parameter.Settings["+ i +"].Name");
				settingsItem._Value = context.IntegerValue("CreateMix.Result.Parameter.Settings["+ i +"].Value");

				parameter_settings.Add(settingsItem);
			}
			parameter.Settings = parameter_settings;
			result.Parameter = parameter;
			createMixResponse.Result = result;
        
			return createMixResponse;
        }
    }
}
