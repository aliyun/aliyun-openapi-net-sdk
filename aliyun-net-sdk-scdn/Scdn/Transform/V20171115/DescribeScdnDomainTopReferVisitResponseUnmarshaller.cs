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
        public static DescribeScdnDomainTopReferVisitResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeScdnDomainTopReferVisitResponse describeScdnDomainTopReferVisitResponse = new DescribeScdnDomainTopReferVisitResponse();

			describeScdnDomainTopReferVisitResponse.HttpResponse = context.HttpResponse;
			describeScdnDomainTopReferVisitResponse.RequestId = context.StringValue("DescribeScdnDomainTopReferVisit.RequestId");
			describeScdnDomainTopReferVisitResponse.DomainName = context.StringValue("DescribeScdnDomainTopReferVisit.DomainName");
			describeScdnDomainTopReferVisitResponse.StartTime = context.StringValue("DescribeScdnDomainTopReferVisit.StartTime");

			List<DescribeScdnDomainTopReferVisitResponse.DescribeScdnDomainTopReferVisit_ReferList> describeScdnDomainTopReferVisitResponse_topReferList = new List<DescribeScdnDomainTopReferVisitResponse.DescribeScdnDomainTopReferVisit_ReferList>();
			for (int i = 0; i < context.Length("DescribeScdnDomainTopReferVisit.TopReferList.Length"); i++) {
				DescribeScdnDomainTopReferVisitResponse.DescribeScdnDomainTopReferVisit_ReferList referList = new DescribeScdnDomainTopReferVisitResponse.DescribeScdnDomainTopReferVisit_ReferList();
				referList.ReferDetail = context.StringValue("DescribeScdnDomainTopReferVisit.TopReferList["+ i +"].ReferDetail");
				referList.VisitData = context.StringValue("DescribeScdnDomainTopReferVisit.TopReferList["+ i +"].VisitData");
				referList.VisitProportion = context.FloatValue("DescribeScdnDomainTopReferVisit.TopReferList["+ i +"].VisitProportion");
				referList.Flow = context.StringValue("DescribeScdnDomainTopReferVisit.TopReferList["+ i +"].Flow");
				referList.FlowProportion = context.FloatValue("DescribeScdnDomainTopReferVisit.TopReferList["+ i +"].FlowProportion");

				describeScdnDomainTopReferVisitResponse_topReferList.Add(referList);
			}
			describeScdnDomainTopReferVisitResponse.TopReferList = describeScdnDomainTopReferVisitResponse_topReferList;
        
			return describeScdnDomainTopReferVisitResponse;
        }
    }
}
