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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class SetDevicePropertyResponseUnmarshaller
    {
        public static SetDevicePropertyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SetDevicePropertyResponse setDevicePropertyResponse = new SetDevicePropertyResponse();

			setDevicePropertyResponse.HttpResponse = _ctx.HttpResponse;
			setDevicePropertyResponse.RequestId = _ctx.StringValue("SetDeviceProperty.RequestId");
			setDevicePropertyResponse.Success = _ctx.BooleanValue("SetDeviceProperty.Success");
			setDevicePropertyResponse.ErrorMessage = _ctx.StringValue("SetDeviceProperty.ErrorMessage");
			setDevicePropertyResponse.Code = _ctx.StringValue("SetDeviceProperty.Code");

			SetDevicePropertyResponse.SetDeviceProperty_Data data = new SetDevicePropertyResponse.SetDeviceProperty_Data();
			data.MessageId = _ctx.StringValue("SetDeviceProperty.Data.MessageId");
			setDevicePropertyResponse.Data = data;
        
			return setDevicePropertyResponse;
        }
    }
}
