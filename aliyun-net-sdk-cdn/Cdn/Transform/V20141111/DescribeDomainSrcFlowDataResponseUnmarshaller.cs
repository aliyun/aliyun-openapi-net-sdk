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
    public class DescribeDomainSrcFlowDataResponseUnmarshaller
    {
        public static DescribeDomainSrcFlowDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDomainSrcFlowDataResponse describeDomainSrcFlowDataResponse = new DescribeDomainSrcFlowDataResponse();

			describeDomainSrcFlowDataResponse.HttpResponse = context.HttpResponse;
			describeDomainSrcFlowDataResponse.RequestId = context.StringValue("DescribeDomainSrcFlowData.RequestId");
			describeDomainSrcFlowDataResponse.DomainName = context.StringValue("DescribeDomainSrcFlowData.DomainName");
			describeDomainSrcFlowDataResponse.DataInterval = context.StringValue("DescribeDomainSrcFlowData.DataInterval");
			describeDomainSrcFlowDataResponse.StartTime = context.StringValue("DescribeDomainSrcFlowData.StartTime");
			describeDomainSrcFlowDataResponse.EndTime = context.StringValue("DescribeDomainSrcFlowData.EndTime");

			List<DescribeDomainSrcFlowDataResponse.DescribeDomainSrcFlowData_DataModule> describeDomainSrcFlowDataResponse_srcFlowDataPerInterval = new List<DescribeDomainSrcFlowDataResponse.DescribeDomainSrcFlowData_DataModule>();
			for (int i = 0; i < context.Length("DescribeDomainSrcFlowData.SrcFlowDataPerInterval.Length"); i++) {
				DescribeDomainSrcFlowDataResponse.DescribeDomainSrcFlowData_DataModule dataModule = new DescribeDomainSrcFlowDataResponse.DescribeDomainSrcFlowData_DataModule();
				dataModule.TimeStamp = context.StringValue("DescribeDomainSrcFlowData.SrcFlowDataPerInterval["+ i +"].TimeStamp");
				dataModule._Value = context.StringValue("DescribeDomainSrcFlowData.SrcFlowDataPerInterval["+ i +"].Value");

				describeDomainSrcFlowDataResponse_srcFlowDataPerInterval.Add(dataModule);
			}
			describeDomainSrcFlowDataResponse.SrcFlowDataPerInterval = describeDomainSrcFlowDataResponse_srcFlowDataPerInterval;
        
			return describeDomainSrcFlowDataResponse;
        }
    }
}