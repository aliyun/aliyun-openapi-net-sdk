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
using Aliyun.Acs.OpenSearch.Model.V20171225;

namespace Aliyun.Acs.OpenSearch.Transform.V20171225
{
    public class DescribeAppGroupResponseUnmarshaller
    {
        public static DescribeAppGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAppGroupResponse describeAppGroupResponse = new DescribeAppGroupResponse();

			describeAppGroupResponse.HttpResponse = _ctx.HttpResponse;
			describeAppGroupResponse.RequestId = _ctx.StringValue("DescribeAppGroup.requestId");

			DescribeAppGroupResponse.DescribeAppGroup_Result result = new DescribeAppGroupResponse.DescribeAppGroup_Result();
			result.Id = _ctx.StringValue("DescribeAppGroup.Result.id");
			result.Name = _ctx.StringValue("DescribeAppGroup.Result.name");
			result.CurrentVersion = _ctx.StringValue("DescribeAppGroup.Result.currentVersion");
			result.SwitchedTime = _ctx.IntegerValue("DescribeAppGroup.Result.switchedTime");
			result.ChargingWay = _ctx.IntegerValue("DescribeAppGroup.Result.chargingWay");
			result.Type = _ctx.StringValue("DescribeAppGroup.Result.type");
			result.ProjectId = _ctx.StringValue("DescribeAppGroup.Result.projectId");
			result.ChargeType = _ctx.StringValue("DescribeAppGroup.Result.chargeType");
			result.ExpireOn = _ctx.StringValue("DescribeAppGroup.Result.expireOn");
			result.InstanceId = _ctx.StringValue("DescribeAppGroup.Result.instanceId");
			result.CommodityCode = _ctx.StringValue("DescribeAppGroup.Result.commodityCode");
			result.ProcessingOrderId = _ctx.StringValue("DescribeAppGroup.Result.processingOrderId");
			result.FirstRankAlgoDeploymentId = _ctx.IntegerValue("DescribeAppGroup.Result.firstRankAlgoDeploymentId");
			result.SecondRankAlgoDeploymentId = _ctx.IntegerValue("DescribeAppGroup.Result.secondRankAlgoDeploymentId");
			result.PendingSecondRankAlgoDeploymentId = _ctx.IntegerValue("DescribeAppGroup.Result.pendingSecondRankAlgoDeploymentId");
			result.Description = _ctx.StringValue("DescribeAppGroup.Result.description");
			result.Produced = _ctx.IntegerValue("DescribeAppGroup.Result.produced");
			result.LockedByExpiration = _ctx.IntegerValue("DescribeAppGroup.Result.lockedByExpiration");
			result.HasPendingQuotaReviewTask = _ctx.IntegerValue("DescribeAppGroup.Result.hasPendingQuotaReviewTask");
			result.Created = _ctx.IntegerValue("DescribeAppGroup.Result.created");
			result.Updated = _ctx.IntegerValue("DescribeAppGroup.Result.updated");
			result.Status = _ctx.StringValue("DescribeAppGroup.Result.status");
			result.LockMode = _ctx.StringValue("DescribeAppGroup.Result.lockMode");
			result.Domain = _ctx.StringValue("DescribeAppGroup.Result.domain");

			DescribeAppGroupResponse.DescribeAppGroup_Result.DescribeAppGroup_Quota quota = new DescribeAppGroupResponse.DescribeAppGroup_Result.DescribeAppGroup_Quota();
			quota.DocSize = _ctx.IntegerValue("DescribeAppGroup.Result.Quota.docSize");
			quota.ComputeResource = _ctx.IntegerValue("DescribeAppGroup.Result.Quota.computeResource");
			quota.Spec = _ctx.StringValue("DescribeAppGroup.Result.Quota.spec");
			result.Quota = quota;
			describeAppGroupResponse.Result = result;
        
			return describeAppGroupResponse;
        }
    }
}
