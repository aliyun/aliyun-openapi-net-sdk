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
    public class InstantiateChaincodeResponseUnmarshaller
    {
        public static InstantiateChaincodeResponse Unmarshall(UnmarshallerContext context)
        {
			InstantiateChaincodeResponse instantiateChaincodeResponse = new InstantiateChaincodeResponse();

			instantiateChaincodeResponse.HttpResponse = context.HttpResponse;
			instantiateChaincodeResponse.RequestId = context.StringValue("InstantiateChaincode.RequestId");
			instantiateChaincodeResponse.Success = context.BooleanValue("InstantiateChaincode.Success");
			instantiateChaincodeResponse.ErrorCode = context.IntegerValue("InstantiateChaincode.ErrorCode");

			InstantiateChaincodeResponse.InstantiateChaincode_Result result = new InstantiateChaincodeResponse.InstantiateChaincode_Result();
			result.Name = context.StringValue("InstantiateChaincode.Result.Name");
			result.Version = context.StringValue("InstantiateChaincode.Result.Version");
			result.Input = context.StringValue("InstantiateChaincode.Result.Input");
			result.Type = context.IntegerValue("InstantiateChaincode.Result.Type");
			result.State = context.StringValue("InstantiateChaincode.Result.State");
			result.Path = context.StringValue("InstantiateChaincode.Result.Path");
			result.ChaincodeId = context.StringValue("InstantiateChaincode.Result.ChaincodeId");
			result.Install = context.BooleanValue("InstantiateChaincode.Result.Install");
			result.Message = context.StringValue("InstantiateChaincode.Result.Message");
			result.CreateTime = context.StringValue("InstantiateChaincode.Result.CreateTime");
			result.DeployTime = context.StringValue("InstantiateChaincode.Result.DeployTime");
			result.ChannelName = context.StringValue("InstantiateChaincode.Result.ChannelName");
			result.EndorsePolicy = context.StringValue("InstantiateChaincode.Result.EndorsePolicy");
			result.ConsortiumId = context.StringValue("InstantiateChaincode.Result.ConsortiumId");
			result.ProviderId = context.StringValue("InstantiateChaincode.Result.ProviderId");
			result.ProviderName = context.StringValue("InstantiateChaincode.Result.ProviderName");
			instantiateChaincodeResponse.Result = result;
        
			return instantiateChaincodeResponse;
        }
    }
}