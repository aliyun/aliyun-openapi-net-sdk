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
    public class GetEdgeInstanceMessageRoutingResponseUnmarshaller
    {
        public static GetEdgeInstanceMessageRoutingResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetEdgeInstanceMessageRoutingResponse getEdgeInstanceMessageRoutingResponse = new GetEdgeInstanceMessageRoutingResponse();

			getEdgeInstanceMessageRoutingResponse.HttpResponse = _ctx.HttpResponse;
			getEdgeInstanceMessageRoutingResponse.RequestId = _ctx.StringValue("GetEdgeInstanceMessageRouting.RequestId");
			getEdgeInstanceMessageRoutingResponse.Success = _ctx.BooleanValue("GetEdgeInstanceMessageRouting.Success");
			getEdgeInstanceMessageRoutingResponse.Code = _ctx.StringValue("GetEdgeInstanceMessageRouting.Code");
			getEdgeInstanceMessageRoutingResponse.ErrorMessage = _ctx.StringValue("GetEdgeInstanceMessageRouting.ErrorMessage");

			GetEdgeInstanceMessageRoutingResponse.GetEdgeInstanceMessageRouting_Data data = new GetEdgeInstanceMessageRoutingResponse.GetEdgeInstanceMessageRouting_Data();
			data.TopicFilter = _ctx.StringValue("GetEdgeInstanceMessageRouting.Data.TopicFilter");
			data.SourceType = _ctx.StringValue("GetEdgeInstanceMessageRouting.Data.SourceType");
			data.Name = _ctx.StringValue("GetEdgeInstanceMessageRouting.Data.Name");
			data.SourceData = _ctx.StringValue("GetEdgeInstanceMessageRouting.Data.SourceData");
			data.TargetType = _ctx.StringValue("GetEdgeInstanceMessageRouting.Data.TargetType");
			data.TargetData = _ctx.StringValue("GetEdgeInstanceMessageRouting.Data.TargetData");
			data.GmtCreate = _ctx.StringValue("GetEdgeInstanceMessageRouting.Data.GmtCreate");
			data.GmtModified = _ctx.StringValue("GetEdgeInstanceMessageRouting.Data.GmtModified");
			data.GmtCreateTimestamp = _ctx.LongValue("GetEdgeInstanceMessageRouting.Data.GmtCreateTimestamp");
			data.GmtModifiedTimestamp = _ctx.LongValue("GetEdgeInstanceMessageRouting.Data.GmtModifiedTimestamp");

			GetEdgeInstanceMessageRoutingResponse.GetEdgeInstanceMessageRouting_Data.GetEdgeInstanceMessageRouting_RouteContext routeContext = new GetEdgeInstanceMessageRoutingResponse.GetEdgeInstanceMessageRouting_Data.GetEdgeInstanceMessageRouting_RouteContext();
			routeContext.SourceFcServiceName = _ctx.StringValue("GetEdgeInstanceMessageRouting.Data.RouteContext.SourceFcServiceName");
			routeContext.SourceFcFunctionName = _ctx.StringValue("GetEdgeInstanceMessageRouting.Data.RouteContext.SourceFcFunctionName");
			routeContext.SourceStreamName = _ctx.StringValue("GetEdgeInstanceMessageRouting.Data.RouteContext.SourceStreamName");
			routeContext.SourceApplicationName = _ctx.StringValue("GetEdgeInstanceMessageRouting.Data.RouteContext.SourceApplicationName");
			routeContext.TargetFcServiceName = _ctx.StringValue("GetEdgeInstanceMessageRouting.Data.RouteContext.TargetFcServiceName");
			routeContext.TargetFcFunctionName = _ctx.StringValue("GetEdgeInstanceMessageRouting.Data.RouteContext.TargetFcFunctionName");
			routeContext.TargetStreamName = _ctx.StringValue("GetEdgeInstanceMessageRouting.Data.RouteContext.TargetStreamName");
			routeContext.TargetApplicationName = _ctx.StringValue("GetEdgeInstanceMessageRouting.Data.RouteContext.TargetApplicationName");
			routeContext.Qos = _ctx.StringValue("GetEdgeInstanceMessageRouting.Data.RouteContext.Qos");
			data.RouteContext = routeContext;
			getEdgeInstanceMessageRoutingResponse.Data = data;
        
			return getEdgeInstanceMessageRoutingResponse;
        }
    }
}
