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
        public static DescribeScdnDomainQpsDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeScdnDomainQpsDataResponse describeScdnDomainQpsDataResponse = new DescribeScdnDomainQpsDataResponse();

			describeScdnDomainQpsDataResponse.HttpResponse = context.HttpResponse;
			describeScdnDomainQpsDataResponse.RequestId = context.StringValue("DescribeScdnDomainQpsData.RequestId");
			describeScdnDomainQpsDataResponse.DomainName = context.StringValue("DescribeScdnDomainQpsData.DomainName");
			describeScdnDomainQpsDataResponse.StartTime = context.StringValue("DescribeScdnDomainQpsData.StartTime");
			describeScdnDomainQpsDataResponse.EndTime = context.StringValue("DescribeScdnDomainQpsData.EndTime");
			describeScdnDomainQpsDataResponse.DataInterval = context.StringValue("DescribeScdnDomainQpsData.DataInterval");

			List<DescribeScdnDomainQpsDataResponse.DescribeScdnDomainQpsData_DataModule> describeScdnDomainQpsDataResponse_qpsDataPerInterval = new List<DescribeScdnDomainQpsDataResponse.DescribeScdnDomainQpsData_DataModule>();
			for (int i = 0; i < context.Length("DescribeScdnDomainQpsData.QpsDataPerInterval.Length"); i++) {
				DescribeScdnDomainQpsDataResponse.DescribeScdnDomainQpsData_DataModule dataModule = new DescribeScdnDomainQpsDataResponse.DescribeScdnDomainQpsData_DataModule();
				dataModule.TimeStamp = context.StringValue("DescribeScdnDomainQpsData.QpsDataPerInterval["+ i +"].TimeStamp");
				dataModule.QpsValue = context.StringValue("DescribeScdnDomainQpsData.QpsDataPerInterval["+ i +"].QpsValue");
				dataModule.HttpQpsValue = context.StringValue("DescribeScdnDomainQpsData.QpsDataPerInterval["+ i +"].HttpQpsValue");
				dataModule.HttpsQpsValue = context.StringValue("DescribeScdnDomainQpsData.QpsDataPerInterval["+ i +"].HttpsQpsValue");
				dataModule.AccValue = context.StringValue("DescribeScdnDomainQpsData.QpsDataPerInterval["+ i +"].AccValue");
				dataModule.HttpAccValue = context.StringValue("DescribeScdnDomainQpsData.QpsDataPerInterval["+ i +"].HttpAccValue");
				dataModule.HttpsAccValue = context.StringValue("DescribeScdnDomainQpsData.QpsDataPerInterval["+ i +"].HttpsAccValue");

				describeScdnDomainQpsDataResponse_qpsDataPerInterval.Add(dataModule);
			}
			describeScdnDomainQpsDataResponse.QpsDataPerInterval = describeScdnDomainQpsDataResponse_qpsDataPerInterval;
        
			return describeScdnDomainQpsDataResponse;
        }
    }
}
