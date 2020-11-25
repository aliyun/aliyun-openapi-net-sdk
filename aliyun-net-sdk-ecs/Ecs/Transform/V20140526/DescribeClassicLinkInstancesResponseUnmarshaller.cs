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
    public class DescribeClassicLinkInstancesResponseUnmarshaller
    {
        public static DescribeClassicLinkInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeClassicLinkInstancesResponse describeClassicLinkInstancesResponse = new DescribeClassicLinkInstancesResponse();

			describeClassicLinkInstancesResponse.HttpResponse = _ctx.HttpResponse;
			describeClassicLinkInstancesResponse.RequestId = _ctx.StringValue("DescribeClassicLinkInstances.RequestId");
			describeClassicLinkInstancesResponse.TotalCount = _ctx.IntegerValue("DescribeClassicLinkInstances.TotalCount");
			describeClassicLinkInstancesResponse.PageNumber = _ctx.IntegerValue("DescribeClassicLinkInstances.PageNumber");
			describeClassicLinkInstancesResponse.PageSize = _ctx.IntegerValue("DescribeClassicLinkInstances.PageSize");

			List<DescribeClassicLinkInstancesResponse.DescribeClassicLinkInstances_Link> describeClassicLinkInstancesResponse_links = new List<DescribeClassicLinkInstancesResponse.DescribeClassicLinkInstances_Link>();
			for (int i = 0; i < _ctx.Length("DescribeClassicLinkInstances.Links.Length"); i++) {
				DescribeClassicLinkInstancesResponse.DescribeClassicLinkInstances_Link link = new DescribeClassicLinkInstancesResponse.DescribeClassicLinkInstances_Link();
				link.InstanceId = _ctx.StringValue("DescribeClassicLinkInstances.Links["+ i +"].InstanceId");
				link.VpcId = _ctx.StringValue("DescribeClassicLinkInstances.Links["+ i +"].VpcId");

				describeClassicLinkInstancesResponse_links.Add(link);
			}
			describeClassicLinkInstancesResponse.Links = describeClassicLinkInstancesResponse_links;
        
			return describeClassicLinkInstancesResponse;
        }
    }
}
