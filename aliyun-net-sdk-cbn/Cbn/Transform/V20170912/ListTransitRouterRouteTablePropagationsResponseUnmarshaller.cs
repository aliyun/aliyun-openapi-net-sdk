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
using Aliyun.Acs.Cbn.Model.V20170912;

namespace Aliyun.Acs.Cbn.Transform.V20170912
{
    public class ListTransitRouterRouteTablePropagationsResponseUnmarshaller
    {
        public static ListTransitRouterRouteTablePropagationsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListTransitRouterRouteTablePropagationsResponse listTransitRouterRouteTablePropagationsResponse = new ListTransitRouterRouteTablePropagationsResponse();

			listTransitRouterRouteTablePropagationsResponse.HttpResponse = _ctx.HttpResponse;
			listTransitRouterRouteTablePropagationsResponse.RequestId = _ctx.StringValue("ListTransitRouterRouteTablePropagations.RequestId");
			listTransitRouterRouteTablePropagationsResponse.TotalCount = _ctx.IntegerValue("ListTransitRouterRouteTablePropagations.TotalCount");
			listTransitRouterRouteTablePropagationsResponse.MaxResults = _ctx.IntegerValue("ListTransitRouterRouteTablePropagations.MaxResults");
			listTransitRouterRouteTablePropagationsResponse.NextToken = _ctx.StringValue("ListTransitRouterRouteTablePropagations.NextToken");

			List<ListTransitRouterRouteTablePropagationsResponse.ListTransitRouterRouteTablePropagations_TransitRouterPropagation> listTransitRouterRouteTablePropagationsResponse_transitRouterPropagations = new List<ListTransitRouterRouteTablePropagationsResponse.ListTransitRouterRouteTablePropagations_TransitRouterPropagation>();
			for (int i = 0; i < _ctx.Length("ListTransitRouterRouteTablePropagations.TransitRouterPropagations.Length"); i++) {
				ListTransitRouterRouteTablePropagationsResponse.ListTransitRouterRouteTablePropagations_TransitRouterPropagation transitRouterPropagation = new ListTransitRouterRouteTablePropagationsResponse.ListTransitRouterRouteTablePropagations_TransitRouterPropagation();
				transitRouterPropagation.Status = _ctx.StringValue("ListTransitRouterRouteTablePropagations.TransitRouterPropagations["+ i +"].Status");
				transitRouterPropagation.TransitRouterAttachmentId = _ctx.StringValue("ListTransitRouterRouteTablePropagations.TransitRouterPropagations["+ i +"].TransitRouterAttachmentId");
				transitRouterPropagation.TransitRouterRouteTableId = _ctx.StringValue("ListTransitRouterRouteTablePropagations.TransitRouterPropagations["+ i +"].TransitRouterRouteTableId");
				transitRouterPropagation.ResourceId = _ctx.StringValue("ListTransitRouterRouteTablePropagations.TransitRouterPropagations["+ i +"].ResourceId");
				transitRouterPropagation.ResourceType = _ctx.StringValue("ListTransitRouterRouteTablePropagations.TransitRouterPropagations["+ i +"].ResourceType");

				listTransitRouterRouteTablePropagationsResponse_transitRouterPropagations.Add(transitRouterPropagation);
			}
			listTransitRouterRouteTablePropagationsResponse.TransitRouterPropagations = listTransitRouterRouteTablePropagationsResponse_transitRouterPropagations;
        
			return listTransitRouterRouteTablePropagationsResponse;
        }
    }
}
