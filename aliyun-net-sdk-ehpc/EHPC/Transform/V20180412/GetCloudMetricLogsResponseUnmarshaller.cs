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
using Aliyun.Acs.EHPC.Model.V20180412;

namespace Aliyun.Acs.EHPC.Transform.V20180412
{
    public class GetCloudMetricLogsResponseUnmarshaller
    {
        public static GetCloudMetricLogsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetCloudMetricLogsResponse getCloudMetricLogsResponse = new GetCloudMetricLogsResponse();

			getCloudMetricLogsResponse.HttpResponse = _ctx.HttpResponse;
			getCloudMetricLogsResponse.RequestId = _ctx.StringValue("GetCloudMetricLogs.RequestId");

			List<GetCloudMetricLogsResponse.GetCloudMetricLogs_MetricLog> getCloudMetricLogsResponse_metricLogs = new List<GetCloudMetricLogsResponse.GetCloudMetricLogs_MetricLog>();
			for (int i = 0; i < _ctx.Length("GetCloudMetricLogs.MetricLogs.Length"); i++) {
				GetCloudMetricLogsResponse.GetCloudMetricLogs_MetricLog metricLog = new GetCloudMetricLogsResponse.GetCloudMetricLogs_MetricLog();
				metricLog.Time = _ctx.IntegerValue("GetCloudMetricLogs.MetricLogs["+ i +"].Time");
				metricLog.InstanceId = _ctx.StringValue("GetCloudMetricLogs.MetricLogs["+ i +"].InstanceId");
				metricLog.Hostname = _ctx.StringValue("GetCloudMetricLogs.MetricLogs["+ i +"].Hostname");
				metricLog.NetworkInterface = _ctx.StringValue("GetCloudMetricLogs.MetricLogs["+ i +"].NetworkInterface");
				metricLog.DiskDevice = _ctx.StringValue("GetCloudMetricLogs.MetricLogs["+ i +"].DiskDevice");
				metricLog.MetricData = _ctx.StringValue("GetCloudMetricLogs.MetricLogs["+ i +"].MetricData");

				getCloudMetricLogsResponse_metricLogs.Add(metricLog);
			}
			getCloudMetricLogsResponse.MetricLogs = getCloudMetricLogsResponse_metricLogs;
        
			return getCloudMetricLogsResponse;
        }
    }
}
