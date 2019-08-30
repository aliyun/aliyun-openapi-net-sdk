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
    public class UpdateInstanceResponseUnmarshaller
    {
        public static UpdateInstanceResponse Unmarshall(UnmarshallerContext context)
        {
			UpdateInstanceResponse updateInstanceResponse = new UpdateInstanceResponse();

			updateInstanceResponse.HttpResponse = context.HttpResponse;
			updateInstanceResponse.RequestId = context.StringValue("UpdateInstance.RequestId");

			UpdateInstanceResponse.UpdateInstance_Result result = new UpdateInstanceResponse.UpdateInstance_Result();
			result.InstanceId = context.StringValue("UpdateInstance.Result.InstanceId");
			result.Domain = context.StringValue("UpdateInstance.Result.Domain");
			result.Description = context.StringValue("UpdateInstance.Result.Description");
			result.NodeAmount = context.IntegerValue("UpdateInstance.Result.NodeAmount");
			result.PaymentType = context.StringValue("UpdateInstance.Result.PaymentType");
			result.Status = context.StringValue("UpdateInstance.Result.Status");
			result.EsVersion = context.StringValue("UpdateInstance.Result.EsVersion");
			result.CreatedAt = context.StringValue("UpdateInstance.Result.CreatedAt");
			result.UpdatedAt = context.StringValue("UpdateInstance.Result.UpdatedAt");

			UpdateInstanceResponse.UpdateInstance_Result.UpdateInstance_NodeSpec nodeSpec = new UpdateInstanceResponse.UpdateInstance_Result.UpdateInstance_NodeSpec();
			nodeSpec.Spec = context.StringValue("UpdateInstance.Result.NodeSpec.Spec");
			nodeSpec.Disk = context.IntegerValue("UpdateInstance.Result.NodeSpec.Disk");
			result.NodeSpec = nodeSpec;

			UpdateInstanceResponse.UpdateInstance_Result.UpdateInstance_NetworkConfig networkConfig = new UpdateInstanceResponse.UpdateInstance_Result.UpdateInstance_NetworkConfig();
			networkConfig.Type = context.StringValue("UpdateInstance.Result.NetworkConfig.Type");
			networkConfig.VpcId = context.StringValue("UpdateInstance.Result.NetworkConfig.VpcId");
			networkConfig.VswitchId = context.StringValue("UpdateInstance.Result.NetworkConfig.VswitchId");
			networkConfig.VsArea = context.StringValue("UpdateInstance.Result.NetworkConfig.VsArea");
			result.NetworkConfig = networkConfig;
			updateInstanceResponse.Result = result;
        
			return updateInstanceResponse;
        }
    }
}
