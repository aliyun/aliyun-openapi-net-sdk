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
    public class DescribeLiveStreamPushDataResponseUnmarshaller
    {
        public static DescribeLiveStreamPushDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLiveStreamPushDataResponse describeLiveStreamPushDataResponse = new DescribeLiveStreamPushDataResponse();

			describeLiveStreamPushDataResponse.HttpResponse = context.HttpResponse;
			describeLiveStreamPushDataResponse.RequestId = context.StringValue("DescribeLiveStreamPushData.RequestId");

			List<DescribeLiveStreamPushDataResponse.PushStreamModel> pushStreamModelList = new List<DescribeLiveStreamPushDataResponse.PushStreamModel>();
			for (int i = 0; i < context.Length("DescribeLiveStreamPushData.PushStreamModelList.Length"); i++) {
				DescribeLiveStreamPushDataResponse.PushStreamModel pushStreamModel = new DescribeLiveStreamPushDataResponse.PushStreamModel();
				pushStreamModel.Time = context.StringValue("DescribeLiveStreamPushData.PushStreamModelList["+ i +"].Time");
				pushStreamModel.Stream = context.StringValue("DescribeLiveStreamPushData.PushStreamModelList["+ i +"].Stream");
				pushStreamModel.FrameRate = context.FloatValue("DescribeLiveStreamPushData.PushStreamModelList["+ i +"].FrameRate");
				pushStreamModel.BitRate = context.FloatValue("DescribeLiveStreamPushData.PushStreamModelList["+ i +"].BitRate");
				pushStreamModel.FrameLossRate = context.FloatValue("DescribeLiveStreamPushData.PushStreamModelList["+ i +"].FrameLossRate");
				pushStreamModel.ServerAddr = context.StringValue("DescribeLiveStreamPushData.PushStreamModelList["+ i +"].ServerAddr");
				pushStreamModel.ClientAddr = context.StringValue("DescribeLiveStreamPushData.PushStreamModelList["+ i +"].ClientAddr");

				pushStreamModelList.Add(pushStreamModel);
			}
			describeLiveStreamPushDataResponse.PushStreamModelList = pushStreamModelList;
        
			return describeLiveStreamPushDataResponse;
        }
    }
}