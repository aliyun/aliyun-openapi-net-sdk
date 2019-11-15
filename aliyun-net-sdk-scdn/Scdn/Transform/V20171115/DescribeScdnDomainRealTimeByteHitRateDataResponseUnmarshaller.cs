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
    public class DescribeScdnDomainRealTimeByteHitRateDataResponseUnmarshaller
    {
        public static DescribeScdnDomainRealTimeByteHitRateDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeScdnDomainRealTimeByteHitRateDataResponse describeScdnDomainRealTimeByteHitRateDataResponse = new DescribeScdnDomainRealTimeByteHitRateDataResponse();

			describeScdnDomainRealTimeByteHitRateDataResponse.HttpResponse = context.HttpResponse;
			describeScdnDomainRealTimeByteHitRateDataResponse.RequestId = context.StringValue("DescribeScdnDomainRealTimeByteHitRateData.RequestId");

			List<DescribeScdnDomainRealTimeByteHitRateDataResponse.DescribeScdnDomainRealTimeByteHitRateData_ByteHitRateDataModel> describeScdnDomainRealTimeByteHitRateDataResponse_data = new List<DescribeScdnDomainRealTimeByteHitRateDataResponse.DescribeScdnDomainRealTimeByteHitRateData_ByteHitRateDataModel>();
			for (int i = 0; i < context.Length("DescribeScdnDomainRealTimeByteHitRateData.Data.Length"); i++) {
				DescribeScdnDomainRealTimeByteHitRateDataResponse.DescribeScdnDomainRealTimeByteHitRateData_ByteHitRateDataModel byteHitRateDataModel = new DescribeScdnDomainRealTimeByteHitRateDataResponse.DescribeScdnDomainRealTimeByteHitRateData_ByteHitRateDataModel();
				byteHitRateDataModel.ByteHitRate = context.FloatValue("DescribeScdnDomainRealTimeByteHitRateData.Data["+ i +"].ByteHitRate");
				byteHitRateDataModel.TimeStamp = context.StringValue("DescribeScdnDomainRealTimeByteHitRateData.Data["+ i +"].TimeStamp");

				describeScdnDomainRealTimeByteHitRateDataResponse_data.Add(byteHitRateDataModel);
			}
			describeScdnDomainRealTimeByteHitRateDataResponse.Data = describeScdnDomainRealTimeByteHitRateDataResponse_data;
        
			return describeScdnDomainRealTimeByteHitRateDataResponse;
        }
    }
}
