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
    public class CreateGreyTagRouteResponseUnmarshaller
    {
        public static CreateGreyTagRouteResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateGreyTagRouteResponse createGreyTagRouteResponse = new CreateGreyTagRouteResponse();

			createGreyTagRouteResponse.HttpResponse = _ctx.HttpResponse;
			createGreyTagRouteResponse.RequestId = _ctx.StringValue("CreateGreyTagRoute.RequestId");
			createGreyTagRouteResponse.Message = _ctx.StringValue("CreateGreyTagRoute.Message");
			createGreyTagRouteResponse.TraceId = _ctx.StringValue("CreateGreyTagRoute.TraceId");
			createGreyTagRouteResponse.ErrorCode = _ctx.StringValue("CreateGreyTagRoute.ErrorCode");
			createGreyTagRouteResponse.Code = _ctx.StringValue("CreateGreyTagRoute.Code");
			createGreyTagRouteResponse.Success = _ctx.BooleanValue("CreateGreyTagRoute.Success");

			CreateGreyTagRouteResponse.CreateGreyTagRoute_Data data = new CreateGreyTagRouteResponse.CreateGreyTagRoute_Data();
			data.GreyTagRouteId = _ctx.LongValue("CreateGreyTagRoute.Data.GreyTagRouteId");
			createGreyTagRouteResponse.Data = data;
        
			return createGreyTagRouteResponse;
        }
    }
}
