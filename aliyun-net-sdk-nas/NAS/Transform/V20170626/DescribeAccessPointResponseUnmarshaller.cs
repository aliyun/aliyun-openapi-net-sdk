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
    public class DescribeAccessPointResponseUnmarshaller
    {
        public static DescribeAccessPointResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAccessPointResponse describeAccessPointResponse = new DescribeAccessPointResponse();

			describeAccessPointResponse.HttpResponse = _ctx.HttpResponse;
			describeAccessPointResponse.RequestId = _ctx.StringValue("DescribeAccessPoint.RequestId");

			DescribeAccessPointResponse.DescribeAccessPoint_AccessPoint accessPoint = new DescribeAccessPointResponse.DescribeAccessPoint_AccessPoint();
			accessPoint.ARN = _ctx.StringValue("DescribeAccessPoint.AccessPoint.ARN");
			accessPoint.AccessGroup = _ctx.StringValue("DescribeAccessPoint.AccessPoint.AccessGroup");
			accessPoint.AccessPointId = _ctx.StringValue("DescribeAccessPoint.AccessPoint.AccessPointId");
			accessPoint.AccessPointName = _ctx.StringValue("DescribeAccessPoint.AccessPoint.AccessPointName");
			accessPoint.CreateTime = _ctx.StringValue("DescribeAccessPoint.AccessPoint.CreateTime");
			accessPoint.DomainName = _ctx.StringValue("DescribeAccessPoint.AccessPoint.DomainName");
			accessPoint.EnabledRam = _ctx.BooleanValue("DescribeAccessPoint.AccessPoint.EnabledRam");
			accessPoint.FileSystemId = _ctx.StringValue("DescribeAccessPoint.AccessPoint.FileSystemId");
			accessPoint.ModifyTime = _ctx.StringValue("DescribeAccessPoint.AccessPoint.ModifyTime");
			accessPoint.RootPath = _ctx.StringValue("DescribeAccessPoint.AccessPoint.RootPath");
			accessPoint.RootPathStatus = _ctx.StringValue("DescribeAccessPoint.AccessPoint.RootPathStatus");
			accessPoint.Status = _ctx.StringValue("DescribeAccessPoint.AccessPoint.Status");
			accessPoint.VSwitchId = _ctx.StringValue("DescribeAccessPoint.AccessPoint.VSwitchId");
			accessPoint.VpcId = _ctx.StringValue("DescribeAccessPoint.AccessPoint.VpcId");
			accessPoint.RegionId = _ctx.StringValue("DescribeAccessPoint.AccessPoint.RegionId");

			DescribeAccessPointResponse.DescribeAccessPoint_AccessPoint.DescribeAccessPoint_RootPathPermission rootPathPermission = new DescribeAccessPointResponse.DescribeAccessPoint_AccessPoint.DescribeAccessPoint_RootPathPermission();
			rootPathPermission.OwnerGroupId = _ctx.IntegerValue("DescribeAccessPoint.AccessPoint.RootPathPermission.OwnerGroupId");
			rootPathPermission.OwnerUserId = _ctx.IntegerValue("DescribeAccessPoint.AccessPoint.RootPathPermission.OwnerUserId");
			rootPathPermission.Permission = _ctx.StringValue("DescribeAccessPoint.AccessPoint.RootPathPermission.Permission");
			accessPoint.RootPathPermission = rootPathPermission;

			DescribeAccessPointResponse.DescribeAccessPoint_AccessPoint.DescribeAccessPoint_PosixUser posixUser = new DescribeAccessPointResponse.DescribeAccessPoint_AccessPoint.DescribeAccessPoint_PosixUser();
			posixUser.PosixGroupId = _ctx.IntegerValue("DescribeAccessPoint.AccessPoint.PosixUser.PosixGroupId");
			posixUser.PosixUserId = _ctx.IntegerValue("DescribeAccessPoint.AccessPoint.PosixUser.PosixUserId");

			List<string> posixUser_posixSecondaryGroupIds = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeAccessPoint.AccessPoint.PosixUser.PosixSecondaryGroupIds.Length"); i++) {
				posixUser_posixSecondaryGroupIds.Add(_ctx.StringValue("DescribeAccessPoint.AccessPoint.PosixUser.PosixSecondaryGroupIds["+ i +"]"));
			}
			posixUser.PosixSecondaryGroupIds = posixUser_posixSecondaryGroupIds;
			accessPoint.PosixUser = posixUser;

			List<DescribeAccessPointResponse.DescribeAccessPoint_AccessPoint.DescribeAccessPoint_Tag> accessPoint_tags = new List<DescribeAccessPointResponse.DescribeAccessPoint_AccessPoint.DescribeAccessPoint_Tag>();
			for (int i = 0; i < _ctx.Length("DescribeAccessPoint.AccessPoint.Tags.Length"); i++) {
				DescribeAccessPointResponse.DescribeAccessPoint_AccessPoint.DescribeAccessPoint_Tag tag = new DescribeAccessPointResponse.DescribeAccessPoint_AccessPoint.DescribeAccessPoint_Tag();
				tag.Key = _ctx.StringValue("DescribeAccessPoint.AccessPoint.Tags["+ i +"].Key");
				tag._Value = _ctx.StringValue("DescribeAccessPoint.AccessPoint.Tags["+ i +"].Value");

				accessPoint_tags.Add(tag);
			}
			accessPoint.Tags = accessPoint_tags;
			describeAccessPointResponse.AccessPoint = accessPoint;
        
			return describeAccessPointResponse;
        }
    }
}
