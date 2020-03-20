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
    public class GetStackDriftDetectionStatusResponseUnmarshaller
    {
        public static GetStackDriftDetectionStatusResponse Unmarshall(UnmarshallerContext context)
        {
			GetStackDriftDetectionStatusResponse getStackDriftDetectionStatusResponse = new GetStackDriftDetectionStatusResponse();

			getStackDriftDetectionStatusResponse.HttpResponse = context.HttpResponse;
			getStackDriftDetectionStatusResponse.RequestId = context.StringValue("GetStackDriftDetectionStatus.RequestId");
			getStackDriftDetectionStatusResponse.DriftDetectionId = context.StringValue("GetStackDriftDetectionStatus.DriftDetectionId");
			getStackDriftDetectionStatusResponse.DriftDetectionTime = context.StringValue("GetStackDriftDetectionStatus.DriftDetectionTime");
			getStackDriftDetectionStatusResponse.DriftDetectionStatus = context.StringValue("GetStackDriftDetectionStatus.DriftDetectionStatus");
			getStackDriftDetectionStatusResponse.DriftDetectionStatusReason = context.StringValue("GetStackDriftDetectionStatus.DriftDetectionStatusReason");
			getStackDriftDetectionStatusResponse.StackDriftStatus = context.StringValue("GetStackDriftDetectionStatus.StackDriftStatus");
			getStackDriftDetectionStatusResponse.StackId = context.StringValue("GetStackDriftDetectionStatus.StackId");
			getStackDriftDetectionStatusResponse.DriftedStackResourceCount = context.IntegerValue("GetStackDriftDetectionStatus.DriftedStackResourceCount");
        
			return getStackDriftDetectionStatusResponse;
        }
    }
}
