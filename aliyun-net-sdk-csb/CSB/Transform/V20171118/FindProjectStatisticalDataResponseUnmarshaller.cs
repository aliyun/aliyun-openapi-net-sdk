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
    public class FindProjectStatisticalDataResponseUnmarshaller
    {
        public static FindProjectStatisticalDataResponse Unmarshall(UnmarshallerContext context)
        {
			FindProjectStatisticalDataResponse findProjectStatisticalDataResponse = new FindProjectStatisticalDataResponse();

			findProjectStatisticalDataResponse.HttpResponse = context.HttpResponse;
			findProjectStatisticalDataResponse.Code = context.IntegerValue("FindProjectStatisticalData.Code");
			findProjectStatisticalDataResponse.Message = context.StringValue("FindProjectStatisticalData.Message");
			findProjectStatisticalDataResponse.RequestId = context.StringValue("FindProjectStatisticalData.RequestId");

			FindProjectStatisticalDataResponse.FindProjectStatisticalData_Data data = new FindProjectStatisticalDataResponse.FindProjectStatisticalData_Data();
			data.CurrentPage = context.IntegerValue("FindProjectStatisticalData.Data.CurrentPage");
			data.PageNumber = context.IntegerValue("FindProjectStatisticalData.Data.PageNumber");
			data.Total = context.LongValue("FindProjectStatisticalData.Data.Total");

			List<FindProjectStatisticalDataResponse.FindProjectStatisticalData_Data.FindProjectStatisticalData_ServiceStatisticData> data_monitorStatisticData = new List<FindProjectStatisticalDataResponse.FindProjectStatisticalData_Data.FindProjectStatisticalData_ServiceStatisticData>();
			for (int i = 0; i < context.Length("FindProjectStatisticalData.Data.MonitorStatisticData.Length"); i++) {
				FindProjectStatisticalDataResponse.FindProjectStatisticalData_Data.FindProjectStatisticalData_ServiceStatisticData serviceStatisticData = new FindProjectStatisticalDataResponse.FindProjectStatisticalData_Data.FindProjectStatisticalData_ServiceStatisticData();
				serviceStatisticData.AvgRt = context.FloatValue("FindProjectStatisticalData.Data.MonitorStatisticData["+ i +"].AvgRt");
				serviceStatisticData.MaxRt = context.FloatValue("FindProjectStatisticalData.Data.MonitorStatisticData["+ i +"].MaxRt");
				serviceStatisticData.MinRt = context.FloatValue("FindProjectStatisticalData.Data.MonitorStatisticData["+ i +"].MinRt");

				FindProjectStatisticalDataResponse.FindProjectStatisticalData_Data.FindProjectStatisticalData_ServiceStatisticData.FindProjectStatisticalData_Total total = new FindProjectStatisticalDataResponse.FindProjectStatisticalData_Data.FindProjectStatisticalData_ServiceStatisticData.FindProjectStatisticalData_Total();
				total.Total = context.LongValue("FindProjectStatisticalData.Data.MonitorStatisticData["+ i +"].Total.Total");
				total.ErrorNum = context.LongValue("FindProjectStatisticalData.Data.MonitorStatisticData["+ i +"].Total.ErrorNum");
				serviceStatisticData.Total = total;

				FindProjectStatisticalDataResponse.FindProjectStatisticalData_Data.FindProjectStatisticalData_ServiceStatisticData.FindProjectStatisticalData_ProjectInfoData projectInfoData = new FindProjectStatisticalDataResponse.FindProjectStatisticalData_Data.FindProjectStatisticalData_ServiceStatisticData.FindProjectStatisticalData_ProjectInfoData();
				projectInfoData.ProjectName = context.StringValue("FindProjectStatisticalData.Data.MonitorStatisticData["+ i +"].ProjectInfoData.ProjectName");
				serviceStatisticData.ProjectInfoData = projectInfoData;

				data_monitorStatisticData.Add(serviceStatisticData);
			}
			data.MonitorStatisticData = data_monitorStatisticData;
			findProjectStatisticalDataResponse.Data = data;
        
			return findProjectStatisticalDataResponse;
        }
    }
}
