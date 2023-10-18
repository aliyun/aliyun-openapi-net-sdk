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
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeLiveDomainMonitoringUsageDataResponseUnmarshaller
    {
        public static DescribeLiveDomainMonitoringUsageDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveDomainMonitoringUsageDataResponse describeLiveDomainMonitoringUsageDataResponse = new DescribeLiveDomainMonitoringUsageDataResponse();

			describeLiveDomainMonitoringUsageDataResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveDomainMonitoringUsageDataResponse.EndTime = _ctx.StringValue("DescribeLiveDomainMonitoringUsageData.EndTime");
			describeLiveDomainMonitoringUsageDataResponse.StartTime = _ctx.StringValue("DescribeLiveDomainMonitoringUsageData.StartTime");
			describeLiveDomainMonitoringUsageDataResponse.RequestId = _ctx.StringValue("DescribeLiveDomainMonitoringUsageData.RequestId");
			describeLiveDomainMonitoringUsageDataResponse.Region = _ctx.StringValue("DescribeLiveDomainMonitoringUsageData.Region");
			describeLiveDomainMonitoringUsageDataResponse.InstanceId = _ctx.StringValue("DescribeLiveDomainMonitoringUsageData.InstanceId");
			describeLiveDomainMonitoringUsageDataResponse.DomainName = _ctx.StringValue("DescribeLiveDomainMonitoringUsageData.DomainName");

			List<DescribeLiveDomainMonitoringUsageDataResponse.DescribeLiveDomainMonitoringUsageData_MonitoringDataItem> describeLiveDomainMonitoringUsageDataResponse_monitoringData = new List<DescribeLiveDomainMonitoringUsageDataResponse.DescribeLiveDomainMonitoringUsageData_MonitoringDataItem>();
			for (int i = 0; i < _ctx.Length("DescribeLiveDomainMonitoringUsageData.MonitoringData.Length"); i++) {
				DescribeLiveDomainMonitoringUsageDataResponse.DescribeLiveDomainMonitoringUsageData_MonitoringDataItem monitoringDataItem = new DescribeLiveDomainMonitoringUsageDataResponse.DescribeLiveDomainMonitoringUsageData_MonitoringDataItem();
				monitoringDataItem.Region = _ctx.StringValue("DescribeLiveDomainMonitoringUsageData.MonitoringData["+ i +"].Region");
				monitoringDataItem.TimeStamp = _ctx.StringValue("DescribeLiveDomainMonitoringUsageData.MonitoringData["+ i +"].TimeStamp");
				monitoringDataItem.Duration = _ctx.IntegerValue("DescribeLiveDomainMonitoringUsageData.MonitoringData["+ i +"].Duration");
				monitoringDataItem.InstanceId = _ctx.StringValue("DescribeLiveDomainMonitoringUsageData.MonitoringData["+ i +"].InstanceId");
				monitoringDataItem.DomainName = _ctx.StringValue("DescribeLiveDomainMonitoringUsageData.MonitoringData["+ i +"].DomainName");
				monitoringDataItem.Resolution = _ctx.StringValue("DescribeLiveDomainMonitoringUsageData.MonitoringData["+ i +"].Resolution");

				describeLiveDomainMonitoringUsageDataResponse_monitoringData.Add(monitoringDataItem);
			}
			describeLiveDomainMonitoringUsageDataResponse.MonitoringData = describeLiveDomainMonitoringUsageDataResponse_monitoringData;
        
			return describeLiveDomainMonitoringUsageDataResponse;
        }
    }
}
