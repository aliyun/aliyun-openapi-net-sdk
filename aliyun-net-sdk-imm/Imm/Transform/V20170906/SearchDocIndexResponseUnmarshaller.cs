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
using Aliyun.Acs.imm.Model.V20170906;

namespace Aliyun.Acs.imm.Transform.V20170906
{
    public class SearchDocIndexResponseUnmarshaller
    {
        public static SearchDocIndexResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SearchDocIndexResponse searchDocIndexResponse = new SearchDocIndexResponse();

			searchDocIndexResponse.HttpResponse = _ctx.HttpResponse;
			searchDocIndexResponse.RequestId = _ctx.StringValue("SearchDocIndex.RequestId");

			List<SearchDocIndexResponse.SearchDocIndex_DocInfosItem> searchDocIndexResponse_docInfos = new List<SearchDocIndexResponse.SearchDocIndex_DocInfosItem>();
			for (int i = 0; i < _ctx.Length("SearchDocIndex.DocInfos.Length"); i++) {
				SearchDocIndexResponse.SearchDocIndex_DocInfosItem docInfosItem = new SearchDocIndexResponse.SearchDocIndex_DocInfosItem();
				docInfosItem.UniqueId = _ctx.StringValue("SearchDocIndex.DocInfos["+ i +"].UniqueId");
				docInfosItem.SrcUri = _ctx.StringValue("SearchDocIndex.DocInfos["+ i +"].SrcUri");
				docInfosItem.Name = _ctx.StringValue("SearchDocIndex.DocInfos["+ i +"].Name");
				docInfosItem.ContentType = _ctx.StringValue("SearchDocIndex.DocInfos["+ i +"].ContentType");
				docInfosItem.LastModified = _ctx.StringValue("SearchDocIndex.DocInfos["+ i +"].LastModified");
				docInfosItem.Size = _ctx.IntegerValue("SearchDocIndex.DocInfos["+ i +"].Size");
				docInfosItem.PageNum = _ctx.IntegerValue("SearchDocIndex.DocInfos["+ i +"].PageNum");
				docInfosItem.CustomKey1 = _ctx.StringValue("SearchDocIndex.DocInfos["+ i +"].CustomKey1");
				docInfosItem.CustomKey2 = _ctx.StringValue("SearchDocIndex.DocInfos["+ i +"].CustomKey2");
				docInfosItem.CustomKey3 = _ctx.StringValue("SearchDocIndex.DocInfos["+ i +"].CustomKey3");
				docInfosItem.CustomKey4 = _ctx.StringValue("SearchDocIndex.DocInfos["+ i +"].CustomKey4");
				docInfosItem.CustomKey5 = _ctx.StringValue("SearchDocIndex.DocInfos["+ i +"].CustomKey5");
				docInfosItem.CustomKey6 = _ctx.StringValue("SearchDocIndex.DocInfos["+ i +"].CustomKey6");

				searchDocIndexResponse_docInfos.Add(docInfosItem);
			}
			searchDocIndexResponse.DocInfos = searchDocIndexResponse_docInfos;
        
			return searchDocIndexResponse;
        }
    }
}
