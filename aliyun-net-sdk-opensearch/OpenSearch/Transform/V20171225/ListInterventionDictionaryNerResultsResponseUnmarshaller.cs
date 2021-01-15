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
    public class ListInterventionDictionaryNerResultsResponseUnmarshaller
    {
        public static ListInterventionDictionaryNerResultsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListInterventionDictionaryNerResultsResponse listInterventionDictionaryNerResultsResponse = new ListInterventionDictionaryNerResultsResponse();

			listInterventionDictionaryNerResultsResponse.HttpResponse = _ctx.HttpResponse;
			listInterventionDictionaryNerResultsResponse.RequestId = _ctx.StringValue("ListInterventionDictionaryNerResults.requestId");

			List<ListInterventionDictionaryNerResultsResponse.ListInterventionDictionaryNerResults_NerItem> listInterventionDictionaryNerResultsResponse_result = new List<ListInterventionDictionaryNerResultsResponse.ListInterventionDictionaryNerResults_NerItem>();
			for (int i = 0; i < _ctx.Length("ListInterventionDictionaryNerResults.Result.Length"); i++) {
				ListInterventionDictionaryNerResultsResponse.ListInterventionDictionaryNerResults_NerItem nerItem = new ListInterventionDictionaryNerResultsResponse.ListInterventionDictionaryNerResults_NerItem();
				nerItem.Tag = _ctx.StringValue("ListInterventionDictionaryNerResults.Result["+ i +"].tag");
				nerItem.TagLabel = _ctx.StringValue("ListInterventionDictionaryNerResults.Result["+ i +"].tagLabel");
				nerItem.Token = _ctx.StringValue("ListInterventionDictionaryNerResults.Result["+ i +"].token");
				nerItem.Order = _ctx.IntegerValue("ListInterventionDictionaryNerResults.Result["+ i +"].order");

				listInterventionDictionaryNerResultsResponse_result.Add(nerItem);
			}
			listInterventionDictionaryNerResultsResponse.Result = listInterventionDictionaryNerResultsResponse_result;
        
			return listInterventionDictionaryNerResultsResponse;
        }
    }
}
