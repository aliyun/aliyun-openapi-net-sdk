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
    public class ListABTestGroupsResponseUnmarshaller
    {
        public static ListABTestGroupsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListABTestGroupsResponse listABTestGroupsResponse = new ListABTestGroupsResponse();

			listABTestGroupsResponse.HttpResponse = _ctx.HttpResponse;
			listABTestGroupsResponse.RequestId = _ctx.StringValue("ListABTestGroups.requestId");

			List<ListABTestGroupsResponse.ListABTestGroups_ResultItem> listABTestGroupsResponse_result = new List<ListABTestGroupsResponse.ListABTestGroups_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListABTestGroups.Result.Length"); i++) {
				ListABTestGroupsResponse.ListABTestGroups_ResultItem resultItem = new ListABTestGroupsResponse.ListABTestGroups_ResultItem();
				resultItem.Id = _ctx.StringValue("ListABTestGroups.Result["+ i +"].id");
				resultItem.Name = _ctx.StringValue("ListABTestGroups.Result["+ i +"].name");
				resultItem.Status = _ctx.IntegerValue("ListABTestGroups.Result["+ i +"].status");
				resultItem.Created = _ctx.IntegerValue("ListABTestGroups.Result["+ i +"].created");
				resultItem.Updated = _ctx.IntegerValue("ListABTestGroups.Result["+ i +"].updated");

				listABTestGroupsResponse_result.Add(resultItem);
			}
			listABTestGroupsResponse.Result = listABTestGroupsResponse_result;
        
			return listABTestGroupsResponse;
        }
    }
}
