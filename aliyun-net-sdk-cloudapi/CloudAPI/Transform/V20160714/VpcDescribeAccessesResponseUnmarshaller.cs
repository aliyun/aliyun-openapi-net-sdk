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
    public class VpcDescribeAccessesResponseUnmarshaller
    {
        public static VpcDescribeAccessesResponse Unmarshall(UnmarshallerContext context)
        {
			VpcDescribeAccessesResponse vpcDescribeAccessesResponse = new VpcDescribeAccessesResponse();

			vpcDescribeAccessesResponse.HttpResponse = context.HttpResponse;
			vpcDescribeAccessesResponse.RequestId = context.StringValue("VpcDescribeAccesses.RequestId");
			vpcDescribeAccessesResponse.TotalCount = context.IntegerValue("VpcDescribeAccesses.TotalCount");
			vpcDescribeAccessesResponse.PageSize = context.IntegerValue("VpcDescribeAccesses.PageSize");
			vpcDescribeAccessesResponse.PageNumber = context.IntegerValue("VpcDescribeAccesses.PageNumber");

			List<VpcDescribeAccessesResponse.VpcAccessAttribute> vpcAccessAttributes = new List<VpcDescribeAccessesResponse.VpcAccessAttribute>();
			for (int i = 0; i < context.Length("VpcDescribeAccesses.VpcAccessAttributes.Length"); i++) {
				VpcDescribeAccessesResponse.VpcAccessAttribute vpcAccessAttribute = new VpcDescribeAccessesResponse.VpcAccessAttribute();
				vpcAccessAttribute.VpcId = context.StringValue("VpcDescribeAccesses.VpcAccessAttributes["+ i +"].VpcId");
				vpcAccessAttribute.InstanceId = context.StringValue("VpcDescribeAccesses.VpcAccessAttributes["+ i +"].InstanceId");
				vpcAccessAttribute.CreatedTime = context.StringValue("VpcDescribeAccesses.VpcAccessAttributes["+ i +"].CreatedTime");
				vpcAccessAttribute.Port = context.IntegerValue("VpcDescribeAccesses.VpcAccessAttributes["+ i +"].Port");
				vpcAccessAttribute.RegionId = context.StringValue("VpcDescribeAccesses.VpcAccessAttributes["+ i +"].RegionId");
				vpcAccessAttribute.Name = context.StringValue("VpcDescribeAccesses.VpcAccessAttributes["+ i +"].Name");

				vpcAccessAttributes.Add(vpcAccessAttribute);
			}
			vpcDescribeAccessesResponse.VpcAccessAttributes = vpcAccessAttributes;
        
			return vpcDescribeAccessesResponse;
        }
    }
}