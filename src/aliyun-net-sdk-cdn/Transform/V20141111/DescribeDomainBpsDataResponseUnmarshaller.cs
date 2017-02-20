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
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Transform.V20141111
{
    public class DescribeDomainBpsDataResponseUnmarshaller
    {
        public static DescribeDomainBpsDataResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeDomainBpsDataResponse describeDomainBpsDataResponse = new DescribeDomainBpsDataResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeDomainBpsData.RequestId"),
                DomainName = context.StringValue("DescribeDomainBpsData.DomainName"),
                DataInterval = context.StringValue("DescribeDomainBpsData.DataInterval"),
                StartTime = context.StringValue("DescribeDomainBpsData.StartTime"),
                EndTime = context.StringValue("DescribeDomainBpsData.EndTime"),
                LocationNameEn = context.StringValue("DescribeDomainBpsData.LocationNameEn"),
                IspNameEn = context.StringValue("DescribeDomainBpsData.IspNameEn"),
                LocationName = context.StringValue("DescribeDomainBpsData.LocationName"),
                IspName = context.StringValue("DescribeDomainBpsData.IspName")
            };
            List<DescribeDomainBpsDataResponse.DataModule> bpsDataPerInterval = new List<DescribeDomainBpsDataResponse.DataModule>();
			for (int i = 0; i < context.Length("DescribeDomainBpsData.BpsDataPerInterval.Length"); i++) {
                DescribeDomainBpsDataResponse.DataModule dataModule = new DescribeDomainBpsDataResponse.DataModule()
                {
                    TimeStamp = context.StringValue($"DescribeDomainBpsData.BpsDataPerInterval[{i}].TimeStamp"),
                    Value = context.StringValue($"DescribeDomainBpsData.BpsDataPerInterval[{i}].Value"),
                    DomesticValue = context.StringValue($"DescribeDomainBpsData.BpsDataPerInterval[{i}].DomesticValue"),
                    OverseasValue = context.StringValue($"DescribeDomainBpsData.BpsDataPerInterval[{i}].OverseasValue")
                };
                bpsDataPerInterval.Add(dataModule);
			}
			describeDomainBpsDataResponse.BpsDataPerInterval = bpsDataPerInterval;

			List<DescribeDomainBpsDataResponse.DataModule> supplyBpsDatas = new List<DescribeDomainBpsDataResponse.DataModule>();
			for (int i = 0; i < context.Length("DescribeDomainBpsData.SupplyBpsDatas.Length"); i++) {
                DescribeDomainBpsDataResponse.DataModule dataModule = new DescribeDomainBpsDataResponse.DataModule()
                {
                    TimeStamp = context.StringValue($"DescribeDomainBpsData.SupplyBpsDatas[{i}].TimeStamp"),
                    Value = context.StringValue($"DescribeDomainBpsData.SupplyBpsDatas[{i}].Value")
                };
                supplyBpsDatas.Add(dataModule);
			}
			describeDomainBpsDataResponse.SupplyBpsDatas = supplyBpsDatas;
        
			return describeDomainBpsDataResponse;
        }
    }
}