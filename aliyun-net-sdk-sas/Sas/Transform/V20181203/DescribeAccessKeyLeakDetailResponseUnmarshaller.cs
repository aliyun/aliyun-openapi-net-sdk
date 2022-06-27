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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class DescribeAccessKeyLeakDetailResponseUnmarshaller
    {
        public static DescribeAccessKeyLeakDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAccessKeyLeakDetailResponse describeAccessKeyLeakDetailResponse = new DescribeAccessKeyLeakDetailResponse();

			describeAccessKeyLeakDetailResponse.HttpResponse = _ctx.HttpResponse;
			describeAccessKeyLeakDetailResponse.Type = _ctx.StringValue("DescribeAccessKeyLeakDetail.Type");
			describeAccessKeyLeakDetailResponse.GithubUserPicUrl = _ctx.StringValue("DescribeAccessKeyLeakDetail.GithubUserPicUrl");
			describeAccessKeyLeakDetailResponse.GithubUser = _ctx.StringValue("DescribeAccessKeyLeakDetail.GithubUser");
			describeAccessKeyLeakDetailResponse.GithubRepoName = _ctx.StringValue("DescribeAccessKeyLeakDetail.GithubRepoName");
			describeAccessKeyLeakDetailResponse.GithubFileType = _ctx.StringValue("DescribeAccessKeyLeakDetail.GithubFileType");
			describeAccessKeyLeakDetailResponse.Remark = _ctx.StringValue("DescribeAccessKeyLeakDetail.Remark");
			describeAccessKeyLeakDetailResponse.GithubFileUpdateTime = _ctx.StringValue("DescribeAccessKeyLeakDetail.GithubFileUpdateTime");
			describeAccessKeyLeakDetailResponse.WhitelistStatus = _ctx.StringValue("DescribeAccessKeyLeakDetail.WhitelistStatus");
			describeAccessKeyLeakDetailResponse.GithubFileName = _ctx.StringValue("DescribeAccessKeyLeakDetail.GithubFileName");
			describeAccessKeyLeakDetailResponse.Source = _ctx.StringValue("DescribeAccessKeyLeakDetail.Source");
			describeAccessKeyLeakDetailResponse.GmtModified = _ctx.StringValue("DescribeAccessKeyLeakDetail.GmtModified");
			describeAccessKeyLeakDetailResponse.Asset = _ctx.StringValue("DescribeAccessKeyLeakDetail.Asset");
			describeAccessKeyLeakDetailResponse.DealTime = _ctx.StringValue("DescribeAccessKeyLeakDetail.DealTime");
			describeAccessKeyLeakDetailResponse.RequestId = _ctx.StringValue("DescribeAccessKeyLeakDetail.RequestId");
			describeAccessKeyLeakDetailResponse.AccesskeyId = _ctx.StringValue("DescribeAccessKeyLeakDetail.AccesskeyId");
			describeAccessKeyLeakDetailResponse.GithubFileUrl = _ctx.StringValue("DescribeAccessKeyLeakDetail.GithubFileUrl");
			describeAccessKeyLeakDetailResponse.DealType = _ctx.StringValue("DescribeAccessKeyLeakDetail.DealType");
			describeAccessKeyLeakDetailResponse.Code = _ctx.StringValue("DescribeAccessKeyLeakDetail.Code");
			describeAccessKeyLeakDetailResponse.GmtCreate = _ctx.StringValue("DescribeAccessKeyLeakDetail.GmtCreate");
			describeAccessKeyLeakDetailResponse.GithubRepoUrl = _ctx.StringValue("DescribeAccessKeyLeakDetail.GithubRepoUrl");
        
			return describeAccessKeyLeakDetailResponse;
        }
    }
}
