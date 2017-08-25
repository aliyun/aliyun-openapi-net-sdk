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
    public class DescribeDomainUpstreamOfCenterResponseUnmarshaller
    {
        public static DescribeDomainUpstreamOfCenterResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDomainUpstreamOfCenterResponse describeDomainUpstreamOfCenterResponse = new DescribeDomainUpstreamOfCenterResponse();

			describeDomainUpstreamOfCenterResponse.HttpResponse = context.HttpResponse;
			describeDomainUpstreamOfCenterResponse.RequestId = context.StringValue("DescribeDomainUpstreamOfCenter.RequestId");

			List<DescribeDomainUpstreamOfCenterResponse.DescribeDomainUpstreamOfCenter_DomainBpsModel> describeDomainUpstreamOfCenterResponse_bpsDatas = new List<DescribeDomainUpstreamOfCenterResponse.DescribeDomainUpstreamOfCenter_DomainBpsModel>();
			for (int i = 0; i < context.Length("DescribeDomainUpstreamOfCenter.BpsDatas.Length"); i++) {
				DescribeDomainUpstreamOfCenterResponse.DescribeDomainUpstreamOfCenter_DomainBpsModel domainBpsModel = new DescribeDomainUpstreamOfCenterResponse.DescribeDomainUpstreamOfCenter_DomainBpsModel();
				domainBpsModel.Time = context.StringValue("DescribeDomainUpstreamOfCenter.BpsDatas["+ i +"].Time");
				domainBpsModel.Bps = context.FloatValue("DescribeDomainUpstreamOfCenter.BpsDatas["+ i +"].Bps");

				describeDomainUpstreamOfCenterResponse_bpsDatas.Add(domainBpsModel);
			}
			describeDomainUpstreamOfCenterResponse.BpsDatas = describeDomainUpstreamOfCenterResponse_bpsDatas;
        
			return describeDomainUpstreamOfCenterResponse;
        }
    }
}