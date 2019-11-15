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
    public class DescribeDcdnDomainQpsDataResponseUnmarshaller
    {
        public static DescribeDcdnDomainQpsDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDcdnDomainQpsDataResponse describeDcdnDomainQpsDataResponse = new DescribeDcdnDomainQpsDataResponse();

			describeDcdnDomainQpsDataResponse.HttpResponse = context.HttpResponse;
			describeDcdnDomainQpsDataResponse.RequestId = context.StringValue("DescribeDcdnDomainQpsData.RequestId");
			describeDcdnDomainQpsDataResponse.DomainName = context.StringValue("DescribeDcdnDomainQpsData.DomainName");
			describeDcdnDomainQpsDataResponse.StartTime = context.StringValue("DescribeDcdnDomainQpsData.StartTime");
			describeDcdnDomainQpsDataResponse.EndTime = context.StringValue("DescribeDcdnDomainQpsData.EndTime");
			describeDcdnDomainQpsDataResponse.DataInterval = context.StringValue("DescribeDcdnDomainQpsData.DataInterval");

			List<DescribeDcdnDomainQpsDataResponse.DescribeDcdnDomainQpsData_DataModule> describeDcdnDomainQpsDataResponse_qpsDataPerInterval = new List<DescribeDcdnDomainQpsDataResponse.DescribeDcdnDomainQpsData_DataModule>();
			for (int i = 0; i < context.Length("DescribeDcdnDomainQpsData.QpsDataPerInterval.Length"); i++) {
				DescribeDcdnDomainQpsDataResponse.DescribeDcdnDomainQpsData_DataModule dataModule = new DescribeDcdnDomainQpsDataResponse.DescribeDcdnDomainQpsData_DataModule();
				dataModule.TimeStamp = context.StringValue("DescribeDcdnDomainQpsData.QpsDataPerInterval["+ i +"].TimeStamp");
				dataModule.Qps = context.FloatValue("DescribeDcdnDomainQpsData.QpsDataPerInterval["+ i +"].Qps");
				dataModule.DynamicHttpQps = context.FloatValue("DescribeDcdnDomainQpsData.QpsDataPerInterval["+ i +"].DynamicHttpQps");
				dataModule.DynamicHttpsQps = context.FloatValue("DescribeDcdnDomainQpsData.QpsDataPerInterval["+ i +"].DynamicHttpsQps");
				dataModule.StaticHttpQps = context.FloatValue("DescribeDcdnDomainQpsData.QpsDataPerInterval["+ i +"].StaticHttpQps");
				dataModule.StaticHttpsQps = context.FloatValue("DescribeDcdnDomainQpsData.QpsDataPerInterval["+ i +"].StaticHttpsQps");
				dataModule.Acc = context.FloatValue("DescribeDcdnDomainQpsData.QpsDataPerInterval["+ i +"].Acc");
				dataModule.DynamicHttpAcc = context.FloatValue("DescribeDcdnDomainQpsData.QpsDataPerInterval["+ i +"].DynamicHttpAcc");
				dataModule.DynamicHttpsAcc = context.FloatValue("DescribeDcdnDomainQpsData.QpsDataPerInterval["+ i +"].DynamicHttpsAcc");
				dataModule.StaticHttpAcc = context.FloatValue("DescribeDcdnDomainQpsData.QpsDataPerInterval["+ i +"].StaticHttpAcc");
				dataModule.StaticHttpsAcc = context.FloatValue("DescribeDcdnDomainQpsData.QpsDataPerInterval["+ i +"].StaticHttpsAcc");

				describeDcdnDomainQpsDataResponse_qpsDataPerInterval.Add(dataModule);
			}
			describeDcdnDomainQpsDataResponse.QpsDataPerInterval = describeDcdnDomainQpsDataResponse_qpsDataPerInterval;
        
			return describeDcdnDomainQpsDataResponse;
        }
    }
}
