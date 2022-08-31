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
using Aliyun.Acs.scdn.Model.V20171115;

namespace Aliyun.Acs.scdn.Transform.V20171115
{
    public class TestAmpDescribeScdnDomainIspDataResponseUnmarshaller
    {
        public static TestAmpDescribeScdnDomainIspDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			TestAmpDescribeScdnDomainIspDataResponse testAmpDescribeScdnDomainIspDataResponse = new TestAmpDescribeScdnDomainIspDataResponse();

			testAmpDescribeScdnDomainIspDataResponse.HttpResponse = _ctx.HttpResponse;
			testAmpDescribeScdnDomainIspDataResponse.EndTime = _ctx.StringValue("TestAmpDescribeScdnDomainIspData.EndTime");
			testAmpDescribeScdnDomainIspDataResponse.StartTime = _ctx.StringValue("TestAmpDescribeScdnDomainIspData.StartTime");
			testAmpDescribeScdnDomainIspDataResponse.RequestId = _ctx.StringValue("TestAmpDescribeScdnDomainIspData.RequestId");
			testAmpDescribeScdnDomainIspDataResponse.DomainName = _ctx.StringValue("TestAmpDescribeScdnDomainIspData.DomainName");
			testAmpDescribeScdnDomainIspDataResponse.DataInterval = _ctx.StringValue("TestAmpDescribeScdnDomainIspData.DataInterval");

			List<TestAmpDescribeScdnDomainIspDataResponse.TestAmpDescribeScdnDomainIspData_ISPProportionData> testAmpDescribeScdnDomainIspDataResponse_value = new List<TestAmpDescribeScdnDomainIspDataResponse.TestAmpDescribeScdnDomainIspData_ISPProportionData>();
			for (int i = 0; i < _ctx.Length("TestAmpDescribeScdnDomainIspData.Value.Length"); i++) {
				TestAmpDescribeScdnDomainIspDataResponse.TestAmpDescribeScdnDomainIspData_ISPProportionData iSPProportionData = new TestAmpDescribeScdnDomainIspDataResponse.TestAmpDescribeScdnDomainIspData_ISPProportionData();
				iSPProportionData.TotalQuery = _ctx.StringValue("TestAmpDescribeScdnDomainIspData.Value["+ i +"].TotalQuery");
				iSPProportionData.TotalBytes = _ctx.StringValue("TestAmpDescribeScdnDomainIspData.Value["+ i +"].TotalBytes");
				iSPProportionData.AvgResponseRate = _ctx.StringValue("TestAmpDescribeScdnDomainIspData.Value["+ i +"].AvgResponseRate");
				iSPProportionData.AvgResponseTime = _ctx.StringValue("TestAmpDescribeScdnDomainIspData.Value["+ i +"].AvgResponseTime");
				iSPProportionData.ReqErrRate = _ctx.StringValue("TestAmpDescribeScdnDomainIspData.Value["+ i +"].ReqErrRate");
				iSPProportionData.AvgObjectSize = _ctx.StringValue("TestAmpDescribeScdnDomainIspData.Value["+ i +"].AvgObjectSize");
				iSPProportionData.Bps = _ctx.StringValue("TestAmpDescribeScdnDomainIspData.Value["+ i +"].Bps");
				iSPProportionData.Qps = _ctx.StringValue("TestAmpDescribeScdnDomainIspData.Value["+ i +"].Qps");
				iSPProportionData.Proportion = _ctx.StringValue("TestAmpDescribeScdnDomainIspData.Value["+ i +"].Proportion");
				iSPProportionData.IspEname = _ctx.StringValue("TestAmpDescribeScdnDomainIspData.Value["+ i +"].IspEname");
				iSPProportionData.ISP = _ctx.StringValue("TestAmpDescribeScdnDomainIspData.Value["+ i +"].ISP");
				iSPProportionData.BytesProportion = _ctx.StringValue("TestAmpDescribeScdnDomainIspData.Value["+ i +"].BytesProportion");

				testAmpDescribeScdnDomainIspDataResponse_value.Add(iSPProportionData);
			}
			testAmpDescribeScdnDomainIspDataResponse._Value = testAmpDescribeScdnDomainIspDataResponse_value;
        
			return testAmpDescribeScdnDomainIspDataResponse;
        }
    }
}
