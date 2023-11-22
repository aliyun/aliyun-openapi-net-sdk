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
    public class DescribeLiveStreamTranscodeMetricDataResponseUnmarshaller
    {
        public static DescribeLiveStreamTranscodeMetricDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveStreamTranscodeMetricDataResponse describeLiveStreamTranscodeMetricDataResponse = new DescribeLiveStreamTranscodeMetricDataResponse();

			describeLiveStreamTranscodeMetricDataResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveStreamTranscodeMetricDataResponse.EndTime = _ctx.StringValue("DescribeLiveStreamTranscodeMetricData.EndTime");
			describeLiveStreamTranscodeMetricDataResponse.StartTime = _ctx.StringValue("DescribeLiveStreamTranscodeMetricData.StartTime");
			describeLiveStreamTranscodeMetricDataResponse.RequestId = _ctx.StringValue("DescribeLiveStreamTranscodeMetricData.RequestId");
			describeLiveStreamTranscodeMetricDataResponse.NextPageToken = _ctx.StringValue("DescribeLiveStreamTranscodeMetricData.NextPageToken");
			describeLiveStreamTranscodeMetricDataResponse.PageSize = _ctx.IntegerValue("DescribeLiveStreamTranscodeMetricData.PageSize");
			describeLiveStreamTranscodeMetricDataResponse.DomainName = _ctx.StringValue("DescribeLiveStreamTranscodeMetricData.DomainName");

			List<DescribeLiveStreamTranscodeMetricDataResponse.DescribeLiveStreamTranscodeMetricData_StreamData> describeLiveStreamTranscodeMetricDataResponse_streamDetailData = new List<DescribeLiveStreamTranscodeMetricDataResponse.DescribeLiveStreamTranscodeMetricData_StreamData>();
			for (int i = 0; i < _ctx.Length("DescribeLiveStreamTranscodeMetricData.StreamDetailData.Length"); i++) {
				DescribeLiveStreamTranscodeMetricDataResponse.DescribeLiveStreamTranscodeMetricData_StreamData streamData = new DescribeLiveStreamTranscodeMetricDataResponse.DescribeLiveStreamTranscodeMetricData_StreamData();
				streamData.AppName = _ctx.StringValue("DescribeLiveStreamTranscodeMetricData.StreamDetailData["+ i +"].AppName");
				streamData.StreamName = _ctx.StringValue("DescribeLiveStreamTranscodeMetricData.StreamDetailData["+ i +"].StreamName");
				streamData.Region = _ctx.StringValue("DescribeLiveStreamTranscodeMetricData.StreamDetailData["+ i +"].Region");
				streamData.Duration = _ctx.LongValue("DescribeLiveStreamTranscodeMetricData.StreamDetailData["+ i +"].Duration");
				streamData.Fps = _ctx.StringValue("DescribeLiveStreamTranscodeMetricData.StreamDetailData["+ i +"].Fps");
				streamData.TimeStamp = _ctx.StringValue("DescribeLiveStreamTranscodeMetricData.StreamDetailData["+ i +"].TimeStamp");
				streamData.TranscodeType = _ctx.StringValue("DescribeLiveStreamTranscodeMetricData.StreamDetailData["+ i +"].TranscodeType");
				streamData.Resolution = _ctx.StringValue("DescribeLiveStreamTranscodeMetricData.StreamDetailData["+ i +"].Resolution");

				describeLiveStreamTranscodeMetricDataResponse_streamDetailData.Add(streamData);
			}
			describeLiveStreamTranscodeMetricDataResponse.StreamDetailData = describeLiveStreamTranscodeMetricDataResponse_streamDetailData;
        
			return describeLiveStreamTranscodeMetricDataResponse;
        }
    }
}
