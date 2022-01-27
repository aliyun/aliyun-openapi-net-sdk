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
    public class DescribeScdnDomainQpsDataResponseUnmarshaller
    {
        public static DescribeScdnDomainQpsDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeScdnDomainQpsDataResponse describeScdnDomainQpsDataResponse = new DescribeScdnDomainQpsDataResponse();

			describeScdnDomainQpsDataResponse.HttpResponse = _ctx.HttpResponse;
			describeScdnDomainQpsDataResponse.RequestId = _ctx.StringValue("DescribeScdnDomainQpsData.RequestId");
			describeScdnDomainQpsDataResponse.DomainName = _ctx.StringValue("DescribeScdnDomainQpsData.DomainName");
			describeScdnDomainQpsDataResponse.StartTime = _ctx.StringValue("DescribeScdnDomainQpsData.StartTime");
			describeScdnDomainQpsDataResponse.EndTime = _ctx.StringValue("DescribeScdnDomainQpsData.EndTime");
			describeScdnDomainQpsDataResponse.DataInterval = _ctx.StringValue("DescribeScdnDomainQpsData.DataInterval");

			List<DescribeScdnDomainQpsDataResponse.DescribeScdnDomainQpsData_DataModule> describeScdnDomainQpsDataResponse_qpsDataPerInterval = new List<DescribeScdnDomainQpsDataResponse.DescribeScdnDomainQpsData_DataModule>();
			for (int i = 0; i < _ctx.Length("DescribeScdnDomainQpsData.QpsDataPerInterval.Length"); i++) {
				DescribeScdnDomainQpsDataResponse.DescribeScdnDomainQpsData_DataModule dataModule = new DescribeScdnDomainQpsDataResponse.DescribeScdnDomainQpsData_DataModule();
				dataModule.TimeStamp = _ctx.StringValue("DescribeScdnDomainQpsData.QpsDataPerInterval["+ i +"].TimeStamp");
				dataModule.QpsValue = _ctx.StringValue("DescribeScdnDomainQpsData.QpsDataPerInterval["+ i +"].QpsValue");
				dataModule.HttpQpsValue = _ctx.StringValue("DescribeScdnDomainQpsData.QpsDataPerInterval["+ i +"].HttpQpsValue");
				dataModule.HttpsQpsValue = _ctx.StringValue("DescribeScdnDomainQpsData.QpsDataPerInterval["+ i +"].HttpsQpsValue");
				dataModule.AccValue = _ctx.StringValue("DescribeScdnDomainQpsData.QpsDataPerInterval["+ i +"].AccValue");
				dataModule.HttpAccValue = _ctx.StringValue("DescribeScdnDomainQpsData.QpsDataPerInterval["+ i +"].HttpAccValue");
				dataModule.HttpsAccValue = _ctx.StringValue("DescribeScdnDomainQpsData.QpsDataPerInterval["+ i +"].HttpsAccValue");

				describeScdnDomainQpsDataResponse_qpsDataPerInterval.Add(dataModule);
			}
			describeScdnDomainQpsDataResponse.QpsDataPerInterval = describeScdnDomainQpsDataResponse_qpsDataPerInterval;
        
			return describeScdnDomainQpsDataResponse;
        }
    }
}
