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
    public class DescribeOrganizationChaincodesResponseUnmarshaller
    {
        public static DescribeOrganizationChaincodesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeOrganizationChaincodesResponse describeOrganizationChaincodesResponse = new DescribeOrganizationChaincodesResponse();

			describeOrganizationChaincodesResponse.HttpResponse = context.HttpResponse;
			describeOrganizationChaincodesResponse.RequestId = context.StringValue("DescribeOrganizationChaincodes.RequestId");
			describeOrganizationChaincodesResponse.Success = context.BooleanValue("DescribeOrganizationChaincodes.Success");
			describeOrganizationChaincodesResponse.ErrorCode = context.IntegerValue("DescribeOrganizationChaincodes.ErrorCode");

			List<DescribeOrganizationChaincodesResponse.DescribeOrganizationChaincodes_OrganizationChaincode> describeOrganizationChaincodesResponse_result = new List<DescribeOrganizationChaincodesResponse.DescribeOrganizationChaincodes_OrganizationChaincode>();
			for (int i = 0; i < context.Length("DescribeOrganizationChaincodes.Result.Length"); i++) {
				DescribeOrganizationChaincodesResponse.DescribeOrganizationChaincodes_OrganizationChaincode organizationChaincode = new DescribeOrganizationChaincodesResponse.DescribeOrganizationChaincodes_OrganizationChaincode();
				organizationChaincode.Name = context.StringValue("DescribeOrganizationChaincodes.Result["+ i +"].Name");
				organizationChaincode.Version = context.StringValue("DescribeOrganizationChaincodes.Result["+ i +"].Version");
				organizationChaincode.Creator = context.StringValue("DescribeOrganizationChaincodes.Result["+ i +"].Creator");
				organizationChaincode.ChannelId = context.StringValue("DescribeOrganizationChaincodes.Result["+ i +"].ChannelId");
				organizationChaincode.ChannelName = context.StringValue("DescribeOrganizationChaincodes.Result["+ i +"].ChannelName");
				organizationChaincode.CreateTime = context.StringValue("DescribeOrganizationChaincodes.Result["+ i +"].CreateTime");
				organizationChaincode.DeployTime = context.StringValue("DescribeOrganizationChaincodes.Result["+ i +"].DeployTime");
				organizationChaincode.ChaincodeId = context.StringValue("DescribeOrganizationChaincodes.Result["+ i +"].ChaincodeId");
				organizationChaincode.EndorsePolicy = context.StringValue("DescribeOrganizationChaincodes.Result["+ i +"].EndorsePolicy");
				organizationChaincode.State = context.StringValue("DescribeOrganizationChaincodes.Result["+ i +"].State");
				organizationChaincode.Installed = context.StringValue("DescribeOrganizationChaincodes.Result["+ i +"].Installed");
				organizationChaincode.Message = context.StringValue("DescribeOrganizationChaincodes.Result["+ i +"].Message");
				organizationChaincode.ConsortiumId = context.StringValue("DescribeOrganizationChaincodes.Result["+ i +"].ConsortiumId");

				describeOrganizationChaincodesResponse_result.Add(organizationChaincode);
			}
			describeOrganizationChaincodesResponse.Result = describeOrganizationChaincodesResponse_result;
        
			return describeOrganizationChaincodesResponse;
        }
    }
}