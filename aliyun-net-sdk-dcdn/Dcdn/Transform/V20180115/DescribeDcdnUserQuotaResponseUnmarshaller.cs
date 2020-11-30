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
    public class DescribeDcdnUserQuotaResponseUnmarshaller
    {
        public static DescribeDcdnUserQuotaResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDcdnUserQuotaResponse describeDcdnUserQuotaResponse = new DescribeDcdnUserQuotaResponse();

			describeDcdnUserQuotaResponse.HttpResponse = _ctx.HttpResponse;
			describeDcdnUserQuotaResponse.RequestId = _ctx.StringValue("DescribeDcdnUserQuota.RequestId");
			describeDcdnUserQuotaResponse.DomainQuota = _ctx.IntegerValue("DescribeDcdnUserQuota.DomainQuota");
			describeDcdnUserQuotaResponse.RefreshUrlQuota = _ctx.IntegerValue("DescribeDcdnUserQuota.RefreshUrlQuota");
			describeDcdnUserQuotaResponse.RefreshDirQuota = _ctx.IntegerValue("DescribeDcdnUserQuota.RefreshDirQuota");
			describeDcdnUserQuotaResponse.RefreshUrlRemain = _ctx.IntegerValue("DescribeDcdnUserQuota.RefreshUrlRemain");
			describeDcdnUserQuotaResponse.RefreshDirRemain = _ctx.IntegerValue("DescribeDcdnUserQuota.RefreshDirRemain");
			describeDcdnUserQuotaResponse.PreloadQuota = _ctx.IntegerValue("DescribeDcdnUserQuota.PreloadQuota");
			describeDcdnUserQuotaResponse.PreloadRemain = _ctx.IntegerValue("DescribeDcdnUserQuota.PreloadRemain");
			describeDcdnUserQuotaResponse.BlockQuota = _ctx.IntegerValue("DescribeDcdnUserQuota.BlockQuota");
			describeDcdnUserQuotaResponse.BlockRemain = _ctx.IntegerValue("DescribeDcdnUserQuota.BlockRemain");
        
			return describeDcdnUserQuotaResponse;
        }
    }
}
