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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Ecs.Model.V20140526;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeVRoutersResponseUnmarshaller
    {
        public static DescribeVRoutersResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeVRoutersResponse describeVRoutersResponse = new DescribeVRoutersResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeVRouters.RequestId"),
                TotalCount = context.IntegerValue("DescribeVRouters.TotalCount"),
                PageNumber = context.IntegerValue("DescribeVRouters.PageNumber"),
                PageSize = context.IntegerValue("DescribeVRouters.PageSize")
            };
            List<DescribeVRoutersResponse.VRouter> vRouters = new List<DescribeVRoutersResponse.VRouter>();
			for (int i = 0; i < context.Length("DescribeVRouters.VRouters.Length"); i++) {
                DescribeVRoutersResponse.VRouter vRouter = new DescribeVRoutersResponse.VRouter()
                {
                    RegionId = context.StringValue($"DescribeVRouters.VRouters[{i}].RegionId"),
                    VpcId = context.StringValue($"DescribeVRouters.VRouters[{i}].VpcId"),
                    VRouterName = context.StringValue($"DescribeVRouters.VRouters[{i}].VRouterName"),
                    Description = context.StringValue($"DescribeVRouters.VRouters[{i}].Description"),
                    VRouterId = context.StringValue($"DescribeVRouters.VRouters[{i}].VRouterId"),
                    CreationTime = context.StringValue($"DescribeVRouters.VRouters[{i}].CreationTime")
                };
                List<string> routeTableIds = new List<string>();
				for (int j = 0; j < context.Length($"DescribeVRouters.VRouters[{i}].RouteTableIds.Length"); j++) {
					routeTableIds.Add(context.StringValue($"DescribeVRouters.VRouters[{i}].RouteTableIds[{j}]"));
				}
				vRouter.RouteTableIds = routeTableIds;

				vRouters.Add(vRouter);
			}
			describeVRoutersResponse.VRouters = vRouters;
        
			return describeVRoutersResponse;
        }
    }
}