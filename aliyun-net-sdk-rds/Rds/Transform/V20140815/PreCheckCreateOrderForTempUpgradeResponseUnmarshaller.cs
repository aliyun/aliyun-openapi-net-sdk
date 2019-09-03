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
    public class PreCheckCreateOrderForTempUpgradeResponseUnmarshaller
    {
        public static PreCheckCreateOrderForTempUpgradeResponse Unmarshall(UnmarshallerContext context)
        {
			PreCheckCreateOrderForTempUpgradeResponse preCheckCreateOrderForTempUpgradeResponse = new PreCheckCreateOrderForTempUpgradeResponse();

			preCheckCreateOrderForTempUpgradeResponse.HttpResponse = context.HttpResponse;
			preCheckCreateOrderForTempUpgradeResponse.RequestId = context.StringValue("PreCheckCreateOrderForTempUpgrade.RequestId");
			preCheckCreateOrderForTempUpgradeResponse.PreCheckResult = context.BooleanValue("PreCheckCreateOrderForTempUpgrade.PreCheckResult");

			List<PreCheckCreateOrderForTempUpgradeResponse.PreCheckCreateOrderForTempUpgrade_FailuresItem> preCheckCreateOrderForTempUpgradeResponse_failures = new List<PreCheckCreateOrderForTempUpgradeResponse.PreCheckCreateOrderForTempUpgrade_FailuresItem>();
			for (int i = 0; i < context.Length("PreCheckCreateOrderForTempUpgrade.Failures.Length"); i++) {
				PreCheckCreateOrderForTempUpgradeResponse.PreCheckCreateOrderForTempUpgrade_FailuresItem failuresItem = new PreCheckCreateOrderForTempUpgradeResponse.PreCheckCreateOrderForTempUpgrade_FailuresItem();
				failuresItem.Code = context.StringValue("PreCheckCreateOrderForTempUpgrade.Failures["+ i +"].Code");
				failuresItem.Message = context.StringValue("PreCheckCreateOrderForTempUpgrade.Failures["+ i +"].Message");

				preCheckCreateOrderForTempUpgradeResponse_failures.Add(failuresItem);
			}
			preCheckCreateOrderForTempUpgradeResponse.Failures = preCheckCreateOrderForTempUpgradeResponse_failures;
        
			return preCheckCreateOrderForTempUpgradeResponse;
        }
    }
}
