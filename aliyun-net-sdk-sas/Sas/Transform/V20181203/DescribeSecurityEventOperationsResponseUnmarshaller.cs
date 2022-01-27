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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class DescribeSecurityEventOperationsResponseUnmarshaller
    {
        public static DescribeSecurityEventOperationsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSecurityEventOperationsResponse describeSecurityEventOperationsResponse = new DescribeSecurityEventOperationsResponse();

			describeSecurityEventOperationsResponse.HttpResponse = _ctx.HttpResponse;
			describeSecurityEventOperationsResponse.RequestId = _ctx.StringValue("DescribeSecurityEventOperations.RequestId");

			List<DescribeSecurityEventOperationsResponse.DescribeSecurityEventOperations_SecurityEventOperation> describeSecurityEventOperationsResponse_securityEventOperationsResponse = new List<DescribeSecurityEventOperationsResponse.DescribeSecurityEventOperations_SecurityEventOperation>();
			for (int i = 0; i < _ctx.Length("DescribeSecurityEventOperations.SecurityEventOperationsResponse.Length"); i++) {
				DescribeSecurityEventOperationsResponse.DescribeSecurityEventOperations_SecurityEventOperation securityEventOperation = new DescribeSecurityEventOperationsResponse.DescribeSecurityEventOperations_SecurityEventOperation();
				securityEventOperation.OperationCode = _ctx.StringValue("DescribeSecurityEventOperations.SecurityEventOperationsResponse["+ i +"].OperationCode");
				securityEventOperation.OperationParams = _ctx.StringValue("DescribeSecurityEventOperations.SecurityEventOperationsResponse["+ i +"].OperationParams");
				securityEventOperation.UserCanOperate = _ctx.BooleanValue("DescribeSecurityEventOperations.SecurityEventOperationsResponse["+ i +"].UserCanOperate");

				List<DescribeSecurityEventOperationsResponse.DescribeSecurityEventOperations_SecurityEventOperation.DescribeSecurityEventOperations_MarkFieldItem> securityEventOperation_markField = new List<DescribeSecurityEventOperationsResponse.DescribeSecurityEventOperations_SecurityEventOperation.DescribeSecurityEventOperations_MarkFieldItem>();
				for (int j = 0; j < _ctx.Length("DescribeSecurityEventOperations.SecurityEventOperationsResponse["+ i +"].MarkField.Length"); j++) {
					DescribeSecurityEventOperationsResponse.DescribeSecurityEventOperations_SecurityEventOperation.DescribeSecurityEventOperations_MarkFieldItem markFieldItem = new DescribeSecurityEventOperationsResponse.DescribeSecurityEventOperations_SecurityEventOperation.DescribeSecurityEventOperations_MarkFieldItem();
					markFieldItem.FiledName = _ctx.StringValue("DescribeSecurityEventOperations.SecurityEventOperationsResponse["+ i +"].MarkField["+ j +"].FiledName");
					markFieldItem.FiledAliasName = _ctx.StringValue("DescribeSecurityEventOperations.SecurityEventOperationsResponse["+ i +"].MarkField["+ j +"].FiledAliasName");
					markFieldItem.MarkMisType = _ctx.StringValue("DescribeSecurityEventOperations.SecurityEventOperationsResponse["+ i +"].MarkField["+ j +"].MarkMisType");
					markFieldItem.MarkMisValue = _ctx.StringValue("DescribeSecurityEventOperations.SecurityEventOperationsResponse["+ i +"].MarkField["+ j +"].MarkMisValue");

					List<string> markFieldItem_supportedMisType = new List<string>();
					for (int k = 0; k < _ctx.Length("DescribeSecurityEventOperations.SecurityEventOperationsResponse["+ i +"].MarkField["+ j +"].SupportedMisType.Length"); k++) {
						markFieldItem_supportedMisType.Add(_ctx.StringValue("DescribeSecurityEventOperations.SecurityEventOperationsResponse["+ i +"].MarkField["+ j +"].SupportedMisType["+ k +"]"));
					}
					markFieldItem.SupportedMisType = markFieldItem_supportedMisType;

					securityEventOperation_markField.Add(markFieldItem);
				}
				securityEventOperation.MarkField = securityEventOperation_markField;

				List<DescribeSecurityEventOperationsResponse.DescribeSecurityEventOperations_SecurityEventOperation.DescribeSecurityEventOperations_SecurityEventOperation1> securityEventOperation_markFieldsSource = new List<DescribeSecurityEventOperationsResponse.DescribeSecurityEventOperations_SecurityEventOperation.DescribeSecurityEventOperations_SecurityEventOperation1>();
				for (int j = 0; j < _ctx.Length("DescribeSecurityEventOperations.SecurityEventOperationsResponse["+ i +"].MarkFieldsSource.Length"); j++) {
					DescribeSecurityEventOperationsResponse.DescribeSecurityEventOperations_SecurityEventOperation.DescribeSecurityEventOperations_SecurityEventOperation1 securityEventOperation1 = new DescribeSecurityEventOperationsResponse.DescribeSecurityEventOperations_SecurityEventOperation.DescribeSecurityEventOperations_SecurityEventOperation1();
					securityEventOperation1.FiledName = _ctx.StringValue("DescribeSecurityEventOperations.SecurityEventOperationsResponse["+ i +"].MarkFieldsSource["+ j +"].FiledName");
					securityEventOperation1.FiledAliasName = _ctx.StringValue("DescribeSecurityEventOperations.SecurityEventOperationsResponse["+ i +"].MarkFieldsSource["+ j +"].FiledAliasName");
					securityEventOperation1.MarkMisValue = _ctx.StringValue("DescribeSecurityEventOperations.SecurityEventOperationsResponse["+ i +"].MarkFieldsSource["+ j +"].MarkMisValue");

					List<string> securityEventOperation1_supportedMisType2 = new List<string>();
					for (int k = 0; k < _ctx.Length("DescribeSecurityEventOperations.SecurityEventOperationsResponse["+ i +"].MarkFieldsSource["+ j +"].SupportedMisType.Length"); k++) {
						securityEventOperation1_supportedMisType2.Add(_ctx.StringValue("DescribeSecurityEventOperations.SecurityEventOperationsResponse["+ i +"].MarkFieldsSource["+ j +"].SupportedMisType["+ k +"]"));
					}
					securityEventOperation1.SupportedMisType2 = securityEventOperation1_supportedMisType2;

					securityEventOperation_markFieldsSource.Add(securityEventOperation1);
				}
				securityEventOperation.MarkFieldsSource = securityEventOperation_markFieldsSource;

				describeSecurityEventOperationsResponse_securityEventOperationsResponse.Add(securityEventOperation);
			}
			describeSecurityEventOperationsResponse.SecurityEventOperationsResponse = describeSecurityEventOperationsResponse_securityEventOperationsResponse;
        
			return describeSecurityEventOperationsResponse;
        }
    }
}
