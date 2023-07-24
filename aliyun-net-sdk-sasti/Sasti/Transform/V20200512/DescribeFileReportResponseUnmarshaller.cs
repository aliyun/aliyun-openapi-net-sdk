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
using Aliyun.Acs.Sasti.Model.V20200512;

namespace Aliyun.Acs.Sasti.Transform.V20200512
{
    public class DescribeFileReportResponseUnmarshaller
    {
        public static DescribeFileReportResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeFileReportResponse describeFileReportResponse = new DescribeFileReportResponse();

			describeFileReportResponse.HttpResponse = _ctx.HttpResponse;
			describeFileReportResponse.Intelligences = _ctx.StringValue("DescribeFileReport.Intelligences");
			describeFileReportResponse.RequestId = _ctx.StringValue("DescribeFileReport.RequestId");
			describeFileReportResponse.FileHash = _ctx.StringValue("DescribeFileReport.FileHash");
			describeFileReportResponse.ThreatTypes = _ctx.StringValue("DescribeFileReport.ThreatTypes");
			describeFileReportResponse.Basic = _ctx.StringValue("DescribeFileReport.Basic");
			describeFileReportResponse.ThreatLevel = _ctx.StringValue("DescribeFileReport.ThreatLevel");
			describeFileReportResponse.Sandbox = _ctx.StringValue("DescribeFileReport.Sandbox");
        
			return describeFileReportResponse;
        }
    }
}
