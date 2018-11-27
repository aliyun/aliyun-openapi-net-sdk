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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.imm.Model.V20170906;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.imm.Transform.V20170906
{
    public class SearchDocIndexResponseUnmarshaller
    {
        public static SearchDocIndexResponse Unmarshall(UnmarshallerContext context)
        {
			SearchDocIndexResponse searchDocIndexResponse = new SearchDocIndexResponse();

			searchDocIndexResponse.HttpResponse = context.HttpResponse;
			searchDocIndexResponse.RequestId = context.StringValue("SearchDocIndex.RequestId");

			List<SearchDocIndexResponse.SearchDocIndex_DocInfosItem> searchDocIndexResponse_docInfos = new List<SearchDocIndexResponse.SearchDocIndex_DocInfosItem>();
			for (int i = 0; i < context.Length("SearchDocIndex.DocInfos.Length"); i++) {
				SearchDocIndexResponse.SearchDocIndex_DocInfosItem docInfosItem = new SearchDocIndexResponse.SearchDocIndex_DocInfosItem();
				docInfosItem.UniqueId = context.StringValue("SearchDocIndex.DocInfos["+ i +"].UniqueId");
				docInfosItem.SrcUri = context.StringValue("SearchDocIndex.DocInfos["+ i +"].SrcUri");
				docInfosItem.Name = context.StringValue("SearchDocIndex.DocInfos["+ i +"].Name");
				docInfosItem.ContentType = context.StringValue("SearchDocIndex.DocInfos["+ i +"].ContentType");
				docInfosItem.LastModified = context.StringValue("SearchDocIndex.DocInfos["+ i +"].LastModified");
				docInfosItem.Size = context.IntegerValue("SearchDocIndex.DocInfos["+ i +"].Size");
				docInfosItem.PageNum = context.IntegerValue("SearchDocIndex.DocInfos["+ i +"].PageNum");
				docInfosItem.CustomKey1 = context.StringValue("SearchDocIndex.DocInfos["+ i +"].CustomKey1");
				docInfosItem.CustomKey2 = context.StringValue("SearchDocIndex.DocInfos["+ i +"].CustomKey2");
				docInfosItem.CustomKey3 = context.StringValue("SearchDocIndex.DocInfos["+ i +"].CustomKey3");
				docInfosItem.CustomKey4 = context.StringValue("SearchDocIndex.DocInfos["+ i +"].CustomKey4");
				docInfosItem.CustomKey5 = context.StringValue("SearchDocIndex.DocInfos["+ i +"].CustomKey5");
				docInfosItem.CustomKey6 = context.StringValue("SearchDocIndex.DocInfos["+ i +"].CustomKey6");

				searchDocIndexResponse_docInfos.Add(docInfosItem);
			}
			searchDocIndexResponse.DocInfos = searchDocIndexResponse_docInfos;
        
			return searchDocIndexResponse;
        }
    }
}