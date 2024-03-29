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
using Aliyun.Acs.sgw.Model.V20180511;

namespace Aliyun.Acs.sgw.Transform.V20180511
{
    public class DescribeGatewayBucketCachesResponseUnmarshaller
    {
        public static DescribeGatewayBucketCachesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeGatewayBucketCachesResponse describeGatewayBucketCachesResponse = new DescribeGatewayBucketCachesResponse();

			describeGatewayBucketCachesResponse.HttpResponse = _ctx.HttpResponse;
			describeGatewayBucketCachesResponse.TotalCount = _ctx.IntegerValue("DescribeGatewayBucketCaches.TotalCount");
			describeGatewayBucketCachesResponse.RequestId = _ctx.StringValue("DescribeGatewayBucketCaches.RequestId");
			describeGatewayBucketCachesResponse.Message = _ctx.StringValue("DescribeGatewayBucketCaches.Message");
			describeGatewayBucketCachesResponse.PageSize = _ctx.IntegerValue("DescribeGatewayBucketCaches.PageSize");
			describeGatewayBucketCachesResponse.PageNumber = _ctx.IntegerValue("DescribeGatewayBucketCaches.PageNumber");
			describeGatewayBucketCachesResponse.Code = _ctx.StringValue("DescribeGatewayBucketCaches.Code");
			describeGatewayBucketCachesResponse.Success = _ctx.BooleanValue("DescribeGatewayBucketCaches.Success");

			List<DescribeGatewayBucketCachesResponse.DescribeGatewayBucketCaches_BucketCache> describeGatewayBucketCachesResponse_bucketCaches = new List<DescribeGatewayBucketCachesResponse.DescribeGatewayBucketCaches_BucketCache>();
			for (int i = 0; i < _ctx.Length("DescribeGatewayBucketCaches.BucketCaches.Length"); i++) {
				DescribeGatewayBucketCachesResponse.DescribeGatewayBucketCaches_BucketCache bucketCache = new DescribeGatewayBucketCachesResponse.DescribeGatewayBucketCaches_BucketCache();
				bucketCache.VpcId = _ctx.StringValue("DescribeGatewayBucketCaches.BucketCaches["+ i +"].VpcId");
				bucketCache.Type = _ctx.StringValue("DescribeGatewayBucketCaches.BucketCaches["+ i +"].Type");
				bucketCache.MountPoint = _ctx.StringValue("DescribeGatewayBucketCaches.BucketCaches["+ i +"].MountPoint");
				bucketCache.GatewayId = _ctx.StringValue("DescribeGatewayBucketCaches.BucketCaches["+ i +"].GatewayId");
				bucketCache.CacheMode = _ctx.StringValue("DescribeGatewayBucketCaches.BucketCaches["+ i +"].CacheMode");
				bucketCache.Protocol = _ctx.StringValue("DescribeGatewayBucketCaches.BucketCaches["+ i +"].Protocol");
				bucketCache.GatewayName = _ctx.StringValue("DescribeGatewayBucketCaches.BucketCaches["+ i +"].GatewayName");
				bucketCache.CacheStats = _ctx.StringValue("DescribeGatewayBucketCaches.BucketCaches["+ i +"].CacheStats");
				bucketCache.ShareName = _ctx.StringValue("DescribeGatewayBucketCaches.BucketCaches["+ i +"].ShareName");
				bucketCache.RegionId = _ctx.StringValue("DescribeGatewayBucketCaches.BucketCaches["+ i +"].RegionId");
				bucketCache.VpcCidr = _ctx.StringValue("DescribeGatewayBucketCaches.BucketCaches["+ i +"].VpcCidr");
				bucketCache.BucketName = _ctx.StringValue("DescribeGatewayBucketCaches.BucketCaches["+ i +"].BucketName");
				bucketCache.Category = _ctx.StringValue("DescribeGatewayBucketCaches.BucketCaches["+ i +"].Category");
				bucketCache.Location = _ctx.StringValue("DescribeGatewayBucketCaches.BucketCaches["+ i +"].Location");

				describeGatewayBucketCachesResponse_bucketCaches.Add(bucketCache);
			}
			describeGatewayBucketCachesResponse.BucketCaches = describeGatewayBucketCachesResponse_bucketCaches;
        
			return describeGatewayBucketCachesResponse;
        }
    }
}
