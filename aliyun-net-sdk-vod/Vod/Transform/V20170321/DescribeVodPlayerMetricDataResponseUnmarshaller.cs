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
using Aliyun.Acs.vod.Model.V20170321;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class DescribeVodPlayerMetricDataResponseUnmarshaller
    {
        public static DescribeVodPlayerMetricDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVodPlayerMetricDataResponse describeVodPlayerMetricDataResponse = new DescribeVodPlayerMetricDataResponse();

			describeVodPlayerMetricDataResponse.HttpResponse = _ctx.HttpResponse;
			describeVodPlayerMetricDataResponse.RequestId = _ctx.StringValue("DescribeVodPlayerMetricData.RequestId");
			describeVodPlayerMetricDataResponse.PageNumber = _ctx.LongValue("DescribeVodPlayerMetricData.PageNumber");
			describeVodPlayerMetricDataResponse.PageSize = _ctx.LongValue("DescribeVodPlayerMetricData.PageSize");
			describeVodPlayerMetricDataResponse.TotalCnt = _ctx.LongValue("DescribeVodPlayerMetricData.TotalCnt");

			DescribeVodPlayerMetricDataResponse.DescribeVodPlayerMetricData_Extend extend = new DescribeVodPlayerMetricDataResponse.DescribeVodPlayerMetricData_Extend();
			extend.ActualStartTime = _ctx.StringValue("DescribeVodPlayerMetricData.Extend.ActualStartTime");
			extend.ActualEndTime = _ctx.StringValue("DescribeVodPlayerMetricData.Extend.ActualEndTime");
			extend.IntervalSeconds = _ctx.LongValue("DescribeVodPlayerMetricData.Extend.IntervalSeconds");
			describeVodPlayerMetricDataResponse.Extend = extend;

			List<DescribeVodPlayerMetricDataResponse.DescribeVodPlayerMetricData_Datds> describeVodPlayerMetricDataResponse_dataList = new List<DescribeVodPlayerMetricDataResponse.DescribeVodPlayerMetricData_Datds>();
			for (int i = 0; i < _ctx.Length("DescribeVodPlayerMetricData.DataList.Length"); i++) {
				DescribeVodPlayerMetricDataResponse.DescribeVodPlayerMetricData_Datds datds = new DescribeVodPlayerMetricDataResponse.DescribeVodPlayerMetricData_Datds();
				datds.TimeStamp = _ctx.StringValue("DescribeVodPlayerMetricData.DataList["+ i +"].TimeStamp");
				datds.Dimension = _ctx.StringValue("DescribeVodPlayerMetricData.DataList["+ i +"].Dimension");
				datds.Uv = _ctx.DoubleValue("DescribeVodPlayerMetricData.DataList["+ i +"].Uv");
				datds.Vv = _ctx.DoubleValue("DescribeVodPlayerMetricData.DataList["+ i +"].Vv");
				datds.RealVv = _ctx.DoubleValue("DescribeVodPlayerMetricData.DataList["+ i +"].RealVv");
				datds.FirstFrame = _ctx.DoubleValue("DescribeVodPlayerMetricData.DataList["+ i +"].FirstFrame");
				datds.SecondPlayRate = _ctx.DoubleValue("DescribeVodPlayerMetricData.DataList["+ i +"].SecondPlayRate");
				datds.SlowPlayRate = _ctx.DoubleValue("DescribeVodPlayerMetricData.DataList["+ i +"].SlowPlayRate");
				datds.StuckCountRate = _ctx.DoubleValue("DescribeVodPlayerMetricData.DataList["+ i +"].StuckCountRate");
				datds.SeekDuration = _ctx.DoubleValue("DescribeVodPlayerMetricData.DataList["+ i +"].SeekDuration");
				datds.StuckDuration100s = _ctx.DoubleValue("DescribeVodPlayerMetricData.DataList["+ i +"].StuckDuration100s");
				datds.PlayFailRate = _ctx.DoubleValue("DescribeVodPlayerMetricData.DataList["+ i +"].PlayFailRate");
				datds.SeedFailRate = _ctx.DoubleValue("DescribeVodPlayerMetricData.DataList["+ i +"].SeedFailRate");
				datds.AvgPlayBitrate = _ctx.DoubleValue("DescribeVodPlayerMetricData.DataList["+ i +"].AvgPlayBitrate");
				datds.AvgStartBitrate = _ctx.DoubleValue("DescribeVodPlayerMetricData.DataList["+ i +"].AvgStartBitrate");
				datds.ErrorCount100s = _ctx.DoubleValue("DescribeVodPlayerMetricData.DataList["+ i +"].ErrorCount100s");
				datds.AvgPerVv = _ctx.DoubleValue("DescribeVodPlayerMetricData.DataList["+ i +"].AvgPerVv");
				datds.AvgVideoDuration = _ctx.DoubleValue("DescribeVodPlayerMetricData.DataList["+ i +"].AvgVideoDuration");
				datds.AvgPerPlayDuration = _ctx.DoubleValue("DescribeVodPlayerMetricData.DataList["+ i +"].AvgPerPlayDuration");
				datds.AvgPerCompletionVv = _ctx.DoubleValue("DescribeVodPlayerMetricData.DataList["+ i +"].AvgPerCompletionVv");
				datds.CompletionVv = _ctx.DoubleValue("DescribeVodPlayerMetricData.DataList["+ i +"].CompletionVv");
				datds.CompletionRate = _ctx.DoubleValue("DescribeVodPlayerMetricData.DataList["+ i +"].CompletionRate");
				datds.AvgPlayDuration = _ctx.DoubleValue("DescribeVodPlayerMetricData.DataList["+ i +"].AvgPlayDuration");
				datds.JumpRate5s = _ctx.DoubleValue("DescribeVodPlayerMetricData.DataList["+ i +"].JumpRate5s");
				datds.TotalPlayDuration = _ctx.DoubleValue("DescribeVodPlayerMetricData.DataList["+ i +"].TotalPlayDuration");
				datds.StuckCount100s = _ctx.StringValue("DescribeVodPlayerMetricData.DataList["+ i +"].StuckCount100s");

				describeVodPlayerMetricDataResponse_dataList.Add(datds);
			}
			describeVodPlayerMetricDataResponse.DataList = describeVodPlayerMetricDataResponse_dataList;
        
			return describeVodPlayerMetricDataResponse;
        }
    }
}
