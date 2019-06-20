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
    public class DeleteMixResponseUnmarshaller
    {
        public static DeleteMixResponse Unmarshall(UnmarshallerContext context)
        {
			DeleteMixResponse deleteMixResponse = new DeleteMixResponse();

			deleteMixResponse.HttpResponse = context.HttpResponse;
			deleteMixResponse.RequestId = context.StringValue("DeleteMix.RequestId");
			deleteMixResponse.Code = context.StringValue("DeleteMix.Code");
			deleteMixResponse.Message = context.StringValue("DeleteMix.Message");

			DeleteMixResponse.DeleteMix_Result result = new DeleteMixResponse.DeleteMix_Result();
			result.Name = context.StringValue("DeleteMix.Result.Name");
			result.GmtCreate = context.StringValue("DeleteMix.Result.GmtCreate");
			result.GmtModified = context.StringValue("DeleteMix.Result.GmtModified");

			DeleteMixResponse.DeleteMix_Result.DeleteMix_Parameter parameter = new DeleteMixResponse.DeleteMix_Result.DeleteMix_Parameter();

			List<DeleteMixResponse.DeleteMix_Result.DeleteMix_Parameter.DeleteMix_SettingsItem> parameter_settings = new List<DeleteMixResponse.DeleteMix_Result.DeleteMix_Parameter.DeleteMix_SettingsItem>();
			for (int i = 0; i < context.Length("DeleteMix.Result.Parameter.Settings.Length"); i++) {
				DeleteMixResponse.DeleteMix_Result.DeleteMix_Parameter.DeleteMix_SettingsItem settingsItem = new DeleteMixResponse.DeleteMix_Result.DeleteMix_Parameter.DeleteMix_SettingsItem();
				settingsItem.Name = context.StringValue("DeleteMix.Result.Parameter.Settings["+ i +"].Name");
				settingsItem._Value = context.StringValue("DeleteMix.Result.Parameter.Settings["+ i +"].Value");

				parameter_settings.Add(settingsItem);
			}
			parameter.Settings = parameter_settings;
			result.Parameter = parameter;
			deleteMixResponse.Result = result;
        
			return deleteMixResponse;
        }
    }
}
