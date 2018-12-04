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
    public class InstallChaincodeResponseUnmarshaller
    {
        public static InstallChaincodeResponse Unmarshall(UnmarshallerContext context)
        {
			InstallChaincodeResponse installChaincodeResponse = new InstallChaincodeResponse();

			installChaincodeResponse.HttpResponse = context.HttpResponse;
			installChaincodeResponse.RequestId = context.StringValue("InstallChaincode.RequestId");
			installChaincodeResponse.Success = context.BooleanValue("InstallChaincode.Success");
			installChaincodeResponse.ErrorCode = context.IntegerValue("InstallChaincode.ErrorCode");

			InstallChaincodeResponse.InstallChaincode_Result result = new InstallChaincodeResponse.InstallChaincode_Result();
			result.Name = context.StringValue("InstallChaincode.Result.Name");
			result.Version = context.StringValue("InstallChaincode.Result.Version");
			result.Input = context.StringValue("InstallChaincode.Result.Input");
			result.Type = context.IntegerValue("InstallChaincode.Result.Type");
			result.State = context.StringValue("InstallChaincode.Result.State");
			result.Path = context.StringValue("InstallChaincode.Result.Path");
			result.ChaincodeId = context.StringValue("InstallChaincode.Result.ChaincodeId");
			result.Install = context.BooleanValue("InstallChaincode.Result.Install");
			result.Message = context.StringValue("InstallChaincode.Result.Message");
			result.CreateTime = context.StringValue("InstallChaincode.Result.CreateTime");
			result.DeployTime = context.StringValue("InstallChaincode.Result.DeployTime");
			result.ChannelName = context.StringValue("InstallChaincode.Result.ChannelName");
			result.EndorsePolicy = context.StringValue("InstallChaincode.Result.EndorsePolicy");
			result.ConsortiumId = context.StringValue("InstallChaincode.Result.ConsortiumId");
			result.ProviderId = context.StringValue("InstallChaincode.Result.ProviderId");
			result.ProviderName = context.StringValue("InstallChaincode.Result.ProviderName");
			installChaincodeResponse.Result = result;
        
			return installChaincodeResponse;
        }
    }
}