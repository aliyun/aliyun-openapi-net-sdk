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
    public class ListDataStreamsResponseUnmarshaller
    {
        public static ListDataStreamsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDataStreamsResponse listDataStreamsResponse = new ListDataStreamsResponse();

			listDataStreamsResponse.HttpResponse = _ctx.HttpResponse;
			listDataStreamsResponse.RequestId = _ctx.StringValue("ListDataStreams.RequestId");

			ListDataStreamsResponse.ListDataStreams_Headers headers = new ListDataStreamsResponse.ListDataStreams_Headers();
			headers.XManagedStorageSize = _ctx.LongValue("ListDataStreams.Headers.X-Managed-StorageSize");
			headers.XManagedCount = _ctx.IntegerValue("ListDataStreams.Headers.X-Managed-Count");
			listDataStreamsResponse.Headers = headers;

			List<ListDataStreamsResponse.ListDataStreams_ResultItem> listDataStreamsResponse_result = new List<ListDataStreamsResponse.ListDataStreams_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListDataStreams.Result.Length"); i++) {
				ListDataStreamsResponse.ListDataStreams_ResultItem resultItem = new ListDataStreamsResponse.ListDataStreams_ResultItem();
				resultItem.TotalStorageSize = _ctx.LongValue("ListDataStreams.Result["+ i +"].totalStorageSize");
				resultItem.IndexTemplateName = _ctx.StringValue("ListDataStreams.Result["+ i +"].indexTemplateName");
				resultItem.IlmPolicyName = _ctx.StringValue("ListDataStreams.Result["+ i +"].ilmPolicyName");
				resultItem.Name = _ctx.StringValue("ListDataStreams.Result["+ i +"].name");
				resultItem.Health = _ctx.StringValue("ListDataStreams.Result["+ i +"].health");
				resultItem.ManagedStorageSize = _ctx.LongValue("ListDataStreams.Result["+ i +"].managedStorageSize");

				List<ListDataStreamsResponse.ListDataStreams_ResultItem.ListDataStreams_IndicesItem> resultItem_indices = new List<ListDataStreamsResponse.ListDataStreams_ResultItem.ListDataStreams_IndicesItem>();
				for (int j = 0; j < _ctx.Length("ListDataStreams.Result["+ i +"].Indices.Length"); j++) {
					ListDataStreamsResponse.ListDataStreams_ResultItem.ListDataStreams_IndicesItem indicesItem = new ListDataStreamsResponse.ListDataStreams_ResultItem.ListDataStreams_IndicesItem();
					indicesItem.IsManaged = _ctx.BooleanValue("ListDataStreams.Result["+ i +"].Indices["+ j +"].isManaged");
					indicesItem.CreateTime = _ctx.StringValue("ListDataStreams.Result["+ i +"].Indices["+ j +"].createTime");
					indicesItem.Size = _ctx.LongValue("ListDataStreams.Result["+ i +"].Indices["+ j +"].size");
					indicesItem.ManagedStatus = _ctx.StringValue("ListDataStreams.Result["+ i +"].Indices["+ j +"].managedStatus");
					indicesItem.Name = _ctx.StringValue("ListDataStreams.Result["+ i +"].Indices["+ j +"].name");
					indicesItem.Health = _ctx.StringValue("ListDataStreams.Result["+ i +"].Indices["+ j +"].health");

					resultItem_indices.Add(indicesItem);
				}
				resultItem.Indices = resultItem_indices;

				listDataStreamsResponse_result.Add(resultItem);
			}
			listDataStreamsResponse.Result = listDataStreamsResponse_result;
        
			return listDataStreamsResponse;
        }
    }
}
