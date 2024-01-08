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
using Aliyun.Acs.ResourceSharing.Model.V20200110;

namespace Aliyun.Acs.ResourceSharing.Transform.V20200110
{
    public class ListSharedTargetsResponseUnmarshaller
    {
        public static ListSharedTargetsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListSharedTargetsResponse listSharedTargetsResponse = new ListSharedTargetsResponse();

			listSharedTargetsResponse.HttpResponse = _ctx.HttpResponse;
			listSharedTargetsResponse.NextToken = _ctx.StringValue("ListSharedTargets.NextToken");
			listSharedTargetsResponse.RequestId = _ctx.StringValue("ListSharedTargets.RequestId");

			List<ListSharedTargetsResponse.ListSharedTargets_SharedTarget> listSharedTargetsResponse_sharedTargets = new List<ListSharedTargetsResponse.ListSharedTargets_SharedTarget>();
			for (int i = 0; i < _ctx.Length("ListSharedTargets.SharedTargets.Length"); i++) {
				ListSharedTargetsResponse.ListSharedTargets_SharedTarget sharedTarget = new ListSharedTargetsResponse.ListSharedTargets_SharedTarget();
				sharedTarget.TargetId = _ctx.StringValue("ListSharedTargets.SharedTargets["+ i +"].TargetId");
				sharedTarget.UpdateTime = _ctx.StringValue("ListSharedTargets.SharedTargets["+ i +"].UpdateTime");
				sharedTarget.CreateTime = _ctx.StringValue("ListSharedTargets.SharedTargets["+ i +"].CreateTime");
				sharedTarget.ResourceShareId = _ctx.StringValue("ListSharedTargets.SharedTargets["+ i +"].ResourceShareId");
				sharedTarget.External = _ctx.BooleanValue("ListSharedTargets.SharedTargets["+ i +"].External");
				sharedTarget.TargetProperty = _ctx.StringValue("ListSharedTargets.SharedTargets["+ i +"].TargetProperty");

				listSharedTargetsResponse_sharedTargets.Add(sharedTarget);
			}
			listSharedTargetsResponse.SharedTargets = listSharedTargetsResponse_sharedTargets;
        
			return listSharedTargetsResponse;
        }
    }
}
