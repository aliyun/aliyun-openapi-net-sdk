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
    public class GetRentedJoinPermissionResponseUnmarshaller
    {
        public static GetRentedJoinPermissionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetRentedJoinPermissionResponse getRentedJoinPermissionResponse = new GetRentedJoinPermissionResponse();

			getRentedJoinPermissionResponse.HttpResponse = _ctx.HttpResponse;
			getRentedJoinPermissionResponse.RequestId = _ctx.StringValue("GetRentedJoinPermission.RequestId");
			getRentedJoinPermissionResponse.Success = _ctx.BooleanValue("GetRentedJoinPermission.Success");

			GetRentedJoinPermissionResponse.GetRentedJoinPermission_Data data = new GetRentedJoinPermissionResponse.GetRentedJoinPermission_Data();
			data.JoinPermissionId = _ctx.StringValue("GetRentedJoinPermission.Data.JoinPermissionId");
			data.JoinEui = _ctx.StringValue("GetRentedJoinPermission.Data.JoinEui");
			data.FreqBandPlanGroupId = _ctx.LongValue("GetRentedJoinPermission.Data.FreqBandPlanGroupId");
			data.ClassMode = _ctx.StringValue("GetRentedJoinPermission.Data.ClassMode");
			data.Type = _ctx.StringValue("GetRentedJoinPermission.Data.Type");
			data.Enabled = _ctx.BooleanValue("GetRentedJoinPermission.Data.Enabled");
			data.RxDailySum = _ctx.LongValue("GetRentedJoinPermission.Data.RxDailySum");
			data.RxMonthSum = _ctx.LongValue("GetRentedJoinPermission.Data.RxMonthSum");
			data.TxDailySum = _ctx.LongValue("GetRentedJoinPermission.Data.TxDailySum");
			data.TxMonthSum = _ctx.LongValue("GetRentedJoinPermission.Data.TxMonthSum");
			data.CreateMillis = _ctx.LongValue("GetRentedJoinPermission.Data.CreateMillis");
			data.NodesCnt = _ctx.LongValue("GetRentedJoinPermission.Data.NodesCnt");
			data.JoinPermissionName = _ctx.StringValue("GetRentedJoinPermission.Data.JoinPermissionName");
			data.BoundNodeGroupId = _ctx.StringValue("GetRentedJoinPermission.Data.BoundNodeGroupId");
			data.BoundNodeGroupName = _ctx.StringValue("GetRentedJoinPermission.Data.BoundNodeGroupName");
			data.RxDelay = _ctx.LongValue("GetRentedJoinPermission.Data.RxDelay");
			data.DataRate = _ctx.LongValue("GetRentedJoinPermission.Data.DataRate");
			getRentedJoinPermissionResponse.Data = data;
        
			return getRentedJoinPermissionResponse;
        }
    }
}
