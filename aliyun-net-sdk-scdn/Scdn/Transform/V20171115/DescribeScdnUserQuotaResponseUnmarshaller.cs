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
using Aliyun.Acs.scdn.Model.V20171115;

namespace Aliyun.Acs.scdn.Transform.V20171115
{
    public class DescribeScdnUserQuotaResponseUnmarshaller
    {
        public static DescribeScdnUserQuotaResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeScdnUserQuotaResponse describeScdnUserQuotaResponse = new DescribeScdnUserQuotaResponse();

			describeScdnUserQuotaResponse.HttpResponse = _ctx.HttpResponse;
			describeScdnUserQuotaResponse.RequestId = _ctx.StringValue("DescribeScdnUserQuota.RequestId");
			describeScdnUserQuotaResponse.DomainQuota = _ctx.IntegerValue("DescribeScdnUserQuota.DomainQuota");
			describeScdnUserQuotaResponse.RefreshUrlQuota = _ctx.IntegerValue("DescribeScdnUserQuota.RefreshUrlQuota");
			describeScdnUserQuotaResponse.RefreshDirQuota = _ctx.IntegerValue("DescribeScdnUserQuota.RefreshDirQuota");
			describeScdnUserQuotaResponse.RefreshUrlRemain = _ctx.IntegerValue("DescribeScdnUserQuota.RefreshUrlRemain");
			describeScdnUserQuotaResponse.RefreshDirRemain = _ctx.IntegerValue("DescribeScdnUserQuota.RefreshDirRemain");
			describeScdnUserQuotaResponse.PreloadQuota = _ctx.IntegerValue("DescribeScdnUserQuota.PreloadQuota");
			describeScdnUserQuotaResponse.PreloadRemain = _ctx.IntegerValue("DescribeScdnUserQuota.PreloadRemain");
			describeScdnUserQuotaResponse.BlockQuota = _ctx.IntegerValue("DescribeScdnUserQuota.BlockQuota");
			describeScdnUserQuotaResponse.BlockRemain = _ctx.IntegerValue("DescribeScdnUserQuota.BlockRemain");
        
			return describeScdnUserQuotaResponse;
        }
    }
}
