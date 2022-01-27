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
using Aliyun.Acs.reid_cloud.Model.V20201029;

namespace Aliyun.Acs.reid_cloud.Transform.V20201029
{
    public class DescribeCameraStatisticsResponseUnmarshaller
    {
        public static DescribeCameraStatisticsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCameraStatisticsResponse describeCameraStatisticsResponse = new DescribeCameraStatisticsResponse();

			describeCameraStatisticsResponse.HttpResponse = _ctx.HttpResponse;
			describeCameraStatisticsResponse.ErrorCode = _ctx.StringValue("DescribeCameraStatistics.ErrorCode");
			describeCameraStatisticsResponse.ErrorMessage = _ctx.StringValue("DescribeCameraStatistics.ErrorMessage");
			describeCameraStatisticsResponse.Message = _ctx.StringValue("DescribeCameraStatistics.Message");
			describeCameraStatisticsResponse.Code = _ctx.StringValue("DescribeCameraStatistics.Code");
			describeCameraStatisticsResponse.DynamicCode = _ctx.StringValue("DescribeCameraStatistics.DynamicCode");
			describeCameraStatisticsResponse.RequestId = _ctx.StringValue("DescribeCameraStatistics.RequestId");
			describeCameraStatisticsResponse.Success = _ctx.BooleanValue("DescribeCameraStatistics.Success");
			describeCameraStatisticsResponse.DynamicMessage = _ctx.StringValue("DescribeCameraStatistics.DynamicMessage");

			List<DescribeCameraStatisticsResponse.DescribeCameraStatistics_PvStatisticResult> describeCameraStatisticsResponse_pvStatisticResults = new List<DescribeCameraStatisticsResponse.DescribeCameraStatistics_PvStatisticResult>();
			for (int i = 0; i < _ctx.Length("DescribeCameraStatistics.PvStatisticResults.Length"); i++) {
				DescribeCameraStatisticsResponse.DescribeCameraStatistics_PvStatisticResult pvStatisticResult = new DescribeCameraStatisticsResponse.DescribeCameraStatistics_PvStatisticResult();
				pvStatisticResult.IpcId = _ctx.LongValue("DescribeCameraStatistics.PvStatisticResults["+ i +"].IpcId");
				pvStatisticResult.MaxDataTime = _ctx.LongValue("DescribeCameraStatistics.PvStatisticResults["+ i +"].MaxDataTime");
				pvStatisticResult.PvCount = _ctx.LongValue("DescribeCameraStatistics.PvStatisticResults["+ i +"].PvCount");
				pvStatisticResult.PvType = _ctx.StringValue("DescribeCameraStatistics.PvStatisticResults["+ i +"].PvType");
				pvStatisticResult.LocationId = _ctx.LongValue("DescribeCameraStatistics.PvStatisticResults["+ i +"].LocationId");

				List<DescribeCameraStatisticsResponse.DescribeCameraStatistics_PvStatisticResult.DescribeCameraStatistics_Rect> pvStatisticResult_pvRects = new List<DescribeCameraStatisticsResponse.DescribeCameraStatistics_PvStatisticResult.DescribeCameraStatistics_Rect>();
				for (int j = 0; j < _ctx.Length("DescribeCameraStatistics.PvStatisticResults["+ i +"].PvRects.Length"); j++) {
					DescribeCameraStatisticsResponse.DescribeCameraStatistics_PvStatisticResult.DescribeCameraStatistics_Rect rect = new DescribeCameraStatisticsResponse.DescribeCameraStatistics_PvStatisticResult.DescribeCameraStatistics_Rect();
					rect.Right = _ctx.FloatValue("DescribeCameraStatistics.PvStatisticResults["+ i +"].PvRects["+ j +"].Right");
					rect.Left = _ctx.FloatValue("DescribeCameraStatistics.PvStatisticResults["+ i +"].PvRects["+ j +"].Left");
					rect.Top = _ctx.FloatValue("DescribeCameraStatistics.PvStatisticResults["+ i +"].PvRects["+ j +"].Top");
					rect.Bottom = _ctx.FloatValue("DescribeCameraStatistics.PvStatisticResults["+ i +"].PvRects["+ j +"].Bottom");

					pvStatisticResult_pvRects.Add(rect);
				}
				pvStatisticResult.PvRects = pvStatisticResult_pvRects;

				describeCameraStatisticsResponse_pvStatisticResults.Add(pvStatisticResult);
			}
			describeCameraStatisticsResponse.PvStatisticResults = describeCameraStatisticsResponse_pvStatisticResults;
        
			return describeCameraStatisticsResponse;
        }
    }
}
