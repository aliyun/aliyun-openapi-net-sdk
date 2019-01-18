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
using Aliyun.Acs.R_kvstore.Model.V20150101;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.R_kvstore.Transform.V20150101
{
    public class GetSnapshotSettingsResponseUnmarshaller
    {
        public static GetSnapshotSettingsResponse Unmarshall(UnmarshallerContext context)
        {
			GetSnapshotSettingsResponse getSnapshotSettingsResponse = new GetSnapshotSettingsResponse();

			getSnapshotSettingsResponse.HttpResponse = context.HttpResponse;
			getSnapshotSettingsResponse.RequestId = context.StringValue("GetSnapshotSettings.RequestId");
			getSnapshotSettingsResponse.InstanceId = context.StringValue("GetSnapshotSettings.InstanceId");
			getSnapshotSettingsResponse.BeginHour = context.IntegerValue("GetSnapshotSettings.BeginHour");
			getSnapshotSettingsResponse.EndHour = context.IntegerValue("GetSnapshotSettings.EndHour");
			getSnapshotSettingsResponse.RetentionDay = context.IntegerValue("GetSnapshotSettings.RetentionDay");
			getSnapshotSettingsResponse.MaxAutoSnapshots = context.IntegerValue("GetSnapshotSettings.MaxAutoSnapshots");
			getSnapshotSettingsResponse.MaxManualSnapshots = context.IntegerValue("GetSnapshotSettings.MaxManualSnapshots");
			getSnapshotSettingsResponse.DayList = context.IntegerValue("GetSnapshotSettings.DayList");
			getSnapshotSettingsResponse.NextTime = context.StringValue("GetSnapshotSettings.NextTime");
        
			return getSnapshotSettingsResponse;
        }
    }
}