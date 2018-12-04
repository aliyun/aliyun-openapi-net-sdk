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
    public class DescribeConsortiumChaincodesResponseUnmarshaller
    {
        public static DescribeConsortiumChaincodesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeConsortiumChaincodesResponse describeConsortiumChaincodesResponse = new DescribeConsortiumChaincodesResponse();

			describeConsortiumChaincodesResponse.HttpResponse = context.HttpResponse;
			describeConsortiumChaincodesResponse.RequestId = context.StringValue("DescribeConsortiumChaincodes.RequestId");
			describeConsortiumChaincodesResponse.Success = context.BooleanValue("DescribeConsortiumChaincodes.Success");
			describeConsortiumChaincodesResponse.ErrorCode = context.IntegerValue("DescribeConsortiumChaincodes.ErrorCode");

			List<DescribeConsortiumChaincodesResponse.DescribeConsortiumChaincodes_ChaincodeVO> describeConsortiumChaincodesResponse_result = new List<DescribeConsortiumChaincodesResponse.DescribeConsortiumChaincodes_ChaincodeVO>();
			for (int i = 0; i < context.Length("DescribeConsortiumChaincodes.Result.Length"); i++) {
				DescribeConsortiumChaincodesResponse.DescribeConsortiumChaincodes_ChaincodeVO chaincodeVO = new DescribeConsortiumChaincodesResponse.DescribeConsortiumChaincodes_ChaincodeVO();
				chaincodeVO.Name = context.StringValue("DescribeConsortiumChaincodes.Result["+ i +"].Name");
				chaincodeVO.Version = context.StringValue("DescribeConsortiumChaincodes.Result["+ i +"].Version");
				chaincodeVO.Input = context.StringValue("DescribeConsortiumChaincodes.Result["+ i +"].Input");
				chaincodeVO.Type = context.IntegerValue("DescribeConsortiumChaincodes.Result["+ i +"].Type");
				chaincodeVO.State = context.StringValue("DescribeConsortiumChaincodes.Result["+ i +"].State");
				chaincodeVO.Path = context.StringValue("DescribeConsortiumChaincodes.Result["+ i +"].Path");
				chaincodeVO.ChaincodeId = context.StringValue("DescribeConsortiumChaincodes.Result["+ i +"].ChaincodeId");
				chaincodeVO.Install = context.BooleanValue("DescribeConsortiumChaincodes.Result["+ i +"].Install");
				chaincodeVO.Message = context.StringValue("DescribeConsortiumChaincodes.Result["+ i +"].Message");
				chaincodeVO.CreateTime = context.StringValue("DescribeConsortiumChaincodes.Result["+ i +"].CreateTime");
				chaincodeVO.DeployTime = context.StringValue("DescribeConsortiumChaincodes.Result["+ i +"].DeployTime");
				chaincodeVO.ChannelName = context.StringValue("DescribeConsortiumChaincodes.Result["+ i +"].ChannelName");
				chaincodeVO.EndorsePolicy = context.StringValue("DescribeConsortiumChaincodes.Result["+ i +"].EndorsePolicy");
				chaincodeVO.ConsortiumId = context.StringValue("DescribeConsortiumChaincodes.Result["+ i +"].ConsortiumId");
				chaincodeVO.ProviderId = context.StringValue("DescribeConsortiumChaincodes.Result["+ i +"].ProviderId");
				chaincodeVO.ProviderName = context.StringValue("DescribeConsortiumChaincodes.Result["+ i +"].ProviderName");
				chaincodeVO.ChannelId = context.StringValue("DescribeConsortiumChaincodes.Result["+ i +"].ChannelId");

				describeConsortiumChaincodesResponse_result.Add(chaincodeVO);
			}
			describeConsortiumChaincodesResponse.Result = describeConsortiumChaincodesResponse_result;
        
			return describeConsortiumChaincodesResponse;
        }
    }
}