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
    public class DescribeLiveRecordConfigResponseUnmarshaller
    {
        public static DescribeLiveRecordConfigResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeLiveRecordConfigResponse describeLiveRecordConfigResponse = new DescribeLiveRecordConfigResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeLiveRecordConfig.RequestId"),
                PageNum = context.IntegerValue("DescribeLiveRecordConfig.PageNum"),
                PageSize = context.IntegerValue("DescribeLiveRecordConfig.PageSize"),
                Order = context.StringValue("DescribeLiveRecordConfig.Order"),
                TotalNum = context.IntegerValue("DescribeLiveRecordConfig.TotalNum"),
                TotalPage = context.IntegerValue("DescribeLiveRecordConfig.TotalPage")
            };
            List<DescribeLiveRecordConfigResponse.LiveAppRecord> liveAppRecordList = new List<DescribeLiveRecordConfigResponse.LiveAppRecord>();
			for (int i = 0; i < context.Length("DescribeLiveRecordConfig.LiveAppRecordList.Length"); i++) {
                DescribeLiveRecordConfigResponse.LiveAppRecord liveAppRecord = new DescribeLiveRecordConfigResponse.LiveAppRecord()
                {
                    DomainName = context.StringValue($"DescribeLiveRecordConfig.LiveAppRecordList[{i}].DomainName"),
                    AppName = context.StringValue($"DescribeLiveRecordConfig.LiveAppRecordList[{i}].AppName"),
                    OssEndpoint = context.StringValue($"DescribeLiveRecordConfig.LiveAppRecordList[{i}].OssEndpoint"),
                    OssBucket = context.StringValue($"DescribeLiveRecordConfig.LiveAppRecordList[{i}].OssBucket"),
                    CreateTime = context.StringValue($"DescribeLiveRecordConfig.LiveAppRecordList[{i}].CreateTime")
                };
                List<DescribeLiveRecordConfigResponse.LiveAppRecord.RecordFormat> recordFormatList = new List<DescribeLiveRecordConfigResponse.LiveAppRecord.RecordFormat>();
				for (int j = 0; j < context.Length($"DescribeLiveRecordConfig.LiveAppRecordList[{i}].RecordFormatList.Length"); j++) {
                    DescribeLiveRecordConfigResponse.LiveAppRecord.RecordFormat recordFormat = new DescribeLiveRecordConfigResponse.LiveAppRecord.RecordFormat()
                    {
                        Format = context.StringValue($"DescribeLiveRecordConfig.LiveAppRecordList[{i}].RecordFormatList[{j}].Format"),
                        OssObjectPrefix = context.StringValue($"DescribeLiveRecordConfig.LiveAppRecordList[{i}].RecordFormatList[{j}].OssObjectPrefix"),
                        SliceOssObjectPrefix = context.StringValue($"DescribeLiveRecordConfig.LiveAppRecordList[{i}].RecordFormatList[{j}].SliceOssObjectPrefix")
                    };
                    recordFormatList.Add(recordFormat);
				}
				liveAppRecord.RecordFormatList = recordFormatList;

				liveAppRecordList.Add(liveAppRecord);
			}
			describeLiveRecordConfigResponse.LiveAppRecordList = liveAppRecordList;
        
			return describeLiveRecordConfigResponse;
        }
    }
}