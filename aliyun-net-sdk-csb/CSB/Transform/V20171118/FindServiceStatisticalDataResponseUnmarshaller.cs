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
using Aliyun.Acs.CSB.Model.V20171118;

namespace Aliyun.Acs.CSB.Transform.V20171118
{
    public class FindServiceStatisticalDataResponseUnmarshaller
    {
        public static FindServiceStatisticalDataResponse Unmarshall(UnmarshallerContext context)
        {
			FindServiceStatisticalDataResponse findServiceStatisticalDataResponse = new FindServiceStatisticalDataResponse();

			findServiceStatisticalDataResponse.HttpResponse = context.HttpResponse;
			findServiceStatisticalDataResponse.Code = context.IntegerValue("FindServiceStatisticalData.Code");
			findServiceStatisticalDataResponse.Message = context.StringValue("FindServiceStatisticalData.Message");
			findServiceStatisticalDataResponse.RequestId = context.StringValue("FindServiceStatisticalData.RequestId");

			FindServiceStatisticalDataResponse.FindServiceStatisticalData_Data data = new FindServiceStatisticalDataResponse.FindServiceStatisticalData_Data();
			data.CurrentPage = context.IntegerValue("FindServiceStatisticalData.Data.CurrentPage");
			data.PageNumber = context.IntegerValue("FindServiceStatisticalData.Data.PageNumber");
			data.Total = context.LongValue("FindServiceStatisticalData.Data.Total");

			List<FindServiceStatisticalDataResponse.FindServiceStatisticalData_Data.FindServiceStatisticalData_ServiceStatisticData> data_monitorStatisticData = new List<FindServiceStatisticalDataResponse.FindServiceStatisticalData_Data.FindServiceStatisticalData_ServiceStatisticData>();
			for (int i = 0; i < context.Length("FindServiceStatisticalData.Data.MonitorStatisticData.Length"); i++) {
				FindServiceStatisticalDataResponse.FindServiceStatisticalData_Data.FindServiceStatisticalData_ServiceStatisticData serviceStatisticData = new FindServiceStatisticalDataResponse.FindServiceStatisticalData_Data.FindServiceStatisticalData_ServiceStatisticData();
				serviceStatisticData.AvgRt = context.FloatValue("FindServiceStatisticalData.Data.MonitorStatisticData["+ i +"].AvgRt");
				serviceStatisticData.MaxRt = context.FloatValue("FindServiceStatisticalData.Data.MonitorStatisticData["+ i +"].MaxRt");
				serviceStatisticData.MinRt = context.FloatValue("FindServiceStatisticalData.Data.MonitorStatisticData["+ i +"].MinRt");
				serviceStatisticData.ServiceName = context.StringValue("FindServiceStatisticalData.Data.MonitorStatisticData["+ i +"].ServiceName");

				FindServiceStatisticalDataResponse.FindServiceStatisticalData_Data.FindServiceStatisticalData_ServiceStatisticData.FindServiceStatisticalData_Total total = new FindServiceStatisticalDataResponse.FindServiceStatisticalData_Data.FindServiceStatisticalData_ServiceStatisticData.FindServiceStatisticalData_Total();
				total.Total = context.LongValue("FindServiceStatisticalData.Data.MonitorStatisticData["+ i +"].Total.Total");
				total.ErrorNum = context.LongValue("FindServiceStatisticalData.Data.MonitorStatisticData["+ i +"].Total.ErrorNum");
				serviceStatisticData.Total = total;

				data_monitorStatisticData.Add(serviceStatisticData);
			}
			data.MonitorStatisticData = data_monitorStatisticData;
			findServiceStatisticalDataResponse.Data = data;
        
			return findServiceStatisticalDataResponse;
        }
    }
}
