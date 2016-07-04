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

			List<DescribeDomainTopUrlVisitResponse.UrlList> allUrlList = new List<DescribeDomainTopUrlVisitResponse.UrlList>();
			for (int i = 0; i < context.Length("DescribeDomainTopUrlVisit.AllUrlList.Length"); i++) {
				DescribeDomainTopUrlVisitResponse.UrlList urlList = new DescribeDomainTopUrlVisitResponse.UrlList();
				urlList.UrlDetail = context.StringValue("DescribeDomainTopUrlVisit.AllUrlList["+ i +"].UrlDetail");
				urlList.VisitData = context.StringValue("DescribeDomainTopUrlVisit.AllUrlList["+ i +"].VisitData");

				allUrlList.Add(urlList);
			}
			describeDomainTopUrlVisitResponse.AllUrlList = allUrlList;

			List<DescribeDomainTopUrlVisitResponse.UrlList> url200List = new List<DescribeDomainTopUrlVisitResponse.UrlList>();
			for (int i = 0; i < context.Length("DescribeDomainTopUrlVisit.Url200List.Length"); i++) {
				DescribeDomainTopUrlVisitResponse.UrlList urlList = new DescribeDomainTopUrlVisitResponse.UrlList();
				urlList.UrlDetail = context.StringValue("DescribeDomainTopUrlVisit.Url200List["+ i +"].UrlDetail");
				urlList.VisitData = context.StringValue("DescribeDomainTopUrlVisit.Url200List["+ i +"].VisitData");

				url200List.Add(urlList);
			}
			describeDomainTopUrlVisitResponse.Url200List = url200List;

			List<DescribeDomainTopUrlVisitResponse.UrlList> url300List = new List<DescribeDomainTopUrlVisitResponse.UrlList>();
			for (int i = 0; i < context.Length("DescribeDomainTopUrlVisit.Url300List.Length"); i++) {
				DescribeDomainTopUrlVisitResponse.UrlList urlList = new DescribeDomainTopUrlVisitResponse.UrlList();
				urlList.UrlDetail = context.StringValue("DescribeDomainTopUrlVisit.Url300List["+ i +"].UrlDetail");
				urlList.VisitData = context.StringValue("DescribeDomainTopUrlVisit.Url300List["+ i +"].VisitData");

				url300List.Add(urlList);
			}
			describeDomainTopUrlVisitResponse.Url300List = url300List;

			List<DescribeDomainTopUrlVisitResponse.UrlList> url400List = new List<DescribeDomainTopUrlVisitResponse.UrlList>();
			for (int i = 0; i < context.Length("DescribeDomainTopUrlVisit.Url400List.Length"); i++) {
				DescribeDomainTopUrlVisitResponse.UrlList urlList = new DescribeDomainTopUrlVisitResponse.UrlList();
				urlList.UrlDetail = context.StringValue("DescribeDomainTopUrlVisit.Url400List["+ i +"].UrlDetail");
				urlList.VisitData = context.StringValue("DescribeDomainTopUrlVisit.Url400List["+ i +"].VisitData");

				url400List.Add(urlList);
			}
			describeDomainTopUrlVisitResponse.Url400List = url400List;

			List<DescribeDomainTopUrlVisitResponse.UrlList> url500List = new List<DescribeDomainTopUrlVisitResponse.UrlList>();
			for (int i = 0; i < context.Length("DescribeDomainTopUrlVisit.Url500List.Length"); i++) {
				DescribeDomainTopUrlVisitResponse.UrlList urlList = new DescribeDomainTopUrlVisitResponse.UrlList();
				urlList.UrlDetail = context.StringValue("DescribeDomainTopUrlVisit.Url500List["+ i +"].UrlDetail");
				urlList.VisitData = context.StringValue("DescribeDomainTopUrlVisit.Url500List["+ i +"].VisitData");

				url500List.Add(urlList);
			}
			describeDomainTopUrlVisitResponse.Url500List = url500List;
        
			return describeDomainTopUrlVisitResponse;
        }
    }
}