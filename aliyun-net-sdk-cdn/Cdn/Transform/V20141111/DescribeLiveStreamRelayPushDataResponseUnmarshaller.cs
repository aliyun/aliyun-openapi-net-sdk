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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Cdn.Model.V20141111;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Transform.V20141111
{
    public class DescribeLiveStreamRelayPushDataResponseUnmarshaller
    {
        public static DescribeLiveStreamRelayPushDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLiveStreamRelayPushDataResponse describeLiveStreamRelayPushDataResponse = new DescribeLiveStreamRelayPushDataResponse();

			describeLiveStreamRelayPushDataResponse.HttpResponse = context.HttpResponse;
			describeLiveStreamRelayPushDataResponse.RequestId = context.StringValue("DescribeLiveStreamRelayPushData.RequestId");

			List<DescribeLiveStreamRelayPushDataResponse.DescribeLiveStreamRelayPushData_RelayPushDetailModel> describeLiveStreamRelayPushDataResponse_relayPushDetailModelList = new List<DescribeLiveStreamRelayPushDataResponse.DescribeLiveStreamRelayPushData_RelayPushDetailModel>();
			for (int i = 0; i < context.Length("DescribeLiveStreamRelayPushData.RelayPushDetailModelList.Length"); i++) {
				DescribeLiveStreamRelayPushDataResponse.DescribeLiveStreamRelayPushData_RelayPushDetailModel relayPushDetailModel = new DescribeLiveStreamRelayPushDataResponse.DescribeLiveStreamRelayPushData_RelayPushDetailModel();
				relayPushDetailModel.Time = context.StringValue("DescribeLiveStreamRelayPushData.RelayPushDetailModelList["+ i +"].Time");
				relayPushDetailModel.Stream = context.StringValue("DescribeLiveStreamRelayPushData.RelayPushDetailModelList["+ i +"].Stream");
				relayPushDetailModel.FrameRate = context.FloatValue("DescribeLiveStreamRelayPushData.RelayPushDetailModelList["+ i +"].FrameRate");
				relayPushDetailModel.BitRate = context.FloatValue("DescribeLiveStreamRelayPushData.RelayPushDetailModelList["+ i +"].BitRate");
				relayPushDetailModel.FrameLossRate = context.FloatValue("DescribeLiveStreamRelayPushData.RelayPushDetailModelList["+ i +"].FrameLossRate");
				relayPushDetailModel.ServerAddr = context.StringValue("DescribeLiveStreamRelayPushData.RelayPushDetailModelList["+ i +"].ServerAddr");
				relayPushDetailModel.ClientAddr = context.StringValue("DescribeLiveStreamRelayPushData.RelayPushDetailModelList["+ i +"].ClientAddr");

				describeLiveStreamRelayPushDataResponse_relayPushDetailModelList.Add(relayPushDetailModel);
			}
			describeLiveStreamRelayPushDataResponse.RelayPushDetailModelList = describeLiveStreamRelayPushDataResponse_relayPushDetailModelList;
        
			return describeLiveStreamRelayPushDataResponse;
        }
    }
}