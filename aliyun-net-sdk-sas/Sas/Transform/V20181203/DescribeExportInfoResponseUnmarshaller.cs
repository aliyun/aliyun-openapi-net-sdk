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
    public class DescribeExportInfoResponseUnmarshaller
    {
        public static DescribeExportInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeExportInfoResponse describeExportInfoResponse = new DescribeExportInfoResponse();

			describeExportInfoResponse.HttpResponse = _ctx.HttpResponse;
			describeExportInfoResponse.RequestId = _ctx.StringValue("DescribeExportInfo.RequestId");
			describeExportInfoResponse.Id = _ctx.LongValue("DescribeExportInfo.Id");
			describeExportInfoResponse.FileName = _ctx.StringValue("DescribeExportInfo.FileName");
			describeExportInfoResponse.CurrentCount = _ctx.IntegerValue("DescribeExportInfo.CurrentCount");
			describeExportInfoResponse.TotalCount = _ctx.IntegerValue("DescribeExportInfo.TotalCount");
			describeExportInfoResponse.Progress = _ctx.IntegerValue("DescribeExportInfo.Progress");
			describeExportInfoResponse.ExportStatus = _ctx.StringValue("DescribeExportInfo.ExportStatus");
			describeExportInfoResponse.Message = _ctx.StringValue("DescribeExportInfo.Message");
			describeExportInfoResponse.Link = _ctx.StringValue("DescribeExportInfo.Link");
        
			return describeExportInfoResponse;
        }
    }
}
