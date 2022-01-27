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
    public class GetServiceSettingsResponseUnmarshaller
    {
        public static GetServiceSettingsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetServiceSettingsResponse getServiceSettingsResponse = new GetServiceSettingsResponse();

			getServiceSettingsResponse.HttpResponse = _ctx.HttpResponse;
			getServiceSettingsResponse.RequestId = _ctx.StringValue("GetServiceSettings.RequestId");

			List<GetServiceSettingsResponse.GetServiceSettings_ServiceSetting> getServiceSettingsResponse_serviceSettings = new List<GetServiceSettingsResponse.GetServiceSettings_ServiceSetting>();
			for (int i = 0; i < _ctx.Length("GetServiceSettings.ServiceSettings.Length"); i++) {
				GetServiceSettingsResponse.GetServiceSettings_ServiceSetting serviceSetting = new GetServiceSettingsResponse.GetServiceSettings_ServiceSetting();
				serviceSetting.DeliveryOssEnabled = _ctx.BooleanValue("GetServiceSettings.ServiceSettings["+ i +"].DeliveryOssEnabled");
				serviceSetting.DeliveryOssBucketName = _ctx.StringValue("GetServiceSettings.ServiceSettings["+ i +"].DeliveryOssBucketName");
				serviceSetting.DeliveryOssKeyPrefix = _ctx.StringValue("GetServiceSettings.ServiceSettings["+ i +"].DeliveryOssKeyPrefix");
				serviceSetting.DeliverySlsEnabled = _ctx.BooleanValue("GetServiceSettings.ServiceSettings["+ i +"].DeliverySlsEnabled");
				serviceSetting.DeliverySlsProjectName = _ctx.StringValue("GetServiceSettings.ServiceSettings["+ i +"].DeliverySlsProjectName");

				getServiceSettingsResponse_serviceSettings.Add(serviceSetting);
			}
			getServiceSettingsResponse.ServiceSettings = getServiceSettingsResponse_serviceSettings;
        
			return getServiceSettingsResponse;
        }
    }
}
