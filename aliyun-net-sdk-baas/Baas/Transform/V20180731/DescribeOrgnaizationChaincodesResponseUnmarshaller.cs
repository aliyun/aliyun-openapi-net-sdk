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
    public class DescribeOrgnaizationChaincodesResponseUnmarshaller
    {
        public static DescribeOrgnaizationChaincodesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeOrgnaizationChaincodesResponse describeOrgnaizationChaincodesResponse = new DescribeOrgnaizationChaincodesResponse();

			describeOrgnaizationChaincodesResponse.HttpResponse = context.HttpResponse;
			describeOrgnaizationChaincodesResponse.RequestId = context.StringValue("DescribeOrgnaizationChaincodes.RequestId");
			describeOrgnaizationChaincodesResponse.Success = context.BooleanValue("DescribeOrgnaizationChaincodes.Success");
			describeOrgnaizationChaincodesResponse.ErrorCode = context.IntegerValue("DescribeOrgnaizationChaincodes.ErrorCode");

			List<DescribeOrgnaizationChaincodesResponse.DescribeOrgnaizationChaincodes_OrganizationChaincode> describeOrgnaizationChaincodesResponse_result = new List<DescribeOrgnaizationChaincodesResponse.DescribeOrgnaizationChaincodes_OrganizationChaincode>();
			for (int i = 0; i < context.Length("DescribeOrgnaizationChaincodes.Result.Length"); i++) {
				DescribeOrgnaizationChaincodesResponse.DescribeOrgnaizationChaincodes_OrganizationChaincode organizationChaincode = new DescribeOrgnaizationChaincodesResponse.DescribeOrgnaizationChaincodes_OrganizationChaincode();
				organizationChaincode.Name = context.StringValue("DescribeOrgnaizationChaincodes.Result["+ i +"].Name");
				organizationChaincode.Version = context.StringValue("DescribeOrgnaizationChaincodes.Result["+ i +"].Version");
				organizationChaincode.Creator = context.StringValue("DescribeOrgnaizationChaincodes.Result["+ i +"].Creator");
				organizationChaincode.ChannelId = context.StringValue("DescribeOrgnaizationChaincodes.Result["+ i +"].ChannelId");
				organizationChaincode.ChannelName = context.StringValue("DescribeOrgnaizationChaincodes.Result["+ i +"].ChannelName");
				organizationChaincode.CreateTime = context.StringValue("DescribeOrgnaizationChaincodes.Result["+ i +"].CreateTime");
				organizationChaincode.DeployTime = context.StringValue("DescribeOrgnaizationChaincodes.Result["+ i +"].DeployTime");
				organizationChaincode.ChaincodeId = context.StringValue("DescribeOrgnaizationChaincodes.Result["+ i +"].ChaincodeId");
				organizationChaincode.EndorsePolicy = context.StringValue("DescribeOrgnaizationChaincodes.Result["+ i +"].EndorsePolicy");
				organizationChaincode.State = context.StringValue("DescribeOrgnaizationChaincodes.Result["+ i +"].State");
				organizationChaincode.Installed = context.StringValue("DescribeOrgnaizationChaincodes.Result["+ i +"].Installed");
				organizationChaincode.Message = context.StringValue("DescribeOrgnaizationChaincodes.Result["+ i +"].Message");

				describeOrgnaizationChaincodesResponse_result.Add(organizationChaincode);
			}
			describeOrgnaizationChaincodesResponse.Result = describeOrgnaizationChaincodesResponse_result;
        
			return describeOrgnaizationChaincodesResponse;
        }
    }
}