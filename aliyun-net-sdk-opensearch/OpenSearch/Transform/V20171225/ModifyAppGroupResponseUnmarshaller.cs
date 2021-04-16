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
    public class ModifyAppGroupResponseUnmarshaller
    {
        public static ModifyAppGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ModifyAppGroupResponse modifyAppGroupResponse = new ModifyAppGroupResponse();

			modifyAppGroupResponse.HttpResponse = _ctx.HttpResponse;
			modifyAppGroupResponse.RequestId = _ctx.StringValue("ModifyAppGroup.requestId");

			ModifyAppGroupResponse.ModifyAppGroup_Result result = new ModifyAppGroupResponse.ModifyAppGroup_Result();
			result.Id = _ctx.StringValue("ModifyAppGroup.Result.id");
			result.Name = _ctx.StringValue("ModifyAppGroup.Result.name");
			result.CurrentVersion = _ctx.StringValue("ModifyAppGroup.Result.currentVersion");
			result.SwitchedTime = _ctx.IntegerValue("ModifyAppGroup.Result.switchedTime");
			result.ChargingWay = _ctx.IntegerValue("ModifyAppGroup.Result.chargingWay");
			result.Type = _ctx.StringValue("ModifyAppGroup.Result.type");
			result.ProjectId = _ctx.StringValue("ModifyAppGroup.Result.projectId");
			result.ChargeType = _ctx.StringValue("ModifyAppGroup.Result.chargeType");
			result.ExpireOn = _ctx.StringValue("ModifyAppGroup.Result.expireOn");
			result.InstanceId = _ctx.StringValue("ModifyAppGroup.Result.instanceId");
			result.CommodityCode = _ctx.StringValue("ModifyAppGroup.Result.commodityCode");
			result.ProcessingOrderId = _ctx.StringValue("ModifyAppGroup.Result.processingOrderId");
			result.FirstRankAlgoDeploymentId = _ctx.IntegerValue("ModifyAppGroup.Result.firstRankAlgoDeploymentId");
			result.SecondRankAlgoDeploymentId = _ctx.IntegerValue("ModifyAppGroup.Result.secondRankAlgoDeploymentId");
			result.PendingSecondRankAlgoDeploymentId = _ctx.IntegerValue("ModifyAppGroup.Result.pendingSecondRankAlgoDeploymentId");
			result.Description = _ctx.StringValue("ModifyAppGroup.Result.description");
			result.Produced = _ctx.IntegerValue("ModifyAppGroup.Result.produced");
			result.LockedByExpiration = _ctx.IntegerValue("ModifyAppGroup.Result.lockedByExpiration");
			result.HasPendingQuotaReviewTask = _ctx.IntegerValue("ModifyAppGroup.Result.hasPendingQuotaReviewTask");
			result.Created = _ctx.IntegerValue("ModifyAppGroup.Result.created");
			result.Updated = _ctx.IntegerValue("ModifyAppGroup.Result.updated");
			result.Status = _ctx.StringValue("ModifyAppGroup.Result.status");
			result.LockMode = _ctx.StringValue("ModifyAppGroup.Result.lockMode");
			result.Domain = _ctx.StringValue("ModifyAppGroup.Result.domain");

			ModifyAppGroupResponse.ModifyAppGroup_Result.ModifyAppGroup_Quota quota = new ModifyAppGroupResponse.ModifyAppGroup_Result.ModifyAppGroup_Quota();
			quota.DocSize = _ctx.IntegerValue("ModifyAppGroup.Result.Quota.docSize");
			quota.ComputeResource = _ctx.IntegerValue("ModifyAppGroup.Result.Quota.computeResource");
			quota.Spec = _ctx.StringValue("ModifyAppGroup.Result.Quota.spec");
			result.Quota = quota;
			modifyAppGroupResponse.Result = result;
        
			return modifyAppGroupResponse;
        }
    }
}
