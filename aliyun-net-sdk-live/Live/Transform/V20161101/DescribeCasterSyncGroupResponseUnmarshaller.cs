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
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeCasterSyncGroupResponseUnmarshaller
    {
        public static DescribeCasterSyncGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCasterSyncGroupResponse describeCasterSyncGroupResponse = new DescribeCasterSyncGroupResponse();

			describeCasterSyncGroupResponse.HttpResponse = _ctx.HttpResponse;
			describeCasterSyncGroupResponse.RequestId = _ctx.StringValue("DescribeCasterSyncGroup.RequestId");
			describeCasterSyncGroupResponse.CasterId = _ctx.StringValue("DescribeCasterSyncGroup.CasterId");

			List<DescribeCasterSyncGroupResponse.DescribeCasterSyncGroup_SyncGroup> describeCasterSyncGroupResponse_syncGroups = new List<DescribeCasterSyncGroupResponse.DescribeCasterSyncGroup_SyncGroup>();
			for (int i = 0; i < _ctx.Length("DescribeCasterSyncGroup.SyncGroups.Length"); i++) {
				DescribeCasterSyncGroupResponse.DescribeCasterSyncGroup_SyncGroup syncGroup = new DescribeCasterSyncGroupResponse.DescribeCasterSyncGroup_SyncGroup();
				syncGroup.Mode = _ctx.IntegerValue("DescribeCasterSyncGroup.SyncGroups["+ i +"].Mode");
				syncGroup.HostResourceId = _ctx.StringValue("DescribeCasterSyncGroup.SyncGroups["+ i +"].HostResourceId");

				List<string> syncGroup_resourceIds = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeCasterSyncGroup.SyncGroups["+ i +"].ResourceIds.Length"); j++) {
					syncGroup_resourceIds.Add(_ctx.StringValue("DescribeCasterSyncGroup.SyncGroups["+ i +"].ResourceIds["+ j +"]"));
				}
				syncGroup.ResourceIds = syncGroup_resourceIds;

				describeCasterSyncGroupResponse_syncGroups.Add(syncGroup);
			}
			describeCasterSyncGroupResponse.SyncGroups = describeCasterSyncGroupResponse_syncGroups;
        
			return describeCasterSyncGroupResponse;
        }
    }
}
