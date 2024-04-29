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
    public class DescribeLiveProducerUsageDataResponseUnmarshaller
    {
        public static DescribeLiveProducerUsageDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveProducerUsageDataResponse describeLiveProducerUsageDataResponse = new DescribeLiveProducerUsageDataResponse();

			describeLiveProducerUsageDataResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveProducerUsageDataResponse.EndTime = _ctx.StringValue("DescribeLiveProducerUsageData.EndTime");
			describeLiveProducerUsageDataResponse.RequestId = _ctx.StringValue("DescribeLiveProducerUsageData.RequestId");
			describeLiveProducerUsageDataResponse.StartTime = _ctx.StringValue("DescribeLiveProducerUsageData.StartTime");

			List<DescribeLiveProducerUsageDataResponse.DescribeLiveProducerUsageData_BillProducerDataItem> describeLiveProducerUsageDataResponse_billProducerData = new List<DescribeLiveProducerUsageDataResponse.DescribeLiveProducerUsageData_BillProducerDataItem>();
			for (int i = 0; i < _ctx.Length("DescribeLiveProducerUsageData.BillProducerData.Length"); i++) {
				DescribeLiveProducerUsageDataResponse.DescribeLiveProducerUsageData_BillProducerDataItem billProducerDataItem = new DescribeLiveProducerUsageDataResponse.DescribeLiveProducerUsageData_BillProducerDataItem();
				billProducerDataItem.DomainName = _ctx.StringValue("DescribeLiveProducerUsageData.BillProducerData["+ i +"].DomainName");
				billProducerDataItem.Instance = _ctx.StringValue("DescribeLiveProducerUsageData.BillProducerData["+ i +"].Instance");
				billProducerDataItem.OutputHdDuration = _ctx.LongValue("DescribeLiveProducerUsageData.BillProducerData["+ i +"].OutputHdDuration");
				billProducerDataItem.OutputLdDuration = _ctx.LongValue("DescribeLiveProducerUsageData.BillProducerData["+ i +"].OutputLdDuration");
				billProducerDataItem.OutputSdDuration = _ctx.LongValue("DescribeLiveProducerUsageData.BillProducerData["+ i +"].OutputSdDuration");
				billProducerDataItem.Region = _ctx.StringValue("DescribeLiveProducerUsageData.BillProducerData["+ i +"].Region");
				billProducerDataItem.TimeStamp = _ctx.StringValue("DescribeLiveProducerUsageData.BillProducerData["+ i +"].TimeStamp");
				billProducerDataItem.TranHdDuration = _ctx.LongValue("DescribeLiveProducerUsageData.BillProducerData["+ i +"].TranHdDuration");
				billProducerDataItem.TranLdDuration = _ctx.LongValue("DescribeLiveProducerUsageData.BillProducerData["+ i +"].TranLdDuration");
				billProducerDataItem.TranSdDuration = _ctx.LongValue("DescribeLiveProducerUsageData.BillProducerData["+ i +"].TranSdDuration");
				billProducerDataItem.Type = _ctx.StringValue("DescribeLiveProducerUsageData.BillProducerData["+ i +"].Type");

				describeLiveProducerUsageDataResponse_billProducerData.Add(billProducerDataItem);
			}
			describeLiveProducerUsageDataResponse.BillProducerData = describeLiveProducerUsageDataResponse_billProducerData;
        
			return describeLiveProducerUsageDataResponse;
        }
    }
}
