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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.elasticsearch.Model.V20170613;

namespace Aliyun.Acs.elasticsearch.Transform.V20170613
{
    public class RollbackInstanceResponseUnmarshaller
    {
        public static RollbackInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RollbackInstanceResponse rollbackInstanceResponse = new RollbackInstanceResponse();

			rollbackInstanceResponse.HttpResponse = _ctx.HttpResponse;
			rollbackInstanceResponse.RequestId = _ctx.StringValue("RollbackInstance.RequestId");

			RollbackInstanceResponse.RollbackInstance_Result result = new RollbackInstanceResponse.RollbackInstance_Result();
			result.InstanceId = _ctx.StringValue("RollbackInstance.Result.instanceId");
			result.Domain = _ctx.StringValue("RollbackInstance.Result.domain");
			result.Description = _ctx.StringValue("RollbackInstance.Result.description");
			result.NodeAmount = _ctx.IntegerValue("RollbackInstance.Result.nodeAmount");
			result.PaymentType = _ctx.StringValue("RollbackInstance.Result.paymentType");
			result.Status = _ctx.StringValue("RollbackInstance.Result.status");
			result.EsVersion = _ctx.StringValue("RollbackInstance.Result.esVersion");
			result.CreatedAt = _ctx.StringValue("RollbackInstance.Result.createdAt");
			result.UpdatedAt = _ctx.StringValue("RollbackInstance.Result.updatedAt");

			RollbackInstanceResponse.RollbackInstance_Result.RollbackInstance_NodeSpec nodeSpec = new RollbackInstanceResponse.RollbackInstance_Result.RollbackInstance_NodeSpec();
			nodeSpec.Spec = _ctx.StringValue("RollbackInstance.Result.NodeSpec.spec");
			nodeSpec.Disk = _ctx.IntegerValue("RollbackInstance.Result.NodeSpec.disk");
			result.NodeSpec = nodeSpec;

			RollbackInstanceResponse.RollbackInstance_Result.RollbackInstance_NetworkConfig networkConfig = new RollbackInstanceResponse.RollbackInstance_Result.RollbackInstance_NetworkConfig();
			networkConfig.Type = _ctx.StringValue("RollbackInstance.Result.NetworkConfig.type");
			networkConfig.VpcId = _ctx.StringValue("RollbackInstance.Result.NetworkConfig.vpcId");
			networkConfig.VswitchId = _ctx.StringValue("RollbackInstance.Result.NetworkConfig.vswitchId");
			networkConfig.VsArea = _ctx.StringValue("RollbackInstance.Result.NetworkConfig.vsArea");
			result.NetworkConfig = networkConfig;
			rollbackInstanceResponse.Result = result;
        
			return rollbackInstanceResponse;
        }
    }
}
