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
    public class ListAppGroupsResponseUnmarshaller
    {
        public static ListAppGroupsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAppGroupsResponse listAppGroupsResponse = new ListAppGroupsResponse();

			listAppGroupsResponse.HttpResponse = _ctx.HttpResponse;
			listAppGroupsResponse.RequestId = _ctx.StringValue("ListAppGroups.requestId");
			listAppGroupsResponse.TotalCount = _ctx.IntegerValue("ListAppGroups.totalCount");

			List<ListAppGroupsResponse.ListAppGroups_ResultItem> listAppGroupsResponse_result = new List<ListAppGroupsResponse.ListAppGroups_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListAppGroups.Result.Length"); i++) {
				ListAppGroupsResponse.ListAppGroups_ResultItem resultItem = new ListAppGroupsResponse.ListAppGroups_ResultItem();
				resultItem.Id = _ctx.StringValue("ListAppGroups.Result["+ i +"].id");
				resultItem.Name = _ctx.StringValue("ListAppGroups.Result["+ i +"].name");
				resultItem.CurrentVersion = _ctx.StringValue("ListAppGroups.Result["+ i +"].currentVersion");
				resultItem.SwitchedTime = _ctx.IntegerValue("ListAppGroups.Result["+ i +"].switchedTime");
				resultItem.ChargingWay = _ctx.IntegerValue("ListAppGroups.Result["+ i +"].chargingWay");
				resultItem.Type = _ctx.StringValue("ListAppGroups.Result["+ i +"].type");
				resultItem.ProjectId = _ctx.StringValue("ListAppGroups.Result["+ i +"].projectId");
				resultItem.ChargeType = _ctx.StringValue("ListAppGroups.Result["+ i +"].chargeType");
				resultItem.ExpireOn = _ctx.StringValue("ListAppGroups.Result["+ i +"].expireOn");
				resultItem.InstanceId = _ctx.StringValue("ListAppGroups.Result["+ i +"].instanceId");
				resultItem.CommodityCode = _ctx.StringValue("ListAppGroups.Result["+ i +"].commodityCode");
				resultItem.ProcessingOrderId = _ctx.StringValue("ListAppGroups.Result["+ i +"].processingOrderId");
				resultItem.FirstRankAlgoDeploymentId = _ctx.IntegerValue("ListAppGroups.Result["+ i +"].firstRankAlgoDeploymentId");
				resultItem.SecondRankAlgoDeploymentId = _ctx.IntegerValue("ListAppGroups.Result["+ i +"].secondRankAlgoDeploymentId");
				resultItem.PendingSecondRankAlgoDeploymentId = _ctx.IntegerValue("ListAppGroups.Result["+ i +"].pendingSecondRankAlgoDeploymentId");
				resultItem.Description = _ctx.StringValue("ListAppGroups.Result["+ i +"].description");
				resultItem.Produced = _ctx.IntegerValue("ListAppGroups.Result["+ i +"].produced");
				resultItem.LockedByExpiration = _ctx.IntegerValue("ListAppGroups.Result["+ i +"].lockedByExpiration");
				resultItem.HasPendingQuotaReviewTask = _ctx.IntegerValue("ListAppGroups.Result["+ i +"].hasPendingQuotaReviewTask");
				resultItem.Created = _ctx.IntegerValue("ListAppGroups.Result["+ i +"].created");
				resultItem.Updated = _ctx.IntegerValue("ListAppGroups.Result["+ i +"].updated");
				resultItem.Status = _ctx.StringValue("ListAppGroups.Result["+ i +"].status");
				resultItem.LockMode = _ctx.StringValue("ListAppGroups.Result["+ i +"].lockMode");
				resultItem.Domain = _ctx.StringValue("ListAppGroups.Result["+ i +"].domain");

				ListAppGroupsResponse.ListAppGroups_ResultItem.ListAppGroups_Quota quota = new ListAppGroupsResponse.ListAppGroups_ResultItem.ListAppGroups_Quota();
				quota.DocSize = _ctx.IntegerValue("ListAppGroups.Result["+ i +"].Quota.docSize");
				quota.ComputeResource = _ctx.IntegerValue("ListAppGroups.Result["+ i +"].Quota.computeResource");
				quota.Spec = _ctx.StringValue("ListAppGroups.Result["+ i +"].Quota.spec");
				resultItem.Quota = quota;

				listAppGroupsResponse_result.Add(resultItem);
			}
			listAppGroupsResponse.Result = listAppGroupsResponse_result;
        
			return listAppGroupsResponse;
        }
    }
}
