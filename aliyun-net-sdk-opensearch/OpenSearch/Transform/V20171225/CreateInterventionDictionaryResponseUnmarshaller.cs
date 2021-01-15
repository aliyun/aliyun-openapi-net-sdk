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
using Aliyun.Acs.OpenSearch.Model.V20171225;

namespace Aliyun.Acs.OpenSearch.Transform.V20171225
{
    public class CreateInterventionDictionaryResponseUnmarshaller
    {
        public static CreateInterventionDictionaryResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateInterventionDictionaryResponse createInterventionDictionaryResponse = new CreateInterventionDictionaryResponse();

			createInterventionDictionaryResponse.HttpResponse = _ctx.HttpResponse;
			createInterventionDictionaryResponse.RequestId = _ctx.StringValue("CreateInterventionDictionary.requestId");

			CreateInterventionDictionaryResponse.CreateInterventionDictionary_Result result = new CreateInterventionDictionaryResponse.CreateInterventionDictionary_Result();
			result.Name = _ctx.StringValue("CreateInterventionDictionary.Result.name");
			result.Type = _ctx.StringValue("CreateInterventionDictionary.Result.type");
			result.Analyzer = _ctx.StringValue("CreateInterventionDictionary.Result.analyzer");
			result.Created = _ctx.StringValue("CreateInterventionDictionary.Result.created");
			result.Updated = _ctx.StringValue("CreateInterventionDictionary.Result.updated");
			createInterventionDictionaryResponse.Result = result;
        
			return createInterventionDictionaryResponse;
        }
    }
}
