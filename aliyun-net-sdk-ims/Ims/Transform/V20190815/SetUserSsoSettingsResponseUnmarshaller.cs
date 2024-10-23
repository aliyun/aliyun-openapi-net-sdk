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
using Aliyun.Acs.Ims.Model.V20190815;

namespace Aliyun.Acs.Ims.Transform.V20190815
{
    public class SetUserSsoSettingsResponseUnmarshaller
    {
        public static SetUserSsoSettingsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SetUserSsoSettingsResponse setUserSsoSettingsResponse = new SetUserSsoSettingsResponse();

			setUserSsoSettingsResponse.HttpResponse = _ctx.HttpResponse;
			setUserSsoSettingsResponse.RequestId = _ctx.StringValue("SetUserSsoSettings.RequestId");

			SetUserSsoSettingsResponse.SetUserSsoSettings_UserSsoSettings userSsoSettings = new SetUserSsoSettingsResponse.SetUserSsoSettings_UserSsoSettings();
			userSsoSettings.AuxiliaryDomain = _ctx.StringValue("SetUserSsoSettings.UserSsoSettings.AuxiliaryDomain");
			userSsoSettings.MetadataDocument = _ctx.StringValue("SetUserSsoSettings.UserSsoSettings.MetadataDocument");
			userSsoSettings.SsoEnabled = _ctx.BooleanValue("SetUserSsoSettings.UserSsoSettings.SsoEnabled");
			userSsoSettings.Name = _ctx.StringValue("SetUserSsoSettings.UserSsoSettings.Name");
			setUserSsoSettingsResponse.UserSsoSettings = userSsoSettings;
        
			return setUserSsoSettingsResponse;
        }
    }
}
