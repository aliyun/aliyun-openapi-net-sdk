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
    public class DescribeLiveCenterStreamRateDataResponseUnmarshaller
    {
        public static DescribeLiveCenterStreamRateDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveCenterStreamRateDataResponse describeLiveCenterStreamRateDataResponse = new DescribeLiveCenterStreamRateDataResponse();

			describeLiveCenterStreamRateDataResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveCenterStreamRateDataResponse.RequestId = _ctx.StringValue("DescribeLiveCenterStreamRateData.RequestId");

			List<DescribeLiveCenterStreamRateDataResponse.DescribeLiveCenterStreamRateData_Data> describeLiveCenterStreamRateDataResponse_rateDatas = new List<DescribeLiveCenterStreamRateDataResponse.DescribeLiveCenterStreamRateData_Data>();
			for (int i = 0; i < _ctx.Length("DescribeLiveCenterStreamRateData.RateDatas.Length"); i++) {
				DescribeLiveCenterStreamRateDataResponse.DescribeLiveCenterStreamRateData_Data data = new DescribeLiveCenterStreamRateDataResponse.DescribeLiveCenterStreamRateData_Data();
				data.VideoFps = _ctx.StringValue("DescribeLiveCenterStreamRateData.RateDatas["+ i +"].VideoFps");
				data.VideoRate = _ctx.StringValue("DescribeLiveCenterStreamRateData.RateDatas["+ i +"].VideoRate");
				data.AudioFps = _ctx.StringValue("DescribeLiveCenterStreamRateData.RateDatas["+ i +"].AudioFps");
				data.AudioRate = _ctx.StringValue("DescribeLiveCenterStreamRateData.RateDatas["+ i +"].AudioRate");
				data.Time = _ctx.StringValue("DescribeLiveCenterStreamRateData.RateDatas["+ i +"].Time");

				describeLiveCenterStreamRateDataResponse_rateDatas.Add(data);
			}
			describeLiveCenterStreamRateDataResponse.RateDatas = describeLiveCenterStreamRateDataResponse_rateDatas;
        
			return describeLiveCenterStreamRateDataResponse;
        }
    }
}
