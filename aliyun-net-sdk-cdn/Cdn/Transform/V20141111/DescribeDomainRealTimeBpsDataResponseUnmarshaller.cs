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
    public class DescribeDomainRealTimeBpsDataResponseUnmarshaller
    {
        public static DescribeDomainRealTimeBpsDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDomainRealTimeBpsDataResponse describeDomainRealTimeBpsDataResponse = new DescribeDomainRealTimeBpsDataResponse();

			describeDomainRealTimeBpsDataResponse.HttpResponse = _ctx.HttpResponse;
			describeDomainRealTimeBpsDataResponse.RequestId = _ctx.StringValue("DescribeDomainRealTimeBpsData.RequestId");

			List<DescribeDomainRealTimeBpsDataResponse.DescribeDomainRealTimeBpsData_BpsModel> describeDomainRealTimeBpsDataResponse_data = new List<DescribeDomainRealTimeBpsDataResponse.DescribeDomainRealTimeBpsData_BpsModel>();
			for (int i = 0; i < _ctx.Length("DescribeDomainRealTimeBpsData.Data.Length"); i++) {
				DescribeDomainRealTimeBpsDataResponse.DescribeDomainRealTimeBpsData_BpsModel bpsModel = new DescribeDomainRealTimeBpsDataResponse.DescribeDomainRealTimeBpsData_BpsModel();
				bpsModel.Bps = _ctx.FloatValue("DescribeDomainRealTimeBpsData.Data["+ i +"].Bps");
				bpsModel.TimeStamp = _ctx.StringValue("DescribeDomainRealTimeBpsData.Data["+ i +"].TimeStamp");

				describeDomainRealTimeBpsDataResponse_data.Add(bpsModel);
			}
			describeDomainRealTimeBpsDataResponse.Data = describeDomainRealTimeBpsDataResponse_data;
        
			return describeDomainRealTimeBpsDataResponse;
        }
    }
}
