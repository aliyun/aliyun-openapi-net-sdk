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
using Aliyun.Acs.reid.Model.V20190928;

namespace Aliyun.Acs.reid.Transform.V20190928
{
    public class GetFootwearEventResponseUnmarshaller
    {
        public static GetFootwearEventResponse Unmarshall(UnmarshallerContext context)
        {
			GetFootwearEventResponse getFootwearEventResponse = new GetFootwearEventResponse();

			getFootwearEventResponse.HttpResponse = context.HttpResponse;
			getFootwearEventResponse.ErrorCode = context.StringValue("GetFootwearEvent.ErrorCode");
			getFootwearEventResponse.ErrorMessage = context.StringValue("GetFootwearEvent.ErrorMessage");
			getFootwearEventResponse.Message = context.StringValue("GetFootwearEvent.Message");
			getFootwearEventResponse.Code = context.StringValue("GetFootwearEvent.Code");
			getFootwearEventResponse.DynamicCode = context.StringValue("GetFootwearEvent.DynamicCode");
			getFootwearEventResponse.RequestId = context.StringValue("GetFootwearEvent.RequestId");
			getFootwearEventResponse.Success = context.BooleanValue("GetFootwearEvent.Success");
			getFootwearEventResponse.DynamicMessage = context.StringValue("GetFootwearEvent.DynamicMessage");

			List<GetFootwearEventResponse.GetFootwearEvent_FootwearEvent> getFootwearEventResponse_footwearEventList = new List<GetFootwearEventResponse.GetFootwearEvent_FootwearEvent>();
			for (int i = 0; i < context.Length("GetFootwearEvent.FootwearEventList.Length"); i++) {
				GetFootwearEventResponse.GetFootwearEvent_FootwearEvent footwearEvent = new GetFootwearEventResponse.GetFootwearEvent_FootwearEvent();
				footwearEvent.PositionNumber = context.StringValue("GetFootwearEvent.FootwearEventList["+ i +"].PositionNumber");
				footwearEvent.TryOnEventCount = context.IntegerValue("GetFootwearEvent.FootwearEventList["+ i +"].TryOnEventCount");
				footwearEvent.SkuId = context.StringValue("GetFootwearEvent.FootwearEventList["+ i +"].SkuId");
				footwearEvent.StoreId = context.LongValue("GetFootwearEvent.FootwearEventList["+ i +"].StoreId");
				footwearEvent.TakeEventCount = context.IntegerValue("GetFootwearEvent.FootwearEventList["+ i +"].TakeEventCount");
				footwearEvent.Date = context.StringValue("GetFootwearEvent.FootwearEventList["+ i +"].Date");

				getFootwearEventResponse_footwearEventList.Add(footwearEvent);
			}
			getFootwearEventResponse.FootwearEventList = getFootwearEventResponse_footwearEventList;
        
			return getFootwearEventResponse;
        }
    }
}
