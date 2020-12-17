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
    public class GetStackGroupOperationResponseUnmarshaller
    {
        public static GetStackGroupOperationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetStackGroupOperationResponse getStackGroupOperationResponse = new GetStackGroupOperationResponse();

			getStackGroupOperationResponse.HttpResponse = _ctx.HttpResponse;
			getStackGroupOperationResponse.RequestId = _ctx.StringValue("GetStackGroupOperation.RequestId");

			GetStackGroupOperationResponse.GetStackGroupOperation_StackGroupOperation stackGroupOperation = new GetStackGroupOperationResponse.GetStackGroupOperation_StackGroupOperation();
			stackGroupOperation.StackGroupName = _ctx.StringValue("GetStackGroupOperation.StackGroupOperation.StackGroupName");
			stackGroupOperation.StackGroupId = _ctx.StringValue("GetStackGroupOperation.StackGroupOperation.StackGroupId");
			stackGroupOperation.OperationId = _ctx.StringValue("GetStackGroupOperation.StackGroupOperation.OperationId");
			stackGroupOperation.OperationDescription = _ctx.StringValue("GetStackGroupOperation.StackGroupOperation.OperationDescription");
			stackGroupOperation.CreateTime = _ctx.StringValue("GetStackGroupOperation.StackGroupOperation.CreateTime");
			stackGroupOperation.EndTime = _ctx.StringValue("GetStackGroupOperation.StackGroupOperation.EndTime");
			stackGroupOperation.Action = _ctx.StringValue("GetStackGroupOperation.StackGroupOperation.Action");
			stackGroupOperation.Status = _ctx.StringValue("GetStackGroupOperation.StackGroupOperation.Status");
			stackGroupOperation.RetainStacks = _ctx.BooleanValue("GetStackGroupOperation.StackGroupOperation.RetainStacks");
			stackGroupOperation.AdministratorRoleName = _ctx.StringValue("GetStackGroupOperation.StackGroupOperation.AdministratorRoleName");
			stackGroupOperation.ExecutionRoleName = _ctx.StringValue("GetStackGroupOperation.StackGroupOperation.ExecutionRoleName");

			GetStackGroupOperationResponse.GetStackGroupOperation_StackGroupOperation.GetStackGroupOperation_OperationPreferences operationPreferences = new GetStackGroupOperationResponse.GetStackGroupOperation_StackGroupOperation.GetStackGroupOperation_OperationPreferences();
			operationPreferences.FailureToleranceCount = _ctx.IntegerValue("GetStackGroupOperation.StackGroupOperation.OperationPreferences.FailureToleranceCount");
			operationPreferences.FailureTolerancePercentage = _ctx.IntegerValue("GetStackGroupOperation.StackGroupOperation.OperationPreferences.FailureTolerancePercentage");
			operationPreferences.MaxConcurrentCount = _ctx.IntegerValue("GetStackGroupOperation.StackGroupOperation.OperationPreferences.MaxConcurrentCount");
			operationPreferences.MaxConcurrentPercentage = _ctx.IntegerValue("GetStackGroupOperation.StackGroupOperation.OperationPreferences.MaxConcurrentPercentage");

			List<string> operationPreferences_regionIdsOrder = new List<string>();
			for (int i = 0; i < _ctx.Length("GetStackGroupOperation.StackGroupOperation.OperationPreferences.RegionIdsOrder.Length"); i++) {
				operationPreferences_regionIdsOrder.Add(_ctx.StringValue("GetStackGroupOperation.StackGroupOperation.OperationPreferences.RegionIdsOrder["+ i +"]"));
			}
			operationPreferences.RegionIdsOrder = operationPreferences_regionIdsOrder;
			stackGroupOperation.OperationPreferences = operationPreferences;

			GetStackGroupOperationResponse.GetStackGroupOperation_StackGroupOperation.GetStackGroupOperation_StackGroupDriftDetectionDetail stackGroupDriftDetectionDetail = new GetStackGroupOperationResponse.GetStackGroupOperation_StackGroupOperation.GetStackGroupOperation_StackGroupDriftDetectionDetail();
			stackGroupDriftDetectionDetail.DriftDetectionTime = _ctx.StringValue("GetStackGroupOperation.StackGroupOperation.StackGroupDriftDetectionDetail.DriftDetectionTime");
			stackGroupDriftDetectionDetail.StackGroupDriftStatus = _ctx.StringValue("GetStackGroupOperation.StackGroupOperation.StackGroupDriftDetectionDetail.StackGroupDriftStatus");
			stackGroupDriftDetectionDetail.DriftDetectionStatus = _ctx.StringValue("GetStackGroupOperation.StackGroupOperation.StackGroupDriftDetectionDetail.DriftDetectionStatus");
			stackGroupDriftDetectionDetail.DriftedStackInstancesCount = _ctx.IntegerValue("GetStackGroupOperation.StackGroupOperation.StackGroupDriftDetectionDetail.DriftedStackInstancesCount");
			stackGroupDriftDetectionDetail.FailedStackInstancesCount = _ctx.IntegerValue("GetStackGroupOperation.StackGroupOperation.StackGroupDriftDetectionDetail.FailedStackInstancesCount");
			stackGroupDriftDetectionDetail.CancelledStackInstancesCount = _ctx.IntegerValue("GetStackGroupOperation.StackGroupOperation.StackGroupDriftDetectionDetail.CancelledStackInstancesCount");
			stackGroupDriftDetectionDetail.InProgressStackInstancesCount = _ctx.IntegerValue("GetStackGroupOperation.StackGroupOperation.StackGroupDriftDetectionDetail.InProgressStackInstancesCount");
			stackGroupDriftDetectionDetail.InSyncStackInstancesCount = _ctx.IntegerValue("GetStackGroupOperation.StackGroupOperation.StackGroupDriftDetectionDetail.InSyncStackInstancesCount");
			stackGroupDriftDetectionDetail.TotalStackInstancesCount = _ctx.IntegerValue("GetStackGroupOperation.StackGroupOperation.StackGroupDriftDetectionDetail.TotalStackInstancesCount");
			stackGroupOperation.StackGroupDriftDetectionDetail = stackGroupDriftDetectionDetail;
			getStackGroupOperationResponse.StackGroupOperation = stackGroupOperation;
        
			return getStackGroupOperationResponse;
        }
    }
}
