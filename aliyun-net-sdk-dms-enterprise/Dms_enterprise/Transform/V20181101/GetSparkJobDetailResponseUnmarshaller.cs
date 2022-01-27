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
    public class GetSparkJobDetailResponseUnmarshaller
    {
        public static GetSparkJobDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetSparkJobDetailResponse getSparkJobDetailResponse = new GetSparkJobDetailResponse();

			getSparkJobDetailResponse.HttpResponse = _ctx.HttpResponse;
			getSparkJobDetailResponse.RequestId = _ctx.StringValue("GetSparkJobDetail.RequestId");
			getSparkJobDetailResponse.Success = _ctx.BooleanValue("GetSparkJobDetail.Success");
			getSparkJobDetailResponse.ErrorMessage = _ctx.StringValue("GetSparkJobDetail.ErrorMessage");
			getSparkJobDetailResponse.ErrorCode = _ctx.StringValue("GetSparkJobDetail.ErrorCode");

			GetSparkJobDetailResponse.GetSparkJobDetail_JobDetail jobDetail = new GetSparkJobDetailResponse.GetSparkJobDetail_JobDetail();
			jobDetail.JobId = _ctx.StringValue("GetSparkJobDetail.JobDetail.JobId");
			jobDetail.Name = _ctx.StringValue("GetSparkJobDetail.JobDetail.Name");
			jobDetail.Status = _ctx.StringValue("GetSparkJobDetail.JobDetail.Status");
			jobDetail.MainClass = _ctx.StringValue("GetSparkJobDetail.JobDetail.MainClass");
			jobDetail.MainFile = _ctx.StringValue("GetSparkJobDetail.JobDetail.MainFile");
			jobDetail.Arguments = _ctx.StringValue("GetSparkJobDetail.JobDetail.Arguments");
			jobDetail.Configuration = _ctx.StringValue("GetSparkJobDetail.JobDetail.Configuration");
			jobDetail.SubmitTime = _ctx.StringValue("GetSparkJobDetail.JobDetail.SubmitTime");
			jobDetail.BeginTime = _ctx.StringValue("GetSparkJobDetail.JobDetail.BeginTime");
			jobDetail.EndTime = _ctx.StringValue("GetSparkJobDetail.JobDetail.EndTime");
			getSparkJobDetailResponse.JobDetail = jobDetail;
        
			return getSparkJobDetailResponse;
        }
    }
}
