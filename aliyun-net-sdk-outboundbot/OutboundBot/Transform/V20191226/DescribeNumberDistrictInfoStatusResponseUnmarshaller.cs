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
    public class DescribeNumberDistrictInfoStatusResponseUnmarshaller
    {
        public static DescribeNumberDistrictInfoStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeNumberDistrictInfoStatusResponse describeNumberDistrictInfoStatusResponse = new DescribeNumberDistrictInfoStatusResponse();

			describeNumberDistrictInfoStatusResponse.HttpResponse = _ctx.HttpResponse;
			describeNumberDistrictInfoStatusResponse.HttpStatusCode = _ctx.IntegerValue("DescribeNumberDistrictInfoStatus.HttpStatusCode");
			describeNumberDistrictInfoStatusResponse.Code = _ctx.StringValue("DescribeNumberDistrictInfoStatus.Code");
			describeNumberDistrictInfoStatusResponse.Message = _ctx.StringValue("DescribeNumberDistrictInfoStatus.Message");
			describeNumberDistrictInfoStatusResponse.RequestId = _ctx.StringValue("DescribeNumberDistrictInfoStatus.RequestId");
			describeNumberDistrictInfoStatusResponse.Success = _ctx.BooleanValue("DescribeNumberDistrictInfoStatus.Success");
			describeNumberDistrictInfoStatusResponse.Status = _ctx.StringValue("DescribeNumberDistrictInfoStatus.Status");

			DescribeNumberDistrictInfoStatusResponse.DescribeNumberDistrictInfoStatus_AppliedVersion appliedVersion = new DescribeNumberDistrictInfoStatusResponse.DescribeNumberDistrictInfoStatus_AppliedVersion();
			appliedVersion.VersionId = _ctx.StringValue("DescribeNumberDistrictInfoStatus.AppliedVersion.VersionId");
			appliedVersion.FileName = _ctx.StringValue("DescribeNumberDistrictInfoStatus.AppliedVersion.FileName");
			appliedVersion.FileSize = _ctx.LongValue("DescribeNumberDistrictInfoStatus.AppliedVersion.FileSize");
			describeNumberDistrictInfoStatusResponse.AppliedVersion = appliedVersion;

			DescribeNumberDistrictInfoStatusResponse.DescribeNumberDistrictInfoStatus_ParsingVersion parsingVersion = new DescribeNumberDistrictInfoStatusResponse.DescribeNumberDistrictInfoStatus_ParsingVersion();
			parsingVersion.VersionId = _ctx.StringValue("DescribeNumberDistrictInfoStatus.ParsingVersion.VersionId");
			parsingVersion.FileName = _ctx.StringValue("DescribeNumberDistrictInfoStatus.ParsingVersion.FileName");
			parsingVersion.FileSize = _ctx.LongValue("DescribeNumberDistrictInfoStatus.ParsingVersion.FileSize");
			parsingVersion.ParseProgress = _ctx.LongValue("DescribeNumberDistrictInfoStatus.ParsingVersion.ParseProgress");
			describeNumberDistrictInfoStatusResponse.ParsingVersion = parsingVersion;
        
			return describeNumberDistrictInfoStatusResponse;
        }
    }
}
