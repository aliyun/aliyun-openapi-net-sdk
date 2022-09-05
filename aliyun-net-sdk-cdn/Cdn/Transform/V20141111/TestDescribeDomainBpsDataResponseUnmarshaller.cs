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
using Aliyun.Acs.Cdn.Model.V20141111;

namespace Aliyun.Acs.Cdn.Transform.V20141111
{
    public class TestDescribeDomainBpsDataResponseUnmarshaller
    {
        public static TestDescribeDomainBpsDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			TestDescribeDomainBpsDataResponse testDescribeDomainBpsDataResponse = new TestDescribeDomainBpsDataResponse();

			testDescribeDomainBpsDataResponse.HttpResponse = _ctx.HttpResponse;
			testDescribeDomainBpsDataResponse.EndTime = _ctx.StringValue("TestDescribeDomainBpsData.EndTime");
			testDescribeDomainBpsDataResponse.StartTime = _ctx.StringValue("TestDescribeDomainBpsData.StartTime");
			testDescribeDomainBpsDataResponse.IspNameEn = _ctx.StringValue("TestDescribeDomainBpsData.IspNameEn");
			testDescribeDomainBpsDataResponse.RequestId = _ctx.StringValue("TestDescribeDomainBpsData.RequestId");
			testDescribeDomainBpsDataResponse.LocationNameEn = _ctx.StringValue("TestDescribeDomainBpsData.LocationNameEn");
			testDescribeDomainBpsDataResponse.LocationName = _ctx.StringValue("TestDescribeDomainBpsData.LocationName");
			testDescribeDomainBpsDataResponse.IspName = _ctx.StringValue("TestDescribeDomainBpsData.IspName");
			testDescribeDomainBpsDataResponse.DomainName = _ctx.StringValue("TestDescribeDomainBpsData.DomainName");
			testDescribeDomainBpsDataResponse.DataInterval = _ctx.StringValue("TestDescribeDomainBpsData.DataInterval");

			List<TestDescribeDomainBpsDataResponse.TestDescribeDomainBpsData_DataModule> testDescribeDomainBpsDataResponse_bpsDataPerInterval = new List<TestDescribeDomainBpsDataResponse.TestDescribeDomainBpsData_DataModule>();
			for (int i = 0; i < _ctx.Length("TestDescribeDomainBpsData.BpsDataPerInterval.Length"); i++) {
				TestDescribeDomainBpsDataResponse.TestDescribeDomainBpsData_DataModule dataModule = new TestDescribeDomainBpsDataResponse.TestDescribeDomainBpsData_DataModule();
				dataModule.L2Value = _ctx.StringValue("TestDescribeDomainBpsData.BpsDataPerInterval["+ i +"].L2Value");
				dataModule.DynamicValue = _ctx.StringValue("TestDescribeDomainBpsData.BpsDataPerInterval["+ i +"].DynamicValue");
				dataModule.DynamicDomesticValue = _ctx.StringValue("TestDescribeDomainBpsData.BpsDataPerInterval["+ i +"].DynamicDomesticValue");
				dataModule.DomesticValue = _ctx.StringValue("TestDescribeDomainBpsData.BpsDataPerInterval["+ i +"].DomesticValue");
				dataModule._Value = _ctx.StringValue("TestDescribeDomainBpsData.BpsDataPerInterval["+ i +"].Value");
				dataModule.OverseasL2Value = _ctx.StringValue("TestDescribeDomainBpsData.BpsDataPerInterval["+ i +"].OverseasL2Value");
				dataModule.StaticDomesticValue = _ctx.StringValue("TestDescribeDomainBpsData.BpsDataPerInterval["+ i +"].StaticDomesticValue");
				dataModule.DomesticL2Value = _ctx.StringValue("TestDescribeDomainBpsData.BpsDataPerInterval["+ i +"].DomesticL2Value");
				dataModule.OverseasValue = _ctx.StringValue("TestDescribeDomainBpsData.BpsDataPerInterval["+ i +"].OverseasValue");
				dataModule.StaticValue = _ctx.StringValue("TestDescribeDomainBpsData.BpsDataPerInterval["+ i +"].StaticValue");
				dataModule.TimeStamp = _ctx.StringValue("TestDescribeDomainBpsData.BpsDataPerInterval["+ i +"].TimeStamp");
				dataModule.StaticOverseasValue = _ctx.StringValue("TestDescribeDomainBpsData.BpsDataPerInterval["+ i +"].StaticOverseasValue");
				dataModule.DynamicOverseasValue = _ctx.StringValue("TestDescribeDomainBpsData.BpsDataPerInterval["+ i +"].DynamicOverseasValue");

				testDescribeDomainBpsDataResponse_bpsDataPerInterval.Add(dataModule);
			}
			testDescribeDomainBpsDataResponse.BpsDataPerInterval = testDescribeDomainBpsDataResponse_bpsDataPerInterval;
        
			return testDescribeDomainBpsDataResponse;
        }
    }
}
