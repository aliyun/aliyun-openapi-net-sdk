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
using Aliyun.Acs.aegis.Model.V20161111;

namespace Aliyun.Acs.aegis.Transform.V20161111
{
    public class DescribeVulExportInfoResponseUnmarshaller
    {
        public static DescribeVulExportInfoResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVulExportInfoResponse describeVulExportInfoResponse = new DescribeVulExportInfoResponse();

			describeVulExportInfoResponse.HttpResponse = context.HttpResponse;
			describeVulExportInfoResponse.RequestId = context.StringValue("DescribeVulExportInfo.RequestId");
			describeVulExportInfoResponse.Id = context.LongValue("DescribeVulExportInfo.Id");
			describeVulExportInfoResponse.FileName = context.StringValue("DescribeVulExportInfo.FileName");
			describeVulExportInfoResponse.CurrentCount = context.IntegerValue("DescribeVulExportInfo.CurrentCount");
			describeVulExportInfoResponse.TotalCount = context.IntegerValue("DescribeVulExportInfo.TotalCount");
			describeVulExportInfoResponse.Progress = context.IntegerValue("DescribeVulExportInfo.Progress");
			describeVulExportInfoResponse.ExportStatus = context.StringValue("DescribeVulExportInfo.ExportStatus");
			describeVulExportInfoResponse.Message = context.StringValue("DescribeVulExportInfo.Message");
			describeVulExportInfoResponse.Link = context.StringValue("DescribeVulExportInfo.Link");
        
			return describeVulExportInfoResponse;
        }
    }
}
