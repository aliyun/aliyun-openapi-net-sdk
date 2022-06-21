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
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeMixStreamListResponseUnmarshaller
    {
        public static DescribeMixStreamListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeMixStreamListResponse describeMixStreamListResponse = new DescribeMixStreamListResponse();

			describeMixStreamListResponse.HttpResponse = _ctx.HttpResponse;
			describeMixStreamListResponse.RequestId = _ctx.StringValue("DescribeMixStreamList.RequestId");
			describeMixStreamListResponse.Total = _ctx.IntegerValue("DescribeMixStreamList.Total");

			List<DescribeMixStreamListResponse.DescribeMixStreamList_MixStreamInfo> describeMixStreamListResponse_mixStreamList = new List<DescribeMixStreamListResponse.DescribeMixStreamList_MixStreamInfo>();
			for (int i = 0; i < _ctx.Length("DescribeMixStreamList.MixStreamList.Length"); i++) {
				DescribeMixStreamListResponse.DescribeMixStreamList_MixStreamInfo mixStreamInfo = new DescribeMixStreamListResponse.DescribeMixStreamList_MixStreamInfo();
				mixStreamInfo.MixstreamId = _ctx.StringValue("DescribeMixStreamList.MixStreamList["+ i +"].MixstreamId");
				mixStreamInfo.DomainName = _ctx.StringValue("DescribeMixStreamList.MixStreamList["+ i +"].DomainName");
				mixStreamInfo.AppName = _ctx.StringValue("DescribeMixStreamList.MixStreamList["+ i +"].AppName");
				mixStreamInfo.StreamName = _ctx.StringValue("DescribeMixStreamList.MixStreamList["+ i +"].StreamName");
				mixStreamInfo.LayoutId = _ctx.StringValue("DescribeMixStreamList.MixStreamList["+ i +"].LayoutId");
				mixStreamInfo.InputStreamNumber = _ctx.IntegerValue("DescribeMixStreamList.MixStreamList["+ i +"].InputStreamNumber");
				mixStreamInfo.MixStreamTemplate = _ctx.StringValue("DescribeMixStreamList.MixStreamList["+ i +"].MixStreamTemplate");
				mixStreamInfo.GmtCreate = _ctx.StringValue("DescribeMixStreamList.MixStreamList["+ i +"].GmtCreate");
				mixStreamInfo.GmtModified = _ctx.StringValue("DescribeMixStreamList.MixStreamList["+ i +"].GmtModified");

				describeMixStreamListResponse_mixStreamList.Add(mixStreamInfo);
			}
			describeMixStreamListResponse.MixStreamList = describeMixStreamListResponse_mixStreamList;
        
			return describeMixStreamListResponse;
        }
    }
}
