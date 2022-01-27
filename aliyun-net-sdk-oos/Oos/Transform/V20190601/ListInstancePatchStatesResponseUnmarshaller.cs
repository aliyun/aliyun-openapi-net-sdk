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
using Aliyun.Acs.oos.Model.V20190601;

namespace Aliyun.Acs.oos.Transform.V20190601
{
    public class ListInstancePatchStatesResponseUnmarshaller
    {
        public static ListInstancePatchStatesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListInstancePatchStatesResponse listInstancePatchStatesResponse = new ListInstancePatchStatesResponse();

			listInstancePatchStatesResponse.HttpResponse = _ctx.HttpResponse;
			listInstancePatchStatesResponse.MaxResults = _ctx.IntegerValue("ListInstancePatchStates.MaxResults");
			listInstancePatchStatesResponse.NextToken = _ctx.StringValue("ListInstancePatchStates.NextToken");
			listInstancePatchStatesResponse.RequestId = _ctx.StringValue("ListInstancePatchStates.RequestId");

			List<ListInstancePatchStatesResponse.ListInstancePatchStates_InstancePatchState> listInstancePatchStatesResponse_instancePatchStates = new List<ListInstancePatchStatesResponse.ListInstancePatchStates_InstancePatchState>();
			for (int i = 0; i < _ctx.Length("ListInstancePatchStates.InstancePatchStates.Length"); i++) {
				ListInstancePatchStatesResponse.ListInstancePatchStates_InstancePatchState instancePatchState = new ListInstancePatchStatesResponse.ListInstancePatchStates_InstancePatchState();
				instancePatchState.InstanceId = _ctx.StringValue("ListInstancePatchStates.InstancePatchStates["+ i +"].InstanceId");
				instancePatchState.PatchGroup = _ctx.StringValue("ListInstancePatchStates.InstancePatchStates["+ i +"].PatchGroup");
				instancePatchState.BaselineId = _ctx.StringValue("ListInstancePatchStates.InstancePatchStates["+ i +"].BaselineId");
				instancePatchState.OwnerInformation = _ctx.StringValue("ListInstancePatchStates.InstancePatchStates["+ i +"].OwnerInformation");
				instancePatchState.InstalledCount = _ctx.StringValue("ListInstancePatchStates.InstancePatchStates["+ i +"].InstalledCount");
				instancePatchState.InstalledOtherCount = _ctx.StringValue("ListInstancePatchStates.InstancePatchStates["+ i +"].InstalledOtherCount");
				instancePatchState.InstalledPendingRebootCount = _ctx.StringValue("ListInstancePatchStates.InstancePatchStates["+ i +"].InstalledPendingRebootCount");
				instancePatchState.InstalledRejectedCount = _ctx.StringValue("ListInstancePatchStates.InstancePatchStates["+ i +"].InstalledRejectedCount");
				instancePatchState.MissingCount = _ctx.StringValue("ListInstancePatchStates.InstancePatchStates["+ i +"].MissingCount");
				instancePatchState.FailedCount = _ctx.StringValue("ListInstancePatchStates.InstancePatchStates["+ i +"].FailedCount");
				instancePatchState.OperationType = _ctx.StringValue("ListInstancePatchStates.InstancePatchStates["+ i +"].OperationType");
				instancePatchState.OperationStartTime = _ctx.StringValue("ListInstancePatchStates.InstancePatchStates["+ i +"].OperationStartTime");
				instancePatchState.OperationEndTime = _ctx.StringValue("ListInstancePatchStates.InstancePatchStates["+ i +"].OperationEndTime");

				listInstancePatchStatesResponse_instancePatchStates.Add(instancePatchState);
			}
			listInstancePatchStatesResponse.InstancePatchStates = listInstancePatchStatesResponse_instancePatchStates;
        
			return listInstancePatchStatesResponse;
        }
    }
}
