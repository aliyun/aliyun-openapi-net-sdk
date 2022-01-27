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
    public class ListABTestScenesResponseUnmarshaller
    {
        public static ListABTestScenesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListABTestScenesResponse listABTestScenesResponse = new ListABTestScenesResponse();

			listABTestScenesResponse.HttpResponse = _ctx.HttpResponse;
			listABTestScenesResponse.RequestId = _ctx.StringValue("ListABTestScenes.requestId");

			List<ListABTestScenesResponse.ListABTestScenes_ResultItem> listABTestScenesResponse_result = new List<ListABTestScenesResponse.ListABTestScenes_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListABTestScenes.Result.Length"); i++) {
				ListABTestScenesResponse.ListABTestScenes_ResultItem resultItem = new ListABTestScenesResponse.ListABTestScenes_ResultItem();
				resultItem.Id = _ctx.StringValue("ListABTestScenes.Result["+ i +"].id");
				resultItem.Name = _ctx.StringValue("ListABTestScenes.Result["+ i +"].name");
				resultItem.Status = _ctx.IntegerValue("ListABTestScenes.Result["+ i +"].status");
				resultItem.Created = _ctx.IntegerValue("ListABTestScenes.Result["+ i +"].created");
				resultItem.Updated = _ctx.IntegerValue("ListABTestScenes.Result["+ i +"].updated");

				List<string> resultItem_values = new List<string>();
				for (int j = 0; j < _ctx.Length("ListABTestScenes.Result["+ i +"].Values.Length"); j++) {
					resultItem_values.Add(_ctx.StringValue("ListABTestScenes.Result["+ i +"].Values["+ j +"]"));
				}
				resultItem.Values = resultItem_values;

				listABTestScenesResponse_result.Add(resultItem);
			}
			listABTestScenesResponse.Result = listABTestScenesResponse_result;
        
			return listABTestScenesResponse;
        }
    }
}
