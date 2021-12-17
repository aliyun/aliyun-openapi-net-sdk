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
    public class ListDirectoriesAndFilesResponseUnmarshaller
    {
        public static ListDirectoriesAndFilesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDirectoriesAndFilesResponse listDirectoriesAndFilesResponse = new ListDirectoriesAndFilesResponse();

			listDirectoriesAndFilesResponse.HttpResponse = _ctx.HttpResponse;
			listDirectoriesAndFilesResponse.NextToken = _ctx.StringValue("ListDirectoriesAndFiles.NextToken");
			listDirectoriesAndFilesResponse.RequestId = _ctx.StringValue("ListDirectoriesAndFiles.RequestId");

			List<ListDirectoriesAndFilesResponse.ListDirectoriesAndFiles_Entry> listDirectoriesAndFilesResponse_entries = new List<ListDirectoriesAndFilesResponse.ListDirectoriesAndFiles_Entry>();
			for (int i = 0; i < _ctx.Length("ListDirectoriesAndFiles.Entries.Length"); i++) {
				ListDirectoriesAndFilesResponse.ListDirectoriesAndFiles_Entry entry = new ListDirectoriesAndFilesResponse.ListDirectoriesAndFiles_Entry();
				entry.Type = _ctx.StringValue("ListDirectoriesAndFiles.Entries["+ i +"].Type");
				entry.HasInfrequentAccessFile = _ctx.BooleanValue("ListDirectoriesAndFiles.Entries["+ i +"].HasInfrequentAccessFile");
				entry.Ctime = _ctx.StringValue("ListDirectoriesAndFiles.Entries["+ i +"].Ctime");
				entry.Mtime = _ctx.StringValue("ListDirectoriesAndFiles.Entries["+ i +"].Mtime");
				entry.Size = _ctx.LongValue("ListDirectoriesAndFiles.Entries["+ i +"].Size");
				entry.StorageType = _ctx.StringValue("ListDirectoriesAndFiles.Entries["+ i +"].StorageType");
				entry.Atime = _ctx.StringValue("ListDirectoriesAndFiles.Entries["+ i +"].Atime");
				entry.Name = _ctx.StringValue("ListDirectoriesAndFiles.Entries["+ i +"].Name");
				entry.RetrieveTime = _ctx.StringValue("ListDirectoriesAndFiles.Entries["+ i +"].RetrieveTime");
				entry.Inode = _ctx.StringValue("ListDirectoriesAndFiles.Entries["+ i +"].Inode");
				entry.FileId = _ctx.StringValue("ListDirectoriesAndFiles.Entries["+ i +"].FileId");

				listDirectoriesAndFilesResponse_entries.Add(entry);
			}
			listDirectoriesAndFilesResponse.Entries = listDirectoriesAndFilesResponse_entries;
        
			return listDirectoriesAndFilesResponse;
        }
    }
}
