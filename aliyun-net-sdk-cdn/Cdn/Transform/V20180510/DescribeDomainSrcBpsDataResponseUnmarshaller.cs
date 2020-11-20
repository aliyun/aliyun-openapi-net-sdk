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
using Aliyun.Acs.Cdn.Model.V20180510;

namespace Aliyun.Acs.Cdn.Transform.V20180510
{
    public class DescribeDomainSrcBpsDataResponseUnmarshaller
    {
        public static DescribeDomainSrcBpsDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDomainSrcBpsDataResponse describeDomainSrcBpsDataResponse = new DescribeDomainSrcBpsDataResponse();

			describeDomainSrcBpsDataResponse.HttpResponse = _ctx.HttpResponse;
			describeDomainSrcBpsDataResponse.RequestId = _ctx.StringValue("DescribeDomainSrcBpsData.RequestId");
			describeDomainSrcBpsDataResponse.DomainName = _ctx.StringValue("DescribeDomainSrcBpsData.DomainName");
			describeDomainSrcBpsDataResponse.StartTime = _ctx.StringValue("DescribeDomainSrcBpsData.StartTime");
			describeDomainSrcBpsDataResponse.EndTime = _ctx.StringValue("DescribeDomainSrcBpsData.EndTime");
			describeDomainSrcBpsDataResponse.DataInterval = _ctx.StringValue("DescribeDomainSrcBpsData.DataInterval");

			List<DescribeDomainSrcBpsDataResponse.DescribeDomainSrcBpsData_DataModule> describeDomainSrcBpsDataResponse_srcBpsDataPerInterval = new List<DescribeDomainSrcBpsDataResponse.DescribeDomainSrcBpsData_DataModule>();
			for (int i = 0; i < _ctx.Length("DescribeDomainSrcBpsData.SrcBpsDataPerInterval.Length"); i++) {
				DescribeDomainSrcBpsDataResponse.DescribeDomainSrcBpsData_DataModule dataModule = new DescribeDomainSrcBpsDataResponse.DescribeDomainSrcBpsData_DataModule();
				dataModule.TimeStamp = _ctx.StringValue("DescribeDomainSrcBpsData.SrcBpsDataPerInterval["+ i +"].TimeStamp");
				dataModule._Value = _ctx.StringValue("DescribeDomainSrcBpsData.SrcBpsDataPerInterval["+ i +"].Value");
				dataModule.HttpsValue = _ctx.StringValue("DescribeDomainSrcBpsData.SrcBpsDataPerInterval["+ i +"].HttpsValue");

				describeDomainSrcBpsDataResponse_srcBpsDataPerInterval.Add(dataModule);
			}
			describeDomainSrcBpsDataResponse.SrcBpsDataPerInterval = describeDomainSrcBpsDataResponse_srcBpsDataPerInterval;
        
			return describeDomainSrcBpsDataResponse;
        }
    }
}
