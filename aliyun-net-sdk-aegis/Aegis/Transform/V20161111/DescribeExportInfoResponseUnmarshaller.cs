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
    public class DescribeExportInfoResponseUnmarshaller
    {
        public static DescribeExportInfoResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeExportInfoResponse describeExportInfoResponse = new DescribeExportInfoResponse();

			describeExportInfoResponse.HttpResponse = context.HttpResponse;
			describeExportInfoResponse.RequestId = context.StringValue("DescribeExportInfo.RequestId");
			describeExportInfoResponse.FileName = context.StringValue("DescribeExportInfo.FileName");
			describeExportInfoResponse.CurrentCount = context.IntegerValue("DescribeExportInfo.CurrentCount");
			describeExportInfoResponse.Link = context.StringValue("DescribeExportInfo.Link");
			describeExportInfoResponse.Progress = context.IntegerValue("DescribeExportInfo.Progress");
			describeExportInfoResponse.Id = context.IntegerValue("DescribeExportInfo.Id");
			describeExportInfoResponse.Message = context.StringValue("DescribeExportInfo.Message");
			describeExportInfoResponse.TotalCount = context.IntegerValue("DescribeExportInfo.TotalCount");
			describeExportInfoResponse.GmtCreate = context.LongValue("DescribeExportInfo.GmtCreate");
			describeExportInfoResponse.ResultStatus = context.StringValue("DescribeExportInfo.ResultStatus");
        
			return describeExportInfoResponse;
        }
    }
}
