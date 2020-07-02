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
    public class GetFolderResponseUnmarshaller
    {
        public static GetFolderResponse Unmarshall(UnmarshallerContext context)
        {
			GetFolderResponse getFolderResponse = new GetFolderResponse();

			getFolderResponse.HttpResponse = context.HttpResponse;
			getFolderResponse.RequestId = context.StringValue("GetFolder.RequestId");
			getFolderResponse.Success = context.BooleanValue("GetFolder.Success");
			getFolderResponse.ErrorCode = context.StringValue("GetFolder.ErrorCode");
			getFolderResponse.ErrorMessage = context.StringValue("GetFolder.ErrorMessage");
			getFolderResponse.HttpStatusCode = context.IntegerValue("GetFolder.HttpStatusCode");

			GetFolderResponse.GetFolder_Data data = new GetFolderResponse.GetFolder_Data();
			data.FolderId = context.StringValue("GetFolder.Data.FolderId");
			data.FolderPath = context.StringValue("GetFolder.Data.FolderPath");
			getFolderResponse.Data = data;
        
			return getFolderResponse;
        }
    }
}
