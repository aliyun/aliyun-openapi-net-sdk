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
using Aliyun.Acs.Dbs.Model.V20190306;

namespace Aliyun.Acs.Dbs.Transform.V20190306
{
    public class DescribeFullBackupSetResponseUnmarshaller
    {
        public static DescribeFullBackupSetResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeFullBackupSetResponse describeFullBackupSetResponse = new DescribeFullBackupSetResponse();

			describeFullBackupSetResponse.HttpResponse = _ctx.HttpResponse;
			describeFullBackupSetResponse.Success = _ctx.BooleanValue("DescribeFullBackupSet.Success");
			describeFullBackupSetResponse.ErrCode = _ctx.StringValue("DescribeFullBackupSet.ErrCode");
			describeFullBackupSetResponse.ErrMessage = _ctx.StringValue("DescribeFullBackupSet.ErrMessage");
			describeFullBackupSetResponse.HttpStatusCode = _ctx.IntegerValue("DescribeFullBackupSet.HttpStatusCode");
			describeFullBackupSetResponse.RequestId = _ctx.StringValue("DescribeFullBackupSet.RequestId");
			describeFullBackupSetResponse.BackupSetId = _ctx.StringValue("DescribeFullBackupSet.BackupSetId");
			describeFullBackupSetResponse.SourceEndpointIpPort = _ctx.StringValue("DescribeFullBackupSet.SourceEndpointIpPort");
			describeFullBackupSetResponse.StartTime = _ctx.LongValue("DescribeFullBackupSet.StartTime");
			describeFullBackupSetResponse.EndTime = _ctx.LongValue("DescribeFullBackupSet.EndTime");
			describeFullBackupSetResponse.BackupStatus = _ctx.StringValue("DescribeFullBackupSet.BackupStatus");
			describeFullBackupSetResponse.BackupSetExpiredTime = _ctx.LongValue("DescribeFullBackupSet.BackupSetExpiredTime");
			describeFullBackupSetResponse.BackupSize = _ctx.LongValue("DescribeFullBackupSet.BackupSize");
			describeFullBackupSetResponse.StorageMethod = _ctx.StringValue("DescribeFullBackupSet.StorageMethod");
			describeFullBackupSetResponse.ErrMessage1 = _ctx.StringValue("DescribeFullBackupSet.ErrMessage");
			describeFullBackupSetResponse.BackupObjects = _ctx.StringValue("DescribeFullBackupSet.BackupObjects");
			describeFullBackupSetResponse.CreateTime = _ctx.LongValue("DescribeFullBackupSet.CreateTime");
			describeFullBackupSetResponse.FinishTime = _ctx.LongValue("DescribeFullBackupSet.FinishTime");
        
			return describeFullBackupSetResponse;
        }
    }
}
