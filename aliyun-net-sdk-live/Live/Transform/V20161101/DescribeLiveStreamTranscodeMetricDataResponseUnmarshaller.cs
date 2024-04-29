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
			describeLiveStreamTranscodeMetricDataResponse.DomainName = _ctx.StringValue("DescribeLiveStreamTranscodeMetricData.DomainName");
			describeLiveStreamTranscodeMetricDataResponse.EndTime = _ctx.StringValue("DescribeLiveStreamTranscodeMetricData.EndTime");
			describeLiveStreamTranscodeMetricDataResponse.NextPageToken = _ctx.StringValue("DescribeLiveStreamTranscodeMetricData.NextPageToken");
			describeLiveStreamTranscodeMetricDataResponse.PageSize = _ctx.IntegerValue("DescribeLiveStreamTranscodeMetricData.PageSize");
			describeLiveStreamTranscodeMetricDataResponse.RequestId = _ctx.StringValue("DescribeLiveStreamTranscodeMetricData.RequestId");
			describeLiveStreamTranscodeMetricDataResponse.StartTime = _ctx.StringValue("DescribeLiveStreamTranscodeMetricData.StartTime");

			List<DescribeLiveStreamTranscodeMetricDataResponse.DescribeLiveStreamTranscodeMetricData_StreamData> describeLiveStreamTranscodeMetricDataResponse_streamDetailData = new List<DescribeLiveStreamTranscodeMetricDataResponse.DescribeLiveStreamTranscodeMetricData_StreamData>();
			for (int i = 0; i < _ctx.Length("DescribeLiveStreamTranscodeMetricData.StreamDetailData.Length"); i++) {
				DescribeLiveStreamTranscodeMetricDataResponse.DescribeLiveStreamTranscodeMetricData_StreamData streamData = new DescribeLiveStreamTranscodeMetricDataResponse.DescribeLiveStreamTranscodeMetricData_StreamData();
				streamData.AppName = _ctx.StringValue("DescribeLiveStreamTranscodeMetricData.StreamDetailData["+ i +"].AppName");
				streamData.Duration = _ctx.LongValue("DescribeLiveStreamTranscodeMetricData.StreamDetailData["+ i +"].Duration");
				streamData.Fps = _ctx.StringValue("DescribeLiveStreamTranscodeMetricData.StreamDetailData["+ i +"].Fps");
				streamData.Region = _ctx.StringValue("DescribeLiveStreamTranscodeMetricData.StreamDetailData["+ i +"].Region");
				streamData.Resolution = _ctx.StringValue("DescribeLiveStreamTranscodeMetricData.StreamDetailData["+ i +"].Resolution");
				streamData.StreamName = _ctx.StringValue("DescribeLiveStreamTranscodeMetricData.StreamDetailData["+ i +"].StreamName");
				streamData.TimeStamp = _ctx.StringValue("DescribeLiveStreamTranscodeMetricData.StreamDetailData["+ i +"].TimeStamp");
				streamData.TranscodeType = _ctx.StringValue("DescribeLiveStreamTranscodeMetricData.StreamDetailData["+ i +"].TranscodeType");

				describeLiveStreamTranscodeMetricDataResponse_streamDetailData.Add(streamData);
			}
			describeLiveStreamTranscodeMetricDataResponse.StreamDetailData = describeLiveStreamTranscodeMetricDataResponse_streamDetailData;
        
			return describeLiveStreamTranscodeMetricDataResponse;
        }
    }
}
