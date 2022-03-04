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
using Aliyun.Acs.quickbi_public.Model.V20220101;

namespace Aliyun.Acs.quickbi_public.Transform.V20220101
{
    public class SetDataLevelPermissionWhiteListResponseUnmarshaller
    {
        public static SetDataLevelPermissionWhiteListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SetDataLevelPermissionWhiteListResponse setDataLevelPermissionWhiteListResponse = new SetDataLevelPermissionWhiteListResponse();

			setDataLevelPermissionWhiteListResponse.HttpResponse = _ctx.HttpResponse;
			setDataLevelPermissionWhiteListResponse.RequestId = _ctx.StringValue("SetDataLevelPermissionWhiteList.RequestId");
			setDataLevelPermissionWhiteListResponse.Result = _ctx.BooleanValue("SetDataLevelPermissionWhiteList.Result");
			setDataLevelPermissionWhiteListResponse.Success = _ctx.BooleanValue("SetDataLevelPermissionWhiteList.Success");
        
			return setDataLevelPermissionWhiteListResponse;
        }
    }
}
