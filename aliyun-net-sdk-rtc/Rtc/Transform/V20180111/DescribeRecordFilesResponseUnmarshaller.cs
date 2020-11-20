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
using Aliyun.Acs.rtc.Model.V20180111;

namespace Aliyun.Acs.rtc.Transform.V20180111
{
    public class DescribeRecordFilesResponseUnmarshaller
    {
        public static DescribeRecordFilesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRecordFilesResponse describeRecordFilesResponse = new DescribeRecordFilesResponse();

			describeRecordFilesResponse.HttpResponse = _ctx.HttpResponse;
			describeRecordFilesResponse.RequestId = _ctx.StringValue("DescribeRecordFiles.RequestId");
			describeRecordFilesResponse.TotalNum = _ctx.LongValue("DescribeRecordFiles.TotalNum");
			describeRecordFilesResponse.TotalPage = _ctx.LongValue("DescribeRecordFiles.TotalPage");

			List<DescribeRecordFilesResponse.DescribeRecordFiles_RecordFile> describeRecordFilesResponse_recordFiles = new List<DescribeRecordFilesResponse.DescribeRecordFiles_RecordFile>();
			for (int i = 0; i < _ctx.Length("DescribeRecordFiles.RecordFiles.Length"); i++) {
				DescribeRecordFilesResponse.DescribeRecordFiles_RecordFile recordFile = new DescribeRecordFilesResponse.DescribeRecordFiles_RecordFile();
				recordFile.CreateTime = _ctx.StringValue("DescribeRecordFiles.RecordFiles["+ i +"].CreateTime");
				recordFile.AppId = _ctx.StringValue("DescribeRecordFiles.RecordFiles["+ i +"].AppId");
				recordFile.ChannelId = _ctx.StringValue("DescribeRecordFiles.RecordFiles["+ i +"].ChannelId");
				recordFile.TaskId = _ctx.StringValue("DescribeRecordFiles.RecordFiles["+ i +"].TaskId");
				recordFile.StartTime = _ctx.StringValue("DescribeRecordFiles.RecordFiles["+ i +"].StartTime");
				recordFile.StopTime = _ctx.StringValue("DescribeRecordFiles.RecordFiles["+ i +"].StopTime");
				recordFile.Url = _ctx.StringValue("DescribeRecordFiles.RecordFiles["+ i +"].Url");
				recordFile.Duration = _ctx.FloatValue("DescribeRecordFiles.RecordFiles["+ i +"].Duration");

				describeRecordFilesResponse_recordFiles.Add(recordFile);
			}
			describeRecordFilesResponse.RecordFiles = describeRecordFilesResponse_recordFiles;
        
			return describeRecordFilesResponse;
        }
    }
}
