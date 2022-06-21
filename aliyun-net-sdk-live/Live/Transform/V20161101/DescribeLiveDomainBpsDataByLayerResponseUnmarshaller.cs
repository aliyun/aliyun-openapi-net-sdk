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
    public class DescribeLiveDomainBpsDataByLayerResponseUnmarshaller
    {
        public static DescribeLiveDomainBpsDataByLayerResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveDomainBpsDataByLayerResponse describeLiveDomainBpsDataByLayerResponse = new DescribeLiveDomainBpsDataByLayerResponse();

			describeLiveDomainBpsDataByLayerResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveDomainBpsDataByLayerResponse.RequestId = _ctx.StringValue("DescribeLiveDomainBpsDataByLayer.RequestId");
			describeLiveDomainBpsDataByLayerResponse.DataInterval = _ctx.StringValue("DescribeLiveDomainBpsDataByLayer.DataInterval");

			List<DescribeLiveDomainBpsDataByLayerResponse.DescribeLiveDomainBpsDataByLayer_DataModule> describeLiveDomainBpsDataByLayerResponse_bpsDataInterval = new List<DescribeLiveDomainBpsDataByLayerResponse.DescribeLiveDomainBpsDataByLayer_DataModule>();
			for (int i = 0; i < _ctx.Length("DescribeLiveDomainBpsDataByLayer.BpsDataInterval.Length"); i++) {
				DescribeLiveDomainBpsDataByLayerResponse.DescribeLiveDomainBpsDataByLayer_DataModule dataModule = new DescribeLiveDomainBpsDataByLayerResponse.DescribeLiveDomainBpsDataByLayer_DataModule();
				dataModule.TimeStamp = _ctx.StringValue("DescribeLiveDomainBpsDataByLayer.BpsDataInterval["+ i +"].TimeStamp");
				dataModule._Value = _ctx.StringValue("DescribeLiveDomainBpsDataByLayer.BpsDataInterval["+ i +"].Value");
				dataModule.TrafficValue = _ctx.StringValue("DescribeLiveDomainBpsDataByLayer.BpsDataInterval["+ i +"].TrafficValue");

				describeLiveDomainBpsDataByLayerResponse_bpsDataInterval.Add(dataModule);
			}
			describeLiveDomainBpsDataByLayerResponse.BpsDataInterval = describeLiveDomainBpsDataByLayerResponse_bpsDataInterval;
        
			return describeLiveDomainBpsDataByLayerResponse;
        }
    }
}
