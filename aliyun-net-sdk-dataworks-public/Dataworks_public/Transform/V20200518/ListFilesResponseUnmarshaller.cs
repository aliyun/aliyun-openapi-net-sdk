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
    public class ListFilesResponseUnmarshaller
    {
        public static ListFilesResponse Unmarshall(UnmarshallerContext context)
        {
			ListFilesResponse listFilesResponse = new ListFilesResponse();

			listFilesResponse.HttpResponse = context.HttpResponse;
			listFilesResponse.RequestId = context.StringValue("ListFiles.RequestId");
			listFilesResponse.Success = context.BooleanValue("ListFiles.Success");
			listFilesResponse.ErrorCode = context.StringValue("ListFiles.ErrorCode");
			listFilesResponse.ErrorMessage = context.StringValue("ListFiles.ErrorMessage");
			listFilesResponse.HttpStatusCode = context.IntegerValue("ListFiles.HttpStatusCode");

			ListFilesResponse.ListFiles_Data data = new ListFilesResponse.ListFiles_Data();
			data.PageNumber = context.IntegerValue("ListFiles.Data.PageNumber");
			data.PageSize = context.IntegerValue("ListFiles.Data.PageSize");
			data.TotalCount = context.IntegerValue("ListFiles.Data.TotalCount");

			List<ListFilesResponse.ListFiles_Data.ListFiles_File> data_files = new List<ListFilesResponse.ListFiles_Data.ListFiles_File>();
			for (int i = 0; i < context.Length("ListFiles.Data.Files.Length"); i++) {
				ListFilesResponse.ListFiles_Data.ListFiles_File file = new ListFilesResponse.ListFiles_Data.ListFiles_File();
				file.ConnectionName = context.StringValue("ListFiles.Data.Files["+ i +"].ConnectionName");
				file.ParentId = context.LongValue("ListFiles.Data.Files["+ i +"].ParentId");
				file.IsMaxCompute = context.BooleanValue("ListFiles.Data.Files["+ i +"].IsMaxCompute");
				file.CreateTime = context.LongValue("ListFiles.Data.Files["+ i +"].CreateTime");
				file.CreateUser = context.StringValue("ListFiles.Data.Files["+ i +"].CreateUser");
				file.BizId = context.LongValue("ListFiles.Data.Files["+ i +"].BizId");
				file.FileFolderId = context.StringValue("ListFiles.Data.Files["+ i +"].FileFolderId");
				file.FileName = context.StringValue("ListFiles.Data.Files["+ i +"].FileName");
				file.FileType = context.IntegerValue("ListFiles.Data.Files["+ i +"].FileType");
				file.UseType = context.StringValue("ListFiles.Data.Files["+ i +"].UseType");
				file.FileDescription = context.StringValue("ListFiles.Data.Files["+ i +"].FileDescription");
				file.Content = context.StringValue("ListFiles.Data.Files["+ i +"].Content");
				file.NodeId = context.LongValue("ListFiles.Data.Files["+ i +"].NodeId");
				file.CurrentVersion = context.IntegerValue("ListFiles.Data.Files["+ i +"].CurrentVersion");
				file.Owner = context.StringValue("ListFiles.Data.Files["+ i +"].Owner");
				file.LastEditUser = context.StringValue("ListFiles.Data.Files["+ i +"].LastEditUser");
				file.LastEditTime = context.LongValue("ListFiles.Data.Files["+ i +"].LastEditTime");
				file.CommitStatus = context.IntegerValue("ListFiles.Data.Files["+ i +"].CommitStatus");
				file.FileId = context.LongValue("ListFiles.Data.Files["+ i +"].FileId");

				data_files.Add(file);
			}
			data.Files = data_files;
			listFilesResponse.Data = data;
        
			return listFilesResponse;
        }
    }
}
