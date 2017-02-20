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
    public class DescribeAccessPointsResponseUnmarshaller
    {
        public static DescribeAccessPointsResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeAccessPointsResponse describeAccessPointsResponse = new DescribeAccessPointsResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeAccessPoints.RequestId"),
                PageNumber = context.IntegerValue("DescribeAccessPoints.PageNumber"),
                PageSize = context.IntegerValue("DescribeAccessPoints.PageSize"),
                TotalCount = context.IntegerValue("DescribeAccessPoints.TotalCount")
            };
            List<DescribeAccessPointsResponse.AccessPointType> accessPointSet = new List<DescribeAccessPointsResponse.AccessPointType>();
			for (int i = 0; i < context.Length("DescribeAccessPoints.AccessPointSet.Length"); i++) {
                DescribeAccessPointsResponse.AccessPointType accessPointType = new DescribeAccessPointsResponse.AccessPointType()
                {
                    AccessPointId = context.StringValue($"DescribeAccessPoints.AccessPointSet[{i}].AccessPointId"),
                    Status = context.StringValue($"DescribeAccessPoints.AccessPointSet[{i}].Status"),
                    Type = context.StringValue($"DescribeAccessPoints.AccessPointSet[{i}].Type"),
                    AttachedRegionNo = context.StringValue($"DescribeAccessPoints.AccessPointSet[{i}].AttachedRegionNo"),
                    Location = context.StringValue($"DescribeAccessPoints.AccessPointSet[{i}].Location"),
                    HostOperator = context.StringValue($"DescribeAccessPoints.AccessPointSet[{i}].HostOperator"),
                    Name = context.StringValue($"DescribeAccessPoints.AccessPointSet[{i}].Name"),
                    Description = context.StringValue($"DescribeAccessPoints.AccessPointSet[{i}].Description")
                };
                accessPointSet.Add(accessPointType);
			}
			describeAccessPointsResponse.AccessPointSet = accessPointSet;
        
			return describeAccessPointsResponse;
        }
    }
}