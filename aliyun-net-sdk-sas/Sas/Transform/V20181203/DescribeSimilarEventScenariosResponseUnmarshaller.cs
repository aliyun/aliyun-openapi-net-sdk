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
    public class DescribeSimilarEventScenariosResponseUnmarshaller
    {
        public static DescribeSimilarEventScenariosResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSimilarEventScenariosResponse describeSimilarEventScenariosResponse = new DescribeSimilarEventScenariosResponse();

			describeSimilarEventScenariosResponse.HttpResponse = _ctx.HttpResponse;
			describeSimilarEventScenariosResponse.RequestId = _ctx.StringValue("DescribeSimilarEventScenarios.RequestId");

			List<DescribeSimilarEventScenariosResponse.DescribeSimilarEventScenarios_Scenario> describeSimilarEventScenariosResponse_scenarios = new List<DescribeSimilarEventScenariosResponse.DescribeSimilarEventScenarios_Scenario>();
			for (int i = 0; i < _ctx.Length("DescribeSimilarEventScenarios.Scenarios.Length"); i++) {
				DescribeSimilarEventScenariosResponse.DescribeSimilarEventScenarios_Scenario scenario = new DescribeSimilarEventScenariosResponse.DescribeSimilarEventScenarios_Scenario();
				scenario.Code = _ctx.StringValue("DescribeSimilarEventScenarios.Scenarios["+ i +"].Code");

				describeSimilarEventScenariosResponse_scenarios.Add(scenario);
			}
			describeSimilarEventScenariosResponse.Scenarios = describeSimilarEventScenariosResponse_scenarios;
        
			return describeSimilarEventScenariosResponse;
        }
    }
}
