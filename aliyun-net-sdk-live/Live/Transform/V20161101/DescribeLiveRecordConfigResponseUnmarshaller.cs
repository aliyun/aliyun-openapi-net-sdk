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
    public class DescribeLiveRecordConfigResponseUnmarshaller
    {
        public static DescribeLiveRecordConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveRecordConfigResponse describeLiveRecordConfigResponse = new DescribeLiveRecordConfigResponse();

			describeLiveRecordConfigResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveRecordConfigResponse.RequestId = _ctx.StringValue("DescribeLiveRecordConfig.RequestId");
			describeLiveRecordConfigResponse.PageNum = _ctx.IntegerValue("DescribeLiveRecordConfig.PageNum");
			describeLiveRecordConfigResponse.PageSize = _ctx.IntegerValue("DescribeLiveRecordConfig.PageSize");
			describeLiveRecordConfigResponse.Order = _ctx.StringValue("DescribeLiveRecordConfig.Order");
			describeLiveRecordConfigResponse.TotalNum = _ctx.IntegerValue("DescribeLiveRecordConfig.TotalNum");
			describeLiveRecordConfigResponse.TotalPage = _ctx.IntegerValue("DescribeLiveRecordConfig.TotalPage");

			List<DescribeLiveRecordConfigResponse.DescribeLiveRecordConfig_LiveAppRecord> describeLiveRecordConfigResponse_liveAppRecordList = new List<DescribeLiveRecordConfigResponse.DescribeLiveRecordConfig_LiveAppRecord>();
			for (int i = 0; i < _ctx.Length("DescribeLiveRecordConfig.LiveAppRecordList.Length"); i++) {
				DescribeLiveRecordConfigResponse.DescribeLiveRecordConfig_LiveAppRecord liveAppRecord = new DescribeLiveRecordConfigResponse.DescribeLiveRecordConfig_LiveAppRecord();
				liveAppRecord.DomainName = _ctx.StringValue("DescribeLiveRecordConfig.LiveAppRecordList["+ i +"].DomainName");
				liveAppRecord.AppName = _ctx.StringValue("DescribeLiveRecordConfig.LiveAppRecordList["+ i +"].AppName");
				liveAppRecord.StreamName = _ctx.StringValue("DescribeLiveRecordConfig.LiveAppRecordList["+ i +"].StreamName");
				liveAppRecord.OssEndpoint = _ctx.StringValue("DescribeLiveRecordConfig.LiveAppRecordList["+ i +"].OssEndpoint");
				liveAppRecord.OssBucket = _ctx.StringValue("DescribeLiveRecordConfig.LiveAppRecordList["+ i +"].OssBucket");
				liveAppRecord.CreateTime = _ctx.StringValue("DescribeLiveRecordConfig.LiveAppRecordList["+ i +"].CreateTime");
				liveAppRecord.StartTime = _ctx.StringValue("DescribeLiveRecordConfig.LiveAppRecordList["+ i +"].StartTime");
				liveAppRecord.EndTime = _ctx.StringValue("DescribeLiveRecordConfig.LiveAppRecordList["+ i +"].EndTime");
				liveAppRecord.OnDemond = _ctx.IntegerValue("DescribeLiveRecordConfig.LiveAppRecordList["+ i +"].OnDemond");

				List<DescribeLiveRecordConfigResponse.DescribeLiveRecordConfig_LiveAppRecord.DescribeLiveRecordConfig_RecordFormat> liveAppRecord_recordFormatList = new List<DescribeLiveRecordConfigResponse.DescribeLiveRecordConfig_LiveAppRecord.DescribeLiveRecordConfig_RecordFormat>();
				for (int j = 0; j < _ctx.Length("DescribeLiveRecordConfig.LiveAppRecordList["+ i +"].RecordFormatList.Length"); j++) {
					DescribeLiveRecordConfigResponse.DescribeLiveRecordConfig_LiveAppRecord.DescribeLiveRecordConfig_RecordFormat recordFormat = new DescribeLiveRecordConfigResponse.DescribeLiveRecordConfig_LiveAppRecord.DescribeLiveRecordConfig_RecordFormat();
					recordFormat.Format = _ctx.StringValue("DescribeLiveRecordConfig.LiveAppRecordList["+ i +"].RecordFormatList["+ j +"].Format");
					recordFormat.OssObjectPrefix = _ctx.StringValue("DescribeLiveRecordConfig.LiveAppRecordList["+ i +"].RecordFormatList["+ j +"].OssObjectPrefix");
					recordFormat.SliceOssObjectPrefix = _ctx.StringValue("DescribeLiveRecordConfig.LiveAppRecordList["+ i +"].RecordFormatList["+ j +"].SliceOssObjectPrefix");
					recordFormat.CycleDuration = _ctx.IntegerValue("DescribeLiveRecordConfig.LiveAppRecordList["+ i +"].RecordFormatList["+ j +"].CycleDuration");

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
