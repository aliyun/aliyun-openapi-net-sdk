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
using Aliyun.Acs.Mts.Model.V20140618;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Mts.Transform.V20140618
{
    public class ListAllMediaBucketResponseUnmarshaller
    {
        public static ListAllMediaBucketResponse Unmarshall(UnmarshallerContext context)
        {
			ListAllMediaBucketResponse listAllMediaBucketResponse = new ListAllMediaBucketResponse();

			listAllMediaBucketResponse.HttpResponse = context.HttpResponse;
			listAllMediaBucketResponse.RequestId = context.StringValue("ListAllMediaBucket.RequestId");

			List<ListAllMediaBucketResponse.MediaBucket> mediaBucketList = new List<ListAllMediaBucketResponse.MediaBucket>();
			for (int i = 0; i < context.Length("ListAllMediaBucket.MediaBucketList.Length"); i++) {
				ListAllMediaBucketResponse.MediaBucket mediaBucket = new ListAllMediaBucketResponse.MediaBucket();
				mediaBucket.Bucket = context.StringValue("ListAllMediaBucket.MediaBucketList["+ i +"].Bucket");
				mediaBucket.Type = context.StringValue("ListAllMediaBucket.MediaBucketList["+ i +"].Type");

				mediaBucketList.Add(mediaBucket);
			}
			listAllMediaBucketResponse.MediaBucketList = mediaBucketList;
        
			return listAllMediaBucketResponse;
        }
    }
}