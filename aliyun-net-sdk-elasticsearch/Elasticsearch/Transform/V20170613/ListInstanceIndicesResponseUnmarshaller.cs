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
using Aliyun.Acs.elasticsearch.Model.V20170613;

namespace Aliyun.Acs.elasticsearch.Transform.V20170613
{
    public class ListInstanceIndicesResponseUnmarshaller
    {
        public static ListInstanceIndicesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListInstanceIndicesResponse listInstanceIndicesResponse = new ListInstanceIndicesResponse();

			listInstanceIndicesResponse.HttpResponse = _ctx.HttpResponse;
			listInstanceIndicesResponse.RequestId = _ctx.StringValue("ListInstanceIndices.RequestId");

			ListInstanceIndicesResponse.ListInstanceIndices_Headers headers = new ListInstanceIndicesResponse.ListInstanceIndices_Headers();
			headers.XManagedCount = _ctx.IntegerValue("ListInstanceIndices.Headers.X-Managed-Count");
			headers.XManagedStorageSize = _ctx.LongValue("ListInstanceIndices.Headers.X-Managed-StorageSize");
			listInstanceIndicesResponse.Headers = headers;

			List<ListInstanceIndicesResponse.ListInstanceIndices_ResultItem> listInstanceIndicesResponse_result = new List<ListInstanceIndicesResponse.ListInstanceIndices_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListInstanceIndices.Result.Length"); i++) {
				ListInstanceIndicesResponse.ListInstanceIndices_ResultItem resultItem = new ListInstanceIndicesResponse.ListInstanceIndices_ResultItem();
				resultItem.Name = _ctx.StringValue("ListInstanceIndices.Result["+ i +"].name");
				resultItem.Health = _ctx.StringValue("ListInstanceIndices.Result["+ i +"].health");
				resultItem.Size = _ctx.LongValue("ListInstanceIndices.Result["+ i +"].size");
				resultItem.CreateTime = _ctx.StringValue("ListInstanceIndices.Result["+ i +"].createTime");
				resultItem.IsManaged = _ctx.StringValue("ListInstanceIndices.Result["+ i +"].isManaged");
				resultItem.ManagedStatus = _ctx.StringValue("ListInstanceIndices.Result["+ i +"].managedStatus");

				listInstanceIndicesResponse_result.Add(resultItem);
			}
			listInstanceIndicesResponse.Result = listInstanceIndicesResponse_result;
        
			return listInstanceIndicesResponse;
        }
    }
}
