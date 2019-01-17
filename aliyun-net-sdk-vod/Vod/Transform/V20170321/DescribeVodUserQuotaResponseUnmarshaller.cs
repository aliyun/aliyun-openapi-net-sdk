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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.vod.Model.V20170321;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class DescribeVodUserQuotaResponseUnmarshaller
    {
        public static DescribeVodUserQuotaResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVodUserQuotaResponse describeVodUserQuotaResponse = new DescribeVodUserQuotaResponse();

			describeVodUserQuotaResponse.HttpResponse = context.HttpResponse;
			describeVodUserQuotaResponse.RequestId = context.StringValue("DescribeVodUserQuota.RequestId");
			describeVodUserQuotaResponse.DomainQuota = context.IntegerValue("DescribeVodUserQuota.DomainQuota");
			describeVodUserQuotaResponse.RefreshUrlQuota = context.IntegerValue("DescribeVodUserQuota.RefreshUrlQuota");
			describeVodUserQuotaResponse.RefreshDirQuota = context.IntegerValue("DescribeVodUserQuota.RefreshDirQuota");
			describeVodUserQuotaResponse.RefreshUrlRemain = context.IntegerValue("DescribeVodUserQuota.RefreshUrlRemain");
			describeVodUserQuotaResponse.RefreshDirRemain = context.IntegerValue("DescribeVodUserQuota.RefreshDirRemain");
			describeVodUserQuotaResponse.PreloadQuota = context.IntegerValue("DescribeVodUserQuota.PreloadQuota");
			describeVodUserQuotaResponse.PreloadRemain = context.IntegerValue("DescribeVodUserQuota.PreloadRemain");
			describeVodUserQuotaResponse.BlockQuota = context.IntegerValue("DescribeVodUserQuota.BlockQuota");
			describeVodUserQuotaResponse.BlockRemain = context.IntegerValue("DescribeVodUserQuota.BlockRemain");
        
			return describeVodUserQuotaResponse;
        }
    }
}