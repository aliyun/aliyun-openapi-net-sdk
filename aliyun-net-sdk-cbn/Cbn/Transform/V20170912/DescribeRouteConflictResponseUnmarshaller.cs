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
    public class DescribeRouteConflictResponseUnmarshaller
    {
        public static DescribeRouteConflictResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRouteConflictResponse describeRouteConflictResponse = new DescribeRouteConflictResponse();

			describeRouteConflictResponse.HttpResponse = context.HttpResponse;
			describeRouteConflictResponse.RequestId = context.StringValue("DescribeRouteConflict.RequestId");
			describeRouteConflictResponse.PageNumber = context.IntegerValue("DescribeRouteConflict.PageNumber");
			describeRouteConflictResponse.TotalCount = context.IntegerValue("DescribeRouteConflict.TotalCount");
			describeRouteConflictResponse.PageSize = context.IntegerValue("DescribeRouteConflict.PageSize");

			List<DescribeRouteConflictResponse.DescribeRouteConflict_RouteConflict> describeRouteConflictResponse_routeConflicts = new List<DescribeRouteConflictResponse.DescribeRouteConflict_RouteConflict>();
			for (int i = 0; i < context.Length("DescribeRouteConflict.RouteConflicts.Length"); i++) {
				DescribeRouteConflictResponse.DescribeRouteConflict_RouteConflict routeConflict = new DescribeRouteConflictResponse.DescribeRouteConflict_RouteConflict();
				routeConflict.DestinationCidrBlock = context.StringValue("DescribeRouteConflict.RouteConflicts["+ i +"].DestinationCidrBlock");
				routeConflict.RegionId = context.StringValue("DescribeRouteConflict.RouteConflicts["+ i +"].RegionId");
				routeConflict.InstanceId = context.StringValue("DescribeRouteConflict.RouteConflicts["+ i +"].InstanceId");
				routeConflict.InstanceType = context.StringValue("DescribeRouteConflict.RouteConflicts["+ i +"].InstanceType");
				routeConflict.Status = context.StringValue("DescribeRouteConflict.RouteConflicts["+ i +"].Status");

				describeRouteConflictResponse_routeConflicts.Add(routeConflict);
			}
			describeRouteConflictResponse.RouteConflicts = describeRouteConflictResponse_routeConflicts;
        
			return describeRouteConflictResponse;
        }
    }
}
