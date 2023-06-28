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
    public class DescribeMemberBizChainStatInfoResponseUnmarshaller
    {
        public static DescribeMemberBizChainStatInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeMemberBizChainStatInfoResponse describeMemberBizChainStatInfoResponse = new DescribeMemberBizChainStatInfoResponse();

			describeMemberBizChainStatInfoResponse.HttpResponse = _ctx.HttpResponse;
			describeMemberBizChainStatInfoResponse.Code = _ctx.StringValue("DescribeMemberBizChainStatInfo.Code");
			describeMemberBizChainStatInfoResponse.HttpStatusCode = _ctx.IntegerValue("DescribeMemberBizChainStatInfo.HttpStatusCode");
			describeMemberBizChainStatInfoResponse.Message = _ctx.StringValue("DescribeMemberBizChainStatInfo.Message");
			describeMemberBizChainStatInfoResponse.RequestId = _ctx.StringValue("DescribeMemberBizChainStatInfo.RequestId");
			describeMemberBizChainStatInfoResponse.Success = _ctx.BooleanValue("DescribeMemberBizChainStatInfo.Success");

			List<DescribeMemberBizChainStatInfoResponse.DescribeMemberBizChainStatInfo_MemberBizChainStatInfo> describeMemberBizChainStatInfoResponse_data = new List<DescribeMemberBizChainStatInfoResponse.DescribeMemberBizChainStatInfo_MemberBizChainStatInfo>();
			for (int i = 0; i < _ctx.Length("DescribeMemberBizChainStatInfo.Data.Length"); i++) {
				DescribeMemberBizChainStatInfoResponse.DescribeMemberBizChainStatInfo_MemberBizChainStatInfo memberBizChainStatInfo = new DescribeMemberBizChainStatInfoResponse.DescribeMemberBizChainStatInfo_MemberBizChainStatInfo();
				memberBizChainStatInfo.UsedCount = _ctx.LongValue("DescribeMemberBizChainStatInfo.Data["+ i +"].UsedCount");
				memberBizChainStatInfo.BizChainName = _ctx.StringValue("DescribeMemberBizChainStatInfo.Data["+ i +"].BizChainName");

				describeMemberBizChainStatInfoResponse_data.Add(memberBizChainStatInfo);
			}
			describeMemberBizChainStatInfoResponse.Data = describeMemberBizChainStatInfoResponse_data;
        
			return describeMemberBizChainStatInfoResponse;
        }
    }
}
