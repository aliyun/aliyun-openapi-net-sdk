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
using Aliyun.Acs.Cms.Model.V20180308;

namespace Aliyun.Acs.Cms.Transform.V20180308
{
    public class CreateMyGroupAlertBatchResponseUnmarshaller
    {
        public static CreateMyGroupAlertBatchResponse Unmarshall(UnmarshallerContext context)
        {
			CreateMyGroupAlertBatchResponse createMyGroupAlertBatchResponse = new CreateMyGroupAlertBatchResponse();

			createMyGroupAlertBatchResponse.HttpResponse = context.HttpResponse;
			createMyGroupAlertBatchResponse.RequestId = context.StringValue("CreateMyGroupAlertBatch.RequestId");
			createMyGroupAlertBatchResponse.Success = context.BooleanValue("CreateMyGroupAlertBatch.Success");
			createMyGroupAlertBatchResponse.ErrorCode = context.IntegerValue("CreateMyGroupAlertBatch.ErrorCode");
			createMyGroupAlertBatchResponse.ErrorMessage = context.StringValue("CreateMyGroupAlertBatch.ErrorMessage");

			List<CreateMyGroupAlertBatchResponse.CreateMyGroupAlertBatch_AlertResult> createMyGroupAlertBatchResponse_resources = new List<CreateMyGroupAlertBatchResponse.CreateMyGroupAlertBatch_AlertResult>();
			for (int i = 0; i < context.Length("CreateMyGroupAlertBatch.Resources.Length"); i++) {
				CreateMyGroupAlertBatchResponse.CreateMyGroupAlertBatch_AlertResult alertResult = new CreateMyGroupAlertBatchResponse.CreateMyGroupAlertBatch_AlertResult();
				alertResult.AlertName = context.StringValue("CreateMyGroupAlertBatch.Resources["+ i +"].AlertName");
				alertResult.DisplayName = context.StringValue("CreateMyGroupAlertBatch.Resources["+ i +"].DisplayName");
				alertResult.MetricNamespace = context.StringValue("CreateMyGroupAlertBatch.Resources["+ i +"].MetricNamespace");
				alertResult.MetricName = context.StringValue("CreateMyGroupAlertBatch.Resources["+ i +"].MetricName");
				alertResult.Message = context.StringValue("CreateMyGroupAlertBatch.Resources["+ i +"].Message");
				alertResult.Code = context.IntegerValue("CreateMyGroupAlertBatch.Resources["+ i +"].Code");
				alertResult.Success = context.BooleanValue("CreateMyGroupAlertBatch.Resources["+ i +"].Success");
				alertResult.GroupId = context.LongValue("CreateMyGroupAlertBatch.Resources["+ i +"].GroupId");

				createMyGroupAlertBatchResponse_resources.Add(alertResult);
			}
			createMyGroupAlertBatchResponse.Resources = createMyGroupAlertBatchResponse_resources;
        
			return createMyGroupAlertBatchResponse;
        }
    }
}
