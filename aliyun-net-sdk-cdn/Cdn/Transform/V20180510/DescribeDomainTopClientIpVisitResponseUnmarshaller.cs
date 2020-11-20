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
    public class DescribeDomainTopClientIpVisitResponseUnmarshaller
    {
        public static DescribeDomainTopClientIpVisitResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDomainTopClientIpVisitResponse describeDomainTopClientIpVisitResponse = new DescribeDomainTopClientIpVisitResponse();

			describeDomainTopClientIpVisitResponse.HttpResponse = _ctx.HttpResponse;
			describeDomainTopClientIpVisitResponse.RequestId = _ctx.StringValue("DescribeDomainTopClientIpVisit.RequestId");

			List<DescribeDomainTopClientIpVisitResponse.DescribeDomainTopClientIpVisit_ClientIp> describeDomainTopClientIpVisitResponse_clientIpList = new List<DescribeDomainTopClientIpVisitResponse.DescribeDomainTopClientIpVisit_ClientIp>();
			for (int i = 0; i < _ctx.Length("DescribeDomainTopClientIpVisit.ClientIpList.Length"); i++) {
				DescribeDomainTopClientIpVisitResponse.DescribeDomainTopClientIpVisit_ClientIp clientIp = new DescribeDomainTopClientIpVisitResponse.DescribeDomainTopClientIpVisit_ClientIp();
				clientIp.Rank = _ctx.IntegerValue("DescribeDomainTopClientIpVisit.ClientIpList["+ i +"].Rank");
				clientIp.ClientIp = _ctx.StringValue("DescribeDomainTopClientIpVisit.ClientIpList["+ i +"].ClientIp");
				clientIp.Traffic = _ctx.LongValue("DescribeDomainTopClientIpVisit.ClientIpList["+ i +"].Traffic");
				clientIp.Acc = _ctx.LongValue("DescribeDomainTopClientIpVisit.ClientIpList["+ i +"].Acc");

				describeDomainTopClientIpVisitResponse_clientIpList.Add(clientIp);
			}
			describeDomainTopClientIpVisitResponse.ClientIpList = describeDomainTopClientIpVisitResponse_clientIpList;
        
			return describeDomainTopClientIpVisitResponse;
        }
    }
}
