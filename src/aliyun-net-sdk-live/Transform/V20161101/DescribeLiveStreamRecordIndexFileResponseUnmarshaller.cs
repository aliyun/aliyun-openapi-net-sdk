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

namespace Aliyun.Acs.Live.Transform.V20161101
{
    public class DescribeLiveStreamRecordIndexFileResponseUnmarshaller
    {
        public static DescribeLiveStreamRecordIndexFileResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeLiveStreamRecordIndexFileResponse describeLiveStreamRecordIndexFileResponse = new DescribeLiveStreamRecordIndexFileResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeLiveStreamRecordIndexFile.RequestId")
            };
            DescribeLiveStreamRecordIndexFileResponse.RecordIndexInfo_ recordIndexInfo = new DescribeLiveStreamRecordIndexFileResponse.RecordIndexInfo_()
            {
                RecordId = context.StringValue("DescribeLiveStreamRecordIndexFile.RecordIndexInfo.RecordId"),
                RecordUrl = context.StringValue("DescribeLiveStreamRecordIndexFile.RecordIndexInfo.RecordUrl"),
                DomainName = context.StringValue("DescribeLiveStreamRecordIndexFile.RecordIndexInfo.DomainName"),
                AppName = context.StringValue("DescribeLiveStreamRecordIndexFile.RecordIndexInfo.AppName"),
                StreamName = context.StringValue("DescribeLiveStreamRecordIndexFile.RecordIndexInfo.StreamName"),
                OssBucket = context.StringValue("DescribeLiveStreamRecordIndexFile.RecordIndexInfo.OssBucket"),
                OssEndpoint = context.StringValue("DescribeLiveStreamRecordIndexFile.RecordIndexInfo.OssEndpoint"),
                OssObject = context.StringValue("DescribeLiveStreamRecordIndexFile.RecordIndexInfo.OssObject"),
                StartTime = context.StringValue("DescribeLiveStreamRecordIndexFile.RecordIndexInfo.StartTime"),
                EndTime = context.StringValue("DescribeLiveStreamRecordIndexFile.RecordIndexInfo.EndTime"),
                Duration = context.FloatValue("DescribeLiveStreamRecordIndexFile.RecordIndexInfo.Duration"),
                Height = context.IntegerValue("DescribeLiveStreamRecordIndexFile.RecordIndexInfo.Height"),
                Width = context.IntegerValue("DescribeLiveStreamRecordIndexFile.RecordIndexInfo.Width"),
                CreateTime = context.StringValue("DescribeLiveStreamRecordIndexFile.RecordIndexInfo.CreateTime")
            };
            describeLiveStreamRecordIndexFileResponse.RecordIndexInfo = recordIndexInfo;
        
			return describeLiveStreamRecordIndexFileResponse;
        }
    }
}