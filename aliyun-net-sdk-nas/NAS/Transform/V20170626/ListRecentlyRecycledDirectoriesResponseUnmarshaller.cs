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
using Aliyun.Acs.NAS.Model.V20170626;

namespace Aliyun.Acs.NAS.Transform.V20170626
{
    public class ListRecentlyRecycledDirectoriesResponseUnmarshaller
    {
        public static ListRecentlyRecycledDirectoriesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListRecentlyRecycledDirectoriesResponse listRecentlyRecycledDirectoriesResponse = new ListRecentlyRecycledDirectoriesResponse();

			listRecentlyRecycledDirectoriesResponse.HttpResponse = _ctx.HttpResponse;
			listRecentlyRecycledDirectoriesResponse.RequestId = _ctx.StringValue("ListRecentlyRecycledDirectories.RequestId");
			listRecentlyRecycledDirectoriesResponse.NextToken = _ctx.StringValue("ListRecentlyRecycledDirectories.NextToken");

			List<ListRecentlyRecycledDirectoriesResponse.ListRecentlyRecycledDirectories_Entry> listRecentlyRecycledDirectoriesResponse_entries = new List<ListRecentlyRecycledDirectoriesResponse.ListRecentlyRecycledDirectories_Entry>();
			for (int i = 0; i < _ctx.Length("ListRecentlyRecycledDirectories.Entries.Length"); i++) {
				ListRecentlyRecycledDirectoriesResponse.ListRecentlyRecycledDirectories_Entry entry = new ListRecentlyRecycledDirectoriesResponse.ListRecentlyRecycledDirectories_Entry();
				entry.FileId = _ctx.StringValue("ListRecentlyRecycledDirectories.Entries["+ i +"].FileId");
				entry.Path = _ctx.StringValue("ListRecentlyRecycledDirectories.Entries["+ i +"].Path");
				entry.Name = _ctx.StringValue("ListRecentlyRecycledDirectories.Entries["+ i +"].Name");
				entry.LastDeleteTime = _ctx.StringValue("ListRecentlyRecycledDirectories.Entries["+ i +"].LastDeleteTime");

				listRecentlyRecycledDirectoriesResponse_entries.Add(entry);
			}
			listRecentlyRecycledDirectoriesResponse.Entries = listRecentlyRecycledDirectoriesResponse_entries;
        
			return listRecentlyRecycledDirectoriesResponse;
        }
    }
}
