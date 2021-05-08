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
    public class QueryEdgeInstanceMessageRoutingResponseUnmarshaller
    {
        public static QueryEdgeInstanceMessageRoutingResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryEdgeInstanceMessageRoutingResponse queryEdgeInstanceMessageRoutingResponse = new QueryEdgeInstanceMessageRoutingResponse();

			queryEdgeInstanceMessageRoutingResponse.HttpResponse = _ctx.HttpResponse;
			queryEdgeInstanceMessageRoutingResponse.RequestId = _ctx.StringValue("QueryEdgeInstanceMessageRouting.RequestId");
			queryEdgeInstanceMessageRoutingResponse.Success = _ctx.BooleanValue("QueryEdgeInstanceMessageRouting.Success");
			queryEdgeInstanceMessageRoutingResponse.Code = _ctx.StringValue("QueryEdgeInstanceMessageRouting.Code");
			queryEdgeInstanceMessageRoutingResponse.ErrorMessage = _ctx.StringValue("QueryEdgeInstanceMessageRouting.ErrorMessage");

			QueryEdgeInstanceMessageRoutingResponse.QueryEdgeInstanceMessageRouting_Data data = new QueryEdgeInstanceMessageRoutingResponse.QueryEdgeInstanceMessageRouting_Data();
			data.Total = _ctx.IntegerValue("QueryEdgeInstanceMessageRouting.Data.Total");
			data.PageSize = _ctx.IntegerValue("QueryEdgeInstanceMessageRouting.Data.PageSize");
			data.CurrentPage = _ctx.IntegerValue("QueryEdgeInstanceMessageRouting.Data.CurrentPage");

			List<QueryEdgeInstanceMessageRoutingResponse.QueryEdgeInstanceMessageRouting_Data.QueryEdgeInstanceMessageRouting_MessageRoute> data_messageRouteList = new List<QueryEdgeInstanceMessageRoutingResponse.QueryEdgeInstanceMessageRouting_Data.QueryEdgeInstanceMessageRouting_MessageRoute>();
			for (int i = 0; i < _ctx.Length("QueryEdgeInstanceMessageRouting.Data.MessageRouteList.Length"); i++) {
				QueryEdgeInstanceMessageRoutingResponse.QueryEdgeInstanceMessageRouting_Data.QueryEdgeInstanceMessageRouting_MessageRoute messageRoute = new QueryEdgeInstanceMessageRoutingResponse.QueryEdgeInstanceMessageRouting_Data.QueryEdgeInstanceMessageRouting_MessageRoute();
				messageRoute.RouteId = _ctx.IntegerValue("QueryEdgeInstanceMessageRouting.Data.MessageRouteList["+ i +"].RouteId");
				messageRoute.Name = _ctx.StringValue("QueryEdgeInstanceMessageRouting.Data.MessageRouteList["+ i +"].Name");
				messageRoute.TopicFilter = _ctx.StringValue("QueryEdgeInstanceMessageRouting.Data.MessageRouteList["+ i +"].TopicFilter");
				messageRoute.SourceType = _ctx.StringValue("QueryEdgeInstanceMessageRouting.Data.MessageRouteList["+ i +"].SourceType");
				messageRoute.SourceData = _ctx.StringValue("QueryEdgeInstanceMessageRouting.Data.MessageRouteList["+ i +"].SourceData");
				messageRoute.TargetType = _ctx.StringValue("QueryEdgeInstanceMessageRouting.Data.MessageRouteList["+ i +"].TargetType");
				messageRoute.TargetData = _ctx.StringValue("QueryEdgeInstanceMessageRouting.Data.MessageRouteList["+ i +"].TargetData");
				messageRoute.GmtCreate = _ctx.StringValue("QueryEdgeInstanceMessageRouting.Data.MessageRouteList["+ i +"].GmtCreate");
				messageRoute.GmtModified = _ctx.StringValue("QueryEdgeInstanceMessageRouting.Data.MessageRouteList["+ i +"].GmtModified");
				messageRoute.GmtCreateTimestamp = _ctx.LongValue("QueryEdgeInstanceMessageRouting.Data.MessageRouteList["+ i +"].GmtCreateTimestamp");
				messageRoute.GmtModifiedTimestamp = _ctx.LongValue("QueryEdgeInstanceMessageRouting.Data.MessageRouteList["+ i +"].GmtModifiedTimestamp");

				QueryEdgeInstanceMessageRoutingResponse.QueryEdgeInstanceMessageRouting_Data.QueryEdgeInstanceMessageRouting_MessageRoute.QueryEdgeInstanceMessageRouting_RouteContext routeContext = new QueryEdgeInstanceMessageRoutingResponse.QueryEdgeInstanceMessageRouting_Data.QueryEdgeInstanceMessageRouting_MessageRoute.QueryEdgeInstanceMessageRouting_RouteContext();
				routeContext.SourceFcServiceName = _ctx.StringValue("QueryEdgeInstanceMessageRouting.Data.MessageRouteList["+ i +"].RouteContext.SourceFcServiceName");
				routeContext.SourceFcFunctionName = _ctx.StringValue("QueryEdgeInstanceMessageRouting.Data.MessageRouteList["+ i +"].RouteContext.SourceFcFunctionName");
				routeContext.SourceStreamName = _ctx.StringValue("QueryEdgeInstanceMessageRouting.Data.MessageRouteList["+ i +"].RouteContext.SourceStreamName");
				routeContext.SourceApplicationName = _ctx.StringValue("QueryEdgeInstanceMessageRouting.Data.MessageRouteList["+ i +"].RouteContext.SourceApplicationName");
				routeContext.TargetFcServiceName = _ctx.StringValue("QueryEdgeInstanceMessageRouting.Data.MessageRouteList["+ i +"].RouteContext.TargetFcServiceName");
				routeContext.TargetFcFunctionName = _ctx.StringValue("QueryEdgeInstanceMessageRouting.Data.MessageRouteList["+ i +"].RouteContext.TargetFcFunctionName");
				routeContext.TargetStreamName = _ctx.StringValue("QueryEdgeInstanceMessageRouting.Data.MessageRouteList["+ i +"].RouteContext.TargetStreamName");
				routeContext.TargetApplicationName = _ctx.StringValue("QueryEdgeInstanceMessageRouting.Data.MessageRouteList["+ i +"].RouteContext.TargetApplicationName");
				routeContext.Qos = _ctx.StringValue("QueryEdgeInstanceMessageRouting.Data.MessageRouteList["+ i +"].RouteContext.Qos");
				messageRoute.RouteContext = routeContext;

				data_messageRouteList.Add(messageRoute);
			}
			data.MessageRouteList = data_messageRouteList;
			queryEdgeInstanceMessageRoutingResponse.Data = data;
        
			return queryEdgeInstanceMessageRoutingResponse;
        }
    }
}
