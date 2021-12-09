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
    public class UpdateGreyTagRouteResponseUnmarshaller
    {
        public static UpdateGreyTagRouteResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateGreyTagRouteResponse updateGreyTagRouteResponse = new UpdateGreyTagRouteResponse();

			updateGreyTagRouteResponse.HttpResponse = _ctx.HttpResponse;
			updateGreyTagRouteResponse.RequestId = _ctx.StringValue("UpdateGreyTagRoute.RequestId");
			updateGreyTagRouteResponse.Message = _ctx.StringValue("UpdateGreyTagRoute.Message");
			updateGreyTagRouteResponse.TraceId = _ctx.StringValue("UpdateGreyTagRoute.TraceId");
			updateGreyTagRouteResponse.ErrorCode = _ctx.StringValue("UpdateGreyTagRoute.ErrorCode");
			updateGreyTagRouteResponse.Code = _ctx.StringValue("UpdateGreyTagRoute.Code");
			updateGreyTagRouteResponse.Success = _ctx.BooleanValue("UpdateGreyTagRoute.Success");

			UpdateGreyTagRouteResponse.UpdateGreyTagRoute_Data data = new UpdateGreyTagRouteResponse.UpdateGreyTagRoute_Data();
			data.GreyTagRouteId = _ctx.LongValue("UpdateGreyTagRoute.Data.GreyTagRouteId");
			updateGreyTagRouteResponse.Data = data;
        
			return updateGreyTagRouteResponse;
        }
    }
}
