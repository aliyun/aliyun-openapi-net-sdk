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
using Aliyun.Acs.Rds.Model.V20140815;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class QueryOssBucketsResponseUnmarshaller
    {
        public static QueryOssBucketsResponse Unmarshall(UnmarshallerContext context)
        {
			QueryOssBucketsResponse queryOssBucketsResponse = new QueryOssBucketsResponse();

			queryOssBucketsResponse.HttpResponse = context.HttpResponse;
			queryOssBucketsResponse.RequestId = context.StringValue("QueryOssBuckets.RequestId");

			List<QueryOssBucketsResponse.QueryOssBuckets_BucketItem> queryOssBucketsResponse_bucket = new List<QueryOssBucketsResponse.QueryOssBuckets_BucketItem>();
			for (int i = 0; i < context.Length("QueryOssBuckets.Bucket.Length"); i++) {
				QueryOssBucketsResponse.QueryOssBuckets_BucketItem bucketItem = new QueryOssBucketsResponse.QueryOssBuckets_BucketItem();
				bucketItem.Name = context.StringValue("QueryOssBuckets.Bucket["+ i +"].Name");
				bucketItem.Location = context.StringValue("QueryOssBuckets.Bucket["+ i +"].Location");
				bucketItem.StorageClass = context.StringValue("QueryOssBuckets.Bucket["+ i +"].StorageClass");
				bucketItem.ExtranetEndpoint = context.LongValue("QueryOssBuckets.Bucket["+ i +"].ExtranetEndpoint");
				bucketItem.IntranetEndpoint = context.LongValue("QueryOssBuckets.Bucket["+ i +"].IntranetEndpoint");
				bucketItem.CreationDate = context.StringValue("QueryOssBuckets.Bucket["+ i +"].CreationDate");

				QueryOssBucketsResponse.QueryOssBuckets_BucketItem.QueryOssBuckets_Owner owner = new QueryOssBucketsResponse.QueryOssBuckets_BucketItem.QueryOssBuckets_Owner();
				owner.DisplayName = context.StringValue("QueryOssBuckets.Bucket["+ i +"].Owner.DisplayName");
				owner.Id = context.StringValue("QueryOssBuckets.Bucket["+ i +"].Owner.Id");
				bucketItem.Owner = owner;

				queryOssBucketsResponse_bucket.Add(bucketItem);
			}
			queryOssBucketsResponse.Bucket = queryOssBucketsResponse_bucket;
        
			return queryOssBucketsResponse;
        }
    }
}