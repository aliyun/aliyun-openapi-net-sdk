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
    public class DescribeDomainDetailDataByLayerResponseUnmarshaller
    {
        public static DescribeDomainDetailDataByLayerResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDomainDetailDataByLayerResponse describeDomainDetailDataByLayerResponse = new DescribeDomainDetailDataByLayerResponse();

			describeDomainDetailDataByLayerResponse.HttpResponse = context.HttpResponse;
			describeDomainDetailDataByLayerResponse.RequestId = context.StringValue("DescribeDomainDetailDataByLayer.RequestId");

			List<DescribeDomainDetailDataByLayerResponse.DescribeDomainDetailDataByLayer_DataModule> describeDomainDetailDataByLayerResponse_data = new List<DescribeDomainDetailDataByLayerResponse.DescribeDomainDetailDataByLayer_DataModule>();
			for (int i = 0; i < context.Length("DescribeDomainDetailDataByLayer.Data.Length"); i++) {
				DescribeDomainDetailDataByLayerResponse.DescribeDomainDetailDataByLayer_DataModule dataModule = new DescribeDomainDetailDataByLayerResponse.DescribeDomainDetailDataByLayer_DataModule();
				dataModule.TimeStamp = context.StringValue("DescribeDomainDetailDataByLayer.Data["+ i +"].TimeStamp");
				dataModule.DomainName = context.StringValue("DescribeDomainDetailDataByLayer.Data["+ i +"].DomainName");
				dataModule.Bps = context.FloatValue("DescribeDomainDetailDataByLayer.Data["+ i +"].Bps");
				dataModule.Qps = context.FloatValue("DescribeDomainDetailDataByLayer.Data["+ i +"].Qps");
				dataModule.Traf = context.LongValue("DescribeDomainDetailDataByLayer.Data["+ i +"].Traf");
				dataModule.Acc = context.LongValue("DescribeDomainDetailDataByLayer.Data["+ i +"].Acc");
				dataModule.Ipv6Traf = context.LongValue("DescribeDomainDetailDataByLayer.Data["+ i +"].Ipv6Traf");
				dataModule.Ipv6Bps = context.FloatValue("DescribeDomainDetailDataByLayer.Data["+ i +"].Ipv6Bps");
				dataModule.Ipv6Acc = context.LongValue("DescribeDomainDetailDataByLayer.Data["+ i +"].Ipv6Acc");
				dataModule.Ipv6Qps = context.FloatValue("DescribeDomainDetailDataByLayer.Data["+ i +"].Ipv6Qps");
				dataModule.HttpCode = context.StringValue("DescribeDomainDetailDataByLayer.Data["+ i +"].HttpCode");

				describeDomainDetailDataByLayerResponse_data.Add(dataModule);
			}
			describeDomainDetailDataByLayerResponse.Data = describeDomainDetailDataByLayerResponse_data;
        
			return describeDomainDetailDataByLayerResponse;
        }
    }
}
