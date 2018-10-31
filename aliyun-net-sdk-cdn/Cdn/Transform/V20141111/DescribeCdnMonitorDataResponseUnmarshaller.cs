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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Cdn.Model.V20141111;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Transform.V20141111
{
    public class DescribeCdnMonitorDataResponseUnmarshaller
    {
        public static DescribeCdnMonitorDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCdnMonitorDataResponse describeCdnMonitorDataResponse = new DescribeCdnMonitorDataResponse();

			describeCdnMonitorDataResponse.HttpResponse = context.HttpResponse;
			describeCdnMonitorDataResponse.RequestId = context.StringValue("DescribeCdnMonitorData.RequestId");
			describeCdnMonitorDataResponse.DomainName = context.StringValue("DescribeCdnMonitorData.DomainName");
			describeCdnMonitorDataResponse.MonitorInterval = context.LongValue("DescribeCdnMonitorData.MonitorInterval");
			describeCdnMonitorDataResponse.StartTime = context.StringValue("DescribeCdnMonitorData.StartTime");
			describeCdnMonitorDataResponse.EndTime = context.StringValue("DescribeCdnMonitorData.EndTime");

			List<DescribeCdnMonitorDataResponse.DescribeCdnMonitorData_CDNMonitorData> describeCdnMonitorDataResponse_monitorDatas = new List<DescribeCdnMonitorDataResponse.DescribeCdnMonitorData_CDNMonitorData>();
			for (int i = 0; i < context.Length("DescribeCdnMonitorData.MonitorDatas.Length"); i++) {
				DescribeCdnMonitorDataResponse.DescribeCdnMonitorData_CDNMonitorData cDNMonitorData = new DescribeCdnMonitorDataResponse.DescribeCdnMonitorData_CDNMonitorData();
				cDNMonitorData.TimeStamp = context.StringValue("DescribeCdnMonitorData.MonitorDatas["+ i +"].TimeStamp");
				cDNMonitorData.QueryPerSecond = context.StringValue("DescribeCdnMonitorData.MonitorDatas["+ i +"].QueryPerSecond");
				cDNMonitorData.BytesPerSecond = context.StringValue("DescribeCdnMonitorData.MonitorDatas["+ i +"].BytesPerSecond");
				cDNMonitorData.BytesHitRate = context.StringValue("DescribeCdnMonitorData.MonitorDatas["+ i +"].BytesHitRate");
				cDNMonitorData.RequestHitRate = context.StringValue("DescribeCdnMonitorData.MonitorDatas["+ i +"].RequestHitRate");
				cDNMonitorData.AverageObjectSize = context.StringValue("DescribeCdnMonitorData.MonitorDatas["+ i +"].AverageObjectSize");

				describeCdnMonitorDataResponse_monitorDatas.Add(cDNMonitorData);
			}
			describeCdnMonitorDataResponse.MonitorDatas = describeCdnMonitorDataResponse_monitorDatas;
        
			return describeCdnMonitorDataResponse;
        }
    }
}