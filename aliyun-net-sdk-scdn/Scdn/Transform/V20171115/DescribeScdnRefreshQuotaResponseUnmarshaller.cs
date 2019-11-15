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
    public class DescribeScdnRefreshQuotaResponseUnmarshaller
    {
        public static DescribeScdnRefreshQuotaResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeScdnRefreshQuotaResponse describeScdnRefreshQuotaResponse = new DescribeScdnRefreshQuotaResponse();

			describeScdnRefreshQuotaResponse.HttpResponse = context.HttpResponse;
			describeScdnRefreshQuotaResponse.RequestId = context.StringValue("DescribeScdnRefreshQuota.RequestId");
			describeScdnRefreshQuotaResponse.UrlQuota = context.StringValue("DescribeScdnRefreshQuota.UrlQuota");
			describeScdnRefreshQuotaResponse.DirQuota = context.StringValue("DescribeScdnRefreshQuota.DirQuota");
			describeScdnRefreshQuotaResponse.UrlRemain = context.StringValue("DescribeScdnRefreshQuota.UrlRemain");
			describeScdnRefreshQuotaResponse.DirRemain = context.StringValue("DescribeScdnRefreshQuota.DirRemain");
			describeScdnRefreshQuotaResponse.PreloadQuota = context.StringValue("DescribeScdnRefreshQuota.PreloadQuota");
			describeScdnRefreshQuotaResponse.BlockQuota = context.StringValue("DescribeScdnRefreshQuota.BlockQuota");
			describeScdnRefreshQuotaResponse.PreloadRemain = context.StringValue("DescribeScdnRefreshQuota.PreloadRemain");
			describeScdnRefreshQuotaResponse.BlockRemain = context.StringValue("DescribeScdnRefreshQuota.blockRemain");
        
			return describeScdnRefreshQuotaResponse;
        }
    }
}
