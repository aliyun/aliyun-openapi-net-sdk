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
using Aliyun.Acs.EHPC.Model.V20180412;

namespace Aliyun.Acs.EHPC.Transform.V20180412
{
    public class ListAvailableFileSystemTypesResponseUnmarshaller
    {
        public static ListAvailableFileSystemTypesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAvailableFileSystemTypesResponse listAvailableFileSystemTypesResponse = new ListAvailableFileSystemTypesResponse();

			listAvailableFileSystemTypesResponse.HttpResponse = _ctx.HttpResponse;
			listAvailableFileSystemTypesResponse.RequestId = _ctx.StringValue("ListAvailableFileSystemTypes.RequestId");

			List<ListAvailableFileSystemTypesResponse.ListAvailableFileSystemTypes_FileSystemTypes> listAvailableFileSystemTypesResponse_fileSystemTypeList = new List<ListAvailableFileSystemTypesResponse.ListAvailableFileSystemTypes_FileSystemTypes>();
			for (int i = 0; i < _ctx.Length("ListAvailableFileSystemTypes.FileSystemTypeList.Length"); i++) {
				ListAvailableFileSystemTypesResponse.ListAvailableFileSystemTypes_FileSystemTypes fileSystemTypes = new ListAvailableFileSystemTypesResponse.ListAvailableFileSystemTypes_FileSystemTypes();
				fileSystemTypes.FileSystemType = _ctx.StringValue("ListAvailableFileSystemTypes.FileSystemTypeList["+ i +"].FileSystemType");
				fileSystemTypes.Available = _ctx.BooleanValue("ListAvailableFileSystemTypes.FileSystemTypeList["+ i +"].Available");
				fileSystemTypes.ProtocolType = _ctx.StringValue("ListAvailableFileSystemTypes.FileSystemTypeList["+ i +"].ProtocolType");

				List<string> fileSystemTypes_storageTypes = new List<string>();
				for (int j = 0; j < _ctx.Length("ListAvailableFileSystemTypes.FileSystemTypeList["+ i +"].StorageTypes.Length"); j++) {
					fileSystemTypes_storageTypes.Add(_ctx.StringValue("ListAvailableFileSystemTypes.FileSystemTypeList["+ i +"].StorageTypes["+ j +"]"));
				}
				fileSystemTypes.StorageTypes = fileSystemTypes_storageTypes;

				listAvailableFileSystemTypesResponse_fileSystemTypeList.Add(fileSystemTypes);
			}
			listAvailableFileSystemTypesResponse.FileSystemTypeList = listAvailableFileSystemTypesResponse_fileSystemTypeList;
        
			return listAvailableFileSystemTypesResponse;
        }
    }
}
