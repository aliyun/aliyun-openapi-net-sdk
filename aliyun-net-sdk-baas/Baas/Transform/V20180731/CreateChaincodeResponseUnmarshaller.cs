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
    public class CreateChaincodeResponseUnmarshaller
    {
        public static CreateChaincodeResponse Unmarshall(UnmarshallerContext context)
        {
			CreateChaincodeResponse createChaincodeResponse = new CreateChaincodeResponse();

			createChaincodeResponse.HttpResponse = context.HttpResponse;
			createChaincodeResponse.RequestId = context.StringValue("CreateChaincode.RequestId");
			createChaincodeResponse.Success = context.BooleanValue("CreateChaincode.Success");
			createChaincodeResponse.ErrorCode = context.IntegerValue("CreateChaincode.ErrorCode");

			CreateChaincodeResponse.CreateChaincode_Result result = new CreateChaincodeResponse.CreateChaincode_Result();
			result.Name = context.StringValue("CreateChaincode.Result.Name");
			result.Version = context.StringValue("CreateChaincode.Result.Version");
			result.Input = context.StringValue("CreateChaincode.Result.Input");
			result.Type = context.IntegerValue("CreateChaincode.Result.Type");
			result.State = context.StringValue("CreateChaincode.Result.State");
			result.Path = context.StringValue("CreateChaincode.Result.Path");
			result.ChaincodeId = context.StringValue("CreateChaincode.Result.ChaincodeId");
			result.Install = context.BooleanValue("CreateChaincode.Result.Install");
			result.Message = context.StringValue("CreateChaincode.Result.Message");
			result.CreateTime = context.StringValue("CreateChaincode.Result.CreateTime");
			result.DeployTime = context.StringValue("CreateChaincode.Result.DeployTime");
			result.ChannelName = context.StringValue("CreateChaincode.Result.ChannelName");
			result.EndorsePolicy = context.StringValue("CreateChaincode.Result.EndorsePolicy");
			result.ConsortiumId = context.StringValue("CreateChaincode.Result.ConsortiumId");
			result.ProviderId = context.StringValue("CreateChaincode.Result.ProviderId");
			result.ProviderName = context.StringValue("CreateChaincode.Result.ProviderName");
			createChaincodeResponse.Result = result;
        
			return createChaincodeResponse;
        }
    }
}