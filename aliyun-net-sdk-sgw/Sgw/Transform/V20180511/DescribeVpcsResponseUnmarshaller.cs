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
using Aliyun.Acs.sgw.Model.V20180511;

namespace Aliyun.Acs.sgw.Transform.V20180511
{
    public class DescribeVpcsResponseUnmarshaller
    {
        public static DescribeVpcsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVpcsResponse describeVpcsResponse = new DescribeVpcsResponse();

			describeVpcsResponse.HttpResponse = context.HttpResponse;
			describeVpcsResponse.RequestId = context.StringValue("DescribeVpcs.RequestId");
			describeVpcsResponse.Success = context.BooleanValue("DescribeVpcs.Success");
			describeVpcsResponse.Code = context.StringValue("DescribeVpcs.Code");
			describeVpcsResponse.Message = context.StringValue("DescribeVpcs.Message");
			describeVpcsResponse.TotalCount = context.IntegerValue("DescribeVpcs.TotalCount");
			describeVpcsResponse.PageNumber = context.IntegerValue("DescribeVpcs.PageNumber");
			describeVpcsResponse.PageSize = context.IntegerValue("DescribeVpcs.PageSize");

			List<DescribeVpcsResponse.DescribeVpcs_Vpc> describeVpcsResponse_vpcs = new List<DescribeVpcsResponse.DescribeVpcs_Vpc>();
			for (int i = 0; i < context.Length("DescribeVpcs.Vpcs.Length"); i++) {
				DescribeVpcsResponse.DescribeVpcs_Vpc vpc = new DescribeVpcsResponse.DescribeVpcs_Vpc();
				vpc.Name = context.StringValue("DescribeVpcs.Vpcs["+ i +"].Name");
				vpc.Id = context.StringValue("DescribeVpcs.Vpcs["+ i +"].Id");
				vpc.IsDefault = context.BooleanValue("DescribeVpcs.Vpcs["+ i +"].IsDefault");
				vpc.CidrBlock = context.StringValue("DescribeVpcs.Vpcs["+ i +"].CidrBlock");

				describeVpcsResponse_vpcs.Add(vpc);
			}
			describeVpcsResponse.Vpcs = describeVpcsResponse_vpcs;
        
			return describeVpcsResponse;
        }
    }
}
