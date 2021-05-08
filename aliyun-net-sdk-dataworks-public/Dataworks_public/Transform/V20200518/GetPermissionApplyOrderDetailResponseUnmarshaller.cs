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
using Aliyun.Acs.dataworks_public.Model.V20200518;

namespace Aliyun.Acs.dataworks_public.Transform.V20200518
{
    public class GetPermissionApplyOrderDetailResponseUnmarshaller
    {
        public static GetPermissionApplyOrderDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetPermissionApplyOrderDetailResponse getPermissionApplyOrderDetailResponse = new GetPermissionApplyOrderDetailResponse();

			getPermissionApplyOrderDetailResponse.HttpResponse = _ctx.HttpResponse;
			getPermissionApplyOrderDetailResponse.RequestId = _ctx.StringValue("GetPermissionApplyOrderDetail.RequestId");

			GetPermissionApplyOrderDetailResponse.GetPermissionApplyOrderDetail_ApplyOrderDetail applyOrderDetail = new GetPermissionApplyOrderDetailResponse.GetPermissionApplyOrderDetail_ApplyOrderDetail();
			applyOrderDetail.ApplyBaseId = _ctx.StringValue("GetPermissionApplyOrderDetail.ApplyOrderDetail.ApplyBaseId");
			applyOrderDetail.ApplyTimestamp = _ctx.LongValue("GetPermissionApplyOrderDetail.ApplyOrderDetail.ApplyTimestamp");
			applyOrderDetail.FlowId = _ctx.StringValue("GetPermissionApplyOrderDetail.ApplyOrderDetail.FlowId");
			applyOrderDetail.FlowStatus = _ctx.IntegerValue("GetPermissionApplyOrderDetail.ApplyOrderDetail.FlowStatus");

			GetPermissionApplyOrderDetailResponse.GetPermissionApplyOrderDetail_ApplyOrderDetail.GetPermissionApplyOrderDetail_ApproveContent approveContent = new GetPermissionApplyOrderDetailResponse.GetPermissionApplyOrderDetail_ApplyOrderDetail.GetPermissionApplyOrderDetail_ApproveContent();
			approveContent.ApplyReason = _ctx.StringValue("GetPermissionApplyOrderDetail.ApplyOrderDetail.ApproveContent.ApplyReason");
			approveContent.Deadline = _ctx.LongValue("GetPermissionApplyOrderDetail.ApplyOrderDetail.ApproveContent.Deadline");
			approveContent.OrderType = _ctx.IntegerValue("GetPermissionApplyOrderDetail.ApplyOrderDetail.ApproveContent.OrderType");

			GetPermissionApplyOrderDetailResponse.GetPermissionApplyOrderDetail_ApplyOrderDetail.GetPermissionApplyOrderDetail_ApproveContent.GetPermissionApplyOrderDetail_ProjectMeta projectMeta = new GetPermissionApplyOrderDetailResponse.GetPermissionApplyOrderDetail_ApplyOrderDetail.GetPermissionApplyOrderDetail_ApproveContent.GetPermissionApplyOrderDetail_ProjectMeta();
			projectMeta.WorkspaceId = _ctx.IntegerValue("GetPermissionApplyOrderDetail.ApplyOrderDetail.ApproveContent.ProjectMeta.WorkspaceId");
			projectMeta.MaxComputeProjectName = _ctx.StringValue("GetPermissionApplyOrderDetail.ApplyOrderDetail.ApproveContent.ProjectMeta.MaxComputeProjectName");

			List<GetPermissionApplyOrderDetailResponse.GetPermissionApplyOrderDetail_ApplyOrderDetail.GetPermissionApplyOrderDetail_ApproveContent.GetPermissionApplyOrderDetail_ProjectMeta.GetPermissionApplyOrderDetail_ObjectMetaListItem> projectMeta_objectMetaList = new List<GetPermissionApplyOrderDetailResponse.GetPermissionApplyOrderDetail_ApplyOrderDetail.GetPermissionApplyOrderDetail_ApproveContent.GetPermissionApplyOrderDetail_ProjectMeta.GetPermissionApplyOrderDetail_ObjectMetaListItem>();
			for (int i = 0; i < _ctx.Length("GetPermissionApplyOrderDetail.ApplyOrderDetail.ApproveContent.ProjectMeta.ObjectMetaList.Length"); i++) {
				GetPermissionApplyOrderDetailResponse.GetPermissionApplyOrderDetail_ApplyOrderDetail.GetPermissionApplyOrderDetail_ApproveContent.GetPermissionApplyOrderDetail_ProjectMeta.GetPermissionApplyOrderDetail_ObjectMetaListItem objectMetaListItem = new GetPermissionApplyOrderDetailResponse.GetPermissionApplyOrderDetail_ApplyOrderDetail.GetPermissionApplyOrderDetail_ApproveContent.GetPermissionApplyOrderDetail_ProjectMeta.GetPermissionApplyOrderDetail_ObjectMetaListItem();
				objectMetaListItem.ObjectName = _ctx.StringValue("GetPermissionApplyOrderDetail.ApplyOrderDetail.ApproveContent.ProjectMeta.ObjectMetaList["+ i +"].ObjectName");

				List<GetPermissionApplyOrderDetailResponse.GetPermissionApplyOrderDetail_ApplyOrderDetail.GetPermissionApplyOrderDetail_ApproveContent.GetPermissionApplyOrderDetail_ProjectMeta.GetPermissionApplyOrderDetail_ObjectMetaListItem.GetPermissionApplyOrderDetail_ColumnMetaListItem> objectMetaListItem_columnMetaList = new List<GetPermissionApplyOrderDetailResponse.GetPermissionApplyOrderDetail_ApplyOrderDetail.GetPermissionApplyOrderDetail_ApproveContent.GetPermissionApplyOrderDetail_ProjectMeta.GetPermissionApplyOrderDetail_ObjectMetaListItem.GetPermissionApplyOrderDetail_ColumnMetaListItem>();
				for (int j = 0; j < _ctx.Length("GetPermissionApplyOrderDetail.ApplyOrderDetail.ApproveContent.ProjectMeta.ObjectMetaList["+ i +"].ColumnMetaList.Length"); j++) {
					GetPermissionApplyOrderDetailResponse.GetPermissionApplyOrderDetail_ApplyOrderDetail.GetPermissionApplyOrderDetail_ApproveContent.GetPermissionApplyOrderDetail_ProjectMeta.GetPermissionApplyOrderDetail_ObjectMetaListItem.GetPermissionApplyOrderDetail_ColumnMetaListItem columnMetaListItem = new GetPermissionApplyOrderDetailResponse.GetPermissionApplyOrderDetail_ApplyOrderDetail.GetPermissionApplyOrderDetail_ApproveContent.GetPermissionApplyOrderDetail_ProjectMeta.GetPermissionApplyOrderDetail_ObjectMetaListItem.GetPermissionApplyOrderDetail_ColumnMetaListItem();
					columnMetaListItem.ColumnComment = _ctx.StringValue("GetPermissionApplyOrderDetail.ApplyOrderDetail.ApproveContent.ProjectMeta.ObjectMetaList["+ i +"].ColumnMetaList["+ j +"].ColumnComment");
					columnMetaListItem.ColumnName = _ctx.StringValue("GetPermissionApplyOrderDetail.ApplyOrderDetail.ApproveContent.ProjectMeta.ObjectMetaList["+ i +"].ColumnMetaList["+ j +"].ColumnName");

					objectMetaListItem_columnMetaList.Add(columnMetaListItem);
				}
				objectMetaListItem.ColumnMetaList = objectMetaListItem_columnMetaList;

				projectMeta_objectMetaList.Add(objectMetaListItem);
			}
			projectMeta.ObjectMetaList = projectMeta_objectMetaList;
			approveContent.ProjectMeta = projectMeta;
			applyOrderDetail.ApproveContent = approveContent;

			List<GetPermissionApplyOrderDetailResponse.GetPermissionApplyOrderDetail_ApplyOrderDetail.GetPermissionApplyOrderDetail_ApproveAccountListItem> applyOrderDetail_approveAccountList = new List<GetPermissionApplyOrderDetailResponse.GetPermissionApplyOrderDetail_ApplyOrderDetail.GetPermissionApplyOrderDetail_ApproveAccountListItem>();
			for (int i = 0; i < _ctx.Length("GetPermissionApplyOrderDetail.ApplyOrderDetail.ApproveAccountList.Length"); i++) {
				GetPermissionApplyOrderDetailResponse.GetPermissionApplyOrderDetail_ApplyOrderDetail.GetPermissionApplyOrderDetail_ApproveAccountListItem approveAccountListItem = new GetPermissionApplyOrderDetailResponse.GetPermissionApplyOrderDetail_ApplyOrderDetail.GetPermissionApplyOrderDetail_ApproveAccountListItem();
				approveAccountListItem.BaseId = _ctx.StringValue("GetPermissionApplyOrderDetail.ApplyOrderDetail.ApproveAccountList["+ i +"].BaseId");

				applyOrderDetail_approveAccountList.Add(approveAccountListItem);
			}
			applyOrderDetail.ApproveAccountList = applyOrderDetail_approveAccountList;

			List<GetPermissionApplyOrderDetailResponse.GetPermissionApplyOrderDetail_ApplyOrderDetail.GetPermissionApplyOrderDetail_GranteeObjectListItem> applyOrderDetail_granteeObjectList = new List<GetPermissionApplyOrderDetailResponse.GetPermissionApplyOrderDetail_ApplyOrderDetail.GetPermissionApplyOrderDetail_GranteeObjectListItem>();
			for (int i = 0; i < _ctx.Length("GetPermissionApplyOrderDetail.ApplyOrderDetail.GranteeObjectList.Length"); i++) {
				GetPermissionApplyOrderDetailResponse.GetPermissionApplyOrderDetail_ApplyOrderDetail.GetPermissionApplyOrderDetail_GranteeObjectListItem granteeObjectListItem = new GetPermissionApplyOrderDetailResponse.GetPermissionApplyOrderDetail_ApplyOrderDetail.GetPermissionApplyOrderDetail_GranteeObjectListItem();
				granteeObjectListItem.GranteeId = _ctx.StringValue("GetPermissionApplyOrderDetail.ApplyOrderDetail.GranteeObjectList["+ i +"].GranteeId");
				granteeObjectListItem.GranteeName = _ctx.StringValue("GetPermissionApplyOrderDetail.ApplyOrderDetail.GranteeObjectList["+ i +"].GranteeName");
				granteeObjectListItem.GranteeType = _ctx.IntegerValue("GetPermissionApplyOrderDetail.ApplyOrderDetail.GranteeObjectList["+ i +"].GranteeType");
				granteeObjectListItem.GranteeTypeSub = _ctx.IntegerValue("GetPermissionApplyOrderDetail.ApplyOrderDetail.GranteeObjectList["+ i +"].GranteeTypeSub");

				applyOrderDetail_granteeObjectList.Add(granteeObjectListItem);
			}
			applyOrderDetail.GranteeObjectList = applyOrderDetail_granteeObjectList;
			getPermissionApplyOrderDetailResponse.ApplyOrderDetail = applyOrderDetail;
        
			return getPermissionApplyOrderDetailResponse;
        }
    }
}
