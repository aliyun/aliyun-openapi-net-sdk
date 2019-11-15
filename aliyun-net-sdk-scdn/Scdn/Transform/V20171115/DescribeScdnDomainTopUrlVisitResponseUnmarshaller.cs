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
    public class DescribeScdnDomainTopUrlVisitResponseUnmarshaller
    {
        public static DescribeScdnDomainTopUrlVisitResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeScdnDomainTopUrlVisitResponse describeScdnDomainTopUrlVisitResponse = new DescribeScdnDomainTopUrlVisitResponse();

			describeScdnDomainTopUrlVisitResponse.HttpResponse = context.HttpResponse;
			describeScdnDomainTopUrlVisitResponse.RequestId = context.StringValue("DescribeScdnDomainTopUrlVisit.RequestId");
			describeScdnDomainTopUrlVisitResponse.DomainName = context.StringValue("DescribeScdnDomainTopUrlVisit.DomainName");
			describeScdnDomainTopUrlVisitResponse.StartTime = context.StringValue("DescribeScdnDomainTopUrlVisit.StartTime");

			List<DescribeScdnDomainTopUrlVisitResponse.DescribeScdnDomainTopUrlVisit_UrlList> describeScdnDomainTopUrlVisitResponse_allUrlList = new List<DescribeScdnDomainTopUrlVisitResponse.DescribeScdnDomainTopUrlVisit_UrlList>();
			for (int i = 0; i < context.Length("DescribeScdnDomainTopUrlVisit.AllUrlList.Length"); i++) {
				DescribeScdnDomainTopUrlVisitResponse.DescribeScdnDomainTopUrlVisit_UrlList urlList = new DescribeScdnDomainTopUrlVisitResponse.DescribeScdnDomainTopUrlVisit_UrlList();
				urlList.UrlDetail = context.StringValue("DescribeScdnDomainTopUrlVisit.AllUrlList["+ i +"].UrlDetail");
				urlList.VisitData = context.StringValue("DescribeScdnDomainTopUrlVisit.AllUrlList["+ i +"].VisitData");
				urlList.VisitProportion = context.FloatValue("DescribeScdnDomainTopUrlVisit.AllUrlList["+ i +"].VisitProportion");
				urlList.Flow = context.StringValue("DescribeScdnDomainTopUrlVisit.AllUrlList["+ i +"].Flow");
				urlList.FlowProportion = context.FloatValue("DescribeScdnDomainTopUrlVisit.AllUrlList["+ i +"].FlowProportion");

				describeScdnDomainTopUrlVisitResponse_allUrlList.Add(urlList);
			}
			describeScdnDomainTopUrlVisitResponse.AllUrlList = describeScdnDomainTopUrlVisitResponse_allUrlList;

			List<DescribeScdnDomainTopUrlVisitResponse.DescribeScdnDomainTopUrlVisit_UrlList> describeScdnDomainTopUrlVisitResponse_url200List = new List<DescribeScdnDomainTopUrlVisitResponse.DescribeScdnDomainTopUrlVisit_UrlList>();
			for (int i = 0; i < context.Length("DescribeScdnDomainTopUrlVisit.Url200List.Length"); i++) {
				DescribeScdnDomainTopUrlVisitResponse.DescribeScdnDomainTopUrlVisit_UrlList urlList = new DescribeScdnDomainTopUrlVisitResponse.DescribeScdnDomainTopUrlVisit_UrlList();
				urlList.UrlDetail = context.StringValue("DescribeScdnDomainTopUrlVisit.Url200List["+ i +"].UrlDetail");
				urlList.VisitData = context.StringValue("DescribeScdnDomainTopUrlVisit.Url200List["+ i +"].VisitData");
				urlList.VisitProportion = context.FloatValue("DescribeScdnDomainTopUrlVisit.Url200List["+ i +"].VisitProportion");
				urlList.Flow = context.StringValue("DescribeScdnDomainTopUrlVisit.Url200List["+ i +"].Flow");
				urlList.FlowProportion = context.FloatValue("DescribeScdnDomainTopUrlVisit.Url200List["+ i +"].FlowProportion");

				describeScdnDomainTopUrlVisitResponse_url200List.Add(urlList);
			}
			describeScdnDomainTopUrlVisitResponse.Url200List = describeScdnDomainTopUrlVisitResponse_url200List;

			List<DescribeScdnDomainTopUrlVisitResponse.DescribeScdnDomainTopUrlVisit_UrlList> describeScdnDomainTopUrlVisitResponse_url300List = new List<DescribeScdnDomainTopUrlVisitResponse.DescribeScdnDomainTopUrlVisit_UrlList>();
			for (int i = 0; i < context.Length("DescribeScdnDomainTopUrlVisit.Url300List.Length"); i++) {
				DescribeScdnDomainTopUrlVisitResponse.DescribeScdnDomainTopUrlVisit_UrlList urlList = new DescribeScdnDomainTopUrlVisitResponse.DescribeScdnDomainTopUrlVisit_UrlList();
				urlList.UrlDetail = context.StringValue("DescribeScdnDomainTopUrlVisit.Url300List["+ i +"].UrlDetail");
				urlList.VisitData = context.StringValue("DescribeScdnDomainTopUrlVisit.Url300List["+ i +"].VisitData");
				urlList.VisitProportion = context.FloatValue("DescribeScdnDomainTopUrlVisit.Url300List["+ i +"].VisitProportion");
				urlList.Flow = context.StringValue("DescribeScdnDomainTopUrlVisit.Url300List["+ i +"].Flow");
				urlList.FlowProportion = context.FloatValue("DescribeScdnDomainTopUrlVisit.Url300List["+ i +"].FlowProportion");

				describeScdnDomainTopUrlVisitResponse_url300List.Add(urlList);
			}
			describeScdnDomainTopUrlVisitResponse.Url300List = describeScdnDomainTopUrlVisitResponse_url300List;

			List<DescribeScdnDomainTopUrlVisitResponse.DescribeScdnDomainTopUrlVisit_UrlList> describeScdnDomainTopUrlVisitResponse_url400List = new List<DescribeScdnDomainTopUrlVisitResponse.DescribeScdnDomainTopUrlVisit_UrlList>();
			for (int i = 0; i < context.Length("DescribeScdnDomainTopUrlVisit.Url400List.Length"); i++) {
				DescribeScdnDomainTopUrlVisitResponse.DescribeScdnDomainTopUrlVisit_UrlList urlList = new DescribeScdnDomainTopUrlVisitResponse.DescribeScdnDomainTopUrlVisit_UrlList();
				urlList.UrlDetail = context.StringValue("DescribeScdnDomainTopUrlVisit.Url400List["+ i +"].UrlDetail");
				urlList.VisitData = context.StringValue("DescribeScdnDomainTopUrlVisit.Url400List["+ i +"].VisitData");
				urlList.VisitProportion = context.FloatValue("DescribeScdnDomainTopUrlVisit.Url400List["+ i +"].VisitProportion");
				urlList.Flow = context.StringValue("DescribeScdnDomainTopUrlVisit.Url400List["+ i +"].Flow");
				urlList.FlowProportion = context.FloatValue("DescribeScdnDomainTopUrlVisit.Url400List["+ i +"].FlowProportion");

				describeScdnDomainTopUrlVisitResponse_url400List.Add(urlList);
			}
			describeScdnDomainTopUrlVisitResponse.Url400List = describeScdnDomainTopUrlVisitResponse_url400List;

			List<DescribeScdnDomainTopUrlVisitResponse.DescribeScdnDomainTopUrlVisit_UrlList> describeScdnDomainTopUrlVisitResponse_url500List = new List<DescribeScdnDomainTopUrlVisitResponse.DescribeScdnDomainTopUrlVisit_UrlList>();
			for (int i = 0; i < context.Length("DescribeScdnDomainTopUrlVisit.Url500List.Length"); i++) {
				DescribeScdnDomainTopUrlVisitResponse.DescribeScdnDomainTopUrlVisit_UrlList urlList = new DescribeScdnDomainTopUrlVisitResponse.DescribeScdnDomainTopUrlVisit_UrlList();
				urlList.UrlDetail = context.StringValue("DescribeScdnDomainTopUrlVisit.Url500List["+ i +"].UrlDetail");
				urlList.VisitData = context.StringValue("DescribeScdnDomainTopUrlVisit.Url500List["+ i +"].VisitData");
				urlList.VisitProportion = context.FloatValue("DescribeScdnDomainTopUrlVisit.Url500List["+ i +"].VisitProportion");
				urlList.Flow = context.StringValue("DescribeScdnDomainTopUrlVisit.Url500List["+ i +"].Flow");
				urlList.FlowProportion = context.FloatValue("DescribeScdnDomainTopUrlVisit.Url500List["+ i +"].FlowProportion");

				describeScdnDomainTopUrlVisitResponse_url500List.Add(urlList);
			}
			describeScdnDomainTopUrlVisitResponse.Url500List = describeScdnDomainTopUrlVisitResponse_url500List;
        
			return describeScdnDomainTopUrlVisitResponse;
        }
    }
}
