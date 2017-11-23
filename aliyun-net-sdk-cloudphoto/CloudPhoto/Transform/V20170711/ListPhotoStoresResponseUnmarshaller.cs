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
    public class ListPhotoStoresResponseUnmarshaller
    {
        public static ListPhotoStoresResponse Unmarshall(UnmarshallerContext context)
        {
			ListPhotoStoresResponse listPhotoStoresResponse = new ListPhotoStoresResponse();

			listPhotoStoresResponse.HttpResponse = context.HttpResponse;
			listPhotoStoresResponse.Code = context.StringValue("ListPhotoStores.Code");
			listPhotoStoresResponse.Message = context.StringValue("ListPhotoStores.Message");
			listPhotoStoresResponse.RequestId = context.StringValue("ListPhotoStores.RequestId");
			listPhotoStoresResponse.Action = context.StringValue("ListPhotoStores.Action");

			List<ListPhotoStoresResponse.ListPhotoStores_PhotoStore> listPhotoStoresResponse_photoStores = new List<ListPhotoStoresResponse.ListPhotoStores_PhotoStore>();
			for (int i = 0; i < context.Length("ListPhotoStores.PhotoStores.Length"); i++) {
				ListPhotoStoresResponse.ListPhotoStores_PhotoStore photoStore = new ListPhotoStoresResponse.ListPhotoStores_PhotoStore();
				photoStore.Id = context.LongValue("ListPhotoStores.PhotoStores["+ i +"].Id");
				photoStore.Name = context.StringValue("ListPhotoStores.PhotoStores["+ i +"].Name");
				photoStore.Remark = context.StringValue("ListPhotoStores.PhotoStores["+ i +"].Remark");
				photoStore.AutoCleanEnabled = context.BooleanValue("ListPhotoStores.PhotoStores["+ i +"].AutoCleanEnabled");
				photoStore.AutoCleanDays = context.IntegerValue("ListPhotoStores.PhotoStores["+ i +"].AutoCleanDays");
				photoStore.DefaultQuota = context.LongValue("ListPhotoStores.PhotoStores["+ i +"].DefaultQuota");
				photoStore.Ctime = context.LongValue("ListPhotoStores.PhotoStores["+ i +"].Ctime");
				photoStore.Mtime = context.LongValue("ListPhotoStores.PhotoStores["+ i +"].Mtime");

				List<ListPhotoStoresResponse.ListPhotoStores_PhotoStore.ListPhotoStores_Bucket> photoStore_buckets = new List<ListPhotoStoresResponse.ListPhotoStores_PhotoStore.ListPhotoStores_Bucket>();
				for (int j = 0; j < context.Length("ListPhotoStores.PhotoStores["+ i +"].Buckets.Length"); j++) {
					ListPhotoStoresResponse.ListPhotoStores_PhotoStore.ListPhotoStores_Bucket bucket = new ListPhotoStoresResponse.ListPhotoStores_PhotoStore.ListPhotoStores_Bucket();
					bucket.Name = context.StringValue("ListPhotoStores.PhotoStores["+ i +"].Buckets["+ j +"].Name");
					bucket.Region = context.StringValue("ListPhotoStores.PhotoStores["+ i +"].Buckets["+ j +"].Region");
					bucket.State = context.StringValue("ListPhotoStores.PhotoStores["+ i +"].Buckets["+ j +"].State");

					photoStore_buckets.Add(bucket);
				}
				photoStore.Buckets = photoStore_buckets;

				listPhotoStoresResponse_photoStores.Add(photoStore);
			}
			listPhotoStoresResponse.PhotoStores = listPhotoStoresResponse_photoStores;
        
			return listPhotoStoresResponse;
        }
    }
}