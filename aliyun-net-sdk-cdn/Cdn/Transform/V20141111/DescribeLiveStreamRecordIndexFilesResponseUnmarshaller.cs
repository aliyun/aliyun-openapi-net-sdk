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
using Aliyun.Acs.Cdn.Model.V20141111;

namespace Aliyun.Acs.Cdn.Transform.V20141111
{
    public class DescribeLiveStreamRecordIndexFilesResponseUnmarshaller
    {
        public static DescribeLiveStreamRecordIndexFilesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveStreamRecordIndexFilesResponse describeLiveStreamRecordIndexFilesResponse = new DescribeLiveStreamRecordIndexFilesResponse();

			describeLiveStreamRecordIndexFilesResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveStreamRecordIndexFilesResponse.RequestId = _ctx.StringValue("DescribeLiveStreamRecordIndexFiles.RequestId");

			List<DescribeLiveStreamRecordIndexFilesResponse.DescribeLiveStreamRecordIndexFiles_RecordIndexInfo> describeLiveStreamRecordIndexFilesResponse_recordIndexInfoList = new List<DescribeLiveStreamRecordIndexFilesResponse.DescribeLiveStreamRecordIndexFiles_RecordIndexInfo>();
			for (int i = 0; i < _ctx.Length("DescribeLiveStreamRecordIndexFiles.RecordIndexInfoList.Length"); i++) {
				DescribeLiveStreamRecordIndexFilesResponse.DescribeLiveStreamRecordIndexFiles_RecordIndexInfo recordIndexInfo = new DescribeLiveStreamRecordIndexFilesResponse.DescribeLiveStreamRecordIndexFiles_RecordIndexInfo();
				recordIndexInfo.RecordId = _ctx.StringValue("DescribeLiveStreamRecordIndexFiles.RecordIndexInfoList["+ i +"].RecordId");
				recordIndexInfo.RecordUrl = _ctx.StringValue("DescribeLiveStreamRecordIndexFiles.RecordIndexInfoList["+ i +"].RecordUrl");
				recordIndexInfo.DomainName = _ctx.StringValue("DescribeLiveStreamRecordIndexFiles.RecordIndexInfoList["+ i +"].DomainName");
				recordIndexInfo.AppName = _ctx.StringValue("DescribeLiveStreamRecordIndexFiles.RecordIndexInfoList["+ i +"].AppName");
				recordIndexInfo.StreamName = _ctx.StringValue("DescribeLiveStreamRecordIndexFiles.RecordIndexInfoList["+ i +"].StreamName");
				recordIndexInfo.OssObject = _ctx.StringValue("DescribeLiveStreamRecordIndexFiles.RecordIndexInfoList["+ i +"].OssObject");
				recordIndexInfo.StartTime = _ctx.StringValue("DescribeLiveStreamRecordIndexFiles.RecordIndexInfoList["+ i +"].StartTime");
				recordIndexInfo.EndTime = _ctx.StringValue("DescribeLiveStreamRecordIndexFiles.RecordIndexInfoList["+ i +"].EndTime");
				recordIndexInfo.Duration = _ctx.FloatValue("DescribeLiveStreamRecordIndexFiles.RecordIndexInfoList["+ i +"].Duration");
				recordIndexInfo.Height = _ctx.IntegerValue("DescribeLiveStreamRecordIndexFiles.RecordIndexInfoList["+ i +"].Height");
				recordIndexInfo.Width = _ctx.IntegerValue("DescribeLiveStreamRecordIndexFiles.RecordIndexInfoList["+ i +"].Width");
				recordIndexInfo.CreateTime = _ctx.StringValue("DescribeLiveStreamRecordIndexFiles.RecordIndexInfoList["+ i +"].CreateTime");

				describeLiveStreamRecordIndexFilesResponse_recordIndexInfoList.Add(recordIndexInfo);
			}
			describeLiveStreamRecordIndexFilesResponse.RecordIndexInfoList = describeLiveStreamRecordIndexFilesResponse_recordIndexInfoList;
        
			return describeLiveStreamRecordIndexFilesResponse;
        }
    }
}
