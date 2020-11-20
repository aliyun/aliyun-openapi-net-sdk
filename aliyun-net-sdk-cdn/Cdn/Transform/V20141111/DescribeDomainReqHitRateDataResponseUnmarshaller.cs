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
    public class DescribeDomainReqHitRateDataResponseUnmarshaller
    {
        public static DescribeDomainReqHitRateDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDomainReqHitRateDataResponse describeDomainReqHitRateDataResponse = new DescribeDomainReqHitRateDataResponse();

			describeDomainReqHitRateDataResponse.HttpResponse = _ctx.HttpResponse;
			describeDomainReqHitRateDataResponse.RequestId = _ctx.StringValue("DescribeDomainReqHitRateData.RequestId");
			describeDomainReqHitRateDataResponse.DomainName = _ctx.StringValue("DescribeDomainReqHitRateData.DomainName");
			describeDomainReqHitRateDataResponse.StartTime = _ctx.StringValue("DescribeDomainReqHitRateData.StartTime");
			describeDomainReqHitRateDataResponse.EndTime = _ctx.StringValue("DescribeDomainReqHitRateData.EndTime");
			describeDomainReqHitRateDataResponse.DataInterval = _ctx.StringValue("DescribeDomainReqHitRateData.DataInterval");

			List<DescribeDomainReqHitRateDataResponse.DescribeDomainReqHitRateData_DataModule> describeDomainReqHitRateDataResponse_reqHitRateInterval = new List<DescribeDomainReqHitRateDataResponse.DescribeDomainReqHitRateData_DataModule>();
			for (int i = 0; i < _ctx.Length("DescribeDomainReqHitRateData.ReqHitRateInterval.Length"); i++) {
				DescribeDomainReqHitRateDataResponse.DescribeDomainReqHitRateData_DataModule dataModule = new DescribeDomainReqHitRateDataResponse.DescribeDomainReqHitRateData_DataModule();
				dataModule.TimeStamp = _ctx.StringValue("DescribeDomainReqHitRateData.ReqHitRateInterval["+ i +"].TimeStamp");
				dataModule._Value = _ctx.StringValue("DescribeDomainReqHitRateData.ReqHitRateInterval["+ i +"].Value");

				describeDomainReqHitRateDataResponse_reqHitRateInterval.Add(dataModule);
			}
			describeDomainReqHitRateDataResponse.ReqHitRateInterval = describeDomainReqHitRateDataResponse_reqHitRateInterval;
        
			return describeDomainReqHitRateDataResponse;
        }
    }
}
