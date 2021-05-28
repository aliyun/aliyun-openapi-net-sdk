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
        public static DescribeGatewayCachesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeGatewayCachesResponse describeGatewayCachesResponse = new DescribeGatewayCachesResponse();

			describeGatewayCachesResponse.HttpResponse = _ctx.HttpResponse;
			describeGatewayCachesResponse.RequestId = _ctx.StringValue("DescribeGatewayCaches.RequestId");
			describeGatewayCachesResponse.Success = _ctx.BooleanValue("DescribeGatewayCaches.Success");
			describeGatewayCachesResponse.Code = _ctx.StringValue("DescribeGatewayCaches.Code");
			describeGatewayCachesResponse.Message = _ctx.StringValue("DescribeGatewayCaches.Message");

			List<DescribeGatewayCachesResponse.DescribeGatewayCaches_Cache> describeGatewayCachesResponse_caches = new List<DescribeGatewayCachesResponse.DescribeGatewayCaches_Cache>();
			for (int i = 0; i < _ctx.Length("DescribeGatewayCaches.Caches.Length"); i++) {
				DescribeGatewayCachesResponse.DescribeGatewayCaches_Cache cache = new DescribeGatewayCachesResponse.DescribeGatewayCaches_Cache();
				cache.SizeInGB = _ctx.LongValue("DescribeGatewayCaches.Caches["+ i +"].SizeInGB");
				cache.Iops = _ctx.LongValue("DescribeGatewayCaches.Caches["+ i +"].Iops");
				cache.CacheId = _ctx.StringValue("DescribeGatewayCaches.Caches["+ i +"].CacheId");
				cache.CacheType = _ctx.StringValue("DescribeGatewayCaches.Caches["+ i +"].CacheType");
				cache.IsUsed = _ctx.BooleanValue("DescribeGatewayCaches.Caches["+ i +"].IsUsed");
				cache.LocalFilePath = _ctx.StringValue("DescribeGatewayCaches.Caches["+ i +"].LocalFilePath");
				cache.RenewURL = _ctx.StringValue("DescribeGatewayCaches.Caches["+ i +"].RenewURL");
				cache.ExpiredTime = _ctx.LongValue("DescribeGatewayCaches.Caches["+ i +"].ExpiredTime");
				cache.ExpireStatus = _ctx.IntegerValue("DescribeGatewayCaches.Caches["+ i +"].ExpireStatus");
				cache.PerformanceLevel = _ctx.StringValue("DescribeGatewayCaches.Caches["+ i +"].PerformanceLevel");
				cache.BuyURL = _ctx.StringValue("DescribeGatewayCaches.Caches["+ i +"].BuyURL");
				cache.SubscriptionInstanceId = _ctx.StringValue("DescribeGatewayCaches.Caches["+ i +"].SubscriptionInstanceId");

				describeGatewayCachesResponse_caches.Add(cache);
			}
			describeGatewayCachesResponse.Caches = describeGatewayCachesResponse_caches;
        
			return describeGatewayCachesResponse;
        }
    }
}
