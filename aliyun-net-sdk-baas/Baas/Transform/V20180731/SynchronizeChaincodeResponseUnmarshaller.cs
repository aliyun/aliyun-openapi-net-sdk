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
    public class SynchronizeChaincodeResponseUnmarshaller
    {
        public static SynchronizeChaincodeResponse Unmarshall(UnmarshallerContext context)
        {
			SynchronizeChaincodeResponse synchronizeChaincodeResponse = new SynchronizeChaincodeResponse();

			synchronizeChaincodeResponse.HttpResponse = context.HttpResponse;
			synchronizeChaincodeResponse.RequestId = context.StringValue("SynchronizeChaincode.RequestId");
			synchronizeChaincodeResponse.Success = context.BooleanValue("SynchronizeChaincode.Success");
			synchronizeChaincodeResponse.ErrorCode = context.IntegerValue("SynchronizeChaincode.ErrorCode");

			SynchronizeChaincodeResponse.SynchronizeChaincode_Result result = new SynchronizeChaincodeResponse.SynchronizeChaincode_Result();
			result.Name = context.StringValue("SynchronizeChaincode.Result.Name");
			result.Version = context.StringValue("SynchronizeChaincode.Result.Version");
			result.Input = context.StringValue("SynchronizeChaincode.Result.Input");
			result.Type = context.IntegerValue("SynchronizeChaincode.Result.Type");
			result.State = context.StringValue("SynchronizeChaincode.Result.State");
			result.Path = context.StringValue("SynchronizeChaincode.Result.Path");
			result.ChaincodeId = context.StringValue("SynchronizeChaincode.Result.ChaincodeId");
			result.Install = context.BooleanValue("SynchronizeChaincode.Result.Install");
			result.Message = context.StringValue("SynchronizeChaincode.Result.Message");
			result.CreateTime = context.StringValue("SynchronizeChaincode.Result.CreateTime");
			result.DeployTime = context.StringValue("SynchronizeChaincode.Result.DeployTime");
			result.ChannelName = context.StringValue("SynchronizeChaincode.Result.ChannelName");
			result.EndorsePolicy = context.StringValue("SynchronizeChaincode.Result.EndorsePolicy");
			result.ConsortiumId = context.StringValue("SynchronizeChaincode.Result.ConsortiumId");
			result.ProviderId = context.StringValue("SynchronizeChaincode.Result.ProviderId");
			result.ProviderName = context.StringValue("SynchronizeChaincode.Result.ProviderName");
			synchronizeChaincodeResponse.Result = result;
        
			return synchronizeChaincodeResponse;
        }
    }
}