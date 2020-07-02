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
        public static ListFileVersionsResponse Unmarshall(UnmarshallerContext context)
        {
			ListFileVersionsResponse listFileVersionsResponse = new ListFileVersionsResponse();

			listFileVersionsResponse.HttpResponse = context.HttpResponse;
			listFileVersionsResponse.RequestId = context.StringValue("ListFileVersions.RequestId");
			listFileVersionsResponse.Success = context.BooleanValue("ListFileVersions.Success");
			listFileVersionsResponse.ErrorCode = context.StringValue("ListFileVersions.ErrorCode");
			listFileVersionsResponse.ErrorMessage = context.StringValue("ListFileVersions.ErrorMessage");
			listFileVersionsResponse.HttpStatusCode = context.IntegerValue("ListFileVersions.HttpStatusCode");

			ListFileVersionsResponse.ListFileVersions_Data data = new ListFileVersionsResponse.ListFileVersions_Data();
			data.PageNumber = context.IntegerValue("ListFileVersions.Data.PageNumber");
			data.PageSize = context.IntegerValue("ListFileVersions.Data.PageSize");
			data.TotalCount = context.IntegerValue("ListFileVersions.Data.TotalCount");

			List<ListFileVersionsResponse.ListFileVersions_Data.ListFileVersions_FileVersion> data_fileVersions = new List<ListFileVersionsResponse.ListFileVersions_Data.ListFileVersions_FileVersion>();
			for (int i = 0; i < context.Length("ListFileVersions.Data.FileVersions.Length"); i++) {
				ListFileVersionsResponse.ListFileVersions_Data.ListFileVersions_FileVersion fileVersion = new ListFileVersionsResponse.ListFileVersions_Data.ListFileVersions_FileVersion();
				fileVersion.FileVersion = context.IntegerValue("ListFileVersions.Data.FileVersions["+ i +"].FileVersion");
				fileVersion.FileContent = context.StringValue("ListFileVersions.Data.FileVersions["+ i +"].FileContent");
				fileVersion.CommitTime = context.LongValue("ListFileVersions.Data.FileVersions["+ i +"].CommitTime");
				fileVersion.CommitUser = context.StringValue("ListFileVersions.Data.FileVersions["+ i +"].CommitUser");
				fileVersion.FileName = context.StringValue("ListFileVersions.Data.FileVersions["+ i +"].FileName");
				fileVersion.Status = context.StringValue("ListFileVersions.Data.FileVersions["+ i +"].Status");
				fileVersion.ChangeType = context.StringValue("ListFileVersions.Data.FileVersions["+ i +"].ChangeType");
				fileVersion.IsCurrentProd = context.BooleanValue("ListFileVersions.Data.FileVersions["+ i +"].IsCurrentProd");
				fileVersion.NodeId = context.LongValue("ListFileVersions.Data.FileVersions["+ i +"].NodeId");
				fileVersion.Comment = context.StringValue("ListFileVersions.Data.FileVersions["+ i +"].Comment");
				fileVersion.NodeContent = context.StringValue("ListFileVersions.Data.FileVersions["+ i +"].NodeContent");
				fileVersion.FilePropertyContent = context.StringValue("ListFileVersions.Data.FileVersions["+ i +"].FilePropertyContent");
				fileVersion.UseType = context.StringValue("ListFileVersions.Data.FileVersions["+ i +"].UseType");

				data_fileVersions.Add(fileVersion);
			}
			data.FileVersions = data_fileVersions;
			listFileVersionsResponse.Data = data;
        
			return listFileVersionsResponse;
        }
    }
}
