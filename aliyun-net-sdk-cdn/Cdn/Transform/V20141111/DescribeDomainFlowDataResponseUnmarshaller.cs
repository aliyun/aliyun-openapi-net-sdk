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
    public class DescribeDomainFlowDataResponseUnmarshaller
    {
        public static DescribeDomainFlowDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDomainFlowDataResponse describeDomainFlowDataResponse = new DescribeDomainFlowDataResponse();

			describeDomainFlowDataResponse.HttpResponse = _ctx.HttpResponse;
			describeDomainFlowDataResponse.EndTime = _ctx.StringValue("DescribeDomainFlowData.EndTime");
			describeDomainFlowDataResponse.StartTime = _ctx.StringValue("DescribeDomainFlowData.StartTime");
			describeDomainFlowDataResponse.RequestId = _ctx.StringValue("DescribeDomainFlowData.RequestId");
			describeDomainFlowDataResponse.DomainName = _ctx.StringValue("DescribeDomainFlowData.DomainName");
			describeDomainFlowDataResponse.DataInterval = _ctx.StringValue("DescribeDomainFlowData.DataInterval");

			List<DescribeDomainFlowDataResponse.DescribeDomainFlowData_DataModule> describeDomainFlowDataResponse_flowDataPerInterval = new List<DescribeDomainFlowDataResponse.DescribeDomainFlowData_DataModule>();
			for (int i = 0; i < _ctx.Length("DescribeDomainFlowData.FlowDataPerInterval.Length"); i++) {
				DescribeDomainFlowDataResponse.DescribeDomainFlowData_DataModule dataModule = new DescribeDomainFlowDataResponse.DescribeDomainFlowData_DataModule();
				dataModule._Value = _ctx.StringValue("DescribeDomainFlowData.FlowDataPerInterval["+ i +"].Value");
				dataModule.StaticDomesticValue = _ctx.StringValue("DescribeDomainFlowData.FlowDataPerInterval["+ i +"].StaticDomesticValue");
				dataModule.DynamicValue = _ctx.StringValue("DescribeDomainFlowData.FlowDataPerInterval["+ i +"].DynamicValue");
				dataModule.OverseasValue = _ctx.StringValue("DescribeDomainFlowData.FlowDataPerInterval["+ i +"].OverseasValue");
				dataModule.StaticValue = _ctx.StringValue("DescribeDomainFlowData.FlowDataPerInterval["+ i +"].StaticValue");
				dataModule.TimeStamp = _ctx.StringValue("DescribeDomainFlowData.FlowDataPerInterval["+ i +"].TimeStamp");
				dataModule.StaticOverseasValue = _ctx.StringValue("DescribeDomainFlowData.FlowDataPerInterval["+ i +"].StaticOverseasValue");
				dataModule.DynamicDomesticValue = _ctx.StringValue("DescribeDomainFlowData.FlowDataPerInterval["+ i +"].DynamicDomesticValue");
				dataModule.DomesticValue = _ctx.StringValue("DescribeDomainFlowData.FlowDataPerInterval["+ i +"].DomesticValue");
				dataModule.DynamicOverseasValue = _ctx.StringValue("DescribeDomainFlowData.FlowDataPerInterval["+ i +"].DynamicOverseasValue");

				describeDomainFlowDataResponse_flowDataPerInterval.Add(dataModule);
			}
			describeDomainFlowDataResponse.FlowDataPerInterval = describeDomainFlowDataResponse_flowDataPerInterval;
        
			return describeDomainFlowDataResponse;
        }
    }
}
