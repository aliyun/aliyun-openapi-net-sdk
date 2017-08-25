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
    public class DescribeLiveStreamRelayPushBitRateResponseUnmarshaller
    {
        public static DescribeLiveStreamRelayPushBitRateResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLiveStreamRelayPushBitRateResponse describeLiveStreamRelayPushBitRateResponse = new DescribeLiveStreamRelayPushBitRateResponse();

			describeLiveStreamRelayPushBitRateResponse.HttpResponse = context.HttpResponse;
			describeLiveStreamRelayPushBitRateResponse.RequestId = context.StringValue("DescribeLiveStreamRelayPushBitRate.RequestId");

			List<DescribeLiveStreamRelayPushBitRateResponse.DescribeLiveStreamRelayPushBitRate_RelayPushBitRateModel> describeLiveStreamRelayPushBitRateResponse_relayPushBitRateModelList = new List<DescribeLiveStreamRelayPushBitRateResponse.DescribeLiveStreamRelayPushBitRate_RelayPushBitRateModel>();
			for (int i = 0; i < context.Length("DescribeLiveStreamRelayPushBitRate.RelayPushBitRateModelList.Length"); i++) {
				DescribeLiveStreamRelayPushBitRateResponse.DescribeLiveStreamRelayPushBitRate_RelayPushBitRateModel relayPushBitRateModel = new DescribeLiveStreamRelayPushBitRateResponse.DescribeLiveStreamRelayPushBitRate_RelayPushBitRateModel();
				relayPushBitRateModel.Time = context.StringValue("DescribeLiveStreamRelayPushBitRate.RelayPushBitRateModelList["+ i +"].Time");
				relayPushBitRateModel.VedioFrame = context.StringValue("DescribeLiveStreamRelayPushBitRate.RelayPushBitRateModelList["+ i +"].VedioFrame");
				relayPushBitRateModel.VedioTimstamp = context.StringValue("DescribeLiveStreamRelayPushBitRate.RelayPushBitRateModelList["+ i +"].VedioTimstamp");
				relayPushBitRateModel.AudioFrame = context.StringValue("DescribeLiveStreamRelayPushBitRate.RelayPushBitRateModelList["+ i +"].AudioFrame");
				relayPushBitRateModel.AudioTimstamp = context.StringValue("DescribeLiveStreamRelayPushBitRate.RelayPushBitRateModelList["+ i +"].AudioTimstamp");
				relayPushBitRateModel.RelayDomain = context.StringValue("DescribeLiveStreamRelayPushBitRate.RelayPushBitRateModelList["+ i +"].RelayDomain");

				describeLiveStreamRelayPushBitRateResponse_relayPushBitRateModelList.Add(relayPushBitRateModel);
			}
			describeLiveStreamRelayPushBitRateResponse.RelayPushBitRateModelList = describeLiveStreamRelayPushBitRateResponse_relayPushBitRateModelList;
        
			return describeLiveStreamRelayPushBitRateResponse;
        }
    }
}