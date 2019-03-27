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
using Aliyun.Acs.Drds.Model.V20171016;

namespace Aliyun.Acs.Drds.Transform.V20171016
{
    public class DescribeDrdsInstanceMonitorResponseUnmarshaller
    {
        public static DescribeDrdsInstanceMonitorResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDrdsInstanceMonitorResponse describeDrdsInstanceMonitorResponse = new DescribeDrdsInstanceMonitorResponse();

			describeDrdsInstanceMonitorResponse.HttpResponse = context.HttpResponse;
			describeDrdsInstanceMonitorResponse.RequestId = context.StringValue("DescribeDrdsInstanceMonitor.RequestId");
			describeDrdsInstanceMonitorResponse.Success = context.BooleanValue("DescribeDrdsInstanceMonitor.Success");

			List<DescribeDrdsInstanceMonitorResponse.DescribeDrdsInstanceMonitor_PartialPerformanceData> describeDrdsInstanceMonitorResponse_data = new List<DescribeDrdsInstanceMonitorResponse.DescribeDrdsInstanceMonitor_PartialPerformanceData>();
			for (int i = 0; i < context.Length("DescribeDrdsInstanceMonitor.Data.Length"); i++) {
				DescribeDrdsInstanceMonitorResponse.DescribeDrdsInstanceMonitor_PartialPerformanceData partialPerformanceData = new DescribeDrdsInstanceMonitorResponse.DescribeDrdsInstanceMonitor_PartialPerformanceData();
				partialPerformanceData.Key = context.StringValue("DescribeDrdsInstanceMonitor.Data["+ i +"].Key");
				partialPerformanceData.Unit = context.StringValue("DescribeDrdsInstanceMonitor.Data["+ i +"].Unit");

				List<DescribeDrdsInstanceMonitorResponse.DescribeDrdsInstanceMonitor_PartialPerformanceData.DescribeDrdsInstanceMonitor_PerformanceValue> partialPerformanceData_values = new List<DescribeDrdsInstanceMonitorResponse.DescribeDrdsInstanceMonitor_PartialPerformanceData.DescribeDrdsInstanceMonitor_PerformanceValue>();
				for (int j = 0; j < context.Length("DescribeDrdsInstanceMonitor.Data["+ i +"].Values.Length"); j++) {
					DescribeDrdsInstanceMonitorResponse.DescribeDrdsInstanceMonitor_PartialPerformanceData.DescribeDrdsInstanceMonitor_PerformanceValue performanceValue = new DescribeDrdsInstanceMonitorResponse.DescribeDrdsInstanceMonitor_PartialPerformanceData.DescribeDrdsInstanceMonitor_PerformanceValue();
					performanceValue.Date = context.LongValue("DescribeDrdsInstanceMonitor.Data["+ i +"].Values["+ j +"].Date");
					performanceValue._Value = context.StringValue("DescribeDrdsInstanceMonitor.Data["+ i +"].Values["+ j +"].Value");

					partialPerformanceData_values.Add(performanceValue);
				}
				partialPerformanceData.Values = partialPerformanceData_values;

				describeDrdsInstanceMonitorResponse_data.Add(partialPerformanceData);
			}
			describeDrdsInstanceMonitorResponse.Data = describeDrdsInstanceMonitorResponse_data;
        
			return describeDrdsInstanceMonitorResponse;
        }
    }
}
