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
using Aliyun.Acs.Ecs.Model.V20151101;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Transform.V20151101
{
    public class OpsDetailSnapshotResponseUnmarshaller
    {
        public static OpsDetailSnapshotResponse Unmarshall(UnmarshallerContext context)
        {
			OpsDetailSnapshotResponse opsDetailSnapshotResponse = new OpsDetailSnapshotResponse();

			opsDetailSnapshotResponse.HttpResponse = context.HttpResponse;
			opsDetailSnapshotResponse.RequestId = context.StringValue("OpsDetailSnapshot.RequestId");
			opsDetailSnapshotResponse.SnapshotName = context.StringValue("OpsDetailSnapshot.SnapshotName");
			opsDetailSnapshotResponse.SnapshotId = context.StringValue("OpsDetailSnapshot.SnapshotId");
			opsDetailSnapshotResponse.CreatedTime = context.StringValue("OpsDetailSnapshot.CreatedTime");
			opsDetailSnapshotResponse.Progress = context.StringValue("OpsDetailSnapshot.Progress");
			opsDetailSnapshotResponse.ImageId = context.StringValue("OpsDetailSnapshot.ImageId");
			opsDetailSnapshotResponse.SnapshotType = context.StringValue("OpsDetailSnapshot.SnapshotType");
			opsDetailSnapshotResponse.SnapshotSize = context.IntegerValue("OpsDetailSnapshot.SnapshotSize");
			opsDetailSnapshotResponse.RegionNo = context.StringValue("OpsDetailSnapshot.RegionNo");
			opsDetailSnapshotResponse.Description = context.StringValue("OpsDetailSnapshot.Description");
			opsDetailSnapshotResponse.SourceDiskId = context.StringValue("OpsDetailSnapshot.SourceDiskId");
			opsDetailSnapshotResponse.SourceDiskType = context.StringValue("OpsDetailSnapshot.SourceDiskType");
			opsDetailSnapshotResponse.SourceDiskSize = context.IntegerValue("OpsDetailSnapshot.SourceDiskSize");
        
			return opsDetailSnapshotResponse;
        }
    }
}