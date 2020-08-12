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
using Aliyun.Acs.Vcs.Model.V20200515;

namespace Aliyun.Acs.Vcs.Transform.V20200515
{
    public class ListCorpGroupsResponseUnmarshaller
    {
        public static ListCorpGroupsResponse Unmarshall(UnmarshallerContext context)
        {
			ListCorpGroupsResponse listCorpGroupsResponse = new ListCorpGroupsResponse();

			listCorpGroupsResponse.HttpResponse = context.HttpResponse;
			listCorpGroupsResponse.Code = context.StringValue("ListCorpGroups.Code");
			listCorpGroupsResponse.Message = context.StringValue("ListCorpGroups.Message");
			listCorpGroupsResponse.RequestId = context.StringValue("ListCorpGroups.RequestId");

			ListCorpGroupsResponse.ListCorpGroups_Data data = new ListCorpGroupsResponse.ListCorpGroups_Data();
			data.PageNumber = context.LongValue("ListCorpGroups.Data.PageNumber");
			data.PageSize = context.LongValue("ListCorpGroups.Data.PageSize");
			data.TotalCount = context.LongValue("ListCorpGroups.Data.TotalCount");
			data.TotalPage = context.LongValue("ListCorpGroups.Data.TotalPage");

			List<string> data_records = new List<string>();
			for (int i = 0; i < context.Length("ListCorpGroups.Data.Records.Length"); i++) {
				data_records.Add(context.StringValue("ListCorpGroups.Data.Records["+ i +"]"));
			}
			data.Records = data_records;
			listCorpGroupsResponse.Data = data;
        
			return listCorpGroupsResponse;
        }
    }
}
