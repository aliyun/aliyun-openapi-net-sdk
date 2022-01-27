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
using Aliyun.Acs.Drds.Model.V20190123;

namespace Aliyun.Acs.Drds.Transform.V20190123
{
    public class DescribeDrdsInstanceDbMonitorResponseUnmarshaller
    {
        public static DescribeDrdsInstanceDbMonitorResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDrdsInstanceDbMonitorResponse describeDrdsInstanceDbMonitorResponse = new DescribeDrdsInstanceDbMonitorResponse();

			describeDrdsInstanceDbMonitorResponse.HttpResponse = _ctx.HttpResponse;
			describeDrdsInstanceDbMonitorResponse.RequestId = _ctx.StringValue("DescribeDrdsInstanceDbMonitor.RequestId");
			describeDrdsInstanceDbMonitorResponse.Success = _ctx.BooleanValue("DescribeDrdsInstanceDbMonitor.Success");

			List<DescribeDrdsInstanceDbMonitorResponse.DescribeDrdsInstanceDbMonitor_PartialPerformanceData> describeDrdsInstanceDbMonitorResponse_data = new List<DescribeDrdsInstanceDbMonitorResponse.DescribeDrdsInstanceDbMonitor_PartialPerformanceData>();
			for (int i = 0; i < _ctx.Length("DescribeDrdsInstanceDbMonitor.Data.Length"); i++) {
				DescribeDrdsInstanceDbMonitorResponse.DescribeDrdsInstanceDbMonitor_PartialPerformanceData partialPerformanceData = new DescribeDrdsInstanceDbMonitorResponse.DescribeDrdsInstanceDbMonitor_PartialPerformanceData();
				partialPerformanceData.Key = _ctx.StringValue("DescribeDrdsInstanceDbMonitor.Data["+ i +"].Key");
				partialPerformanceData.Unit = _ctx.StringValue("DescribeDrdsInstanceDbMonitor.Data["+ i +"].Unit");

				List<DescribeDrdsInstanceDbMonitorResponse.DescribeDrdsInstanceDbMonitor_PartialPerformanceData.DescribeDrdsInstanceDbMonitor_PerformanceValue> partialPerformanceData_values = new List<DescribeDrdsInstanceDbMonitorResponse.DescribeDrdsInstanceDbMonitor_PartialPerformanceData.DescribeDrdsInstanceDbMonitor_PerformanceValue>();
				for (int j = 0; j < _ctx.Length("DescribeDrdsInstanceDbMonitor.Data["+ i +"].Values.Length"); j++) {
					DescribeDrdsInstanceDbMonitorResponse.DescribeDrdsInstanceDbMonitor_PartialPerformanceData.DescribeDrdsInstanceDbMonitor_PerformanceValue performanceValue = new DescribeDrdsInstanceDbMonitorResponse.DescribeDrdsInstanceDbMonitor_PartialPerformanceData.DescribeDrdsInstanceDbMonitor_PerformanceValue();
					performanceValue.Date = _ctx.LongValue("DescribeDrdsInstanceDbMonitor.Data["+ i +"].Values["+ j +"].Date");
					performanceValue._Value = _ctx.StringValue("DescribeDrdsInstanceDbMonitor.Data["+ i +"].Values["+ j +"].Value");

					partialPerformanceData_values.Add(performanceValue);
				}
				partialPerformanceData.Values = partialPerformanceData_values;

				describeDrdsInstanceDbMonitorResponse_data.Add(partialPerformanceData);
			}
			describeDrdsInstanceDbMonitorResponse.Data = describeDrdsInstanceDbMonitorResponse_data;
        
			return describeDrdsInstanceDbMonitorResponse;
        }
    }
}
