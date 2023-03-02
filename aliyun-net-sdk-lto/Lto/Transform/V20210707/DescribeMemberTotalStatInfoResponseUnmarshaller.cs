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
    public class DescribeMemberTotalStatInfoResponseUnmarshaller
    {
        public static DescribeMemberTotalStatInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeMemberTotalStatInfoResponse describeMemberTotalStatInfoResponse = new DescribeMemberTotalStatInfoResponse();

			describeMemberTotalStatInfoResponse.HttpResponse = _ctx.HttpResponse;
			describeMemberTotalStatInfoResponse.Code = _ctx.StringValue("DescribeMemberTotalStatInfo.Code");
			describeMemberTotalStatInfoResponse.HttpStatusCode = _ctx.IntegerValue("DescribeMemberTotalStatInfo.HttpStatusCode");
			describeMemberTotalStatInfoResponse.Message = _ctx.StringValue("DescribeMemberTotalStatInfo.Message");
			describeMemberTotalStatInfoResponse.RequestId = _ctx.StringValue("DescribeMemberTotalStatInfo.RequestId");
			describeMemberTotalStatInfoResponse.Success = _ctx.BooleanValue("DescribeMemberTotalStatInfo.Success");

			DescribeMemberTotalStatInfoResponse.DescribeMemberTotalStatInfo_Data data = new DescribeMemberTotalStatInfoResponse.DescribeMemberTotalStatInfo_Data();
			data.AuthorizedCount = _ctx.LongValue("DescribeMemberTotalStatInfo.Data.AuthorizedCount");
			data.UsedCount = _ctx.LongValue("DescribeMemberTotalStatInfo.Data.UsedCount");
			describeMemberTotalStatInfoResponse.Data = data;
        
			return describeMemberTotalStatInfoResponse;
        }
    }
}
