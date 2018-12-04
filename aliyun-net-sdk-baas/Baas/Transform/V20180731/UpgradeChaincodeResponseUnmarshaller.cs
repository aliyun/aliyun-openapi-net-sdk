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
    public class UpgradeChaincodeResponseUnmarshaller
    {
        public static UpgradeChaincodeResponse Unmarshall(UnmarshallerContext context)
        {
			UpgradeChaincodeResponse upgradeChaincodeResponse = new UpgradeChaincodeResponse();

			upgradeChaincodeResponse.HttpResponse = context.HttpResponse;
			upgradeChaincodeResponse.RequestId = context.StringValue("UpgradeChaincode.RequestId");
			upgradeChaincodeResponse.Success = context.BooleanValue("UpgradeChaincode.Success");
			upgradeChaincodeResponse.ErrorCode = context.IntegerValue("UpgradeChaincode.ErrorCode");

			UpgradeChaincodeResponse.UpgradeChaincode_Result result = new UpgradeChaincodeResponse.UpgradeChaincode_Result();
			result.Name = context.StringValue("UpgradeChaincode.Result.Name");
			result.Version = context.StringValue("UpgradeChaincode.Result.Version");
			result.Input = context.StringValue("UpgradeChaincode.Result.Input");
			result.Type = context.IntegerValue("UpgradeChaincode.Result.Type");
			result.State = context.StringValue("UpgradeChaincode.Result.State");
			result.Path = context.StringValue("UpgradeChaincode.Result.Path");
			result.ChaincodeId = context.StringValue("UpgradeChaincode.Result.ChaincodeId");
			result.Install = context.BooleanValue("UpgradeChaincode.Result.Install");
			result.Message = context.StringValue("UpgradeChaincode.Result.Message");
			result.CreateTime = context.StringValue("UpgradeChaincode.Result.CreateTime");
			result.DeployTime = context.StringValue("UpgradeChaincode.Result.DeployTime");
			result.ChannelName = context.StringValue("UpgradeChaincode.Result.ChannelName");
			result.EndorsePolicy = context.StringValue("UpgradeChaincode.Result.EndorsePolicy");
			result.ConsortiumId = context.StringValue("UpgradeChaincode.Result.ConsortiumId");
			result.ProviderId = context.StringValue("UpgradeChaincode.Result.ProviderId");
			result.ProviderName = context.StringValue("UpgradeChaincode.Result.ProviderName");
			upgradeChaincodeResponse.Result = result;
        
			return upgradeChaincodeResponse;
        }
    }
}