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
using Aliyun.Acs.Baas.Model.V20180731;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Baas.Transform.V20180731
{
    public class DescribeOrganizationPeersResponseUnmarshaller
    {
        public static DescribeOrganizationPeersResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeOrganizationPeersResponse describeOrganizationPeersResponse = new DescribeOrganizationPeersResponse();

			describeOrganizationPeersResponse.HttpResponse = context.HttpResponse;
			describeOrganizationPeersResponse.RequestId = context.StringValue("DescribeOrganizationPeers.RequestId");
			describeOrganizationPeersResponse.Success = context.BooleanValue("DescribeOrganizationPeers.Success");
			describeOrganizationPeersResponse.ErrorCode = context.IntegerValue("DescribeOrganizationPeers.ErrorCode");

			List<DescribeOrganizationPeersResponse.DescribeOrganizationPeers_ResultItem> describeOrganizationPeersResponse_result = new List<DescribeOrganizationPeersResponse.DescribeOrganizationPeers_ResultItem>();
			for (int i = 0; i < context.Length("DescribeOrganizationPeers.Result.Length"); i++) {
				DescribeOrganizationPeersResponse.DescribeOrganizationPeers_ResultItem resultItem = new DescribeOrganizationPeersResponse.DescribeOrganizationPeers_ResultItem();
				resultItem.Name = context.StringValue("DescribeOrganizationPeers.Result["+ i +"].Name");
				resultItem.IsAnchor = context.BooleanValue("DescribeOrganizationPeers.Result["+ i +"].IsAnchor");
				resultItem.IntranetIp = context.StringValue("DescribeOrganizationPeers.Result["+ i +"].IntranetIp");
				resultItem.InternetIp = context.StringValue("DescribeOrganizationPeers.Result["+ i +"].InternetIp");
				resultItem.Domain = context.StringValue("DescribeOrganizationPeers.Result["+ i +"].Domain");
				resultItem.Port = context.IntegerValue("DescribeOrganizationPeers.Result["+ i +"].Port");
				resultItem.InstanceType = context.StringValue("DescribeOrganizationPeers.Result["+ i +"].InstanceType");
				resultItem.CreateTime = context.StringValue("DescribeOrganizationPeers.Result["+ i +"].CreateTime");
				resultItem.UpdateTime = context.StringValue("DescribeOrganizationPeers.Result["+ i +"].UpdateTime");

				describeOrganizationPeersResponse_result.Add(resultItem);
			}
			describeOrganizationPeersResponse.Result = describeOrganizationPeersResponse_result;
        
			return describeOrganizationPeersResponse;
        }
    }
}