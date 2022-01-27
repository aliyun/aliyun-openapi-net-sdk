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
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeRecordResponseUnmarshaller
    {
        public static DescribeRecordResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRecordResponse describeRecordResponse = new DescribeRecordResponse();

			describeRecordResponse.HttpResponse = _ctx.HttpResponse;
			describeRecordResponse.RequestId = _ctx.StringValue("DescribeRecord.RequestId");
			describeRecordResponse.RecordId = _ctx.StringValue("DescribeRecord.RecordId");
			describeRecordResponse.AppId = _ctx.StringValue("DescribeRecord.AppId");
			describeRecordResponse.BoardId = _ctx.IntegerValue("DescribeRecord.BoardId");
			describeRecordResponse.RecordStartTime = _ctx.LongValue("DescribeRecord.RecordStartTime");
			describeRecordResponse.StartTime = _ctx.LongValue("DescribeRecord.StartTime");
			describeRecordResponse.EndTime = _ctx.LongValue("DescribeRecord.EndTime");
			describeRecordResponse.State = _ctx.IntegerValue("DescribeRecord.State");
			describeRecordResponse.OssPath = _ctx.StringValue("DescribeRecord.OssPath");
			describeRecordResponse.OssBucket = _ctx.StringValue("DescribeRecord.OssBucket");
			describeRecordResponse.OssEndpoint = _ctx.StringValue("DescribeRecord.OssEndpoint");
        
			return describeRecordResponse;
        }
    }
}
