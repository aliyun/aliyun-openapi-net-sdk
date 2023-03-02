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
using Aliyun.Acs.lto.Model.V20210707;

namespace Aliyun.Acs.lto.Transform.V20210707
{
    public class DescribeMemberStatInfoResponseUnmarshaller
    {
        public static DescribeMemberStatInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeMemberStatInfoResponse describeMemberStatInfoResponse = new DescribeMemberStatInfoResponse();

			describeMemberStatInfoResponse.HttpResponse = _ctx.HttpResponse;
			describeMemberStatInfoResponse.Code = _ctx.StringValue("DescribeMemberStatInfo.Code");
			describeMemberStatInfoResponse.HttpStatusCode = _ctx.IntegerValue("DescribeMemberStatInfo.HttpStatusCode");
			describeMemberStatInfoResponse.Message = _ctx.StringValue("DescribeMemberStatInfo.Message");
			describeMemberStatInfoResponse.RequestId = _ctx.StringValue("DescribeMemberStatInfo.RequestId");
			describeMemberStatInfoResponse.Success = _ctx.BooleanValue("DescribeMemberStatInfo.Success");

			List<DescribeMemberStatInfoResponse.DescribeMemberStatInfo_MemberStatInfo> describeMemberStatInfoResponse_data = new List<DescribeMemberStatInfoResponse.DescribeMemberStatInfo_MemberStatInfo>();
			for (int i = 0; i < _ctx.Length("DescribeMemberStatInfo.Data.Length"); i++) {
				DescribeMemberStatInfoResponse.DescribeMemberStatInfo_MemberStatInfo memberStatInfo = new DescribeMemberStatInfoResponse.DescribeMemberStatInfo_MemberStatInfo();
				memberStatInfo.AuthorizedCount = _ctx.LongValue("DescribeMemberStatInfo.Data["+ i +"].AuthorizedCount");
				memberStatInfo.MemberId = _ctx.StringValue("DescribeMemberStatInfo.Data["+ i +"].MemberId");
				memberStatInfo.MemberName = _ctx.StringValue("DescribeMemberStatInfo.Data["+ i +"].MemberName");
				memberStatInfo.UsedCount = _ctx.LongValue("DescribeMemberStatInfo.Data["+ i +"].UsedCount");
				memberStatInfo.BizChainCount = _ctx.IntegerValue("DescribeMemberStatInfo.Data["+ i +"].BizChainCount");

				describeMemberStatInfoResponse_data.Add(memberStatInfo);
			}
			describeMemberStatInfoResponse.Data = describeMemberStatInfoResponse_data;
        
			return describeMemberStatInfoResponse;
        }
    }
}
