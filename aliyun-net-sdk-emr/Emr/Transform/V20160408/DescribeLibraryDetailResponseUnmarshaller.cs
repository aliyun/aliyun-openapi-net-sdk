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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class DescribeLibraryDetailResponseUnmarshaller
    {
        public static DescribeLibraryDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLibraryDetailResponse describeLibraryDetailResponse = new DescribeLibraryDetailResponse();

			describeLibraryDetailResponse.HttpResponse = _ctx.HttpResponse;
			describeLibraryDetailResponse.RequestId = _ctx.StringValue("DescribeLibraryDetail.RequestId");
			describeLibraryDetailResponse.BizId = _ctx.StringValue("DescribeLibraryDetail.BizId");
			describeLibraryDetailResponse.CreateTime = _ctx.LongValue("DescribeLibraryDetail.CreateTime");
			describeLibraryDetailResponse.Type = _ctx.StringValue("DescribeLibraryDetail.Type");
			describeLibraryDetailResponse.Name = _ctx.StringValue("DescribeLibraryDetail.Name");
			describeLibraryDetailResponse.LibraryVersion = _ctx.StringValue("DescribeLibraryDetail.LibraryVersion");
			describeLibraryDetailResponse.SourceType = _ctx.StringValue("DescribeLibraryDetail.SourceType");
			describeLibraryDetailResponse.SourceLocation = _ctx.StringValue("DescribeLibraryDetail.SourceLocation");
			describeLibraryDetailResponse.Scope = _ctx.StringValue("DescribeLibraryDetail.Scope");
			describeLibraryDetailResponse.Properties = _ctx.StringValue("DescribeLibraryDetail.Properties");
			describeLibraryDetailResponse.UserId = _ctx.StringValue("DescribeLibraryDetail.UserId");
        
			return describeLibraryDetailResponse;
        }
    }
}
