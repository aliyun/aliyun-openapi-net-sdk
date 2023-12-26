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
    public class DescribeLiveStreamMetricDetailDataResponseUnmarshaller
    {
        public static DescribeLiveStreamMetricDetailDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveStreamMetricDetailDataResponse describeLiveStreamMetricDetailDataResponse = new DescribeLiveStreamMetricDetailDataResponse();

			describeLiveStreamMetricDetailDataResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveStreamMetricDetailDataResponse.EndTime = _ctx.StringValue("DescribeLiveStreamMetricDetailData.EndTime");
			describeLiveStreamMetricDetailDataResponse.StartTime = _ctx.StringValue("DescribeLiveStreamMetricDetailData.StartTime");
			describeLiveStreamMetricDetailDataResponse.RequestId = _ctx.StringValue("DescribeLiveStreamMetricDetailData.RequestId");
			describeLiveStreamMetricDetailDataResponse.NextPageToken = _ctx.StringValue("DescribeLiveStreamMetricDetailData.NextPageToken");
			describeLiveStreamMetricDetailDataResponse.PageSize = _ctx.IntegerValue("DescribeLiveStreamMetricDetailData.PageSize");
			describeLiveStreamMetricDetailDataResponse.DomainName = _ctx.StringValue("DescribeLiveStreamMetricDetailData.DomainName");

			List<DescribeLiveStreamMetricDetailDataResponse.DescribeLiveStreamMetricDetailData_StreamData> describeLiveStreamMetricDetailDataResponse_streamDetailData = new List<DescribeLiveStreamMetricDetailDataResponse.DescribeLiveStreamMetricDetailData_StreamData>();
			for (int i = 0; i < _ctx.Length("DescribeLiveStreamMetricDetailData.StreamDetailData.Length"); i++) {
				DescribeLiveStreamMetricDetailDataResponse.DescribeLiveStreamMetricDetailData_StreamData streamData = new DescribeLiveStreamMetricDetailDataResponse.DescribeLiveStreamMetricDetailData_StreamData();
				streamData.P2pTraffic = _ctx.LongValue("DescribeLiveStreamMetricDetailData.StreamDetailData["+ i +"].P2pTraffic");
				streamData.RtmpBps = _ctx.FloatValue("DescribeLiveStreamMetricDetailData.StreamDetailData["+ i +"].RtmpBps");
				streamData.HlsBps = _ctx.FloatValue("DescribeLiveStreamMetricDetailData.StreamDetailData["+ i +"].HlsBps");
				streamData.P2pBps = _ctx.FloatValue("DescribeLiveStreamMetricDetailData.StreamDetailData["+ i +"].P2pBps");
				streamData.StreamName = _ctx.StringValue("DescribeLiveStreamMetricDetailData.StreamDetailData["+ i +"].StreamName");
				streamData.P2pCount = _ctx.LongValue("DescribeLiveStreamMetricDetailData.StreamDetailData["+ i +"].P2pCount");
				streamData.Traffic = _ctx.LongValue("DescribeLiveStreamMetricDetailData.StreamDetailData["+ i +"].Traffic");
				streamData.RtmpCount = _ctx.LongValue("DescribeLiveStreamMetricDetailData.StreamDetailData["+ i +"].RtmpCount");
				streamData.RtsCount = _ctx.LongValue("DescribeLiveStreamMetricDetailData.StreamDetailData["+ i +"].RtsCount");
				streamData.RtsBps = _ctx.FloatValue("DescribeLiveStreamMetricDetailData.StreamDetailData["+ i +"].RtsBps");
				streamData.Bps = _ctx.FloatValue("DescribeLiveStreamMetricDetailData.StreamDetailData["+ i +"].Bps");
				streamData.HlsTraffic = _ctx.LongValue("DescribeLiveStreamMetricDetailData.StreamDetailData["+ i +"].HlsTraffic");
				streamData.FlvBps = _ctx.FloatValue("DescribeLiveStreamMetricDetailData.StreamDetailData["+ i +"].FlvBps");
				streamData.Count = _ctx.LongValue("DescribeLiveStreamMetricDetailData.StreamDetailData["+ i +"].Count");
				streamData.RtsTraffic = _ctx.LongValue("DescribeLiveStreamMetricDetailData.StreamDetailData["+ i +"].RtsTraffic");
				streamData.RtmpTraffic = _ctx.LongValue("DescribeLiveStreamMetricDetailData.StreamDetailData["+ i +"].RtmpTraffic");
				streamData.HlsCount = _ctx.LongValue("DescribeLiveStreamMetricDetailData.StreamDetailData["+ i +"].HlsCount");
				streamData.AppName = _ctx.StringValue("DescribeLiveStreamMetricDetailData.StreamDetailData["+ i +"].AppName");
				streamData.FlvCount = _ctx.LongValue("DescribeLiveStreamMetricDetailData.StreamDetailData["+ i +"].FlvCount");
				streamData.FlvTraffic = _ctx.LongValue("DescribeLiveStreamMetricDetailData.StreamDetailData["+ i +"].FlvTraffic");
				streamData.TimeStamp = _ctx.StringValue("DescribeLiveStreamMetricDetailData.StreamDetailData["+ i +"].TimeStamp");
				streamData.NewConns = _ctx.StringValue("DescribeLiveStreamMetricDetailData.StreamDetailData["+ i +"].NewConns");

				describeLiveStreamMetricDetailDataResponse_streamDetailData.Add(streamData);
			}
			describeLiveStreamMetricDetailDataResponse.StreamDetailData = describeLiveStreamMetricDetailDataResponse_streamDetailData;
        
			return describeLiveStreamMetricDetailDataResponse;
        }
    }
}
