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
using Aliyun.Acs.cusanalytic_sc_online.Model.V20190524;

namespace Aliyun.Acs.cusanalytic_sc_online.Transform.V20190524
{
    public class GetCameraStatisticResponseUnmarshaller
    {
        public static GetCameraStatisticResponse Unmarshall(UnmarshallerContext context)
        {
			GetCameraStatisticResponse getCameraStatisticResponse = new GetCameraStatisticResponse();

			getCameraStatisticResponse.HttpResponse = context.HttpResponse;
			getCameraStatisticResponse.RequestId = context.StringValue("GetCameraStatistic.RequestId");
			getCameraStatisticResponse.ErrorMsg = context.StringValue("GetCameraStatistic.ErrorMsg");
			getCameraStatisticResponse.Success = context.BooleanValue("GetCameraStatistic.Success");

			List<GetCameraStatisticResponse.GetCameraStatistic_PvStatisticResult> getCameraStatisticResponse_pvStatisticResults = new List<GetCameraStatisticResponse.GetCameraStatistic_PvStatisticResult>();
			for (int i = 0; i < context.Length("GetCameraStatistic.PvStatisticResults.Length"); i++) {
				GetCameraStatisticResponse.GetCameraStatistic_PvStatisticResult pvStatisticResult = new GetCameraStatisticResponse.GetCameraStatistic_PvStatisticResult();
				pvStatisticResult.ProcessCursor = context.LongValue("GetCameraStatistic.PvStatisticResults["+ i +"].ProcessCursor");
				pvStatisticResult.IpcId = context.LongValue("GetCameraStatistic.PvStatisticResults["+ i +"].IpcId");
				pvStatisticResult.LocationId = context.LongValue("GetCameraStatistic.PvStatisticResults["+ i +"].LocationId");
				pvStatisticResult.PvCount = context.LongValue("GetCameraStatistic.PvStatisticResults["+ i +"].PvCount");

				List<GetCameraStatisticResponse.GetCameraStatistic_PvStatisticResult.GetCameraStatistic_Rect> pvStatisticResult_pvRects = new List<GetCameraStatisticResponse.GetCameraStatistic_PvStatisticResult.GetCameraStatistic_Rect>();
				for (int j = 0; j < context.Length("GetCameraStatistic.PvStatisticResults["+ i +"].PvRects.Length"); j++) {
					GetCameraStatisticResponse.GetCameraStatistic_PvStatisticResult.GetCameraStatistic_Rect rect = new GetCameraStatisticResponse.GetCameraStatistic_PvStatisticResult.GetCameraStatistic_Rect();
					rect.Right = context.FloatValue("GetCameraStatistic.PvStatisticResults["+ i +"].PvRects["+ j +"].Right");
					rect.Bottom = context.FloatValue("GetCameraStatistic.PvStatisticResults["+ i +"].PvRects["+ j +"].Bottom");
					rect.Top = context.FloatValue("GetCameraStatistic.PvStatisticResults["+ i +"].PvRects["+ j +"].Top");
					rect.Left = context.FloatValue("GetCameraStatistic.PvStatisticResults["+ i +"].PvRects["+ j +"].Left");

					pvStatisticResult_pvRects.Add(rect);
				}
				pvStatisticResult.PvRects = pvStatisticResult_pvRects;

				getCameraStatisticResponse_pvStatisticResults.Add(pvStatisticResult);
			}
			getCameraStatisticResponse.PvStatisticResults = getCameraStatisticResponse_pvStatisticResults;
        
			return getCameraStatisticResponse;
        }
    }
}
