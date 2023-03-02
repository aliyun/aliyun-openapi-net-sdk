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
using Aliyun.Acs.lto.Model.V20210707;

namespace Aliyun.Acs.lto.Transform.V20210707
{
    public class DisableDeviceGroupResponseUnmarshaller
    {
        public static DisableDeviceGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DisableDeviceGroupResponse disableDeviceGroupResponse = new DisableDeviceGroupResponse();

			disableDeviceGroupResponse.HttpResponse = _ctx.HttpResponse;
			disableDeviceGroupResponse.Code = _ctx.StringValue("DisableDeviceGroup.Code");
			disableDeviceGroupResponse.HttpStatusCode = _ctx.IntegerValue("DisableDeviceGroup.HttpStatusCode");
			disableDeviceGroupResponse.Message = _ctx.StringValue("DisableDeviceGroup.Message");
			disableDeviceGroupResponse.RequestId = _ctx.StringValue("DisableDeviceGroup.RequestId");
			disableDeviceGroupResponse.Success = _ctx.BooleanValue("DisableDeviceGroup.Success");
        
			return disableDeviceGroupResponse;
        }
    }
}
