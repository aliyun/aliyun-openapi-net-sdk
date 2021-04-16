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
    public class CreateAppGroupResponseUnmarshaller
    {
        public static CreateAppGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateAppGroupResponse createAppGroupResponse = new CreateAppGroupResponse();

			createAppGroupResponse.HttpResponse = _ctx.HttpResponse;
			createAppGroupResponse.RequestId = _ctx.StringValue("CreateAppGroup.requestId");

			CreateAppGroupResponse.CreateAppGroup_Result result = new CreateAppGroupResponse.CreateAppGroup_Result();
			result.Id = _ctx.StringValue("CreateAppGroup.Result.id");
			result.Name = _ctx.StringValue("CreateAppGroup.Result.name");
			result.CurrentVersion = _ctx.StringValue("CreateAppGroup.Result.currentVersion");
			result.SwitchedTime = _ctx.IntegerValue("CreateAppGroup.Result.switchedTime");
			result.ChargingWay = _ctx.IntegerValue("CreateAppGroup.Result.chargingWay");
			result.Type = _ctx.StringValue("CreateAppGroup.Result.type");
			result.ProjectId = _ctx.StringValue("CreateAppGroup.Result.projectId");
			result.ChargeType = _ctx.StringValue("CreateAppGroup.Result.chargeType");
			result.ExpireOn = _ctx.StringValue("CreateAppGroup.Result.expireOn");
			result.InstanceId = _ctx.StringValue("CreateAppGroup.Result.instanceId");
			result.CommodityCode = _ctx.StringValue("CreateAppGroup.Result.commodityCode");
			result.ProcessingOrderId = _ctx.StringValue("CreateAppGroup.Result.processingOrderId");
			result.FirstRankAlgoDeploymentId = _ctx.IntegerValue("CreateAppGroup.Result.firstRankAlgoDeploymentId");
			result.SecondRankAlgoDeploymentId = _ctx.IntegerValue("CreateAppGroup.Result.secondRankAlgoDeploymentId");
			result.PendingSecondRankAlgoDeploymentId = _ctx.IntegerValue("CreateAppGroup.Result.pendingSecondRankAlgoDeploymentId");
			result.Description = _ctx.StringValue("CreateAppGroup.Result.description");
			result.Produced = _ctx.IntegerValue("CreateAppGroup.Result.produced");
			result.LockedByExpiration = _ctx.IntegerValue("CreateAppGroup.Result.lockedByExpiration");
			result.HasPendingQuotaReviewTask = _ctx.IntegerValue("CreateAppGroup.Result.hasPendingQuotaReviewTask");
			result.Created = _ctx.IntegerValue("CreateAppGroup.Result.created");
			result.Updated = _ctx.IntegerValue("CreateAppGroup.Result.updated");
			result.Status = _ctx.StringValue("CreateAppGroup.Result.status");
			result.LockMode = _ctx.StringValue("CreateAppGroup.Result.lockMode");
			result.Domain = _ctx.StringValue("CreateAppGroup.Result.domain");

			CreateAppGroupResponse.CreateAppGroup_Result.CreateAppGroup_Quota quota = new CreateAppGroupResponse.CreateAppGroup_Result.CreateAppGroup_Quota();
			quota.DocSize = _ctx.IntegerValue("CreateAppGroup.Result.Quota.docSize");
			quota.ComputeResource = _ctx.IntegerValue("CreateAppGroup.Result.Quota.computeResource");
			quota.Spec = _ctx.StringValue("CreateAppGroup.Result.Quota.spec");
			result.Quota = quota;
			createAppGroupResponse.Result = result;
        
			return createAppGroupResponse;
        }
    }
}
