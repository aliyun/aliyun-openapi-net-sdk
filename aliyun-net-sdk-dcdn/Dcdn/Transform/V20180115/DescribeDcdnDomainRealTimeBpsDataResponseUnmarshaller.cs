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
using Aliyun.Acs.dcdn.Model.V20180115;

namespace Aliyun.Acs.dcdn.Transform.V20180115
{
    public class DescribeDcdnDomainRealTimeBpsDataResponseUnmarshaller
    {
        public static DescribeDcdnDomainRealTimeBpsDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDcdnDomainRealTimeBpsDataResponse describeDcdnDomainRealTimeBpsDataResponse = new DescribeDcdnDomainRealTimeBpsDataResponse();

			describeDcdnDomainRealTimeBpsDataResponse.HttpResponse = context.HttpResponse;
			describeDcdnDomainRealTimeBpsDataResponse.RequestId = context.StringValue("DescribeDcdnDomainRealTimeBpsData.RequestId");

			List<DescribeDcdnDomainRealTimeBpsDataResponse.DescribeDcdnDomainRealTimeBpsData_BpsModel> describeDcdnDomainRealTimeBpsDataResponse_data = new List<DescribeDcdnDomainRealTimeBpsDataResponse.DescribeDcdnDomainRealTimeBpsData_BpsModel>();
			for (int i = 0; i < context.Length("DescribeDcdnDomainRealTimeBpsData.Data.Length"); i++) {
				DescribeDcdnDomainRealTimeBpsDataResponse.DescribeDcdnDomainRealTimeBpsData_BpsModel bpsModel = new DescribeDcdnDomainRealTimeBpsDataResponse.DescribeDcdnDomainRealTimeBpsData_BpsModel();
				bpsModel.Bps = context.FloatValue("DescribeDcdnDomainRealTimeBpsData.Data["+ i +"].Bps");
				bpsModel.TimeStamp = context.StringValue("DescribeDcdnDomainRealTimeBpsData.Data["+ i +"].TimeStamp");

				describeDcdnDomainRealTimeBpsDataResponse_data.Add(bpsModel);
			}
			describeDcdnDomainRealTimeBpsDataResponse.Data = describeDcdnDomainRealTimeBpsDataResponse_data;
        
			return describeDcdnDomainRealTimeBpsDataResponse;
        }
    }
}
