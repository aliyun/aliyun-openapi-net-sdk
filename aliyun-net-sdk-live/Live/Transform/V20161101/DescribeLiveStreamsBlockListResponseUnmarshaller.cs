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
    public class DescribeLiveStreamsBlockListResponseUnmarshaller
    {
        public static DescribeLiveStreamsBlockListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveStreamsBlockListResponse describeLiveStreamsBlockListResponse = new DescribeLiveStreamsBlockListResponse();

			describeLiveStreamsBlockListResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveStreamsBlockListResponse.RequestId = _ctx.StringValue("DescribeLiveStreamsBlockList.RequestId");
			describeLiveStreamsBlockListResponse.DomainName = _ctx.StringValue("DescribeLiveStreamsBlockList.DomainName");
			describeLiveStreamsBlockListResponse.PageNum = _ctx.IntegerValue("DescribeLiveStreamsBlockList.PageNum");
			describeLiveStreamsBlockListResponse.PageSize = _ctx.IntegerValue("DescribeLiveStreamsBlockList.PageSize");
			describeLiveStreamsBlockListResponse.TotalNum = _ctx.IntegerValue("DescribeLiveStreamsBlockList.TotalNum");
			describeLiveStreamsBlockListResponse.TotalPage = _ctx.IntegerValue("DescribeLiveStreamsBlockList.TotalPage");

			List<string> describeLiveStreamsBlockListResponse_streamUrls = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeLiveStreamsBlockList.StreamUrls.Length"); i++) {
				describeLiveStreamsBlockListResponse_streamUrls.Add(_ctx.StringValue("DescribeLiveStreamsBlockList.StreamUrls["+ i +"]"));
			}
			describeLiveStreamsBlockListResponse.StreamUrls = describeLiveStreamsBlockListResponse_streamUrls;
        
			return describeLiveStreamsBlockListResponse;
        }
    }
}
