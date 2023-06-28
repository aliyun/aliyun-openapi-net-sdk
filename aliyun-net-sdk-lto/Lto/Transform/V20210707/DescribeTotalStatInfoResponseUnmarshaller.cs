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
    public class DescribeTotalStatInfoResponseUnmarshaller
    {
        public static DescribeTotalStatInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeTotalStatInfoResponse describeTotalStatInfoResponse = new DescribeTotalStatInfoResponse();

			describeTotalStatInfoResponse.HttpResponse = _ctx.HttpResponse;
			describeTotalStatInfoResponse.Code = _ctx.StringValue("DescribeTotalStatInfo.Code");
			describeTotalStatInfoResponse.HttpStatusCode = _ctx.IntegerValue("DescribeTotalStatInfo.HttpStatusCode");
			describeTotalStatInfoResponse.Message = _ctx.StringValue("DescribeTotalStatInfo.Message");
			describeTotalStatInfoResponse.RequestId = _ctx.StringValue("DescribeTotalStatInfo.RequestId");
			describeTotalStatInfoResponse.Success = _ctx.BooleanValue("DescribeTotalStatInfo.Success");

			DescribeTotalStatInfoResponse.DescribeTotalStatInfo_Data data = new DescribeTotalStatInfoResponse.DescribeTotalStatInfo_Data();
			data.AuthorizedCount = _ctx.LongValue("DescribeTotalStatInfo.Data.AuthorizedCount");
			data.TotalCount = _ctx.LongValue("DescribeTotalStatInfo.Data.TotalCount");
			data.UsedCount = _ctx.LongValue("DescribeTotalStatInfo.Data.UsedCount");
			describeTotalStatInfoResponse.Data = data;
        
			return describeTotalStatInfoResponse;
        }
    }
}
