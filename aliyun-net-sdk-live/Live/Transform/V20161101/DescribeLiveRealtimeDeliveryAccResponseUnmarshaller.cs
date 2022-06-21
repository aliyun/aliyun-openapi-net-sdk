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
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeLiveRealtimeDeliveryAccResponseUnmarshaller
    {
        public static DescribeLiveRealtimeDeliveryAccResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveRealtimeDeliveryAccResponse describeLiveRealtimeDeliveryAccResponse = new DescribeLiveRealtimeDeliveryAccResponse();

			describeLiveRealtimeDeliveryAccResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveRealtimeDeliveryAccResponse.RequestId = _ctx.StringValue("DescribeLiveRealtimeDeliveryAcc.RequestId");

			List<DescribeLiveRealtimeDeliveryAccResponse.DescribeLiveRealtimeDeliveryAcc_AccData> describeLiveRealtimeDeliveryAccResponse_realTimeDeliveryAccData = new List<DescribeLiveRealtimeDeliveryAccResponse.DescribeLiveRealtimeDeliveryAcc_AccData>();
			for (int i = 0; i < _ctx.Length("DescribeLiveRealtimeDeliveryAcc.RealTimeDeliveryAccData.Length"); i++) {
				DescribeLiveRealtimeDeliveryAccResponse.DescribeLiveRealtimeDeliveryAcc_AccData accData = new DescribeLiveRealtimeDeliveryAccResponse.DescribeLiveRealtimeDeliveryAcc_AccData();
				accData.TimeStamp = _ctx.StringValue("DescribeLiveRealtimeDeliveryAcc.RealTimeDeliveryAccData["+ i +"].TimeStamp");
				accData.SuccessNum = _ctx.IntegerValue("DescribeLiveRealtimeDeliveryAcc.RealTimeDeliveryAccData["+ i +"].SuccessNum");
				accData.FailedNum = _ctx.IntegerValue("DescribeLiveRealtimeDeliveryAcc.RealTimeDeliveryAccData["+ i +"].FailedNum");

				describeLiveRealtimeDeliveryAccResponse_realTimeDeliveryAccData.Add(accData);
			}
			describeLiveRealtimeDeliveryAccResponse.RealTimeDeliveryAccData = describeLiveRealtimeDeliveryAccResponse_realTimeDeliveryAccData;
        
			return describeLiveRealtimeDeliveryAccResponse;
        }
    }
}
