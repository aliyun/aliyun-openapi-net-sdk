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
using Aliyun.Acs.Linkvisual.Model.V20180120;

namespace Aliyun.Acs.Linkvisual.Transform.V20180120
{
    public class GetPictureSearchJobStatusResponseUnmarshaller
    {
        public static GetPictureSearchJobStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetPictureSearchJobStatusResponse getPictureSearchJobStatusResponse = new GetPictureSearchJobStatusResponse();

			getPictureSearchJobStatusResponse.HttpResponse = _ctx.HttpResponse;
			getPictureSearchJobStatusResponse.Code = _ctx.StringValue("GetPictureSearchJobStatus.Code");
			getPictureSearchJobStatusResponse.ErrorMessage = _ctx.StringValue("GetPictureSearchJobStatus.ErrorMessage");
			getPictureSearchJobStatusResponse.RequestId = _ctx.StringValue("GetPictureSearchJobStatus.RequestId");
			getPictureSearchJobStatusResponse.Success = _ctx.BooleanValue("GetPictureSearchJobStatus.Success");

			GetPictureSearchJobStatusResponse.GetPictureSearchJobStatus_Data data = new GetPictureSearchJobStatusResponse.GetPictureSearchJobStatus_Data();
			data.EndTime = _ctx.LongValue("GetPictureSearchJobStatus.Data.EndTime");
			data.StartTime = _ctx.LongValue("GetPictureSearchJobStatus.Data.StartTime");
			data.JobStatus = _ctx.IntegerValue("GetPictureSearchJobStatus.Data.JobStatus");
			data.SearchPicUrl = _ctx.StringValue("GetPictureSearchJobStatus.Data.SearchPicUrl");
			data.CreateTime = _ctx.LongValue("GetPictureSearchJobStatus.Data.CreateTime");
			data.JobId = _ctx.StringValue("GetPictureSearchJobStatus.Data.JobId");
			data.Threshold = _ctx.FloatValue("GetPictureSearchJobStatus.Data.Threshold");
			getPictureSearchJobStatusResponse.Data = data;
        
			return getPictureSearchJobStatusResponse;
        }
    }
}
