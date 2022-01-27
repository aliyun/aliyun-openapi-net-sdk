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
    public class ListInterventionDictionariesResponseUnmarshaller
    {
        public static ListInterventionDictionariesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListInterventionDictionariesResponse listInterventionDictionariesResponse = new ListInterventionDictionariesResponse();

			listInterventionDictionariesResponse.HttpResponse = _ctx.HttpResponse;
			listInterventionDictionariesResponse.RequestId = _ctx.StringValue("ListInterventionDictionaries.requestId");
			listInterventionDictionariesResponse.TotalCount = _ctx.IntegerValue("ListInterventionDictionaries.totalCount");

			List<ListInterventionDictionariesResponse.ListInterventionDictionaries_ResultItem> listInterventionDictionariesResponse_result = new List<ListInterventionDictionariesResponse.ListInterventionDictionaries_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListInterventionDictionaries.Result.Length"); i++) {
				ListInterventionDictionariesResponse.ListInterventionDictionaries_ResultItem resultItem = new ListInterventionDictionariesResponse.ListInterventionDictionaries_ResultItem();
				resultItem.Id = _ctx.IntegerValue("ListInterventionDictionaries.Result["+ i +"].id");
				resultItem.Name = _ctx.StringValue("ListInterventionDictionaries.Result["+ i +"].name");
				resultItem.Type = _ctx.StringValue("ListInterventionDictionaries.Result["+ i +"].type");
				resultItem.Analyzer = _ctx.StringValue("ListInterventionDictionaries.Result["+ i +"].analyzer");
				resultItem.Created = _ctx.IntegerValue("ListInterventionDictionaries.Result["+ i +"].created");
				resultItem.Updated = _ctx.IntegerValue("ListInterventionDictionaries.Result["+ i +"].updated");

				listInterventionDictionariesResponse_result.Add(resultItem);
			}
			listInterventionDictionariesResponse.Result = listInterventionDictionariesResponse_result;
        
			return listInterventionDictionariesResponse;
        }
    }
}
