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
using Aliyun.Acs.oos.Model.V20190601;

namespace Aliyun.Acs.oos.Transform.V20190601
{
    public class SetServiceSettingsResponseUnmarshaller
    {
        public static SetServiceSettingsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SetServiceSettingsResponse setServiceSettingsResponse = new SetServiceSettingsResponse();

			setServiceSettingsResponse.HttpResponse = _ctx.HttpResponse;
			setServiceSettingsResponse.RequestId = _ctx.StringValue("SetServiceSettings.RequestId");

			List<SetServiceSettingsResponse.SetServiceSettings_ServiceSetting> setServiceSettingsResponse_serviceSettings = new List<SetServiceSettingsResponse.SetServiceSettings_ServiceSetting>();
			for (int i = 0; i < _ctx.Length("SetServiceSettings.ServiceSettings.Length"); i++) {
				SetServiceSettingsResponse.SetServiceSettings_ServiceSetting serviceSetting = new SetServiceSettingsResponse.SetServiceSettings_ServiceSetting();
				serviceSetting.DeliveryOssEnabled = _ctx.BooleanValue("SetServiceSettings.ServiceSettings["+ i +"].DeliveryOssEnabled");
				serviceSetting.DeliveryOssBucketName = _ctx.StringValue("SetServiceSettings.ServiceSettings["+ i +"].DeliveryOssBucketName");
				serviceSetting.DeliveryOssKeyPrefix = _ctx.StringValue("SetServiceSettings.ServiceSettings["+ i +"].DeliveryOssKeyPrefix");
				serviceSetting.DeliverySlsEnabled = _ctx.BooleanValue("SetServiceSettings.ServiceSettings["+ i +"].DeliverySlsEnabled");
				serviceSetting.DeliverySlsProjectName = _ctx.StringValue("SetServiceSettings.ServiceSettings["+ i +"].DeliverySlsProjectName");

				setServiceSettingsResponse_serviceSettings.Add(serviceSetting);
			}
			setServiceSettingsResponse.ServiceSettings = setServiceSettingsResponse_serviceSettings;
        
			return setServiceSettingsResponse;
        }
    }
}
