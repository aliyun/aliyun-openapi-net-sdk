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
using Aliyun.Acs.LinkWAN.Model.V20190301;

namespace Aliyun.Acs.LinkWAN.Transform.V20190301
{
    public class GetOwnedJoinPermissionResponseUnmarshaller
    {
        public static GetOwnedJoinPermissionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetOwnedJoinPermissionResponse getOwnedJoinPermissionResponse = new GetOwnedJoinPermissionResponse();

			getOwnedJoinPermissionResponse.HttpResponse = _ctx.HttpResponse;
			getOwnedJoinPermissionResponse.RequestId = _ctx.StringValue("GetOwnedJoinPermission.RequestId");
			getOwnedJoinPermissionResponse.Success = _ctx.BooleanValue("GetOwnedJoinPermission.Success");

			GetOwnedJoinPermissionResponse.GetOwnedJoinPermission_Data data = new GetOwnedJoinPermissionResponse.GetOwnedJoinPermission_Data();
			data.JoinPermissionId = _ctx.StringValue("GetOwnedJoinPermission.Data.JoinPermissionId");
			data.RenterAliyunId = _ctx.StringValue("GetOwnedJoinPermission.Data.RenterAliyunId");
			data.JoinEui = _ctx.StringValue("GetOwnedJoinPermission.Data.JoinEui");
			data.FreqBandPlanGroupId = _ctx.LongValue("GetOwnedJoinPermission.Data.FreqBandPlanGroupId");
			data.ClassMode = _ctx.StringValue("GetOwnedJoinPermission.Data.ClassMode");
			data.Enabled = _ctx.BooleanValue("GetOwnedJoinPermission.Data.Enabled");
			data.NodesCnt = _ctx.LongValue("GetOwnedJoinPermission.Data.NodesCnt");
			data.DataDispatchDestination = _ctx.StringValue("GetOwnedJoinPermission.Data.DataDispatchDestination");
			data.RxDailySum = _ctx.LongValue("GetOwnedJoinPermission.Data.RxDailySum");
			data.RxMonthSum = _ctx.LongValue("GetOwnedJoinPermission.Data.RxMonthSum");
			data.TxDailySum = _ctx.LongValue("GetOwnedJoinPermission.Data.TxDailySum");
			data.TxMonthSum = _ctx.LongValue("GetOwnedJoinPermission.Data.TxMonthSum");
			data.CreateMillis = _ctx.LongValue("GetOwnedJoinPermission.Data.CreateMillis");
			data.JoinPermissionName = _ctx.StringValue("GetOwnedJoinPermission.Data.JoinPermissionName");
			data.AuthState = _ctx.StringValue("GetOwnedJoinPermission.Data.AuthState");
			data.MulticastEnabled = _ctx.BooleanValue("GetOwnedJoinPermission.Data.MulticastEnabled");
			data.MulticastNodeCapacity = _ctx.IntegerValue("GetOwnedJoinPermission.Data.MulticastNodeCapacity");
			data.MulticastNodeCount = _ctx.IntegerValue("GetOwnedJoinPermission.Data.MulticastNodeCount");
			data.RxDelay = _ctx.LongValue("GetOwnedJoinPermission.Data.RxDelay");
			data.DataRate = _ctx.LongValue("GetOwnedJoinPermission.Data.DataRate");
			data.BoundProductName = _ctx.StringValue("GetOwnedJoinPermission.Data.BoundProductName");
			getOwnedJoinPermissionResponse.Data = data;
        
			return getOwnedJoinPermissionResponse;
        }
    }
}
