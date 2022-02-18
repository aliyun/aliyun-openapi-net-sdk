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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class GisSearchDeviceTraceResponseUnmarshaller
    {
        public static GisSearchDeviceTraceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GisSearchDeviceTraceResponse gisSearchDeviceTraceResponse = new GisSearchDeviceTraceResponse();

			gisSearchDeviceTraceResponse.HttpResponse = _ctx.HttpResponse;
			gisSearchDeviceTraceResponse.RequestId = _ctx.StringValue("GisSearchDeviceTrace.RequestId");
			gisSearchDeviceTraceResponse.Success = _ctx.BooleanValue("GisSearchDeviceTrace.Success");
			gisSearchDeviceTraceResponse.Code = _ctx.StringValue("GisSearchDeviceTrace.Code");
			gisSearchDeviceTraceResponse.ErrorMessage = _ctx.StringValue("GisSearchDeviceTrace.ErrorMessage");

			GisSearchDeviceTraceResponse.GisSearchDeviceTrace_Data data = new GisSearchDeviceTraceResponse.GisSearchDeviceTrace_Data();
			data.ProductKey = _ctx.StringValue("GisSearchDeviceTrace.Data.ProductKey");
			data.DeviceName = _ctx.StringValue("GisSearchDeviceTrace.Data.DeviceName");

			List<GisSearchDeviceTraceResponse.GisSearchDeviceTrace_Data.GisSearchDeviceTrace_PointsItem> data_points = new List<GisSearchDeviceTraceResponse.GisSearchDeviceTrace_Data.GisSearchDeviceTrace_PointsItem>();
			for (int i = 0; i < _ctx.Length("GisSearchDeviceTrace.Data.Points.Length"); i++) {
				GisSearchDeviceTraceResponse.GisSearchDeviceTrace_Data.GisSearchDeviceTrace_PointsItem pointsItem = new GisSearchDeviceTraceResponse.GisSearchDeviceTrace_Data.GisSearchDeviceTrace_PointsItem();
				pointsItem.Location = _ctx.StringValue("GisSearchDeviceTrace.Data.Points["+ i +"].Location");
				pointsItem.LocateTime = _ctx.LongValue("GisSearchDeviceTrace.Data.Points["+ i +"].LocateTime");

				data_points.Add(pointsItem);
			}
			data.Points = data_points;
			gisSearchDeviceTraceResponse.Data = data;
        
			return gisSearchDeviceTraceResponse;
        }
    }
}
