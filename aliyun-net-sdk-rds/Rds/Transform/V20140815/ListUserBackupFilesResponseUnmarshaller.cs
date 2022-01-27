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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class ListUserBackupFilesResponseUnmarshaller
    {
        public static ListUserBackupFilesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListUserBackupFilesResponse listUserBackupFilesResponse = new ListUserBackupFilesResponse();

			listUserBackupFilesResponse.HttpResponse = _ctx.HttpResponse;
			listUserBackupFilesResponse.RequestId = _ctx.StringValue("ListUserBackupFiles.RequestId");

			List<ListUserBackupFilesResponse.ListUserBackupFiles_RecordsItem> listUserBackupFilesResponse_records = new List<ListUserBackupFilesResponse.ListUserBackupFiles_RecordsItem>();
			for (int i = 0; i < _ctx.Length("ListUserBackupFiles.Records.Length"); i++) {
				ListUserBackupFilesResponse.ListUserBackupFiles_RecordsItem recordsItem = new ListUserBackupFilesResponse.ListUserBackupFiles_RecordsItem();
				recordsItem.Status = _ctx.StringValue("ListUserBackupFiles.Records["+ i +"].Status");
				recordsItem.CreationTime = _ctx.StringValue("ListUserBackupFiles.Records["+ i +"].CreationTime");
				recordsItem.FinishTime = _ctx.StringValue("ListUserBackupFiles.Records["+ i +"].FinishTime");
				recordsItem.Comment = _ctx.StringValue("ListUserBackupFiles.Records["+ i +"].Comment");
				recordsItem.OssFilePath = _ctx.StringValue("ListUserBackupFiles.Records["+ i +"].OssFilePath");
				recordsItem.OssBucket = _ctx.StringValue("ListUserBackupFiles.Records["+ i +"].OssBucket");
				recordsItem.ModificationTime = _ctx.StringValue("ListUserBackupFiles.Records["+ i +"].ModificationTime");
				recordsItem.OssFileSize = _ctx.LongValue("ListUserBackupFiles.Records["+ i +"].OssFileSize");
				recordsItem.OssFileName = _ctx.StringValue("ListUserBackupFiles.Records["+ i +"].OssFileName");
				recordsItem.EngineVersion = _ctx.StringValue("ListUserBackupFiles.Records["+ i +"].EngineVersion");
				recordsItem.BackupId = _ctx.StringValue("ListUserBackupFiles.Records["+ i +"].BackupId");
				recordsItem.RestoreSize = _ctx.StringValue("ListUserBackupFiles.Records["+ i +"].RestoreSize");
				recordsItem.ZoneId = _ctx.StringValue("ListUserBackupFiles.Records["+ i +"].ZoneId");
				recordsItem.Retention = _ctx.IntegerValue("ListUserBackupFiles.Records["+ i +"].Retention");
				recordsItem.DBInstanceId = _ctx.StringValue("ListUserBackupFiles.Records["+ i +"].DBInstanceId");
				recordsItem.Engine = _ctx.StringValue("ListUserBackupFiles.Records["+ i +"].Engine");
				recordsItem.OssUrl = _ctx.StringValue("ListUserBackupFiles.Records["+ i +"].OssUrl");
				recordsItem.OssFileMetaData = _ctx.StringValue("ListUserBackupFiles.Records["+ i +"].OssFileMetaData");
				recordsItem.BinlogInfo = _ctx.StringValue("ListUserBackupFiles.Records["+ i +"].BinlogInfo");
				recordsItem.Reason = _ctx.StringValue("ListUserBackupFiles.Records["+ i +"].Reason");

				listUserBackupFilesResponse_records.Add(recordsItem);
			}
			listUserBackupFilesResponse.Records = listUserBackupFilesResponse_records;
        
			return listUserBackupFilesResponse;
        }
    }
}
