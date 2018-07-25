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
using Aliyun.Acs.imm.Model.V20170906;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.imm.Transform.V20170906
{
    public class ListTagPhotosResponseUnmarshaller
    {
        public static ListTagPhotosResponse Unmarshall(UnmarshallerContext context)
        {
			ListTagPhotosResponse listTagPhotosResponse = new ListTagPhotosResponse();

			listTagPhotosResponse.HttpResponse = context.HttpResponse;
			listTagPhotosResponse.RequestId = context.StringValue("ListTagPhotos.RequestId");
			listTagPhotosResponse.NextMarker = context.StringValue("ListTagPhotos.NextMarker");

			List<ListTagPhotosResponse.ListTagPhotos_PhotosItem> listTagPhotosResponse_photos = new List<ListTagPhotosResponse.ListTagPhotos_PhotosItem>();
			for (int i = 0; i < context.Length("ListTagPhotos.Photos.Length"); i++) {
				ListTagPhotosResponse.ListTagPhotos_PhotosItem photosItem = new ListTagPhotosResponse.ListTagPhotos_PhotosItem();
				photosItem.SrcUri = context.StringValue("ListTagPhotos.Photos["+ i +"].SrcUri");
				photosItem.TagScore = context.FloatValue("ListTagPhotos.Photos["+ i +"].TagScore");

				listTagPhotosResponse_photos.Add(photosItem);
			}
			listTagPhotosResponse.Photos = listTagPhotosResponse_photos;
        
			return listTagPhotosResponse;
        }
    }
}