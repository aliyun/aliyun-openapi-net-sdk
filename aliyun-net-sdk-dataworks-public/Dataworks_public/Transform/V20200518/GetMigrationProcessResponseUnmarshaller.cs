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
    public class GetMigrationProcessResponseUnmarshaller
    {
        public static GetMigrationProcessResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetMigrationProcessResponse getMigrationProcessResponse = new GetMigrationProcessResponse();

			getMigrationProcessResponse.HttpResponse = _ctx.HttpResponse;
			getMigrationProcessResponse.ErrorCode = _ctx.StringValue("GetMigrationProcess.ErrorCode");
			getMigrationProcessResponse.ErrorMessage = _ctx.StringValue("GetMigrationProcess.ErrorMessage");
			getMigrationProcessResponse.HttpStatusCode = _ctx.IntegerValue("GetMigrationProcess.HttpStatusCode");
			getMigrationProcessResponse.RequestId = _ctx.StringValue("GetMigrationProcess.RequestId");
			getMigrationProcessResponse.Success = _ctx.BooleanValue("GetMigrationProcess.Success");

			List<GetMigrationProcessResponse.GetMigrationProcess_ProgressTaskItem> getMigrationProcessResponse_data = new List<GetMigrationProcessResponse.GetMigrationProcess_ProgressTaskItem>();
			for (int i = 0; i < _ctx.Length("GetMigrationProcess.Data.Length"); i++) {
				GetMigrationProcessResponse.GetMigrationProcess_ProgressTaskItem progressTaskItem = new GetMigrationProcessResponse.GetMigrationProcess_ProgressTaskItem();
				progressTaskItem.TaskName = _ctx.StringValue("GetMigrationProcess.Data["+ i +"].TaskName");
				progressTaskItem.TaskStatus = _ctx.StringValue("GetMigrationProcess.Data["+ i +"].TaskStatus");

				getMigrationProcessResponse_data.Add(progressTaskItem);
			}
			getMigrationProcessResponse.Data = getMigrationProcessResponse_data;
        
			return getMigrationProcessResponse;
        }
    }
}
