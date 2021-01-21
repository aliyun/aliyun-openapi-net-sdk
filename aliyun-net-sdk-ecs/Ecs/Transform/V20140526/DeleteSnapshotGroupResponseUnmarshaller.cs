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
using Aliyun.Acs.Ecs.Model.V20140526;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DeleteSnapshotGroupResponseUnmarshaller
    {
        public static DeleteSnapshotGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DeleteSnapshotGroupResponse deleteSnapshotGroupResponse = new DeleteSnapshotGroupResponse();

			deleteSnapshotGroupResponse.HttpResponse = _ctx.HttpResponse;
			deleteSnapshotGroupResponse.RequestId = _ctx.StringValue("DeleteSnapshotGroup.RequestId");

			List<DeleteSnapshotGroupResponse.DeleteSnapshotGroup_OperationProgress> deleteSnapshotGroupResponse_operationProgressSet = new List<DeleteSnapshotGroupResponse.DeleteSnapshotGroup_OperationProgress>();
			for (int i = 0; i < _ctx.Length("DeleteSnapshotGroup.OperationProgressSet.Length"); i++) {
				DeleteSnapshotGroupResponse.DeleteSnapshotGroup_OperationProgress operationProgress = new DeleteSnapshotGroupResponse.DeleteSnapshotGroup_OperationProgress();
				operationProgress.OperationStatus = _ctx.StringValue("DeleteSnapshotGroup.OperationProgressSet["+ i +"].OperationStatus");
				operationProgress.ErrorCode = _ctx.StringValue("DeleteSnapshotGroup.OperationProgressSet["+ i +"].ErrorCode");
				operationProgress.ErrorMsg = _ctx.StringValue("DeleteSnapshotGroup.OperationProgressSet["+ i +"].ErrorMsg");

				List<DeleteSnapshotGroupResponse.DeleteSnapshotGroup_OperationProgress.DeleteSnapshotGroup_RelatedItem> operationProgress_relatedItemSet = new List<DeleteSnapshotGroupResponse.DeleteSnapshotGroup_OperationProgress.DeleteSnapshotGroup_RelatedItem>();
				for (int j = 0; j < _ctx.Length("DeleteSnapshotGroup.OperationProgressSet["+ i +"].RelatedItemSet.Length"); j++) {
					DeleteSnapshotGroupResponse.DeleteSnapshotGroup_OperationProgress.DeleteSnapshotGroup_RelatedItem relatedItem = new DeleteSnapshotGroupResponse.DeleteSnapshotGroup_OperationProgress.DeleteSnapshotGroup_RelatedItem();
					relatedItem.Name = _ctx.StringValue("DeleteSnapshotGroup.OperationProgressSet["+ i +"].RelatedItemSet["+ j +"].Name");
					relatedItem._Value = _ctx.StringValue("DeleteSnapshotGroup.OperationProgressSet["+ i +"].RelatedItemSet["+ j +"].Value");

					operationProgress_relatedItemSet.Add(relatedItem);
				}
				operationProgress.RelatedItemSet = operationProgress_relatedItemSet;

				deleteSnapshotGroupResponse_operationProgressSet.Add(operationProgress);
			}
			deleteSnapshotGroupResponse.OperationProgressSet = deleteSnapshotGroupResponse_operationProgressSet;
        
			return deleteSnapshotGroupResponse;
        }
    }
}
