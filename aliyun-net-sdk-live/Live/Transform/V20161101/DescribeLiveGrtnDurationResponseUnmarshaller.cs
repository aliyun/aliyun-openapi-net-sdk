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
    public class DescribeLiveGrtnDurationResponseUnmarshaller
    {
        public static DescribeLiveGrtnDurationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveGrtnDurationResponse describeLiveGrtnDurationResponse = new DescribeLiveGrtnDurationResponse();

			describeLiveGrtnDurationResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveGrtnDurationResponse.RequestId = _ctx.StringValue("DescribeLiveGrtnDuration.RequestId");

			List<DescribeLiveGrtnDurationResponse.DescribeLiveGrtnDuration_StreamData> describeLiveGrtnDurationResponse_streamDetailData = new List<DescribeLiveGrtnDurationResponse.DescribeLiveGrtnDuration_StreamData>();
			for (int i = 0; i < _ctx.Length("DescribeLiveGrtnDuration.StreamDetailData.Length"); i++) {
				DescribeLiveGrtnDurationResponse.DescribeLiveGrtnDuration_StreamData streamData = new DescribeLiveGrtnDurationResponse.DescribeLiveGrtnDuration_StreamData();
				streamData.Duration = _ctx.LongValue("DescribeLiveGrtnDuration.StreamDetailData["+ i +"].Duration");
				streamData.TimeStamp = _ctx.StringValue("DescribeLiveGrtnDuration.StreamDetailData["+ i +"].TimeStamp");
				streamData.MediaProfile = _ctx.StringValue("DescribeLiveGrtnDuration.StreamDetailData["+ i +"].MediaProfile");
				streamData.MediaType = _ctx.StringValue("DescribeLiveGrtnDuration.StreamDetailData["+ i +"].MediaType");
				streamData.AppId = _ctx.StringValue("DescribeLiveGrtnDuration.StreamDetailData["+ i +"].AppId");

				describeLiveGrtnDurationResponse_streamDetailData.Add(streamData);
			}
			describeLiveGrtnDurationResponse.StreamDetailData = describeLiveGrtnDurationResponse_streamDetailData;
        
			return describeLiveGrtnDurationResponse;
        }
    }
}
