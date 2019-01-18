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
    public class DescribeConsortiumMemberApprovalResponseUnmarshaller
    {
        public static DescribeConsortiumMemberApprovalResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeConsortiumMemberApprovalResponse describeConsortiumMemberApprovalResponse = new DescribeConsortiumMemberApprovalResponse();

			describeConsortiumMemberApprovalResponse.HttpResponse = context.HttpResponse;
			describeConsortiumMemberApprovalResponse.RequestId = context.StringValue("DescribeConsortiumMemberApproval.RequestId");
			describeConsortiumMemberApprovalResponse.Success = context.BooleanValue("DescribeConsortiumMemberApproval.Success");
			describeConsortiumMemberApprovalResponse.ErrorCode = context.IntegerValue("DescribeConsortiumMemberApproval.ErrorCode");

			List<DescribeConsortiumMemberApprovalResponse.DescribeConsortiumMemberApproval_ConsortiumMemberApproval> describeConsortiumMemberApprovalResponse_result = new List<DescribeConsortiumMemberApprovalResponse.DescribeConsortiumMemberApproval_ConsortiumMemberApproval>();
			for (int i = 0; i < context.Length("DescribeConsortiumMemberApproval.Result.Length"); i++) {
				DescribeConsortiumMemberApprovalResponse.DescribeConsortiumMemberApproval_ConsortiumMemberApproval consortiumMemberApproval = new DescribeConsortiumMemberApprovalResponse.DescribeConsortiumMemberApproval_ConsortiumMemberApproval();
				consortiumMemberApproval.ConsortiumId = context.StringValue("DescribeConsortiumMemberApproval.Result["+ i +"].ConsortiumId");
				consortiumMemberApproval.ConsortiumName = context.StringValue("DescribeConsortiumMemberApproval.Result["+ i +"].ConsortiumName");
				consortiumMemberApproval.ChannelCreatePolicy = context.StringValue("DescribeConsortiumMemberApproval.Result["+ i +"].ChannelCreatePolicy");
				consortiumMemberApproval.OrganizationId = context.StringValue("DescribeConsortiumMemberApproval.Result["+ i +"].OrganizationId");
				consortiumMemberApproval.OrganizationName = context.StringValue("DescribeConsortiumMemberApproval.Result["+ i +"].OrganizationName");
				consortiumMemberApproval.DomainName = context.StringValue("DescribeConsortiumMemberApproval.Result["+ i +"].DomainName");
				consortiumMemberApproval.State = context.StringValue("DescribeConsortiumMemberApproval.Result["+ i +"].State");
				consortiumMemberApproval.ConfirmTime = context.StringValue("DescribeConsortiumMemberApproval.Result["+ i +"].ConfirmTime");

				describeConsortiumMemberApprovalResponse_result.Add(consortiumMemberApproval);
			}
			describeConsortiumMemberApprovalResponse.Result = describeConsortiumMemberApprovalResponse_result;
        
			return describeConsortiumMemberApprovalResponse;
        }
    }
}