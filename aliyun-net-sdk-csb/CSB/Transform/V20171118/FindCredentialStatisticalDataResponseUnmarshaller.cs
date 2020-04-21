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
    public class FindCredentialStatisticalDataResponseUnmarshaller
    {
        public static FindCredentialStatisticalDataResponse Unmarshall(UnmarshallerContext context)
        {
			FindCredentialStatisticalDataResponse findCredentialStatisticalDataResponse = new FindCredentialStatisticalDataResponse();

			findCredentialStatisticalDataResponse.HttpResponse = context.HttpResponse;
			findCredentialStatisticalDataResponse.Code = context.IntegerValue("FindCredentialStatisticalData.Code");
			findCredentialStatisticalDataResponse.Message = context.StringValue("FindCredentialStatisticalData.Message");
			findCredentialStatisticalDataResponse.RequestId = context.StringValue("FindCredentialStatisticalData.RequestId");

			FindCredentialStatisticalDataResponse.FindCredentialStatisticalData_Data data = new FindCredentialStatisticalDataResponse.FindCredentialStatisticalData_Data();
			data.CurrentPage = context.IntegerValue("FindCredentialStatisticalData.Data.CurrentPage");
			data.PageNumber = context.IntegerValue("FindCredentialStatisticalData.Data.PageNumber");
			data.Total = context.LongValue("FindCredentialStatisticalData.Data.Total");

			List<FindCredentialStatisticalDataResponse.FindCredentialStatisticalData_Data.FindCredentialStatisticalData_ServiceStatisticData> data_monitorStatisticData = new List<FindCredentialStatisticalDataResponse.FindCredentialStatisticalData_Data.FindCredentialStatisticalData_ServiceStatisticData>();
			for (int i = 0; i < context.Length("FindCredentialStatisticalData.Data.MonitorStatisticData.Length"); i++) {
				FindCredentialStatisticalDataResponse.FindCredentialStatisticalData_Data.FindCredentialStatisticalData_ServiceStatisticData serviceStatisticData = new FindCredentialStatisticalDataResponse.FindCredentialStatisticalData_Data.FindCredentialStatisticalData_ServiceStatisticData();
				serviceStatisticData.AvgRt = context.FloatValue("FindCredentialStatisticalData.Data.MonitorStatisticData["+ i +"].AvgRt");
				serviceStatisticData.MaxRt = context.FloatValue("FindCredentialStatisticalData.Data.MonitorStatisticData["+ i +"].MaxRt");
				serviceStatisticData.MinRt = context.FloatValue("FindCredentialStatisticalData.Data.MonitorStatisticData["+ i +"].MinRt");

				FindCredentialStatisticalDataResponse.FindCredentialStatisticalData_Data.FindCredentialStatisticalData_ServiceStatisticData.FindCredentialStatisticalData_Total total = new FindCredentialStatisticalDataResponse.FindCredentialStatisticalData_Data.FindCredentialStatisticalData_ServiceStatisticData.FindCredentialStatisticalData_Total();
				total.Total = context.LongValue("FindCredentialStatisticalData.Data.MonitorStatisticData["+ i +"].Total.Total");
				total.ErrorNum = context.LongValue("FindCredentialStatisticalData.Data.MonitorStatisticData["+ i +"].Total.ErrorNum");
				serviceStatisticData.Total = total;

				FindCredentialStatisticalDataResponse.FindCredentialStatisticalData_Data.FindCredentialStatisticalData_ServiceStatisticData.FindCredentialStatisticalData_CredentialInfoData credentialInfoData = new FindCredentialStatisticalDataResponse.FindCredentialStatisticalData_Data.FindCredentialStatisticalData_ServiceStatisticData.FindCredentialStatisticalData_CredentialInfoData();
				credentialInfoData.CurrentAk = context.StringValue("FindCredentialStatisticalData.Data.MonitorStatisticData["+ i +"].CredentialInfoData.CurrentAk");
				credentialInfoData.CredentialName = context.StringValue("FindCredentialStatisticalData.Data.MonitorStatisticData["+ i +"].CredentialInfoData.CredentialName");
				serviceStatisticData.CredentialInfoData = credentialInfoData;

				data_monitorStatisticData.Add(serviceStatisticData);
			}
			data.MonitorStatisticData = data_monitorStatisticData;
			findCredentialStatisticalDataResponse.Data = data;
        
			return findCredentialStatisticalDataResponse;
        }
    }
}
