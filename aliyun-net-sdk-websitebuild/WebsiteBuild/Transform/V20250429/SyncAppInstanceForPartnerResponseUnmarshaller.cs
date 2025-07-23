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
using Aliyun.Acs.WebsiteBuild.Model.V20250429;

namespace Aliyun.Acs.WebsiteBuild.Transform.V20250429
{
    public class SyncAppInstanceForPartnerResponseUnmarshaller
    {
        public static SyncAppInstanceForPartnerResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SyncAppInstanceForPartnerResponse syncAppInstanceForPartnerResponse = new SyncAppInstanceForPartnerResponse();

			syncAppInstanceForPartnerResponse.HttpResponse = _ctx.HttpResponse;
			syncAppInstanceForPartnerResponse.RequestId = _ctx.StringValue("SyncAppInstanceForPartner.RequestId");

			SyncAppInstanceForPartnerResponse.SyncAppInstanceForPartner_Data data = new SyncAppInstanceForPartnerResponse.SyncAppInstanceForPartner_Data();

			SyncAppInstanceForPartnerResponse.SyncAppInstanceForPartner_Data.SyncAppInstanceForPartner_AppInstance appInstance = new SyncAppInstanceForPartnerResponse.SyncAppInstanceForPartner_Data.SyncAppInstanceForPartner_AppInstance();
			appInstance.BizId = _ctx.StringValue("SyncAppInstanceForPartner.Data.AppInstance.BizId");
			data.AppInstance = appInstance;
			syncAppInstanceForPartnerResponse.Data = data;
        
			return syncAppInstanceForPartnerResponse;
        }
    }
}
