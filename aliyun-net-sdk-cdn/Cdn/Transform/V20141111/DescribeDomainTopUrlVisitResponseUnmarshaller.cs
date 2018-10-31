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
    public class DescribeDomainTopUrlVisitResponseUnmarshaller
    {
        public static DescribeDomainTopUrlVisitResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDomainTopUrlVisitResponse describeDomainTopUrlVisitResponse = new DescribeDomainTopUrlVisitResponse();

			describeDomainTopUrlVisitResponse.HttpResponse = context.HttpResponse;
			describeDomainTopUrlVisitResponse.RequestId = context.StringValue("DescribeDomainTopUrlVisit.RequestId");
			describeDomainTopUrlVisitResponse.DomainName = context.StringValue("DescribeDomainTopUrlVisit.DomainName");
			describeDomainTopUrlVisitResponse.StartTime = context.StringValue("DescribeDomainTopUrlVisit.StartTime");

			List<DescribeDomainTopUrlVisitResponse.DescribeDomainTopUrlVisit_UrlList> describeDomainTopUrlVisitResponse_allUrlList = new List<DescribeDomainTopUrlVisitResponse.DescribeDomainTopUrlVisit_UrlList>();
			for (int i = 0; i < context.Length("DescribeDomainTopUrlVisit.AllUrlList.Length"); i++) {
				DescribeDomainTopUrlVisitResponse.DescribeDomainTopUrlVisit_UrlList urlList = new DescribeDomainTopUrlVisitResponse.DescribeDomainTopUrlVisit_UrlList();
				urlList.UrlDetail = context.StringValue("DescribeDomainTopUrlVisit.AllUrlList["+ i +"].UrlDetail");
				urlList.VisitData = context.StringValue("DescribeDomainTopUrlVisit.AllUrlList["+ i +"].VisitData");
				urlList.VisitProportion = context.FloatValue("DescribeDomainTopUrlVisit.AllUrlList["+ i +"].VisitProportion");
				urlList.Flow = context.StringValue("DescribeDomainTopUrlVisit.AllUrlList["+ i +"].Flow");
				urlList.FlowProportion = context.FloatValue("DescribeDomainTopUrlVisit.AllUrlList["+ i +"].FlowProportion");

				describeDomainTopUrlVisitResponse_allUrlList.Add(urlList);
			}
			describeDomainTopUrlVisitResponse.AllUrlList = describeDomainTopUrlVisitResponse_allUrlList;

			List<DescribeDomainTopUrlVisitResponse.DescribeDomainTopUrlVisit_UrlList> describeDomainTopUrlVisitResponse_url200List = new List<DescribeDomainTopUrlVisitResponse.DescribeDomainTopUrlVisit_UrlList>();
			for (int i = 0; i < context.Length("DescribeDomainTopUrlVisit.Url200List.Length"); i++) {
				DescribeDomainTopUrlVisitResponse.DescribeDomainTopUrlVisit_UrlList urlList = new DescribeDomainTopUrlVisitResponse.DescribeDomainTopUrlVisit_UrlList();
				urlList.UrlDetail = context.StringValue("DescribeDomainTopUrlVisit.Url200List["+ i +"].UrlDetail");
				urlList.VisitData = context.StringValue("DescribeDomainTopUrlVisit.Url200List["+ i +"].VisitData");
				urlList.VisitProportion = context.FloatValue("DescribeDomainTopUrlVisit.Url200List["+ i +"].VisitProportion");
				urlList.Flow = context.StringValue("DescribeDomainTopUrlVisit.Url200List["+ i +"].Flow");
				urlList.FlowProportion = context.FloatValue("DescribeDomainTopUrlVisit.Url200List["+ i +"].FlowProportion");

				describeDomainTopUrlVisitResponse_url200List.Add(urlList);
			}
			describeDomainTopUrlVisitResponse.Url200List = describeDomainTopUrlVisitResponse_url200List;

			List<DescribeDomainTopUrlVisitResponse.DescribeDomainTopUrlVisit_UrlList> describeDomainTopUrlVisitResponse_url300List = new List<DescribeDomainTopUrlVisitResponse.DescribeDomainTopUrlVisit_UrlList>();
			for (int i = 0; i < context.Length("DescribeDomainTopUrlVisit.Url300List.Length"); i++) {
				DescribeDomainTopUrlVisitResponse.DescribeDomainTopUrlVisit_UrlList urlList = new DescribeDomainTopUrlVisitResponse.DescribeDomainTopUrlVisit_UrlList();
				urlList.UrlDetail = context.StringValue("DescribeDomainTopUrlVisit.Url300List["+ i +"].UrlDetail");
				urlList.VisitData = context.StringValue("DescribeDomainTopUrlVisit.Url300List["+ i +"].VisitData");
				urlList.VisitProportion = context.FloatValue("DescribeDomainTopUrlVisit.Url300List["+ i +"].VisitProportion");
				urlList.Flow = context.StringValue("DescribeDomainTopUrlVisit.Url300List["+ i +"].Flow");
				urlList.FlowProportion = context.FloatValue("DescribeDomainTopUrlVisit.Url300List["+ i +"].FlowProportion");

				describeDomainTopUrlVisitResponse_url300List.Add(urlList);
			}
			describeDomainTopUrlVisitResponse.Url300List = describeDomainTopUrlVisitResponse_url300List;

			List<DescribeDomainTopUrlVisitResponse.DescribeDomainTopUrlVisit_UrlList> describeDomainTopUrlVisitResponse_url400List = new List<DescribeDomainTopUrlVisitResponse.DescribeDomainTopUrlVisit_UrlList>();
			for (int i = 0; i < context.Length("DescribeDomainTopUrlVisit.Url400List.Length"); i++) {
				DescribeDomainTopUrlVisitResponse.DescribeDomainTopUrlVisit_UrlList urlList = new DescribeDomainTopUrlVisitResponse.DescribeDomainTopUrlVisit_UrlList();
				urlList.UrlDetail = context.StringValue("DescribeDomainTopUrlVisit.Url400List["+ i +"].UrlDetail");
				urlList.VisitData = context.StringValue("DescribeDomainTopUrlVisit.Url400List["+ i +"].VisitData");
				urlList.VisitProportion = context.FloatValue("DescribeDomainTopUrlVisit.Url400List["+ i +"].VisitProportion");
				urlList.Flow = context.StringValue("DescribeDomainTopUrlVisit.Url400List["+ i +"].Flow");
				urlList.FlowProportion = context.FloatValue("DescribeDomainTopUrlVisit.Url400List["+ i +"].FlowProportion");

				describeDomainTopUrlVisitResponse_url400List.Add(urlList);
			}
			describeDomainTopUrlVisitResponse.Url400List = describeDomainTopUrlVisitResponse_url400List;

			List<DescribeDomainTopUrlVisitResponse.DescribeDomainTopUrlVisit_UrlList> describeDomainTopUrlVisitResponse_url500List = new List<DescribeDomainTopUrlVisitResponse.DescribeDomainTopUrlVisit_UrlList>();
			for (int i = 0; i < context.Length("DescribeDomainTopUrlVisit.Url500List.Length"); i++) {
				DescribeDomainTopUrlVisitResponse.DescribeDomainTopUrlVisit_UrlList urlList = new DescribeDomainTopUrlVisitResponse.DescribeDomainTopUrlVisit_UrlList();
				urlList.UrlDetail = context.StringValue("DescribeDomainTopUrlVisit.Url500List["+ i +"].UrlDetail");
				urlList.VisitData = context.StringValue("DescribeDomainTopUrlVisit.Url500List["+ i +"].VisitData");
				urlList.VisitProportion = context.FloatValue("DescribeDomainTopUrlVisit.Url500List["+ i +"].VisitProportion");
				urlList.Flow = context.StringValue("DescribeDomainTopUrlVisit.Url500List["+ i +"].Flow");
				urlList.FlowProportion = context.FloatValue("DescribeDomainTopUrlVisit.Url500List["+ i +"].FlowProportion");

				describeDomainTopUrlVisitResponse_url500List.Add(urlList);
			}
			describeDomainTopUrlVisitResponse.Url500List = describeDomainTopUrlVisitResponse_url500List;
        
			return describeDomainTopUrlVisitResponse;
        }
    }
}