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
using Aliyun.Acs.Cdn.Model.V20141111;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Transform.V20141111
{
    public class DescribeDomainFlowDataResponseUnmarshaller
    {
        public static DescribeDomainFlowDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDomainFlowDataResponse describeDomainFlowDataResponse = new DescribeDomainFlowDataResponse();

			describeDomainFlowDataResponse.HttpResponse = context.HttpResponse;
			describeDomainFlowDataResponse.RequestId = context.StringValue("DescribeDomainFlowData.RequestId");
			describeDomainFlowDataResponse.DomainName = context.StringValue("DescribeDomainFlowData.DomainName");
			describeDomainFlowDataResponse.DataInterval = context.StringValue("DescribeDomainFlowData.DataInterval");
			describeDomainFlowDataResponse.StartTime = context.StringValue("DescribeDomainFlowData.StartTime");
			describeDomainFlowDataResponse.EndTime = context.StringValue("DescribeDomainFlowData.EndTime");

			List<DescribeDomainFlowDataResponse.DescribeDomainFlowData_DataModule> describeDomainFlowDataResponse_flowDataPerInterval = new List<DescribeDomainFlowDataResponse.DescribeDomainFlowData_DataModule>();
			for (int i = 0; i < context.Length("DescribeDomainFlowData.FlowDataPerInterval.Length"); i++) {
				DescribeDomainFlowDataResponse.DescribeDomainFlowData_DataModule dataModule = new DescribeDomainFlowDataResponse.DescribeDomainFlowData_DataModule();
				dataModule.TimeStamp = context.StringValue("DescribeDomainFlowData.FlowDataPerInterval["+ i +"].TimeStamp");
				dataModule._Value = context.StringValue("DescribeDomainFlowData.FlowDataPerInterval["+ i +"].Value");
				dataModule.DomesticValue = context.StringValue("DescribeDomainFlowData.FlowDataPerInterval["+ i +"].DomesticValue");
				dataModule.OverseasValue = context.StringValue("DescribeDomainFlowData.FlowDataPerInterval["+ i +"].OverseasValue");
				dataModule.DynamicValue = context.StringValue("DescribeDomainFlowData.FlowDataPerInterval["+ i +"].DynamicValue");
				dataModule.DynamicDomesticValue = context.StringValue("DescribeDomainFlowData.FlowDataPerInterval["+ i +"].DynamicDomesticValue");
				dataModule.DynamicOverseasValue = context.StringValue("DescribeDomainFlowData.FlowDataPerInterval["+ i +"].DynamicOverseasValue");
				dataModule.StaticValue = context.StringValue("DescribeDomainFlowData.FlowDataPerInterval["+ i +"].StaticValue");
				dataModule.StaticDomesticValue = context.StringValue("DescribeDomainFlowData.FlowDataPerInterval["+ i +"].StaticDomesticValue");
				dataModule.StaticOverseasValue = context.StringValue("DescribeDomainFlowData.FlowDataPerInterval["+ i +"].StaticOverseasValue");

				describeDomainFlowDataResponse_flowDataPerInterval.Add(dataModule);
			}
			describeDomainFlowDataResponse.FlowDataPerInterval = describeDomainFlowDataResponse_flowDataPerInterval;
        
			return describeDomainFlowDataResponse;
        }
    }
}