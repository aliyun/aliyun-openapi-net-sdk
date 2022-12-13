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
			listAppGroupsResponse.TotalCount = _ctx.IntegerValue("ListAppGroups.totalCount");
			listAppGroupsResponse.RequestId = _ctx.StringValue("ListAppGroups.requestId");

			List<ListAppGroupsResponse.ListAppGroups_ResultItem> listAppGroupsResponse_result = new List<ListAppGroupsResponse.ListAppGroups_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListAppGroups.Result.Length"); i++) {
				ListAppGroupsResponse.ListAppGroups_ResultItem resultItem = new ListAppGroupsResponse.ListAppGroups_ResultItem();
				resultItem.Created = _ctx.IntegerValue("ListAppGroups.Result["+ i +"].created");
				resultItem.CurrentVersion = _ctx.StringValue("ListAppGroups.Result["+ i +"].currentVersion");
				resultItem.PendingSecondRankAlgoDeploymentId = _ctx.IntegerValue("ListAppGroups.Result["+ i +"].pendingSecondRankAlgoDeploymentId");
				resultItem.LockMode = _ctx.StringValue("ListAppGroups.Result["+ i +"].lockMode");
				resultItem.Updated = _ctx.IntegerValue("ListAppGroups.Result["+ i +"].updated");
				resultItem.Id = _ctx.StringValue("ListAppGroups.Result["+ i +"].id");
				resultItem.ChargeType = _ctx.StringValue("ListAppGroups.Result["+ i +"].chargeType");
				resultItem.HasPendingQuotaReviewTask = _ctx.IntegerValue("ListAppGroups.Result["+ i +"].hasPendingQuotaReviewTask");
				resultItem.SecondRankAlgoDeploymentId = _ctx.IntegerValue("ListAppGroups.Result["+ i +"].secondRankAlgoDeploymentId");
				resultItem.Name = _ctx.StringValue("ListAppGroups.Result["+ i +"].name");
				resultItem.InstanceId = _ctx.StringValue("ListAppGroups.Result["+ i +"].instanceId");
				resultItem.ProcessingOrderId = _ctx.StringValue("ListAppGroups.Result["+ i +"].processingOrderId");
				resultItem.ChargingWay = _ctx.IntegerValue("ListAppGroups.Result["+ i +"].chargingWay");
				resultItem.Type = _ctx.StringValue("ListAppGroups.Result["+ i +"].type");
				resultItem.Status = _ctx.StringValue("ListAppGroups.Result["+ i +"].status");
				resultItem.ProjectId = _ctx.StringValue("ListAppGroups.Result["+ i +"].projectId");
				resultItem.SwitchedTime = _ctx.IntegerValue("ListAppGroups.Result["+ i +"].switchedTime");
				resultItem.CommodityCode = _ctx.StringValue("ListAppGroups.Result["+ i +"].commodityCode");
				resultItem.ExpireOn = _ctx.StringValue("ListAppGroups.Result["+ i +"].expireOn");
				resultItem.Domain = _ctx.StringValue("ListAppGroups.Result["+ i +"].domain");
				resultItem.Description = _ctx.StringValue("ListAppGroups.Result["+ i +"].description");
				resultItem.FirstRankAlgoDeploymentId = _ctx.IntegerValue("ListAppGroups.Result["+ i +"].firstRankAlgoDeploymentId");
				resultItem.Produced = _ctx.IntegerValue("ListAppGroups.Result["+ i +"].produced");
				resultItem.LockedByExpiration = _ctx.IntegerValue("ListAppGroups.Result["+ i +"].lockedByExpiration");

				ListAppGroupsResponse.ListAppGroups_ResultItem.ListAppGroups_Quota quota = new ListAppGroupsResponse.ListAppGroups_ResultItem.ListAppGroups_Quota();
				quota.Spec = _ctx.StringValue("ListAppGroups.Result["+ i +"].Quota.spec");
				quota.DocSize = _ctx.IntegerValue("ListAppGroups.Result["+ i +"].Quota.docSize");
				quota.ComputeResource = _ctx.IntegerValue("ListAppGroups.Result["+ i +"].Quota.computeResource");
				resultItem.Quota = quota;

				List<ListAppGroupsResponse.ListAppGroups_ResultItem.ListAppGroups_TagsItem> resultItem_tags = new List<ListAppGroupsResponse.ListAppGroups_ResultItem.ListAppGroups_TagsItem>();
				for (int j = 0; j < _ctx.Length("ListAppGroups.Result["+ i +"].Tags.Length"); j++) {
					ListAppGroupsResponse.ListAppGroups_ResultItem.ListAppGroups_TagsItem tagsItem = new ListAppGroupsResponse.ListAppGroups_ResultItem.ListAppGroups_TagsItem();
					tagsItem.Key = _ctx.StringValue("ListAppGroups.Result["+ i +"].Tags["+ j +"].key");
					tagsItem._Value = _ctx.StringValue("ListAppGroups.Result["+ i +"].Tags["+ j +"].value");

					resultItem_tags.Add(tagsItem);
				}
				resultItem.Tags = resultItem_tags;

				listAppGroupsResponse_result.Add(resultItem);
			}
			listAppGroupsResponse.Result = listAppGroupsResponse_result;
        
			return listAppGroupsResponse;
        }
    }
}
