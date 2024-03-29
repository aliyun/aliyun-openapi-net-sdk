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
        public static DescribeVRoutersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVRoutersResponse describeVRoutersResponse = new DescribeVRoutersResponse();

			describeVRoutersResponse.HttpResponse = _ctx.HttpResponse;
			describeVRoutersResponse.PageSize = _ctx.IntegerValue("DescribeVRouters.PageSize");
			describeVRoutersResponse.RequestId = _ctx.StringValue("DescribeVRouters.RequestId");
			describeVRoutersResponse.PageNumber = _ctx.IntegerValue("DescribeVRouters.PageNumber");
			describeVRoutersResponse.TotalCount = _ctx.IntegerValue("DescribeVRouters.TotalCount");

			List<DescribeVRoutersResponse.DescribeVRouters_VRouter> describeVRoutersResponse_vRouters = new List<DescribeVRoutersResponse.DescribeVRouters_VRouter>();
			for (int i = 0; i < _ctx.Length("DescribeVRouters.VRouters.Length"); i++) {
				DescribeVRoutersResponse.DescribeVRouters_VRouter vRouter = new DescribeVRoutersResponse.DescribeVRouters_VRouter();
				vRouter.VpcId = _ctx.StringValue("DescribeVRouters.VRouters["+ i +"].VpcId");
				vRouter.CreationTime = _ctx.StringValue("DescribeVRouters.VRouters["+ i +"].CreationTime");
				vRouter.VRouterId = _ctx.StringValue("DescribeVRouters.VRouters["+ i +"].VRouterId");
				vRouter.Description = _ctx.StringValue("DescribeVRouters.VRouters["+ i +"].Description");
				vRouter.VRouterName = _ctx.StringValue("DescribeVRouters.VRouters["+ i +"].VRouterName");
				vRouter.RegionId = _ctx.StringValue("DescribeVRouters.VRouters["+ i +"].RegionId");

				List<string> vRouter_routeTableIds = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeVRouters.VRouters["+ i +"].RouteTableIds.Length"); j++) {
					vRouter_routeTableIds.Add(_ctx.StringValue("DescribeVRouters.VRouters["+ i +"].RouteTableIds["+ j +"]"));
				}
				vRouter.RouteTableIds = vRouter_routeTableIds;

				describeVRoutersResponse_vRouters.Add(vRouter);
			}
			describeVRoutersResponse.VRouters = describeVRoutersResponse_vRouters;
        
			return describeVRoutersResponse;
        }
    }
}
