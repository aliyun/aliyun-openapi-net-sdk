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
using Aliyun.Acs.OutboundBot.Model.V20191226;

namespace Aliyun.Acs.OutboundBot.Transform.V20191226
{
    public class DescribeJobDataParsingTaskProgressResponseUnmarshaller
    {
        public static DescribeJobDataParsingTaskProgressResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeJobDataParsingTaskProgressResponse describeJobDataParsingTaskProgressResponse = new DescribeJobDataParsingTaskProgressResponse();

			describeJobDataParsingTaskProgressResponse.HttpResponse = _ctx.HttpResponse;
			describeJobDataParsingTaskProgressResponse.RequestId = _ctx.StringValue("DescribeJobDataParsingTaskProgress.RequestId");
			describeJobDataParsingTaskProgressResponse.Success = _ctx.BooleanValue("DescribeJobDataParsingTaskProgress.Success");
			describeJobDataParsingTaskProgressResponse.Code = _ctx.StringValue("DescribeJobDataParsingTaskProgress.Code");
			describeJobDataParsingTaskProgressResponse.Message = _ctx.StringValue("DescribeJobDataParsingTaskProgress.Message");
			describeJobDataParsingTaskProgressResponse.HttpStatusCode = _ctx.IntegerValue("DescribeJobDataParsingTaskProgress.HttpStatusCode");

			DescribeJobDataParsingTaskProgressResponse.DescribeJobDataParsingTaskProgress_Progress progress = new DescribeJobDataParsingTaskProgressResponse.DescribeJobDataParsingTaskProgress_Progress();
			progress.Status = _ctx.StringValue("DescribeJobDataParsingTaskProgress.Progress.Status");
			progress.FailErrorCode = _ctx.StringValue("DescribeJobDataParsingTaskProgress.Progress.FailErrorCode");
			progress.FailReason = _ctx.StringValue("DescribeJobDataParsingTaskProgress.Progress.FailReason");
			progress.TotalJobCount = _ctx.IntegerValue("DescribeJobDataParsingTaskProgress.Progress.TotalJobCount");
			progress.HandledJobCount = _ctx.IntegerValue("DescribeJobDataParsingTaskProgress.Progress.HandledJobCount");
			describeJobDataParsingTaskProgressResponse.Progress = progress;
        
			return describeJobDataParsingTaskProgressResponse;
        }
    }
}
