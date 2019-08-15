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
using Aliyun.Acs.Cdn.Model.V20180510;

namespace Aliyun.Acs.Cdn.Transform.V20180510
{
    public class DescribeDomainSrcTrafficDataResponseUnmarshaller
    {
        public static DescribeDomainSrcTrafficDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDomainSrcTrafficDataResponse describeDomainSrcTrafficDataResponse = new DescribeDomainSrcTrafficDataResponse();

			describeDomainSrcTrafficDataResponse.HttpResponse = context.HttpResponse;
			describeDomainSrcTrafficDataResponse.RequestId = context.StringValue("DescribeDomainSrcTrafficData.RequestId");
			describeDomainSrcTrafficDataResponse.DomainName = context.StringValue("DescribeDomainSrcTrafficData.DomainName");
			describeDomainSrcTrafficDataResponse.StartTime = context.StringValue("DescribeDomainSrcTrafficData.StartTime");
			describeDomainSrcTrafficDataResponse.EndTime = context.StringValue("DescribeDomainSrcTrafficData.EndTime");
			describeDomainSrcTrafficDataResponse.DataInterval = context.StringValue("DescribeDomainSrcTrafficData.DataInterval");

			List<DescribeDomainSrcTrafficDataResponse.DescribeDomainSrcTrafficData_DataModule> describeDomainSrcTrafficDataResponse_srcTrafficDataPerInterval = new List<DescribeDomainSrcTrafficDataResponse.DescribeDomainSrcTrafficData_DataModule>();
			for (int i = 0; i < context.Length("DescribeDomainSrcTrafficData.SrcTrafficDataPerInterval.Length"); i++) {
				DescribeDomainSrcTrafficDataResponse.DescribeDomainSrcTrafficData_DataModule dataModule = new DescribeDomainSrcTrafficDataResponse.DescribeDomainSrcTrafficData_DataModule();
				dataModule.TimeStamp = context.StringValue("DescribeDomainSrcTrafficData.SrcTrafficDataPerInterval["+ i +"].TimeStamp");
				dataModule._Value = context.StringValue("DescribeDomainSrcTrafficData.SrcTrafficDataPerInterval["+ i +"]._Value");
				dataModule.HttpsValue = context.StringValue("DescribeDomainSrcTrafficData.SrcTrafficDataPerInterval["+ i +"].HttpsValue");

				describeDomainSrcTrafficDataResponse_srcTrafficDataPerInterval.Add(dataModule);
			}
			describeDomainSrcTrafficDataResponse.SrcTrafficDataPerInterval = describeDomainSrcTrafficDataResponse_srcTrafficDataPerInterval;
        
			return describeDomainSrcTrafficDataResponse;
        }
    }
}
