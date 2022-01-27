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
using Aliyun.Acs.vs.Model.V20181212;

namespace Aliyun.Acs.vs.Transform.V20181212
{
    public class ListBucketsResponseUnmarshaller
    {
        public static ListBucketsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListBucketsResponse listBucketsResponse = new ListBucketsResponse();

			listBucketsResponse.HttpResponse = _ctx.HttpResponse;
			listBucketsResponse.RequestId = _ctx.StringValue("ListBuckets.RequestId");
			listBucketsResponse.TotalCount = _ctx.LongValue("ListBuckets.TotalCount");

			List<ListBucketsResponse.ListBuckets_BucketInfo> listBucketsResponse_bucketInfos = new List<ListBucketsResponse.ListBuckets_BucketInfo>();
			for (int i = 0; i < _ctx.Length("ListBuckets.BucketInfos.Length"); i++) {
				ListBucketsResponse.ListBuckets_BucketInfo bucketInfo = new ListBucketsResponse.ListBuckets_BucketInfo();
				bucketInfo.BucketName = _ctx.StringValue("ListBuckets.BucketInfos["+ i +"].BucketName");
				bucketInfo.Comment = _ctx.StringValue("ListBuckets.BucketInfos["+ i +"].Comment");
				bucketInfo.BucketAcl = _ctx.StringValue("ListBuckets.BucketInfos["+ i +"].BucketAcl");
				bucketInfo.DataRedundancyType = _ctx.StringValue("ListBuckets.BucketInfos["+ i +"].DataRedundancyType");
				bucketInfo.StorageClass = _ctx.StringValue("ListBuckets.BucketInfos["+ i +"].StorageClass");
				bucketInfo.DispatcherType = _ctx.StringValue("ListBuckets.BucketInfos["+ i +"].DispatcherType");
				bucketInfo.ResourceType = _ctx.StringValue("ListBuckets.BucketInfos["+ i +"].ResourceType");
				bucketInfo.CreateTime = _ctx.StringValue("ListBuckets.BucketInfos["+ i +"].CreateTime");
				bucketInfo.ModifyTime = _ctx.StringValue("ListBuckets.BucketInfos["+ i +"].ModifyTime");
				bucketInfo.Endpoint = _ctx.StringValue("ListBuckets.BucketInfos["+ i +"].Endpoint");

				listBucketsResponse_bucketInfos.Add(bucketInfo);
			}
			listBucketsResponse.BucketInfos = listBucketsResponse_bucketInfos;
        
			return listBucketsResponse;
        }
    }
}
