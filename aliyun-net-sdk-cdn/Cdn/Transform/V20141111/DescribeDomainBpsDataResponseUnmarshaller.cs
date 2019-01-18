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
    public class DescribeDomainBpsDataResponseUnmarshaller
    {
        public static DescribeDomainBpsDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDomainBpsDataResponse describeDomainBpsDataResponse = new DescribeDomainBpsDataResponse();

			describeDomainBpsDataResponse.HttpResponse = context.HttpResponse;
			describeDomainBpsDataResponse.RequestId = context.StringValue("DescribeDomainBpsData.RequestId");
			describeDomainBpsDataResponse.DomainName = context.StringValue("DescribeDomainBpsData.DomainName");
			describeDomainBpsDataResponse.DataInterval = context.StringValue("DescribeDomainBpsData.DataInterval");
			describeDomainBpsDataResponse.StartTime = context.StringValue("DescribeDomainBpsData.StartTime");
			describeDomainBpsDataResponse.EndTime = context.StringValue("DescribeDomainBpsData.EndTime");
			describeDomainBpsDataResponse.LocationNameEn = context.StringValue("DescribeDomainBpsData.LocationNameEn");
			describeDomainBpsDataResponse.IspNameEn = context.StringValue("DescribeDomainBpsData.IspNameEn");
			describeDomainBpsDataResponse.LocationName = context.StringValue("DescribeDomainBpsData.LocationName");
			describeDomainBpsDataResponse.IspName = context.StringValue("DescribeDomainBpsData.IspName");

			List<DescribeDomainBpsDataResponse.DescribeDomainBpsData_DataModule> describeDomainBpsDataResponse_bpsDataPerInterval = new List<DescribeDomainBpsDataResponse.DescribeDomainBpsData_DataModule>();
			for (int i = 0; i < context.Length("DescribeDomainBpsData.BpsDataPerInterval.Length"); i++) {
				DescribeDomainBpsDataResponse.DescribeDomainBpsData_DataModule dataModule = new DescribeDomainBpsDataResponse.DescribeDomainBpsData_DataModule();
				dataModule.TimeStamp = context.StringValue("DescribeDomainBpsData.BpsDataPerInterval["+ i +"].TimeStamp");
				dataModule._Value = context.StringValue("DescribeDomainBpsData.BpsDataPerInterval["+ i +"].Value");
				dataModule.DomesticValue = context.StringValue("DescribeDomainBpsData.BpsDataPerInterval["+ i +"].DomesticValue");
				dataModule.OverseasValue = context.StringValue("DescribeDomainBpsData.BpsDataPerInterval["+ i +"].OverseasValue");
				dataModule.DynamicValue = context.StringValue("DescribeDomainBpsData.BpsDataPerInterval["+ i +"].DynamicValue");
				dataModule.DynamicDomesticValue = context.StringValue("DescribeDomainBpsData.BpsDataPerInterval["+ i +"].DynamicDomesticValue");
				dataModule.DynamicOverseasValue = context.StringValue("DescribeDomainBpsData.BpsDataPerInterval["+ i +"].DynamicOverseasValue");
				dataModule.StaticValue = context.StringValue("DescribeDomainBpsData.BpsDataPerInterval["+ i +"].StaticValue");
				dataModule.StaticDomesticValue = context.StringValue("DescribeDomainBpsData.BpsDataPerInterval["+ i +"].StaticDomesticValue");
				dataModule.StaticOverseasValue = context.StringValue("DescribeDomainBpsData.BpsDataPerInterval["+ i +"].StaticOverseasValue");
				dataModule.L2Value = context.StringValue("DescribeDomainBpsData.BpsDataPerInterval["+ i +"].L2Value");
				dataModule.DomesticL2Value = context.StringValue("DescribeDomainBpsData.BpsDataPerInterval["+ i +"].DomesticL2Value");
				dataModule.OverseasL2Value = context.StringValue("DescribeDomainBpsData.BpsDataPerInterval["+ i +"].OverseasL2Value");

				describeDomainBpsDataResponse_bpsDataPerInterval.Add(dataModule);
			}
			describeDomainBpsDataResponse.BpsDataPerInterval = describeDomainBpsDataResponse_bpsDataPerInterval;

			List<DescribeDomainBpsDataResponse.DescribeDomainBpsData_DataModule1> describeDomainBpsDataResponse_supplyBpsDatas = new List<DescribeDomainBpsDataResponse.DescribeDomainBpsData_DataModule1>();
			for (int i = 0; i < context.Length("DescribeDomainBpsData.SupplyBpsDatas.Length"); i++) {
				DescribeDomainBpsDataResponse.DescribeDomainBpsData_DataModule1 dataModule1 = new DescribeDomainBpsDataResponse.DescribeDomainBpsData_DataModule1();
				dataModule1.TimeStamp = context.StringValue("DescribeDomainBpsData.SupplyBpsDatas["+ i +"].TimeStamp");
				dataModule1._Value = context.StringValue("DescribeDomainBpsData.SupplyBpsDatas["+ i +"].Value");

				describeDomainBpsDataResponse_supplyBpsDatas.Add(dataModule1);
			}
			describeDomainBpsDataResponse.SupplyBpsDatas = describeDomainBpsDataResponse_supplyBpsDatas;
        
			return describeDomainBpsDataResponse;
        }
    }
}