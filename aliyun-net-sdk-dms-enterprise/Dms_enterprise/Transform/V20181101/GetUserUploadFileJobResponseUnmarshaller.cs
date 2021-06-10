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
    public class GetUserUploadFileJobResponseUnmarshaller
    {
        public static GetUserUploadFileJobResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetUserUploadFileJobResponse getUserUploadFileJobResponse = new GetUserUploadFileJobResponse();

			getUserUploadFileJobResponse.HttpResponse = _ctx.HttpResponse;
			getUserUploadFileJobResponse.RequestId = _ctx.StringValue("GetUserUploadFileJob.RequestId");
			getUserUploadFileJobResponse.Success = _ctx.BooleanValue("GetUserUploadFileJob.Success");
			getUserUploadFileJobResponse.ErrorMessage = _ctx.StringValue("GetUserUploadFileJob.ErrorMessage");
			getUserUploadFileJobResponse.ErrorCode = _ctx.StringValue("GetUserUploadFileJob.ErrorCode");

			GetUserUploadFileJobResponse.GetUserUploadFileJob_UploadFileJobDetail uploadFileJobDetail = new GetUserUploadFileJobResponse.GetUserUploadFileJob_UploadFileJobDetail();
			uploadFileJobDetail.JobKey = _ctx.StringValue("GetUserUploadFileJob.UploadFileJobDetail.JobKey");
			uploadFileJobDetail.FileName = _ctx.StringValue("GetUserUploadFileJob.UploadFileJobDetail.FileName");
			uploadFileJobDetail.FileSize = _ctx.LongValue("GetUserUploadFileJob.UploadFileJobDetail.FileSize");
			uploadFileJobDetail.FileSource = _ctx.StringValue("GetUserUploadFileJob.UploadFileJobDetail.FileSource");
			uploadFileJobDetail.UploadType = _ctx.StringValue("GetUserUploadFileJob.UploadFileJobDetail.UploadType");
			uploadFileJobDetail.UploadURL = _ctx.StringValue("GetUserUploadFileJob.UploadFileJobDetail.UploadURL");
			uploadFileJobDetail.UploadedSize = _ctx.LongValue("GetUserUploadFileJob.UploadFileJobDetail.UploadedSize");
			uploadFileJobDetail.JobStatus = _ctx.StringValue("GetUserUploadFileJob.UploadFileJobDetail.JobStatus");
			uploadFileJobDetail.JobStatusDesc = _ctx.StringValue("GetUserUploadFileJob.UploadFileJobDetail.JobStatusDesc");
			uploadFileJobDetail.AttachmentKey = _ctx.StringValue("GetUserUploadFileJob.UploadFileJobDetail.AttachmentKey");

			GetUserUploadFileJobResponse.GetUserUploadFileJob_UploadFileJobDetail.GetUserUploadFileJob_UploadOSSParam uploadOSSParam = new GetUserUploadFileJobResponse.GetUserUploadFileJob_UploadFileJobDetail.GetUserUploadFileJob_UploadOSSParam();
			uploadOSSParam.Endpoint = _ctx.StringValue("GetUserUploadFileJob.UploadFileJobDetail.UploadOSSParam.Endpoint");
			uploadOSSParam.BucketName = _ctx.StringValue("GetUserUploadFileJob.UploadFileJobDetail.UploadOSSParam.BucketName");
			uploadOSSParam.ObjectName = _ctx.StringValue("GetUserUploadFileJob.UploadFileJobDetail.UploadOSSParam.ObjectName");
			uploadFileJobDetail.UploadOSSParam = uploadOSSParam;
			getUserUploadFileJobResponse.UploadFileJobDetail = uploadFileJobDetail;
        
			return getUserUploadFileJobResponse;
        }
    }
}
