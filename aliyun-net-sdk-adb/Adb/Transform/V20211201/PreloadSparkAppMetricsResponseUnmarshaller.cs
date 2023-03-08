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
using Aliyun.Acs.adb.Model.V20211201;

namespace Aliyun.Acs.adb.Transform.V20211201
{
    public class PreloadSparkAppMetricsResponseUnmarshaller
    {
        public static PreloadSparkAppMetricsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			PreloadSparkAppMetricsResponse preloadSparkAppMetricsResponse = new PreloadSparkAppMetricsResponse();

			preloadSparkAppMetricsResponse.HttpResponse = _ctx.HttpResponse;
			preloadSparkAppMetricsResponse.RequestId = _ctx.StringValue("PreloadSparkAppMetrics.RequestId");

			PreloadSparkAppMetricsResponse.PreloadSparkAppMetrics_Data data = new PreloadSparkAppMetricsResponse.PreloadSparkAppMetrics_Data();
			data.AppId = _ctx.StringValue("PreloadSparkAppMetrics.Data.AppId");
			data.AttemptId = _ctx.StringValue("PreloadSparkAppMetrics.Data.AttemptId");
			data.Finished = _ctx.BooleanValue("PreloadSparkAppMetrics.Data.Finished");
			data.EventLogPath = _ctx.StringValue("PreloadSparkAppMetrics.Data.EventLogPath");

			PreloadSparkAppMetricsResponse.PreloadSparkAppMetrics_Data.PreloadSparkAppMetrics_ScanMetrics scanMetrics = new PreloadSparkAppMetricsResponse.PreloadSparkAppMetrics_Data.PreloadSparkAppMetrics_ScanMetrics();
			scanMetrics.OutputRowsCount = _ctx.LongValue("PreloadSparkAppMetrics.Data.ScanMetrics.OutputRowsCount");
			scanMetrics.TotalReadFileSizeInByte = _ctx.LongValue("PreloadSparkAppMetrics.Data.ScanMetrics.TotalReadFileSizeInByte");
			data.ScanMetrics = scanMetrics;
			preloadSparkAppMetricsResponse.Data = data;
        
			return preloadSparkAppMetricsResponse;
        }
    }
}
