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
using Aliyun.Acs.Rds.Model.V20140815;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeVpcZoneNosResponseUnmarshaller
    {
        public static DescribeVpcZoneNosResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVpcZoneNosResponse describeVpcZoneNosResponse = new DescribeVpcZoneNosResponse();

			describeVpcZoneNosResponse.HttpResponse = context.HttpResponse;
			describeVpcZoneNosResponse.RequestId = context.StringValue("DescribeVpcZoneNos.RequestId");

			List<DescribeVpcZoneNosResponse.DescribeVpcZoneNos_VpcZoneId> describeVpcZoneNosResponse_items = new List<DescribeVpcZoneNosResponse.DescribeVpcZoneNos_VpcZoneId>();
			for (int i = 0; i < context.Length("DescribeVpcZoneNos.Items.Length"); i++) {
				DescribeVpcZoneNosResponse.DescribeVpcZoneNos_VpcZoneId vpcZoneId = new DescribeVpcZoneNosResponse.DescribeVpcZoneNos_VpcZoneId();
				vpcZoneId.ZoneId = context.StringValue("DescribeVpcZoneNos.Items["+ i +"].ZoneId");
				vpcZoneId.Region = context.StringValue("DescribeVpcZoneNos.Items["+ i +"].Region");
				vpcZoneId.SubDomain = context.StringValue("DescribeVpcZoneNos.Items["+ i +"].SubDomain");

				describeVpcZoneNosResponse_items.Add(vpcZoneId);
			}
			describeVpcZoneNosResponse.Items = describeVpcZoneNosResponse_items;
        
			return describeVpcZoneNosResponse;
        }
    }
}