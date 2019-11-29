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
using Aliyun.Acs.cloudesl.Model.V20190801;

namespace Aliyun.Acs.cloudesl.Transform.V20190801
{
    public class ActivateApDeviceResponseUnmarshaller
    {
        public static ActivateApDeviceResponse Unmarshall(UnmarshallerContext context)
        {
			ActivateApDeviceResponse activateApDeviceResponse = new ActivateApDeviceResponse();

			activateApDeviceResponse.HttpResponse = context.HttpResponse;
			activateApDeviceResponse.ErrorMessage = context.StringValue("ActivateApDevice.ErrorMessage");
			activateApDeviceResponse.ErrorCode = context.StringValue("ActivateApDevice.ErrorCode");
			activateApDeviceResponse.Message = context.StringValue("ActivateApDevice.Message");
			activateApDeviceResponse.DynamicCode = context.StringValue("ActivateApDevice.DynamicCode");
			activateApDeviceResponse.Code = context.StringValue("ActivateApDevice.Code");
			activateApDeviceResponse.DynamicMessage = context.StringValue("ActivateApDevice.DynamicMessage");
			activateApDeviceResponse.RequestId = context.StringValue("ActivateApDevice.RequestId");
			activateApDeviceResponse.Success = context.BooleanValue("ActivateApDevice.Success");
        
			return activateApDeviceResponse;
        }
    }
}
