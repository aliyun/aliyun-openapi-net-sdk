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
        public static DescribeApplicationGroupsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeApplicationGroupsResponse describeApplicationGroupsResponse = new DescribeApplicationGroupsResponse();

			describeApplicationGroupsResponse.HttpResponse = context.HttpResponse;
			describeApplicationGroupsResponse.Code = context.StringValue("DescribeApplicationGroups.Code");
			describeApplicationGroupsResponse.Message = context.StringValue("DescribeApplicationGroups.Message");
			describeApplicationGroupsResponse.TraceId = context.StringValue("DescribeApplicationGroups.TraceId");
			describeApplicationGroupsResponse.RequestId = context.StringValue("DescribeApplicationGroups.RequestId");
			describeApplicationGroupsResponse.Success = context.BooleanValue("DescribeApplicationGroups.Success");
			describeApplicationGroupsResponse.ErrorCode = context.StringValue("DescribeApplicationGroups.ErrorCode");

			List<DescribeApplicationGroupsResponse.DescribeApplicationGroups_ApplicationGroup> describeApplicationGroupsResponse_data = new List<DescribeApplicationGroupsResponse.DescribeApplicationGroups_ApplicationGroup>();
			for (int i = 0; i < context.Length("DescribeApplicationGroups.Data.Length"); i++) {
				DescribeApplicationGroupsResponse.DescribeApplicationGroups_ApplicationGroup applicationGroup = new DescribeApplicationGroupsResponse.DescribeApplicationGroups_ApplicationGroup();
				applicationGroup.GroupId = context.StringValue("DescribeApplicationGroups.Data["+ i +"].GroupId");
				applicationGroup.GroupName = context.StringValue("DescribeApplicationGroups.Data["+ i +"].GroupName");
				applicationGroup.GroupType = context.IntegerValue("DescribeApplicationGroups.Data["+ i +"].GroupType");
				applicationGroup.PackageType = context.StringValue("DescribeApplicationGroups.Data["+ i +"].PackageType");
				applicationGroup.PackageVersion = context.StringValue("DescribeApplicationGroups.Data["+ i +"].PackageVersion");
				applicationGroup.ImageUrl = context.StringValue("DescribeApplicationGroups.Data["+ i +"].ImageUrl");
				applicationGroup.PackageUrl = context.StringValue("DescribeApplicationGroups.Data["+ i +"].PackageUrl");
				applicationGroup.Jdk = context.StringValue("DescribeApplicationGroups.Data["+ i +"].Jdk");
				applicationGroup.WebContainer = context.StringValue("DescribeApplicationGroups.Data["+ i +"].WebContainer");
				applicationGroup.EdasContainerVersion = context.StringValue("DescribeApplicationGroups.Data["+ i +"].EdasContainerVersion");
				applicationGroup.Replicas = context.IntegerValue("DescribeApplicationGroups.Data["+ i +"].Replicas");
				applicationGroup.RunningInstances = context.IntegerValue("DescribeApplicationGroups.Data["+ i +"].RunningInstances");

				describeApplicationGroupsResponse_data.Add(applicationGroup);
			}
			describeApplicationGroupsResponse.Data = describeApplicationGroupsResponse_data;
        
			return describeApplicationGroupsResponse;
        }
    }
}
