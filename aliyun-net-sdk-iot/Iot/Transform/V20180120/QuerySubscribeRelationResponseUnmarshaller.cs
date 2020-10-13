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
        public static QuerySubscribeRelationResponse Unmarshall(UnmarshallerContext context)
        {
			QuerySubscribeRelationResponse querySubscribeRelationResponse = new QuerySubscribeRelationResponse();

			querySubscribeRelationResponse.HttpResponse = context.HttpResponse;
			querySubscribeRelationResponse.RequestId = context.StringValue("QuerySubscribeRelation.RequestId");
			querySubscribeRelationResponse.Success = context.BooleanValue("QuerySubscribeRelation.Success");
			querySubscribeRelationResponse.Code = context.StringValue("QuerySubscribeRelation.Code");
			querySubscribeRelationResponse.ErrorMessage = context.StringValue("QuerySubscribeRelation.ErrorMessage");
			querySubscribeRelationResponse.ProductKey = context.StringValue("QuerySubscribeRelation.ProductKey");
			querySubscribeRelationResponse.Type = context.StringValue("QuerySubscribeRelation.Type");
			querySubscribeRelationResponse.DeviceDataFlag = context.BooleanValue("QuerySubscribeRelation.DeviceDataFlag");
			querySubscribeRelationResponse.DeviceLifeCycleFlag = context.BooleanValue("QuerySubscribeRelation.DeviceLifeCycleFlag");
			querySubscribeRelationResponse.DeviceStatusChangeFlag = context.BooleanValue("QuerySubscribeRelation.DeviceStatusChangeFlag");
			querySubscribeRelationResponse.DeviceTopoLifeCycleFlag = context.BooleanValue("QuerySubscribeRelation.DeviceTopoLifeCycleFlag");
			querySubscribeRelationResponse.FoundDeviceListFlag = context.BooleanValue("QuerySubscribeRelation.FoundDeviceListFlag");
			querySubscribeRelationResponse.OtaEventFlag = context.BooleanValue("QuerySubscribeRelation.OtaEventFlag");
			querySubscribeRelationResponse.ThingHistoryFlag = context.BooleanValue("QuerySubscribeRelation.ThingHistoryFlag");
			querySubscribeRelationResponse.MnsConfiguration = context.StringValue("QuerySubscribeRelation.MnsConfiguration");
			querySubscribeRelationResponse.DeviceTagFlag = context.BooleanValue("QuerySubscribeRelation.DeviceTagFlag");
			querySubscribeRelationResponse.OtaVersionFlag = context.BooleanValue("QuerySubscribeRelation.OtaVersionFlag");
			querySubscribeRelationResponse.OtaJobFlag = context.BooleanValue("QuerySubscribeRelation.OtaJobFlag");

			List<string> querySubscribeRelationResponse_consumerGroupIds = new List<string>();
			for (int i = 0; i < context.Length("QuerySubscribeRelation.ConsumerGroupIds.Length"); i++) {
				querySubscribeRelationResponse_consumerGroupIds.Add(context.StringValue("QuerySubscribeRelation.ConsumerGroupIds["+ i +"]"));
			}
			querySubscribeRelationResponse.ConsumerGroupIds = querySubscribeRelationResponse_consumerGroupIds;
        
			return querySubscribeRelationResponse;
        }
    }
}
