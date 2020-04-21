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
    public class FindServiceCredentialStatisticalDataResponseUnmarshaller
    {
        public static FindServiceCredentialStatisticalDataResponse Unmarshall(UnmarshallerContext context)
        {
			FindServiceCredentialStatisticalDataResponse findServiceCredentialStatisticalDataResponse = new FindServiceCredentialStatisticalDataResponse();

			findServiceCredentialStatisticalDataResponse.HttpResponse = context.HttpResponse;
			findServiceCredentialStatisticalDataResponse.Code = context.IntegerValue("FindServiceCredentialStatisticalData.Code");
			findServiceCredentialStatisticalDataResponse.Message = context.StringValue("FindServiceCredentialStatisticalData.Message");
			findServiceCredentialStatisticalDataResponse.RequestId = context.StringValue("FindServiceCredentialStatisticalData.RequestId");

			FindServiceCredentialStatisticalDataResponse.FindServiceCredentialStatisticalData_Data data = new FindServiceCredentialStatisticalDataResponse.FindServiceCredentialStatisticalData_Data();
			data.CurrentPage = context.IntegerValue("FindServiceCredentialStatisticalData.Data.CurrentPage");
			data.PageNumber = context.IntegerValue("FindServiceCredentialStatisticalData.Data.PageNumber");
			data.Total = context.LongValue("FindServiceCredentialStatisticalData.Data.Total");

			List<FindServiceCredentialStatisticalDataResponse.FindServiceCredentialStatisticalData_Data.FindServiceCredentialStatisticalData_ServiceStatisticData> data_monitorStatisticData = new List<FindServiceCredentialStatisticalDataResponse.FindServiceCredentialStatisticalData_Data.FindServiceCredentialStatisticalData_ServiceStatisticData>();
			for (int i = 0; i < context.Length("FindServiceCredentialStatisticalData.Data.MonitorStatisticData.Length"); i++) {
				FindServiceCredentialStatisticalDataResponse.FindServiceCredentialStatisticalData_Data.FindServiceCredentialStatisticalData_ServiceStatisticData serviceStatisticData = new FindServiceCredentialStatisticalDataResponse.FindServiceCredentialStatisticalData_Data.FindServiceCredentialStatisticalData_ServiceStatisticData();
				serviceStatisticData.AvgRt = context.FloatValue("FindServiceCredentialStatisticalData.Data.MonitorStatisticData["+ i +"].AvgRt");
				serviceStatisticData.MaxRt = context.FloatValue("FindServiceCredentialStatisticalData.Data.MonitorStatisticData["+ i +"].MaxRt");
				serviceStatisticData.MinRt = context.FloatValue("FindServiceCredentialStatisticalData.Data.MonitorStatisticData["+ i +"].MinRt");
				serviceStatisticData.ServiceName = context.StringValue("FindServiceCredentialStatisticalData.Data.MonitorStatisticData["+ i +"].ServiceName");
				serviceStatisticData.CredentialName = context.StringValue("FindServiceCredentialStatisticalData.Data.MonitorStatisticData["+ i +"].CredentialName");

				FindServiceCredentialStatisticalDataResponse.FindServiceCredentialStatisticalData_Data.FindServiceCredentialStatisticalData_ServiceStatisticData.FindServiceCredentialStatisticalData_Total total = new FindServiceCredentialStatisticalDataResponse.FindServiceCredentialStatisticalData_Data.FindServiceCredentialStatisticalData_ServiceStatisticData.FindServiceCredentialStatisticalData_Total();
				total.Total = context.LongValue("FindServiceCredentialStatisticalData.Data.MonitorStatisticData["+ i +"].Total.Total");
				total.ErrorNum = context.LongValue("FindServiceCredentialStatisticalData.Data.MonitorStatisticData["+ i +"].Total.ErrorNum");
				serviceStatisticData.Total = total;

				data_monitorStatisticData.Add(serviceStatisticData);
			}
			data.MonitorStatisticData = data_monitorStatisticData;
			findServiceCredentialStatisticalDataResponse.Data = data;
        
			return findServiceCredentialStatisticalDataResponse;
        }
    }
}
