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
using Aliyun.Acs.CCC.Model.V20170705;

namespace Aliyun.Acs.CCC.Transform.V20170705
{
    public class GetRoutePointResponseUnmarshaller
    {
        public static GetRoutePointResponse Unmarshall(UnmarshallerContext context)
        {
			GetRoutePointResponse getRoutePointResponse = new GetRoutePointResponse();

			getRoutePointResponse.HttpResponse = context.HttpResponse;
			getRoutePointResponse.RequestId = context.StringValue("GetRoutePoint.RequestId");
			getRoutePointResponse.Success = context.BooleanValue("GetRoutePoint.Success");
			getRoutePointResponse.Code = context.StringValue("GetRoutePoint.Code");
			getRoutePointResponse.Message = context.StringValue("GetRoutePoint.Message");
			getRoutePointResponse.HttpStatusCode = context.IntegerValue("GetRoutePoint.HttpStatusCode");
			getRoutePointResponse.StatusCode = context.StringValue("GetRoutePoint.StatusCode");
			getRoutePointResponse.StatusDesc = context.StringValue("GetRoutePoint.StatusDesc");
			getRoutePointResponse.RoutePoint = context.StringValue("GetRoutePoint.RoutePoint");
        
			return getRoutePointResponse;
        }
    }
}
