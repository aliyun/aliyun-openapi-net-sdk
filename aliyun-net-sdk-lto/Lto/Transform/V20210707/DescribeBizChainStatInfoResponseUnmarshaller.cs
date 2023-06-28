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
    public class DescribeBizChainStatInfoResponseUnmarshaller
    {
        public static DescribeBizChainStatInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeBizChainStatInfoResponse describeBizChainStatInfoResponse = new DescribeBizChainStatInfoResponse();

			describeBizChainStatInfoResponse.HttpResponse = _ctx.HttpResponse;
			describeBizChainStatInfoResponse.Code = _ctx.StringValue("DescribeBizChainStatInfo.Code");
			describeBizChainStatInfoResponse.HttpStatusCode = _ctx.IntegerValue("DescribeBizChainStatInfo.HttpStatusCode");
			describeBizChainStatInfoResponse.Message = _ctx.StringValue("DescribeBizChainStatInfo.Message");
			describeBizChainStatInfoResponse.RequestId = _ctx.StringValue("DescribeBizChainStatInfo.RequestId");
			describeBizChainStatInfoResponse.Success = _ctx.BooleanValue("DescribeBizChainStatInfo.Success");

			List<DescribeBizChainStatInfoResponse.DescribeBizChainStatInfo_BizChainStatInfo> describeBizChainStatInfoResponse_data = new List<DescribeBizChainStatInfoResponse.DescribeBizChainStatInfo_BizChainStatInfo>();
			for (int i = 0; i < _ctx.Length("DescribeBizChainStatInfo.Data.Length"); i++) {
				DescribeBizChainStatInfoResponse.DescribeBizChainStatInfo_BizChainStatInfo bizChainStatInfo = new DescribeBizChainStatInfoResponse.DescribeBizChainStatInfo_BizChainStatInfo();
				bizChainStatInfo.UsedCount = _ctx.LongValue("DescribeBizChainStatInfo.Data["+ i +"].UsedCount");
				bizChainStatInfo.BizChainName = _ctx.StringValue("DescribeBizChainStatInfo.Data["+ i +"].BizChainName");

				describeBizChainStatInfoResponse_data.Add(bizChainStatInfo);
			}
			describeBizChainStatInfoResponse.Data = describeBizChainStatInfoResponse_data;
        
			return describeBizChainStatInfoResponse;
        }
    }
}
