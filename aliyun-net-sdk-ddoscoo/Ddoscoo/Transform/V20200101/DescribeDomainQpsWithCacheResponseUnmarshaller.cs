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
using Aliyun.Acs.ddoscoo.Model.V20200101;

namespace Aliyun.Acs.ddoscoo.Transform.V20200101
{
    public class DescribeDomainQpsWithCacheResponseUnmarshaller
    {
        public static DescribeDomainQpsWithCacheResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDomainQpsWithCacheResponse describeDomainQpsWithCacheResponse = new DescribeDomainQpsWithCacheResponse();

			describeDomainQpsWithCacheResponse.HttpResponse = _ctx.HttpResponse;
			describeDomainQpsWithCacheResponse.RequestId = _ctx.StringValue("DescribeDomainQpsWithCache.RequestId");
			describeDomainQpsWithCacheResponse.Interval = _ctx.IntegerValue("DescribeDomainQpsWithCache.Interval");
			describeDomainQpsWithCacheResponse.StartTime = _ctx.LongValue("DescribeDomainQpsWithCache.StartTime");

			List<string> describeDomainQpsWithCacheResponse_totals = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeDomainQpsWithCache.Totals.Length"); i++) {
				describeDomainQpsWithCacheResponse_totals.Add(_ctx.StringValue("DescribeDomainQpsWithCache.Totals["+ i +"]"));
			}
			describeDomainQpsWithCacheResponse.Totals = describeDomainQpsWithCacheResponse_totals;

			List<string> describeDomainQpsWithCacheResponse_blocks = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeDomainQpsWithCache.Blocks.Length"); i++) {
				describeDomainQpsWithCacheResponse_blocks.Add(_ctx.StringValue("DescribeDomainQpsWithCache.Blocks["+ i +"]"));
			}
			describeDomainQpsWithCacheResponse.Blocks = describeDomainQpsWithCacheResponse_blocks;

			List<string> describeDomainQpsWithCacheResponse_cacheHits = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeDomainQpsWithCache.CacheHits.Length"); i++) {
				describeDomainQpsWithCacheResponse_cacheHits.Add(_ctx.StringValue("DescribeDomainQpsWithCache.CacheHits["+ i +"]"));
			}
			describeDomainQpsWithCacheResponse.CacheHits = describeDomainQpsWithCacheResponse_cacheHits;

			List<string> describeDomainQpsWithCacheResponse_preciseBlocks = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeDomainQpsWithCache.PreciseBlocks.Length"); i++) {
				describeDomainQpsWithCacheResponse_preciseBlocks.Add(_ctx.StringValue("DescribeDomainQpsWithCache.PreciseBlocks["+ i +"]"));
			}
			describeDomainQpsWithCacheResponse.PreciseBlocks = describeDomainQpsWithCacheResponse_preciseBlocks;

			List<string> describeDomainQpsWithCacheResponse_regionBlocks = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeDomainQpsWithCache.RegionBlocks.Length"); i++) {
				describeDomainQpsWithCacheResponse_regionBlocks.Add(_ctx.StringValue("DescribeDomainQpsWithCache.RegionBlocks["+ i +"]"));
			}
			describeDomainQpsWithCacheResponse.RegionBlocks = describeDomainQpsWithCacheResponse_regionBlocks;

			List<string> describeDomainQpsWithCacheResponse_ipBlockQps = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeDomainQpsWithCache.IpBlockQps.Length"); i++) {
				describeDomainQpsWithCacheResponse_ipBlockQps.Add(_ctx.StringValue("DescribeDomainQpsWithCache.IpBlockQps["+ i +"]"));
			}
			describeDomainQpsWithCacheResponse.IpBlockQps = describeDomainQpsWithCacheResponse_ipBlockQps;

			List<string> describeDomainQpsWithCacheResponse_ccJsQps = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeDomainQpsWithCache.CcJsQps.Length"); i++) {
				describeDomainQpsWithCacheResponse_ccJsQps.Add(_ctx.StringValue("DescribeDomainQpsWithCache.CcJsQps["+ i +"]"));
			}
			describeDomainQpsWithCacheResponse.CcJsQps = describeDomainQpsWithCacheResponse_ccJsQps;

			List<string> describeDomainQpsWithCacheResponse_preciseJsQps = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeDomainQpsWithCache.PreciseJsQps.Length"); i++) {
				describeDomainQpsWithCacheResponse_preciseJsQps.Add(_ctx.StringValue("DescribeDomainQpsWithCache.PreciseJsQps["+ i +"]"));
			}
			describeDomainQpsWithCacheResponse.PreciseJsQps = describeDomainQpsWithCacheResponse_preciseJsQps;

			List<string> describeDomainQpsWithCacheResponse_ccBlockQps = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeDomainQpsWithCache.CcBlockQps.Length"); i++) {
				describeDomainQpsWithCacheResponse_ccBlockQps.Add(_ctx.StringValue("DescribeDomainQpsWithCache.CcBlockQps["+ i +"]"));
			}
			describeDomainQpsWithCacheResponse.CcBlockQps = describeDomainQpsWithCacheResponse_ccBlockQps;
        
			return describeDomainQpsWithCacheResponse;
        }
    }
}
