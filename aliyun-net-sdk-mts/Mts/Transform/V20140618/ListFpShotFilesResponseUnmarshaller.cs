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
using Aliyun.Acs.Mts.Model.V20140618;

namespace Aliyun.Acs.Mts.Transform.V20140618
{
    public class ListFpShotFilesResponseUnmarshaller
    {
        public static ListFpShotFilesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListFpShotFilesResponse listFpShotFilesResponse = new ListFpShotFilesResponse();

			listFpShotFilesResponse.HttpResponse = _ctx.HttpResponse;
			listFpShotFilesResponse.RequestId = _ctx.StringValue("ListFpShotFiles.RequestId");
			listFpShotFilesResponse.NextPageToken = _ctx.StringValue("ListFpShotFiles.NextPageToken");

			List<ListFpShotFilesResponse.ListFpShotFiles_FpShotFile> listFpShotFilesResponse_fpShotFileList = new List<ListFpShotFilesResponse.ListFpShotFiles_FpShotFile>();
			for (int i = 0; i < _ctx.Length("ListFpShotFiles.FpShotFileList.Length"); i++) {
				ListFpShotFilesResponse.ListFpShotFiles_FpShotFile fpShotFile = new ListFpShotFilesResponse.ListFpShotFiles_FpShotFile();
				fpShotFile.PrimaryKey = _ctx.StringValue("ListFpShotFiles.FpShotFileList["+ i +"].PrimaryKey");
				fpShotFile.FileId = _ctx.StringValue("ListFpShotFiles.FpShotFileList["+ i +"].FileId");
				fpShotFile.StoreTime = _ctx.StringValue("ListFpShotFiles.FpShotFileList["+ i +"].StoreTime");

				ListFpShotFilesResponse.ListFpShotFiles_FpShotFile.ListFpShotFiles_InputFile inputFile = new ListFpShotFilesResponse.ListFpShotFiles_FpShotFile.ListFpShotFiles_InputFile();
				inputFile._Object = _ctx.StringValue("ListFpShotFiles.FpShotFileList["+ i +"].InputFile.Object");
				inputFile.Location = _ctx.StringValue("ListFpShotFiles.FpShotFileList["+ i +"].InputFile.Location");
				inputFile.Bucket = _ctx.StringValue("ListFpShotFiles.FpShotFileList["+ i +"].InputFile.Bucket");
				fpShotFile.InputFile = inputFile;

				listFpShotFilesResponse_fpShotFileList.Add(fpShotFile);
			}
			listFpShotFilesResponse.FpShotFileList = listFpShotFilesResponse_fpShotFileList;
        
			return listFpShotFilesResponse;
        }
    }
}
