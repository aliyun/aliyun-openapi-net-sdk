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
    public class ListRecycledDirectoriesAndFilesResponseUnmarshaller
    {
        public static ListRecycledDirectoriesAndFilesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListRecycledDirectoriesAndFilesResponse listRecycledDirectoriesAndFilesResponse = new ListRecycledDirectoriesAndFilesResponse();

			listRecycledDirectoriesAndFilesResponse.HttpResponse = _ctx.HttpResponse;
			listRecycledDirectoriesAndFilesResponse.RequestId = _ctx.StringValue("ListRecycledDirectoriesAndFiles.RequestId");
			listRecycledDirectoriesAndFilesResponse.NextToken = _ctx.StringValue("ListRecycledDirectoriesAndFiles.NextToken");

			List<ListRecycledDirectoriesAndFilesResponse.ListRecycledDirectoriesAndFiles_Entry> listRecycledDirectoriesAndFilesResponse_entries = new List<ListRecycledDirectoriesAndFilesResponse.ListRecycledDirectoriesAndFiles_Entry>();
			for (int i = 0; i < _ctx.Length("ListRecycledDirectoriesAndFiles.Entries.Length"); i++) {
				ListRecycledDirectoriesAndFilesResponse.ListRecycledDirectoriesAndFiles_Entry entry = new ListRecycledDirectoriesAndFilesResponse.ListRecycledDirectoriesAndFiles_Entry();
				entry.FileId = _ctx.StringValue("ListRecycledDirectoriesAndFiles.Entries["+ i +"].FileId");
				entry.Type = _ctx.StringValue("ListRecycledDirectoriesAndFiles.Entries["+ i +"].Type");
				entry.Name = _ctx.StringValue("ListRecycledDirectoriesAndFiles.Entries["+ i +"].Name");
				entry.DeleteTime = _ctx.StringValue("ListRecycledDirectoriesAndFiles.Entries["+ i +"].DeleteTime");
				entry.Inode = _ctx.StringValue("ListRecycledDirectoriesAndFiles.Entries["+ i +"].Inode");
				entry.ATime = _ctx.StringValue("ListRecycledDirectoriesAndFiles.Entries["+ i +"].ATime");
				entry.MTime = _ctx.StringValue("ListRecycledDirectoriesAndFiles.Entries["+ i +"].MTime");
				entry.CTime = _ctx.StringValue("ListRecycledDirectoriesAndFiles.Entries["+ i +"].CTime");
				entry.Size = _ctx.LongValue("ListRecycledDirectoriesAndFiles.Entries["+ i +"].Size");

				listRecycledDirectoriesAndFilesResponse_entries.Add(entry);
			}
			listRecycledDirectoriesAndFilesResponse.Entries = listRecycledDirectoriesAndFilesResponse_entries;
        
			return listRecycledDirectoriesAndFilesResponse;
        }
    }
}
