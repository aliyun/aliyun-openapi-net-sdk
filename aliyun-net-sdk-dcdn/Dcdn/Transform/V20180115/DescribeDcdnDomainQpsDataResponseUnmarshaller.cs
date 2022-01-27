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
        public static DescribeDcdnDomainQpsDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDcdnDomainQpsDataResponse describeDcdnDomainQpsDataResponse = new DescribeDcdnDomainQpsDataResponse();

			describeDcdnDomainQpsDataResponse.HttpResponse = _ctx.HttpResponse;
			describeDcdnDomainQpsDataResponse.RequestId = _ctx.StringValue("DescribeDcdnDomainQpsData.RequestId");
			describeDcdnDomainQpsDataResponse.DomainName = _ctx.StringValue("DescribeDcdnDomainQpsData.DomainName");
			describeDcdnDomainQpsDataResponse.StartTime = _ctx.StringValue("DescribeDcdnDomainQpsData.StartTime");
			describeDcdnDomainQpsDataResponse.EndTime = _ctx.StringValue("DescribeDcdnDomainQpsData.EndTime");
			describeDcdnDomainQpsDataResponse.DataInterval = _ctx.StringValue("DescribeDcdnDomainQpsData.DataInterval");

			List<DescribeDcdnDomainQpsDataResponse.DescribeDcdnDomainQpsData_DataModule> describeDcdnDomainQpsDataResponse_qpsDataPerInterval = new List<DescribeDcdnDomainQpsDataResponse.DescribeDcdnDomainQpsData_DataModule>();
			for (int i = 0; i < _ctx.Length("DescribeDcdnDomainQpsData.QpsDataPerInterval.Length"); i++) {
				DescribeDcdnDomainQpsDataResponse.DescribeDcdnDomainQpsData_DataModule dataModule = new DescribeDcdnDomainQpsDataResponse.DescribeDcdnDomainQpsData_DataModule();
				dataModule.TimeStamp = _ctx.StringValue("DescribeDcdnDomainQpsData.QpsDataPerInterval["+ i +"].TimeStamp");
				dataModule.Qps = _ctx.FloatValue("DescribeDcdnDomainQpsData.QpsDataPerInterval["+ i +"].Qps");
				dataModule.DynamicHttpQps = _ctx.FloatValue("DescribeDcdnDomainQpsData.QpsDataPerInterval["+ i +"].DynamicHttpQps");
				dataModule.DynamicHttpsQps = _ctx.FloatValue("DescribeDcdnDomainQpsData.QpsDataPerInterval["+ i +"].DynamicHttpsQps");
				dataModule.StaticHttpQps = _ctx.FloatValue("DescribeDcdnDomainQpsData.QpsDataPerInterval["+ i +"].StaticHttpQps");
				dataModule.StaticHttpsQps = _ctx.FloatValue("DescribeDcdnDomainQpsData.QpsDataPerInterval["+ i +"].StaticHttpsQps");
				dataModule.Acc = _ctx.FloatValue("DescribeDcdnDomainQpsData.QpsDataPerInterval["+ i +"].Acc");
				dataModule.DynamicHttpAcc = _ctx.FloatValue("DescribeDcdnDomainQpsData.QpsDataPerInterval["+ i +"].DynamicHttpAcc");
				dataModule.DynamicHttpsAcc = _ctx.FloatValue("DescribeDcdnDomainQpsData.QpsDataPerInterval["+ i +"].DynamicHttpsAcc");
				dataModule.StaticHttpAcc = _ctx.FloatValue("DescribeDcdnDomainQpsData.QpsDataPerInterval["+ i +"].StaticHttpAcc");
				dataModule.StaticHttpsAcc = _ctx.FloatValue("DescribeDcdnDomainQpsData.QpsDataPerInterval["+ i +"].StaticHttpsAcc");

				describeDcdnDomainQpsDataResponse_qpsDataPerInterval.Add(dataModule);
			}
			describeDcdnDomainQpsDataResponse.QpsDataPerInterval = describeDcdnDomainQpsDataResponse_qpsDataPerInterval;
        
			return describeDcdnDomainQpsDataResponse;
        }
    }
}
