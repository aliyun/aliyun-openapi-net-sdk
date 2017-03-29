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
using Aliyun.Acs.CloudAPI.Model.V20160714;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.CloudAPI.Transform.V20160714
{
    public class DescribeApiStageDetailResponseUnmarshaller
    {
        public static DescribeApiStageDetailResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeApiStageDetailResponse describeApiStageDetailResponse = new DescribeApiStageDetailResponse();

			describeApiStageDetailResponse.HttpResponse = context.HttpResponse;
			describeApiStageDetailResponse.RequestId = context.StringValue("DescribeApiStageDetail.RequestId");
			describeApiStageDetailResponse.GroupId = context.StringValue("DescribeApiStageDetail.GroupId");
			describeApiStageDetailResponse.StageId = context.StringValue("DescribeApiStageDetail.StageId");
			describeApiStageDetailResponse.StageName = context.StringValue("DescribeApiStageDetail.StageName");
			describeApiStageDetailResponse.Description = context.StringValue("DescribeApiStageDetail.Description");
			describeApiStageDetailResponse.CreatedTime = context.StringValue("DescribeApiStageDetail.CreatedTime");
			describeApiStageDetailResponse.ModifiedTime = context.StringValue("DescribeApiStageDetail.ModifiedTime");

			List<DescribeApiStageDetailResponse.VariableItem> variables = new List<DescribeApiStageDetailResponse.VariableItem>();
			for (int i = 0; i < context.Length("DescribeApiStageDetail.Variables.Length"); i++) {
				DescribeApiStageDetailResponse.VariableItem variableItem = new DescribeApiStageDetailResponse.VariableItem();
				variableItem.VariableName = context.StringValue("DescribeApiStageDetail.Variables["+ i +"].VariableName");
				variableItem.VariableValue = context.StringValue("DescribeApiStageDetail.Variables["+ i +"].VariableValue");

				variables.Add(variableItem);
			}
			describeApiStageDetailResponse.Variables = variables;
        
			return describeApiStageDetailResponse;
        }
    }
}