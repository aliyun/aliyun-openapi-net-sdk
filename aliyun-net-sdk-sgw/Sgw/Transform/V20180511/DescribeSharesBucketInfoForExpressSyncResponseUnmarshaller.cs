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
    public class DescribeSharesBucketInfoForExpressSyncResponseUnmarshaller
    {
        public static DescribeSharesBucketInfoForExpressSyncResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSharesBucketInfoForExpressSyncResponse describeSharesBucketInfoForExpressSyncResponse = new DescribeSharesBucketInfoForExpressSyncResponse();

			describeSharesBucketInfoForExpressSyncResponse.HttpResponse = context.HttpResponse;
			describeSharesBucketInfoForExpressSyncResponse.RequestId = context.StringValue("DescribeSharesBucketInfoForExpressSync.RequestId");
			describeSharesBucketInfoForExpressSyncResponse.Success = context.BooleanValue("DescribeSharesBucketInfoForExpressSync.Success");
			describeSharesBucketInfoForExpressSyncResponse.Code = context.StringValue("DescribeSharesBucketInfoForExpressSync.Code");
			describeSharesBucketInfoForExpressSyncResponse.Message = context.StringValue("DescribeSharesBucketInfoForExpressSync.Message");

			List<DescribeSharesBucketInfoForExpressSyncResponse.DescribeSharesBucketInfoForExpressSync_BucketInfo> describeSharesBucketInfoForExpressSyncResponse_bucketInfos = new List<DescribeSharesBucketInfoForExpressSyncResponse.DescribeSharesBucketInfoForExpressSync_BucketInfo>();
			for (int i = 0; i < context.Length("DescribeSharesBucketInfoForExpressSync.BucketInfos.Length"); i++) {
				DescribeSharesBucketInfoForExpressSyncResponse.DescribeSharesBucketInfoForExpressSync_BucketInfo bucketInfo = new DescribeSharesBucketInfoForExpressSyncResponse.DescribeSharesBucketInfoForExpressSync_BucketInfo();
				bucketInfo.BucketRegion = context.StringValue("DescribeSharesBucketInfoForExpressSync.BucketInfos["+ i +"].BucketRegion");
				bucketInfo.BucketName = context.StringValue("DescribeSharesBucketInfoForExpressSync.BucketInfos["+ i +"].BucketName");
				bucketInfo.BucketPrefix = context.StringValue("DescribeSharesBucketInfoForExpressSync.BucketInfos["+ i +"].BucketPrefix");

				describeSharesBucketInfoForExpressSyncResponse_bucketInfos.Add(bucketInfo);
			}
			describeSharesBucketInfoForExpressSyncResponse.BucketInfos = describeSharesBucketInfoForExpressSyncResponse_bucketInfos;
        
			return describeSharesBucketInfoForExpressSyncResponse;
        }
    }
}
