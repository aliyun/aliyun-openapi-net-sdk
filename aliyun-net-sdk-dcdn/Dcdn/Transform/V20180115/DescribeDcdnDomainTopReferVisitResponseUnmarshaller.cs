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
using Aliyun.Acs.dcdn.Model.V20180115;

namespace Aliyun.Acs.dcdn.Transform.V20180115
{
    public class DescribeDcdnDomainTopReferVisitResponseUnmarshaller
    {
        public static DescribeDcdnDomainTopReferVisitResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDcdnDomainTopReferVisitResponse describeDcdnDomainTopReferVisitResponse = new DescribeDcdnDomainTopReferVisitResponse();

			describeDcdnDomainTopReferVisitResponse.HttpResponse = context.HttpResponse;
			describeDcdnDomainTopReferVisitResponse.RequestId = context.StringValue("DescribeDcdnDomainTopReferVisit.RequestId");
			describeDcdnDomainTopReferVisitResponse.DomainName = context.StringValue("DescribeDcdnDomainTopReferVisit.DomainName");
			describeDcdnDomainTopReferVisitResponse.StartTime = context.StringValue("DescribeDcdnDomainTopReferVisit.StartTime");

			List<DescribeDcdnDomainTopReferVisitResponse.DescribeDcdnDomainTopReferVisit_ReferList> describeDcdnDomainTopReferVisitResponse_topReferList = new List<DescribeDcdnDomainTopReferVisitResponse.DescribeDcdnDomainTopReferVisit_ReferList>();
			for (int i = 0; i < context.Length("DescribeDcdnDomainTopReferVisit.TopReferList.Length"); i++) {
				DescribeDcdnDomainTopReferVisitResponse.DescribeDcdnDomainTopReferVisit_ReferList referList = new DescribeDcdnDomainTopReferVisitResponse.DescribeDcdnDomainTopReferVisit_ReferList();
				referList.ReferDetail = context.StringValue("DescribeDcdnDomainTopReferVisit.TopReferList["+ i +"].ReferDetail");
				referList.VisitData = context.StringValue("DescribeDcdnDomainTopReferVisit.TopReferList["+ i +"].VisitData");
				referList.VisitProportion = context.FloatValue("DescribeDcdnDomainTopReferVisit.TopReferList["+ i +"].VisitProportion");
				referList.Flow = context.StringValue("DescribeDcdnDomainTopReferVisit.TopReferList["+ i +"].Flow");
				referList.FlowProportion = context.FloatValue("DescribeDcdnDomainTopReferVisit.TopReferList["+ i +"].FlowProportion");

				describeDcdnDomainTopReferVisitResponse_topReferList.Add(referList);
			}
			describeDcdnDomainTopReferVisitResponse.TopReferList = describeDcdnDomainTopReferVisitResponse_topReferList;
        
			return describeDcdnDomainTopReferVisitResponse;
        }
    }
}
