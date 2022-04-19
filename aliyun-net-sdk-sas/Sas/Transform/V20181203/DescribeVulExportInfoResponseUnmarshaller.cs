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
    public class DescribeVulExportInfoResponseUnmarshaller
    {
        public static DescribeVulExportInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVulExportInfoResponse describeVulExportInfoResponse = new DescribeVulExportInfoResponse();

			describeVulExportInfoResponse.HttpResponse = _ctx.HttpResponse;
			describeVulExportInfoResponse.Link = _ctx.StringValue("DescribeVulExportInfo.Link");
			describeVulExportInfoResponse.Progress = _ctx.IntegerValue("DescribeVulExportInfo.Progress");
			describeVulExportInfoResponse.RequestId = _ctx.StringValue("DescribeVulExportInfo.RequestId");
			describeVulExportInfoResponse.CurrentCount = _ctx.IntegerValue("DescribeVulExportInfo.CurrentCount");
			describeVulExportInfoResponse.Message = _ctx.StringValue("DescribeVulExportInfo.Message");
			describeVulExportInfoResponse.FileName = _ctx.StringValue("DescribeVulExportInfo.FileName");
			describeVulExportInfoResponse.TotalCount = _ctx.IntegerValue("DescribeVulExportInfo.TotalCount");
			describeVulExportInfoResponse.ExportStatus = _ctx.StringValue("DescribeVulExportInfo.ExportStatus");
			describeVulExportInfoResponse.Id = _ctx.LongValue("DescribeVulExportInfo.Id");
        
			return describeVulExportInfoResponse;
        }
    }
}
