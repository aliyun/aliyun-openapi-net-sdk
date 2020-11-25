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
    public class DescribeScdnDomainTopReferVisitResponseUnmarshaller
    {
        public static DescribeScdnDomainTopReferVisitResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeScdnDomainTopReferVisitResponse describeScdnDomainTopReferVisitResponse = new DescribeScdnDomainTopReferVisitResponse();

			describeScdnDomainTopReferVisitResponse.HttpResponse = _ctx.HttpResponse;
			describeScdnDomainTopReferVisitResponse.RequestId = _ctx.StringValue("DescribeScdnDomainTopReferVisit.RequestId");
			describeScdnDomainTopReferVisitResponse.DomainName = _ctx.StringValue("DescribeScdnDomainTopReferVisit.DomainName");
			describeScdnDomainTopReferVisitResponse.StartTime = _ctx.StringValue("DescribeScdnDomainTopReferVisit.StartTime");

			List<DescribeScdnDomainTopReferVisitResponse.DescribeScdnDomainTopReferVisit_ReferList> describeScdnDomainTopReferVisitResponse_topReferList = new List<DescribeScdnDomainTopReferVisitResponse.DescribeScdnDomainTopReferVisit_ReferList>();
			for (int i = 0; i < _ctx.Length("DescribeScdnDomainTopReferVisit.TopReferList.Length"); i++) {
				DescribeScdnDomainTopReferVisitResponse.DescribeScdnDomainTopReferVisit_ReferList referList = new DescribeScdnDomainTopReferVisitResponse.DescribeScdnDomainTopReferVisit_ReferList();
				referList.ReferDetail = _ctx.StringValue("DescribeScdnDomainTopReferVisit.TopReferList["+ i +"].ReferDetail");
				referList.VisitData = _ctx.StringValue("DescribeScdnDomainTopReferVisit.TopReferList["+ i +"].VisitData");
				referList.VisitProportion = _ctx.FloatValue("DescribeScdnDomainTopReferVisit.TopReferList["+ i +"].VisitProportion");
				referList.Flow = _ctx.StringValue("DescribeScdnDomainTopReferVisit.TopReferList["+ i +"].Flow");
				referList.FlowProportion = _ctx.FloatValue("DescribeScdnDomainTopReferVisit.TopReferList["+ i +"].FlowProportion");

				describeScdnDomainTopReferVisitResponse_topReferList.Add(referList);
			}
			describeScdnDomainTopReferVisitResponse.TopReferList = describeScdnDomainTopReferVisitResponse_topReferList;
        
			return describeScdnDomainTopReferVisitResponse;
        }
    }
}
