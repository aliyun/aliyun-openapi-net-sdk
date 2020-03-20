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
        public static GetStackInstanceResponse Unmarshall(UnmarshallerContext context)
        {
			GetStackInstanceResponse getStackInstanceResponse = new GetStackInstanceResponse();

			getStackInstanceResponse.HttpResponse = context.HttpResponse;
			getStackInstanceResponse.RequestId = context.StringValue("GetStackInstance.RequestId");

			GetStackInstanceResponse.GetStackInstance_StackInstance stackInstance = new GetStackInstanceResponse.GetStackInstance_StackInstance();
			stackInstance.StackGroupName = context.StringValue("GetStackInstance.StackInstance.StackGroupName");
			stackInstance.StackGroupId = context.StringValue("GetStackInstance.StackInstance.StackGroupId");
			stackInstance.StackId = context.StringValue("GetStackInstance.StackInstance.StackId");
			stackInstance.AccountId = context.StringValue("GetStackInstance.StackInstance.AccountId");
			stackInstance.RegionId = context.StringValue("GetStackInstance.StackInstance.RegionId");
			stackInstance.Status = context.StringValue("GetStackInstance.StackInstance.Status");
			stackInstance.StatusReason = context.StringValue("GetStackInstance.StackInstance.StatusReason");
			stackInstance.StackDriftStatus = context.StringValue("GetStackInstance.StackInstance.StackDriftStatus");
			stackInstance.DriftDetectionTime = context.StringValue("GetStackInstance.StackInstance.DriftDetectionTime");

			List<GetStackInstanceResponse.GetStackInstance_StackInstance.GetStackInstance_ParameterOverride> stackInstance_parameterOverrides = new List<GetStackInstanceResponse.GetStackInstance_StackInstance.GetStackInstance_ParameterOverride>();
			for (int i = 0; i < context.Length("GetStackInstance.StackInstance.ParameterOverrides.Length"); i++) {
				GetStackInstanceResponse.GetStackInstance_StackInstance.GetStackInstance_ParameterOverride parameterOverride = new GetStackInstanceResponse.GetStackInstance_StackInstance.GetStackInstance_ParameterOverride();
				parameterOverride.ParameterKey = context.StringValue("GetStackInstance.StackInstance.ParameterOverrides["+ i +"].ParameterKey");
				parameterOverride.ParameterValue = context.StringValue("GetStackInstance.StackInstance.ParameterOverrides["+ i +"].ParameterValue");

				stackInstance_parameterOverrides.Add(parameterOverride);
			}
			stackInstance.ParameterOverrides = stackInstance_parameterOverrides;
			getStackInstanceResponse.StackInstance = stackInstance;
        
			return getStackInstanceResponse;
        }
    }
}
