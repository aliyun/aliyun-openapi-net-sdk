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
using Aliyun.Acs.Vcs.Model.V20200515;

namespace Aliyun.Acs.Vcs.Transform.V20200515
{
    public class UploadFileResponseUnmarshaller
    {
        public static UploadFileResponse Unmarshall(UnmarshallerContext context)
        {
			UploadFileResponse uploadFileResponse = new UploadFileResponse();

			uploadFileResponse.HttpResponse = context.HttpResponse;
			uploadFileResponse.Code = context.StringValue("UploadFile.Code");
			uploadFileResponse.Message = context.StringValue("UploadFile.Message");
			uploadFileResponse.RequestId = context.StringValue("UploadFile.RequestId");

			UploadFileResponse.UploadFile_Data data = new UploadFileResponse.UploadFile_Data();

			List<UploadFileResponse.UploadFile_Data.UploadFile_OssPath> data_records = new List<UploadFileResponse.UploadFile_Data.UploadFile_OssPath>();
			for (int i = 0; i < context.Length("UploadFile.Data.Records.Length"); i++) {
				UploadFileResponse.UploadFile_Data.UploadFile_OssPath ossPath = new UploadFileResponse.UploadFile_Data.UploadFile_OssPath();
				ossPath.OssPath = context.StringValue("UploadFile.Data.Records["+ i +"].OssPath");
				ossPath.SourceId = context.StringValue("UploadFile.Data.Records["+ i +"].SourceId");

				data_records.Add(ossPath);
			}
			data.Records = data_records;
			uploadFileResponse.Data = data;
        
			return uploadFileResponse;
        }
    }
}
