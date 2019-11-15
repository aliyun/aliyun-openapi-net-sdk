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
    public class DescribeDcdnDomainRealTimeQpsDataResponseUnmarshaller
    {
        public static DescribeDcdnDomainRealTimeQpsDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDcdnDomainRealTimeQpsDataResponse describeDcdnDomainRealTimeQpsDataResponse = new DescribeDcdnDomainRealTimeQpsDataResponse();

			describeDcdnDomainRealTimeQpsDataResponse.HttpResponse = context.HttpResponse;
			describeDcdnDomainRealTimeQpsDataResponse.RequestId = context.StringValue("DescribeDcdnDomainRealTimeQpsData.RequestId");

			List<DescribeDcdnDomainRealTimeQpsDataResponse.DescribeDcdnDomainRealTimeQpsData_QpsModel> describeDcdnDomainRealTimeQpsDataResponse_data = new List<DescribeDcdnDomainRealTimeQpsDataResponse.DescribeDcdnDomainRealTimeQpsData_QpsModel>();
			for (int i = 0; i < context.Length("DescribeDcdnDomainRealTimeQpsData.Data.Length"); i++) {
				DescribeDcdnDomainRealTimeQpsDataResponse.DescribeDcdnDomainRealTimeQpsData_QpsModel qpsModel = new DescribeDcdnDomainRealTimeQpsDataResponse.DescribeDcdnDomainRealTimeQpsData_QpsModel();
				qpsModel.Qps = context.FloatValue("DescribeDcdnDomainRealTimeQpsData.Data["+ i +"].Qps");
				qpsModel.TimeStamp = context.StringValue("DescribeDcdnDomainRealTimeQpsData.Data["+ i +"].TimeStamp");

				describeDcdnDomainRealTimeQpsDataResponse_data.Add(qpsModel);
			}
			describeDcdnDomainRealTimeQpsDataResponse.Data = describeDcdnDomainRealTimeQpsDataResponse_data;
        
			return describeDcdnDomainRealTimeQpsDataResponse;
        }
    }
}
