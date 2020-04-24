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
using Aliyun.Acs.ledgerdb.Model.V20191122;

namespace Aliyun.Acs.ledgerdb.Transform.V20191122
{
    public class ListVpcEndpointsResponseUnmarshaller
    {
        public static ListVpcEndpointsResponse Unmarshall(UnmarshallerContext context)
        {
			ListVpcEndpointsResponse listVpcEndpointsResponse = new ListVpcEndpointsResponse();

			listVpcEndpointsResponse.HttpResponse = context.HttpResponse;
			listVpcEndpointsResponse.RequestId = context.StringValue("ListVpcEndpoints.RequestId");
			listVpcEndpointsResponse.NextToken = context.StringValue("ListVpcEndpoints.NextToken");
			listVpcEndpointsResponse.MaxResults = context.IntegerValue("ListVpcEndpoints.MaxResults");

			List<ListVpcEndpointsResponse.ListVpcEndpoints_VpcEndpoint> listVpcEndpointsResponse_vpcEndpoints = new List<ListVpcEndpointsResponse.ListVpcEndpoints_VpcEndpoint>();
			for (int i = 0; i < context.Length("ListVpcEndpoints.VpcEndpoints.Length"); i++) {
				ListVpcEndpointsResponse.ListVpcEndpoints_VpcEndpoint vpcEndpoint = new ListVpcEndpointsResponse.ListVpcEndpoints_VpcEndpoint();
				vpcEndpoint.VpcEndpointId = context.StringValue("ListVpcEndpoints.VpcEndpoints["+ i +"].VpcEndpointId");
				vpcEndpoint.LedgerId = context.StringValue("ListVpcEndpoints.VpcEndpoints["+ i +"].LedgerId");
				vpcEndpoint.MemberId = context.StringValue("ListVpcEndpoints.VpcEndpoints["+ i +"].MemberId");
				vpcEndpoint.RegionId = context.StringValue("ListVpcEndpoints.VpcEndpoints["+ i +"].RegionId");
				vpcEndpoint.VpcId = context.StringValue("ListVpcEndpoints.VpcEndpoints["+ i +"].VpcId");
				vpcEndpoint.VSwitchId = context.StringValue("ListVpcEndpoints.VpcEndpoints["+ i +"].VSwitchId");
				vpcEndpoint.Address = context.StringValue("ListVpcEndpoints.VpcEndpoints["+ i +"].Address");
				vpcEndpoint.CreateTime = context.LongValue("ListVpcEndpoints.VpcEndpoints["+ i +"].CreateTime");
				vpcEndpoint.Status = context.StringValue("ListVpcEndpoints.VpcEndpoints["+ i +"].Status");

				listVpcEndpointsResponse_vpcEndpoints.Add(vpcEndpoint);
			}
			listVpcEndpointsResponse.VpcEndpoints = listVpcEndpointsResponse_vpcEndpoints;
        
			return listVpcEndpointsResponse;
        }
    }
}
