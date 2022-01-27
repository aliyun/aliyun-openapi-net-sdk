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
        public static GetStackGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetStackGroupResponse getStackGroupResponse = new GetStackGroupResponse();

			getStackGroupResponse.HttpResponse = _ctx.HttpResponse;
			getStackGroupResponse.RequestId = _ctx.StringValue("GetStackGroup.RequestId");

			GetStackGroupResponse.GetStackGroup_StackGroup stackGroup = new GetStackGroupResponse.GetStackGroup_StackGroup();
			stackGroup.StackGroupName = _ctx.StringValue("GetStackGroup.StackGroup.StackGroupName");
			stackGroup.StackGroupId = _ctx.StringValue("GetStackGroup.StackGroup.StackGroupId");
			stackGroup.Status = _ctx.StringValue("GetStackGroup.StackGroup.Status");
			stackGroup.Description = _ctx.StringValue("GetStackGroup.StackGroup.Description");
			stackGroup.TemplateBody = _ctx.StringValue("GetStackGroup.StackGroup.TemplateBody");
			stackGroup.ExecutionRoleName = _ctx.StringValue("GetStackGroup.StackGroup.ExecutionRoleName");
			stackGroup.AdministrationRoleName = _ctx.StringValue("GetStackGroup.StackGroup.AdministrationRoleName");

			GetStackGroupResponse.GetStackGroup_StackGroup.GetStackGroup_StackGroupDriftDetectionDetail stackGroupDriftDetectionDetail = new GetStackGroupResponse.GetStackGroup_StackGroup.GetStackGroup_StackGroupDriftDetectionDetail();
			stackGroupDriftDetectionDetail.DriftDetectionTime = _ctx.StringValue("GetStackGroup.StackGroup.StackGroupDriftDetectionDetail.DriftDetectionTime");
			stackGroupDriftDetectionDetail.StackGroupDriftStatus = _ctx.StringValue("GetStackGroup.StackGroup.StackGroupDriftDetectionDetail.StackGroupDriftStatus");
			stackGroupDriftDetectionDetail.DriftDetectionStatus = _ctx.StringValue("GetStackGroup.StackGroup.StackGroupDriftDetectionDetail.DriftDetectionStatus");
			stackGroupDriftDetectionDetail.DriftedStackInstancesCount = _ctx.IntegerValue("GetStackGroup.StackGroup.StackGroupDriftDetectionDetail.DriftedStackInstancesCount");
			stackGroupDriftDetectionDetail.FailedStackInstancesCount = _ctx.IntegerValue("GetStackGroup.StackGroup.StackGroupDriftDetectionDetail.FailedStackInstancesCount");
			stackGroupDriftDetectionDetail.CancelledStackInstancesCount = _ctx.IntegerValue("GetStackGroup.StackGroup.StackGroupDriftDetectionDetail.CancelledStackInstancesCount");
			stackGroupDriftDetectionDetail.InProgressStackInstancesCount = _ctx.IntegerValue("GetStackGroup.StackGroup.StackGroupDriftDetectionDetail.InProgressStackInstancesCount");
			stackGroupDriftDetectionDetail.InSyncStackInstancesCount = _ctx.IntegerValue("GetStackGroup.StackGroup.StackGroupDriftDetectionDetail.InSyncStackInstancesCount");
			stackGroupDriftDetectionDetail.TotalStackInstancesCount = _ctx.IntegerValue("GetStackGroup.StackGroup.StackGroupDriftDetectionDetail.TotalStackInstancesCount");
			stackGroup.StackGroupDriftDetectionDetail = stackGroupDriftDetectionDetail;

			List<GetStackGroupResponse.GetStackGroup_StackGroup.GetStackGroup_Parameter> stackGroup_parameters = new List<GetStackGroupResponse.GetStackGroup_StackGroup.GetStackGroup_Parameter>();
			for (int i = 0; i < _ctx.Length("GetStackGroup.StackGroup.Parameters.Length"); i++) {
				GetStackGroupResponse.GetStackGroup_StackGroup.GetStackGroup_Parameter parameter = new GetStackGroupResponse.GetStackGroup_StackGroup.GetStackGroup_Parameter();
				parameter.ParameterKey = _ctx.StringValue("GetStackGroup.StackGroup.Parameters["+ i +"].ParameterKey");
				parameter.ParameterValue = _ctx.StringValue("GetStackGroup.StackGroup.Parameters["+ i +"].ParameterValue");

				stackGroup_parameters.Add(parameter);
			}
			stackGroup.Parameters = stackGroup_parameters;
			getStackGroupResponse.StackGroup = stackGroup;
        
			return getStackGroupResponse;
        }
    }
}
