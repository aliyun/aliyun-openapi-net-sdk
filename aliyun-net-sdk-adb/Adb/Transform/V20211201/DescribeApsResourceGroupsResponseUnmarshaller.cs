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
using Aliyun.Acs.adb.Model.V20211201;

namespace Aliyun.Acs.adb.Transform.V20211201
{
    public class DescribeApsResourceGroupsResponseUnmarshaller
    {
        public static DescribeApsResourceGroupsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeApsResourceGroupsResponse describeApsResourceGroupsResponse = new DescribeApsResourceGroupsResponse();

			describeApsResourceGroupsResponse.HttpResponse = _ctx.HttpResponse;
			describeApsResourceGroupsResponse.RequestId = _ctx.StringValue("DescribeApsResourceGroups.RequestId");
			describeApsResourceGroupsResponse.Message = _ctx.StringValue("DescribeApsResourceGroups.Message");
			describeApsResourceGroupsResponse.HttpStatusCode = _ctx.LongValue("DescribeApsResourceGroups.HttpStatusCode");
			describeApsResourceGroupsResponse.Success = _ctx.BooleanValue("DescribeApsResourceGroups.Success");

			DescribeApsResourceGroupsResponse.DescribeApsResourceGroups_Data data = new DescribeApsResourceGroupsResponse.DescribeApsResourceGroups_Data();
			data.Step = _ctx.LongValue("DescribeApsResourceGroups.Data.Step");

			List<DescribeApsResourceGroupsResponse.DescribeApsResourceGroups_Data.DescribeApsResourceGroups_ValidPoolsInfo> data_resourceGroups = new List<DescribeApsResourceGroupsResponse.DescribeApsResourceGroups_Data.DescribeApsResourceGroups_ValidPoolsInfo>();
			for (int i = 0; i < _ctx.Length("DescribeApsResourceGroups.Data.ResourceGroups.Length"); i++) {
				DescribeApsResourceGroupsResponse.DescribeApsResourceGroups_Data.DescribeApsResourceGroups_ValidPoolsInfo validPoolsInfo = new DescribeApsResourceGroupsResponse.DescribeApsResourceGroups_Data.DescribeApsResourceGroups_ValidPoolsInfo();
				validPoolsInfo.MaxComputeResource = _ctx.IntegerValue("DescribeApsResourceGroups.Data.ResourceGroups["+ i +"].MaxComputeResource");
				validPoolsInfo.MinComputeResource = _ctx.IntegerValue("DescribeApsResourceGroups.Data.ResourceGroups["+ i +"].MinComputeResource");
				validPoolsInfo.GroupName = _ctx.StringValue("DescribeApsResourceGroups.Data.ResourceGroups["+ i +"].GroupName");
				validPoolsInfo.GroupType = _ctx.StringValue("DescribeApsResourceGroups.Data.ResourceGroups["+ i +"].GroupType");
				validPoolsInfo.Available = _ctx.BooleanValue("DescribeApsResourceGroups.Data.ResourceGroups["+ i +"].Available");

				List<string> validPoolsInfo_cuOptions = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeApsResourceGroups.Data.ResourceGroups["+ i +"].CuOptions.Length"); j++) {
					validPoolsInfo_cuOptions.Add(_ctx.StringValue("DescribeApsResourceGroups.Data.ResourceGroups["+ i +"].CuOptions["+ j +"]"));
				}
				validPoolsInfo.CuOptions = validPoolsInfo_cuOptions;

				data_resourceGroups.Add(validPoolsInfo);
			}
			data.ResourceGroups = data_resourceGroups;
			describeApsResourceGroupsResponse.Data = data;
        
			return describeApsResourceGroupsResponse;
        }
    }
}
