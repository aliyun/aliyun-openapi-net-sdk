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
    public class DescribeAccessPointsResponseUnmarshaller
    {
        public static DescribeAccessPointsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAccessPointsResponse describeAccessPointsResponse = new DescribeAccessPointsResponse();

			describeAccessPointsResponse.HttpResponse = _ctx.HttpResponse;
			describeAccessPointsResponse.RequestId = _ctx.StringValue("DescribeAccessPoints.RequestId");
			describeAccessPointsResponse.PageNumber = _ctx.IntegerValue("DescribeAccessPoints.PageNumber");
			describeAccessPointsResponse.PageSize = _ctx.IntegerValue("DescribeAccessPoints.PageSize");
			describeAccessPointsResponse.TotalCount = _ctx.IntegerValue("DescribeAccessPoints.TotalCount");

			List<DescribeAccessPointsResponse.DescribeAccessPoints_AccessPointType> describeAccessPointsResponse_accessPointSet = new List<DescribeAccessPointsResponse.DescribeAccessPoints_AccessPointType>();
			for (int i = 0; i < _ctx.Length("DescribeAccessPoints.AccessPointSet.Length"); i++) {
				DescribeAccessPointsResponse.DescribeAccessPoints_AccessPointType accessPointType = new DescribeAccessPointsResponse.DescribeAccessPoints_AccessPointType();
				accessPointType.Status = _ctx.StringValue("DescribeAccessPoints.AccessPointSet["+ i +"].Status");
				accessPointType.Type = _ctx.StringValue("DescribeAccessPoints.AccessPointSet["+ i +"].Type");
				accessPointType.HostOperator = _ctx.StringValue("DescribeAccessPoints.AccessPointSet["+ i +"].HostOperator");
				accessPointType.Description = _ctx.StringValue("DescribeAccessPoints.AccessPointSet["+ i +"].Description");
				accessPointType.AttachedRegionNo = _ctx.StringValue("DescribeAccessPoints.AccessPointSet["+ i +"].AttachedRegionNo");
				accessPointType.Name = _ctx.StringValue("DescribeAccessPoints.AccessPointSet["+ i +"].Name");
				accessPointType.AccessPointId = _ctx.StringValue("DescribeAccessPoints.AccessPointSet["+ i +"].AccessPointId");
				accessPointType.Location = _ctx.StringValue("DescribeAccessPoints.AccessPointSet["+ i +"].Location");

				describeAccessPointsResponse_accessPointSet.Add(accessPointType);
			}
			describeAccessPointsResponse.AccessPointSet = describeAccessPointsResponse_accessPointSet;
        
			return describeAccessPointsResponse;
        }
    }
}
