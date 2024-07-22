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
    public class ListDictsResponseUnmarshaller
    {
        public static ListDictsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDictsResponse listDictsResponse = new ListDictsResponse();

			listDictsResponse.HttpResponse = _ctx.HttpResponse;
			listDictsResponse.RequestId = _ctx.StringValue("ListDicts.RequestId");

			ListDictsResponse.ListDicts_Headers headers = new ListDictsResponse.ListDicts_Headers();
			headers.XTotalCount = _ctx.IntegerValue("ListDicts.Headers.X-Total-Count");
			listDictsResponse.Headers = headers;

			List<ListDictsResponse.ListDicts_ResultItem> listDictsResponse_result = new List<ListDictsResponse.ListDicts_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListDicts.Result.Length"); i++) {
				ListDictsResponse.ListDicts_ResultItem resultItem = new ListDictsResponse.ListDicts_ResultItem();
				resultItem.FileSize = _ctx.LongValue("ListDicts.Result["+ i +"].fileSize");
				resultItem.DownloadUrl = _ctx.StringValue("ListDicts.Result["+ i +"].downloadUrl");
				resultItem.SourceType = _ctx.StringValue("ListDicts.Result["+ i +"].sourceType");
				resultItem.Type = _ctx.StringValue("ListDicts.Result["+ i +"].type");
				resultItem.Name = _ctx.StringValue("ListDicts.Result["+ i +"].name");

				listDictsResponse_result.Add(resultItem);
			}
			listDictsResponse.Result = listDictsResponse_result;
        
			return listDictsResponse;
        }
    }
}
