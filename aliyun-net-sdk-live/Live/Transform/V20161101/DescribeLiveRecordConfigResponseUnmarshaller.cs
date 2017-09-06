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
using Aliyun.Acs.live.Model.V20161101;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeLiveRecordConfigResponseUnmarshaller
    {
        public static DescribeLiveRecordConfigResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLiveRecordConfigResponse describeLiveRecordConfigResponse = new DescribeLiveRecordConfigResponse();

			describeLiveRecordConfigResponse.HttpResponse = context.HttpResponse;
			describeLiveRecordConfigResponse.RequestId = context.StringValue("DescribeLiveRecordConfig.RequestId");
			describeLiveRecordConfigResponse.PageNum = context.IntegerValue("DescribeLiveRecordConfig.PageNum");
			describeLiveRecordConfigResponse.PageSize = context.IntegerValue("DescribeLiveRecordConfig.PageSize");
			describeLiveRecordConfigResponse.Order = context.StringValue("DescribeLiveRecordConfig.Order");
			describeLiveRecordConfigResponse.TotalNum = context.IntegerValue("DescribeLiveRecordConfig.TotalNum");
			describeLiveRecordConfigResponse.TotalPage = context.IntegerValue("DescribeLiveRecordConfig.TotalPage");

			List<DescribeLiveRecordConfigResponse.DescribeLiveRecordConfig_LiveAppRecord> describeLiveRecordConfigResponse_liveAppRecordList = new List<DescribeLiveRecordConfigResponse.DescribeLiveRecordConfig_LiveAppRecord>();
			for (int i = 0; i < context.Length("DescribeLiveRecordConfig.LiveAppRecordList.Length"); i++) {
				DescribeLiveRecordConfigResponse.DescribeLiveRecordConfig_LiveAppRecord liveAppRecord = new DescribeLiveRecordConfigResponse.DescribeLiveRecordConfig_LiveAppRecord();
				liveAppRecord.DomainName = context.StringValue("DescribeLiveRecordConfig.LiveAppRecordList["+ i +"].DomainName");
				liveAppRecord.AppName = context.StringValue("DescribeLiveRecordConfig.LiveAppRecordList["+ i +"].AppName");
				liveAppRecord.OssEndpoint = context.StringValue("DescribeLiveRecordConfig.LiveAppRecordList["+ i +"].OssEndpoint");
				liveAppRecord.OssBucket = context.StringValue("DescribeLiveRecordConfig.LiveAppRecordList["+ i +"].OssBucket");
				liveAppRecord.CreateTime = context.StringValue("DescribeLiveRecordConfig.LiveAppRecordList["+ i +"].CreateTime");

				List<DescribeLiveRecordConfigResponse.DescribeLiveRecordConfig_LiveAppRecord.DescribeLiveRecordConfig_RecordFormat> liveAppRecord_recordFormatList = new List<DescribeLiveRecordConfigResponse.DescribeLiveRecordConfig_LiveAppRecord.DescribeLiveRecordConfig_RecordFormat>();
				for (int j = 0; j < context.Length("DescribeLiveRecordConfig.LiveAppRecordList["+ i +"].RecordFormatList.Length"); j++) {
					DescribeLiveRecordConfigResponse.DescribeLiveRecordConfig_LiveAppRecord.DescribeLiveRecordConfig_RecordFormat recordFormat = new DescribeLiveRecordConfigResponse.DescribeLiveRecordConfig_LiveAppRecord.DescribeLiveRecordConfig_RecordFormat();
					recordFormat.Format = context.StringValue("DescribeLiveRecordConfig.LiveAppRecordList["+ i +"].RecordFormatList["+ j +"].Format");
					recordFormat.OssObjectPrefix = context.StringValue("DescribeLiveRecordConfig.LiveAppRecordList["+ i +"].RecordFormatList["+ j +"].OssObjectPrefix");
					recordFormat.SliceOssObjectPrefix = context.StringValue("DescribeLiveRecordConfig.LiveAppRecordList["+ i +"].RecordFormatList["+ j +"].SliceOssObjectPrefix");
					recordFormat.CycleDuration = context.IntegerValue("DescribeLiveRecordConfig.LiveAppRecordList["+ i +"].RecordFormatList["+ j +"].CycleDuration");

					liveAppRecord_recordFormatList.Add(recordFormat);
				}
				liveAppRecord.RecordFormatList = liveAppRecord_recordFormatList;

				describeLiveRecordConfigResponse_liveAppRecordList.Add(liveAppRecord);
			}
			describeLiveRecordConfigResponse.LiveAppRecordList = describeLiveRecordConfigResponse_liveAppRecordList;
        
			return describeLiveRecordConfigResponse;
        }
    }
}