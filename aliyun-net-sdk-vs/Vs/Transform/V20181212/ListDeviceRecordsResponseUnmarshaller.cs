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
using Aliyun.Acs.vs.Model.V20181212;

namespace Aliyun.Acs.vs.Transform.V20181212
{
    public class ListDeviceRecordsResponseUnmarshaller
    {
        public static ListDeviceRecordsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDeviceRecordsResponse listDeviceRecordsResponse = new ListDeviceRecordsResponse();

			listDeviceRecordsResponse.HttpResponse = _ctx.HttpResponse;
			listDeviceRecordsResponse.RequestId = _ctx.StringValue("ListDeviceRecords.RequestId");
			listDeviceRecordsResponse.PageSize = _ctx.LongValue("ListDeviceRecords.PageSize");
			listDeviceRecordsResponse.PageNum = _ctx.LongValue("ListDeviceRecords.PageNum");
			listDeviceRecordsResponse.PageCount = _ctx.LongValue("ListDeviceRecords.PageCount");
			listDeviceRecordsResponse.TotalCount = _ctx.LongValue("ListDeviceRecords.TotalCount");

			List<ListDeviceRecordsResponse.ListDeviceRecords_Record> listDeviceRecordsResponse_records = new List<ListDeviceRecordsResponse.ListDeviceRecords_Record>();
			for (int i = 0; i < _ctx.Length("ListDeviceRecords.Records.Length"); i++) {
				ListDeviceRecordsResponse.ListDeviceRecords_Record record = new ListDeviceRecordsResponse.ListDeviceRecords_Record();
				record.Filename = _ctx.StringValue("ListDeviceRecords.Records["+ i +"].Filename");
				record.StartTime = _ctx.StringValue("ListDeviceRecords.Records["+ i +"].StartTime");
				record.EndTime = _ctx.StringValue("ListDeviceRecords.Records["+ i +"].EndTime");
				record.RecordType = _ctx.StringValue("ListDeviceRecords.Records["+ i +"].RecordType");
				record.FileSize = _ctx.LongValue("ListDeviceRecords.Records["+ i +"].FileSize");

				listDeviceRecordsResponse_records.Add(record);
			}
			listDeviceRecordsResponse.Records = listDeviceRecordsResponse_records;
        
			return listDeviceRecordsResponse;
        }
    }
}
