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
    public class ListDataCollectionsResponseUnmarshaller
    {
        public static ListDataCollectionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDataCollectionsResponse listDataCollectionsResponse = new ListDataCollectionsResponse();

			listDataCollectionsResponse.HttpResponse = _ctx.HttpResponse;
			listDataCollectionsResponse.RequestId = _ctx.StringValue("ListDataCollections.requestId");
			listDataCollectionsResponse.TotalCount = _ctx.IntegerValue("ListDataCollections.totalCount");

			List<ListDataCollectionsResponse.ListDataCollections_ResultItem> listDataCollectionsResponse_result = new List<ListDataCollectionsResponse.ListDataCollections_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListDataCollections.Result.Length"); i++) {
				ListDataCollectionsResponse.ListDataCollections_ResultItem resultItem = new ListDataCollectionsResponse.ListDataCollections_ResultItem();
				resultItem.Id = _ctx.StringValue("ListDataCollections.Result["+ i +"].id");
				resultItem.Name = _ctx.StringValue("ListDataCollections.Result["+ i +"].name");
				resultItem.Type = _ctx.StringValue("ListDataCollections.Result["+ i +"].type");
				resultItem.Status = _ctx.IntegerValue("ListDataCollections.Result["+ i +"].status");
				resultItem.DataCollectionType = _ctx.StringValue("ListDataCollections.Result["+ i +"].dataCollectionType");
				resultItem.IndustryName = _ctx.StringValue("ListDataCollections.Result["+ i +"].industryName");
				resultItem.Created = _ctx.IntegerValue("ListDataCollections.Result["+ i +"].created");
				resultItem.Updated = _ctx.IntegerValue("ListDataCollections.Result["+ i +"].updated");
				resultItem.SundialId = _ctx.StringValue("ListDataCollections.Result["+ i +"].sundialId");

				listDataCollectionsResponse_result.Add(resultItem);
			}
			listDataCollectionsResponse.Result = listDataCollectionsResponse_result;
        
			return listDataCollectionsResponse;
        }
    }
}
