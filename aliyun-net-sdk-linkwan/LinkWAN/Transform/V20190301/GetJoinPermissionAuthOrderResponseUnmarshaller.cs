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
    public class GetJoinPermissionAuthOrderResponseUnmarshaller
    {
        public static GetJoinPermissionAuthOrderResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetJoinPermissionAuthOrderResponse getJoinPermissionAuthOrderResponse = new GetJoinPermissionAuthOrderResponse();

			getJoinPermissionAuthOrderResponse.HttpResponse = _ctx.HttpResponse;
			getJoinPermissionAuthOrderResponse.RequestId = _ctx.StringValue("GetJoinPermissionAuthOrder.RequestId");
			getJoinPermissionAuthOrderResponse.Success = _ctx.BooleanValue("GetJoinPermissionAuthOrder.Success");

			GetJoinPermissionAuthOrderResponse.GetJoinPermissionAuthOrder_Data data = new GetJoinPermissionAuthOrderResponse.GetJoinPermissionAuthOrder_Data();
			data.OrderId = _ctx.StringValue("GetJoinPermissionAuthOrder.Data.OrderId");
			data.JoinPermissionId = _ctx.StringValue("GetJoinPermissionAuthOrder.Data.JoinPermissionId");
			data.OwnerAliyunId = _ctx.StringValue("GetJoinPermissionAuthOrder.Data.OwnerAliyunId");
			data.RenterAliyunId = _ctx.StringValue("GetJoinPermissionAuthOrder.Data.RenterAliyunId");
			data.OrderState = _ctx.StringValue("GetJoinPermissionAuthOrder.Data.OrderState");
			data.ApplyingMillis = _ctx.LongValue("GetJoinPermissionAuthOrder.Data.ApplyingMillis");
			data.AcceptedMillis = _ctx.LongValue("GetJoinPermissionAuthOrder.Data.AcceptedMillis");
			data.RejectedMillis = _ctx.LongValue("GetJoinPermissionAuthOrder.Data.RejectedMillis");
			data.CanceledMillis = _ctx.LongValue("GetJoinPermissionAuthOrder.Data.CanceledMillis");
			getJoinPermissionAuthOrderResponse.Data = data;
        
			return getJoinPermissionAuthOrderResponse;
        }
    }
}
