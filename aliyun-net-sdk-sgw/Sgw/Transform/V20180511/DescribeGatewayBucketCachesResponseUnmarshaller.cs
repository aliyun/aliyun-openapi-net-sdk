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
        public static DescribeGatewayBucketCachesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeGatewayBucketCachesResponse describeGatewayBucketCachesResponse = new DescribeGatewayBucketCachesResponse();

			describeGatewayBucketCachesResponse.HttpResponse = context.HttpResponse;
			describeGatewayBucketCachesResponse.RequestId = context.StringValue("DescribeGatewayBucketCaches.RequestId");
			describeGatewayBucketCachesResponse.Success = context.BooleanValue("DescribeGatewayBucketCaches.Success");
			describeGatewayBucketCachesResponse.Code = context.StringValue("DescribeGatewayBucketCaches.Code");
			describeGatewayBucketCachesResponse.Message = context.StringValue("DescribeGatewayBucketCaches.Message");
			describeGatewayBucketCachesResponse.TotalCount = context.IntegerValue("DescribeGatewayBucketCaches.TotalCount");
			describeGatewayBucketCachesResponse.PageNumber = context.IntegerValue("DescribeGatewayBucketCaches.PageNumber");
			describeGatewayBucketCachesResponse.PageSize = context.IntegerValue("DescribeGatewayBucketCaches.PageSize");

			List<DescribeGatewayBucketCachesResponse.DescribeGatewayBucketCaches_BucketCache> describeGatewayBucketCachesResponse_bucketCaches = new List<DescribeGatewayBucketCachesResponse.DescribeGatewayBucketCaches_BucketCache>();
			for (int i = 0; i < context.Length("DescribeGatewayBucketCaches.BucketCaches.Length"); i++) {
				DescribeGatewayBucketCachesResponse.DescribeGatewayBucketCaches_BucketCache bucketCache = new DescribeGatewayBucketCachesResponse.DescribeGatewayBucketCaches_BucketCache();
				bucketCache.GatewayId = context.StringValue("DescribeGatewayBucketCaches.BucketCaches["+ i +"].GatewayId");
				bucketCache.GatewayName = context.StringValue("DescribeGatewayBucketCaches.BucketCaches["+ i +"].GatewayName");
				bucketCache.RegionId = context.StringValue("DescribeGatewayBucketCaches.BucketCaches["+ i +"].RegionId");
				bucketCache.Location = context.StringValue("DescribeGatewayBucketCaches.BucketCaches["+ i +"].Location");
				bucketCache.Category = context.StringValue("DescribeGatewayBucketCaches.BucketCaches["+ i +"].Category");
				bucketCache.Type = context.StringValue("DescribeGatewayBucketCaches.BucketCaches["+ i +"].Type");
				bucketCache.BucketName = context.StringValue("DescribeGatewayBucketCaches.BucketCaches["+ i +"].BucketName");
				bucketCache.Protocol = context.StringValue("DescribeGatewayBucketCaches.BucketCaches["+ i +"].Protocol");
				bucketCache.CacheMode = context.StringValue("DescribeGatewayBucketCaches.BucketCaches["+ i +"].CacheMode");
				bucketCache.CacheStats = context.StringValue("DescribeGatewayBucketCaches.BucketCaches["+ i +"].CacheStats");
				bucketCache.ShareName = context.StringValue("DescribeGatewayBucketCaches.BucketCaches["+ i +"].ShareName");
				bucketCache.VpcId = context.StringValue("DescribeGatewayBucketCaches.BucketCaches["+ i +"].VpcId");
				bucketCache.VpcCidr = context.StringValue("DescribeGatewayBucketCaches.BucketCaches["+ i +"].VpcCidr");
				bucketCache.MountPoint = context.StringValue("DescribeGatewayBucketCaches.BucketCaches["+ i +"].MountPoint");

				describeGatewayBucketCachesResponse_bucketCaches.Add(bucketCache);
			}
			describeGatewayBucketCachesResponse.BucketCaches = describeGatewayBucketCachesResponse_bucketCaches;
        
			return describeGatewayBucketCachesResponse;
        }
    }
}
