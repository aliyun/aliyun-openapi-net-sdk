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
    public class AddDeviceGroupResponseUnmarshaller
    {
        public static AddDeviceGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			AddDeviceGroupResponse addDeviceGroupResponse = new AddDeviceGroupResponse();

			addDeviceGroupResponse.HttpResponse = _ctx.HttpResponse;
			addDeviceGroupResponse.Code = _ctx.StringValue("AddDeviceGroup.Code");
			addDeviceGroupResponse.HttpStatusCode = _ctx.IntegerValue("AddDeviceGroup.HttpStatusCode");
			addDeviceGroupResponse.Message = _ctx.StringValue("AddDeviceGroup.Message");
			addDeviceGroupResponse.RequestId = _ctx.StringValue("AddDeviceGroup.RequestId");
			addDeviceGroupResponse.Success = _ctx.BooleanValue("AddDeviceGroup.Success");
        
			return addDeviceGroupResponse;
        }
    }
}
