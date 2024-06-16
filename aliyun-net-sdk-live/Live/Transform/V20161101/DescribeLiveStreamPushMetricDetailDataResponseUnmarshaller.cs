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
    public class DescribeLiveStreamPushMetricDetailDataResponseUnmarshaller
    {
        public static DescribeLiveStreamPushMetricDetailDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveStreamPushMetricDetailDataResponse describeLiveStreamPushMetricDetailDataResponse = new DescribeLiveStreamPushMetricDetailDataResponse();

			describeLiveStreamPushMetricDetailDataResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveStreamPushMetricDetailDataResponse.DomainName = _ctx.StringValue("DescribeLiveStreamPushMetricDetailData.DomainName");
			describeLiveStreamPushMetricDetailDataResponse.EndTime = _ctx.StringValue("DescribeLiveStreamPushMetricDetailData.EndTime");
			describeLiveStreamPushMetricDetailDataResponse.NextPageToken = _ctx.StringValue("DescribeLiveStreamPushMetricDetailData.NextPageToken");
			describeLiveStreamPushMetricDetailDataResponse.PageSize = _ctx.IntegerValue("DescribeLiveStreamPushMetricDetailData.PageSize");
			describeLiveStreamPushMetricDetailDataResponse.RequestId = _ctx.StringValue("DescribeLiveStreamPushMetricDetailData.RequestId");
			describeLiveStreamPushMetricDetailDataResponse.StartTime = _ctx.StringValue("DescribeLiveStreamPushMetricDetailData.StartTime");

			List<DescribeLiveStreamPushMetricDetailDataResponse.DescribeLiveStreamPushMetricDetailData_StreamData> describeLiveStreamPushMetricDetailDataResponse_streamDetailData = new List<DescribeLiveStreamPushMetricDetailDataResponse.DescribeLiveStreamPushMetricDetailData_StreamData>();
			for (int i = 0; i < _ctx.Length("DescribeLiveStreamPushMetricDetailData.StreamDetailData.Length"); i++) {
				DescribeLiveStreamPushMetricDetailDataResponse.DescribeLiveStreamPushMetricDetailData_StreamData streamData = new DescribeLiveStreamPushMetricDetailDataResponse.DescribeLiveStreamPushMetricDetailData_StreamData();
				streamData.AppName = _ctx.StringValue("DescribeLiveStreamPushMetricDetailData.StreamDetailData["+ i +"].AppName");
				streamData.ReqBps = _ctx.FloatValue("DescribeLiveStreamPushMetricDetailData.StreamDetailData["+ i +"].ReqBps");
				streamData.ReqTraffic = _ctx.LongValue("DescribeLiveStreamPushMetricDetailData.StreamDetailData["+ i +"].ReqTraffic");
				streamData.StreamName = _ctx.StringValue("DescribeLiveStreamPushMetricDetailData.StreamDetailData["+ i +"].StreamName");
				streamData.TimeStamp = _ctx.StringValue("DescribeLiveStreamPushMetricDetailData.StreamDetailData["+ i +"].TimeStamp");

				describeLiveStreamPushMetricDetailDataResponse_streamDetailData.Add(streamData);
			}
			describeLiveStreamPushMetricDetailDataResponse.StreamDetailData = describeLiveStreamPushMetricDetailDataResponse_streamDetailData;
        
			return describeLiveStreamPushMetricDetailDataResponse;
        }
    }
}
