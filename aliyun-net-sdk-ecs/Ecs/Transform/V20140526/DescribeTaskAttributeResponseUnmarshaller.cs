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
    public class DescribeTaskAttributeResponseUnmarshaller
    {
        public static DescribeTaskAttributeResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeTaskAttributeResponse describeTaskAttributeResponse = new DescribeTaskAttributeResponse();

			describeTaskAttributeResponse.HttpResponse = context.HttpResponse;
			describeTaskAttributeResponse.RequestId = context.StringValue("DescribeTaskAttribute.RequestId");
			describeTaskAttributeResponse.TaskId = context.StringValue("DescribeTaskAttribute.TaskId");
			describeTaskAttributeResponse.RegionId = context.StringValue("DescribeTaskAttribute.RegionId");
			describeTaskAttributeResponse.TaskAction = context.StringValue("DescribeTaskAttribute.TaskAction");
			describeTaskAttributeResponse.TaskStatus = context.StringValue("DescribeTaskAttribute.TaskStatus");
			describeTaskAttributeResponse.TaskProcess = context.StringValue("DescribeTaskAttribute.TaskProcess");
			describeTaskAttributeResponse.SupportCancel = context.StringValue("DescribeTaskAttribute.SupportCancel");
			describeTaskAttributeResponse.TotalCount = context.IntegerValue("DescribeTaskAttribute.TotalCount");
			describeTaskAttributeResponse.SuccessCount = context.IntegerValue("DescribeTaskAttribute.SuccessCount");
			describeTaskAttributeResponse.FailedCount = context.IntegerValue("DescribeTaskAttribute.FailedCount");
			describeTaskAttributeResponse.CreationTime = context.StringValue("DescribeTaskAttribute.CreationTime");
			describeTaskAttributeResponse.FinishedTime = context.StringValue("DescribeTaskAttribute.FinishedTime");

			List<DescribeTaskAttributeResponse.DescribeTaskAttribute_OperationProgress> describeTaskAttributeResponse_operationProgressSet = new List<DescribeTaskAttributeResponse.DescribeTaskAttribute_OperationProgress>();
			for (int i = 0; i < context.Length("DescribeTaskAttribute.OperationProgressSet.Length"); i++) {
				DescribeTaskAttributeResponse.DescribeTaskAttribute_OperationProgress operationProgress = new DescribeTaskAttributeResponse.DescribeTaskAttribute_OperationProgress();
				operationProgress.OperationStatus = context.StringValue("DescribeTaskAttribute.OperationProgressSet["+ i +"].OperationStatus");
				operationProgress.ErrorCode = context.StringValue("DescribeTaskAttribute.OperationProgressSet["+ i +"].ErrorCode");
				operationProgress.ErrorMsg = context.StringValue("DescribeTaskAttribute.OperationProgressSet["+ i +"].ErrorMsg");

				List<DescribeTaskAttributeResponse.DescribeTaskAttribute_OperationProgress.DescribeTaskAttribute_RelatedItem> operationProgress_relatedItemSet = new List<DescribeTaskAttributeResponse.DescribeTaskAttribute_OperationProgress.DescribeTaskAttribute_RelatedItem>();
				for (int j = 0; j < context.Length("DescribeTaskAttribute.OperationProgressSet["+ i +"].RelatedItemSet.Length"); j++) {
					DescribeTaskAttributeResponse.DescribeTaskAttribute_OperationProgress.DescribeTaskAttribute_RelatedItem relatedItem = new DescribeTaskAttributeResponse.DescribeTaskAttribute_OperationProgress.DescribeTaskAttribute_RelatedItem();
					relatedItem.Name = context.StringValue("DescribeTaskAttribute.OperationProgressSet["+ i +"].RelatedItemSet["+ j +"].Name");
					relatedItem._Value = context.StringValue("DescribeTaskAttribute.OperationProgressSet["+ i +"].RelatedItemSet["+ j +"].Value");

					operationProgress_relatedItemSet.Add(relatedItem);
				}
				operationProgress.RelatedItemSet = operationProgress_relatedItemSet;

				describeTaskAttributeResponse_operationProgressSet.Add(operationProgress);
			}
			describeTaskAttributeResponse.OperationProgressSet = describeTaskAttributeResponse_operationProgressSet;
        
			return describeTaskAttributeResponse;
        }
    }
}
