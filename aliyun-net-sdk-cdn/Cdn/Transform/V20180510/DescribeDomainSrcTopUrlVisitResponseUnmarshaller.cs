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
    public class DescribeDomainSrcTopUrlVisitResponseUnmarshaller
    {
        public static DescribeDomainSrcTopUrlVisitResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDomainSrcTopUrlVisitResponse describeDomainSrcTopUrlVisitResponse = new DescribeDomainSrcTopUrlVisitResponse();

			describeDomainSrcTopUrlVisitResponse.HttpResponse = _ctx.HttpResponse;
			describeDomainSrcTopUrlVisitResponse.RequestId = _ctx.StringValue("DescribeDomainSrcTopUrlVisit.RequestId");
			describeDomainSrcTopUrlVisitResponse.DomainName = _ctx.StringValue("DescribeDomainSrcTopUrlVisit.DomainName");
			describeDomainSrcTopUrlVisitResponse.StartTime = _ctx.StringValue("DescribeDomainSrcTopUrlVisit.StartTime");

			List<DescribeDomainSrcTopUrlVisitResponse.DescribeDomainSrcTopUrlVisit_UrlList> describeDomainSrcTopUrlVisitResponse_allUrlList = new List<DescribeDomainSrcTopUrlVisitResponse.DescribeDomainSrcTopUrlVisit_UrlList>();
			for (int i = 0; i < _ctx.Length("DescribeDomainSrcTopUrlVisit.AllUrlList.Length"); i++) {
				DescribeDomainSrcTopUrlVisitResponse.DescribeDomainSrcTopUrlVisit_UrlList urlList = new DescribeDomainSrcTopUrlVisitResponse.DescribeDomainSrcTopUrlVisit_UrlList();
				urlList.UrlDetail = _ctx.StringValue("DescribeDomainSrcTopUrlVisit.AllUrlList["+ i +"].UrlDetail");
				urlList.VisitData = _ctx.StringValue("DescribeDomainSrcTopUrlVisit.AllUrlList["+ i +"].VisitData");
				urlList.VisitProportion = _ctx.FloatValue("DescribeDomainSrcTopUrlVisit.AllUrlList["+ i +"].VisitProportion");
				urlList.Flow = _ctx.StringValue("DescribeDomainSrcTopUrlVisit.AllUrlList["+ i +"].Flow");
				urlList.FlowProportion = _ctx.FloatValue("DescribeDomainSrcTopUrlVisit.AllUrlList["+ i +"].FlowProportion");

				describeDomainSrcTopUrlVisitResponse_allUrlList.Add(urlList);
			}
			describeDomainSrcTopUrlVisitResponse.AllUrlList = describeDomainSrcTopUrlVisitResponse_allUrlList;

			List<DescribeDomainSrcTopUrlVisitResponse.DescribeDomainSrcTopUrlVisit_UrlList> describeDomainSrcTopUrlVisitResponse_url200List = new List<DescribeDomainSrcTopUrlVisitResponse.DescribeDomainSrcTopUrlVisit_UrlList>();
			for (int i = 0; i < _ctx.Length("DescribeDomainSrcTopUrlVisit.Url200List.Length"); i++) {
				DescribeDomainSrcTopUrlVisitResponse.DescribeDomainSrcTopUrlVisit_UrlList urlList = new DescribeDomainSrcTopUrlVisitResponse.DescribeDomainSrcTopUrlVisit_UrlList();
				urlList.UrlDetail = _ctx.StringValue("DescribeDomainSrcTopUrlVisit.Url200List["+ i +"].UrlDetail");
				urlList.VisitData = _ctx.StringValue("DescribeDomainSrcTopUrlVisit.Url200List["+ i +"].VisitData");
				urlList.VisitProportion = _ctx.FloatValue("DescribeDomainSrcTopUrlVisit.Url200List["+ i +"].VisitProportion");
				urlList.Flow = _ctx.StringValue("DescribeDomainSrcTopUrlVisit.Url200List["+ i +"].Flow");
				urlList.FlowProportion = _ctx.FloatValue("DescribeDomainSrcTopUrlVisit.Url200List["+ i +"].FlowProportion");

				describeDomainSrcTopUrlVisitResponse_url200List.Add(urlList);
			}
			describeDomainSrcTopUrlVisitResponse.Url200List = describeDomainSrcTopUrlVisitResponse_url200List;

			List<DescribeDomainSrcTopUrlVisitResponse.DescribeDomainSrcTopUrlVisit_UrlList> describeDomainSrcTopUrlVisitResponse_url300List = new List<DescribeDomainSrcTopUrlVisitResponse.DescribeDomainSrcTopUrlVisit_UrlList>();
			for (int i = 0; i < _ctx.Length("DescribeDomainSrcTopUrlVisit.Url300List.Length"); i++) {
				DescribeDomainSrcTopUrlVisitResponse.DescribeDomainSrcTopUrlVisit_UrlList urlList = new DescribeDomainSrcTopUrlVisitResponse.DescribeDomainSrcTopUrlVisit_UrlList();
				urlList.UrlDetail = _ctx.StringValue("DescribeDomainSrcTopUrlVisit.Url300List["+ i +"].UrlDetail");
				urlList.VisitData = _ctx.StringValue("DescribeDomainSrcTopUrlVisit.Url300List["+ i +"].VisitData");
				urlList.VisitProportion = _ctx.FloatValue("DescribeDomainSrcTopUrlVisit.Url300List["+ i +"].VisitProportion");
				urlList.Flow = _ctx.StringValue("DescribeDomainSrcTopUrlVisit.Url300List["+ i +"].Flow");
				urlList.FlowProportion = _ctx.FloatValue("DescribeDomainSrcTopUrlVisit.Url300List["+ i +"].FlowProportion");

				describeDomainSrcTopUrlVisitResponse_url300List.Add(urlList);
			}
			describeDomainSrcTopUrlVisitResponse.Url300List = describeDomainSrcTopUrlVisitResponse_url300List;

			List<DescribeDomainSrcTopUrlVisitResponse.DescribeDomainSrcTopUrlVisit_UrlList> describeDomainSrcTopUrlVisitResponse_url400List = new List<DescribeDomainSrcTopUrlVisitResponse.DescribeDomainSrcTopUrlVisit_UrlList>();
			for (int i = 0; i < _ctx.Length("DescribeDomainSrcTopUrlVisit.Url400List.Length"); i++) {
				DescribeDomainSrcTopUrlVisitResponse.DescribeDomainSrcTopUrlVisit_UrlList urlList = new DescribeDomainSrcTopUrlVisitResponse.DescribeDomainSrcTopUrlVisit_UrlList();
				urlList.UrlDetail = _ctx.StringValue("DescribeDomainSrcTopUrlVisit.Url400List["+ i +"].UrlDetail");
				urlList.VisitData = _ctx.StringValue("DescribeDomainSrcTopUrlVisit.Url400List["+ i +"].VisitData");
				urlList.VisitProportion = _ctx.FloatValue("DescribeDomainSrcTopUrlVisit.Url400List["+ i +"].VisitProportion");
				urlList.Flow = _ctx.StringValue("DescribeDomainSrcTopUrlVisit.Url400List["+ i +"].Flow");
				urlList.FlowProportion = _ctx.FloatValue("DescribeDomainSrcTopUrlVisit.Url400List["+ i +"].FlowProportion");

				describeDomainSrcTopUrlVisitResponse_url400List.Add(urlList);
			}
			describeDomainSrcTopUrlVisitResponse.Url400List = describeDomainSrcTopUrlVisitResponse_url400List;

			List<DescribeDomainSrcTopUrlVisitResponse.DescribeDomainSrcTopUrlVisit_UrlList> describeDomainSrcTopUrlVisitResponse_url500List = new List<DescribeDomainSrcTopUrlVisitResponse.DescribeDomainSrcTopUrlVisit_UrlList>();
			for (int i = 0; i < _ctx.Length("DescribeDomainSrcTopUrlVisit.Url500List.Length"); i++) {
				DescribeDomainSrcTopUrlVisitResponse.DescribeDomainSrcTopUrlVisit_UrlList urlList = new DescribeDomainSrcTopUrlVisitResponse.DescribeDomainSrcTopUrlVisit_UrlList();
				urlList.UrlDetail = _ctx.StringValue("DescribeDomainSrcTopUrlVisit.Url500List["+ i +"].UrlDetail");
				urlList.VisitData = _ctx.StringValue("DescribeDomainSrcTopUrlVisit.Url500List["+ i +"].VisitData");
				urlList.VisitProportion = _ctx.FloatValue("DescribeDomainSrcTopUrlVisit.Url500List["+ i +"].VisitProportion");
				urlList.Flow = _ctx.StringValue("DescribeDomainSrcTopUrlVisit.Url500List["+ i +"].Flow");
				urlList.FlowProportion = _ctx.FloatValue("DescribeDomainSrcTopUrlVisit.Url500List["+ i +"].FlowProportion");

				describeDomainSrcTopUrlVisitResponse_url500List.Add(urlList);
			}
			describeDomainSrcTopUrlVisitResponse.Url500List = describeDomainSrcTopUrlVisitResponse_url500List;
        
			return describeDomainSrcTopUrlVisitResponse;
        }
    }
}
