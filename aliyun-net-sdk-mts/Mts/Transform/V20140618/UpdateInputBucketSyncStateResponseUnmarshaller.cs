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
    public class UpdateInputBucketSyncStateResponseUnmarshaller
    {
        public static UpdateInputBucketSyncStateResponse Unmarshall(UnmarshallerContext context)
        {
			UpdateInputBucketSyncStateResponse updateInputBucketSyncStateResponse = new UpdateInputBucketSyncStateResponse();

			updateInputBucketSyncStateResponse.HttpResponse = context.HttpResponse;
			updateInputBucketSyncStateResponse.RequestId = context.StringValue("UpdateInputBucketSyncState.RequestId");

			UpdateInputBucketSyncStateResponse.MediaBucket_ mediaBucket = new UpdateInputBucketSyncStateResponse.MediaBucket_();
			mediaBucket.Bucket = context.StringValue("UpdateInputBucketSyncState.MediaBucket.Bucket");
			mediaBucket.Type = context.StringValue("UpdateInputBucketSyncState.MediaBucket.Type");
			mediaBucket.Sync = context.BooleanValue("UpdateInputBucketSyncState.MediaBucket.Sync");
			updateInputBucketSyncStateResponse.MediaBucket = mediaBucket;
        
			return updateInputBucketSyncStateResponse;
        }
    }
}