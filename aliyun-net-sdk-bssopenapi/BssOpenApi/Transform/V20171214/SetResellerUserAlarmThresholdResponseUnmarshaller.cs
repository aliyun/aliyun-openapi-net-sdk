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
using Aliyun.Acs.BssOpenApi.Model.V20171214;

namespace Aliyun.Acs.BssOpenApi.Transform.V20171214
{
    public class SetResellerUserAlarmThresholdResponseUnmarshaller
    {
        public static SetResellerUserAlarmThresholdResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SetResellerUserAlarmThresholdResponse setResellerUserAlarmThresholdResponse = new SetResellerUserAlarmThresholdResponse();

			setResellerUserAlarmThresholdResponse.HttpResponse = _ctx.HttpResponse;
			setResellerUserAlarmThresholdResponse.RequestId = _ctx.StringValue("SetResellerUserAlarmThreshold.RequestId");
			setResellerUserAlarmThresholdResponse.Code = _ctx.StringValue("SetResellerUserAlarmThreshold.Code");
			setResellerUserAlarmThresholdResponse.Message = _ctx.StringValue("SetResellerUserAlarmThreshold.Message");
			setResellerUserAlarmThresholdResponse.Success = _ctx.BooleanValue("SetResellerUserAlarmThreshold.Success");
			setResellerUserAlarmThresholdResponse.Data = _ctx.BooleanValue("SetResellerUserAlarmThreshold.Data");
        
			return setResellerUserAlarmThresholdResponse;
        }
    }
}
