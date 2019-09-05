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
using Aliyun.Acs.CloudAPI.Model.V20160714;

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

			List<DescribeApiStageResponse.DescribeApiStage_VariableItem> describeApiStageResponse_variables = new List<DescribeApiStageResponse.DescribeApiStage_VariableItem>();
			for (int i = 0; i < context.Length("DescribeApiStage.Variables.Length"); i++) {
				DescribeApiStageResponse.DescribeApiStage_VariableItem variableItem = new DescribeApiStageResponse.DescribeApiStage_VariableItem();
				variableItem.VariableName = context.StringValue("DescribeApiStage.Variables["+ i +"].VariableName");
				variableItem.VariableValue = context.StringValue("DescribeApiStage.Variables["+ i +"].VariableValue");
				variableItem.SupportRoute = context.BooleanValue("DescribeApiStage.Variables["+ i +"].SupportRoute");

				DescribeApiStageResponse.DescribeApiStage_VariableItem.DescribeApiStage_StageRouteModel stageRouteModel = new DescribeApiStageResponse.DescribeApiStage_VariableItem.DescribeApiStage_StageRouteModel();
				stageRouteModel.ParameterCatalog = context.StringValue("DescribeApiStage.Variables["+ i +"].StageRouteModel.ParameterCatalog");
				stageRouteModel.ServiceParameterName = context.StringValue("DescribeApiStage.Variables["+ i +"].StageRouteModel.ServiceParameterName");
				stageRouteModel.Location = context.StringValue("DescribeApiStage.Variables["+ i +"].StageRouteModel.Location");
				stageRouteModel.ParameterType = context.StringValue("DescribeApiStage.Variables["+ i +"].StageRouteModel.ParameterType");
				stageRouteModel.RouteMatchSymbol = context.StringValue("DescribeApiStage.Variables["+ i +"].StageRouteModel.RouteMatchSymbol");

				List<DescribeApiStageResponse.DescribeApiStage_VariableItem.DescribeApiStage_StageRouteModel.DescribeApiStage_RouteRuleItem> stageRouteModel_routeRules = new List<DescribeApiStageResponse.DescribeApiStage_VariableItem.DescribeApiStage_StageRouteModel.DescribeApiStage_RouteRuleItem>();
				for (int j = 0; j < context.Length("DescribeApiStage.Variables["+ i +"].StageRouteModel.RouteRules.Length"); j++) {
					DescribeApiStageResponse.DescribeApiStage_VariableItem.DescribeApiStage_StageRouteModel.DescribeApiStage_RouteRuleItem routeRuleItem = new DescribeApiStageResponse.DescribeApiStage_VariableItem.DescribeApiStage_StageRouteModel.DescribeApiStage_RouteRuleItem();
					routeRuleItem.MaxValue = context.LongValue("DescribeApiStage.Variables["+ i +"].StageRouteModel.RouteRules["+ j +"].MaxValue");
					routeRuleItem.MinValue = context.LongValue("DescribeApiStage.Variables["+ i +"].StageRouteModel.RouteRules["+ j +"].MinValue");
					routeRuleItem.ConditionValue = context.StringValue("DescribeApiStage.Variables["+ i +"].StageRouteModel.RouteRules["+ j +"].ConditionValue");
					routeRuleItem.ResultValue = context.StringValue("DescribeApiStage.Variables["+ i +"].StageRouteModel.RouteRules["+ j +"].ResultValue");

					stageRouteModel_routeRules.Add(routeRuleItem);
				}
				stageRouteModel.RouteRules = stageRouteModel_routeRules;
				variableItem.StageRouteModel = stageRouteModel;

				describeApiStageResponse_variables.Add(variableItem);
			}
			describeApiStageResponse.Variables = describeApiStageResponse_variables;
        
			return describeApiStageResponse;
        }
    }
}
