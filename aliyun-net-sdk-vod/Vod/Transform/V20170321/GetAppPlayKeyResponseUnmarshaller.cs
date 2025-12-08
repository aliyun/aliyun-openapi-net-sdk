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
using Aliyun.Acs.vod.Model.V20170321;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class GetAppPlayKeyResponseUnmarshaller
    {
        public static GetAppPlayKeyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetAppPlayKeyResponse getAppPlayKeyResponse = new GetAppPlayKeyResponse();

			getAppPlayKeyResponse.HttpResponse = _ctx.HttpResponse;
			getAppPlayKeyResponse.RequestId = _ctx.StringValue("GetAppPlayKey.RequestId");

			GetAppPlayKeyResponse.GetAppPlayKey_AppPlayKey appPlayKey = new GetAppPlayKeyResponse.GetAppPlayKey_AppPlayKey();
			appPlayKey.AppId = _ctx.StringValue("GetAppPlayKey.AppPlayKey.AppId");
			appPlayKey.PlayKey = _ctx.StringValue("GetAppPlayKey.AppPlayKey.PlayKey");
			appPlayKey.CreationTime = _ctx.StringValue("GetAppPlayKey.AppPlayKey.CreationTime");
			appPlayKey.ModificationTime = _ctx.StringValue("GetAppPlayKey.AppPlayKey.ModificationTime");
			getAppPlayKeyResponse.AppPlayKey = appPlayKey;
        
			return getAppPlayKeyResponse;
        }
    }
}
