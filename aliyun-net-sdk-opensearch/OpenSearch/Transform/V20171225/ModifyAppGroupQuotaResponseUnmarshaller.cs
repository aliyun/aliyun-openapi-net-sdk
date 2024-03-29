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
    public class ModifyAppGroupQuotaResponseUnmarshaller
    {
        public static ModifyAppGroupQuotaResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ModifyAppGroupQuotaResponse modifyAppGroupQuotaResponse = new ModifyAppGroupQuotaResponse();

			modifyAppGroupQuotaResponse.HttpResponse = _ctx.HttpResponse;
			modifyAppGroupQuotaResponse.RequestId = _ctx.StringValue("ModifyAppGroupQuota.requestId");

			ModifyAppGroupQuotaResponse.ModifyAppGroupQuota_Result result = new ModifyAppGroupQuotaResponse.ModifyAppGroupQuota_Result();
			result.Created = _ctx.IntegerValue("ModifyAppGroupQuota.Result.created");
			result.CurrentVersion = _ctx.StringValue("ModifyAppGroupQuota.Result.currentVersion");
			result.PendingSecondRankAlgoDeploymentId = _ctx.IntegerValue("ModifyAppGroupQuota.Result.pendingSecondRankAlgoDeploymentId");
			result.Type = _ctx.StringValue("ModifyAppGroupQuota.Result.type");
			result.ChargingWay = _ctx.IntegerValue("ModifyAppGroupQuota.Result.chargingWay");
			result.LockMode = _ctx.StringValue("ModifyAppGroupQuota.Result.lockMode");
			result.Status = _ctx.StringValue("ModifyAppGroupQuota.Result.status");
			result.Updated = _ctx.IntegerValue("ModifyAppGroupQuota.Result.updated");
			result.ChargeType = _ctx.StringValue("ModifyAppGroupQuota.Result.chargeType");
			result.Id = _ctx.StringValue("ModifyAppGroupQuota.Result.id");
			result.HasPendingQuotaReviewTask = _ctx.IntegerValue("ModifyAppGroupQuota.Result.hasPendingQuotaReviewTask");
			result.ProjectId = _ctx.StringValue("ModifyAppGroupQuota.Result.projectId");
			result.SecondRankAlgoDeploymentId = _ctx.IntegerValue("ModifyAppGroupQuota.Result.secondRankAlgoDeploymentId");
			result.CommodityCode = _ctx.StringValue("ModifyAppGroupQuota.Result.commodityCode");
			result.SwitchedTime = _ctx.IntegerValue("ModifyAppGroupQuota.Result.switchedTime");
			result.ExpireOn = _ctx.StringValue("ModifyAppGroupQuota.Result.expireOn");
			result.Description = _ctx.StringValue("ModifyAppGroupQuota.Result.description");
			result.FirstRankAlgoDeploymentId = _ctx.IntegerValue("ModifyAppGroupQuota.Result.firstRankAlgoDeploymentId");
			result.LockedByExpiration = _ctx.IntegerValue("ModifyAppGroupQuota.Result.lockedByExpiration");
			result.Produced = _ctx.IntegerValue("ModifyAppGroupQuota.Result.produced");
			result.Name = _ctx.StringValue("ModifyAppGroupQuota.Result.name");
			result.ProcessingOrderId = _ctx.StringValue("ModifyAppGroupQuota.Result.processingOrderId");
			result.InstanceId = _ctx.StringValue("ModifyAppGroupQuota.Result.instanceId");

			ModifyAppGroupQuotaResponse.ModifyAppGroupQuota_Result.ModifyAppGroupQuota_Quota quota = new ModifyAppGroupQuotaResponse.ModifyAppGroupQuota_Result.ModifyAppGroupQuota_Quota();
			quota.Spec = _ctx.StringValue("ModifyAppGroupQuota.Result.Quota.spec");
			quota.DocSize = _ctx.IntegerValue("ModifyAppGroupQuota.Result.Quota.docSize");
			quota.ComputeResource = _ctx.IntegerValue("ModifyAppGroupQuota.Result.Quota.computeResource");
			result.Quota = quota;
			modifyAppGroupQuotaResponse.Result = result;
        
			return modifyAppGroupQuotaResponse;
        }
    }
}
