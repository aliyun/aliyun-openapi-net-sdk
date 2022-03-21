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
        public static ListFilesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListFilesResponse listFilesResponse = new ListFilesResponse();

			listFilesResponse.HttpResponse = _ctx.HttpResponse;
			listFilesResponse.HttpStatusCode = _ctx.IntegerValue("ListFiles.HttpStatusCode");
			listFilesResponse.ErrorMessage = _ctx.StringValue("ListFiles.ErrorMessage");
			listFilesResponse.RequestId = _ctx.StringValue("ListFiles.RequestId");
			listFilesResponse.ErrorCode = _ctx.StringValue("ListFiles.ErrorCode");
			listFilesResponse.Success = _ctx.BooleanValue("ListFiles.Success");

			ListFilesResponse.ListFiles_Data data = new ListFilesResponse.ListFiles_Data();
			data.PageNumber = _ctx.IntegerValue("ListFiles.Data.PageNumber");
			data.PageSize = _ctx.IntegerValue("ListFiles.Data.PageSize");
			data.TotalCount = _ctx.IntegerValue("ListFiles.Data.TotalCount");

			List<ListFilesResponse.ListFiles_Data.ListFiles_File> data_files = new List<ListFilesResponse.ListFiles_Data.ListFiles_File>();
			for (int i = 0; i < _ctx.Length("ListFiles.Data.Files.Length"); i++) {
				ListFilesResponse.ListFiles_Data.ListFiles_File file = new ListFilesResponse.ListFiles_Data.ListFiles_File();
				file.CommitStatus = _ctx.IntegerValue("ListFiles.Data.Files["+ i +"].CommitStatus");
				file.AutoParsing = _ctx.BooleanValue("ListFiles.Data.Files["+ i +"].AutoParsing");
				file.Owner = _ctx.StringValue("ListFiles.Data.Files["+ i +"].Owner");
				file.CreateTime = _ctx.LongValue("ListFiles.Data.Files["+ i +"].CreateTime");
				file.FileType = _ctx.IntegerValue("ListFiles.Data.Files["+ i +"].FileType");
				file.CurrentVersion = _ctx.IntegerValue("ListFiles.Data.Files["+ i +"].CurrentVersion");
				file.BizId = _ctx.LongValue("ListFiles.Data.Files["+ i +"].BizId");
				file.LastEditUser = _ctx.StringValue("ListFiles.Data.Files["+ i +"].LastEditUser");
				file.FileName = _ctx.StringValue("ListFiles.Data.Files["+ i +"].FileName");
				file.ConnectionName = _ctx.StringValue("ListFiles.Data.Files["+ i +"].ConnectionName");
				file.UseType = _ctx.StringValue("ListFiles.Data.Files["+ i +"].UseType");
				file.FileFolderId = _ctx.StringValue("ListFiles.Data.Files["+ i +"].FileFolderId");
				file.FileId = _ctx.LongValue("ListFiles.Data.Files["+ i +"].FileId");
				file.ParentId = _ctx.LongValue("ListFiles.Data.Files["+ i +"].ParentId");
				file.CreateUser = _ctx.StringValue("ListFiles.Data.Files["+ i +"].CreateUser");
				file.IsMaxCompute = _ctx.BooleanValue("ListFiles.Data.Files["+ i +"].IsMaxCompute");
				file.BusinessId = _ctx.LongValue("ListFiles.Data.Files["+ i +"].BusinessId");
				file.FileDescription = _ctx.StringValue("ListFiles.Data.Files["+ i +"].FileDescription");
				file.LastEditTime = _ctx.LongValue("ListFiles.Data.Files["+ i +"].LastEditTime");
				file.Content = _ctx.StringValue("ListFiles.Data.Files["+ i +"].Content");
				file.NodeId = _ctx.LongValue("ListFiles.Data.Files["+ i +"].NodeId");

				data_files.Add(file);
			}
			data.Files = data_files;
			listFilesResponse.Data = data;
        
			return listFilesResponse;
        }
    }
}
