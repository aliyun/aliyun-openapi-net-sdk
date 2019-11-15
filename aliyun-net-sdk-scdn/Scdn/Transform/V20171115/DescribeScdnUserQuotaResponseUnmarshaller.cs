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
        public static DescribeScdnUserQuotaResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeScdnUserQuotaResponse describeScdnUserQuotaResponse = new DescribeScdnUserQuotaResponse();

			describeScdnUserQuotaResponse.HttpResponse = context.HttpResponse;
			describeScdnUserQuotaResponse.RequestId = context.StringValue("DescribeScdnUserQuota.RequestId");
			describeScdnUserQuotaResponse.DomainQuota = context.IntegerValue("DescribeScdnUserQuota.DomainQuota");
			describeScdnUserQuotaResponse.RefreshUrlQuota = context.IntegerValue("DescribeScdnUserQuota.RefreshUrlQuota");
			describeScdnUserQuotaResponse.RefreshDirQuota = context.IntegerValue("DescribeScdnUserQuota.RefreshDirQuota");
			describeScdnUserQuotaResponse.RefreshUrlRemain = context.IntegerValue("DescribeScdnUserQuota.RefreshUrlRemain");
			describeScdnUserQuotaResponse.RefreshDirRemain = context.IntegerValue("DescribeScdnUserQuota.RefreshDirRemain");
			describeScdnUserQuotaResponse.PreloadQuota = context.IntegerValue("DescribeScdnUserQuota.PreloadQuota");
			describeScdnUserQuotaResponse.PreloadRemain = context.IntegerValue("DescribeScdnUserQuota.PreloadRemain");
			describeScdnUserQuotaResponse.BlockQuota = context.IntegerValue("DescribeScdnUserQuota.BlockQuota");
			describeScdnUserQuotaResponse.BlockRemain = context.IntegerValue("DescribeScdnUserQuota.BlockRemain");
        
			return describeScdnUserQuotaResponse;
        }
    }
}
