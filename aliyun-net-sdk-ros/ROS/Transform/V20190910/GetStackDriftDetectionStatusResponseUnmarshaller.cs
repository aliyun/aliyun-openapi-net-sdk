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
        public static GetStackDriftDetectionStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetStackDriftDetectionStatusResponse getStackDriftDetectionStatusResponse = new GetStackDriftDetectionStatusResponse();

			getStackDriftDetectionStatusResponse.HttpResponse = _ctx.HttpResponse;
			getStackDriftDetectionStatusResponse.RequestId = _ctx.StringValue("GetStackDriftDetectionStatus.RequestId");
			getStackDriftDetectionStatusResponse.DriftDetectionId = _ctx.StringValue("GetStackDriftDetectionStatus.DriftDetectionId");
			getStackDriftDetectionStatusResponse.DriftDetectionTime = _ctx.StringValue("GetStackDriftDetectionStatus.DriftDetectionTime");
			getStackDriftDetectionStatusResponse.DriftDetectionStatus = _ctx.StringValue("GetStackDriftDetectionStatus.DriftDetectionStatus");
			getStackDriftDetectionStatusResponse.DriftDetectionStatusReason = _ctx.StringValue("GetStackDriftDetectionStatus.DriftDetectionStatusReason");
			getStackDriftDetectionStatusResponse.StackDriftStatus = _ctx.StringValue("GetStackDriftDetectionStatus.StackDriftStatus");
			getStackDriftDetectionStatusResponse.StackId = _ctx.StringValue("GetStackDriftDetectionStatus.StackId");
			getStackDriftDetectionStatusResponse.DriftedStackResourceCount = _ctx.IntegerValue("GetStackDriftDetectionStatus.DriftedStackResourceCount");
        
			return getStackDriftDetectionStatusResponse;
        }
    }
}
