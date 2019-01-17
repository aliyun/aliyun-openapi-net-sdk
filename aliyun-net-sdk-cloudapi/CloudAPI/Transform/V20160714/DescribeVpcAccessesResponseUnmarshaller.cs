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
using Aliyun.Acs.CloudAPI.Model.V20160714;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.CloudAPI.Transform.V20160714
{
    public class DescribeVpcAccessesResponseUnmarshaller
    {
        public static DescribeVpcAccessesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVpcAccessesResponse describeVpcAccessesResponse = new DescribeVpcAccessesResponse();

			describeVpcAccessesResponse.HttpResponse = context.HttpResponse;
			describeVpcAccessesResponse.RequestId = context.StringValue("DescribeVpcAccesses.RequestId");
			describeVpcAccessesResponse.TotalCount = context.IntegerValue("DescribeVpcAccesses.TotalCount");
			describeVpcAccessesResponse.PageSize = context.IntegerValue("DescribeVpcAccesses.PageSize");
			describeVpcAccessesResponse.PageNumber = context.IntegerValue("DescribeVpcAccesses.PageNumber");

			List<DescribeVpcAccessesResponse.DescribeVpcAccesses_VpcAccessAttribute> describeVpcAccessesResponse_vpcAccessAttributes = new List<DescribeVpcAccessesResponse.DescribeVpcAccesses_VpcAccessAttribute>();
			for (int i = 0; i < context.Length("DescribeVpcAccesses.VpcAccessAttributes.Length"); i++) {
				DescribeVpcAccessesResponse.DescribeVpcAccesses_VpcAccessAttribute vpcAccessAttribute = new DescribeVpcAccessesResponse.DescribeVpcAccesses_VpcAccessAttribute();
				vpcAccessAttribute.VpcId = context.StringValue("DescribeVpcAccesses.VpcAccessAttributes["+ i +"].VpcId");
				vpcAccessAttribute.InstanceId = context.StringValue("DescribeVpcAccesses.VpcAccessAttributes["+ i +"].InstanceId");
				vpcAccessAttribute.CreatedTime = context.StringValue("DescribeVpcAccesses.VpcAccessAttributes["+ i +"].CreatedTime");
				vpcAccessAttribute.Port = context.IntegerValue("DescribeVpcAccesses.VpcAccessAttributes["+ i +"].Port");
				vpcAccessAttribute.RegionId = context.StringValue("DescribeVpcAccesses.VpcAccessAttributes["+ i +"].RegionId");
				vpcAccessAttribute.Name = context.StringValue("DescribeVpcAccesses.VpcAccessAttributes["+ i +"].Name");

				describeVpcAccessesResponse_vpcAccessAttributes.Add(vpcAccessAttribute);
			}
			describeVpcAccessesResponse.VpcAccessAttributes = describeVpcAccessesResponse_vpcAccessAttributes;
        
			return describeVpcAccessesResponse;
        }
    }
}