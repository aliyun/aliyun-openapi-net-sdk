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
    public class ModifyMixResponseUnmarshaller
    {
        public static ModifyMixResponse Unmarshall(UnmarshallerContext context)
        {
			ModifyMixResponse modifyMixResponse = new ModifyMixResponse();

			modifyMixResponse.HttpResponse = context.HttpResponse;
			modifyMixResponse.RequestId = context.StringValue("ModifyMix.RequestId");
			modifyMixResponse.Code = context.StringValue("ModifyMix.Code");
			modifyMixResponse.Message = context.StringValue("ModifyMix.Message");

			ModifyMixResponse.ModifyMix_Result result = new ModifyMixResponse.ModifyMix_Result();
			result.Name = context.StringValue("ModifyMix.Result.Name");
			result.GmtCreate = context.StringValue("ModifyMix.Result.GmtCreate");
			result.GmtModified = context.StringValue("ModifyMix.Result.GmtModified");

			ModifyMixResponse.ModifyMix_Result.ModifyMix_Parameter parameter = new ModifyMixResponse.ModifyMix_Result.ModifyMix_Parameter();

			List<ModifyMixResponse.ModifyMix_Result.ModifyMix_Parameter.ModifyMix_SettingsItem> parameter_settings = new List<ModifyMixResponse.ModifyMix_Result.ModifyMix_Parameter.ModifyMix_SettingsItem>();
			for (int i = 0; i < context.Length("ModifyMix.Result.Parameter.Settings.Length"); i++) {
				ModifyMixResponse.ModifyMix_Result.ModifyMix_Parameter.ModifyMix_SettingsItem settingsItem = new ModifyMixResponse.ModifyMix_Result.ModifyMix_Parameter.ModifyMix_SettingsItem();
				settingsItem.Name = context.StringValue("ModifyMix.Result.Parameter.Settings["+ i +"].Name");
				settingsItem._Value = context.IntegerValue("ModifyMix.Result.Parameter.Settings["+ i +"].Value");

				parameter_settings.Add(settingsItem);
			}
			parameter.Settings = parameter_settings;
			result.Parameter = parameter;
			modifyMixResponse.Result = result;
        
			return modifyMixResponse;
        }
    }
}
