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
    public class DescribeNamespaceListResponseUnmarshaller
    {
        public static DescribeNamespaceListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeNamespaceListResponse describeNamespaceListResponse = new DescribeNamespaceListResponse();

			describeNamespaceListResponse.HttpResponse = _ctx.HttpResponse;
			describeNamespaceListResponse.RequestId = _ctx.StringValue("DescribeNamespaceList.RequestId");
			describeNamespaceListResponse.Code = _ctx.StringValue("DescribeNamespaceList.Code");
			describeNamespaceListResponse.Message = _ctx.StringValue("DescribeNamespaceList.Message");
			describeNamespaceListResponse.Success = _ctx.BooleanValue("DescribeNamespaceList.Success");
			describeNamespaceListResponse.ErrorCode = _ctx.StringValue("DescribeNamespaceList.ErrorCode");
			describeNamespaceListResponse.TraceId = _ctx.StringValue("DescribeNamespaceList.TraceId");

			List<DescribeNamespaceListResponse.DescribeNamespaceList_RegionList> describeNamespaceListResponse_data = new List<DescribeNamespaceListResponse.DescribeNamespaceList_RegionList>();
			for (int i = 0; i < _ctx.Length("DescribeNamespaceList.Data.Length"); i++) {
				DescribeNamespaceListResponse.DescribeNamespaceList_RegionList regionList = new DescribeNamespaceListResponse.DescribeNamespaceList_RegionList();
				regionList.NamespaceName = _ctx.StringValue("DescribeNamespaceList.Data["+ i +"].NamespaceName");
				regionList.NamespaceId = _ctx.StringValue("DescribeNamespaceList.Data["+ i +"].NamespaceId");
				regionList.AgentInstall = _ctx.StringValue("DescribeNamespaceList.Data["+ i +"].AgentInstall");
				regionList.Current = _ctx.BooleanValue("DescribeNamespaceList.Data["+ i +"].Current");
				regionList.Custom = _ctx.BooleanValue("DescribeNamespaceList.Data["+ i +"].Custom");
				regionList.RegionId = _ctx.StringValue("DescribeNamespaceList.Data["+ i +"].RegionId");
				regionList.HybridCloudEnable = _ctx.BooleanValue("DescribeNamespaceList.Data["+ i +"].HybridCloudEnable");
				regionList.VpcId = _ctx.StringValue("DescribeNamespaceList.Data["+ i +"].VpcId");
				regionList.VSwitchId = _ctx.StringValue("DescribeNamespaceList.Data["+ i +"].VSwitchId");
				regionList.SecurityGroupId = _ctx.StringValue("DescribeNamespaceList.Data["+ i +"].SecurityGroupId");

				describeNamespaceListResponse_data.Add(regionList);
			}
			describeNamespaceListResponse.Data = describeNamespaceListResponse_data;
        
			return describeNamespaceListResponse;
        }
    }
}
