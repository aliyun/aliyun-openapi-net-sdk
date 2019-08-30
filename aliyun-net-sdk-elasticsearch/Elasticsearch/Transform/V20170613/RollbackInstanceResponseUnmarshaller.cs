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
        public static RollbackInstanceResponse Unmarshall(UnmarshallerContext context)
        {
			RollbackInstanceResponse rollbackInstanceResponse = new RollbackInstanceResponse();

			rollbackInstanceResponse.HttpResponse = context.HttpResponse;
			rollbackInstanceResponse.RequestId = context.StringValue("RollbackInstance.RequestId");

			RollbackInstanceResponse.RollbackInstance_Result result = new RollbackInstanceResponse.RollbackInstance_Result();
			result.InstanceId = context.StringValue("RollbackInstance.Result.InstanceId");
			result.Domain = context.StringValue("RollbackInstance.Result.Domain");
			result.Description = context.StringValue("RollbackInstance.Result.Description");
			result.NodeAmount = context.IntegerValue("RollbackInstance.Result.NodeAmount");
			result.PaymentType = context.StringValue("RollbackInstance.Result.PaymentType");
			result.Status = context.StringValue("RollbackInstance.Result.Status");
			result.EsVersion = context.StringValue("RollbackInstance.Result.EsVersion");
			result.CreatedAt = context.StringValue("RollbackInstance.Result.CreatedAt");
			result.UpdatedAt = context.StringValue("RollbackInstance.Result.UpdatedAt");

			RollbackInstanceResponse.RollbackInstance_Result.RollbackInstance_NodeSpec nodeSpec = new RollbackInstanceResponse.RollbackInstance_Result.RollbackInstance_NodeSpec();
			nodeSpec.Spec = context.StringValue("RollbackInstance.Result.NodeSpec.Spec");
			nodeSpec.Disk = context.IntegerValue("RollbackInstance.Result.NodeSpec.Disk");
			result.NodeSpec = nodeSpec;

			RollbackInstanceResponse.RollbackInstance_Result.RollbackInstance_NetworkConfig networkConfig = new RollbackInstanceResponse.RollbackInstance_Result.RollbackInstance_NetworkConfig();
			networkConfig.Type = context.StringValue("RollbackInstance.Result.NetworkConfig.Type");
			networkConfig.VpcId = context.StringValue("RollbackInstance.Result.NetworkConfig.VpcId");
			networkConfig.VswitchId = context.StringValue("RollbackInstance.Result.NetworkConfig.VswitchId");
			networkConfig.VsArea = context.StringValue("RollbackInstance.Result.NetworkConfig.VsArea");
			result.NetworkConfig = networkConfig;
			rollbackInstanceResponse.Result = result;
        
			return rollbackInstanceResponse;
        }
    }
}
