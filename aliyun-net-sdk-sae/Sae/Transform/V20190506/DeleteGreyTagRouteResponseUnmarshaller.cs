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
    public class DeleteGreyTagRouteResponseUnmarshaller
    {
        public static DeleteGreyTagRouteResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DeleteGreyTagRouteResponse deleteGreyTagRouteResponse = new DeleteGreyTagRouteResponse();

			deleteGreyTagRouteResponse.HttpResponse = _ctx.HttpResponse;
			deleteGreyTagRouteResponse.Message = _ctx.StringValue("DeleteGreyTagRoute.Message");
			deleteGreyTagRouteResponse.RequestId = _ctx.StringValue("DeleteGreyTagRoute.RequestId");
			deleteGreyTagRouteResponse.TraceId = _ctx.StringValue("DeleteGreyTagRoute.TraceId");
			deleteGreyTagRouteResponse.ErrorCode = _ctx.StringValue("DeleteGreyTagRoute.ErrorCode");
			deleteGreyTagRouteResponse.Code = _ctx.StringValue("DeleteGreyTagRoute.Code");
			deleteGreyTagRouteResponse.Success = _ctx.BooleanValue("DeleteGreyTagRoute.Success");

			DeleteGreyTagRouteResponse.DeleteGreyTagRoute_Data data = new DeleteGreyTagRouteResponse.DeleteGreyTagRoute_Data();
			data.GreyTagRouteId = _ctx.LongValue("DeleteGreyTagRoute.Data.GreyTagRouteId");
			deleteGreyTagRouteResponse.Data = data;
        
			return deleteGreyTagRouteResponse;
        }
    }
}
