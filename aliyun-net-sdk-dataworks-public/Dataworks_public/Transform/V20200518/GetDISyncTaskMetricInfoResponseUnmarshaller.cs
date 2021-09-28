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
using Aliyun.Acs.dataworks_public.Model.V20200518;

namespace Aliyun.Acs.dataworks_public.Transform.V20200518
{
    public class GetDISyncTaskMetricInfoResponseUnmarshaller
    {
        public static GetDISyncTaskMetricInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetDISyncTaskMetricInfoResponse getDISyncTaskMetricInfoResponse = new GetDISyncTaskMetricInfoResponse();

			getDISyncTaskMetricInfoResponse.HttpResponse = _ctx.HttpResponse;
			getDISyncTaskMetricInfoResponse.RequestId = _ctx.StringValue("GetDISyncTaskMetricInfo.RequestId");
			getDISyncTaskMetricInfoResponse.Success = _ctx.BooleanValue("GetDISyncTaskMetricInfo.Success");

			GetDISyncTaskMetricInfoResponse.GetDISyncTaskMetricInfo_MetricInfo metricInfo = new GetDISyncTaskMetricInfoResponse.GetDISyncTaskMetricInfo_MetricInfo();
			metricInfo.Message = _ctx.StringValue("GetDISyncTaskMetricInfo.MetricInfo.Message");
			metricInfo.SumReaderRecords = _ctx.LongValue("GetDISyncTaskMetricInfo.MetricInfo.SumReaderRecords");
			metricInfo.SumWriterRecords = _ctx.LongValue("GetDISyncTaskMetricInfo.MetricInfo.SumWriterRecords");
			metricInfo.LastTaskDelay = _ctx.LongValue("GetDISyncTaskMetricInfo.MetricInfo.LastTaskDelay");
			metricInfo.InsertReaderRecords = _ctx.LongValue("GetDISyncTaskMetricInfo.MetricInfo.InsertReaderRecords");
			metricInfo.UpdateReaderRecords = _ctx.LongValue("GetDISyncTaskMetricInfo.MetricInfo.UpdateReaderRecords");
			metricInfo.DeleteReaderRecords = _ctx.LongValue("GetDISyncTaskMetricInfo.MetricInfo.DeleteReaderRecords");
			metricInfo.InsertWriterRecords = _ctx.LongValue("GetDISyncTaskMetricInfo.MetricInfo.InsertWriterRecords");
			metricInfo.UpdateWriterRecords = _ctx.LongValue("GetDISyncTaskMetricInfo.MetricInfo.UpdateWriterRecords");
			metricInfo.DeleteWriterRecords = _ctx.LongValue("GetDISyncTaskMetricInfo.MetricInfo.DeleteWriterRecords");
			getDISyncTaskMetricInfoResponse.MetricInfo = metricInfo;
        
			return getDISyncTaskMetricInfoResponse;
        }
    }
}
