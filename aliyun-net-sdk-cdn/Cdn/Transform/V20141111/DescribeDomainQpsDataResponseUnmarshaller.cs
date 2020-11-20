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
using Aliyun.Acs.Cdn.Model.V20141111;

namespace Aliyun.Acs.Cdn.Transform.V20141111
{
    public class DescribeDomainQpsDataResponseUnmarshaller
    {
        public static DescribeDomainQpsDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDomainQpsDataResponse describeDomainQpsDataResponse = new DescribeDomainQpsDataResponse();

			describeDomainQpsDataResponse.HttpResponse = _ctx.HttpResponse;
			describeDomainQpsDataResponse.RequestId = _ctx.StringValue("DescribeDomainQpsData.RequestId");
			describeDomainQpsDataResponse.DomainName = _ctx.StringValue("DescribeDomainQpsData.DomainName");
			describeDomainQpsDataResponse.StartTime = _ctx.StringValue("DescribeDomainQpsData.StartTime");
			describeDomainQpsDataResponse.EndTime = _ctx.StringValue("DescribeDomainQpsData.EndTime");
			describeDomainQpsDataResponse.DataInterval = _ctx.StringValue("DescribeDomainQpsData.DataInterval");

			List<DescribeDomainQpsDataResponse.DescribeDomainQpsData_DataModule> describeDomainQpsDataResponse_qpsDataInterval = new List<DescribeDomainQpsDataResponse.DescribeDomainQpsData_DataModule>();
			for (int i = 0; i < _ctx.Length("DescribeDomainQpsData.QpsDataInterval.Length"); i++) {
				DescribeDomainQpsDataResponse.DescribeDomainQpsData_DataModule dataModule = new DescribeDomainQpsDataResponse.DescribeDomainQpsData_DataModule();
				dataModule.TimeStamp = _ctx.StringValue("DescribeDomainQpsData.QpsDataInterval["+ i +"].TimeStamp");
				dataModule._Value = _ctx.StringValue("DescribeDomainQpsData.QpsDataInterval["+ i +"].Value");
				dataModule.DomesticValue = _ctx.StringValue("DescribeDomainQpsData.QpsDataInterval["+ i +"].DomesticValue");
				dataModule.OverseasValue = _ctx.StringValue("DescribeDomainQpsData.QpsDataInterval["+ i +"].OverseasValue");
				dataModule.AccValue = _ctx.StringValue("DescribeDomainQpsData.QpsDataInterval["+ i +"].AccValue");
				dataModule.AccDomesticValue = _ctx.StringValue("DescribeDomainQpsData.QpsDataInterval["+ i +"].AccDomesticValue");
				dataModule.AccOverseasValue = _ctx.StringValue("DescribeDomainQpsData.QpsDataInterval["+ i +"].AccOverseasValue");
				dataModule.DynamicValue = _ctx.StringValue("DescribeDomainQpsData.QpsDataInterval["+ i +"].DynamicValue");
				dataModule.DynamicDomesticValue = _ctx.StringValue("DescribeDomainQpsData.QpsDataInterval["+ i +"].DynamicDomesticValue");
				dataModule.DynamicOverseasValue = _ctx.StringValue("DescribeDomainQpsData.QpsDataInterval["+ i +"].DynamicOverseasValue");
				dataModule.StaticValue = _ctx.StringValue("DescribeDomainQpsData.QpsDataInterval["+ i +"].StaticValue");
				dataModule.StaticDomesticValue = _ctx.StringValue("DescribeDomainQpsData.QpsDataInterval["+ i +"].StaticDomesticValue");
				dataModule.StaticOverseasValue = _ctx.StringValue("DescribeDomainQpsData.QpsDataInterval["+ i +"].StaticOverseasValue");

				describeDomainQpsDataResponse_qpsDataInterval.Add(dataModule);
			}
			describeDomainQpsDataResponse.QpsDataInterval = describeDomainQpsDataResponse_qpsDataInterval;
        
			return describeDomainQpsDataResponse;
        }
    }
}
