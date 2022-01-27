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
using Aliyun.Acs.sae.Model.V20190506;

namespace Aliyun.Acs.sae.Transform.V20190506
{
    public class RestartInstancesResponseUnmarshaller
    {
        public static RestartInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RestartInstancesResponse restartInstancesResponse = new RestartInstancesResponse();

			restartInstancesResponse.HttpResponse = _ctx.HttpResponse;
			restartInstancesResponse.RequestId = _ctx.StringValue("RestartInstances.RequestId");
			restartInstancesResponse.Code = _ctx.StringValue("RestartInstances.Code");
			restartInstancesResponse.Success = _ctx.BooleanValue("RestartInstances.Success");
			restartInstancesResponse.ErrorCode = _ctx.StringValue("RestartInstances.ErrorCode");
			restartInstancesResponse.Message = _ctx.StringValue("RestartInstances.Message");
			restartInstancesResponse.TraceId = _ctx.StringValue("RestartInstances.TraceId");

			RestartInstancesResponse.RestartInstances_Data data = new RestartInstancesResponse.RestartInstances_Data();
			data.ChangeOrderId = _ctx.StringValue("RestartInstances.Data.ChangeOrderId");
			restartInstancesResponse.Data = data;
        
			return restartInstancesResponse;
        }
    }
}
