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
using Aliyun.Acs.Dts.Model.V20200101;

namespace Aliyun.Acs.Dts.Transform.V20200101
{
    public class RenewInstanceResponseUnmarshaller
    {
        public static RenewInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RenewInstanceResponse renewInstanceResponse = new RenewInstanceResponse();

			renewInstanceResponse.HttpResponse = _ctx.HttpResponse;
			renewInstanceResponse.ChargeType = _ctx.StringValue("RenewInstance.ChargeType");
			renewInstanceResponse.Code = _ctx.StringValue("RenewInstance.Code");
			renewInstanceResponse.DtsJobId = _ctx.StringValue("RenewInstance.DtsJobId");
			renewInstanceResponse.DynamicMessage = _ctx.StringValue("RenewInstance.DynamicMessage");
			renewInstanceResponse.EndTime = _ctx.StringValue("RenewInstance.EndTime");
			renewInstanceResponse.ErrCode = _ctx.StringValue("RenewInstance.ErrCode");
			renewInstanceResponse.ErrMessage = _ctx.StringValue("RenewInstance.ErrMessage");
			renewInstanceResponse.HttpStatusCode = _ctx.IntegerValue("RenewInstance.HttpStatusCode");
			renewInstanceResponse.InstanceId = _ctx.StringValue("RenewInstance.InstanceId");
			renewInstanceResponse.RequestId = _ctx.StringValue("RenewInstance.RequestId");
			renewInstanceResponse.Success = _ctx.BooleanValue("RenewInstance.Success");
        
			return renewInstanceResponse;
        }
    }
}
