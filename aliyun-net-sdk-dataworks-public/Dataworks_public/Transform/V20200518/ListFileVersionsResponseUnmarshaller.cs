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
    public class ListFileVersionsResponseUnmarshaller
    {
        public static ListFileVersionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListFileVersionsResponse listFileVersionsResponse = new ListFileVersionsResponse();

			listFileVersionsResponse.HttpResponse = _ctx.HttpResponse;
			listFileVersionsResponse.RequestId = _ctx.StringValue("ListFileVersions.RequestId");
			listFileVersionsResponse.Success = _ctx.BooleanValue("ListFileVersions.Success");
			listFileVersionsResponse.ErrorCode = _ctx.StringValue("ListFileVersions.ErrorCode");
			listFileVersionsResponse.ErrorMessage = _ctx.StringValue("ListFileVersions.ErrorMessage");
			listFileVersionsResponse.HttpStatusCode = _ctx.IntegerValue("ListFileVersions.HttpStatusCode");

			ListFileVersionsResponse.ListFileVersions_Data data = new ListFileVersionsResponse.ListFileVersions_Data();
			data.PageNumber = _ctx.IntegerValue("ListFileVersions.Data.PageNumber");
			data.PageSize = _ctx.IntegerValue("ListFileVersions.Data.PageSize");
			data.TotalCount = _ctx.IntegerValue("ListFileVersions.Data.TotalCount");

			List<ListFileVersionsResponse.ListFileVersions_Data.ListFileVersions_FileVersion> data_fileVersions = new List<ListFileVersionsResponse.ListFileVersions_Data.ListFileVersions_FileVersion>();
			for (int i = 0; i < _ctx.Length("ListFileVersions.Data.FileVersions.Length"); i++) {
				ListFileVersionsResponse.ListFileVersions_Data.ListFileVersions_FileVersion fileVersion = new ListFileVersionsResponse.ListFileVersions_Data.ListFileVersions_FileVersion();
				fileVersion.FileVersion = _ctx.IntegerValue("ListFileVersions.Data.FileVersions["+ i +"].FileVersion");
				fileVersion.FileContent = _ctx.StringValue("ListFileVersions.Data.FileVersions["+ i +"].FileContent");
				fileVersion.CommitTime = _ctx.LongValue("ListFileVersions.Data.FileVersions["+ i +"].CommitTime");
				fileVersion.CommitUser = _ctx.StringValue("ListFileVersions.Data.FileVersions["+ i +"].CommitUser");
				fileVersion.FileName = _ctx.StringValue("ListFileVersions.Data.FileVersions["+ i +"].FileName");
				fileVersion.Status = _ctx.StringValue("ListFileVersions.Data.FileVersions["+ i +"].Status");
				fileVersion.ChangeType = _ctx.StringValue("ListFileVersions.Data.FileVersions["+ i +"].ChangeType");
				fileVersion.IsCurrentProd = _ctx.BooleanValue("ListFileVersions.Data.FileVersions["+ i +"].IsCurrentProd");
				fileVersion.NodeId = _ctx.LongValue("ListFileVersions.Data.FileVersions["+ i +"].NodeId");
				fileVersion.Comment = _ctx.StringValue("ListFileVersions.Data.FileVersions["+ i +"].Comment");
				fileVersion.NodeContent = _ctx.StringValue("ListFileVersions.Data.FileVersions["+ i +"].NodeContent");
				fileVersion.FilePropertyContent = _ctx.StringValue("ListFileVersions.Data.FileVersions["+ i +"].FilePropertyContent");
				fileVersion.UseType = _ctx.StringValue("ListFileVersions.Data.FileVersions["+ i +"].UseType");

				data_fileVersions.Add(fileVersion);
			}
			data.FileVersions = data_fileVersions;
			listFileVersionsResponse.Data = data;
        
			return listFileVersionsResponse;
        }
    }
}
