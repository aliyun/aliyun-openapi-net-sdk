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
    public class DescribeApiStageResponseUnmarshaller
    {
        public static DescribeApiStageResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeApiStageResponse describeApiStageResponse = new DescribeApiStageResponse();

			describeApiStageResponse.HttpResponse = context.HttpResponse;
			describeApiStageResponse.RequestId = context.StringValue("DescribeApiStage.RequestId");
			describeApiStageResponse.GroupId = context.StringValue("DescribeApiStage.GroupId");
			describeApiStageResponse.StageId = context.StringValue("DescribeApiStage.StageId");
			describeApiStageResponse.StageName = context.StringValue("DescribeApiStage.StageName");
			describeApiStageResponse.Description = context.StringValue("DescribeApiStage.Description");
			describeApiStageResponse.CreatedTime = context.StringValue("DescribeApiStage.CreatedTime");
			describeApiStageResponse.ModifiedTime = context.StringValue("DescribeApiStage.ModifiedTime");

			List<DescribeApiStageResponse.VariableItem> variables = new List<DescribeApiStageResponse.VariableItem>();
			for (int i = 0; i < context.Length("DescribeApiStage.Variables.Length"); i++) {
				DescribeApiStageResponse.VariableItem variableItem = new DescribeApiStageResponse.VariableItem();
				variableItem.VariableName = context.StringValue("DescribeApiStage.Variables["+ i +"].VariableName");
				variableItem.VariableValue = context.StringValue("DescribeApiStage.Variables["+ i +"].VariableValue");

				variables.Add(variableItem);
			}
			describeApiStageResponse.Variables = variables;
        
			return describeApiStageResponse;
        }
    }
}