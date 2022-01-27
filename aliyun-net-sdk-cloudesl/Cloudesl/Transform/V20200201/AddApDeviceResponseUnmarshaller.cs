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
using Aliyun.Acs.cloudesl.Model.V20200201;

namespace Aliyun.Acs.cloudesl.Transform.V20200201
{
    public class AddApDeviceResponseUnmarshaller
    {
        public static AddApDeviceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			AddApDeviceResponse addApDeviceResponse = new AddApDeviceResponse();

			addApDeviceResponse.HttpResponse = _ctx.HttpResponse;
			addApDeviceResponse.ErrorMessage = _ctx.StringValue("AddApDevice.ErrorMessage");
			addApDeviceResponse.ErrorCode = _ctx.StringValue("AddApDevice.ErrorCode");
			addApDeviceResponse.Message = _ctx.StringValue("AddApDevice.Message");
			addApDeviceResponse.DynamicCode = _ctx.StringValue("AddApDevice.DynamicCode");
			addApDeviceResponse.Code = _ctx.StringValue("AddApDevice.Code");
			addApDeviceResponse.DynamicMessage = _ctx.StringValue("AddApDevice.DynamicMessage");
			addApDeviceResponse.RequestId = _ctx.StringValue("AddApDevice.RequestId");
			addApDeviceResponse.Success = _ctx.BooleanValue("AddApDevice.Success");
        
			return addApDeviceResponse;
        }
    }
}
