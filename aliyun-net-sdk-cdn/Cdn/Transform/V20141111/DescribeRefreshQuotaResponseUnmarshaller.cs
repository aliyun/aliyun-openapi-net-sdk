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
using Aliyun.Acs.Cdn.Model.V20141111;

namespace Aliyun.Acs.Cdn.Transform.V20141111
{
    public class DescribeRefreshQuotaResponseUnmarshaller
    {
        public static DescribeRefreshQuotaResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRefreshQuotaResponse describeRefreshQuotaResponse = new DescribeRefreshQuotaResponse();

			describeRefreshQuotaResponse.HttpResponse = _ctx.HttpResponse;
			describeRefreshQuotaResponse.RequestId = _ctx.StringValue("DescribeRefreshQuota.RequestId");
			describeRefreshQuotaResponse.UrlQuota = _ctx.StringValue("DescribeRefreshQuota.UrlQuota");
			describeRefreshQuotaResponse.DirQuota = _ctx.StringValue("DescribeRefreshQuota.DirQuota");
			describeRefreshQuotaResponse.UrlRemain = _ctx.StringValue("DescribeRefreshQuota.UrlRemain");
			describeRefreshQuotaResponse.DirRemain = _ctx.StringValue("DescribeRefreshQuota.DirRemain");
			describeRefreshQuotaResponse.PreloadQuota = _ctx.StringValue("DescribeRefreshQuota.PreloadQuota");
			describeRefreshQuotaResponse.BlockQuota = _ctx.StringValue("DescribeRefreshQuota.BlockQuota");
			describeRefreshQuotaResponse.PreloadRemain = _ctx.StringValue("DescribeRefreshQuota.PreloadRemain");
			describeRefreshQuotaResponse.BlockRemain = _ctx.StringValue("DescribeRefreshQuota.BlockRemain");
        
			return describeRefreshQuotaResponse;
        }
    }
}
