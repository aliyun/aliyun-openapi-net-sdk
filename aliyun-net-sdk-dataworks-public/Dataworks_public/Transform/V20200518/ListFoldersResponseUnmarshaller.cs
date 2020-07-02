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
    public class ListFoldersResponseUnmarshaller
    {
        public static ListFoldersResponse Unmarshall(UnmarshallerContext context)
        {
			ListFoldersResponse listFoldersResponse = new ListFoldersResponse();

			listFoldersResponse.HttpResponse = context.HttpResponse;
			listFoldersResponse.RequestId = context.StringValue("ListFolders.RequestId");
			listFoldersResponse.Success = context.BooleanValue("ListFolders.Success");
			listFoldersResponse.ErrorCode = context.StringValue("ListFolders.ErrorCode");
			listFoldersResponse.ErrorMessage = context.StringValue("ListFolders.ErrorMessage");
			listFoldersResponse.HttpStatusCode = context.IntegerValue("ListFolders.HttpStatusCode");

			ListFoldersResponse.ListFolders_Data data = new ListFoldersResponse.ListFolders_Data();
			data.PageNumber = context.IntegerValue("ListFolders.Data.PageNumber");
			data.PageSize = context.IntegerValue("ListFolders.Data.PageSize");
			data.TotalCount = context.IntegerValue("ListFolders.Data.TotalCount");

			List<ListFoldersResponse.ListFolders_Data.ListFolders_FoldersItem> data_folders = new List<ListFoldersResponse.ListFolders_Data.ListFolders_FoldersItem>();
			for (int i = 0; i < context.Length("ListFolders.Data.Folders.Length"); i++) {
				ListFoldersResponse.ListFolders_Data.ListFolders_FoldersItem foldersItem = new ListFoldersResponse.ListFolders_Data.ListFolders_FoldersItem();
				foldersItem.FolderId = context.StringValue("ListFolders.Data.Folders["+ i +"].FolderId");
				foldersItem.FolderPath = context.StringValue("ListFolders.Data.Folders["+ i +"].FolderPath");

				data_folders.Add(foldersItem);
			}
			data.Folders = data_folders;
			listFoldersResponse.Data = data;
        
			return listFoldersResponse;
        }
    }
}
