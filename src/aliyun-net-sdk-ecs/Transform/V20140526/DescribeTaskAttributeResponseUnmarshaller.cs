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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Ecs.Model.V20140526;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeTaskAttributeResponseUnmarshaller
    {
        public static DescribeTaskAttributeResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeTaskAttributeResponse describeTaskAttributeResponse = new DescribeTaskAttributeResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeTaskAttribute.RequestId"),
                TaskId = context.StringValue("DescribeTaskAttribute.TaskId"),
                RegionId = context.StringValue("DescribeTaskAttribute.RegionId"),
                TaskAction = context.StringValue("DescribeTaskAttribute.TaskAction"),
                TaskStatus = context.StringValue("DescribeTaskAttribute.TaskStatus"),
                TaskProcess = context.StringValue("DescribeTaskAttribute.TaskProcess"),
                SupportCancel = context.StringValue("DescribeTaskAttribute.SupportCancel"),
                TotalCount = context.IntegerValue("DescribeTaskAttribute.TotalCount"),
                SuccessCount = context.IntegerValue("DescribeTaskAttribute.SuccessCount"),
                FailedCount = context.IntegerValue("DescribeTaskAttribute.FailedCount"),
                CreationTime = context.StringValue("DescribeTaskAttribute.CreationTime"),
                FinishedTime = context.StringValue("DescribeTaskAttribute.FinishedTime")
            };
            List<DescribeTaskAttributeResponse.OperationProgress> operationProgressSet = new List<DescribeTaskAttributeResponse.OperationProgress>();
			for (int i = 0; i < context.Length("DescribeTaskAttribute.OperationProgressSet.Length"); i++) {
                DescribeTaskAttributeResponse.OperationProgress operationProgress = new DescribeTaskAttributeResponse.OperationProgress()
                {
                    OperationStatus = context.StringValue($"DescribeTaskAttribute.OperationProgressSet[{i}].OperationStatus"),
                    ErrorCode = context.StringValue($"DescribeTaskAttribute.OperationProgressSet[{i}].ErrorCode"),
                    ErrorMsg = context.StringValue($"DescribeTaskAttribute.OperationProgressSet[{i}].ErrorMsg")
                };
                List<DescribeTaskAttributeResponse.OperationProgress.RelatedItem> relatedItemSet = new List<DescribeTaskAttributeResponse.OperationProgress.RelatedItem>();
				for (int j = 0; j < context.Length($"DescribeTaskAttribute.OperationProgressSet[{i}].RelatedItemSet.Length"); j++) {
                    DescribeTaskAttributeResponse.OperationProgress.RelatedItem relatedItem = new DescribeTaskAttributeResponse.OperationProgress.RelatedItem()
                    {
                        Name = context.StringValue($"DescribeTaskAttribute.OperationProgressSet[{i}].RelatedItemSet[{j}].Name"),
                        Value = context.StringValue($"DescribeTaskAttribute.OperationProgressSet[{i}].RelatedItemSet[{j}].Value")
                    };
                    relatedItemSet.Add(relatedItem);
				}
				operationProgress.RelatedItemSet = relatedItemSet;

				operationProgressSet.Add(operationProgress);
			}
			describeTaskAttributeResponse.OperationProgressSet = operationProgressSet;
        
			return describeTaskAttributeResponse;
        }
    }
}