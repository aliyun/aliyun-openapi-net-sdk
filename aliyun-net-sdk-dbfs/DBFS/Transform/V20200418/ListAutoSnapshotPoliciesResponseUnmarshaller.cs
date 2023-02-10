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
using Aliyun.Acs.DBFS.Model.V20200418;

namespace Aliyun.Acs.DBFS.Transform.V20200418
{
    public class ListAutoSnapshotPoliciesResponseUnmarshaller
    {
        public static ListAutoSnapshotPoliciesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAutoSnapshotPoliciesResponse listAutoSnapshotPoliciesResponse = new ListAutoSnapshotPoliciesResponse();

			listAutoSnapshotPoliciesResponse.HttpResponse = _ctx.HttpResponse;
			listAutoSnapshotPoliciesResponse.PageNumber = _ctx.IntegerValue("ListAutoSnapshotPolicies.PageNumber");
			listAutoSnapshotPoliciesResponse.PageSize = _ctx.IntegerValue("ListAutoSnapshotPolicies.PageSize");
			listAutoSnapshotPoliciesResponse.TotalCount = _ctx.IntegerValue("ListAutoSnapshotPolicies.TotalCount");
			listAutoSnapshotPoliciesResponse.RequestId = _ctx.StringValue("ListAutoSnapshotPolicies.RequestId");

			List<ListAutoSnapshotPoliciesResponse.ListAutoSnapshotPolicies_SnapshotPoliciesItem> listAutoSnapshotPoliciesResponse_snapshotPolicies = new List<ListAutoSnapshotPoliciesResponse.ListAutoSnapshotPolicies_SnapshotPoliciesItem>();
			for (int i = 0; i < _ctx.Length("ListAutoSnapshotPolicies.SnapshotPolicies.Length"); i++) {
				ListAutoSnapshotPoliciesResponse.ListAutoSnapshotPolicies_SnapshotPoliciesItem snapshotPoliciesItem = new ListAutoSnapshotPoliciesResponse.ListAutoSnapshotPolicies_SnapshotPoliciesItem();
				snapshotPoliciesItem.PolicyId = _ctx.StringValue("ListAutoSnapshotPolicies.SnapshotPolicies["+ i +"].PolicyId");
				snapshotPoliciesItem.PolicyName = _ctx.StringValue("ListAutoSnapshotPolicies.SnapshotPolicies["+ i +"].PolicyName");
				snapshotPoliciesItem.AccountId = _ctx.StringValue("ListAutoSnapshotPolicies.SnapshotPolicies["+ i +"].AccountId");
				snapshotPoliciesItem.RegionId = _ctx.StringValue("ListAutoSnapshotPolicies.SnapshotPolicies["+ i +"].RegionId");
				snapshotPoliciesItem.Status = _ctx.StringValue("ListAutoSnapshotPolicies.SnapshotPolicies["+ i +"].Status");
				snapshotPoliciesItem.StatusDetail = _ctx.StringValue("ListAutoSnapshotPolicies.SnapshotPolicies["+ i +"].StatusDetail");
				snapshotPoliciesItem.RetentionDays = _ctx.IntegerValue("ListAutoSnapshotPolicies.SnapshotPolicies["+ i +"].RetentionDays");
				snapshotPoliciesItem.AppliedDbfsNumber = _ctx.IntegerValue("ListAutoSnapshotPolicies.SnapshotPolicies["+ i +"].AppliedDbfsNumber");
				snapshotPoliciesItem.CreatedTime = _ctx.StringValue("ListAutoSnapshotPolicies.SnapshotPolicies["+ i +"].CreatedTime");
				snapshotPoliciesItem.LastModified = _ctx.StringValue("ListAutoSnapshotPolicies.SnapshotPolicies["+ i +"].LastModified");

				List<string> snapshotPoliciesItem_repeatWeekdays = new List<string>();
				for (int j = 0; j < _ctx.Length("ListAutoSnapshotPolicies.SnapshotPolicies["+ i +"].RepeatWeekdays.Length"); j++) {
					snapshotPoliciesItem_repeatWeekdays.Add(_ctx.StringValue("ListAutoSnapshotPolicies.SnapshotPolicies["+ i +"].RepeatWeekdays["+ j +"]"));
				}
				snapshotPoliciesItem.RepeatWeekdays = snapshotPoliciesItem_repeatWeekdays;

				List<string> snapshotPoliciesItem_timePoints = new List<string>();
				for (int j = 0; j < _ctx.Length("ListAutoSnapshotPolicies.SnapshotPolicies["+ i +"].TimePoints.Length"); j++) {
					snapshotPoliciesItem_timePoints.Add(_ctx.StringValue("ListAutoSnapshotPolicies.SnapshotPolicies["+ i +"].TimePoints["+ j +"]"));
				}
				snapshotPoliciesItem.TimePoints = snapshotPoliciesItem_timePoints;

				listAutoSnapshotPoliciesResponse_snapshotPolicies.Add(snapshotPoliciesItem);
			}
			listAutoSnapshotPoliciesResponse.SnapshotPolicies = listAutoSnapshotPoliciesResponse_snapshotPolicies;
        
			return listAutoSnapshotPoliciesResponse;
        }
    }
}
