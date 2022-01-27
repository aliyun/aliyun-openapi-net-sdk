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
using Aliyun.Acs.dataworks_public.Model.V20200518;

namespace Aliyun.Acs.dataworks_public.Transform.V20200518
{
    public class ListDataServiceFoldersResponseUnmarshaller
    {
        public static ListDataServiceFoldersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDataServiceFoldersResponse listDataServiceFoldersResponse = new ListDataServiceFoldersResponse();

			listDataServiceFoldersResponse.HttpResponse = _ctx.HttpResponse;
			listDataServiceFoldersResponse.RequestId = _ctx.StringValue("ListDataServiceFolders.RequestId");

			ListDataServiceFoldersResponse.ListDataServiceFolders_FolderPagingResult folderPagingResult = new ListDataServiceFoldersResponse.ListDataServiceFolders_FolderPagingResult();
			folderPagingResult.PageNumber = _ctx.IntegerValue("ListDataServiceFolders.FolderPagingResult.PageNumber");
			folderPagingResult.PageSize = _ctx.IntegerValue("ListDataServiceFolders.FolderPagingResult.PageSize");
			folderPagingResult.TotalCount = _ctx.IntegerValue("ListDataServiceFolders.FolderPagingResult.TotalCount");

			List<ListDataServiceFoldersResponse.ListDataServiceFolders_FolderPagingResult.ListDataServiceFolders_Folder> folderPagingResult_folders = new List<ListDataServiceFoldersResponse.ListDataServiceFolders_FolderPagingResult.ListDataServiceFolders_Folder>();
			for (int i = 0; i < _ctx.Length("ListDataServiceFolders.FolderPagingResult.Folders.Length"); i++) {
				ListDataServiceFoldersResponse.ListDataServiceFolders_FolderPagingResult.ListDataServiceFolders_Folder folder = new ListDataServiceFoldersResponse.ListDataServiceFolders_FolderPagingResult.ListDataServiceFolders_Folder();
				folder.FolderId = _ctx.LongValue("ListDataServiceFolders.FolderPagingResult.Folders["+ i +"].FolderId");
				folder.FolderName = _ctx.StringValue("ListDataServiceFolders.FolderPagingResult.Folders["+ i +"].FolderName");
				folder.ProjectId = _ctx.LongValue("ListDataServiceFolders.FolderPagingResult.Folders["+ i +"].ProjectId");
				folder.TenantId = _ctx.LongValue("ListDataServiceFolders.FolderPagingResult.Folders["+ i +"].TenantId");
				folder.CreatedTime = _ctx.StringValue("ListDataServiceFolders.FolderPagingResult.Folders["+ i +"].CreatedTime");
				folder.ModifiedTime = _ctx.StringValue("ListDataServiceFolders.FolderPagingResult.Folders["+ i +"].ModifiedTime");
				folder.GroupId = _ctx.StringValue("ListDataServiceFolders.FolderPagingResult.Folders["+ i +"].GroupId");
				folder.ParentId = _ctx.LongValue("ListDataServiceFolders.FolderPagingResult.Folders["+ i +"].ParentId");

				folderPagingResult_folders.Add(folder);
			}
			folderPagingResult.Folders = folderPagingResult_folders;
			listDataServiceFoldersResponse.FolderPagingResult = folderPagingResult;
        
			return listDataServiceFoldersResponse;
        }
    }
}
