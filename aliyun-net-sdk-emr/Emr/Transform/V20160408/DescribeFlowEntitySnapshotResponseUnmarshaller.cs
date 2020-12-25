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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class DescribeFlowEntitySnapshotResponseUnmarshaller
    {
        public static DescribeFlowEntitySnapshotResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeFlowEntitySnapshotResponse describeFlowEntitySnapshotResponse = new DescribeFlowEntitySnapshotResponse();

			describeFlowEntitySnapshotResponse.HttpResponse = _ctx.HttpResponse;
			describeFlowEntitySnapshotResponse.RequestId = _ctx.StringValue("DescribeFlowEntitySnapshot.RequestId");
			describeFlowEntitySnapshotResponse.GmtCreate = _ctx.LongValue("DescribeFlowEntitySnapshot.GmtCreate");
			describeFlowEntitySnapshotResponse.Revision = _ctx.StringValue("DescribeFlowEntitySnapshot.Revision");
			describeFlowEntitySnapshotResponse.UserId = _ctx.StringValue("DescribeFlowEntitySnapshot.UserId");
			describeFlowEntitySnapshotResponse.CommitterId = _ctx.StringValue("DescribeFlowEntitySnapshot.CommitterId");
			describeFlowEntitySnapshotResponse.Message = _ctx.StringValue("DescribeFlowEntitySnapshot.Message");
			describeFlowEntitySnapshotResponse.EntityId = _ctx.StringValue("DescribeFlowEntitySnapshot.EntityId");
			describeFlowEntitySnapshotResponse.EntityGroupId = _ctx.StringValue("DescribeFlowEntitySnapshot.EntityGroupId");
			describeFlowEntitySnapshotResponse.EntityType = _ctx.StringValue("DescribeFlowEntitySnapshot.EntityType");
			describeFlowEntitySnapshotResponse.Data = _ctx.StringValue("DescribeFlowEntitySnapshot.Data");
			describeFlowEntitySnapshotResponse.Active = _ctx.BooleanValue("DescribeFlowEntitySnapshot.Active");
        
			return describeFlowEntitySnapshotResponse;
        }
    }
}
