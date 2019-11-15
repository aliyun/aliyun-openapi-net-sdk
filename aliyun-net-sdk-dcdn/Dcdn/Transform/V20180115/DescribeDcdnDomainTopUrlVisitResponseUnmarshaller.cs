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
    public class DescribeDcdnDomainTopUrlVisitResponseUnmarshaller
    {
        public static DescribeDcdnDomainTopUrlVisitResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDcdnDomainTopUrlVisitResponse describeDcdnDomainTopUrlVisitResponse = new DescribeDcdnDomainTopUrlVisitResponse();

			describeDcdnDomainTopUrlVisitResponse.HttpResponse = context.HttpResponse;
			describeDcdnDomainTopUrlVisitResponse.RequestId = context.StringValue("DescribeDcdnDomainTopUrlVisit.RequestId");
			describeDcdnDomainTopUrlVisitResponse.DomainName = context.StringValue("DescribeDcdnDomainTopUrlVisit.DomainName");
			describeDcdnDomainTopUrlVisitResponse.StartTime = context.StringValue("DescribeDcdnDomainTopUrlVisit.StartTime");

			List<DescribeDcdnDomainTopUrlVisitResponse.DescribeDcdnDomainTopUrlVisit_UrlList> describeDcdnDomainTopUrlVisitResponse_allUrlList = new List<DescribeDcdnDomainTopUrlVisitResponse.DescribeDcdnDomainTopUrlVisit_UrlList>();
			for (int i = 0; i < context.Length("DescribeDcdnDomainTopUrlVisit.AllUrlList.Length"); i++) {
				DescribeDcdnDomainTopUrlVisitResponse.DescribeDcdnDomainTopUrlVisit_UrlList urlList = new DescribeDcdnDomainTopUrlVisitResponse.DescribeDcdnDomainTopUrlVisit_UrlList();
				urlList.UrlDetail = context.StringValue("DescribeDcdnDomainTopUrlVisit.AllUrlList["+ i +"].UrlDetail");
				urlList.VisitData = context.StringValue("DescribeDcdnDomainTopUrlVisit.AllUrlList["+ i +"].VisitData");
				urlList.VisitProportion = context.FloatValue("DescribeDcdnDomainTopUrlVisit.AllUrlList["+ i +"].VisitProportion");
				urlList.Flow = context.StringValue("DescribeDcdnDomainTopUrlVisit.AllUrlList["+ i +"].Flow");
				urlList.FlowProportion = context.FloatValue("DescribeDcdnDomainTopUrlVisit.AllUrlList["+ i +"].FlowProportion");

				describeDcdnDomainTopUrlVisitResponse_allUrlList.Add(urlList);
			}
			describeDcdnDomainTopUrlVisitResponse.AllUrlList = describeDcdnDomainTopUrlVisitResponse_allUrlList;

			List<DescribeDcdnDomainTopUrlVisitResponse.DescribeDcdnDomainTopUrlVisit_UrlList> describeDcdnDomainTopUrlVisitResponse_url200List = new List<DescribeDcdnDomainTopUrlVisitResponse.DescribeDcdnDomainTopUrlVisit_UrlList>();
			for (int i = 0; i < context.Length("DescribeDcdnDomainTopUrlVisit.Url200List.Length"); i++) {
				DescribeDcdnDomainTopUrlVisitResponse.DescribeDcdnDomainTopUrlVisit_UrlList urlList = new DescribeDcdnDomainTopUrlVisitResponse.DescribeDcdnDomainTopUrlVisit_UrlList();
				urlList.UrlDetail = context.StringValue("DescribeDcdnDomainTopUrlVisit.Url200List["+ i +"].UrlDetail");
				urlList.VisitData = context.StringValue("DescribeDcdnDomainTopUrlVisit.Url200List["+ i +"].VisitData");
				urlList.VisitProportion = context.FloatValue("DescribeDcdnDomainTopUrlVisit.Url200List["+ i +"].VisitProportion");
				urlList.Flow = context.StringValue("DescribeDcdnDomainTopUrlVisit.Url200List["+ i +"].Flow");
				urlList.FlowProportion = context.FloatValue("DescribeDcdnDomainTopUrlVisit.Url200List["+ i +"].FlowProportion");

				describeDcdnDomainTopUrlVisitResponse_url200List.Add(urlList);
			}
			describeDcdnDomainTopUrlVisitResponse.Url200List = describeDcdnDomainTopUrlVisitResponse_url200List;

			List<DescribeDcdnDomainTopUrlVisitResponse.DescribeDcdnDomainTopUrlVisit_UrlList> describeDcdnDomainTopUrlVisitResponse_url300List = new List<DescribeDcdnDomainTopUrlVisitResponse.DescribeDcdnDomainTopUrlVisit_UrlList>();
			for (int i = 0; i < context.Length("DescribeDcdnDomainTopUrlVisit.Url300List.Length"); i++) {
				DescribeDcdnDomainTopUrlVisitResponse.DescribeDcdnDomainTopUrlVisit_UrlList urlList = new DescribeDcdnDomainTopUrlVisitResponse.DescribeDcdnDomainTopUrlVisit_UrlList();
				urlList.UrlDetail = context.StringValue("DescribeDcdnDomainTopUrlVisit.Url300List["+ i +"].UrlDetail");
				urlList.VisitData = context.StringValue("DescribeDcdnDomainTopUrlVisit.Url300List["+ i +"].VisitData");
				urlList.VisitProportion = context.FloatValue("DescribeDcdnDomainTopUrlVisit.Url300List["+ i +"].VisitProportion");
				urlList.Flow = context.StringValue("DescribeDcdnDomainTopUrlVisit.Url300List["+ i +"].Flow");
				urlList.FlowProportion = context.FloatValue("DescribeDcdnDomainTopUrlVisit.Url300List["+ i +"].FlowProportion");

				describeDcdnDomainTopUrlVisitResponse_url300List.Add(urlList);
			}
			describeDcdnDomainTopUrlVisitResponse.Url300List = describeDcdnDomainTopUrlVisitResponse_url300List;

			List<DescribeDcdnDomainTopUrlVisitResponse.DescribeDcdnDomainTopUrlVisit_UrlList> describeDcdnDomainTopUrlVisitResponse_url400List = new List<DescribeDcdnDomainTopUrlVisitResponse.DescribeDcdnDomainTopUrlVisit_UrlList>();
			for (int i = 0; i < context.Length("DescribeDcdnDomainTopUrlVisit.Url400List.Length"); i++) {
				DescribeDcdnDomainTopUrlVisitResponse.DescribeDcdnDomainTopUrlVisit_UrlList urlList = new DescribeDcdnDomainTopUrlVisitResponse.DescribeDcdnDomainTopUrlVisit_UrlList();
				urlList.UrlDetail = context.StringValue("DescribeDcdnDomainTopUrlVisit.Url400List["+ i +"].UrlDetail");
				urlList.VisitData = context.StringValue("DescribeDcdnDomainTopUrlVisit.Url400List["+ i +"].VisitData");
				urlList.VisitProportion = context.FloatValue("DescribeDcdnDomainTopUrlVisit.Url400List["+ i +"].VisitProportion");
				urlList.Flow = context.StringValue("DescribeDcdnDomainTopUrlVisit.Url400List["+ i +"].Flow");
				urlList.FlowProportion = context.FloatValue("DescribeDcdnDomainTopUrlVisit.Url400List["+ i +"].FlowProportion");

				describeDcdnDomainTopUrlVisitResponse_url400List.Add(urlList);
			}
			describeDcdnDomainTopUrlVisitResponse.Url400List = describeDcdnDomainTopUrlVisitResponse_url400List;

			List<DescribeDcdnDomainTopUrlVisitResponse.DescribeDcdnDomainTopUrlVisit_UrlList> describeDcdnDomainTopUrlVisitResponse_url500List = new List<DescribeDcdnDomainTopUrlVisitResponse.DescribeDcdnDomainTopUrlVisit_UrlList>();
			for (int i = 0; i < context.Length("DescribeDcdnDomainTopUrlVisit.Url500List.Length"); i++) {
				DescribeDcdnDomainTopUrlVisitResponse.DescribeDcdnDomainTopUrlVisit_UrlList urlList = new DescribeDcdnDomainTopUrlVisitResponse.DescribeDcdnDomainTopUrlVisit_UrlList();
				urlList.UrlDetail = context.StringValue("DescribeDcdnDomainTopUrlVisit.Url500List["+ i +"].UrlDetail");
				urlList.VisitData = context.StringValue("DescribeDcdnDomainTopUrlVisit.Url500List["+ i +"].VisitData");
				urlList.VisitProportion = context.FloatValue("DescribeDcdnDomainTopUrlVisit.Url500List["+ i +"].VisitProportion");
				urlList.Flow = context.StringValue("DescribeDcdnDomainTopUrlVisit.Url500List["+ i +"].Flow");
				urlList.FlowProportion = context.FloatValue("DescribeDcdnDomainTopUrlVisit.Url500List["+ i +"].FlowProportion");

				describeDcdnDomainTopUrlVisitResponse_url500List.Add(urlList);
			}
			describeDcdnDomainTopUrlVisitResponse.Url500List = describeDcdnDomainTopUrlVisitResponse_url500List;
        
			return describeDcdnDomainTopUrlVisitResponse;
        }
    }
}
