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
    public class ListMixResponseUnmarshaller
    {
        public static ListMixResponse Unmarshall(UnmarshallerContext context)
        {
			ListMixResponse listMixResponse = new ListMixResponse();

			listMixResponse.HttpResponse = context.HttpResponse;
			listMixResponse.RequestId = context.StringValue("ListMix.RequestId");
			listMixResponse.Code = context.StringValue("ListMix.Code");
			listMixResponse.Message = context.StringValue("ListMix.Message");

			List<ListMixResponse.ListMix_ResultItem> listMixResponse_result = new List<ListMixResponse.ListMix_ResultItem>();
			for (int i = 0; i < context.Length("ListMix.Result.Length"); i++) {
				ListMixResponse.ListMix_ResultItem resultItem = new ListMixResponse.ListMix_ResultItem();
				resultItem.Name = context.StringValue("ListMix.Result["+ i +"].Name");
				resultItem.GmtCreate = context.StringValue("ListMix.Result["+ i +"].GmtCreate");
				resultItem.GmtModified = context.StringValue("ListMix.Result["+ i +"].GmtModified");

				ListMixResponse.ListMix_ResultItem.ListMix_Parameter parameter = new ListMixResponse.ListMix_ResultItem.ListMix_Parameter();

				List<ListMixResponse.ListMix_ResultItem.ListMix_Parameter.ListMix_SettingsItem> parameter_settings = new List<ListMixResponse.ListMix_ResultItem.ListMix_Parameter.ListMix_SettingsItem>();
				for (int j = 0; j < context.Length("ListMix.Result["+ i +"].Parameter.Settings.Length"); j++) {
					ListMixResponse.ListMix_ResultItem.ListMix_Parameter.ListMix_SettingsItem settingsItem = new ListMixResponse.ListMix_ResultItem.ListMix_Parameter.ListMix_SettingsItem();
					settingsItem.Name = context.StringValue("ListMix.Result["+ i +"].Parameter.Settings["+ j +"].Name");
					settingsItem._Value = context.IntegerValue("ListMix.Result["+ i +"].Parameter.Settings["+ j +"].Value");

					parameter_settings.Add(settingsItem);
				}
				parameter.Settings = parameter_settings;
				resultItem.Parameter = parameter;

				listMixResponse_result.Add(resultItem);
			}
			listMixResponse.Result = listMixResponse_result;
        
			return listMixResponse;
        }
    }
}
