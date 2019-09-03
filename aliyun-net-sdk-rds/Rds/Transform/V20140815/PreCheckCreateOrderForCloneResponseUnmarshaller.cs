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
    public class PreCheckCreateOrderForCloneResponseUnmarshaller
    {
        public static PreCheckCreateOrderForCloneResponse Unmarshall(UnmarshallerContext context)
        {
			PreCheckCreateOrderForCloneResponse preCheckCreateOrderForCloneResponse = new PreCheckCreateOrderForCloneResponse();

			preCheckCreateOrderForCloneResponse.HttpResponse = context.HttpResponse;
			preCheckCreateOrderForCloneResponse.RequestId = context.StringValue("PreCheckCreateOrderForClone.RequestId");
			preCheckCreateOrderForCloneResponse.PreCheckResult = context.BooleanValue("PreCheckCreateOrderForClone.PreCheckResult");

			List<PreCheckCreateOrderForCloneResponse.PreCheckCreateOrderForClone_FailuresItem> preCheckCreateOrderForCloneResponse_failures = new List<PreCheckCreateOrderForCloneResponse.PreCheckCreateOrderForClone_FailuresItem>();
			for (int i = 0; i < context.Length("PreCheckCreateOrderForClone.Failures.Length"); i++) {
				PreCheckCreateOrderForCloneResponse.PreCheckCreateOrderForClone_FailuresItem failuresItem = new PreCheckCreateOrderForCloneResponse.PreCheckCreateOrderForClone_FailuresItem();
				failuresItem.Code = context.StringValue("PreCheckCreateOrderForClone.Failures["+ i +"].Code");
				failuresItem.Message = context.StringValue("PreCheckCreateOrderForClone.Failures["+ i +"].Message");

				preCheckCreateOrderForCloneResponse_failures.Add(failuresItem);
			}
			preCheckCreateOrderForCloneResponse.Failures = preCheckCreateOrderForCloneResponse_failures;
        
			return preCheckCreateOrderForCloneResponse;
        }
    }
}
