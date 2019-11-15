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
    public class DescribeDcdnDomainIpaBpsDataResponseUnmarshaller
    {
        public static DescribeDcdnDomainIpaBpsDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDcdnDomainIpaBpsDataResponse describeDcdnDomainIpaBpsDataResponse = new DescribeDcdnDomainIpaBpsDataResponse();

			describeDcdnDomainIpaBpsDataResponse.HttpResponse = context.HttpResponse;
			describeDcdnDomainIpaBpsDataResponse.RequestId = context.StringValue("DescribeDcdnDomainIpaBpsData.RequestId");
			describeDcdnDomainIpaBpsDataResponse.DomainName = context.StringValue("DescribeDcdnDomainIpaBpsData.DomainName");
			describeDcdnDomainIpaBpsDataResponse.StartTime = context.StringValue("DescribeDcdnDomainIpaBpsData.StartTime");
			describeDcdnDomainIpaBpsDataResponse.EndTime = context.StringValue("DescribeDcdnDomainIpaBpsData.EndTime");
			describeDcdnDomainIpaBpsDataResponse.DataInterval = context.StringValue("DescribeDcdnDomainIpaBpsData.DataInterval");

			List<DescribeDcdnDomainIpaBpsDataResponse.DescribeDcdnDomainIpaBpsData_DataModule> describeDcdnDomainIpaBpsDataResponse_bpsDataPerInterval = new List<DescribeDcdnDomainIpaBpsDataResponse.DescribeDcdnDomainIpaBpsData_DataModule>();
			for (int i = 0; i < context.Length("DescribeDcdnDomainIpaBpsData.BpsDataPerInterval.Length"); i++) {
				DescribeDcdnDomainIpaBpsDataResponse.DescribeDcdnDomainIpaBpsData_DataModule dataModule = new DescribeDcdnDomainIpaBpsDataResponse.DescribeDcdnDomainIpaBpsData_DataModule();
				dataModule.TimeStamp = context.StringValue("DescribeDcdnDomainIpaBpsData.BpsDataPerInterval["+ i +"].TimeStamp");
				dataModule.IpaBps = context.FloatValue("DescribeDcdnDomainIpaBpsData.BpsDataPerInterval["+ i +"].IpaBps");

				describeDcdnDomainIpaBpsDataResponse_bpsDataPerInterval.Add(dataModule);
			}
			describeDcdnDomainIpaBpsDataResponse.BpsDataPerInterval = describeDcdnDomainIpaBpsDataResponse_bpsDataPerInterval;
        
			return describeDcdnDomainIpaBpsDataResponse;
        }
    }
}
