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
using Aliyun.Acs.scdn.Model.V20171115;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.scdn.Transform.V20171115
{
    public class DescribeScdnDomainIspDataResponseUnmarshaller
    {
        public static DescribeScdnDomainIspDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeScdnDomainIspDataResponse describeScdnDomainIspDataResponse = new DescribeScdnDomainIspDataResponse();

			describeScdnDomainIspDataResponse.HttpResponse = context.HttpResponse;
			describeScdnDomainIspDataResponse.RequestId = context.StringValue("DescribeScdnDomainIspData.RequestId");
			describeScdnDomainIspDataResponse.DomainName = context.StringValue("DescribeScdnDomainIspData.DomainName");
			describeScdnDomainIspDataResponse.DataInterval = context.StringValue("DescribeScdnDomainIspData.DataInterval");
			describeScdnDomainIspDataResponse.StartTime = context.StringValue("DescribeScdnDomainIspData.StartTime");
			describeScdnDomainIspDataResponse.EndTime = context.StringValue("DescribeScdnDomainIspData.EndTime");

			List<DescribeScdnDomainIspDataResponse.DescribeScdnDomainIspData_IspProportionData> describeScdnDomainIspDataResponse_value = new List<DescribeScdnDomainIspDataResponse.DescribeScdnDomainIspData_IspProportionData>();
			for (int i = 0; i < context.Length("DescribeScdnDomainIspData.Value.Length"); i++) {
				DescribeScdnDomainIspDataResponse.DescribeScdnDomainIspData_IspProportionData ispProportionData = new DescribeScdnDomainIspDataResponse.DescribeScdnDomainIspData_IspProportionData();
				ispProportionData.Isp = context.StringValue("DescribeScdnDomainIspData.Value["+ i +"].Isp");
				ispProportionData.Proportion = context.StringValue("DescribeScdnDomainIspData.Value["+ i +"].Proportion");
				ispProportionData.IspEname = context.StringValue("DescribeScdnDomainIspData.Value["+ i +"].IspEname");
				ispProportionData.AvgObjectSize = context.StringValue("DescribeScdnDomainIspData.Value["+ i +"].AvgObjectSize");
				ispProportionData.AvgResponseTime = context.StringValue("DescribeScdnDomainIspData.Value["+ i +"].AvgResponseTime");
				ispProportionData.Bps = context.StringValue("DescribeScdnDomainIspData.Value["+ i +"].Bps");
				ispProportionData.Qps = context.StringValue("DescribeScdnDomainIspData.Value["+ i +"].Qps");
				ispProportionData.AvgResponseRate = context.StringValue("DescribeScdnDomainIspData.Value["+ i +"].AvgResponseRate");
				ispProportionData.TotalBytes = context.StringValue("DescribeScdnDomainIspData.Value["+ i +"].TotalBytes");
				ispProportionData.BytesProportion = context.StringValue("DescribeScdnDomainIspData.Value["+ i +"].BytesProportion");
				ispProportionData.TotalQuery = context.StringValue("DescribeScdnDomainIspData.Value["+ i +"].TotalQuery");

				describeScdnDomainIspDataResponse_value.Add(ispProportionData);
			}
			describeScdnDomainIspDataResponse._Value = describeScdnDomainIspDataResponse_value;
        
			return describeScdnDomainIspDataResponse;
        }
    }
}