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
    public class DescribeDomainTopReferVisitResponseUnmarshaller
    {
        public static DescribeDomainTopReferVisitResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDomainTopReferVisitResponse describeDomainTopReferVisitResponse = new DescribeDomainTopReferVisitResponse();

			describeDomainTopReferVisitResponse.HttpResponse = _ctx.HttpResponse;
			describeDomainTopReferVisitResponse.RequestId = _ctx.StringValue("DescribeDomainTopReferVisit.RequestId");
			describeDomainTopReferVisitResponse.DomainName = _ctx.StringValue("DescribeDomainTopReferVisit.DomainName");
			describeDomainTopReferVisitResponse.StartTime = _ctx.StringValue("DescribeDomainTopReferVisit.StartTime");

			List<DescribeDomainTopReferVisitResponse.DescribeDomainTopReferVisit_ReferList> describeDomainTopReferVisitResponse_topReferList = new List<DescribeDomainTopReferVisitResponse.DescribeDomainTopReferVisit_ReferList>();
			for (int i = 0; i < _ctx.Length("DescribeDomainTopReferVisit.TopReferList.Length"); i++) {
				DescribeDomainTopReferVisitResponse.DescribeDomainTopReferVisit_ReferList referList = new DescribeDomainTopReferVisitResponse.DescribeDomainTopReferVisit_ReferList();
				referList.ReferDetail = _ctx.StringValue("DescribeDomainTopReferVisit.TopReferList["+ i +"].ReferDetail");
				referList.VisitData = _ctx.StringValue("DescribeDomainTopReferVisit.TopReferList["+ i +"].VisitData");
				referList.VisitProportion = _ctx.FloatValue("DescribeDomainTopReferVisit.TopReferList["+ i +"].VisitProportion");
				referList.Flow = _ctx.StringValue("DescribeDomainTopReferVisit.TopReferList["+ i +"].Flow");
				referList.FlowProportion = _ctx.FloatValue("DescribeDomainTopReferVisit.TopReferList["+ i +"].FlowProportion");

				describeDomainTopReferVisitResponse_topReferList.Add(referList);
			}
			describeDomainTopReferVisitResponse.TopReferList = describeDomainTopReferVisitResponse_topReferList;
        
			return describeDomainTopReferVisitResponse;
        }
    }
}
