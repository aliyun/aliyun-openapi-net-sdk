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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Live.Model.V20161101;
using System.Collections.Generic;

namespace Aliyun.Acs.Live.Transform.V20161101
{
    public class DescribeLiveStreamRecordIndexFilesResponseUnmarshaller
    {
        public static DescribeLiveStreamRecordIndexFilesResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeLiveStreamRecordIndexFilesResponse describeLiveStreamRecordIndexFilesResponse = new DescribeLiveStreamRecordIndexFilesResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeLiveStreamRecordIndexFiles.RequestId"),
                PageNum = context.IntegerValue("DescribeLiveStreamRecordIndexFiles.PageNum"),
                PageSize = context.IntegerValue("DescribeLiveStreamRecordIndexFiles.PageSize"),
                Order = context.StringValue("DescribeLiveStreamRecordIndexFiles.Order"),
                TotalNum = context.IntegerValue("DescribeLiveStreamRecordIndexFiles.TotalNum"),
                TotalPage = context.IntegerValue("DescribeLiveStreamRecordIndexFiles.TotalPage")
            };
            List<DescribeLiveStreamRecordIndexFilesResponse.RecordIndexInfo> recordIndexInfoList = new List<DescribeLiveStreamRecordIndexFilesResponse.RecordIndexInfo>();
			for (int i = 0; i < context.Length("DescribeLiveStreamRecordIndexFiles.RecordIndexInfoList.Length"); i++) {
                DescribeLiveStreamRecordIndexFilesResponse.RecordIndexInfo recordIndexInfo = new DescribeLiveStreamRecordIndexFilesResponse.RecordIndexInfo()
                {
                    RecordId = context.StringValue($"DescribeLiveStreamRecordIndexFiles.RecordIndexInfoList[{i}].RecordId"),
                    RecordUrl = context.StringValue($"DescribeLiveStreamRecordIndexFiles.RecordIndexInfoList[{i}].RecordUrl"),
                    DomainName = context.StringValue($"DescribeLiveStreamRecordIndexFiles.RecordIndexInfoList[{i}].DomainName"),
                    AppName = context.StringValue($"DescribeLiveStreamRecordIndexFiles.RecordIndexInfoList[{i}].AppName"),
                    StreamName = context.StringValue($"DescribeLiveStreamRecordIndexFiles.RecordIndexInfoList[{i}].StreamName"),
                    OssBucket = context.StringValue($"DescribeLiveStreamRecordIndexFiles.RecordIndexInfoList[{i}].OssBucket"),
                    OssEndpoint = context.StringValue($"DescribeLiveStreamRecordIndexFiles.RecordIndexInfoList[{i}].OssEndpoint"),
                    OssObject = context.StringValue($"DescribeLiveStreamRecordIndexFiles.RecordIndexInfoList[{i}].OssObject"),
                    StartTime = context.StringValue($"DescribeLiveStreamRecordIndexFiles.RecordIndexInfoList[{i}].StartTime"),
                    EndTime = context.StringValue($"DescribeLiveStreamRecordIndexFiles.RecordIndexInfoList[{i}].EndTime"),
                    Duration = context.FloatValue($"DescribeLiveStreamRecordIndexFiles.RecordIndexInfoList[{i}].Duration"),
                    Height = context.IntegerValue($"DescribeLiveStreamRecordIndexFiles.RecordIndexInfoList[{i}].Height"),
                    Width = context.IntegerValue($"DescribeLiveStreamRecordIndexFiles.RecordIndexInfoList[{i}].Width"),
                    CreateTime = context.StringValue($"DescribeLiveStreamRecordIndexFiles.RecordIndexInfoList[{i}].CreateTime")
                };
                recordIndexInfoList.Add(recordIndexInfo);
			}
			describeLiveStreamRecordIndexFilesResponse.RecordIndexInfoList = recordIndexInfoList;
        
			return describeLiveStreamRecordIndexFilesResponse;
        }
    }
}