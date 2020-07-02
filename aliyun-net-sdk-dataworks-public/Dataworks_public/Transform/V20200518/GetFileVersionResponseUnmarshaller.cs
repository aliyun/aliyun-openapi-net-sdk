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
    public class GetFileVersionResponseUnmarshaller
    {
        public static GetFileVersionResponse Unmarshall(UnmarshallerContext context)
        {
			GetFileVersionResponse getFileVersionResponse = new GetFileVersionResponse();

			getFileVersionResponse.HttpResponse = context.HttpResponse;
			getFileVersionResponse.RequestId = context.StringValue("GetFileVersion.RequestId");
			getFileVersionResponse.Success = context.BooleanValue("GetFileVersion.Success");
			getFileVersionResponse.ErrorCode = context.StringValue("GetFileVersion.ErrorCode");
			getFileVersionResponse.ErrorMessage = context.StringValue("GetFileVersion.ErrorMessage");
			getFileVersionResponse.HttpStatusCode = context.IntegerValue("GetFileVersion.HttpStatusCode");

			GetFileVersionResponse.GetFileVersion_Data data = new GetFileVersionResponse.GetFileVersion_Data();
			data.FileVersion = context.IntegerValue("GetFileVersion.Data.FileVersion");
			data.FileContent = context.StringValue("GetFileVersion.Data.FileContent");
			data.FilePropertyContent = context.StringValue("GetFileVersion.Data.FilePropertyContent");
			data.NodeContent = context.StringValue("GetFileVersion.Data.NodeContent");
			data.Comment = context.StringValue("GetFileVersion.Data.Comment");
			data.NodeId = context.LongValue("GetFileVersion.Data.NodeId");
			data.IsCurrentProd = context.BooleanValue("GetFileVersion.Data.IsCurrentProd");
			data.ChangeType = context.StringValue("GetFileVersion.Data.ChangeType");
			data.Status = context.StringValue("GetFileVersion.Data.Status");
			data.FileName = context.StringValue("GetFileVersion.Data.FileName");
			data.CommitUser = context.StringValue("GetFileVersion.Data.CommitUser");
			data.CommitTime = context.LongValue("GetFileVersion.Data.CommitTime");
			data.UseType = context.StringValue("GetFileVersion.Data.UseType");
			getFileVersionResponse.Data = data;
        
			return getFileVersionResponse;
        }
    }
}
