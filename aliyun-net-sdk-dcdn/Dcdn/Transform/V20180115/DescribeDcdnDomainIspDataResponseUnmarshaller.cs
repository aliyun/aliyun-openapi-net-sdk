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
    public class DescribeDcdnDomainIspDataResponseUnmarshaller
    {
        public static DescribeDcdnDomainIspDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDcdnDomainIspDataResponse describeDcdnDomainIspDataResponse = new DescribeDcdnDomainIspDataResponse();

			describeDcdnDomainIspDataResponse.HttpResponse = context.HttpResponse;
			describeDcdnDomainIspDataResponse.RequestId = context.StringValue("DescribeDcdnDomainIspData.RequestId");
			describeDcdnDomainIspDataResponse.DomainName = context.StringValue("DescribeDcdnDomainIspData.DomainName");
			describeDcdnDomainIspDataResponse.DataInterval = context.StringValue("DescribeDcdnDomainIspData.DataInterval");
			describeDcdnDomainIspDataResponse.StartTime = context.StringValue("DescribeDcdnDomainIspData.StartTime");
			describeDcdnDomainIspDataResponse.EndTime = context.StringValue("DescribeDcdnDomainIspData.EndTime");

			List<DescribeDcdnDomainIspDataResponse.DescribeDcdnDomainIspData_IspProportionData> describeDcdnDomainIspDataResponse_value = new List<DescribeDcdnDomainIspDataResponse.DescribeDcdnDomainIspData_IspProportionData>();
			for (int i = 0; i < context.Length("DescribeDcdnDomainIspData.Value.Length"); i++) {
				DescribeDcdnDomainIspDataResponse.DescribeDcdnDomainIspData_IspProportionData ispProportionData = new DescribeDcdnDomainIspDataResponse.DescribeDcdnDomainIspData_IspProportionData();
				ispProportionData.Isp = context.StringValue("DescribeDcdnDomainIspData.Value["+ i +"].Isp");
				ispProportionData.Proportion = context.StringValue("DescribeDcdnDomainIspData.Value["+ i +"].Proportion");
				ispProportionData.IspEname = context.StringValue("DescribeDcdnDomainIspData.Value["+ i +"].IspEname");
				ispProportionData.AvgObjectSize = context.StringValue("DescribeDcdnDomainIspData.Value["+ i +"].AvgObjectSize");
				ispProportionData.AvgResponseTime = context.StringValue("DescribeDcdnDomainIspData.Value["+ i +"].AvgResponseTime");
				ispProportionData.Bps = context.StringValue("DescribeDcdnDomainIspData.Value["+ i +"].Bps");
				ispProportionData.Qps = context.StringValue("DescribeDcdnDomainIspData.Value["+ i +"].Qps");
				ispProportionData.AvgResponseRate = context.StringValue("DescribeDcdnDomainIspData.Value["+ i +"].AvgResponseRate");
				ispProportionData.TotalBytes = context.StringValue("DescribeDcdnDomainIspData.Value["+ i +"].TotalBytes");
				ispProportionData.BytesProportion = context.StringValue("DescribeDcdnDomainIspData.Value["+ i +"].BytesProportion");
				ispProportionData.TotalQuery = context.StringValue("DescribeDcdnDomainIspData.Value["+ i +"].TotalQuery");

				describeDcdnDomainIspDataResponse_value.Add(ispProportionData);
			}
			describeDcdnDomainIspDataResponse._Value = describeDcdnDomainIspDataResponse_value;
        
			return describeDcdnDomainIspDataResponse;
        }
    }
}
