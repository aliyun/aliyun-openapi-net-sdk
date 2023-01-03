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
    public class GetAutoSnapshotPolicyResponseUnmarshaller
    {
        public static GetAutoSnapshotPolicyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetAutoSnapshotPolicyResponse getAutoSnapshotPolicyResponse = new GetAutoSnapshotPolicyResponse();

			getAutoSnapshotPolicyResponse.HttpResponse = _ctx.HttpResponse;
			getAutoSnapshotPolicyResponse.RequestId = _ctx.StringValue("GetAutoSnapshotPolicy.RequestId");

			GetAutoSnapshotPolicyResponse.GetAutoSnapshotPolicy_Data data = new GetAutoSnapshotPolicyResponse.GetAutoSnapshotPolicy_Data();
			data.PolicyId = _ctx.StringValue("GetAutoSnapshotPolicy.Data.PolicyId");
			data.PolicyName = _ctx.StringValue("GetAutoSnapshotPolicy.Data.PolicyName");
			data.AccountId = _ctx.StringValue("GetAutoSnapshotPolicy.Data.AccountId");
			data.RegionId = _ctx.StringValue("GetAutoSnapshotPolicy.Data.RegionId");
			data.Status = _ctx.StringValue("GetAutoSnapshotPolicy.Data.Status");
			data.StatusDetail = _ctx.StringValue("GetAutoSnapshotPolicy.Data.StatusDetail");
			data.RetentionDays = _ctx.IntegerValue("GetAutoSnapshotPolicy.Data.RetentionDays");
			data.AppliedDbfsNumber = _ctx.IntegerValue("GetAutoSnapshotPolicy.Data.AppliedDbfsNumber");
			data.CreatedTime = _ctx.StringValue("GetAutoSnapshotPolicy.Data.CreatedTime");
			data.LastModified = _ctx.StringValue("GetAutoSnapshotPolicy.Data.LastModified");

			List<string> data_repeatWeekdays = new List<string>();
			for (int i = 0; i < _ctx.Length("GetAutoSnapshotPolicy.Data.RepeatWeekdays.Length"); i++) {
				data_repeatWeekdays.Add(_ctx.StringValue("GetAutoSnapshotPolicy.Data.RepeatWeekdays["+ i +"]"));
			}
			data.RepeatWeekdays = data_repeatWeekdays;

			List<string> data_timePoints = new List<string>();
			for (int i = 0; i < _ctx.Length("GetAutoSnapshotPolicy.Data.TimePoints.Length"); i++) {
				data_timePoints.Add(_ctx.StringValue("GetAutoSnapshotPolicy.Data.TimePoints["+ i +"]"));
			}
			data.TimePoints = data_timePoints;
			getAutoSnapshotPolicyResponse.Data = data;
        
			return getAutoSnapshotPolicyResponse;
        }
    }
}
