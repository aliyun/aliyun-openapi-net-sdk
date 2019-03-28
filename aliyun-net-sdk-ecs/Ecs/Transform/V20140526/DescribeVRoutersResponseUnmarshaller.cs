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
using Aliyun.Acs.Ecs.Model.V20140526;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeVRoutersResponseUnmarshaller
    {
        public static DescribeVRoutersResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVRoutersResponse describeVRoutersResponse = new DescribeVRoutersResponse();

			describeVRoutersResponse.HttpResponse = context.HttpResponse;
			describeVRoutersResponse.RequestId = context.StringValue("DescribeVRouters.RequestId");
			describeVRoutersResponse.TotalCount = context.IntegerValue("DescribeVRouters.TotalCount");
			describeVRoutersResponse.PageNumber = context.IntegerValue("DescribeVRouters.PageNumber");
			describeVRoutersResponse.PageSize = context.IntegerValue("DescribeVRouters.PageSize");

			List<DescribeVRoutersResponse.DescribeVRouters_VRouter> describeVRoutersResponse_vRouters = new List<DescribeVRoutersResponse.DescribeVRouters_VRouter>();
			for (int i = 0; i < context.Length("DescribeVRouters.VRouters.Length"); i++) {
				DescribeVRoutersResponse.DescribeVRouters_VRouter vRouter = new DescribeVRoutersResponse.DescribeVRouters_VRouter();
				vRouter.RegionId = context.StringValue("DescribeVRouters.VRouters["+ i +"].RegionId");
				vRouter.VpcId = context.StringValue("DescribeVRouters.VRouters["+ i +"].VpcId");
				vRouter.VRouterName = context.StringValue("DescribeVRouters.VRouters["+ i +"].VRouterName");
				vRouter.Description = context.StringValue("DescribeVRouters.VRouters["+ i +"].Description");
				vRouter.VRouterId = context.StringValue("DescribeVRouters.VRouters["+ i +"].VRouterId");
				vRouter.CreationTime = context.StringValue("DescribeVRouters.VRouters["+ i +"].CreationTime");

				List<string> vRouter_routeTableIds = new List<string>();
				for (int j = 0; j < context.Length("DescribeVRouters.VRouters["+ i +"].RouteTableIds.Length"); j++) {
					vRouter_routeTableIds.Add(context.StringValue("DescribeVRouters.VRouters["+ i +"].RouteTableIds["+ j +"]"));
				}
				vRouter.RouteTableIds = vRouter_routeTableIds;

				describeVRoutersResponse_vRouters.Add(vRouter);
			}
			describeVRoutersResponse.VRouters = describeVRoutersResponse_vRouters;
        
			return describeVRoutersResponse;
        }
    }
}
