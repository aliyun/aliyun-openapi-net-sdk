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
    public class GetStackGroupResponseUnmarshaller
    {
        public static GetStackGroupResponse Unmarshall(UnmarshallerContext context)
        {
			GetStackGroupResponse getStackGroupResponse = new GetStackGroupResponse();

			getStackGroupResponse.HttpResponse = context.HttpResponse;
			getStackGroupResponse.RequestId = context.StringValue("GetStackGroup.RequestId");

			GetStackGroupResponse.GetStackGroup_StackGroup stackGroup = new GetStackGroupResponse.GetStackGroup_StackGroup();
			stackGroup.StackGroupName = context.StringValue("GetStackGroup.StackGroup.StackGroupName");
			stackGroup.StackGroupId = context.StringValue("GetStackGroup.StackGroup.StackGroupId");
			stackGroup.Status = context.StringValue("GetStackGroup.StackGroup.Status");
			stackGroup.Description = context.StringValue("GetStackGroup.StackGroup.Description");
			stackGroup.TemplateBody = context.StringValue("GetStackGroup.StackGroup.TemplateBody");
			stackGroup.ExecutionRoleName = context.StringValue("GetStackGroup.StackGroup.ExecutionRoleName");
			stackGroup.AdministrationRoleName = context.StringValue("GetStackGroup.StackGroup.AdministrationRoleName");

			GetStackGroupResponse.GetStackGroup_StackGroup.GetStackGroup_StackGroupDriftDetectionDetail stackGroupDriftDetectionDetail = new GetStackGroupResponse.GetStackGroup_StackGroup.GetStackGroup_StackGroupDriftDetectionDetail();
			stackGroupDriftDetectionDetail.DriftDetectionTime = context.StringValue("GetStackGroup.StackGroup.StackGroupDriftDetectionDetail.DriftDetectionTime");
			stackGroupDriftDetectionDetail.StackGroupDriftStatus = context.StringValue("GetStackGroup.StackGroup.StackGroupDriftDetectionDetail.StackGroupDriftStatus");
			stackGroupDriftDetectionDetail.DriftDetectionStatus = context.StringValue("GetStackGroup.StackGroup.StackGroupDriftDetectionDetail.DriftDetectionStatus");
			stackGroupDriftDetectionDetail.DriftedStackInstancesCount = context.IntegerValue("GetStackGroup.StackGroup.StackGroupDriftDetectionDetail.DriftedStackInstancesCount");
			stackGroupDriftDetectionDetail.FailedStackInstancesCount = context.IntegerValue("GetStackGroup.StackGroup.StackGroupDriftDetectionDetail.FailedStackInstancesCount");
			stackGroupDriftDetectionDetail.CancelledStackInstancesCount = context.IntegerValue("GetStackGroup.StackGroup.StackGroupDriftDetectionDetail.CancelledStackInstancesCount");
			stackGroupDriftDetectionDetail.InProgressStackInstancesCount = context.IntegerValue("GetStackGroup.StackGroup.StackGroupDriftDetectionDetail.InProgressStackInstancesCount");
			stackGroupDriftDetectionDetail.InSyncStackInstancesCount = context.IntegerValue("GetStackGroup.StackGroup.StackGroupDriftDetectionDetail.InSyncStackInstancesCount");
			stackGroupDriftDetectionDetail.TotalStackInstancesCount = context.IntegerValue("GetStackGroup.StackGroup.StackGroupDriftDetectionDetail.TotalStackInstancesCount");
			stackGroup.StackGroupDriftDetectionDetail = stackGroupDriftDetectionDetail;

			List<GetStackGroupResponse.GetStackGroup_StackGroup.GetStackGroup_Parameter> stackGroup_parameters = new List<GetStackGroupResponse.GetStackGroup_StackGroup.GetStackGroup_Parameter>();
			for (int i = 0; i < context.Length("GetStackGroup.StackGroup.Parameters.Length"); i++) {
				GetStackGroupResponse.GetStackGroup_StackGroup.GetStackGroup_Parameter parameter = new GetStackGroupResponse.GetStackGroup_StackGroup.GetStackGroup_Parameter();
				parameter.ParameterKey = context.StringValue("GetStackGroup.StackGroup.Parameters["+ i +"].ParameterKey");
				parameter.ParameterValue = context.StringValue("GetStackGroup.StackGroup.Parameters["+ i +"].ParameterValue");

				stackGroup_parameters.Add(parameter);
			}
			stackGroup.Parameters = stackGroup_parameters;
			getStackGroupResponse.StackGroup = stackGroup;
        
			return getStackGroupResponse;
        }
    }
}
