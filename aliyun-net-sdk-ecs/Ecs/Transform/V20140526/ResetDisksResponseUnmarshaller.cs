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
    public class ResetDisksResponseUnmarshaller
    {
        public static ResetDisksResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ResetDisksResponse resetDisksResponse = new ResetDisksResponse();

			resetDisksResponse.HttpResponse = _ctx.HttpResponse;
			resetDisksResponse.RequestId = _ctx.StringValue("ResetDisks.RequestId");

			List<ResetDisksResponse.ResetDisks_OperationProgress> resetDisksResponse_operationProgressSet = new List<ResetDisksResponse.ResetDisks_OperationProgress>();
			for (int i = 0; i < _ctx.Length("ResetDisks.OperationProgressSet.Length"); i++) {
				ResetDisksResponse.ResetDisks_OperationProgress operationProgress = new ResetDisksResponse.ResetDisks_OperationProgress();
				operationProgress.ErrorMsg = _ctx.StringValue("ResetDisks.OperationProgressSet["+ i +"].ErrorMsg");
				operationProgress.ErrorCode = _ctx.StringValue("ResetDisks.OperationProgressSet["+ i +"].ErrorCode");
				operationProgress.OperationStatus = _ctx.StringValue("ResetDisks.OperationProgressSet["+ i +"].OperationStatus");

				List<ResetDisksResponse.ResetDisks_OperationProgress.ResetDisks_RelatedItem> operationProgress_relatedItemSet = new List<ResetDisksResponse.ResetDisks_OperationProgress.ResetDisks_RelatedItem>();
				for (int j = 0; j < _ctx.Length("ResetDisks.OperationProgressSet["+ i +"].RelatedItemSet.Length"); j++) {
					ResetDisksResponse.ResetDisks_OperationProgress.ResetDisks_RelatedItem relatedItem = new ResetDisksResponse.ResetDisks_OperationProgress.ResetDisks_RelatedItem();
					relatedItem.Name = _ctx.StringValue("ResetDisks.OperationProgressSet["+ i +"].RelatedItemSet["+ j +"].Name");
					relatedItem._Value = _ctx.StringValue("ResetDisks.OperationProgressSet["+ i +"].RelatedItemSet["+ j +"].Value");

					operationProgress_relatedItemSet.Add(relatedItem);
				}
				operationProgress.RelatedItemSet = operationProgress_relatedItemSet;

				resetDisksResponse_operationProgressSet.Add(operationProgress);
			}
			resetDisksResponse.OperationProgressSet = resetDisksResponse_operationProgressSet;
        
			return resetDisksResponse;
        }
    }
}
