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
using Aliyun.Acs.sae.Model.V20190506;

namespace Aliyun.Acs.sae.Transform.V20190506
{
    public class DescribeApplicationGroupsResponseUnmarshaller
    {
        public static DescribeApplicationGroupsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeApplicationGroupsResponse describeApplicationGroupsResponse = new DescribeApplicationGroupsResponse();

			describeApplicationGroupsResponse.HttpResponse = _ctx.HttpResponse;
			describeApplicationGroupsResponse.Code = _ctx.StringValue("DescribeApplicationGroups.Code");
			describeApplicationGroupsResponse.Message = _ctx.StringValue("DescribeApplicationGroups.Message");
			describeApplicationGroupsResponse.TraceId = _ctx.StringValue("DescribeApplicationGroups.TraceId");
			describeApplicationGroupsResponse.RequestId = _ctx.StringValue("DescribeApplicationGroups.RequestId");
			describeApplicationGroupsResponse.Success = _ctx.BooleanValue("DescribeApplicationGroups.Success");
			describeApplicationGroupsResponse.ErrorCode = _ctx.StringValue("DescribeApplicationGroups.ErrorCode");

			List<DescribeApplicationGroupsResponse.DescribeApplicationGroups_ApplicationGroup> describeApplicationGroupsResponse_data = new List<DescribeApplicationGroupsResponse.DescribeApplicationGroups_ApplicationGroup>();
			for (int i = 0; i < _ctx.Length("DescribeApplicationGroups.Data.Length"); i++) {
				DescribeApplicationGroupsResponse.DescribeApplicationGroups_ApplicationGroup applicationGroup = new DescribeApplicationGroupsResponse.DescribeApplicationGroups_ApplicationGroup();
				applicationGroup.GroupId = _ctx.StringValue("DescribeApplicationGroups.Data["+ i +"].GroupId");
				applicationGroup.GroupName = _ctx.StringValue("DescribeApplicationGroups.Data["+ i +"].GroupName");
				applicationGroup.GroupType = _ctx.IntegerValue("DescribeApplicationGroups.Data["+ i +"].GroupType");
				applicationGroup.PackageType = _ctx.StringValue("DescribeApplicationGroups.Data["+ i +"].PackageType");
				applicationGroup.PackageVersion = _ctx.StringValue("DescribeApplicationGroups.Data["+ i +"].PackageVersion");
				applicationGroup.ImageUrl = _ctx.StringValue("DescribeApplicationGroups.Data["+ i +"].ImageUrl");
				applicationGroup.PackageUrl = _ctx.StringValue("DescribeApplicationGroups.Data["+ i +"].PackageUrl");
				applicationGroup.Jdk = _ctx.StringValue("DescribeApplicationGroups.Data["+ i +"].Jdk");
				applicationGroup.WebContainer = _ctx.StringValue("DescribeApplicationGroups.Data["+ i +"].WebContainer");
				applicationGroup.EdasContainerVersion = _ctx.StringValue("DescribeApplicationGroups.Data["+ i +"].EdasContainerVersion");
				applicationGroup.Replicas = _ctx.IntegerValue("DescribeApplicationGroups.Data["+ i +"].Replicas");
				applicationGroup.RunningInstances = _ctx.IntegerValue("DescribeApplicationGroups.Data["+ i +"].RunningInstances");

				describeApplicationGroupsResponse_data.Add(applicationGroup);
			}
			describeApplicationGroupsResponse.Data = describeApplicationGroupsResponse_data;
        
			return describeApplicationGroupsResponse;
        }
    }
}
