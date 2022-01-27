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
using Aliyun.Acs.dms_enterprise.Model.V20181101;

namespace Aliyun.Acs.dms_enterprise.Transform.V20181101
{
    public class GetDataCorrectBackupFilesResponseUnmarshaller
    {
        public static GetDataCorrectBackupFilesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetDataCorrectBackupFilesResponse getDataCorrectBackupFilesResponse = new GetDataCorrectBackupFilesResponse();

			getDataCorrectBackupFilesResponse.HttpResponse = _ctx.HttpResponse;
			getDataCorrectBackupFilesResponse.RequestId = _ctx.StringValue("GetDataCorrectBackupFiles.RequestId");
			getDataCorrectBackupFilesResponse.ErrorCode = _ctx.StringValue("GetDataCorrectBackupFiles.ErrorCode");
			getDataCorrectBackupFilesResponse.ErrorMessage = _ctx.StringValue("GetDataCorrectBackupFiles.ErrorMessage");
			getDataCorrectBackupFilesResponse.Success = _ctx.BooleanValue("GetDataCorrectBackupFiles.Success");

			List<string> getDataCorrectBackupFilesResponse_dataCorrectBackupFiles = new List<string>();
			for (int i = 0; i < _ctx.Length("GetDataCorrectBackupFiles.DataCorrectBackupFiles.Length"); i++) {
				getDataCorrectBackupFilesResponse_dataCorrectBackupFiles.Add(_ctx.StringValue("GetDataCorrectBackupFiles.DataCorrectBackupFiles["+ i +"]"));
			}
			getDataCorrectBackupFilesResponse.DataCorrectBackupFiles = getDataCorrectBackupFilesResponse_dataCorrectBackupFiles;
        
			return getDataCorrectBackupFilesResponse;
        }
    }
}
