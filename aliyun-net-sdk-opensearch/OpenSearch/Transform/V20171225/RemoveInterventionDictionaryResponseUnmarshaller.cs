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
    public class RemoveInterventionDictionaryResponseUnmarshaller
    {
        public static RemoveInterventionDictionaryResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RemoveInterventionDictionaryResponse removeInterventionDictionaryResponse = new RemoveInterventionDictionaryResponse();

			removeInterventionDictionaryResponse.HttpResponse = _ctx.HttpResponse;
			removeInterventionDictionaryResponse.RequestId = _ctx.StringValue("RemoveInterventionDictionary.requestId");

			RemoveInterventionDictionaryResponse.RemoveInterventionDictionary_Result result = new RemoveInterventionDictionaryResponse.RemoveInterventionDictionary_Result();
			result.Name = _ctx.StringValue("RemoveInterventionDictionary.Result.name");
			result.Type = _ctx.StringValue("RemoveInterventionDictionary.Result.type");
			result.Analyzer = _ctx.StringValue("RemoveInterventionDictionary.Result.analyzer");
			result.Created = _ctx.StringValue("RemoveInterventionDictionary.Result.created");
			result.Updated = _ctx.StringValue("RemoveInterventionDictionary.Result.updated");
			removeInterventionDictionaryResponse.Result = result;
        
			return removeInterventionDictionaryResponse;
        }
    }
}
