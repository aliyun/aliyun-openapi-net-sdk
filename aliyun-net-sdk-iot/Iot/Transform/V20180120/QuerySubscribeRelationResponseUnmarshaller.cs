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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class QuerySubscribeRelationResponseUnmarshaller
    {
        public static QuerySubscribeRelationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QuerySubscribeRelationResponse querySubscribeRelationResponse = new QuerySubscribeRelationResponse();

			querySubscribeRelationResponse.HttpResponse = _ctx.HttpResponse;
			querySubscribeRelationResponse.RequestId = _ctx.StringValue("QuerySubscribeRelation.RequestId");
			querySubscribeRelationResponse.Success = _ctx.BooleanValue("QuerySubscribeRelation.Success");
			querySubscribeRelationResponse.Code = _ctx.StringValue("QuerySubscribeRelation.Code");
			querySubscribeRelationResponse.ErrorMessage = _ctx.StringValue("QuerySubscribeRelation.ErrorMessage");
			querySubscribeRelationResponse.ProductKey = _ctx.StringValue("QuerySubscribeRelation.ProductKey");
			querySubscribeRelationResponse.Type = _ctx.StringValue("QuerySubscribeRelation.Type");
			querySubscribeRelationResponse.DeviceDataFlag = _ctx.BooleanValue("QuerySubscribeRelation.DeviceDataFlag");
			querySubscribeRelationResponse.DeviceLifeCycleFlag = _ctx.BooleanValue("QuerySubscribeRelation.DeviceLifeCycleFlag");
			querySubscribeRelationResponse.DeviceStatusChangeFlag = _ctx.BooleanValue("QuerySubscribeRelation.DeviceStatusChangeFlag");
			querySubscribeRelationResponse.DeviceTopoLifeCycleFlag = _ctx.BooleanValue("QuerySubscribeRelation.DeviceTopoLifeCycleFlag");
			querySubscribeRelationResponse.FoundDeviceListFlag = _ctx.BooleanValue("QuerySubscribeRelation.FoundDeviceListFlag");
			querySubscribeRelationResponse.OtaEventFlag = _ctx.BooleanValue("QuerySubscribeRelation.OtaEventFlag");
			querySubscribeRelationResponse.ThingHistoryFlag = _ctx.BooleanValue("QuerySubscribeRelation.ThingHistoryFlag");
			querySubscribeRelationResponse.MnsConfiguration = _ctx.StringValue("QuerySubscribeRelation.MnsConfiguration");
			querySubscribeRelationResponse.DeviceTagFlag = _ctx.BooleanValue("QuerySubscribeRelation.DeviceTagFlag");
			querySubscribeRelationResponse.OtaVersionFlag = _ctx.BooleanValue("QuerySubscribeRelation.OtaVersionFlag");
			querySubscribeRelationResponse.OtaJobFlag = _ctx.BooleanValue("QuerySubscribeRelation.OtaJobFlag");

			List<string> querySubscribeRelationResponse_consumerGroupIds = new List<string>();
			for (int i = 0; i < _ctx.Length("QuerySubscribeRelation.ConsumerGroupIds.Length"); i++) {
				querySubscribeRelationResponse_consumerGroupIds.Add(_ctx.StringValue("QuerySubscribeRelation.ConsumerGroupIds["+ i +"]"));
			}
			querySubscribeRelationResponse.ConsumerGroupIds = querySubscribeRelationResponse_consumerGroupIds;
        
			return querySubscribeRelationResponse;
        }
    }
}
