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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class PreCheckDBInstanceOperationResponseUnmarshaller
    {
        public static PreCheckDBInstanceOperationResponse Unmarshall(UnmarshallerContext context)
        {
			PreCheckDBInstanceOperationResponse preCheckDBInstanceOperationResponse = new PreCheckDBInstanceOperationResponse();

			preCheckDBInstanceOperationResponse.HttpResponse = context.HttpResponse;
			preCheckDBInstanceOperationResponse.RequestId = context.StringValue("PreCheckDBInstanceOperation.RequestId");
			preCheckDBInstanceOperationResponse.PreCheckResult = context.BooleanValue("PreCheckDBInstanceOperation.PreCheckResult");

			List<PreCheckDBInstanceOperationResponse.PreCheckDBInstanceOperation_FailuresItem> preCheckDBInstanceOperationResponse_failures = new List<PreCheckDBInstanceOperationResponse.PreCheckDBInstanceOperation_FailuresItem>();
			for (int i = 0; i < context.Length("PreCheckDBInstanceOperation.Failures.Length"); i++) {
				PreCheckDBInstanceOperationResponse.PreCheckDBInstanceOperation_FailuresItem failuresItem = new PreCheckDBInstanceOperationResponse.PreCheckDBInstanceOperation_FailuresItem();
				failuresItem.Message = context.StringValue("PreCheckDBInstanceOperation.Failures["+ i +"].Message");
				failuresItem.Code = context.StringValue("PreCheckDBInstanceOperation.Failures["+ i +"].Code");

				preCheckDBInstanceOperationResponse_failures.Add(failuresItem);
			}
			preCheckDBInstanceOperationResponse.Failures = preCheckDBInstanceOperationResponse_failures;
        
			return preCheckDBInstanceOperationResponse;
        }
    }
}
