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
using Aliyun.Acs.ROS.Model.V20190910;

namespace Aliyun.Acs.ROS.Transform.V20190910
{
    public class GetStackInstanceResponseUnmarshaller
    {
        public static GetStackInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetStackInstanceResponse getStackInstanceResponse = new GetStackInstanceResponse();

			getStackInstanceResponse.HttpResponse = _ctx.HttpResponse;
			getStackInstanceResponse.RequestId = _ctx.StringValue("GetStackInstance.RequestId");

			GetStackInstanceResponse.GetStackInstance_StackInstance stackInstance = new GetStackInstanceResponse.GetStackInstance_StackInstance();
			stackInstance.StackGroupName = _ctx.StringValue("GetStackInstance.StackInstance.StackGroupName");
			stackInstance.StackGroupId = _ctx.StringValue("GetStackInstance.StackInstance.StackGroupId");
			stackInstance.StackId = _ctx.StringValue("GetStackInstance.StackInstance.StackId");
			stackInstance.AccountId = _ctx.StringValue("GetStackInstance.StackInstance.AccountId");
			stackInstance.RegionId = _ctx.StringValue("GetStackInstance.StackInstance.RegionId");
			stackInstance.Status = _ctx.StringValue("GetStackInstance.StackInstance.Status");
			stackInstance.StatusReason = _ctx.StringValue("GetStackInstance.StackInstance.StatusReason");
			stackInstance.StackDriftStatus = _ctx.StringValue("GetStackInstance.StackInstance.StackDriftStatus");
			stackInstance.DriftDetectionTime = _ctx.StringValue("GetStackInstance.StackInstance.DriftDetectionTime");

			List<GetStackInstanceResponse.GetStackInstance_StackInstance.GetStackInstance_ParameterOverride> stackInstance_parameterOverrides = new List<GetStackInstanceResponse.GetStackInstance_StackInstance.GetStackInstance_ParameterOverride>();
			for (int i = 0; i < _ctx.Length("GetStackInstance.StackInstance.ParameterOverrides.Length"); i++) {
				GetStackInstanceResponse.GetStackInstance_StackInstance.GetStackInstance_ParameterOverride parameterOverride = new GetStackInstanceResponse.GetStackInstance_StackInstance.GetStackInstance_ParameterOverride();
				parameterOverride.ParameterKey = _ctx.StringValue("GetStackInstance.StackInstance.ParameterOverrides["+ i +"].ParameterKey");
				parameterOverride.ParameterValue = _ctx.StringValue("GetStackInstance.StackInstance.ParameterOverrides["+ i +"].ParameterValue");

				stackInstance_parameterOverrides.Add(parameterOverride);
			}
			stackInstance.ParameterOverrides = stackInstance_parameterOverrides;
			getStackInstanceResponse.StackInstance = stackInstance;
        
			return getStackInstanceResponse;
        }
    }
}
