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
using Aliyun.Acs.retailcloud.Model.V20180313;

namespace Aliyun.Acs.retailcloud.Transform.V20180313
{
    public class GetRdsBackUpResponseUnmarshaller
    {
        public static GetRdsBackUpResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetRdsBackUpResponse getRdsBackUpResponse = new GetRdsBackUpResponse();

			getRdsBackUpResponse.HttpResponse = _ctx.HttpResponse;
			getRdsBackUpResponse.Code = _ctx.IntegerValue("GetRdsBackUp.Code");
			getRdsBackUpResponse.ErrMsg = _ctx.StringValue("GetRdsBackUp.ErrMsg");
			getRdsBackUpResponse.RequestId = _ctx.StringValue("GetRdsBackUp.RequestId");

			GetRdsBackUpResponse.GetRdsBackUp_Result result = new GetRdsBackUpResponse.GetRdsBackUp_Result();
			result.TotalRecordCount = _ctx.StringValue("GetRdsBackUp.Result.TotalRecordCount");
			result.PageNumber = _ctx.StringValue("GetRdsBackUp.Result.PageNumber");
			result.PageRecordCount = _ctx.StringValue("GetRdsBackUp.Result.PageRecordCount");
			result.TotalBackupSize = _ctx.LongValue("GetRdsBackUp.Result.TotalBackupSize");

			List<GetRdsBackUpResponse.GetRdsBackUp_Result.GetRdsBackUp_Backup> result_items = new List<GetRdsBackUpResponse.GetRdsBackUp_Result.GetRdsBackUp_Backup>();
			for (int i = 0; i < _ctx.Length("GetRdsBackUp.Result.Items.Length"); i++) {
				GetRdsBackUpResponse.GetRdsBackUp_Result.GetRdsBackUp_Backup backup = new GetRdsBackUpResponse.GetRdsBackUp_Result.GetRdsBackUp_Backup();
				backup.BackupId = _ctx.StringValue("GetRdsBackUp.Result.Items["+ i +"].BackupId");
				backup.DBInstanceId = _ctx.StringValue("GetRdsBackUp.Result.Items["+ i +"].DBInstanceId");
				backup.BackupStatus = _ctx.StringValue("GetRdsBackUp.Result.Items["+ i +"].BackupStatus");
				backup.BackupStartTime = _ctx.StringValue("GetRdsBackUp.Result.Items["+ i +"].BackupStartTime");
				backup.BackupEndTime = _ctx.StringValue("GetRdsBackUp.Result.Items["+ i +"].BackupEndTime");
				backup.BackupType = _ctx.StringValue("GetRdsBackUp.Result.Items["+ i +"].BackupType");
				backup.BackupMode = _ctx.StringValue("GetRdsBackUp.Result.Items["+ i +"].BackupMode");
				backup.BackupMethod = _ctx.StringValue("GetRdsBackUp.Result.Items["+ i +"].BackupMethod");
				backup.BackupLocation = _ctx.StringValue("GetRdsBackUp.Result.Items["+ i +"].BackupLocation");
				backup.BackupExtractionStatus = _ctx.StringValue("GetRdsBackUp.Result.Items["+ i +"].BackupExtractionStatus");
				backup.BackupScale = _ctx.StringValue("GetRdsBackUp.Result.Items["+ i +"].BackupScale");
				backup.BackupDBNames = _ctx.StringValue("GetRdsBackUp.Result.Items["+ i +"].BackupDBNames");
				backup.TotalBackupSize = _ctx.LongValue("GetRdsBackUp.Result.Items["+ i +"].TotalBackupSize");
				backup.BackupSize = _ctx.LongValue("GetRdsBackUp.Result.Items["+ i +"].BackupSize");
				backup.HostInstanceID = _ctx.StringValue("GetRdsBackUp.Result.Items["+ i +"].HostInstanceID");
				backup.StoreStatus = _ctx.StringValue("GetRdsBackUp.Result.Items["+ i +"].StoreStatus");
				backup.MetaStatus = _ctx.StringValue("GetRdsBackUp.Result.Items["+ i +"].MetaStatus");

				result_items.Add(backup);
			}
			result.Items = result_items;
			getRdsBackUpResponse.Result = result;
        
			return getRdsBackUpResponse;
        }
    }
}
