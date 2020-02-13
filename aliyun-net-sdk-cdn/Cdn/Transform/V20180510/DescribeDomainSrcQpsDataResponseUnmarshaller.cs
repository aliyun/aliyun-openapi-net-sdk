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
    public class DescribeDomainSrcQpsDataResponseUnmarshaller
    {
        public static DescribeDomainSrcQpsDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDomainSrcQpsDataResponse describeDomainSrcQpsDataResponse = new DescribeDomainSrcQpsDataResponse();

			describeDomainSrcQpsDataResponse.HttpResponse = context.HttpResponse;
			describeDomainSrcQpsDataResponse.RequestId = context.StringValue("DescribeDomainSrcQpsData.RequestId");
			describeDomainSrcQpsDataResponse.DomainName = context.StringValue("DescribeDomainSrcQpsData.DomainName");
			describeDomainSrcQpsDataResponse.StartTime = context.StringValue("DescribeDomainSrcQpsData.StartTime");
			describeDomainSrcQpsDataResponse.EndTime = context.StringValue("DescribeDomainSrcQpsData.EndTime");
			describeDomainSrcQpsDataResponse.DataInterval = context.StringValue("DescribeDomainSrcQpsData.DataInterval");

			List<DescribeDomainSrcQpsDataResponse.DescribeDomainSrcQpsData_DataModule> describeDomainSrcQpsDataResponse_srcQpsDataPerInterval = new List<DescribeDomainSrcQpsDataResponse.DescribeDomainSrcQpsData_DataModule>();
			for (int i = 0; i < context.Length("DescribeDomainSrcQpsData.SrcQpsDataPerInterval.Length"); i++) {
				DescribeDomainSrcQpsDataResponse.DescribeDomainSrcQpsData_DataModule dataModule = new DescribeDomainSrcQpsDataResponse.DescribeDomainSrcQpsData_DataModule();
				dataModule.TimeStamp = context.StringValue("DescribeDomainSrcQpsData.SrcQpsDataPerInterval["+ i +"].TimeStamp");
				dataModule._Value = context.StringValue("DescribeDomainSrcQpsData.SrcQpsDataPerInterval["+ i +"].Value");

				describeDomainSrcQpsDataResponse_srcQpsDataPerInterval.Add(dataModule);
			}
			describeDomainSrcQpsDataResponse.SrcQpsDataPerInterval = describeDomainSrcQpsDataResponse_srcQpsDataPerInterval;
        
			return describeDomainSrcQpsDataResponse;
        }
    }
}
