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
using Aliyun.Acs.Yundun_ds.Model.V20190103;

namespace Aliyun.Acs.Yundun_ds.Transform.V20190103
{
    public class DescribeConditionsResponseUnmarshaller
    {
        public static DescribeConditionsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeConditionsResponse describeConditionsResponse = new DescribeConditionsResponse();

			describeConditionsResponse.HttpResponse = context.HttpResponse;
			describeConditionsResponse.RequestId = context.StringValue("DescribeConditions.RequestId");

			DescribeConditionsResponse.DescribeConditions_Condition condition = new DescribeConditionsResponse.DescribeConditions_Condition();

			List<DescribeConditionsResponse.DescribeConditions_Condition.DescribeConditions_RiskLevel> condition_riskLevelList = new List<DescribeConditionsResponse.DescribeConditions_Condition.DescribeConditions_RiskLevel>();
			for (int i = 0; i < context.Length("DescribeConditions.Condition.RiskLevelList.Length"); i++) {
				DescribeConditionsResponse.DescribeConditions_Condition.DescribeConditions_RiskLevel riskLevel = new DescribeConditionsResponse.DescribeConditions_Condition.DescribeConditions_RiskLevel();
				riskLevel.Id = context.LongValue("DescribeConditions.Condition.RiskLevelList["+ i +"].Id");
				riskLevel.Name = context.StringValue("DescribeConditions.Condition.RiskLevelList["+ i +"].Name");
				riskLevel.Defaulted = context.BooleanValue("DescribeConditions.Condition.RiskLevelList["+ i +"].Defaulted");
				riskLevel.Sensitive = context.BooleanValue("DescribeConditions.Condition.RiskLevelList["+ i +"].Sensitive");

				condition_riskLevelList.Add(riskLevel);
			}
			condition.RiskLevelList = condition_riskLevelList;

			List<DescribeConditionsResponse.DescribeConditions_Condition.DescribeConditions_Rule> condition_ruleList = new List<DescribeConditionsResponse.DescribeConditions_Condition.DescribeConditions_Rule>();
			for (int i = 0; i < context.Length("DescribeConditions.Condition.RuleList.Length"); i++) {
				DescribeConditionsResponse.DescribeConditions_Condition.DescribeConditions_Rule rule = new DescribeConditionsResponse.DescribeConditions_Condition.DescribeConditions_Rule();
				rule.Id = context.LongValue("DescribeConditions.Condition.RuleList["+ i +"].Id");
				rule.Name = context.StringValue("DescribeConditions.Condition.RuleList["+ i +"].Name");

				condition_ruleList.Add(rule);
			}
			condition.RuleList = condition_ruleList;

			List<DescribeConditionsResponse.DescribeConditions_Condition.DescribeConditions_Range> condition_rangeList = new List<DescribeConditionsResponse.DescribeConditions_Condition.DescribeConditions_Range>();
			for (int i = 0; i < context.Length("DescribeConditions.Condition.RangeList.Length"); i++) {
				DescribeConditionsResponse.DescribeConditions_Condition.DescribeConditions_Range range = new DescribeConditionsResponse.DescribeConditions_Condition.DescribeConditions_Range();
				range.Id = context.LongValue("DescribeConditions.Condition.RangeList["+ i +"].Id");
				range.Name = context.StringValue("DescribeConditions.Condition.RangeList["+ i +"].Name");

				condition_rangeList.Add(range);
			}
			condition.RangeList = condition_rangeList;

			List<DescribeConditionsResponse.DescribeConditions_Condition.DescribeConditions_EventType> condition_eventTypeList = new List<DescribeConditionsResponse.DescribeConditions_Condition.DescribeConditions_EventType>();
			for (int i = 0; i < context.Length("DescribeConditions.Condition.EventTypeList.Length"); i++) {
				DescribeConditionsResponse.DescribeConditions_Condition.DescribeConditions_EventType eventType = new DescribeConditionsResponse.DescribeConditions_Condition.DescribeConditions_EventType();
				eventType.Id = context.LongValue("DescribeConditions.Condition.EventTypeList["+ i +"].Id");
				eventType.Name = context.StringValue("DescribeConditions.Condition.EventTypeList["+ i +"].Name");
				eventType.Code = context.StringValue("DescribeConditions.Condition.EventTypeList["+ i +"].Code");

				condition_eventTypeList.Add(eventType);
			}
			condition.EventTypeList = condition_eventTypeList;

			List<DescribeConditionsResponse.DescribeConditions_Condition.DescribeConditions_Status> condition_statusList = new List<DescribeConditionsResponse.DescribeConditions_Condition.DescribeConditions_Status>();
			for (int i = 0; i < context.Length("DescribeConditions.Condition.StatusList.Length"); i++) {
				DescribeConditionsResponse.DescribeConditions_Condition.DescribeConditions_Status status = new DescribeConditionsResponse.DescribeConditions_Condition.DescribeConditions_Status();
				status.Id = context.LongValue("DescribeConditions.Condition.StatusList["+ i +"].Id");
				status.Name = context.StringValue("DescribeConditions.Condition.StatusList["+ i +"].Name");

				condition_statusList.Add(status);
			}
			condition.StatusList = condition_statusList;

			List<DescribeConditionsResponse.DescribeConditions_Condition.DescribeConditions_DataType> condition_dataTypeList = new List<DescribeConditionsResponse.DescribeConditions_Condition.DescribeConditions_DataType>();
			for (int i = 0; i < context.Length("DescribeConditions.Condition.DataTypeList.Length"); i++) {
				DescribeConditionsResponse.DescribeConditions_Condition.DescribeConditions_DataType dataType = new DescribeConditionsResponse.DescribeConditions_Condition.DescribeConditions_DataType();
				dataType.Id = context.LongValue("DescribeConditions.Condition.DataTypeList["+ i +"].Id");
				dataType.Name = context.StringValue("DescribeConditions.Condition.DataTypeList["+ i +"].Name");

				condition_dataTypeList.Add(dataType);
			}
			condition.DataTypeList = condition_dataTypeList;

			List<DescribeConditionsResponse.DescribeConditions_Condition.DescribeConditions_Operation> condition_operationList = new List<DescribeConditionsResponse.DescribeConditions_Condition.DescribeConditions_Operation>();
			for (int i = 0; i < context.Length("DescribeConditions.Condition.OperationList.Length"); i++) {
				DescribeConditionsResponse.DescribeConditions_Condition.DescribeConditions_Operation operation = new DescribeConditionsResponse.DescribeConditions_Condition.DescribeConditions_Operation();
				operation.Id = context.LongValue("DescribeConditions.Condition.OperationList["+ i +"].Id");
				operation.Name = context.StringValue("DescribeConditions.Condition.OperationList["+ i +"].Name");

				condition_operationList.Add(operation);
			}
			condition.OperationList = condition_operationList;

			List<DescribeConditionsResponse.DescribeConditions_Condition.DescribeConditions_Product> condition_productList = new List<DescribeConditionsResponse.DescribeConditions_Condition.DescribeConditions_Product>();
			for (int i = 0; i < context.Length("DescribeConditions.Condition.ProductList.Length"); i++) {
				DescribeConditionsResponse.DescribeConditions_Condition.DescribeConditions_Product product = new DescribeConditionsResponse.DescribeConditions_Condition.DescribeConditions_Product();
				product.Id = context.LongValue("DescribeConditions.Condition.ProductList["+ i +"].Id");
				product.Name = context.StringValue("DescribeConditions.Condition.ProductList["+ i +"].Name");

				condition_productList.Add(product);
			}
			condition.ProductList = condition_productList;

			List<DescribeConditionsResponse.DescribeConditions_Condition.DescribeConditions_TransferProduct> condition_transferProductList = new List<DescribeConditionsResponse.DescribeConditions_Condition.DescribeConditions_TransferProduct>();
			for (int i = 0; i < context.Length("DescribeConditions.Condition.TransferProductList.Length"); i++) {
				DescribeConditionsResponse.DescribeConditions_Condition.DescribeConditions_TransferProduct transferProduct = new DescribeConditionsResponse.DescribeConditions_Condition.DescribeConditions_TransferProduct();
				transferProduct.Code = context.StringValue("DescribeConditions.Condition.TransferProductList["+ i +"].Code");
				transferProduct.Status = context.IntegerValue("DescribeConditions.Condition.TransferProductList["+ i +"].Status");

				condition_transferProductList.Add(transferProduct);
			}
			condition.TransferProductList = condition_transferProductList;

			List<DescribeConditionsResponse.DescribeConditions_Condition.DescribeConditions_RuleCategory> condition_ruleCategoryList = new List<DescribeConditionsResponse.DescribeConditions_Condition.DescribeConditions_RuleCategory>();
			for (int i = 0; i < context.Length("DescribeConditions.Condition.RuleCategoryList.Length"); i++) {
				DescribeConditionsResponse.DescribeConditions_Condition.DescribeConditions_RuleCategory ruleCategory = new DescribeConditionsResponse.DescribeConditions_Condition.DescribeConditions_RuleCategory();
				ruleCategory.Id = context.LongValue("DescribeConditions.Condition.RuleCategoryList["+ i +"].Id");
				ruleCategory.Name = context.StringValue("DescribeConditions.Condition.RuleCategoryList["+ i +"].Name");

				condition_ruleCategoryList.Add(ruleCategory);
			}
			condition.RuleCategoryList = condition_ruleCategoryList;
			describeConditionsResponse.Condition = condition;
        
			return describeConditionsResponse;
        }
    }
}
