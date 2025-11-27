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
using Aliyun.Acs.NAS.Model.V20170626;

namespace Aliyun.Acs.NAS.Transform.V20170626
{
    public class DescribeAccessPointsResponseUnmarshaller
    {
        public static DescribeAccessPointsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAccessPointsResponse describeAccessPointsResponse = new DescribeAccessPointsResponse();

			describeAccessPointsResponse.HttpResponse = _ctx.HttpResponse;
			describeAccessPointsResponse.RequestId = _ctx.StringValue("DescribeAccessPoints.RequestId");
			describeAccessPointsResponse.NextToken = _ctx.StringValue("DescribeAccessPoints.NextToken");
			describeAccessPointsResponse.TotalCount = _ctx.IntegerValue("DescribeAccessPoints.TotalCount");

			List<DescribeAccessPointsResponse.DescribeAccessPoints_AccessPoint> describeAccessPointsResponse_accessPoints = new List<DescribeAccessPointsResponse.DescribeAccessPoints_AccessPoint>();
			for (int i = 0; i < _ctx.Length("DescribeAccessPoints.AccessPoints.Length"); i++) {
				DescribeAccessPointsResponse.DescribeAccessPoints_AccessPoint accessPoint = new DescribeAccessPointsResponse.DescribeAccessPoints_AccessPoint();
				accessPoint.ARN = _ctx.StringValue("DescribeAccessPoints.AccessPoints["+ i +"].ARN");
				accessPoint.AccessGroup = _ctx.StringValue("DescribeAccessPoints.AccessPoints["+ i +"].AccessGroup");
				accessPoint.AccessPointId = _ctx.StringValue("DescribeAccessPoints.AccessPoints["+ i +"].AccessPointId");
				accessPoint.AccessPointName = _ctx.StringValue("DescribeAccessPoints.AccessPoints["+ i +"].AccessPointName");
				accessPoint.CreateTime = _ctx.StringValue("DescribeAccessPoints.AccessPoints["+ i +"].CreateTime");
				accessPoint.DomainName = _ctx.StringValue("DescribeAccessPoints.AccessPoints["+ i +"].DomainName");
				accessPoint.EnabledRam = _ctx.BooleanValue("DescribeAccessPoints.AccessPoints["+ i +"].EnabledRam");
				accessPoint.FileSystemId = _ctx.StringValue("DescribeAccessPoints.AccessPoints["+ i +"].FileSystemId");
				accessPoint.ModifyTime = _ctx.StringValue("DescribeAccessPoints.AccessPoints["+ i +"].ModifyTime");
				accessPoint.RootPath = _ctx.StringValue("DescribeAccessPoints.AccessPoints["+ i +"].RootPath");
				accessPoint.RootPathStatus = _ctx.StringValue("DescribeAccessPoints.AccessPoints["+ i +"].RootPathStatus");
				accessPoint.Status = _ctx.StringValue("DescribeAccessPoints.AccessPoints["+ i +"].Status");
				accessPoint.VSwitchId = _ctx.StringValue("DescribeAccessPoints.AccessPoints["+ i +"].VSwitchId");
				accessPoint.VpcId = _ctx.StringValue("DescribeAccessPoints.AccessPoints["+ i +"].VpcId");

				DescribeAccessPointsResponse.DescribeAccessPoints_AccessPoint.DescribeAccessPoints_PosixUser posixUser = new DescribeAccessPointsResponse.DescribeAccessPoints_AccessPoint.DescribeAccessPoints_PosixUser();
				posixUser.PosixGroupId = _ctx.IntegerValue("DescribeAccessPoints.AccessPoints["+ i +"].PosixUser.PosixGroupId");
				posixUser.PosixUserId = _ctx.IntegerValue("DescribeAccessPoints.AccessPoints["+ i +"].PosixUser.PosixUserId");

				List<string> posixUser_posixSecondaryGroupIds = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeAccessPoints.AccessPoints["+ i +"].PosixUser.PosixSecondaryGroupIds.Length"); j++) {
					posixUser_posixSecondaryGroupIds.Add(_ctx.StringValue("DescribeAccessPoints.AccessPoints["+ i +"].PosixUser.PosixSecondaryGroupIds["+ j +"]"));
				}
				posixUser.PosixSecondaryGroupIds = posixUser_posixSecondaryGroupIds;
				accessPoint.PosixUser = posixUser;

				DescribeAccessPointsResponse.DescribeAccessPoints_AccessPoint.DescribeAccessPoints_RootPathPermission rootPathPermission = new DescribeAccessPointsResponse.DescribeAccessPoints_AccessPoint.DescribeAccessPoints_RootPathPermission();
				rootPathPermission.OwnerGroupId = _ctx.LongValue("DescribeAccessPoints.AccessPoints["+ i +"].RootPathPermission.OwnerGroupId");
				rootPathPermission.OwnerUserId = _ctx.LongValue("DescribeAccessPoints.AccessPoints["+ i +"].RootPathPermission.OwnerUserId");
				rootPathPermission.Permission = _ctx.StringValue("DescribeAccessPoints.AccessPoints["+ i +"].RootPathPermission.Permission");
				accessPoint.RootPathPermission = rootPathPermission;

				describeAccessPointsResponse_accessPoints.Add(accessPoint);
			}
			describeAccessPointsResponse.AccessPoints = describeAccessPointsResponse_accessPoints;
        
			return describeAccessPointsResponse;
        }
    }
}
