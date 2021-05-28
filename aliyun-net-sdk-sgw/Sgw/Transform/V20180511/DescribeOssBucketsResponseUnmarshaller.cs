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
    public class DescribeOssBucketsResponseUnmarshaller
    {
        public static DescribeOssBucketsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeOssBucketsResponse describeOssBucketsResponse = new DescribeOssBucketsResponse();

			describeOssBucketsResponse.HttpResponse = _ctx.HttpResponse;
			describeOssBucketsResponse.RequestId = _ctx.StringValue("DescribeOssBuckets.RequestId");
			describeOssBucketsResponse.Success = _ctx.BooleanValue("DescribeOssBuckets.Success");
			describeOssBucketsResponse.Code = _ctx.StringValue("DescribeOssBuckets.Code");
			describeOssBucketsResponse.Message = _ctx.StringValue("DescribeOssBuckets.Message");

			List<DescribeOssBucketsResponse.DescribeOssBuckets_Bucket> describeOssBucketsResponse_buckets = new List<DescribeOssBucketsResponse.DescribeOssBuckets_Bucket>();
			for (int i = 0; i < _ctx.Length("DescribeOssBuckets.Buckets.Length"); i++) {
				DescribeOssBucketsResponse.DescribeOssBuckets_Bucket bucket = new DescribeOssBucketsResponse.DescribeOssBuckets_Bucket();
				bucket.Name = _ctx.StringValue("DescribeOssBuckets.Buckets["+ i +"].Name");

				describeOssBucketsResponse_buckets.Add(bucket);
			}
			describeOssBucketsResponse.Buckets = describeOssBucketsResponse_buckets;
        
			return describeOssBucketsResponse;
        }
    }
}
