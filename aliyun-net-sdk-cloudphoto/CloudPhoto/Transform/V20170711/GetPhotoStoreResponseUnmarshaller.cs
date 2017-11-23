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
using Aliyun.Acs.CloudPhoto.Model.V20170711;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.CloudPhoto.Transform.V20170711
{
    public class GetPhotoStoreResponseUnmarshaller
    {
        public static GetPhotoStoreResponse Unmarshall(UnmarshallerContext context)
        {
			GetPhotoStoreResponse getPhotoStoreResponse = new GetPhotoStoreResponse();

			getPhotoStoreResponse.HttpResponse = context.HttpResponse;
			getPhotoStoreResponse.Code = context.StringValue("GetPhotoStore.Code");
			getPhotoStoreResponse.Message = context.StringValue("GetPhotoStore.Message");
			getPhotoStoreResponse.RequestId = context.StringValue("GetPhotoStore.RequestId");
			getPhotoStoreResponse.Action = context.StringValue("GetPhotoStore.Action");

			GetPhotoStoreResponse.GetPhotoStore_PhotoStore photoStore = new GetPhotoStoreResponse.GetPhotoStore_PhotoStore();
			photoStore.Id = context.LongValue("GetPhotoStore.PhotoStore.Id");
			photoStore.Name = context.StringValue("GetPhotoStore.PhotoStore.Name");
			photoStore.Remark = context.StringValue("GetPhotoStore.PhotoStore.Remark");
			photoStore.AutoCleanEnabled = context.BooleanValue("GetPhotoStore.PhotoStore.AutoCleanEnabled");
			photoStore.AutoCleanDays = context.IntegerValue("GetPhotoStore.PhotoStore.AutoCleanDays");
			photoStore.DefaultQuota = context.LongValue("GetPhotoStore.PhotoStore.DefaultQuota");
			photoStore.Ctime = context.LongValue("GetPhotoStore.PhotoStore.Ctime");
			photoStore.Mtime = context.LongValue("GetPhotoStore.PhotoStore.Mtime");

			List<GetPhotoStoreResponse.GetPhotoStore_PhotoStore.GetPhotoStore_Bucket> photoStore_buckets = new List<GetPhotoStoreResponse.GetPhotoStore_PhotoStore.GetPhotoStore_Bucket>();
			for (int i = 0; i < context.Length("GetPhotoStore.PhotoStore.Buckets.Length"); i++) {
				GetPhotoStoreResponse.GetPhotoStore_PhotoStore.GetPhotoStore_Bucket bucket = new GetPhotoStoreResponse.GetPhotoStore_PhotoStore.GetPhotoStore_Bucket();
				bucket.Name = context.StringValue("GetPhotoStore.PhotoStore.Buckets["+ i +"].Name");
				bucket.Region = context.StringValue("GetPhotoStore.PhotoStore.Buckets["+ i +"].Region");
				bucket.State = context.StringValue("GetPhotoStore.PhotoStore.Buckets["+ i +"].State");
				bucket.Acl = context.StringValue("GetPhotoStore.PhotoStore.Buckets["+ i +"].Acl");

				photoStore_buckets.Add(bucket);
			}
			photoStore.Buckets = photoStore_buckets;
			getPhotoStoreResponse.PhotoStore = photoStore;
        
			return getPhotoStoreResponse;
        }
    }
}