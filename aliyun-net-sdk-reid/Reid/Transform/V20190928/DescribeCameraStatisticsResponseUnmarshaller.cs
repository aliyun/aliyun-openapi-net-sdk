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
using Aliyun.Acs.reid.Model.V20190928;

namespace Aliyun.Acs.reid.Transform.V20190928
{
    public class DescribeCameraStatisticsResponseUnmarshaller
    {
        public static DescribeCameraStatisticsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCameraStatisticsResponse describeCameraStatisticsResponse = new DescribeCameraStatisticsResponse();

			describeCameraStatisticsResponse.HttpResponse = context.HttpResponse;
			describeCameraStatisticsResponse.ErrorCode = context.StringValue("DescribeCameraStatistics.ErrorCode");
			describeCameraStatisticsResponse.ErrorMessage = context.StringValue("DescribeCameraStatistics.ErrorMessage");
			describeCameraStatisticsResponse.Message = context.StringValue("DescribeCameraStatistics.Message");
			describeCameraStatisticsResponse.Code = context.StringValue("DescribeCameraStatistics.Code");
			describeCameraStatisticsResponse.DynamicCode = context.StringValue("DescribeCameraStatistics.DynamicCode");
			describeCameraStatisticsResponse.RequestId = context.StringValue("DescribeCameraStatistics.RequestId");
			describeCameraStatisticsResponse.Success = context.BooleanValue("DescribeCameraStatistics.Success");
			describeCameraStatisticsResponse.DynamicMessage = context.StringValue("DescribeCameraStatistics.DynamicMessage");

			List<DescribeCameraStatisticsResponse.DescribeCameraStatistics_PvStatisticResult> describeCameraStatisticsResponse_pvStatisticResults = new List<DescribeCameraStatisticsResponse.DescribeCameraStatistics_PvStatisticResult>();
			for (int i = 0; i < context.Length("DescribeCameraStatistics.PvStatisticResults.Length"); i++) {
				DescribeCameraStatisticsResponse.DescribeCameraStatistics_PvStatisticResult pvStatisticResult = new DescribeCameraStatisticsResponse.DescribeCameraStatistics_PvStatisticResult();
				pvStatisticResult.ProcessCursor = context.LongValue("DescribeCameraStatistics.PvStatisticResults["+ i +"].ProcessCursor");
				pvStatisticResult.IpcId = context.LongValue("DescribeCameraStatistics.PvStatisticResults["+ i +"].IpcId");
				pvStatisticResult.PvCount = context.LongValue("DescribeCameraStatistics.PvStatisticResults["+ i +"].PvCount");
				pvStatisticResult.LocationId = context.LongValue("DescribeCameraStatistics.PvStatisticResults["+ i +"].LocationId");
				pvStatisticResult.PvType = context.StringValue("DescribeCameraStatistics.PvStatisticResults["+ i +"].PvType");
				pvStatisticResult.MaxDataTime = context.LongValue("DescribeCameraStatistics.PvStatisticResults["+ i +"].MaxDataTime");

				List<DescribeCameraStatisticsResponse.DescribeCameraStatistics_PvStatisticResult.DescribeCameraStatistics_Rect> pvStatisticResult_pvRects = new List<DescribeCameraStatisticsResponse.DescribeCameraStatistics_PvStatisticResult.DescribeCameraStatistics_Rect>();
				for (int j = 0; j < context.Length("DescribeCameraStatistics.PvStatisticResults["+ i +"].PvRects.Length"); j++) {
					DescribeCameraStatisticsResponse.DescribeCameraStatistics_PvStatisticResult.DescribeCameraStatistics_Rect rect = new DescribeCameraStatisticsResponse.DescribeCameraStatistics_PvStatisticResult.DescribeCameraStatistics_Rect();
					rect.Right = context.FloatValue("DescribeCameraStatistics.PvStatisticResults["+ i +"].PvRects["+ j +"].Right");
					rect.Left = context.FloatValue("DescribeCameraStatistics.PvStatisticResults["+ i +"].PvRects["+ j +"].Left");
					rect.Top = context.FloatValue("DescribeCameraStatistics.PvStatisticResults["+ i +"].PvRects["+ j +"].Top");
					rect.Bottom = context.FloatValue("DescribeCameraStatistics.PvStatisticResults["+ i +"].PvRects["+ j +"].Bottom");

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
