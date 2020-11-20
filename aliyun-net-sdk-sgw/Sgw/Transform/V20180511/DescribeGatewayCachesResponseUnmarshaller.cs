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
    public class DescribeGatewayCachesResponseUnmarshaller
    {
        public static DescribeGatewayCachesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeGatewayCachesResponse describeGatewayCachesResponse = new DescribeGatewayCachesResponse();

			describeGatewayCachesResponse.HttpResponse = context.HttpResponse;
			describeGatewayCachesResponse.RequestId = context.StringValue("DescribeGatewayCaches.RequestId");
			describeGatewayCachesResponse.Success = context.BooleanValue("DescribeGatewayCaches.Success");
			describeGatewayCachesResponse.Code = context.StringValue("DescribeGatewayCaches.Code");
			describeGatewayCachesResponse.Message = context.StringValue("DescribeGatewayCaches.Message");

			List<DescribeGatewayCachesResponse.DescribeGatewayCaches_Cache> describeGatewayCachesResponse_caches = new List<DescribeGatewayCachesResponse.DescribeGatewayCaches_Cache>();
			for (int i = 0; i < context.Length("DescribeGatewayCaches.Caches.Length"); i++) {
				DescribeGatewayCachesResponse.DescribeGatewayCaches_Cache cache = new DescribeGatewayCachesResponse.DescribeGatewayCaches_Cache();
				cache.SizeInGB = context.LongValue("DescribeGatewayCaches.Caches["+ i +"].SizeInGB");
				cache.Iops = context.LongValue("DescribeGatewayCaches.Caches["+ i +"].Iops");
				cache.CacheId = context.StringValue("DescribeGatewayCaches.Caches["+ i +"].CacheId");
				cache.CacheType = context.StringValue("DescribeGatewayCaches.Caches["+ i +"].CacheType");
				cache.IsUsed = context.BooleanValue("DescribeGatewayCaches.Caches["+ i +"].IsUsed");
				cache.LocalFilePath = context.StringValue("DescribeGatewayCaches.Caches["+ i +"].LocalFilePath");
				cache.RenewURL = context.StringValue("DescribeGatewayCaches.Caches["+ i +"].RenewURL");
				cache.ExpiredTime = context.LongValue("DescribeGatewayCaches.Caches["+ i +"].ExpiredTime");
				cache.ExpireStatus = context.IntegerValue("DescribeGatewayCaches.Caches["+ i +"].ExpireStatus");
				cache.PerformanceLevel = context.StringValue("DescribeGatewayCaches.Caches["+ i +"].PerformanceLevel");
				cache.BuyURL = context.StringValue("DescribeGatewayCaches.Caches["+ i +"].BuyURL");

				describeGatewayCachesResponse_caches.Add(cache);
			}
			describeGatewayCachesResponse.Caches = describeGatewayCachesResponse_caches;
        
			return describeGatewayCachesResponse;
        }
    }
}
