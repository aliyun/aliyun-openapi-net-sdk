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
using Aliyun.Acs.Vcs.Model.V20200515;

namespace Aliyun.Acs.Vcs.Transform.V20200515
{
    public class ListCorpsResponseUnmarshaller
    {
        public static ListCorpsResponse Unmarshall(UnmarshallerContext context)
        {
			ListCorpsResponse listCorpsResponse = new ListCorpsResponse();

			listCorpsResponse.HttpResponse = context.HttpResponse;
			listCorpsResponse.Code = context.StringValue("ListCorps.Code");
			listCorpsResponse.Message = context.StringValue("ListCorps.Message");
			listCorpsResponse.RequestId = context.StringValue("ListCorps.RequestId");

			ListCorpsResponse.ListCorps_Data data = new ListCorpsResponse.ListCorps_Data();
			data.PageNumber = context.IntegerValue("ListCorps.Data.PageNumber");
			data.PageSize = context.IntegerValue("ListCorps.Data.PageSize");
			data.TotalCount = context.IntegerValue("ListCorps.Data.TotalCount");
			data.TotalPage = context.IntegerValue("ListCorps.Data.TotalPage");

			List<ListCorpsResponse.ListCorps_Data.ListCorps_Record> data_records = new List<ListCorpsResponse.ListCorps_Data.ListCorps_Record>();
			for (int i = 0; i < context.Length("ListCorps.Data.Records.Length"); i++) {
				ListCorpsResponse.ListCorps_Data.ListCorps_Record record = new ListCorpsResponse.ListCorps_Data.ListCorps_Record();
				record.CorpId = context.StringValue("ListCorps.Data.Records["+ i +"].CorpId");
				record.CorpName = context.StringValue("ListCorps.Data.Records["+ i +"].CorpName");
				record.Description = context.StringValue("ListCorps.Data.Records["+ i +"].Description");
				record.CreateDate = context.StringValue("ListCorps.Data.Records["+ i +"].CreateDate");
				record.ParentCorpId = context.StringValue("ListCorps.Data.Records["+ i +"].ParentCorpId");
				record.AppName = context.StringValue("ListCorps.Data.Records["+ i +"].AppName");
				record.DeviceCount = context.IntegerValue("ListCorps.Data.Records["+ i +"].DeviceCount");
				record.IsvSubId = context.StringValue("ListCorps.Data.Records["+ i +"].IsvSubId");
				record.AcuUsed = context.IntegerValue("ListCorps.Data.Records["+ i +"].AcuUsed");
				record.IconPath = context.StringValue("ListCorps.Data.Records["+ i +"].IconPath");

				data_records.Add(record);
			}
			data.Records = data_records;
			listCorpsResponse.Data = data;
        
			return listCorpsResponse;
        }
    }
}
