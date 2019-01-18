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
using Aliyun.Acs.Cdn.Model.V20141111;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Transform.V20141111
{
    public class DescribeLiveStreamRecordIndexFileResponseUnmarshaller
    {
        public static DescribeLiveStreamRecordIndexFileResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLiveStreamRecordIndexFileResponse describeLiveStreamRecordIndexFileResponse = new DescribeLiveStreamRecordIndexFileResponse();

			describeLiveStreamRecordIndexFileResponse.HttpResponse = context.HttpResponse;
			describeLiveStreamRecordIndexFileResponse.RequestId = context.StringValue("DescribeLiveStreamRecordIndexFile.RequestId");

			DescribeLiveStreamRecordIndexFileResponse.DescribeLiveStreamRecordIndexFile_RecordIndexInfo recordIndexInfo = new DescribeLiveStreamRecordIndexFileResponse.DescribeLiveStreamRecordIndexFile_RecordIndexInfo();
			recordIndexInfo.RecordId = context.StringValue("DescribeLiveStreamRecordIndexFile.RecordIndexInfo.RecordId");
			recordIndexInfo.RecordUrl = context.StringValue("DescribeLiveStreamRecordIndexFile.RecordIndexInfo.RecordUrl");
			recordIndexInfo.DomainName = context.StringValue("DescribeLiveStreamRecordIndexFile.RecordIndexInfo.DomainName");
			recordIndexInfo.AppName = context.StringValue("DescribeLiveStreamRecordIndexFile.RecordIndexInfo.AppName");
			recordIndexInfo.StreamName = context.StringValue("DescribeLiveStreamRecordIndexFile.RecordIndexInfo.StreamName");
			recordIndexInfo.OssObject = context.StringValue("DescribeLiveStreamRecordIndexFile.RecordIndexInfo.OssObject");
			recordIndexInfo.StartTime = context.StringValue("DescribeLiveStreamRecordIndexFile.RecordIndexInfo.StartTime");
			recordIndexInfo.EndTime = context.StringValue("DescribeLiveStreamRecordIndexFile.RecordIndexInfo.EndTime");
			recordIndexInfo.Duration = context.FloatValue("DescribeLiveStreamRecordIndexFile.RecordIndexInfo.Duration");
			recordIndexInfo.Height = context.IntegerValue("DescribeLiveStreamRecordIndexFile.RecordIndexInfo.Height");
			recordIndexInfo.Width = context.IntegerValue("DescribeLiveStreamRecordIndexFile.RecordIndexInfo.Width");
			recordIndexInfo.CreateTime = context.StringValue("DescribeLiveStreamRecordIndexFile.RecordIndexInfo.CreateTime");
			describeLiveStreamRecordIndexFileResponse.RecordIndexInfo = recordIndexInfo;
        
			return describeLiveStreamRecordIndexFileResponse;
        }
    }
}