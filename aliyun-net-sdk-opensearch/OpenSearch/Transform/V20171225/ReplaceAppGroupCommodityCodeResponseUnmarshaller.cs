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
    public class ReplaceAppGroupCommodityCodeResponseUnmarshaller
    {
        public static ReplaceAppGroupCommodityCodeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ReplaceAppGroupCommodityCodeResponse replaceAppGroupCommodityCodeResponse = new ReplaceAppGroupCommodityCodeResponse();

			replaceAppGroupCommodityCodeResponse.HttpResponse = _ctx.HttpResponse;
			replaceAppGroupCommodityCodeResponse.RequestId = _ctx.StringValue("ReplaceAppGroupCommodityCode.requestId");

			ReplaceAppGroupCommodityCodeResponse.ReplaceAppGroupCommodityCode_Result result = new ReplaceAppGroupCommodityCodeResponse.ReplaceAppGroupCommodityCode_Result();
			result.Id = _ctx.StringValue("ReplaceAppGroupCommodityCode.Result.id");
			result.Name = _ctx.StringValue("ReplaceAppGroupCommodityCode.Result.name");
			result.CurrentVersion = _ctx.StringValue("ReplaceAppGroupCommodityCode.Result.currentVersion");
			result.SwitchedTime = _ctx.IntegerValue("ReplaceAppGroupCommodityCode.Result.switchedTime");
			result.ChargingWay = _ctx.IntegerValue("ReplaceAppGroupCommodityCode.Result.chargingWay");
			result.Type = _ctx.StringValue("ReplaceAppGroupCommodityCode.Result.type");
			result.ProjectId = _ctx.StringValue("ReplaceAppGroupCommodityCode.Result.projectId");
			result.ChargeType = _ctx.StringValue("ReplaceAppGroupCommodityCode.Result.chargeType");
			result.ExpireOn = _ctx.StringValue("ReplaceAppGroupCommodityCode.Result.expireOn");
			result.InstanceId = _ctx.StringValue("ReplaceAppGroupCommodityCode.Result.instanceId");
			result.CommodityCode = _ctx.StringValue("ReplaceAppGroupCommodityCode.Result.commodityCode");
			result.ProcessingOrderId = _ctx.StringValue("ReplaceAppGroupCommodityCode.Result.processingOrderId");
			result.FirstRankAlgoDeploymentId = _ctx.IntegerValue("ReplaceAppGroupCommodityCode.Result.firstRankAlgoDeploymentId");
			result.SecondRankAlgoDeploymentId = _ctx.IntegerValue("ReplaceAppGroupCommodityCode.Result.secondRankAlgoDeploymentId");
			result.PendingSecondRankAlgoDeploymentId = _ctx.IntegerValue("ReplaceAppGroupCommodityCode.Result.pendingSecondRankAlgoDeploymentId");
			result.Description = _ctx.StringValue("ReplaceAppGroupCommodityCode.Result.description");
			result.Produced = _ctx.IntegerValue("ReplaceAppGroupCommodityCode.Result.produced");
			result.LockedByExpiration = _ctx.IntegerValue("ReplaceAppGroupCommodityCode.Result.lockedByExpiration");
			result.HasPendingQuotaReviewTask = _ctx.IntegerValue("ReplaceAppGroupCommodityCode.Result.hasPendingQuotaReviewTask");
			result.Created = _ctx.IntegerValue("ReplaceAppGroupCommodityCode.Result.created");
			result.Updated = _ctx.IntegerValue("ReplaceAppGroupCommodityCode.Result.updated");
			result.Status = _ctx.StringValue("ReplaceAppGroupCommodityCode.Result.status");
			result.LockMode = _ctx.StringValue("ReplaceAppGroupCommodityCode.Result.lockMode");

			List<string> result_versions = new List<string>();
			for (int i = 0; i < _ctx.Length("ReplaceAppGroupCommodityCode.Result.Versions.Length"); i++) {
				result_versions.Add(_ctx.StringValue("ReplaceAppGroupCommodityCode.Result.Versions["+ i +"]"));
			}
			result.Versions = result_versions;

			ReplaceAppGroupCommodityCodeResponse.ReplaceAppGroupCommodityCode_Result.ReplaceAppGroupCommodityCode_Quota quota = new ReplaceAppGroupCommodityCodeResponse.ReplaceAppGroupCommodityCode_Result.ReplaceAppGroupCommodityCode_Quota();
			quota.DocSize = _ctx.IntegerValue("ReplaceAppGroupCommodityCode.Result.Quota.docSize");
			quota.ComputeResource = _ctx.IntegerValue("ReplaceAppGroupCommodityCode.Result.Quota.computeResource");
			quota.Spec = _ctx.StringValue("ReplaceAppGroupCommodityCode.Result.Quota.spec");
			result.Quota = quota;
			replaceAppGroupCommodityCodeResponse.Result = result;
        
			return replaceAppGroupCommodityCodeResponse;
        }
    }
}
