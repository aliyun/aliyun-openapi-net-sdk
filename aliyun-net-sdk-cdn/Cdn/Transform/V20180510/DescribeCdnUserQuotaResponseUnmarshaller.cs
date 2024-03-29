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
using Aliyun.Acs.Cdn.Model.V20180510;

namespace Aliyun.Acs.Cdn.Transform.V20180510
{
    public class DescribeCdnUserQuotaResponseUnmarshaller
    {
        public static DescribeCdnUserQuotaResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCdnUserQuotaResponse describeCdnUserQuotaResponse = new DescribeCdnUserQuotaResponse();

			describeCdnUserQuotaResponse.HttpResponse = _ctx.HttpResponse;
			describeCdnUserQuotaResponse.BlockQuota = _ctx.IntegerValue("DescribeCdnUserQuota.BlockQuota");
			describeCdnUserQuotaResponse.RefreshUrlRemain = _ctx.IntegerValue("DescribeCdnUserQuota.RefreshUrlRemain");
			describeCdnUserQuotaResponse.DomainQuota = _ctx.IntegerValue("DescribeCdnUserQuota.DomainQuota");
			describeCdnUserQuotaResponse.BlockRemain = _ctx.IntegerValue("DescribeCdnUserQuota.BlockRemain");
			describeCdnUserQuotaResponse.PreloadRemain = _ctx.IntegerValue("DescribeCdnUserQuota.PreloadRemain");
			describeCdnUserQuotaResponse.RequestId = _ctx.StringValue("DescribeCdnUserQuota.RequestId");
			describeCdnUserQuotaResponse.RefreshUrlQuota = _ctx.IntegerValue("DescribeCdnUserQuota.RefreshUrlQuota");
			describeCdnUserQuotaResponse.PreloadQuota = _ctx.IntegerValue("DescribeCdnUserQuota.PreloadQuota");
			describeCdnUserQuotaResponse.RefreshDirQuota = _ctx.IntegerValue("DescribeCdnUserQuota.RefreshDirQuota");
			describeCdnUserQuotaResponse.RefreshDirRemain = _ctx.IntegerValue("DescribeCdnUserQuota.RefreshDirRemain");
        
			return describeCdnUserQuotaResponse;
        }
    }
}
