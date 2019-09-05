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
using Aliyun.Acs.foas.Model.V20181111;

namespace Aliyun.Acs.foas.Transform.V20181111
{
    public class ListChildFolderResponseUnmarshaller
    {
        public static ListChildFolderResponse Unmarshall(UnmarshallerContext context)
        {
			ListChildFolderResponse listChildFolderResponse = new ListChildFolderResponse();

			listChildFolderResponse.HttpResponse = context.HttpResponse;
			listChildFolderResponse.RequestId = context.StringValue("ListChildFolder.RequestId");

			List<ListChildFolderResponse.ListChildFolder_Folder> listChildFolderResponse_folders = new List<ListChildFolderResponse.ListChildFolder_Folder>();
			for (int i = 0; i < context.Length("ListChildFolder.Folders.Length"); i++) {
				ListChildFolderResponse.ListChildFolder_Folder folder = new ListChildFolderResponse.ListChildFolder_Folder();
				folder.FolderId = context.LongValue("ListChildFolder.Folders["+ i +"].FolderId");
				folder.Path = context.StringValue("ListChildFolder.Folders["+ i +"].Path");

				listChildFolderResponse_folders.Add(folder);
			}
			listChildFolderResponse.Folders = listChildFolderResponse_folders;
        
			return listChildFolderResponse;
        }
    }
}
