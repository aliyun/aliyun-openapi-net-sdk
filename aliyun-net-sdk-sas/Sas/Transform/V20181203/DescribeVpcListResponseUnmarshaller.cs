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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class DescribeVpcListResponseUnmarshaller
    {
        public static DescribeVpcListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVpcListResponse describeVpcListResponse = new DescribeVpcListResponse();

			describeVpcListResponse.HttpResponse = _ctx.HttpResponse;
			describeVpcListResponse.RequestId = _ctx.StringValue("DescribeVpcList.RequestId");
			describeVpcListResponse.Count = _ctx.IntegerValue("DescribeVpcList.Count");

			List<DescribeVpcListResponse.DescribeVpcList_Vpc> describeVpcListResponse_vpcList = new List<DescribeVpcListResponse.DescribeVpcList_Vpc>();
			for (int i = 0; i < _ctx.Length("DescribeVpcList.VpcList.Length"); i++) {
				DescribeVpcListResponse.DescribeVpcList_Vpc vpc = new DescribeVpcListResponse.DescribeVpcList_Vpc();
				vpc.InstanceId = _ctx.StringValue("DescribeVpcList.VpcList["+ i +"].InstanceId");
				vpc.MiddleStatus = _ctx.IntegerValue("DescribeVpcList.VpcList["+ i +"].MiddleStatus");
				vpc.InstanceName = _ctx.StringValue("DescribeVpcList.VpcList["+ i +"].InstanceName");
				vpc.RegionId = _ctx.StringValue("DescribeVpcList.VpcList["+ i +"].RegionId");
				vpc.InstanceDesc = _ctx.StringValue("DescribeVpcList.VpcList["+ i +"].InstanceDesc");
				vpc.EcsCount = _ctx.IntegerValue("DescribeVpcList.VpcList["+ i +"].EcsCount");
				vpc.Status = _ctx.IntegerValue("DescribeVpcList.VpcList["+ i +"].Status");

				describeVpcListResponse_vpcList.Add(vpc);
			}
			describeVpcListResponse.VpcList = describeVpcListResponse_vpcList;
        
			return describeVpcListResponse;
        }
    }
}
