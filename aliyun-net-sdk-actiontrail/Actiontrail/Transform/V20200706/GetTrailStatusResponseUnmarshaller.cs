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
using Aliyun.Acs.Actiontrail.Model.V20200706;

namespace Aliyun.Acs.Actiontrail.Transform.V20200706
{
    public class GetTrailStatusResponseUnmarshaller
    {
        public static GetTrailStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetTrailStatusResponse getTrailStatusResponse = new GetTrailStatusResponse();

			getTrailStatusResponse.HttpResponse = _ctx.HttpResponse;
			getTrailStatusResponse.LatestDeliveryLogServiceTime = _ctx.StringValue("GetTrailStatus.LatestDeliveryLogServiceTime");
			getTrailStatusResponse.RequestId = _ctx.StringValue("GetTrailStatus.RequestId");
			getTrailStatusResponse.LatestDeliveryLogServiceError = _ctx.StringValue("GetTrailStatus.LatestDeliveryLogServiceError");
			getTrailStatusResponse.StartLoggingTime = _ctx.StringValue("GetTrailStatus.StartLoggingTime");
			getTrailStatusResponse.OssBucketStatus = _ctx.BooleanValue("GetTrailStatus.OssBucketStatus");
			getTrailStatusResponse.LatestDeliveryError = _ctx.StringValue("GetTrailStatus.LatestDeliveryError");
			getTrailStatusResponse.StopLoggingTime = _ctx.StringValue("GetTrailStatus.StopLoggingTime");
			getTrailStatusResponse.SlsLogStoreStatus = _ctx.BooleanValue("GetTrailStatus.SlsLogStoreStatus");
			getTrailStatusResponse.LatestDeliveryTime = _ctx.StringValue("GetTrailStatus.LatestDeliveryTime");
			getTrailStatusResponse.IsLogging = _ctx.BooleanValue("GetTrailStatus.IsLogging");
        
			return getTrailStatusResponse;
        }
    }
}
