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
using Aliyun.Acs.dcdn.Model.V20180115;

namespace Aliyun.Acs.dcdn.Transform.V20180115
{
    public class DescribeDcdnRefreshQuotaResponseUnmarshaller
    {
        public static DescribeDcdnRefreshQuotaResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDcdnRefreshQuotaResponse describeDcdnRefreshQuotaResponse = new DescribeDcdnRefreshQuotaResponse();

			describeDcdnRefreshQuotaResponse.HttpResponse = _ctx.HttpResponse;
			describeDcdnRefreshQuotaResponse.RequestId = _ctx.StringValue("DescribeDcdnRefreshQuota.RequestId");
			describeDcdnRefreshQuotaResponse.UrlQuota = _ctx.StringValue("DescribeDcdnRefreshQuota.UrlQuota");
			describeDcdnRefreshQuotaResponse.DirQuota = _ctx.StringValue("DescribeDcdnRefreshQuota.DirQuota");
			describeDcdnRefreshQuotaResponse.UrlRemain = _ctx.StringValue("DescribeDcdnRefreshQuota.UrlRemain");
			describeDcdnRefreshQuotaResponse.DirRemain = _ctx.StringValue("DescribeDcdnRefreshQuota.DirRemain");
			describeDcdnRefreshQuotaResponse.PreloadQuota = _ctx.StringValue("DescribeDcdnRefreshQuota.PreloadQuota");
			describeDcdnRefreshQuotaResponse.BlockQuota = _ctx.StringValue("DescribeDcdnRefreshQuota.BlockQuota");
			describeDcdnRefreshQuotaResponse.PreloadRemain = _ctx.StringValue("DescribeDcdnRefreshQuota.PreloadRemain");
			describeDcdnRefreshQuotaResponse.BlockRemain = _ctx.StringValue("DescribeDcdnRefreshQuota.BlockRemain");
			describeDcdnRefreshQuotaResponse.RegexQuota = _ctx.StringValue("DescribeDcdnRefreshQuota.RegexQuota");
			describeDcdnRefreshQuotaResponse.RegexRemain = _ctx.StringValue("DescribeDcdnRefreshQuota.RegexRemain");
        
			return describeDcdnRefreshQuotaResponse;
        }
    }
}
